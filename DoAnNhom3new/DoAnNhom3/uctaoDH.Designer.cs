namespace DoAnNhom3
{
    partial class uctaoDH
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
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            labelgiohang = new Label();
            panel2 = new Panel();
            lblTongTien = new Label();
            btthanhtoanKH = new Button();
            dataGridView1 = new DataGridView();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 0F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 2);
            tableLayoutPanel1.Controls.Add(dataGridView1, 1, 1);
            tableLayoutPanel1.Location = new Point(261, 114);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 11.5727005F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 88.4273F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 44F));
            tableLayoutPanel1.Size = new Size(553, 382);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.Controls.Add(labelgiohang);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(547, 33);
            panel1.TabIndex = 0;
            // 
            // labelgiohang
            // 
            labelgiohang.Anchor = AnchorStyles.None;
            labelgiohang.AutoSize = true;
            labelgiohang.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelgiohang.Location = new Point(228, 0);
            labelgiohang.Name = "labelgiohang";
            labelgiohang.Size = new Size(117, 33);
            labelgiohang.TabIndex = 4;
            labelgiohang.Text = "Giỏ hàng";
            labelgiohang.Click += labelgiohang_Click;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.None;
            panel2.Controls.Add(lblTongTien);
            panel2.Controls.Add(btthanhtoanKH);
            panel2.Location = new Point(3, 340);
            panel2.Name = "panel2";
            panel2.Size = new Size(547, 39);
            panel2.TabIndex = 1;
            // 
            // lblTongTien
            // 
            lblTongTien.Anchor = AnchorStyles.None;
            lblTongTien.AutoSize = true;
            lblTongTien.BackColor = SystemColors.Control;
            lblTongTien.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongTien.ForeColor = Color.Red;
            lblTongTien.Location = new Point(346, 9);
            lblTongTien.Name = "lblTongTien";
            lblTongTien.Size = new Size(53, 21);
            lblTongTien.TabIndex = 41;
            lblTongTien.Text = "label2";
            // 
            // btthanhtoanKH
            // 
            btthanhtoanKH.Anchor = AnchorStyles.None;
            btthanhtoanKH.BackColor = Color.MediumTurquoise;
            btthanhtoanKH.FlatAppearance.BorderSize = 0;
            btthanhtoanKH.FlatStyle = FlatStyle.Flat;
            btthanhtoanKH.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btthanhtoanKH.Location = new Point(190, 0);
            btthanhtoanKH.Name = "btthanhtoanKH";
            btthanhtoanKH.Size = new Size(133, 39);
            btthanhtoanKH.TabIndex = 40;
            btthanhtoanKH.Text = "Thanh toán";
            btthanhtoanKH.UseVisualStyleBackColor = false;
            btthanhtoanKH.Click += btthanhtoanKH_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.None;
            dataGridView1.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(3, 42);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(547, 292);
            dataGridView1.TabIndex = 2;
            // 
            // uctaoDH
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tableLayoutPanel1);
            Name = "uctaoDH";
            Size = new Size(1081, 618);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Label labelgiohang;
        private Button btthanhtoanKH;
        private DataGridView dataGridView1;
        private Label lblTongTien;
    }
}
