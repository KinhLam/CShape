﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project1
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();//Mở form như hộp thoại
            //frmLogin.Show();//Mở form
            lblThongTinDangNhap.Text = string.Format("Tài khoản đăng nhập: {0}", ClsMain.taiKhoan);

        }

        private void mnuDangXuat_Click(object sender, EventArgs e)
        {
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.ShowDialog();
            
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuQuanLyTaiKhoan_Click(object sender, EventArgs e)
        {
            FrmQuanLyTaiKhoan_Main frmQuanLyTaiKhoan_Main = new FrmQuanLyTaiKhoan_Main();
            frmQuanLyTaiKhoan_Main.ShowDialog();
        }
    }
}
