using DoAnNhom3.Model;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace DoAnNhom3
{
    public partial class NhanVien : Form
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline1;Integrated Security=True;Trust Server Certificate=True";
        private MonAn monAnDangChon;

        private ucDonHang ucDonHangControl;
        private HoaDon hoaDonControl;
        private QuanLiDonHang ucQLDonHangControl;

        public NhanVien()
        {
            InitializeComponent();
            Load += NhanVien_Load;

            // Gán sự kiện click cho các nút sidebar
            bttaodonhang.Click += bttaodonhang_Click;
            btqldonhang.Click += btqldonhang_Click;
            btthongke.Click += btthongke_Click;
            btqldanhmuc.Click += btqldanhmuc_Click;
            btDangXuat.Click += btDangXuat_Click;

            dgvmenuNV.SelectionChanged += dgvmenuNV_SelectionChanged;
        }

        private void NhanVien_Load(object sender, EventArgs e)
        {
            LoadMonAn();
            QuayVeMenu();
        }

        private void LoadMonAn()
        {
            string query = @"SELECT m.MaMon, m.TenMon, m.GiaTien, d.SoLuong, m.HinhAnh 
                             FROM MonAn m 
                             LEFT JOIN DanhMuc_MonAn d ON m.MaMon = d.MaMon";
            try
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    dgvmenuNV.DataSource = dt;
                    dgvmenuNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                    cbbTenmonmenuNV.Items.Clear();
                    foreach (DataRow row in dt.Rows)
                    {
                        string tenMon = row["TenMon"].ToString();
                        if (!cbbTenmonmenuNV.Items.Contains(tenMon))
                            cbbTenmonmenuNV.Items.Add(tenMon);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi tải dữ liệu món ăn: " + ex.Message);
            }
        }

        private void dgvmenuNV_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvmenuNV.SelectedRows.Count > 0)
            {
                var row = dgvmenuNV.SelectedRows[0];
                monAnDangChon = new MonAn
                {
                    MaMon = row.Cells["MaMon"].Value.ToString(),
                    TenMon = row.Cells["TenMon"].Value.ToString(),
                    GiaTien = Convert.ToDecimal(row.Cells["GiaTien"].Value),
                    SoLuong = row.Cells["SoLuong"].Value != DBNull.Value ? Convert.ToInt32(row.Cells["SoLuong"].Value) : 1,
                    HinhAnh = row.Cells["HinhAnh"].Value.ToString()
                };

                cbbTenmonmenuNV.Text = monAnDangChon.TenMon;
                txbdongiamenuNV.Text = monAnDangChon.GiaTien.ToString("N0") + " đ";
                txbsoluongmenuNV.Text = monAnDangChon.SoLuong.ToString();
            }
        }

        private void bttaodonhang_Click(object sender, EventArgs e)
        {
            if (monAnDangChon == null)
            {
                MessageBox.Show("Vui lòng chọn món ăn!");
                return;
            }

            if (ucDonHangControl == null)
            {
                ucDonHangControl = new ucDonHang { Dock = DockStyle.Fill };
                ucDonHangControl.QuayVeClicked += QuayVeMenu;
                ucDonHangControl.ThanhToanClicked += MoHoaDon;
            }

            ucDonHangControl.AddItem(monAnDangChon);
            ChuyenGiaoDien(ucDonHangControl);
        }

        private void btqldonhang_Click(object sender, EventArgs e)
        {
            ucQLDonHangControl ??= new QuanLiDonHang { Dock = DockStyle.Fill };
            ucQLDonHangControl.Reload();
            ChuyenGiaoDien(ucQLDonHangControl);
        }

        private void btthongke_Click(object sender, EventArgs e)
        {
            var ucThongKe = new ucBaoCaoThongKe { Dock = DockStyle.Fill };
            ChuyenGiaoDien(ucThongKe);
        }




            private void btqldanhmuc_Click(object sender, EventArgs e)
        {
            LoadMonAn();
            panelMain.Controls.Clear();
            panelMain.Controls.Add(panelContent);
            panelMain.Controls.Add(panelSideBar);
        }
        


        private void MoHoaDon(List<MonAn> dsMon)
        {
            string maHD = "HD" + DateTime.Now.Ticks.ToString().Substring(10);
            hoaDonControl = new HoaDon { Dock = DockStyle.Fill };
            hoaDonControl.SetData(dsMon, maHD, DateTime.Now, "Khách lẻ", "0900000001", "Không rõ");

            hoaDonControl.DonHangDatThanhCong += async (monList, sdt) =>
            {
                await LuuHoaDonAsync(monList, sdt);
                ucQLDonHangControl?.Reload();
                QuayVeMenu();
            };

            hoaDonControl.HuyDonClicked += QuayVeMenu;
            ChuyenGiaoDien(hoaDonControl);
        }

        private async System.Threading.Tasks.Task LuuHoaDonAsync(List<MonAn> danhSachMon, string sdtKH)
        {
            string maHD = "HD" + DateTime.Now.Ticks.ToString().Substring(10);
            string insertHD = "INSERT INTO HoaDon (MaHoaDon, NgayLap, SoDienThoaiKH, MaNhanVien) VALUES (@MaHD, @Ngay, @SDT, @MaNV)";
            string insertCT = "INSERT INTO ChiTietHoaDon (MaHoaDon, MaMon, DonGia, SoLuong, ThanhTien) VALUES (@MaHD, @MaMon, @DonGia, @SoLuong, @ThanhTien)";

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                await conn.OpenAsync();
                SqlTransaction tran = conn.BeginTransaction();

                try
                {
                    SqlCommand cmdHD = new SqlCommand(insertHD, conn, tran);
                    cmdHD.Parameters.AddWithValue("@MaHD", maHD);
                    cmdHD.Parameters.AddWithValue("@Ngay", DateTime.Now);
                    cmdHD.Parameters.AddWithValue("@SDT", sdtKH);
                    cmdHD.Parameters.AddWithValue("@MaNV", "NV01");
                    await cmdHD.ExecuteNonQueryAsync();

                    foreach (var mon in danhSachMon)
                    {
                        SqlCommand cmdCT = new SqlCommand(insertCT, conn, tran);
                        cmdCT.Parameters.AddWithValue("@MaHD", maHD);
                        cmdCT.Parameters.AddWithValue("@MaMon", mon.MaMon);
                        cmdCT.Parameters.AddWithValue("@DonGia", mon.GiaTien);
                        cmdCT.Parameters.AddWithValue("@SoLuong", mon.SoLuong);
                        cmdCT.Parameters.AddWithValue("@ThanhTien", mon.SoLuong * mon.GiaTien);
                        await cmdCT.ExecuteNonQueryAsync();
                    }

                    tran.Commit();
                    MessageBox.Show("Đặt hàng thành công!");
                }
                catch (Exception ex)
                {
                    tran.Rollback();
                    MessageBox.Show("Lỗi lưu hóa đơn: " + ex.Message);
                }
            }
        }

        private void btDangXuat_Click(object sender, EventArgs e)
        {
            this.Close();
            new DangNhap().Show();
        }

        private void ChuyenGiaoDien(UserControl uc)
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(uc);
            panelMain.Controls.Add(panelSideBar);
        }

        private void QuayVeMenu()
        {
            panelMain.Controls.Clear();
            panelMain.Controls.Add(panelContent);
            panelMain.Controls.Add(panelSideBar);
        }
    }
}
