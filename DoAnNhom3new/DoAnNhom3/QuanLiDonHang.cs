using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;
using OfficeOpenXml;
using System.IO;
using static OfficeOpenXml.ExcelPackage;


namespace DoAnNhom3
{
    public partial class QuanLiDonHang : UserControl
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline1;Integrated Security=True;Trust Server Certificate=True";

        public QuanLiDonHang()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            btnTaiLai.Click += BtnTaiLai_Click;
            btnSua.Click += BtnSua_Click;
            btnXoa.Click += BtnXoa_Click;
            btnExcel.Click += BtnExcel_Click;
        }

        private void BtnXoa_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                string maHoaDon = dgvDonHang.SelectedRows[0].Cells["MaHoaDon"].Value.ToString();
                DialogResult result = MessageBox.Show("Xác nhận xóa hóa đơn?", "Xóa", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(connectionString))
                    {
                        conn.Open();
                        SqlCommand cmd1 = new SqlCommand("DELETE FROM ChiTietHoaDon WHERE MaHoaDon = @ma", conn);
                        cmd1.Parameters.AddWithValue("@ma", maHoaDon);
                        cmd1.ExecuteNonQuery();

                        SqlCommand cmd2 = new SqlCommand("DELETE FROM HoaDon WHERE MaHoaDon = @ma", conn);
                        cmd2.Parameters.AddWithValue("@ma", maHoaDon);
                        cmd2.ExecuteNonQuery();
                    }
                    LoadDanhSachDonHang();
                }
            }
        }

        private void BtnSua_Click(object sender, EventArgs e)
        {
            if (dgvDonHang.SelectedRows.Count > 0)
            {
                var row = dgvDonHang.SelectedRows[0];
                string maHoaDon = row.Cells["MaHoaDon"].Value.ToString();
                string maMon = row.Cells["MaMon"].Value.ToString();
                int soLuongMoi = Convert.ToInt32(Microsoft.VisualBasic.Interaction.InputBox(
                    "Nhập số lượng mới:", "Sửa số lượng", row.Cells["SoLuong"].Value.ToString()));
                decimal donGia = Convert.ToDecimal(row.Cells["DonGia"].Value);
                decimal thanhTien = soLuongMoi * donGia;

                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    string query = @"UPDATE ChiTietHoaDon 
                                     SET SoLuong = @sl, ThanhTien = @tt 
                                     WHERE MaHoaDon = @mahd AND MaMon = @mamon";
                    SqlCommand cmd = new SqlCommand(query, conn);
                    cmd.Parameters.AddWithValue("@sl", soLuongMoi);
                    cmd.Parameters.AddWithValue("@tt", thanhTien);
                    cmd.Parameters.AddWithValue("@mahd", maHoaDon);
                    cmd.Parameters.AddWithValue("@mamon", maMon);
                    cmd.ExecuteNonQuery();
                }

                LoadDanhSachDonHang();
            }
        }

        private void BtnExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    OfficeOpenXml.ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
                    using (ExcelPackage pck = new ExcelPackage())
                    {
                        ExcelWorksheet ws = pck.Workbook.Worksheets.Add("DonHang");
                        for (int i = 0; i < dgvDonHang.Columns.Count; i++)
                        {
                            ws.Cells[1, i + 1].Value = dgvDonHang.Columns[i].HeaderText;
                        }

                        for (int i = 0; i < dgvDonHang.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvDonHang.Columns.Count; j++)
                            {
                                ws.Cells[i + 2, j + 1].Value = dgvDonHang.Rows[i].Cells[j].Value;
                            }
                        }

                        File.WriteAllBytes(sfd.FileName, pck.GetAsByteArray());
                        MessageBox.Show("Xuất Excel thành công!", "Thông báo");
                    }
                }
            }
        }

        private void BtnTaiLai_Click(object sender, EventArgs e)
        {
            LoadDanhSachDonHang();
        }

        private void LoadDanhSachDonHang()
        {
            string query = @"
                SELECT h.MaHoaDon, h.NgayLap, h.SoDienThoaiKH, h.MaNhanVien,
                       c.MaMon, m.TenMon, c.SoLuong, c.DonGia, c.ThanhTien
                FROM HoaDon h
                JOIN ChiTietHoaDon c ON h.MaHoaDon = c.MaHoaDon
                JOIN MonAn m ON c.MaMon = m.MaMon
                ORDER BY h.NgayLap DESC";

            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, conn))
            {
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                dgvDonHang.DataSource = dt;
                dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            }
        }

        public void Reload()
        {
            LoadDanhSachDonHang();
        }
    }
}
