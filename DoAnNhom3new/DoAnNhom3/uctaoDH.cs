using DoAnNhom3.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using DoAnNhom3.QuanLy;

namespace DoAnNhom3
{
    public partial class uctaoDH : UserControl
    {
        public uctaoDH(List<GioHangItem> gioHang, string sdtKH)
        {
            InitializeComponent();
            this.gioHang = gioHang;
            this.soDienThoaiKH = sdtKH;
            LoadGioHang();
        }

        private void LoadGioHang()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = gioHang;

            lblTongTien.Text = gioHang.Sum(x => x.ThanhTien).ToString("N0") + " đ";
        }

        private void labelgiohang_Click(object sender, EventArgs e)
        {

        }



        private void btthemvaogiohang_Click(object sender, EventArgs e)
        {

        }


        private void btthanhtoanKH_Click(object sender, EventArgs e)
        {
            if (gioHang == null || gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống!");
                return;
            }

            string maHoaDon = "HD" + DateTime.Now.Ticks.ToString().Substring(10); // ví dụ HD34234
            string maNhanVien = "NV01"; // Giả sử mặc định, hoặc truyền từ đâu đó

            string queryHD = "INSERT INTO HoaDon VALUES (@MaHD, @NgayLap, @SDT, @MaNV)";
            SqlParameter[] paramHD = {
            new SqlParameter("@MaHD", maHoaDon),
            new SqlParameter("@NgayLap", DateTime.Now),
            new SqlParameter("@SDT", soDienThoaiKH),
            new SqlParameter("@MaNV", maNhanVien)
            };
            Database.Execute(queryHD, paramHD); // hàm này bạn cần viết

            foreach (var item in gioHang)
            {
                string queryCT = "INSERT INTO ChiTietHoaDon VALUES (@MaHD, @MaMon, @DonGia, @SoLuong, @ThanhTien)";
                SqlParameter[] paramCT = {
                new SqlParameter("@MaHD", maHoaDon),
                new SqlParameter("@MaMon", item.MaMon),
                new SqlParameter("@DonGia", item.DonGia),
                new SqlParameter("@SoLuong", item.SoLuong),
                new SqlParameter("@ThanhTien", item.ThanhTien)
            };
                Database.Execute(queryCT, paramCT);
            }

            MessageBox.Show("Thanh toán thành công!");

            gioHang.Clear();
            LoadGioHang(); // reload lại giỏ hàng sau khi thanh toán
        }


        private List<GioHangItem> gioHang { get; set; }
        private string soDienThoaiKH { get; set; }
    }

}
