using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrJect_Chuong6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNhapChuoi_TextChanged(object sender, EventArgs e)
        {
            lblChuoiDinhDang.Text = txtNhapChuoi.Text;
            
        }

        private void radXanh_CheckedChanged(object sender, EventArgs e)
        {
            if (radXanh.Checked == true)
            {
                lblChuoiDinhDang.ForeColor = Color.Blue;
            }
        }

        private void radDo_CheckedChanged(object sender, EventArgs e)
        {
            if (radDo.Checked == true)
            {
                lblChuoiDinhDang.ForeColor = Color.Red;
            }
        }

        private void radDen_CheckedChanged(object sender, EventArgs e)
        {
            if (radDen.Checked == true)
            {
                lblChuoiDinhDang.ForeColor = Color.Black;
            }
        }

        private void radDam_CheckedChanged(object sender, EventArgs e)
        {
            if (radDam.Checked == true)
            {
                lblChuoiDinhDang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void radNghieng_CheckedChanged(object sender, EventArgs e)
        {
            if (radNghieng.Checked == true)
            {

                lblChuoiDinhDang.Font = new
                System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Italic);

            }
        }

        private void radGachChan_CheckedChanged(object sender,
EventArgs e)
        {
            if (radGachChan.Checked == true)
            {

                lblChuoiDinhDang.Font = new
                System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Underline);

            }
        }

        private void radGachChan_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radGachChan.Checked == true)
            {

                lblChuoiDinhDang.Font = new
                System.Drawing.Font("Microsoft Sans Serif", 12F,
                System.Drawing.FontStyle.Underline);

            }
        }
    }
}
