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
    public partial class DangKiTaiKhoan : Form
    {
        public DangKiTaiKhoan()
        {
            InitializeComponent();
        }




        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap DK = new DangNhap();
            DK.Show();
        }

        private void btdangki_Click(object sender, EventArgs e)
        {
            string tenDN = txtTenDangNhap.Text.Trim();
            string matKhau = txtMatKhau.Text.Trim();
            string soDT = txtSoDienThoai.Text.Trim();
            string email = txtEmail.Text.Trim();

            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matKhau)
                || string.IsNullOrEmpty(soDT) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            // Kiểm tra trùng tên đăng nhập
            string checkQuery = "SELECT COUNT(*) FROM TaiKhoan WHERE TenDangNhap = @TenDN";
            SqlParameter[] checkParams = { new SqlParameter("@TenDN", tenDN) };
            DataTable checkResult = Database.GetData(checkQuery, checkParams);
            if (Convert.ToInt32(checkResult.Rows[0][0]) > 0)
            {
                MessageBox.Show("Tên đăng nhập đã tồn tại.");
                return;
            }

            // Thêm tài khoản mới
            string insertQuery = @"INSERT INTO TaiKhoan (TenDangNhap, MatKhau, SoDienThoai, Email)
                               VALUES (@TenDN, @MatKhau, @SoDT, @Email)";
            SqlParameter[] parameters = {
            new SqlParameter("@TenDN", tenDN),
            new SqlParameter("@MatKhau", matKhau),
            new SqlParameter("@SoDT", soDT),
            new SqlParameter("@Email", email)
        };

            int rowsAffected = Database.ExecuteNonQuery(insertQuery, parameters);
            if (rowsAffected > 0)
            {
                MessageBox.Show("Đăng ký thành công!");
                this.Close(); // hoặc mở lại FormĐăngNhập
                
            }
            else
            {
                MessageBox.Show("Đăng ký thất bại.");
            }
        }
    }
}
