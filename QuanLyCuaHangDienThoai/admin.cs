using QuanLyCuaHangDienThoai.User_control;
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
    }
}
