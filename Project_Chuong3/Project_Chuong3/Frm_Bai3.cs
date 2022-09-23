using System;
using System.Windows.Forms;

namespace Project_Chuong3
{
    public partial class Frm_Bai3 : Form
    {
        public Frm_Bai3()
        {
            InitializeComponent();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult thoat;
            thoat = MessageBox.Show("Bạn có chắc chắn muốn thoát không ?", "Thoát",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);

            //Nếu bấm Yes-->đóng chương trình
            if (thoat == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
