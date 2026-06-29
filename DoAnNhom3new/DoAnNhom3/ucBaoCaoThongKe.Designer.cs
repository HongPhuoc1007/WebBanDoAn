using System.Windows.Forms.DataVisualization.Charting;

namespace DoAnNhom3
{
    partial class ucBaoCaoThongKe
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
            components = new System.ComponentModel.Container();
            btnQuayLai = new Button();
            lblTongDoanhThu = new Label();
            btnThongKe = new Button();
            dgvBaoCao = new DataGridView();
            label5 = new Label();
            label1 = new Label();
            labelNgay = new Label();
            dtpNgayThongKe = new DateTimePicker();
            btnTaiLai = new Button();
            btnXoaBaoCao = new Button();
            btnXuatExcel = new Button();
            btnTopMon = new Button();
            chartTop3Mon = new Chart();

            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).BeginInit();
            SuspendLayout();

            // label tiêu đề
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 21.75F, FontStyle.Regular);
            label1.Location = new Point(458, 21);
            label1.Text = "Báo cáo doanh thu";

            // label ngày
            labelNgay.Font = new Font("Times New Roman", 14F);
            labelNgay.Location = new Point(90, 111);
            labelNgay.Size = new Size(200, 23);
            labelNgay.Text = "Chọn ngày thống kê";

            // datetimepicker
            dtpNgayThongKe.Location = new Point(138, 150);
            dtpNgayThongKe.Size = new Size(200, 23);

            // tổng doanh thu
            lblTongDoanhThu.AutoSize = true;
            lblTongDoanhThu.Font = new Font("Times New Roman", 14.25F);
            lblTongDoanhThu.Location = new Point(90, 191);
            lblTongDoanhThu.Text = "Tổng Doanh Thu";

            // label bảng thống kê
            label5.AutoSize = true;
            label5.Font = new Font("Times New Roman", 15.75F);
            label5.Location = new Point(90, 247);
            label5.Text = "Bảng Thống Kê";

            // dgvBaoCao
            dgvBaoCao.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvBaoCao.BackgroundColor = SystemColors.ButtonHighlight;
            dgvBaoCao.Location = new Point(90, 299);
            dgvBaoCao.Size = new Size(645, 202);

            // btnThongKe
            btnThongKe.Text = "Thống kê";
            btnThongKe.BackColor = Color.MediumTurquoise;
            btnThongKe.Font = new Font("Times New Roman", 12F);
            btnThongKe.Location = new Point(90, 529);
            btnThongKe.Size = new Size(110, 35);

            // btnTaiLai
            btnTaiLai.Text = "Tải lại";
            btnTaiLai.BackColor = Color.LightSkyBlue;
            btnTaiLai.Font = new Font("Times New Roman", 12F);
            btnTaiLai.Location = new Point(206, 529);
            btnTaiLai.Size = new Size(100, 35);

            // btnXoaBaoCao
            btnXoaBaoCao.Text = "Xóa báo cáo";
            btnXoaBaoCao.BackColor = Color.LightCoral;
            btnXoaBaoCao.Font = new Font("Times New Roman", 12F);
            btnXoaBaoCao.Location = new Point(312, 529);
            btnXoaBaoCao.Size = new Size(110, 35);

            // btnXuatExcel
            btnXuatExcel.Text = "Xuất Excel";
            btnXuatExcel.BackColor = Color.Gold;
            btnXuatExcel.Font = new Font("Times New Roman", 12F);
            btnXuatExcel.Location = new Point(428, 529);
            btnXuatExcel.Size = new Size(110, 35);

            // btnQuayLai
            btnQuayLai.Text = "Quay lại";
            btnQuayLai.BackColor = Color.Gray;
            btnQuayLai.Font = new Font("Times New Roman", 12F);
            btnQuayLai.Location = new Point(544, 529);
            btnQuayLai.Size = new Size(100, 35);

            // btnTopMon
            btnTopMon.Text = "Top món bán chạy";
            btnTopMon.BackColor = Color.MediumPurple;
            btnTopMon.Font = new Font("Times New Roman", 12F);
            btnTopMon.Location = new Point(660, 529);
            btnTopMon.Size = new Size(150, 35);

            // chartTop3Mon
            chartTop3Mon.Location = new Point(760, 240);
            chartTop3Mon.Size = new Size(400, 250);
            ChartArea chartArea = new ChartArea();
            chartArea.AxisX.Title = "Món ăn";
            chartArea.AxisY.Title = "Số lượng bán";
            chartTop3Mon.ChartAreas.Add(chartArea);
            Series series = new Series("Top3");
            series.ChartType = SeriesChartType.Column;
            series.Color = Color.SteelBlue;
            chartTop3Mon.Series.Add(series);

            // add controls
            Controls.Add(label1);
            Controls.Add(labelNgay);
            Controls.Add(dtpNgayThongKe);
            Controls.Add(lblTongDoanhThu);
            Controls.Add(label5);
            Controls.Add(dgvBaoCao);
            Controls.Add(btnThongKe);
            Controls.Add(btnTaiLai);
            Controls.Add(btnXoaBaoCao);
            Controls.Add(btnXuatExcel);
            Controls.Add(btnQuayLai);
            Controls.Add(btnTopMon);
            Controls.Add(chartTop3Mon);

            Name = "ucBaoCaoThongKe";
            Size = new Size(1200, 600);

            ((System.ComponentModel.ISupportInitialize)dgvBaoCao).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnQuayLai;
        private Label lblTongDoanhThu;
        private Button btnThongKe;
        private DataGridView dgvBaoCao;
        private Label label5;
        private Label label1;
        private DateTimePicker dtpNgayThongKe;
        private Label labelNgay;
        private Button btnTaiLai;
        private Button btnXoaBaoCao;
        private Button btnXuatExcel;
        private Button btnTopMon;
        private Chart chartTop3Mon;
    }
}