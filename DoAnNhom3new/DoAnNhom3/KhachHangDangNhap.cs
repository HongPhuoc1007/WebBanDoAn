using DoAnNhom3.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoAnNhom3.QuanLy;



namespace DoAnNhom3
{
    public partial class KhachHangDangNhap : Form
    {
        private ucMenuMonAn ucMenu;
        //private uctaoDH ucDon;

        public static List<GioHangItem> GioHang = new List<GioHangItem>();
        public string sdtKH { get; set; }
        public KhachHangDangNhap(string sdtKH)
        {
            InitializeComponent();
            ucMenu = new ucMenuMonAn();
            //ucDon = new uctaoDH();
            this.sdtKH = sdtKH;
            ucMenu.Dock = DockStyle.Fill;
            //ucDon.Dock = DockStyle.Fill;


            panelkhachhang.Controls.Add(ucMenu);
            //panelkhachhang.Controls.Add(ucDon);

            ucMenu.Show();
            //ucDon.Hide();
        }

        private void baoCaoThongKe1_Load(object sender, EventArgs e)
        {

        }

        private void KhachHangDangNhap_Load(object sender, EventArgs e)
        {
            //ucDon = new uctaoDH();
            //ucDon.Visible = false;
            //ucDon.Dock = DockStyle.Fill;
            //panelkhachhang.Controls.Add(ucDon);

            //LoadMenu(); // Hiển thị danh sách món ăn
        }


        private void btmenuKH_Click(object sender, EventArgs e)
        {
            panelkhachhang.Controls.Clear(); // hoặc tên panel bạn dùng
            ucMenuMonAn uc = new ucMenuMonAn();
            uc.Dock = DockStyle.Fill;
            panelkhachhang.Controls.Add(uc);
        }

        private void btdangxuatKH_Click(object sender, EventArgs e)
        {
            this.Close();
            DangNhap DN = new DangNhap();
            DN.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panelkhachhang.Controls.Clear(); // hoặc tên panel bạn dùng
            uctaoDH uc = new uctaoDH(GioHang, sdtKH);
            uc.Dock = DockStyle.Fill;
            panelkhachhang.Controls.Add(uc);
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            panelkhachhang.Controls.Clear(); // hoặc tên panel bạn dùng
            ucXemLSDonHang uc = new ucXemLSDonHang(sdtKH);
            uc.Dock = DockStyle.Fill;
            panelkhachhang.Controls.Add(uc);
        }
    }
}
public class GioHangItem
{
    public string MaMon { get; set; }
    public string TenMon { get; set; }
    public int SoLuong { get; set; }
    public decimal DonGia { get; set; }
    public decimal ThanhTien => SoLuong * DonGia;
}