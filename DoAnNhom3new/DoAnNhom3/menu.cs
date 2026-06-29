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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        // Đổi từ NhanVien ➝ Menu

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void capNhatDahMuc1_Load(object sender, EventArgs e)
        {

        }

        private void gioHang1_Load(object sender, EventArgs e)
        {

        }

        private void btqldanhmuc_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            // Tạo mới instance của UserControl
            ChinhSuaMenu baoCaoUC = new ChinhSuaMenu();
            baoCaoUC.Dock = DockStyle.Fill; // Để tự giãn theo panel

            // Thêm vào panel
            panelMain.Controls.Add(baoCaoUC);
        }

        private void btbaocao_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            // Tạo mới instance của UserControl
            BaoCaoThongKe baoCaoUC = new BaoCaoThongKe(this);
            baoCaoUC.Dock = DockStyle.Fill; // Để tự giãn theo panel

            // Thêm vào panel
            panelMain.Controls.Add(baoCaoUC);
        }

        private void btkhonguyenlieu_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            // Tạo mới instance của UserControl
            KhoNLieu baoCaoUC = new KhoNLieu(this);
            baoCaoUC.Dock = DockStyle.Fill; // Để tự giãn theo panel

            // Thêm vào panel
            panelMain.Controls.Add(baoCaoUC);

        }

        private void btqlkhachhang_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            // Tạo mới instance của UserControl
            QuanLiKhachHang baoCaoUC = new QuanLiKhachHang(this);
            baoCaoUC.Dock = DockStyle.Fill; // Để tự giãn theo panel

            // Thêm vào panel
            panelMain.Controls.Add(baoCaoUC);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap DN = new DangNhap();
            DN.Show();
        }

        private void btqlnhanvien_Click(object sender, EventArgs e)
        {
            panelMain.Controls.Clear();

            // Tạo mới instance của UserControl
            ThongTinNVien baoCaoUC = new ThongTinNVien(this);
            baoCaoUC.Dock = DockStyle.Fill; // Để tự giãn theo panel

            // Thêm vào panel
            panelMain.Controls.Add(baoCaoUC);
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelMain_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
