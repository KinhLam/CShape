using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevComponents.DotNetBar;//Add DotNetBar

namespace Pro_SuDungThuVienGiaoDienDxEpress
{
    public partial class Frm_Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Frm_Main()
        {
            InitializeComponent();
            this.tc_Main.CloseButtonOnTabsVisible = true;//TTạo nút tắt bên tab
            this.tc_Main.CloseButtonPosition = eTabCloseButtonPosition.Right;//Đưa nút tắt về bên phải

        }

        public Frm_Main frm;
        public delegate void _doDongTab();//Khai báo đối tượng có tên delegate với hàm trả về
        public _doDongTab deDongTab;

        //Triển khải phướng thức đóng tab
        private void DongTab()
        {
            foreach (TabItem item in tc_Main.Tabs)
            {
                
                if (item.IsSelected)
                {
                    tc_Main.Tabs.Remove(item);
                    return;
                }
            }
        }

        //Mở Form
        //Kiểm tra form đã mở chưa
        private bool CheckOpenTab(string name)
        {
            //Duyệt tab xem có trùng lặp kh
            //Nếu có tab thì kh mở thêm tab
            for (int i = 0; i < tc_Main.Tabs.Count; i++)
            {
                if (tc_Main.Tabs[i].Text == name)
                {
                    tc_Main.SelectedTabIndex = i;
                    return true;
                }
            }
            return false;
        }

        //Phương thức mở Form
        bool trangThaiMoTab = false;//Biến toàn cục
        string tieuDeTab = string.Empty;//Biến toàn cục

        private void OpenForm(Form frm, string tieuDe,bool trangThaiMoTab)
        {
            this.trangThaiMoTab = true;
            this.tieuDeTab = tieuDe;

            if (!CheckOpenTab(tieuDeTab))
            {
                TabItem t = tc_Main.CreateTab(tieuDeTab);
                t.Name = frm.Name;
                switch (frm.Name)
                {
                    case "Frm_QuanLyNguoiDung":
                        frm = new Frm_QuanLyNguoiDung()
                        {
                            DongTab = new Frm_QuanLyNguoiDung._doDongTab(DongTab),
                            frm = this,//Xác định form chính
                            TopLevel = false,//Tránh quyền việc active form chính
                            Dock = DockStyle.Fill,
                            Text = tieuDe

                        };
                        break;
                    case "Frm_Home":
                        frm = new Frm_Home()
                        {
                            DongTab = new Frm_Home._doDongTab(DongTab),
                            frm = this,//Xác định form chính
                            TopLevel = false,//Tránh quyền việc active form chính
                            Dock = DockStyle.Fill,
                            Text = tieuDe

                        };
                        break;
                }
                t.AttachedControl.Controls.Add(frm);
                frm.Show();
                tc_Main.SelectedTabIndex = tc_Main.Tabs.Count - 1;

            }
        }
        private void btnQuanLyNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            OpenForm(new Frm_QuanLyNguoiDung(), "Quản lý người dùng", true);
        }

        //Button Thoát
        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            
        }

        private void tc_Main_TabItemClose(object sender, TabStripActionEventArgs e)
        {
            TabItem t = tc_Main.SelectedTab;
            tc_Main.Tabs.Remove(t);
        }

        private void Frm_Main_Load(object sender, EventArgs e)
        {
            OpenForm(new Frm_Home(), "Thong Tin", true);
        }
    }
}
