using System;
using System.Windows.Forms; 

namespace DoAnNhom3
{
    static class Program
    {
        /// <summary>
        /// Điểm khởi động chính của ứng dụng
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Mở trực tiếp form NhanVien (form chính của bạn)
            Application.Run(new DangNhap());
        }
    }
}

