namespace DoAnNhom3
{
    partial class QuenMatKhau
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            lblTrangThai = new Label();
            txbsdt = new TextBox();
            label4 = new Label();
            btxacnhan = new Button();
            txbmatkhaumoi = new TextBox();
            txbtendangnhap = new TextBox();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackgroundImage = Properties.Resources.dangnhap2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(lblTrangThai);
            panel1.Controls.Add(txbsdt);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(btxacnhan);
            panel1.Controls.Add(txbmatkhaumoi);
            panel1.Controls.Add(txbtendangnhap);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(316, 111);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(424, 406);
            panel1.TabIndex = 0;
            // 
            // lblTrangThai
            // 
            lblTrangThai.AutoSize = true;
            lblTrangThai.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTrangThai.Margin = new Padding(4, 3, 4, 3);
            lblTrangThai.Location = new Point(147, 296);
            lblTrangThai.Name = "lblTrangThai";
            lblTrangThai.Size = new Size(0, 15);
            lblTrangThai.TabIndex = 1;
            lblTrangThai.Left = (panel1.Width - lblTrangThai.Width) / 2;
            // 
            // txbsdt
            // 
            txbsdt.Location = new Point(78, 184);
            txbsdt.Margin = new Padding(4, 3, 4, 3);
            txbsdt.Name = "txbsdt";
            txbsdt.Size = new Size(266, 23);
            txbsdt.TabIndex = 18;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ButtonHighlight;
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(78, 162);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(88, 19);
            label4.TabIndex = 17;
            label4.Text = "Số điện thoại";
            // 
            // btxacnhan
            // 
            btxacnhan.BackColor = Color.LimeGreen;
            btxacnhan.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btxacnhan.Location = new Point(147, 314);
            btxacnhan.Margin = new Padding(4, 3, 4, 3);
            btxacnhan.Name = "btxacnhan";
            btxacnhan.Size = new Size(138, 38);
            btxacnhan.TabIndex = 16;
            btxacnhan.Text = "Xác nhận";
            btxacnhan.UseVisualStyleBackColor = false;
            btxacnhan.Click += btxacnhan_Click;
            // 
            // txbmatkhaumoi
            // 
            txbmatkhaumoi.Location = new Point(79, 256);
            txbmatkhaumoi.Margin = new Padding(4, 3, 4, 3);
            txbmatkhaumoi.Name = "txbmatkhaumoi";
            txbmatkhaumoi.Size = new Size(266, 23);
            txbmatkhaumoi.TabIndex = 13;
            // 
            // txbtendangnhap
            // 
            txbtendangnhap.Location = new Point(79, 106);
            txbtendangnhap.Margin = new Padding(4, 3, 4, 3);
            txbtendangnhap.Name = "txbtendangnhap";
            txbtendangnhap.Size = new Size(266, 23);
            txbtendangnhap.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.ButtonHighlight;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(79, 234);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(93, 19);
            label5.TabIndex = 11;
            label5.Text = "Mật khẩu mới";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ButtonHighlight;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(80, 84);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 10;
            label2.Text = "Tên đăng nhập";
            label2.Click += label2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Times New Roman", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(147, 38);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(136, 23);
            label1.TabIndex = 1;
            label1.Text = "Quên mật khẩu";
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(0, 2);
            panel2.Name = "panel2";
            panel2.Size = new Size(157, 170);
            panel2.TabIndex = 2;
            // 
            // QuenMatKhau
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dangnhap3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1055, 614);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuenMatKhau";
            Text = "QuenMatKhau";
            Load += QuenMatKhau_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbmatkhaumoi;
        private System.Windows.Forms.TextBox txbtendangnhap;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btxacnhan;
        private TextBox txbsdt;
        private Label label4;
        private Label lblTrangThai;
        private Panel panel2;
    }
}