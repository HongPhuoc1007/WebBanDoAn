namespace DoAnNhom3
{
    partial class ucXemLSDonHang
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
            dgvLichSu = new DataGridView();
            lblTongTien = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.None;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(438, 46);
            label1.Name = "label1";
            label1.Size = new Size(243, 33);
            label1.TabIndex = 0;
            label1.Text = "Danh sách đơn hàng";
            // 
            // dgvLichSu
            // 
            dgvLichSu.Anchor = AnchorStyles.None;
            dgvLichSu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLichSu.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllHeaders;
            dgvLichSu.BackgroundColor = SystemColors.ButtonHighlight;
            dgvLichSu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLichSu.Location = new Point(172, 125);
            dgvLichSu.Name = "dgvLichSu";
            dgvLichSu.Size = new Size(769, 346);
            dgvLichSu.TabIndex = 1;
            dgvLichSu.CellContentClick += dgvDonHang_CellContentClick;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.None;
            lblTongTien.AutoSize = true;
            lblTongTien.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.Location = new Point(524, 495);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(53, 21);
            lblTongTien.TabIndex = 2;
            lblTongTien.Text = "label2";
            // 
            // ucXemLSDonHang
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(lblTongTien);
            Controls.Add(dgvLichSu);
            Controls.Add(label1);
            Name = "ucXemLSDonHang";
            Size = new Size(1081, 618);
            ((System.ComponentModel.ISupportInitialize)dgvLichSu).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dgvLichSu;
        private Label lblTongTien;
    }
}
