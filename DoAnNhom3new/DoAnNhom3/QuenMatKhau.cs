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
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btxacnhan_Click(object sender, EventArgs e)
        {
            string tenDangNhap = txbtendangnhap.Text.Trim();
            string sdt = txbsdt.Text.Trim();
            string matKhauMoi = txbmatkhaumoi.Text.Trim();
            txbmatkhaumoi.Enabled = false;

            if (tenDangNhap == "" || sdt == "")
            {
                lblTrangThai.Text = "Vui lòng nhập đầy đủ tên đăng nhập và số điện thoại.";
                return;
            }

            // Bước 1: Kiểm tra tài khoản tồn tại
            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDN AND SoDienThoai = @SDT";
            SqlParameter[] prms =
            {
            new SqlParameter("@TenDN", tenDangNhap),
            new SqlParameter("@SDT", sdt)
            };

            DataTable dt = Database.GetData(query, prms);

            if (dt.Rows.Count == 0)
            {
                lblTrangThai.Text = "Tên đăng nhập hoặc số điện thoại không đúng!";
                return;
            }

            // Nếu đúng thì bật nhập mật khẩu mới
            if (matKhauMoi == "")
            {
                txbmatkhaumoi.Enabled = true;
                lblTrangThai.Text = "Thông tin đúng, hãy nhập mật khẩu mới.";
                return;
            }

            // Cập nhật mật khẩu
            string updateQuery = "UPDATE TaiKhoan SET MatKhau = @MatKhauMoi WHERE TenDangNhap = @TenDN AND SoDienThoai = @SDT";
            SqlParameter[] updateParams =
            {
            new SqlParameter("@MatKhauMoi", matKhauMoi),
            new SqlParameter("@TenDN", tenDangNhap),
            new SqlParameter("@SDT", sdt)
            };

            int rows = Database.Execute(updateQuery, updateParams);

            if (rows > 0)
            {
                MessageBox.Show("Cập nhật mật khẩu thành công!", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); // Quay lại form đăng nhập
            }
            else
            {
                lblTrangThai.Text = "Có lỗi xảy ra khi cập nhật.";
            }
        }

        private void QuenMatKhau_Load(object sender, EventArgs e)
        {

        }
    }
}
