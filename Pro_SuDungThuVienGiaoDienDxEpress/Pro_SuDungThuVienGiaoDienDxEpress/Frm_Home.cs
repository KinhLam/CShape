using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pro_SuDungThuVienGiaoDienDxEpress
{
    public partial class Frm_Home : Form
    {
        public Frm_Home()
        {
            InitializeComponent();
        }

        public Frm_Main frm;
        public delegate void _doDongTab();//Khai báo đối tượng có tên delegate với hàm trả về
        public _doDongTab DongTab;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_Home_Load(object sender, EventArgs e)
        {
            List<Product> products = new List<Product>()
            {

                new Product() { STT = 1, ProductName="Banh mi",Price=20000,Category="Thuc Pham"},
                new Product() { STT = 2, ProductName="Banh da",Price=30000,Category="Thuc Pham"},
                new Product() { STT = 3, ProductName="Banh cuon",Price=40000,Category="Thuc Pham"},
                new Product() { STT = 4, ProductName="Banh Orion",Price=50000,Category="Thuc Pham"},
                new Product() { STT = 5, ProductName="Dien Thoai Iphone 14 pro max",Price=30000000,Category="Dien May"},
                new Product() { STT = 6, ProductName="May tinh Asus",Price=70000000,Category="Dien May"},
            };
            gridControl1.DataSource = products;
        }
    }
}
