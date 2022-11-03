using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace ProJ_Chuong9.MyComponents
{
    public partial class MyColorTextBox :TextBox
    {
        private Color backColorMyTextBox;
        public Color BackColorMyTextBox
        {
            get { return backColorMyTextBox; }
            set { backColorMyTextBox = value; }
        }
        public MyColorTextBox()
        {
            //Không làm gì 
            this.BackColor = backColorMyTextBox;
            this.Font = new Font("Arial", 18F);
        }

        public MyColorTextBox(Color color)
        {
            backColorMyTextBox = color;
            this.BackColor = backColorMyTextBox;
            this.Font = new Font("Arial", 18F);
        }



    }
}
