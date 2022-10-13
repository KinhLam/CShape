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
    public partial class Frm_TabControl : Form
    {
        public Frm_TabControl()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCapNhatNV_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listNhanVien.SelectedItems)
            {
                lvi.SubItems[0].Text = txtHoTenNV.Text;
                lvi.SubItems[1].Text = txtChucVuNV.Text;
                lvi.SubItems[2].Text = txtHeSoLuongNV.Text;
                lvi.SubItems[3].Text = txtLuongCBNV.Text;
            }
        }

        private void btnThemNV_Click(object sender, EventArgs e)
        {
            if (txtLuongCBNV.Text != "" && txtHoTenNV.Text != "" && txtHeSoLuongNV.Text != "" && txtChucVuNV.Text != "")
            {
                ListViewItem LVItem = new ListViewItem(txtHoTenNV.Text);
                ListViewItem.ListViewSubItem LVSItemCV = new ListViewItem.ListViewSubItem(LVItem, txtChucVuNV.Text);
                ListViewItem.ListViewSubItem LVSItemHSL = new ListViewItem.ListViewSubItem(LVItem, txtHeSoLuongNV.Text);
                ListViewItem.ListViewSubItem LVSItemLCB = new ListViewItem.ListViewSubItem(LVItem, txtLuongCBNV.Text);

                LVItem.SubItems.Add(LVSItemCV);
                LVItem.SubItems.Add(LVSItemHSL);
                LVItem.SubItems.Add(LVSItemLCB);
                listNhanVien.Items.Add(LVItem);
                txtLuongCBNV.Text = "";
                txtHoTenNV.Text = "";
                txtHeSoLuongNV.Text = "";
                txtChucVuNV.Text = "";
            }
            else
            {
                MessageBox.Show("Phải nhập đầy đủ thông tin nhân viên");
            }
        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            if (listNhanVien.CheckedItems.Count > 0)
            {
                listNhanVien.Items.RemoveAt(listNhanVien.FocusedItem.Index);
            }
            else
            {
                MessageBox.Show("Phải chọn nhân viên muốn");
            }
        }

        private void listNhanVien_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem lvi in listNhanVien.SelectedItems)
            {
                txtHoTenNV.Text = lvi.SubItems[0].Text;
                txtChucVuNV.Text= lvi.SubItems[1].Text;
                txtHeSoLuongNV.Text= lvi.SubItems[2].Text;
                txtLuongCBNV.Text = lvi.SubItems[3].Text;
            }
        }
    }
}
