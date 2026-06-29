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
using DoAnNhom3.QuanLy;

namespace DoAnNhom3
{
    public partial class ucXemLSDonHang : UserControl
    {
        //private string connectionString = "Data Source=(localdb)\\mssqllocaldb;Initial Catalog=QuanLyBanHangOnline1;Integrated Security=True;Trust Server Certificate=True";
        public string sdt { get; set; }
        public ucXemLSDonHang(string sdt)
        {
            this.sdt = sdt;
            InitializeComponent();
            LoadDonHang();
        }

        private void LoadDonHang()
        {
            string sdtKH = this.sdt;

            string query = @"
            SELECT 
            HD.MaHoaDon,
            HD.NgayLap,
            CT.MaMon,
            MA.TenMon,
            CT.DonGia,
            CT.SoLuong,
            CT.ThanhTien
            FROM HoaDon HD
            JOIN ChiTietHoaDon CT ON HD.MaHoaDon = CT.MaHoaDon
            JOIN MonAn MA ON CT.MaMon = MA.MaMon
            WHERE HD.SoDienThoaiKH = @SoDienThoaiKH
            ORDER BY HD.NgayLap DESC";

            SqlParameter[] parameters = new SqlParameter[]
            {
        new SqlParameter("@SoDienThoaiKH", sdtKH)
            };

            DataTable dt = Database.GetData(query, parameters);
            dgvLichSu.DataSource = dt;

            // Tính tổng tiền đã mua (nếu cần)
            decimal tong = 0;
            foreach (DataRow row in dt.Rows)
            {
                tong += Convert.ToDecimal(row["ThanhTien"]);
            }

            lblTongTien.Text = "Tổng tiền đã mua: " + tong.ToString("N0") + " đ";
        }

        private void dgvDonHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
