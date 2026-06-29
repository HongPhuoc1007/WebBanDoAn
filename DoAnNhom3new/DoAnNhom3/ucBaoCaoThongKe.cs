using System;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using OfficeOpenXml;
using System.IO;
using System.Windows.Forms.DataVisualization.Charting;
using static OfficeOpenXml.ExcelPackage;



namespace DoAnNhom3
{
    public partial class ucBaoCaoThongKe : UserControl
    {
        private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline1;Integrated Security=True";

        public event Action QuayVeClicked;

        public ucBaoCaoThongKe()
        {
            InitializeComponent();
            btnTaiLai.Click += (s, e) => btnThongKe_Click(null, null);
            btnXoaBaoCao.Click += BtnXoaBaoCao_Click;
            btnXuatExcel.Click += BtnXuatExcel_Click;
            btnTopMon.Click += BtnTopMon_Click;
        }

        private void BtnXoaBaoCao_Click(object sender, EventArgs e)
        {
            if (dgvBaoCao.SelectedRows.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn ít nhất một dòng để xóa.", "Thông báo");
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc muốn xóa các báo cáo đã chọn?", "Xác nhận", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(connectionString))
                {
                    conn.Open();
                    foreach (DataGridViewRow row in dgvBaoCao.SelectedRows)
                    {
                        if (row.Cells["MaBaoCaoNgay"].Value != null)
                        {
                            string ma = row.Cells["MaBaoCaoNgay"].Value.ToString();
                            SqlCommand cmd = new SqlCommand("DELETE FROM BaoCaoNgay WHERE MaBaoCaoNgay = @ma", conn);
                            cmd.Parameters.AddWithValue("@ma", ma);
                            cmd.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show("Đã xóa thành công báo cáo đã chọn!", "Thông báo");
                btnThongKe_Click(null, null);  // làm mới lại bảng
            }
        }


        private void BtnXuatExcel_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    // Dòng này rất quan trọng để tránh lỗi License!
                    ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

                    using (ExcelPackage pck = new ExcelPackage())
                    {
                        var ws = pck.Workbook.Worksheets.Add("Báo cáo");

                        // Header
                        for (int i = 0; i < dgvBaoCao.Columns.Count; i++)
                        {
                            ws.Cells[1, i + 1].Value = dgvBaoCao.Columns[i].HeaderText;
                        }

                        // Rows
                        for (int i = 0; i < dgvBaoCao.Rows.Count; i++)
                        {
                            for (int j = 0; j < dgvBaoCao.Columns.Count; j++)
                            {
                                ws.Cells[i + 2, j + 1].Value = dgvBaoCao.Rows[i].Cells[j].Value?.ToString();
                            }
                        }

                        File.WriteAllBytes(sfd.FileName, pck.GetAsByteArray());
                        MessageBox.Show("Xuất Excel thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }



        private void btnThongKe_Click(object sender, EventArgs e)
        {
            DateTime ngayChon = dtpNgayThongKe.Value.Date;

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();

                string thongKeQuery = @"
    SELECT 
        CONVERT(date, h.NgayLap) AS Ngay,
        c.MaMon,
        SUM(c.SoLuong) AS SoLuong,
        SUM(c.ThanhTien) AS DoanhThuNgay
    FROM HoaDon h
    JOIN ChiTietHoaDon c ON h.MaHoaDon = c.MaHoaDon
    JOIN MonAn m ON c.MaMon = m.MaMon
    WHERE CONVERT(date, h.NgayLap) = @Ngay
    GROUP BY CONVERT(date, h.NgayLap), c.MaMon";


                SqlCommand cmd = new SqlCommand(thongKeQuery, conn);
                cmd.Parameters.AddWithValue("@Ngay", ngayChon);
                DataTable dt = new DataTable();
                new SqlDataAdapter(cmd).Fill(dt);

                foreach (DataRow row in dt.Rows)
                {
                    SqlCommand check = new SqlCommand("SELECT COUNT(*) FROM BaoCaoNgay WHERE Ngay = @Ngay AND MaMon = @MaMon", conn);
                    check.Parameters.AddWithValue("@Ngay", row["Ngay"]);
                    check.Parameters.AddWithValue("@MaMon", row["MaMon"]);
                    int exists = (int)check.ExecuteScalar();

                    if (exists == 0)
                    {
                        SqlCommand insert = new SqlCommand(@"INSERT INTO BaoCaoNgay
                            (MaBaoCaoNgay, Ngay, MaMon, SoLuong, DoanhThuNgay)
                            VALUES (@Ma, @Ngay, @MaMon, @SL, @DT)", conn);
                        insert.Parameters.AddWithValue("@Ma", Guid.NewGuid().ToString());
                        insert.Parameters.AddWithValue("@Ngay", row["Ngay"]);
                        insert.Parameters.AddWithValue("@MaMon", row["MaMon"]);
                        //insert.Parameters.AddWithValue("@DVT", row["DonViTinh"]);
                        insert.Parameters.AddWithValue("@SL", row["SoLuong"]);
                        insert.Parameters.AddWithValue("@DT", row["DoanhThuNgay"]);
                        insert.ExecuteNonQuery();
                    }
                }

                SqlCommand show = new SqlCommand("SELECT * FROM BaoCaoNgay WHERE Ngay = @Ngay", conn);
                show.Parameters.AddWithValue("@Ngay", ngayChon);
                DataTable dtShow = new DataTable();
                new SqlDataAdapter(show).Fill(dtShow);
                dgvBaoCao.DataSource = dtShow;

                dgvBaoCao.Columns["Ngay"].DefaultCellStyle.Format = "dd/MM/yyyy";
                dgvBaoCao.Columns["DoanhThuNgay"].DefaultCellStyle.Format = "N0";

                decimal tong = 0;
                foreach (DataRow row in dtShow.Rows)
                {
                    if (row["DoanhThuNgay"] != DBNull.Value)
                        tong += Convert.ToDecimal(row["DoanhThuNgay"]);
                }
                lblTongDoanhThu.Text = "Tổng doanh thu: " + tong.ToString("N0") + " VNĐ";
            }
        }

        private void BtnTopMon_Click(object sender, EventArgs e)
        {
            DateTime ngay = dtpNgayThongKe.Value.Date;
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand(@"
            SELECT TOP 3 m.TenMon, SUM(c.SoLuong) AS SoLuongBan
            FROM HoaDon h
            JOIN ChiTietHoaDon c ON h.MaHoaDon = c.MaHoaDon
            JOIN MonAn m ON c.MaMon = m.MaMon
            WHERE CONVERT(date, h.NgayLap) = @Ngay
            GROUP BY m.TenMon
            ORDER BY SoLuongBan DESC", conn);

                cmd.Parameters.AddWithValue("@Ngay", ngay);
                SqlDataReader reader = cmd.ExecuteReader();

                chartTop3Mon.Series["Top3"].Points.Clear();
                while (reader.Read())
                {
                    string tenMon = reader.GetString(0);
                    int soLuong = reader.GetInt32(1);
                    chartTop3Mon.Series["Top3"].Points.AddXY(tenMon, soLuong);
                }
                reader.Close();
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            QuayVeClicked?.Invoke();
        }
    }
}
