using System.Windows.Forms;
using System.Drawing;

namespace DoAnNhom3
{
    partial class QuanLiDonHang
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            button4 = new Button();
            dgvDonHang = new DataGridView();
            btnTaiLai = new Button();
            btnSua = new Button();
            btnXoa = new Button();
            btnExcel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).BeginInit();
            SuspendLayout();
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.None;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Times New Roman", 21.75F);
            button4.ForeColor = Color.Black;
            button4.Location = new Point(449, 51);
            button4.Name = "button4";
            button4.Size = new Size(300, 44);
            button4.TabIndex = 0;
            button4.Text = "Danh sách đơn hàng";
            button4.UseVisualStyleBackColor = true;
            // 
            // dgvDonHang
            // 
            dgvDonHang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvDonHang.BackgroundColor = SystemColors.ButtonHighlight;
            dgvDonHang.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDonHang.Location = new Point(170, 241);
            dgvDonHang.Name = "dgvDonHang";
            dgvDonHang.Size = new Size(880, 300);
            dgvDonHang.TabIndex = 1;
            // 
            // btnTaiLai
            // 
            btnTaiLai.BackColor = Color.MediumTurquoise;
            btnTaiLai.FlatAppearance.BorderSize = 0;
            btnTaiLai.FlatStyle = FlatStyle.Flat;
            btnTaiLai.Font = new Font("Times New Roman", 12F);
            btnTaiLai.Location = new Point(590, 561);
            btnTaiLai.Name = "btnTaiLai";
            btnTaiLai.Size = new Size(100, 40);
            btnTaiLai.TabIndex = 2;
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.UseVisualStyleBackColor = false;
            // 
            // btnSua
            // 
            btnSua.BackColor = Color.LightGreen;
            btnSua.FlatAppearance.BorderSize = 0;
            btnSua.FlatStyle = FlatStyle.Flat;
            btnSua.Font = new Font("Times New Roman", 12F);
            btnSua.Location = new Point(270, 561);
            btnSua.Name = "btnSua";
            btnSua.Size = new Size(100, 40);
            btnSua.TabIndex = 3;
            btnSua.Text = "Sửa";
            btnSua.UseVisualStyleBackColor = false;
            // 
            // btnXoa
            // 
            btnXoa.BackColor = Color.LightCoral;
            btnXoa.FlatAppearance.BorderSize = 0;
            btnXoa.FlatStyle = FlatStyle.Flat;
            btnXoa.Font = new Font("Times New Roman", 12F);
            btnXoa.Location = new Point(390, 561);
            btnXoa.Name = "btnXoa";
            btnXoa.Size = new Size(100, 40);
            btnXoa.TabIndex = 4;
            btnXoa.Text = "Xóa";
            btnXoa.UseVisualStyleBackColor = false;
            // 
            // btnExcel
            // 
            btnExcel.BackColor = Color.Gold;
            btnExcel.FlatAppearance.BorderSize = 0;
            btnExcel.FlatStyle = FlatStyle.Flat;
            btnExcel.Font = new Font("Times New Roman", 12F);
            btnExcel.Location = new Point(710, 561);
            btnExcel.Name = "btnExcel";
            btnExcel.Size = new Size(120, 40);
            btnExcel.TabIndex = 5;
            btnExcel.Text = "Xuất Excel";
            btnExcel.UseVisualStyleBackColor = false;
            // 
            // QuanLiDonHang
            // 
            Controls.Add(button4);
            Controls.Add(dgvDonHang);
            Controls.Add(btnTaiLai);
            Controls.Add(btnSua);
            Controls.Add(btnXoa);
            Controls.Add(btnExcel);
            Name = "QuanLiDonHang";
            Size = new Size(1149, 626);
            ((System.ComponentModel.ISupportInitialize)dgvDonHang).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button4;
        private DataGridView dgvDonHang;
        private Button btnSua;
        private Button btnXoa;
        private Button btnExcel;
        private Button btnTaiLai;
    }
}
