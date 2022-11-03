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
    public partial class Frm_QuanLyNguoiDung : Form
    {
        public Frm_QuanLyNguoiDung()
        {
            InitializeComponent();
        }

        public Frm_Main frm;
        public delegate void _doDongTab();//Khai báo đối tượng có tên delegate với hàm trả về
        public _doDongTab DongTab;

        private void Frm_QuanLyNguoiDung_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DongTab();
        }
    }
}
