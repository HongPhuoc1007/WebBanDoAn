using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNhom3.QuanLy;

namespace DoAnNhom3
{
    public partial class QuanLiKhachHang : UserControl
    {
        private Menu formMenuCha;
        public QuanLiKhachHang(Menu cha)
        {
            InitializeComponent();
            formMenuCha = cha;
            LoadData();
        }

        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM KhachHang";
                DataTable dt = Database.GetData(query); // Gọi trực tiếp từ class Database
                dgvkhachhang.DataSource = dt;          // Giả sử bạn có DataGridView tên là dataGridView1
                string query1 = "SELECT * FROM TaiKhoan";
                DataTable dt1 = Database.GetData(query1);
                dgvTaiKhoan.DataSource = dt1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            formMenuCha.panelMain.Controls.Clear();
        }
    }
}
