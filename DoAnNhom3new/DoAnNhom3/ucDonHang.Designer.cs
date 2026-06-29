using System;
using System.Drawing;
using System.Windows.Forms;

namespace DoAnNhom3
{
    partial class ucDonHang
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            btthemvaogiohang = new Button();
            btthanhtoanKH = new Button();
            btXoaMon = new Button();
            panel1 = new Panel();
            flpgiohang = new FlowLayoutPanel();
            btQuayVe = new Button();
            lblTongTien = new Label();
            panel1.SuspendLayout();
            SuspendLayout();

            // label1
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(100, 23);
            label1.TabIndex = 45;

            // btthemvaogiohang
            btthemvaogiohang.BackColor = Color.MediumTurquoise;
            btthemvaogiohang.FlatAppearance.BorderSize = 0;
            btthemvaogiohang.FlatStyle = FlatStyle.Flat;
            btthemvaogiohang.Font = new Font("Times New Roman", 12F);
            btthemvaogiohang.Location = new Point(20, 320);
            btthemvaogiohang.Name = "btthemvaogiohang";
            btthemvaogiohang.Size = new Size(100, 50);
            btthemvaogiohang.Text = "Thêm món";
            btthemvaogiohang.UseVisualStyleBackColor = false;

            // btthanhtoanKH
            btthanhtoanKH.BackColor = Color.MediumTurquoise;
            btthanhtoanKH.FlatAppearance.BorderSize = 0;
            btthanhtoanKH.FlatStyle = FlatStyle.Flat;
            btthanhtoanKH.Font = new Font("Times New Roman", 12F);
            btthanhtoanKH.Location = new Point(130, 320);
            btthanhtoanKH.Name = "btthanhtoanKH";
            btthanhtoanKH.Size = new Size(100, 50);
            btthanhtoanKH.Text = "Thanh toán";
            btthanhtoanKH.UseVisualStyleBackColor = false;

            // btXoaMon
            btXoaMon.BackColor = Color.LightCoral;
            btXoaMon.FlatAppearance.BorderSize = 0;
            btXoaMon.FlatStyle = FlatStyle.Flat;
            btXoaMon.Font = new Font("Times New Roman", 12F);
            btXoaMon.Location = new Point(240, 320);
            btXoaMon.Name = "btXoaMon";
            btXoaMon.Size = new Size(100, 50);
            btXoaMon.Text = "Xóa món";
            btXoaMon.UseVisualStyleBackColor = false;

            // btQuayVe
            btQuayVe.BackColor = Color.MediumTurquoise;
            btQuayVe.FlatAppearance.BorderSize = 0;
            btQuayVe.FlatStyle = FlatStyle.Flat;
            btQuayVe.Font = new Font("Times New Roman", 12F);
            btQuayVe.Location = new Point(350, 320);
            btQuayVe.Name = "btQuayVe";
            btQuayVe.Size = new Size(100, 50);
            btQuayVe.Text = "Menu";
            btQuayVe.UseVisualStyleBackColor = false;

            // flpgiohang
            flpgiohang.Anchor = AnchorStyles.None;
            flpgiohang.AutoScroll = true;
            flpgiohang.BackColor = SystemColors.ButtonHighlight;
            flpgiohang.FlowDirection = FlowDirection.TopDown;
            flpgiohang.Location = new Point(0, 0);
            flpgiohang.Name = "flpgiohang";
            flpgiohang.Size = new Size(480, 280);
            flpgiohang.WrapContents = false;

            // lblTongTien
            lblTongTien.Font = new Font("Times New Roman", 12F, FontStyle.Bold);
            lblTongTien.ForeColor = Color.DarkGreen;
            lblTongTien.Location = new Point(10, 285);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(460, 30);
            lblTongTien.Text = "Tổng tiền: 0 VNĐ";
            lblTongTien.TextAlign = ContentAlignment.MiddleRight;

            // panel1
            panel1.Controls.Add(flpgiohang);
            panel1.Controls.Add(lblTongTien);
            panel1.Controls.Add(btthemvaogiohang);
            panel1.Controls.Add(btthanhtoanKH);
            panel1.Controls.Add(btXoaMon);
            panel1.Controls.Add(btQuayVe);
            panel1.Location = new Point(300, 80);
            panel1.Name = "panel1";
            panel1.Size = new Size(480, 400);
            panel1.TabIndex = 37;

            // ucDonHang
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "ucDonHang";
            Size = new Size(1081, 618);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Button btthemvaogiohang;
        private Button btthanhtoanKH;
        private Button btXoaMon;
        private Panel panel1;
        private Button btQuayVe;
        private FlowLayoutPanel flpgiohang;
        private Label lblTongTien;
    }
}
