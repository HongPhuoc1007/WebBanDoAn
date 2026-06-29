namespace DoAnNhom3
{
    partial class QuanLiKhachHang
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            dgvkhachhang = new DataGridView();
            btnQuayLai = new Button();
            label3 = new Label();
            dgvTaiKhoan = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvkhachhang).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(189, 72);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(229, 27);
            label1.TabIndex = 2;
            label1.Text = "Danh sách khách hàng";
            // 
            // dgvkhachhang
            // 
            dgvkhachhang.Anchor = AnchorStyles.None;
            dgvkhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvkhachhang.BackgroundColor = SystemColors.ButtonHighlight;
            dgvkhachhang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvkhachhang.Location = new Point(109, 132);
            dgvkhachhang.Margin = new Padding(4, 3, 4, 3);
            dgvkhachhang.Name = "dgvkhachhang";
            dgvkhachhang.Size = new Size(390, 372);
            dgvkhachhang.TabIndex = 3;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.None;
            btnQuayLai.Location = new Point(487, 553);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(75, 23);
            btnQuayLai.TabIndex = 4;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.None;
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(630, 72);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(223, 27);
            label3.TabIndex = 6;
            label3.Text = "Danh Sách Tài Khoản";
            // 
            // dgvTaiKhoan
            // 
            dgvTaiKhoan.Anchor = AnchorStyles.None;
            dgvTaiKhoan.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTaiKhoan.BackgroundColor = SystemColors.ButtonHighlight;
            dgvTaiKhoan.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTaiKhoan.Location = new Point(569, 132);
            dgvTaiKhoan.Margin = new Padding(4, 3, 4, 3);
            dgvTaiKhoan.Name = "dgvTaiKhoan";
            dgvTaiKhoan.Size = new Size(392, 372);
            dgvTaiKhoan.TabIndex = 7;
            // 
            // QuanLiKhachHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            Controls.Add(dgvTaiKhoan);
            Controls.Add(label3);
            Controls.Add(btnQuayLai);
            Controls.Add(dgvkhachhang);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "QuanLiKhachHang";
            Size = new Size(1081, 618);
            ((System.ComponentModel.ISupportInitialize)dgvkhachhang).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgvTaiKhoan).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvkhachhang;
        private Button btnQuayLai;
        private Label label3;
        private DataGridView dgvTaiKhoan;
    }
}
