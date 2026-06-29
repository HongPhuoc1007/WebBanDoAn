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
    public partial class KhoNLieu : UserControl
    {
        private Menu formMenuCha;
        public KhoNLieu(Menu cha)
        {
            InitializeComponent();
            LoadData();
            formMenuCha = cha;
        }
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM NguyenLieu";
                DataTable dt = Database.GetData(query); // Gọi trực tiếp từ class Database
                dgvKhoNLieu.DataSource = dt;          // Giả sử bạn có DataGridView tên là dataGridView1
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formMenuCha.panelMain.Controls.Clear();
        }

        private void dgvKhoNLieu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
