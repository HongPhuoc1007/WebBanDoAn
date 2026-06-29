namespace DoAnNhom3
{
    partial class HoaDon
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
            panel1 = new Panel();
            flpMonAnHoaDon = new FlowLayoutPanel();
            tbxtongtien = new TextBox();
            label7 = new Label();
            btdathang = new Button();
            btnHuyDon = new Button();
            label6 = new Label();
            txbngaylaphoadon = new TextBox();
            label5 = new Label();
            txbsdtkh = new TextBox();
            label4 = new Label();
            txbmahoadon = new TextBox();
            label1 = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(flpMonAnHoaDon);
            panel1.Controls.Add(tbxtongtien);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btdathang);
            panel1.Controls.Add(btnHuyDon);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(txbngaylaphoadon);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(txbsdtkh);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(txbmahoadon);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(194, 45);
            panel1.Name = "panel1";
            panel1.Size = new Size(650, 550);
            panel1.TabIndex = 0;
            // 
            // flpMonAnHoaDon
            // 
            flpMonAnHoaDon.AutoScroll = true;
            flpMonAnHoaDon.FlowDirection = FlowDirection.TopDown;
            flpMonAnHoaDon.Location = new Point(20, 200);
            flpMonAnHoaDon.Name = "flpMonAnHoaDon";
            flpMonAnHoaDon.Size = new Size(600, 200);
            flpMonAnHoaDon.TabIndex = 0;
            flpMonAnHoaDon.WrapContents = false;
            // 
            // tbxtongtien
            // 
            tbxtongtien.Location = new Point(140, 420);
            tbxtongtien.Name = "tbxtongtien";
            tbxtongtien.Size = new Size(200, 23);
            tbxtongtien.TabIndex = 1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Times New Roman", 12F);
            label7.Location = new Point(30, 423);
            label7.Name = "label7";
            label7.Size = new Size(68, 19);
            label7.TabIndex = 2;
            label7.Text = "Tổng tiền:";
            // 
            // btdathang
            // 
            btdathang.Font = new Font("Times New Roman", 12F);
            btdathang.Location = new Point(360, 460);
            btdathang.Name = "btdathang";
            btdathang.Size = new Size(120, 35);
            btdathang.TabIndex = 3;
            btdathang.Text = "Đặt hàng";
            btdathang.UseVisualStyleBackColor = true;
            // 
            // btnHuyDon
            // 
            btnHuyDon.BackColor = Color.LightCoral;
            btnHuyDon.Font = new Font("Times New Roman", 12F);
            btnHuyDon.Location = new Point(490, 460);
            btnHuyDon.Name = "btnHuyDon";
            btnHuyDon.Size = new Size(120, 35);
            btnHuyDon.TabIndex = 4;
            btnHuyDon.Text = "Hủy đơn hàng";
            btnHuyDon.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Times New Roman", 12F);
            label6.Location = new Point(30, 90);
            label6.Name = "label6";
            label6.Size = new Size(67, 19);
            label6.TabIndex = 5;
            label6.Text = "Ngày lập:";
            // 
            // txbngaylaphoadon
            // 
            txbngaylaphoadon.Location = new Point(140, 90);
            txbngaylaphoadon.Name = "txbngaylaphoadon";
            txbngaylaphoadon.Size = new Size(200, 23);
            txbngaylaphoadon.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 12F);
            label5.Location = new Point(30, 130);
            label5.Name = "label5";
            label5.Size = new Size(68, 19);
            label5.TabIndex = 7;
            label5.Text = "SĐT KH:";
            // 
            // txbsdtkh
            // 
            txbsdtkh.Location = new Point(140, 130);
            txbsdtkh.Name = "txbsdtkh";
            txbsdtkh.Size = new Size(200, 23);
            txbsdtkh.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Times New Roman", 12F);
            label4.Location = new Point(30, 50);
            label4.Name = "label4";
            label4.Size = new Size(86, 19);
            label4.TabIndex = 9;
            label4.Text = "Mã hóa đơn:";
            // 
            // txbmahoadon
            // 
            txbmahoadon.Location = new Point(140, 50);
            txbmahoadon.Name = "txbmahoadon";
            txbmahoadon.Size = new Size(200, 23);
            txbmahoadon.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 18F);
            label1.Location = new Point(250, 10);
            label1.Name = "label1";
            label1.Size = new Size(119, 27);
            label1.TabIndex = 11;
            label1.Text = "HÓA ĐƠN";
            // 
            // HoaDon
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel1);
            Name = "HoaDon";
            Size = new Size(1000, 650);
            Load += HoaDon_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbmahoadon;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txbsdtkh;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbngaylaphoadon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btdathang;
        private System.Windows.Forms.Button btnHuyDon;
        private FlowLayoutPanel flpMonAnHoaDon;
        private System.Windows.Forms.TextBox tbxtongtien;
        private System.Windows.Forms.Label label7;
    }
}
