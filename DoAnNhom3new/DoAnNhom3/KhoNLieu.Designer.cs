namespace DoAnNhom3
{
    partial class KhoNLieu
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
            dgvKhoNLieu = new DataGridView();
            btnQuayLai = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvKhoNLieu).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(436, 27);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(270, 33);
            label1.TabIndex = 2;
            label1.Text = "Danh sách nguyên liệu";
            // 
            // dgvKhoNLieu
            // 
            dgvKhoNLieu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvKhoNLieu.BackgroundColor = SystemColors.ButtonHighlight;
            dgvKhoNLieu.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvKhoNLieu.Location = new Point(216, 96);
            dgvKhoNLieu.Margin = new Padding(4, 3, 4, 3);
            dgvKhoNLieu.Name = "dgvKhoNLieu";
            dgvKhoNLieu.Size = new Size(636, 397);
            dgvKhoNLieu.TabIndex = 3;
            dgvKhoNLieu.CellContentClick += dgvKhoNLieu_CellContentClick;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Location = new Point(525, 521);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(75, 23);
            btnQuayLai.TabIndex = 4;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += button1_Click;
            // 
            // KhoNLieu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            Controls.Add(btnQuayLai);
            Controls.Add(dgvKhoNLieu);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "KhoNLieu";
            Size = new Size(1081, 618);
            ((System.ComponentModel.ISupportInitialize)dgvKhoNLieu).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvKhoNLieu;
        private Button btnQuayLai;
    }
}
