namespace DoAnNhom3
{
    partial class KhachHangDangNhap
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
            button1 = new Button();
            btdangxuatKH = new Button();
            btnTaiKhoan = new Button();
            btnMenu = new Button();
            panelkhachhang = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(btdangxuatKH);
            panel1.Controls.Add(btnTaiKhoan);
            panel1.Controls.Add(btnMenu);
            panel1.Location = new Point(2, 165);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 461);
            panel1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.Highlight;
            button1.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Black;
            button1.Location = new Point(0, 231);
            button1.Margin = new Padding(4, 3, 4, 3);
            button1.Name = "button1";
            button1.Size = new Size(204, 115);
            button1.TabIndex = 9;
            button1.Text = "Giỏ Hàng";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // btdangxuatKH
            // 
            btdangxuatKH.BackColor = SystemColors.Highlight;
            btdangxuatKH.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btdangxuatKH.ForeColor = Color.Black;
            btdangxuatKH.Location = new Point(0, 343);
            btdangxuatKH.Margin = new Padding(4, 3, 4, 3);
            btdangxuatKH.Name = "btdangxuatKH";
            btdangxuatKH.Size = new Size(204, 118);
            btdangxuatKH.TabIndex = 8;
            btdangxuatKH.Text = "Đăng xuất";
            btdangxuatKH.UseVisualStyleBackColor = false;
            btdangxuatKH.Click += btdangxuatKH_Click;
            // 
            // btnTaiKhoan
            // 
            btnTaiKhoan.BackColor = SystemColors.Highlight;
            btnTaiKhoan.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnTaiKhoan.ForeColor = Color.Black;
            btnTaiKhoan.Location = new Point(0, 115);
            btnTaiKhoan.Margin = new Padding(4, 3, 4, 3);
            btnTaiKhoan.Name = "btnTaiKhoan";
            btnTaiKhoan.Size = new Size(204, 120);
            btnTaiKhoan.TabIndex = 7;
            btnTaiKhoan.Text = "Tài khoản";
            btnTaiKhoan.UseVisualStyleBackColor = false;
            btnTaiKhoan.Click += btnTaiKhoan_Click;
            // 
            // btnMenu
            // 
            btnMenu.BackColor = SystemColors.Highlight;
            btnMenu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMenu.ForeColor = Color.Black;
            btnMenu.Location = new Point(0, 0);
            btnMenu.Margin = new Padding(4, 3, 4, 3);
            btnMenu.Name = "btnMenu";
            btnMenu.Size = new Size(204, 120);
            btnMenu.TabIndex = 6;
            btnMenu.Text = "Menu";
            btnMenu.UseVisualStyleBackColor = false;
            btnMenu.Click += btmenuKH_Click;
            // 
            // panelkhachhang
            // 
            panelkhachhang.Dock = DockStyle.Right;
            panelkhachhang.Location = new Point(213, 0);
            panelkhachhang.Margin = new Padding(4, 3, 4, 3);
            panelkhachhang.Name = "panelkhachhang";
            panelkhachhang.Size = new Size(1253, 680);
            panelkhachhang.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(2, 5);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 154);
            panel2.TabIndex = 9;
            // 
            // KhachHangDangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1466, 680);
            Controls.Add(panelkhachhang);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "KhachHangDangNhap";
            Text = "KhachHangDangNhap";
            Load += KhachHangDangNhap_Load;
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTaiKhoan;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.Button btdangxuatKH;
        public Panel panelkhachhang;
        private Button button1;
        private Panel panel2;
    }
}