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
    public partial class ThongTinNVien : UserControl
    {
        private Menu formMenuCha;
        public ThongTinNVien(Menu cha)
        {
            InitializeComponent();
            LoadData();
            formMenuCha = cha;
        }
        private void LoadData()
        {
            try
            {
                string query = "SELECT * FROM NhanVien";
                DataTable dt = Database.GetData(query); // Gọi trực tiếp từ class Database
                dgvdsnv.DataSource = dt;          // Giả sử bạn có DataGridView tên là dataGridView1
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message);
            }
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void dgvdsnv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btThemNV_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO NhanVien VALUES (@MaNV, @HoTen, @SDT, @DiaChi)";
            SqlParameter[] parameters = {
            new SqlParameter("@MaNV", txbmanhanvien.Text),
            new SqlParameter("@HoTen", txbtennhanvien.Text),
            new SqlParameter("@SDT", txbsdt.Text),
            new SqlParameter("@DiaChi", txbdiachi.Text),
            };
            int result = Database.Execute(query, parameters);
            if (result > 0) MessageBox.Show("Thêm thành công!");
            LoadData();
        }

        private void btSuaNV_Click(object sender, EventArgs e)
        {
            string query = "UPDATE NhanVien SET HoTen=@HoTen, SoDienThoai=@SDT, DiaChi=@DiaChi WHERE MaNhanVien=@MaNV";
            SqlParameter[] parameters = {
            new SqlParameter("@MaNV", txbmanhanvien.Text),
            new SqlParameter("@HoTen", txbtennhanvien.Text),
            new SqlParameter("@SDT", txbsdt.Text),
            new SqlParameter("@DiaChi", txbdiachi.Text),
            };
            int result = Database.Execute(query, parameters);
            if (result > 0) MessageBox.Show("Sửa thành công!");
            LoadData();
        }

        private void btXoaNV_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM NhanVien WHERE MaNhanVien=@MaNV";
            SqlParameter[] parameters = {
             new SqlParameter("@MaNV", txbmanhanvien.Text),
            };
            int result = Database.Execute(query, parameters);
            if (result > 0) MessageBox.Show("Xóa thành công!");
            LoadData();
        }

        private void dgvdsnv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index >= 0)
            {
                txbmanhanvien.Text = dgvdsnv.Rows[index].Cells[0].Value.ToString();
                txbtennhanvien.Text = dgvdsnv.Rows[index].Cells[1].Value.ToString();
                txbsdt.Text = dgvdsnv.Rows[index].Cells[2].Value.ToString();
                txbdiachi.Text = dgvdsnv.Rows[index].Cells[3].Value.ToString();
            }
        }
    }
}
