using System;
using MyLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Project_Chuong3
{
    public partial class Frm_Bai2 : Form
    {
        public Frm_Bai2()
        {
            InitializeComponent();
        }

        Hashtable hashTable;
        private void btnTinhTanSuat_Click(object sender, EventArgs e)
        {

            //Tiền xử lý
            string inputString = MyString.XoaKyTuDacBiet(MyString.XoaKhoangTrangDu(txtNoiDung.Text));

            //tách từ
            string[] arrayString = inputString.Split(' ');

            //Tính tần suất
            //Khai báo HashTable
            hashTable = new Hashtable();
            {
                foreach (var item in arrayString)
                {
                    if (hashTable.ContainsKey(item))
                    {
                        //C1
                        hashTable[item] = Convert.ToInt32(hashTable[item]) + 1;
                        //C2
                        //hashTable[item] = (int)hashTable[item] + 1;
                    }
                    else
                    {
                        hashTable.Add(item, 1);
                    }
                }
                PrintResult(hashTable);
            }
        }

        private void PrintResult(Hashtable hashTable)
        {
            foreach (var item in hashTable.Keys)
            {
                lbTanSuatTu.Items.Add(string.Format("{0}: {1} lần", item, hashTable[item]));

            }
        }

        private void txtNoiDung_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
