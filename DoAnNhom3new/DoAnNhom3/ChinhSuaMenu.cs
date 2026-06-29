using DoAnNhom3.QuanLy;
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


namespace DoAnNhom3
{
    public partial class ChinhSuaMenu : UserControl
    {
        public ChinhSuaMenu()
        {
            InitializeComponent();
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM MonAn";
                DataTable dt = Database.GetData(query); // Gọi trực tiếp từ class Database
                dataGridView1.DataSource = dt;          // Giả sử bạn có DataGridView tên là dataGridView1
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO MonAn VALUES (@MaMon, @TenMon, @GiaTien, 'banner.jpg')";
            SqlParameter[] parameters = {
            new SqlParameter("@MaMon", textMaMon.Text),
            new SqlParameter("@TenMon", textTenMon.Text),
            new SqlParameter("@GiaTien",  textGiaTien.Text),
            //new SqlParameter("@HinhAnh", null),
            };
            int result = Database.Execute(query, parameters);
            if (result > 0) MessageBox.Show("Thêm thành công!");
            LoadData();
        }
        private void dgvdsnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                textMaMon.Text = dataGridView1.Rows[index].Cells[0].Value.ToString();
                textTenMon.Text = dataGridView1.Rows[index].Cells[1].Value.ToString();
                textGiaTien.Text = dataGridView1.Rows[index].Cells[2].Value.ToString();

            }
        }

        private void btSuaNV_Click(object sender, EventArgs e)
        {
            string query = "UPDATE MonAn SET TenMon=@TenMon, GiaTien=@GiaTien WHERE MaMon=@MaMon";
            SqlParameter[] parameters = {
            new SqlParameter("@MaMon", textMaMon.Text),
            new SqlParameter("@TenMon", textTenMon.Text),
            new SqlParameter("@GiaTien", textGiaTien.Text),
            //new SqlParameter("@DiaChi", txbdiachi.Text),
            };
            int result = Database.Execute(query, parameters);
            if (result > 0) MessageBox.Show("Sửa thành công!");
            LoadData();
        }

        private void btXoaNV_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM MonAn WHERE MaMon=@MaMon";
            SqlParameter[] parameters = {
             new SqlParameter("@MaMon", textMaMon.Text),
            };
            int result = Database.Execute(query, parameters);
            if (result > 0) MessageBox.Show("Xóa thành công!");
            LoadData();
        }
    }
}
