using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DoAnNhom3.Model;
using DoAnNhom3.QuanLy;
using Microsoft.Identity.Client.NativeInterop;

namespace DoAnNhom3
{
    public partial class ucMenuMonAn : UserControl
    {
        public ucMenuMonAn()
        {
            InitializeComponent();
            UC_Menu_Load();
        }

        private void flpgiohang_Paint(object sender, PaintEventArgs e)
        {

        }
        //object sender, EventArgs e
        private void UC_Menu_Load()
        {
            string query = "SELECT MaMon, TenMon, GiaTien, HinhAnh FROM MonAn";
            DataTable dt = Database.GetData(query);

            flpgiohang.Controls.Clear();

            foreach (DataRow row in dt.Rows)
            {
                string ma = row["MaMon"].ToString();
                string ten = row["TenMon"].ToString();
                decimal gia = Convert.ToDecimal(row["GiaTien"]);
                string tenAnh = row["HinhAnh"].ToString();

                string duongDanAnh = Path.Combine(Application.StartupPath, "HinhAnh", tenAnh);

                Image anh = File.Exists(duongDanAnh)
                    ? Image.FromFile(duongDanAnh)
                    : null; // ảnh mặc định nếu không có

                ucMonAn item = new ucMonAn(ma, ten, gia, anh);
                flpgiohang.Controls.Add(item);
            }
        }

    }
}
