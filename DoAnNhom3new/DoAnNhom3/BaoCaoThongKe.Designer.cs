using DoAnNhom3.QuanLy;
using System;
using System.Data;
using System.Data.SqlClient;
using Microsoft.Data.SqlClient;

namespace DoAnNhom3
{
    partial class BaoCaoThongKe
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
            label2 = new Label();
            dtpTuNgay = new DateTimePicker();
            dtpDenNgay = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            dgvBaoCao = new DataGridView();
            rdoNgay = new RadioButton();
            rdoThang = new RadioButton();
            btnThongKe = new Button();
            lblTongDoanhThu = new Label();
            btnQuayLai = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(451, 34);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(193, 27);
            label1.TabIndex = 2;
            label1.Text = "Báo cáo doanh thu";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(199, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(109, 21);
            label2.TabIndex = 4;
            label2.Text = "Ngày bắt đầu";
            // 
            // dtpTuNgay
            // 
            dtpTuNgay.Anchor = AnchorStyles.None;
            dtpTuNgay.Location = new Point(219, 114);
            dtpTuNgay.Margin = new Padding(4, 3, 4, 3);
            dtpTuNgay.Name = "dtpTuNgay";
            dtpTuNgay.Size = new Size(188, 23);
            dtpTuNgay.TabIndex = 6;
            // 
            // dtpDenNgay
            // 
            dtpDenNgay.Anchor = AnchorStyles.None;
            dtpDenNgay.Location = new Point(500, 114);
            dtpDenNgay.Margin = new Padding(4, 3, 4, 3);
            dtpDenNgay.Name = "dtpDenNgay";
            dtpDenNgay.Size = new Size(188, 23);
            dtpDenNgay.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(471, 90);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(113, 21);
            label4.TabIndex = 8;
            label4.Text = "Ngày kết thúc";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(485, 267);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(128, 21);
            label5.TabIndex = 10;
            label5.Text = "Bảng Thống Kê";
            label5.Click += label5_Click;
            // 
            // dgvBaoCao
            // 
            dgvBaoCao.Anchor = AnchorStyles.None;
            dgvBaoCao.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBaoCao.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvBaoCao.Location = new Point(219, 304);
            dgvBaoCao.Margin = new Padding(4, 3, 4, 3);
            dgvBaoCao.Name = "dgvBaoCao";
            dgvBaoCao.Size = new Size(645, 202);
            dgvBaoCao.TabIndex = 11;
            dgvBaoCao.CellContentClick += dgvBaoCao_CellContentClick;
            // 
            // rdoNgay
            // 
            rdoNgay.AutoSize = true;
            rdoNgay.Checked = true;
            rdoNgay.Font = new Font("Times New Roman", 11.25F);
            rdoNgay.Location = new Point(203, 166);
            rdoNgay.Margin = new Padding(4, 3, 4, 3);
            rdoNgay.Name = "rdoNgay";
            rdoNgay.Size = new Size(92, 21);
            rdoNgay.TabIndex = 12;
            rdoNgay.TabStop = true;
            rdoNgay.Text = "Theo Ngày";
            rdoNgay.UseVisualStyleBackColor = true;
            // 
            // rdoThang
            // 
            rdoThang.AutoSize = true;
            rdoThang.Font = new Font("Times New Roman", 11.25F);
            rdoThang.Location = new Point(203, 193);
            rdoThang.Margin = new Padding(4, 3, 4, 3);
            rdoThang.Name = "rdoThang";
            rdoThang.Size = new Size(97, 21);
            rdoThang.TabIndex = 13;
            rdoThang.Text = "Theo Tháng";
            rdoThang.UseVisualStyleBackColor = true;
            // 
            // btnThongKe
            // 
            btnThongKe.Anchor = AnchorStyles.None;
            btnThongKe.BackColor = SystemColors.MenuHighlight;
            btnThongKe.FlatAppearance.BorderSize = 0;
            btnThongKe.FlatStyle = FlatStyle.Flat;
            btnThongKe.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnThongKe.Location = new Point(388, 536);
            btnThongKe.Margin = new Padding(4, 3, 4, 3);
            btnThongKe.Name = "btnThongKe";
            btnThongKe.Size = new Size(103, 27);
            btnThongKe.TabIndex = 14;
            btnThongKe.Text = "Thống Kê";
            btnThongKe.UseVisualStyleBackColor = true;
            btnThongKe.Click += btnThongKe_Click;
            // 
            // lblTongDoanhThu
            // 
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTongDoanhThu.Location = new Point(199, 236);
            lblTongDoanhThu.Margin = new Padding(4, 0, 4, 0);
            lblTongDoanhThu.Name = "lblTongDoanhThu";
            lblTongDoanhThu.Size = new Size(139, 21);
            lblTongDoanhThu.TabIndex = 15;
            lblTongDoanhThu.Text = "Tổng Doanh Thu";
            lblTongDoanhThu.Click += label6_Click;
            // 
            // btnQuayLai
            // 
            btnQuayLai.Anchor = AnchorStyles.None;
            btnQuayLai.BackColor = Color.MediumTurquoise;
            btnQuayLai.FlatAppearance.BorderSize = 0;
            btnQuayLai.FlatStyle = FlatStyle.Flat;
            btnQuayLai.Font = new Font("Times New Roman", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnQuayLai.Location = new Point(614, 536);
            btnQuayLai.Name = "btnQuayLai";
            btnQuayLai.Size = new Size(88, 27);
            btnQuayLai.TabIndex = 16;
            btnQuayLai.Text = "Quay Lại";
            btnQuayLai.UseVisualStyleBackColor = true;
            btnQuayLai.Click += btnQuayLai_Click;
            // 
            // BaoCaoThongKe
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnQuayLai);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(btnThongKe);
            Controls.Add(rdoThang);
            Controls.Add(rdoNgay);
            Controls.Add(dgvBaoCao);
            Controls.Add(label5);
            Controls.Add(dtpDenNgay);
            Controls.Add(label4);
            Controls.Add(dtpTuNgay);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            Name = "BaoCaoThongKe";
            Size = new Size(1081, 618);
            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpTuNgay;
        private System.Windows.Forms.DateTimePicker dtpDenNgay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvBaoCao;
        private System.Windows.Forms.RadioButton rdoNgay;
        private System.Windows.Forms.RadioButton rdoThang;
        private System.Windows.Forms.Button btnThongKe;
        private System.Windows.Forms.Label lblTongDoanhThu;
        private Button btnQuayLai;
    }
}
