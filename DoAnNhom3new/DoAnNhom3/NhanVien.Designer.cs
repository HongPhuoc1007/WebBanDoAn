namespace DoAnNhom3
{
    partial class NhanVien
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            panelMain = new Panel();
            panelMainContent = new Panel();
            panelContent = new Panel();
            labelTitle = new Label();
            dgvmenuNV = new DataGridView();
            labelTenMon = new Label();
            cbbTenmonmenuNV = new ComboBox();
            labelSoLuong = new Label();
            txbsoluongmenuNV = new TextBox();
            labelDonGia = new Label();
            txbdongiamenuNV = new TextBox();
            panelSideBar = new Panel();
            btDangXuat = new Button();
            panelLogo = new Panel();
            bttaodonhang = new Button();
            btqldanhmuc = new Button();
            btthongke = new Button();
            btqldonhang = new Button();
            panelMain.SuspendLayout();
            panelMainContent.SuspendLayout();
            panelContent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmenuNV).BeginInit();
            panelSideBar.SuspendLayout();
            SuspendLayout();
            // 
            // panelMain
            // 
            panelMain.Controls.Add(panelMainContent);
            panelMain.Controls.Add(panelSideBar);
            panelMain.Dock = DockStyle.Fill;
            panelMain.Location = new Point(0, 0);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(1304, 700);
            panelMain.TabIndex = 0;
            // 
            // panelMainContent
            // 
            panelMainContent.Controls.Add(panelContent);
            panelMainContent.Dock = DockStyle.Fill;
            panelMainContent.Location = new Point(200, 0);
            panelMainContent.Name = "panelMainContent";
            panelMainContent.Size = new Size(1104, 700);
            panelMainContent.TabIndex = 0;
            // 
            // panelContent
            // 
            panelContent.Controls.Add(labelTitle);
            panelContent.Controls.Add(dgvmenuNV);
            panelContent.Controls.Add(labelTenMon);
            panelContent.Controls.Add(cbbTenmonmenuNV);
            panelContent.Controls.Add(labelSoLuong);
            panelContent.Controls.Add(txbsoluongmenuNV);
            panelContent.Controls.Add(labelDonGia);
            panelContent.Controls.Add(txbdongiamenuNV);
            panelContent.Dock = DockStyle.Fill;
            panelContent.Location = new Point(0, 0);
            panelContent.Name = "panelContent";
            panelContent.Size = new Size(1104, 700);
            panelContent.TabIndex = 0;
            // 
            // labelTitle
            // 
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            labelTitle.Location = new Point(500, 20);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(86, 32);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "MENU";
            // 
            // dgvmenuNV
            // 
            dgvmenuNV.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvmenuNV.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCellsExceptHeader;
            dgvmenuNV.BackgroundColor = Color.White;
            dgvmenuNV.Location = new Point(186, 72);
            dgvmenuNV.Name = "dgvmenuNV";
            dgvmenuNV.Size = new Size(702, 200);
            dgvmenuNV.TabIndex = 1;
            // 
            // labelTenMon
            // 
            labelTenMon.Location = new Point(186, 323);
            labelTenMon.Name = "labelTenMon";
            labelTenMon.Size = new Size(100, 23);
            labelTenMon.TabIndex = 2;
            labelTenMon.Text = "Tên món ăn";
            // 
            // cbbTenmonmenuNV
            // 
            cbbTenmonmenuNV.Location = new Point(186, 348);
            cbbTenmonmenuNV.Name = "cbbTenmonmenuNV";
            cbbTenmonmenuNV.Size = new Size(250, 23);
            cbbTenmonmenuNV.TabIndex = 3;
            // 
            // labelSoLuong
            // 
            labelSoLuong.Location = new Point(186, 383);
            labelSoLuong.Name = "labelSoLuong";
            labelSoLuong.Size = new Size(100, 23);
            labelSoLuong.TabIndex = 4;
            labelSoLuong.Text = "Số lượng";
            // 
            // txbsoluongmenuNV
            // 
            txbsoluongmenuNV.Location = new Point(186, 408);
            txbsoluongmenuNV.Name = "txbsoluongmenuNV";
            txbsoluongmenuNV.Size = new Size(250, 23);
            txbsoluongmenuNV.TabIndex = 5;
            // 
            // labelDonGia
            // 
            labelDonGia.Location = new Point(186, 443);
            labelDonGia.Name = "labelDonGia";
            labelDonGia.Size = new Size(100, 23);
            labelDonGia.TabIndex = 6;
            labelDonGia.Text = "Đơn giá";
            // 
            // txbdongiamenuNV
            // 
            txbdongiamenuNV.Location = new Point(186, 468);
            txbdongiamenuNV.Name = "txbdongiamenuNV";
            txbdongiamenuNV.Size = new Size(250, 23);
            txbdongiamenuNV.TabIndex = 7;
            // 
            // panelSideBar
            // 
            panelSideBar.BackColor = Color.FromArgb(0, 122, 204);
            panelSideBar.Controls.Add(btDangXuat);
            panelSideBar.Controls.Add(panelLogo);
            panelSideBar.Controls.Add(bttaodonhang);
            panelSideBar.Controls.Add(btqldanhmuc);
            panelSideBar.Controls.Add(btthongke);
            panelSideBar.Controls.Add(btqldonhang);
            panelSideBar.Dock = DockStyle.Left;
            panelSideBar.Location = new Point(0, 0);
            panelSideBar.Name = "panelSideBar";
            panelSideBar.Size = new Size(200, 700);
            panelSideBar.TabIndex = 1;
            // 
            // btDangXuat
            // 
            btDangXuat.BackColor = Color.Firebrick;
            btDangXuat.Dock = DockStyle.Bottom;
            btDangXuat.FlatStyle = FlatStyle.Flat;
            btDangXuat.ForeColor = Color.White;
            btDangXuat.Location = new Point(0, 650);
            btDangXuat.Name = "btDangXuat";
            btDangXuat.Size = new Size(200, 50);
            btDangXuat.TabIndex = 0;
            btDangXuat.Text = "\u23fb Đăng xuất";
            btDangXuat.UseVisualStyleBackColor = false;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = Properties.Resources.logo;
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Dock = DockStyle.Fill;
            panelLogo.Location = new Point(0, 240);
            panelLogo.Name = "panelLogo";
            panelLogo.Size = new Size(200, 460);
            panelLogo.TabIndex = 1;
            // 
            // bttaodonhang
            // 
            bttaodonhang.Dock = DockStyle.Top;
            bttaodonhang.FlatStyle = FlatStyle.Flat;
            bttaodonhang.ForeColor = Color.White;
            bttaodonhang.Location = new Point(0, 180);
            bttaodonhang.Name = "bttaodonhang";
            bttaodonhang.Size = new Size(200, 60);
            bttaodonhang.TabIndex = 2;
            bttaodonhang.Text = "\U0001f6d2 Tạo đơn hàng";
            // 
            // btqldanhmuc
            // 
            btqldanhmuc.Dock = DockStyle.Top;
            btqldanhmuc.FlatStyle = FlatStyle.Flat;
            btqldanhmuc.ForeColor = Color.White;
            btqldanhmuc.Location = new Point(0, 120);
            btqldanhmuc.Name = "btqldanhmuc";
            btqldanhmuc.Size = new Size(200, 60);
            btqldanhmuc.TabIndex = 3;
            btqldanhmuc.Text = "🍽 Quản lý menu";
            // 
            // btthongke
            // 
            btthongke.Dock = DockStyle.Top;
            btthongke.FlatStyle = FlatStyle.Flat;
            btthongke.ForeColor = Color.White;
            btthongke.Location = new Point(0, 60);
            btthongke.Name = "btthongke";
            btthongke.Size = new Size(200, 60);
            btthongke.TabIndex = 4;
            btthongke.Text = "📊 Thống kê";
            // 
            // btqldonhang
            // 
            btqldonhang.Dock = DockStyle.Top;
            btqldonhang.FlatStyle = FlatStyle.Flat;
            btqldonhang.ForeColor = Color.White;
            btqldonhang.Location = new Point(0, 0);
            btqldonhang.Name = "btqldonhang";
            btqldonhang.Size = new Size(200, 60);
            btqldonhang.TabIndex = 5;
            btqldonhang.Text = "📦 Quản lý đơn hàng";
            // 
            // NhanVien
            // 
            ClientSize = new Size(1304, 700);
            Controls.Add(panelMain);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimumSize = new Size(1320, 739);
            Name = "NhanVien";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Nhân Viên";
            panelMain.ResumeLayout(false);
            panelMainContent.ResumeLayout(false);
            panelContent.ResumeLayout(false);
            panelContent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvmenuNV).EndInit();
            panelSideBar.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelMain;
        private Panel panelMainContent;
        private Panel panelContent;
        private Label labelTitle;
        private DataGridView dgvmenuNV;
        private Label labelTenMon;
        private ComboBox cbbTenmonmenuNV;
        private Label labelSoLuong;
        private TextBox txbsoluongmenuNV;
        private Label labelDonGia;
        private TextBox txbdongiamenuNV;
        private Panel panelSideBar;
        private Button btDangXuat;
        private Button btqldonhang;
        private Button btthongke;
        private Button btqldanhmuc;
        private Button bttaodonhang;
        private Panel panelLogo;
    }
}
