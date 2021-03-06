﻿using QuanLyCuaHangDienThoai.User_control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyCuaHangDienThoai
{
    public partial class admin : Form
    {
        public admin()
        {
            InitializeComponent();
        }

        private void navBarQLKho_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucDanhsachhanghoa frm = new ucDanhsachhanghoa();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }

        private void admin_Load(object sender, EventArgs e)
        {
            panelControl1.Controls.Clear();
            usAdmin frm = new usAdmin();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }

        private void navBarDSKhachHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucDanhsachkhachhang frm = new ucDanhsachkhachhang();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }

        private void navBarKHThanThiet_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucKhachhangthanthiet frm = new ucKhachhangthanthiet();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }

        private void navBarKHThongThuong_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucKhachhangthongthuong frm = new ucKhachhangthongthuong();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }

        private void navBarDSSuKien_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucDanhsachsukien frm = new ucDanhsachsukien();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }

        private void navBarTinNhan_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            ucTinnhanAd frm = new ucTinnhanAd();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }
    }
}
