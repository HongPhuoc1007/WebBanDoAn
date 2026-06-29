using DoAnNhom3.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnNhom3
{
    public partial class HoaDon : UserControl
    {
        public event Action<List<MonAn>, string> DonHangDatThanhCong;
        public event Action HuyDonClicked;

        private List<MonAn> danhSachMon = new();
        private readonly string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline1;Integrated Security=True";
        private string sdtKhach = "";
        private string tenKhach = "Khách lẻ";
        private string diaChi = "Không rõ";
        private decimal tongTien = 0;
        private string maHoaDon = "";

        public HoaDon()
        {
            InitializeComponent();
            Load += HoaDon_Load;
            btnHuyDon.Click += (s, e) => HuyDonClicked?.Invoke();
            btdathang.Click += async (s, e) => await DatHang();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            txbmahoadon.Text = "HD" + DateTime.Now.Ticks.ToString().Substring(10);
            txbngaylaphoadon.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        public void SetData(List<MonAn> dsMon, string maHD, DateTime ngayLap, string tenKH, string sdtKH, string diaChiKH)
        {
            danhSachMon = dsMon;
            this.maHoaDon = maHD;
            this.sdtKhach = sdtKH;
            this.tenKhach = tenKH;
            this.diaChi = diaChiKH;

            txbmahoadon.Text = maHD;
            txbngaylaphoadon.Text = ngayLap.ToString("dd/MM/yyyy");
            txbsdtkh.Text = sdtKH;

            flpMonAnHoaDon.Controls.Clear();
            tongTien = 0;

            foreach (var mon in dsMon)
            {
                tongTien += mon.GiaTien * mon.SoLuong;

                Panel panel = new()
                {
                    Width = 500,
                    Height = 70,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5)
                };

                PictureBox pic = new()
                {
                    Width = 60,
                    Height = 60,
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Location = new Point(5, 5)
                };

                string imgPath = Path.Combine(Application.StartupPath, "HinhAnh", mon.HinhAnh);
                if (File.Exists(imgPath)) pic.Image = Image.FromFile(imgPath);

                Label lblTenMon = new() { Text = mon.TenMon, AutoSize = true, Location = new Point(75, 10) };
                Label lblDonGia = new() { Text = $"Đơn giá: {mon.GiaTien:N0} đ", AutoSize = true, Location = new Point(75, 30) };
                Label lblSoLuong = new() { Text = $"Số lượng: {mon.SoLuong}", AutoSize = true, Location = new Point(250, 30) };
                Label lblThanhTien = new() { Text = $"Thành tiền: {(mon.GiaTien * mon.SoLuong):N0} đ", AutoSize = true, Location = new Point(75, 50) };

                panel.Controls.Add(pic);
                panel.Controls.Add(lblTenMon);
                panel.Controls.Add(lblDonGia);
                panel.Controls.Add(lblSoLuong);
                panel.Controls.Add(lblThanhTien);

                flpMonAnHoaDon.Controls.Add(panel);
            }

            tbxtongtien.Text = tongTien.ToString("N0") + " đ";
        }

        private async Task DatHang()
        {
            try
            {
                await ThemBaoCaoNgayAsync();
                DonHangDatThanhCong?.Invoke(danhSachMon, txbsdtkh.Text);

                DialogResult r = MessageBox.Show("Bạn có muốn in hóa đơn?", "Xác nhận", MessageBoxButtons.YesNo);
                if (r == DialogResult.Yes)
                {
                    InHoaDon();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đặt hàng hoặc in hóa đơn: " + ex.Message);
            }
        }

        private async Task ThemBaoCaoNgayAsync()
        {
            using SqlConnection conn = new(connectionString);
            await conn.OpenAsync();

            foreach (var mon in danhSachMon)
            {
                string maBCN = "BCN" + DateTime.Now.Ticks.ToString().Substring(10);

                string query = @"
                    INSERT INTO BaoCaoNgay (MaBaoCaoNgay, Ngay, MaMon, SoLuong, DoanhThuNgay)
                    VALUES (@MaBaoCaoNgay, @Ngay, @MaMon, @SoLuong, @DoanhThuNgay)";

                using SqlCommand cmd = new(query, conn);
                cmd.Parameters.AddWithValue("@MaBaoCaoNgay", maBCN);
                cmd.Parameters.AddWithValue("@Ngay", DateTime.Now.Date);
                cmd.Parameters.AddWithValue("@MaMon", mon.MaMon);
                cmd.Parameters.AddWithValue("@SoLuong", mon.SoLuong);
                cmd.Parameters.AddWithValue("@DoanhThuNgay", mon.GiaTien * mon.SoLuong);

                await cmd.ExecuteNonQueryAsync();
            }
        }

        public void InHoaDon()
        {
            PrintDocument printDoc = new();
            printDoc.PrintPage += PrintDocument_PrintPage;

            PrintDialog pd = new() { Document = printDoc };
            if (pd.ShowDialog() == DialogResult.OK)
                printDoc.Print();
        }

        private void PrintDocument_PrintPage(object sender, PrintPageEventArgs e)
        {
            Font font = new Font("Segoe UI", 11);
            Font boldFont = new Font("Segoe UI", 11, FontStyle.Bold);
            Font titleFont = new Font("Segoe UI", 14, FontStyle.Bold);

            float x = 40, y = 20;
            float tableX = x;
            float tableY = 0;

            // Header thông tin nhà hàng
            e.Graphics.DrawString("Peppa Food", titleFont, Brushes.Black, x, y);
            y += 25;
            e.Graphics.DrawString("Địa chỉ: 218 Lĩnh Nam", font, Brushes.Black, x, y);
            y += 20;
            e.Graphics.DrawString("Điện thoại: 0910010236", font, Brushes.Black, x, y);
            y += 30;

            e.Graphics.DrawString($"HÓA ĐƠN - Ngày: {DateTime.Now:dd/MM/yyyy}", titleFont, Brushes.Black, x + 150, y);
            y += 40;

            // Thông tin khách hàng
            e.Graphics.DrawString($"Mã hóa đơn: {maHoaDon}", font, Brushes.Black, x, y); y += 20;
            e.Graphics.DrawString($"Khách hàng: {tenKhach}", font, Brushes.Black, x, y); y += 20;
            e.Graphics.DrawString($"SĐT: {sdtKhach}", font, Brushes.Black, x, y); y += 20;
            e.Graphics.DrawString($"Địa chỉ: {diaChi}", font, Brushes.Black, x, y); y += 30;

            // Kích thước cột
            int[] columnWidths = { 40, 200, 50, 100, 120 }; // STT, Tên, SL, Đơn giá, Thành tiền
            int rowHeight = 30;

            // Kẻ header bảng
            tableY = y;
            string[] headers = { "STT", "Tên món ăn", "SL", "Đơn giá", "Thành tiền" };
            float colX = x;

            for (int i = 0; i < headers.Length; i++)
            {
                Rectangle rect = new Rectangle((int)colX, (int)tableY, columnWidths[i], rowHeight);
                e.Graphics.DrawRectangle(Pens.Black, rect);
                e.Graphics.DrawString(headers[i], boldFont, Brushes.Black, rect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                colX += columnWidths[i];
            }

            // In từng dòng dữ liệu
            int stt = 1;
            y += rowHeight;

            foreach (var mon in danhSachMon)
            {
                colX = x;

                string[] row = {
            stt.ToString(),
            mon.TenMon,
            mon.SoLuong.ToString(),
            $"{mon.GiaTien:N0}",
            $"{mon.GiaTien * mon.SoLuong:N0}"
        };

                for (int i = 0; i < row.Length; i++)
                {
                    Rectangle rect = new Rectangle((int)colX, (int)y, columnWidths[i], rowHeight);
                    e.Graphics.DrawRectangle(Pens.Black, rect);
                    e.Graphics.DrawString(row[i], font, Brushes.Black, rect, new StringFormat { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center });
                    colX += columnWidths[i];
                }

                y += rowHeight;
                stt++;
            }

            y += 20;
            e.Graphics.DrawString($"Tổng tiền: {tongTien:N0} đ", boldFont, Brushes.Black, x + 350, y);
        }



        // Properties để lấy dữ liệu từ ngoài
        public string MaHoaDon => txbmahoadon.Text;
        public DateTime NgayLap => DateTime.Now;
        public string SoDienThoaiKH => txbsdtkh.Text;
        public decimal TongTien => decimal.TryParse(tbxtongtien.Text.Replace(",", "").Replace(" đ", ""), out decimal tong) ? tong : 0;
        public List<MonAn> DanhSachMon => danhSachMon;
    }
}
