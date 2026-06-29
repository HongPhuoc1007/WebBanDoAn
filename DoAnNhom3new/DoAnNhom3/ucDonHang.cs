using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DoAnNhom3.Model;

namespace DoAnNhom3
{
    public partial class ucDonHang : UserControl
    {
        private List<MonAn> gioHang = new List<MonAn>();

        public event Action QuayVeClicked;
        public event Action<List<MonAn>> ThanhToanClicked;

        public ucDonHang()
        {
            InitializeComponent();

            btQuayVe.Click += (s, e) => QuayVeClicked?.Invoke();
            btthanhtoanKH.Click += btthanhtoanKH_Click;
            btXoaMon.Click += btXoaMon_Click;

            flpgiohang.FlowDirection = FlowDirection.TopDown;
            flpgiohang.WrapContents = false;
            flpgiohang.AutoScroll = true;
        }

        public void AddItem(MonAn monAn)
        {
            var existing = gioHang.FirstOrDefault(m => m.MaMon == monAn.MaMon);
            if (existing != null)
            {
                existing.SoLuong += monAn.SoLuong;
            }
            else
            {
                gioHang.Add(new MonAn
                {
                    MaMon = monAn.MaMon,
                    TenMon = monAn.TenMon,
                    GiaTien = monAn.GiaTien,
                    SoLuong = monAn.SoLuong,
                    HinhAnh = monAn.HinhAnh
                });
            }

            HienThiGioHang();
        }

        private void HienThiGioHang()
        {
            flpgiohang.Controls.Clear();

            foreach (var mon in gioHang)
            {
                Panel panel = new Panel
                {
                    Width = 500,
                    Height = 100,
                    BorderStyle = BorderStyle.FixedSingle,
                    Margin = new Padding(5),
                    Tag = mon
                };

                PictureBox pic = new PictureBox
                {
                    Size = new Size(100, 80),
                    Location = new Point(5, 10),
                    SizeMode = PictureBoxSizeMode.StretchImage
                };

                string path = Path.Combine(Application.StartupPath, "HinhAnh", mon.HinhAnh);
                if (File.Exists(path))
                {
                    using (var stream = new FileStream(path, FileMode.Open, FileAccess.Read))
                    {
                        pic.Image = Image.FromStream(stream);
                    }
                }

                TextBox txbTen = new TextBox
                {
                    Text = mon.TenMon,
                    Location = new Point(110, 10),
                    Width = 150,
                    ReadOnly = true
                };

                TextBox txbGia = new TextBox
                {
                    Text = mon.GiaTien.ToString("N0") + " đ",
                    Location = new Point(110, 40),
                    Width = 150,
                    ReadOnly = true
                };

                NumericUpDown numSL = new NumericUpDown
                {
                    Minimum = 1,
                    Value = mon.SoLuong,
                    Location = new Point(110, 70),
                    Width = 80
                };

                numSL.ValueChanged += (s, e) =>
                {
                    mon.SoLuong = (int)numSL.Value;
                    CapNhatTongTien();
                };

                Button btnX = new Button
                {
                    Text = "X",
                    ForeColor = Color.White,
                    BackColor = Color.Red,
                    FlatStyle = FlatStyle.Flat,
                    Size = new Size(30, 30),
                    Location = new Point(460, 5)
                };

                btnX.Click += (s, e) =>
                {
                    gioHang.RemoveAll(m => m.MaMon == mon.MaMon);
                    HienThiGioHang();
                };

                panel.Controls.Add(pic);
                panel.Controls.Add(txbTen);
                panel.Controls.Add(txbGia);
                panel.Controls.Add(numSL);
                panel.Controls.Add(btnX);

                flpgiohang.Controls.Add(panel);
            }

            CapNhatTongTien();
        }

        private void CapNhatTongTien()
        {
            decimal tong = gioHang.Sum(m => m.GiaTien * m.SoLuong);
            lblTongTien.Text = "Tổng tiền: " + tong.ToString("N0") + " VNĐ";
        }

        private void btthanhtoanKH_Click(object sender, EventArgs e)
        {
            foreach (Control panel in flpgiohang.Controls)
            {
                if (panel is Panel p && p.Tag is MonAn mon)
                {
                    foreach (Control ctrl in p.Controls)
                    {
                        if (ctrl is NumericUpDown num)
                        {
                            mon.SoLuong = (int)num.Value;
                        }
                    }
                }
            }

            if (gioHang.Count == 0)
            {
                MessageBox.Show("Giỏ hàng đang trống!");
                return;
            }

            ThanhToanClicked?.Invoke(new List<MonAn>(gioHang));
        }

        private void btXoaMon_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn có thể nhấn nút \"X\" đỏ trên mỗi món để xoá từng món trong giỏ hàng.", "Thông báo");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
        }
    }
}
