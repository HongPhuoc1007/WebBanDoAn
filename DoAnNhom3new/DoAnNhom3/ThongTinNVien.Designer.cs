namespace DoAnNhom3
{
    partial class ThongTinNVien
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
            btSuaNV = new Button();
            label2 = new Label();
            txbmanhanvien = new TextBox();
            label3 = new Label();
            txbsdt = new TextBox();
            label4 = new Label();
            txbtennhanvien = new TextBox();
            label5 = new Label();
            txbdiachi = new TextBox();
            btThemNV = new Button();
            btXoaNV = new Button();
            dgvdsnv = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvdsnv).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(446, 36);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(249, 33);
            label1.TabIndex = 1;
            label1.Text = "Danh sách nhân viên";
            // 
            // btSuaNV
            // 
            btSuaNV.BackColor = Color.MediumTurquoise;
            btSuaNV.FlatAppearance.BorderSize = 0;
            btSuaNV.FlatStyle = FlatStyle.Flat;
            btSuaNV.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSuaNV.Location = new Point(484, 484);
            btSuaNV.Margin = new Padding(4, 3, 4, 3);
            btSuaNV.Name = "btSuaNV";
            btSuaNV.Size = new Size(153, 52);
            btSuaNV.TabIndex = 16;
            btSuaNV.Text = "Sửa";
            btSuaNV.UseVisualStyleBackColor = false;
            btSuaNV.Click += btSuaNV_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(689, 136);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 6;
            label2.Text = "Mã nhân viên";
            label2.Click += label2_Click;
            // 
            // txbmanhanvien
            // 
            txbmanhanvien.Location = new Point(694, 163);
            txbmanhanvien.Margin = new Padding(4, 3, 4, 3);
            txbmanhanvien.Name = "txbmanhanvien";
            txbmanhanvien.Size = new Size(224, 23);
            txbmanhanvien.TabIndex = 7;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(691, 295);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(108, 21);
            label3.TabIndex = 8;
            label3.Text = "Số điện thoại";
            // 
            // txbsdt
            // 
            txbsdt.Location = new Point(695, 322);
            txbsdt.Margin = new Padding(4, 3, 4, 3);
            txbsdt.Name = "txbsdt";
            txbsdt.Size = new Size(224, 23);
            txbsdt.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(689, 215);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(114, 21);
            label4.TabIndex = 10;
            label4.Text = "Tên nhân viên";
            // 
            // txbtennhanvien
            // 
            txbtennhanvien.Location = new Point(694, 243);
            txbtennhanvien.Margin = new Padding(4, 3, 4, 3);
            txbtennhanvien.Name = "txbtennhanvien";
            txbtennhanvien.Size = new Size(224, 23);
            txbtennhanvien.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(691, 377);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(65, 21);
            label5.TabIndex = 12;
            label5.Text = "Địa chỉ";
            // 
            // txbdiachi
            // 
            txbdiachi.Location = new Point(694, 404);
            txbdiachi.Margin = new Padding(4, 3, 4, 3);
            txbdiachi.Name = "txbdiachi";
            txbdiachi.Size = new Size(224, 23);
            txbdiachi.TabIndex = 13;
            txbdiachi.TextChanged += textBox3_TextChanged;
            // 
            // btThemNV
            // 
            btThemNV.BackColor = Color.MediumTurquoise;
            btThemNV.FlatAppearance.BorderSize = 0;
            btThemNV.FlatStyle = FlatStyle.Flat;
            btThemNV.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThemNV.Location = new Point(242, 484);
            btThemNV.Margin = new Padding(4, 3, 4, 3);
            btThemNV.Name = "btThemNV";
            btThemNV.Size = new Size(153, 52);
            btThemNV.TabIndex = 14;
            btThemNV.Text = "Thêm";
            btThemNV.UseVisualStyleBackColor = false;
            btThemNV.Click += btThemNV_Click;
            // 
            // btXoaNV
            // 
            btXoaNV.BackColor = Color.MediumTurquoise;
            btXoaNV.FlatAppearance.BorderSize = 0;
            btXoaNV.FlatStyle = FlatStyle.Flat;
            btXoaNV.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btXoaNV.Location = new Point(710, 484);
            btXoaNV.Margin = new Padding(4, 3, 4, 3);
            btXoaNV.Name = "btXoaNV";
            btXoaNV.Size = new Size(153, 52);
            btXoaNV.TabIndex = 15;
            btXoaNV.Text = "Xóa";
            btXoaNV.UseVisualStyleBackColor = false;
            btXoaNV.Click += btXoaNV_Click;
            // 
            // dgvdsnv
            // 
            dgvdsnv.Anchor = AnchorStyles.None;
            dgvdsnv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvdsnv.BackgroundColor = SystemColors.ButtonHighlight;
            dgvdsnv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvdsnv.Location = new Point(59, 126);
            dgvdsnv.Margin = new Padding(4, 3, 4, 3);
            dgvdsnv.Name = "dgvdsnv";
            dgvdsnv.Size = new Size(567, 316);
            dgvdsnv.TabIndex = 2;
            dgvdsnv.CellClick += dgvdsnv_CellClick;
            dgvdsnv.CellContentClick += dgvdsnv_CellContentClick;
            // 
            // ThongTinNVien
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btSuaNV);
            Controls.Add(btXoaNV);
            Controls.Add(btThemNV);
            Controls.Add(txbdiachi);
            Controls.Add(label5);
            Controls.Add(txbtennhanvien);
            Controls.Add(label4);
            Controls.Add(txbsdt);
            Controls.Add(label3);
            Controls.Add(txbmanhanvien);
            Controls.Add(label2);
            Controls.Add(dgvdsnv);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "ThongTinNVien";
            Size = new Size(1081, 618);
            ((System.ComponentModel.ISupportInitialize)dgvdsnv).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSuaNV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbmanhanvien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txbsdt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbtennhanvien;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbdiachi;
        private System.Windows.Forms.Button btThemNV;
        private System.Windows.Forms.Button btXoaNV;
        private System.Windows.Forms.DataGridView dgvdsnv;
    }
}
