using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DoAnNhom3.Model;
using Microsoft.Identity.Client.NativeInterop;

namespace DoAnNhom3
{
    public partial class ucMonAn : UserControl
    {
        public string MaMon { get; set; }
        public string TenMon { get; set; }
        public decimal Gia { get; set; }
        public ucMonAn(string maMon, string tenMon, decimal gia, Image hinh)
        {
            InitializeComponent();

            MaMon = maMon;
            TenMon = tenMon;
            Gia = gia;

            lbtenmonan.Text = tenMon;
            lbgia.Text = gia.ToString("N0") + " đ";
            pictureBox1.Image = hinh;
        }

        private void btgiohang_Click(object sender, EventArgs e)
        {

            KhachHangDangNhap.GioHang.Add(new GioHangItem
            {
                MaMon = MaMon,
                TenMon = TenMon,
                SoLuong = 1,
                DonGia = Gia
            });

            MessageBox.Show("Đã thêm vào giỏ!");
        }

        private void btmuangay_Click_1(object sender, EventArgs e)
        {
            if((int)numericUpDown1.Value > 0 )
            {
                KhachHangDangNhap.GioHang.Add(new GioHangItem
                {
                    MaMon = MaMon,
                    TenMon = TenMon,
                    SoLuong = (int) numericUpDown1.Value,
                    DonGia = Gia
                });

                MessageBox.Show("Đã thêm vào giỏ!");
            }    
            
        }
    }
}
