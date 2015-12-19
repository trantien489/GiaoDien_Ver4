using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QuanLyCuaHangDienThoai.User_control_Khach_hang;

namespace QuanLyCuaHangDienThoai
{
    public partial class user : Form
    {
        public user(string s)
        {
            TaiKhoan = s;
            InitializeComponent();
        }
        public string TaiKhoan { get; set; }
        private void navBarDSSanPham_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            UcDanhsachsanpham frm = new UcDanhsachsanpham();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }

        private void navBarGioHang_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            UcGiohang frm = new UcGiohang();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }

        private void navBarSale_LinkClicked(object sender, DevExpress.XtraNavBar.NavBarLinkEventArgs e)
        {
            panelControl1.Controls.Clear();
            UcKhuyenmai frm = new UcKhuyenmai();
            frm.Dock = System.Windows.Forms.DockStyle.Fill;
            panelControl1.Controls.Add(frm);
        }
    }
}
