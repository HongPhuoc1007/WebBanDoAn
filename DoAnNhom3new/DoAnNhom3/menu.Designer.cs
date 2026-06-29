namespace DoAnNhom3
{
    partial class Menu
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
            btqlnhanvien = new Button();
            btbaocao = new Button();
            btkhonguyenlieu = new Button();
            btqldanhmuc = new Button();
            btqlkhachhang = new Button();
            panel1 = new Panel();
            btDangXuat = new Button();
            panelMain = new Panel();
            panel2 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btqlnhanvien
            // 
            btqlnhanvien.BackColor = SystemColors.Highlight;
            btqlnhanvien.FlatAppearance.BorderSize = 0;
            btqlnhanvien.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqlnhanvien.ForeColor = SystemColors.HighlightText;
            btqlnhanvien.Location = new Point(0, 76);
            btqlnhanvien.Margin = new Padding(4, 3, 4, 3);
            btqlnhanvien.Name = "btqlnhanvien";
            btqlnhanvien.Size = new Size(205, 97);
            btqlnhanvien.TabIndex = 0;
            btqlnhanvien.Text = "Quản lí nhân viên";
            btqlnhanvien.UseVisualStyleBackColor = false;
            btqlnhanvien.Click += btqlnhanvien_Click;
            // 
            // btbaocao
            // 
            btbaocao.BackColor = SystemColors.Highlight;
            btbaocao.FlatAppearance.BorderSize = 0;
            btbaocao.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btbaocao.ForeColor = SystemColors.ButtonHighlight;
            btbaocao.Location = new Point(-1, 325);
            btbaocao.Margin = new Padding(4, 3, 4, 3);
            btbaocao.Name = "btbaocao";
            btbaocao.Size = new Size(205, 80);
            btbaocao.TabIndex = 1;
            btbaocao.Text = "Báo cáo thống kê";
            btbaocao.UseVisualStyleBackColor = false;
            btbaocao.Click += btbaocao_Click;
            // 
            // btkhonguyenlieu
            // 
            btkhonguyenlieu.BackColor = SystemColors.Highlight;
            btkhonguyenlieu.FlatAppearance.BorderSize = 0;
            btkhonguyenlieu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btkhonguyenlieu.ForeColor = SystemColors.ButtonHighlight;
            btkhonguyenlieu.Location = new Point(-1, 245);
            btkhonguyenlieu.Margin = new Padding(4, 3, 4, 3);
            btkhonguyenlieu.Name = "btkhonguyenlieu";
            btkhonguyenlieu.Size = new Size(206, 86);
            btkhonguyenlieu.TabIndex = 3;
            btkhonguyenlieu.Text = "Kho nguyên liệu";
            btkhonguyenlieu.UseVisualStyleBackColor = false;
            btkhonguyenlieu.Click += btkhonguyenlieu_Click;
            // 
            // btqldanhmuc
            // 
            btqldanhmuc.BackColor = SystemColors.Highlight;
            btqldanhmuc.FlatAppearance.BorderColor = SystemColors.Highlight;
            btqldanhmuc.FlatAppearance.BorderSize = 0;
            btqldanhmuc.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqldanhmuc.ForeColor = Color.White;
            btqldanhmuc.Location = new Point(1, 0);
            btqldanhmuc.Margin = new Padding(4, 3, 4, 3);
            btqldanhmuc.Name = "btqldanhmuc";
            btqldanhmuc.Size = new Size(204, 82);
            btqldanhmuc.TabIndex = 4;
            btqldanhmuc.Text = "Quản lí menu";
            btqldanhmuc.UseVisualStyleBackColor = false;
            btqldanhmuc.Click += btqldanhmuc_Click;
            // 
            // btqlkhachhang
            // 
            btqlkhachhang.BackColor = SystemColors.Highlight;
            btqlkhachhang.FlatAppearance.BorderSize = 0;
            btqlkhachhang.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btqlkhachhang.ForeColor = SystemColors.HighlightText;
            btqlkhachhang.Location = new Point(0, 169);
            btqlkhachhang.Margin = new Padding(4, 3, 4, 3);
            btqlkhachhang.Name = "btqlkhachhang";
            btqlkhachhang.Size = new Size(205, 82);
            btqlkhachhang.TabIndex = 5;
            btqlkhachhang.Text = "Quản lí khách hàng";
            btqlkhachhang.UseVisualStyleBackColor = false;
            btqlkhachhang.Click += btqlkhachhang_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.Highlight;
            panel1.Controls.Add(btDangXuat);
            panel1.Controls.Add(btqlnhanvien);
            panel1.Controls.Add(btqlkhachhang);
            panel1.Controls.Add(btqldanhmuc);
            panel1.Controls.Add(btbaocao);
            panel1.Controls.Add(btkhonguyenlieu);
            panel1.Location = new Point(1, 157);
            panel1.Margin = new Padding(4, 3, 4, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(204, 477);
            panel1.TabIndex = 6;
            // 
            // btDangXuat
            // 
            btDangXuat.BackColor = SystemColors.Highlight;
            btDangXuat.FlatAppearance.BorderSize = 0;
            btDangXuat.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btDangXuat.ForeColor = SystemColors.ButtonHighlight;
            btDangXuat.Location = new Point(-1, 399);
            btDangXuat.Margin = new Padding(4, 3, 4, 3);
            btDangXuat.Name = "btDangXuat";
            btDangXuat.Size = new Size(205, 78);
            btDangXuat.TabIndex = 7;
            btDangXuat.Text = "Đăng Xuất";
            btDangXuat.UseVisualStyleBackColor = false;
            btDangXuat.Click += button2_Click;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.None;
            panelMain.BackColor = SystemColors.Control;
            panelMain.Location = new Point(211, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1071, 626);
            panelMain.TabIndex = 7;
            panelMain.Paint += panelMain_Paint;
            // 
            // panel2
            // 
            panel2.BackgroundImage = Properties.Resources.logo;
            panel2.BackgroundImageLayout = ImageLayout.Stretch;
            panel2.Location = new Point(1, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(204, 154);
            panel2.TabIndex = 8;
            panel2.Paint += panel2_Paint;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(1284, 634);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(panelMain);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Menu";
            Text = "Menu";
            panel1.ResumeLayout(false);
            ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btqlnhanvien;
        private System.Windows.Forms.Button btbaocao;
        private System.Windows.Forms.Button btkhonguyenlieu;
        private System.Windows.Forms.Button btqldanhmuc;
        private System.Windows.Forms.Button btqlkhachhang;
        private System.Windows.Forms.Panel panel1;
        public Panel panelMain;
        private Button btDangXuat;
        private Panel panel2;
    }
}