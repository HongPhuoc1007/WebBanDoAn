namespace DoAnNhom3
{
    partial class DangNhap
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
            label1 = new Label();
            label2 = new Label();
            label5 = new Label();
            txbtendangnhap = new TextBox();
            txbmatkhau = new TextBox();
            btdangnhap = new Button();
            btquenmatkhau = new Button();
            panel1 = new Panel();
            btDangKy = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.BackColor = SystemColors.HighlightText;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(128, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(116, 27);
            label1.TabIndex = 0;
            label1.Text = "Đăng nhập";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.HighlightText;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(41, 87);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(98, 19);
            label2.TabIndex = 1;
            label2.Text = "Tên đăng nhập";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = SystemColors.HighlightText;
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(41, 167);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(67, 19);
            label5.TabIndex = 4;
            label5.Text = "Mật khẩu";
            // 
            // txbtendangnhap
            // 
            txbtendangnhap.Location = new Point(41, 109);
            txbtendangnhap.Margin = new Padding(4, 3, 4, 3);
            txbtendangnhap.Name = "txbtendangnhap";
            txbtendangnhap.Size = new Size(274, 23);
            txbtendangnhap.TabIndex = 5;
            // 
            // txbmatkhau
            // 
            txbmatkhau.Location = new Point(41, 189);
            txbmatkhau.Margin = new Padding(4, 3, 4, 3);
            txbmatkhau.Name = "txbmatkhau";
            txbmatkhau.Size = new Size(274, 23);
            txbmatkhau.TabIndex = 8;
            // 
            // btdangnhap
            // 
            btdangnhap.BackColor = Color.Turquoise;
            btdangnhap.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btdangnhap.Location = new Point(62, 275);
            btdangnhap.Margin = new Padding(4, 3, 4, 3);
            btdangnhap.Name = "btdangnhap";
            btdangnhap.Size = new Size(105, 38);
            btdangnhap.TabIndex = 9;
            btdangnhap.Text = "Đăng nhập";
            btdangnhap.UseVisualStyleBackColor = false;
            btdangnhap.Click += btdangnhap_Click;
            // 
            // btquenmatkhau
            // 
            btquenmatkhau.BackColor = Color.FromArgb(0, 0, 0, 0);
            btquenmatkhau.FlatAppearance.BorderColor = SystemColors.Control;
            btquenmatkhau.FlatAppearance.BorderSize = 0;
            btquenmatkhau.FlatAppearance.MouseDownBackColor = SystemColors.Control;
            btquenmatkhau.FlatAppearance.MouseOverBackColor = SystemColors.Control;
            btquenmatkhau.FlatStyle = FlatStyle.Flat;
            btquenmatkhau.Font = new Font("Times New Roman", 9.75F, FontStyle.Underline, GraphicsUnit.Point, 0);
            btquenmatkhau.ForeColor = SystemColors.ActiveCaptionText;
            btquenmatkhau.Location = new Point(119, 237);
            btquenmatkhau.Margin = new Padding(4, 3, 4, 3);
            btquenmatkhau.Name = "btquenmatkhau";
            btquenmatkhau.Size = new Size(135, 32);
            btquenmatkhau.TabIndex = 10;
            btquenmatkhau.Text = "Quên mật khẩu";
            btquenmatkhau.UseVisualStyleBackColor = false;
            btquenmatkhau.Click += btquenmatkhau_Click;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(50, 0, 0, 0);
            panel1.BackgroundImage = Properties.Resources.dangnhap2;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btDangKy);
            panel1.Controls.Add(btquenmatkhau);
            panel1.Controls.Add(btdangnhap);
            panel1.Controls.Add(txbmatkhau);
            panel1.Controls.Add(txbtendangnhap);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(343, 118);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(352, 366);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // btDangKy
            // 
            btDangKy.BackColor = Color.SpringGreen;
            btDangKy.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDangKy.Location = new Point(186, 275);
            btDangKy.Margin = new Padding(4, 3, 4, 3);
            btDangKy.Name = "btDangKy";
            btDangKy.Size = new Size(109, 38);
            btDangKy.TabIndex = 11;
            btDangKy.Text = "Đăng ký";
            btDangKy.UseVisualStyleBackColor = false;
            btDangKy.Click += btDangKy_Click;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(157, 164);
            panel2.TabIndex = 1;
            // 
            // DangNhap
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.dangnhap3;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1050, 614);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "DangNhap";
            Text = "DangNhap";
            Load += DangNhap_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbtendangnhap;
        private System.Windows.Forms.TextBox txbmatkhau;
        private System.Windows.Forms.Button btdangnhap;
        private System.Windows.Forms.Button btquenmatkhau;
        private System.Windows.Forms.Panel panel1;
        private Button btDangKy;
        private Panel panel2;
    }
}