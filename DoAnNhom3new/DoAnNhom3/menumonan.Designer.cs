namespace DoAnNhom3
{
    partial class menumonan
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ptbgancon = new System.Windows.Forms.PictureBox();
            this.btgiohang = new System.Windows.Forms.Button();
            this.btmuangay = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ptbgancon)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gà rán nguyên con";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(48, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "150.000";
            // 
            // ptbgancon
            // 
            this.ptbgancon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
//            this.ptbgancon.Image = global::DoAnNhom3.Properties.Resources.garan;
            this.ptbgancon.Location = new System.Drawing.Point(1, 1);
            this.ptbgancon.Name = "ptbgancon";
            this.ptbgancon.Size = new System.Drawing.Size(152, 110);
            this.ptbgancon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbgancon.TabIndex = 0;
            this.ptbgancon.TabStop = false;
            // 
            // btgiohang
            // 
    //        this.btgiohang.BackgroundImage = global::DoAnNhom3.Properties.Resources.giohang;
            this.btgiohang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btgiohang.Location = new System.Drawing.Point(115, 164);
            this.btgiohang.Name = "btgiohang";
            this.btgiohang.Size = new System.Drawing.Size(35, 31);
            this.btgiohang.TabIndex = 21;
            this.btgiohang.UseVisualStyleBackColor = true;
            // 
            // btmuangay
            // 
            this.btmuangay.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btmuangay.Location = new System.Drawing.Point(16, 164);
            this.btmuangay.Name = "btmuangay";
            this.btmuangay.Size = new System.Drawing.Size(93, 31);
            this.btmuangay.TabIndex = 20;
            this.btmuangay.Text = "Mua ngay";
            this.btmuangay.UseVisualStyleBackColor = true;
            // 
            // menumonan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.btgiohang);
            this.Controls.Add(this.btmuangay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbgancon);
            this.Name = "menumonan";
            this.Size = new System.Drawing.Size(153, 209);
            ((System.ComponentModel.ISupportInitialize)(this.ptbgancon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox ptbgancon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btgiohang;
        private System.Windows.Forms.Button btmuangay;
    }
}
