namespace DoAnNhom3
{
    partial class ChinhSuaMenu
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
            dataGridView1 = new DataGridView();
            textMaMon = new TextBox();
            textTenMon = new TextBox();
            textGiaTien = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            btThemNV = new Button();
            btSuaNV = new Button();
            btXoaNV = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(90, 105);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(540, 309);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dgvdsnv_CellClick;
            // 
            // textMaMon
            // 
            textMaMon.Location = new Point(714, 163);
            textMaMon.Name = "textMaMon";
            textMaMon.Size = new Size(206, 23);
            textMaMon.TabIndex = 1;
            // 
            // textTenMon
            // 
            textTenMon.Location = new Point(714, 248);
            textTenMon.Name = "textTenMon";
            textTenMon.Size = new Size(206, 23);
            textTenMon.TabIndex = 2;
            // 
            // textGiaTien
            // 
            textGiaTien.Location = new Point(714, 337);
            textGiaTien.Name = "textGiaTien";
            textGiaTien.Size = new Size(206, 23);
            textGiaTien.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(483, 29);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(222, 33);
            label1.TabIndex = 5;
            label1.Text = "Danh sách món ăn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(714, 139);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(72, 21);
            label2.TabIndex = 7;
            label2.Text = "Mã món";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(714, 224);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(77, 21);
            label3.TabIndex = 8;
            label3.Text = "Tên món";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(714, 313);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 9;
            label4.Text = "Giá Tiền";
            // 
            // btThemNV
            // 
            btThemNV.BackColor = Color.MediumTurquoise;
            btThemNV.FlatAppearance.BorderSize = 0;
            btThemNV.FlatStyle = FlatStyle.Flat;
            btThemNV.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btThemNV.Location = new Point(234, 467);
            btThemNV.Margin = new Padding(4, 3, 4, 3);
            btThemNV.Name = "btThemNV";
            btThemNV.Size = new Size(153, 52);
            btThemNV.TabIndex = 15;
            btThemNV.Text = "Thêm";
            btThemNV.UseVisualStyleBackColor = false;
            btThemNV.Click += btThemNV_Click;
            // 
            // btSuaNV
            // 
            btSuaNV.BackColor = Color.MediumTurquoise;
            btSuaNV.FlatAppearance.BorderSize = 0;
            btSuaNV.FlatStyle = FlatStyle.Flat;
            btSuaNV.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btSuaNV.Location = new Point(501, 467);
            btSuaNV.Margin = new Padding(4, 3, 4, 3);
            btSuaNV.Name = "btSuaNV";
            btSuaNV.Size = new Size(153, 52);
            btSuaNV.TabIndex = 17;
            btSuaNV.Text = "Sửa";
            btSuaNV.UseVisualStyleBackColor = false;
            btSuaNV.Click += btSuaNV_Click;
            // 
            // btXoaNV
            // 
            btXoaNV.BackColor = Color.MediumTurquoise;
            btXoaNV.FlatAppearance.BorderSize = 0;
            btXoaNV.FlatStyle = FlatStyle.Flat;
            btXoaNV.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btXoaNV.Location = new Point(741, 467);
            btXoaNV.Margin = new Padding(4, 3, 4, 3);
            btXoaNV.Name = "btXoaNV";
            btXoaNV.Size = new Size(153, 52);
            btXoaNV.TabIndex = 18;
            btXoaNV.Text = "Xóa";
            btXoaNV.UseVisualStyleBackColor = false;
            btXoaNV.Click += btXoaNV_Click;
            // 
            // ChinhSuaMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btXoaNV);
            Controls.Add(btSuaNV);
            Controls.Add(btThemNV);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textGiaTien);
            Controls.Add(textTenMon);
            Controls.Add(textMaMon);
            Controls.Add(dataGridView1);
            Name = "ChinhSuaMenu";
            Size = new Size(1081, 618);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private TextBox textMaMon;
        private TextBox textTenMon;
        private TextBox textGiaTien;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button btThemNV;
        private Button btSuaNV;
        private Button btXoaNV;
    }
}
