using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProJ_Chuong9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Hàm Kiểm tra số nguyên tố 
        bool kiemTraSoNguyenTo(int x)
        {
            bool kt = true;
            for (int i = 2; i <= x / 2; i++)
                if (x % i == 0)
                    kt = false;
            return kt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gt =
int.Parse(uC_KtraSoNguyenTo1.Controls["txtNhapSo"].Text);
            if (kiemTraSoNguyenTo(gt) == true)
                uC_KtraSoNguyenTo1.Controls["lblKetQua"].Text = " là số nguyên tố";

            else
                uC_KtraSoNguyenTo1.Controls["lblKetQua"].Text =

                gt.ToString() + " không là số nguyên tố";

            uC_KtraSoNguyenTo1.Controls["txtNhapSo"].Text = "";
        }
    }
}
