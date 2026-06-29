namespace DoAnNhom3
{
    partial class ucMenuMonAn
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
            flpgiohang = new FlowLayoutPanel();
            flpMenu = new FlowLayoutPanel();
            label1 = new Label();
            flpgiohang.SuspendLayout();
            SuspendLayout();
            // 
            // flpgiohang
            // 
            flpgiohang.AutoScroll = true;
            flpgiohang.BackColor = SystemColors.Control;
            flpgiohang.Controls.Add(flpMenu);
            flpgiohang.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            flpgiohang.Location = new Point(162, 105);
            flpgiohang.Name = "flpgiohang";
            flpgiohang.Padding = new Padding(10);
            flpgiohang.Size = new Size(919, 510);
            flpgiohang.TabIndex = 0;
            flpgiohang.Paint += flpgiohang_Paint;
            // 
            // flpMenu
            // 
            flpMenu.AutoScroll = true;
            flpMenu.Dock = DockStyle.Fill;
            flpMenu.Location = new Point(13, 13);
            flpMenu.Name = "flpMenu";
            flpMenu.Size = new Size(754, 0);
            flpMenu.TabIndex = 0;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left;
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(607, 28);
            label1.Name = "label1";
            label1.Size = new Size(101, 33);
            label1.TabIndex = 2;
            label1.Text = "MENU";
            // 
            // ucMenuMonAn
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Controls.Add(flpgiohang);
            Name = "ucMenuMonAn";
            Size = new Size(1081, 618);
            flpgiohang.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel flpgiohang;
        private Label label1;
        private FlowLayoutPanel flpMenu;
    }
}
