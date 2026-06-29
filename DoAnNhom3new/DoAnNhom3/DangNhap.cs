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
using System.Diagnostics.Eventing.Reader;

namespace DoAnNhom3
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btdangnhap_Click(object sender, EventArgs e)
        {
            string tenDN = txbtendangnhap.Text.Trim();
            string matKhau = txbmatkhau.Text.Trim();
            string sdtKH;
            if (string.IsNullOrEmpty(tenDN) || string.IsNullOrEmpty(matKhau))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
                return;
            }

            string query = "SELECT * FROM TaiKhoan WHERE TenDangNhap = @TenDN AND MatKhau = @MatKhau";
            SqlParameter[] parameters = new SqlParameter[]
            {
            new SqlParameter("@TenDN", tenDN),
            new SqlParameter("@MatKhau", matKhau)
            };

            DataTable dt = Database.GetData(query, parameters);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Đăng nhập thành công!");
                sdtKH = dt.Rows[0]["SoDienThoai"].ToString();

                // Ẩn form hiện tại và mở menu
                this.Hide();
                if (tenDN == "user1")
                {
                    Menu menu = new Menu(); // đảm bảo bạn có form menu tên này
                    menu.Show();
                }
                else if (tenDN == "user2")
                {
                    NhanVien NV = new NhanVien();
                    NV.Show();
                }
                else
                {
                    KhachHangDangNhap K = new KhachHangDangNhap(sdtKH);
                    K.Show();
                }

            }
            else
            {
                MessageBox.Show("Sai tên đăng nhập hoặc mật khẩu.");
            }
        }

        private void btDangKy_Click(object sender, EventArgs e)
        {
            //this.Hide();
            DangKiTaiKhoan DK = new DangKiTaiKhoan();
            DK.Show();
        }

        private void btquenmatkhau_Click(object sender, EventArgs e)
        {
            QuenMatKhau QMK = new QuenMatKhau();
            QMK.Show();
        }
    }
}
