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
    public partial class frm_FlowLayoutPanel : Form
    {
        public frm_FlowLayoutPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frm_Panel_Click(object sender, EventArgs e)
        {
            try
            {
                PictureBox pic = (PictureBox)sender;
                myPictureBox.Image = pic.Image;
            }
            catch (Exception ex)
            {

            }
        }

        private void frm_Panel_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < myImageList.Images.Count; i++)
            {
                PictureBox pic = new PictureBox();
                pic.Image = myImageList.Images[i];
                pic.Size = new Size(50, 50);
                pic.Click += new EventHandler(frm_Panel_Click);
                myFlowLayoutPanel.Controls.Add(pic);
            }
        }
    }
}
