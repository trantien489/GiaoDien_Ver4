﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace QuanLyCuaHangDienThoai.User_control
{
    public partial class ucDanhsachsukien : UserControl
    {
        public ucDanhsachsukien()
        {
            InitializeComponent();
        }

        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void btnThemDong_Click(object sender, EventArgs e)
        {
            (gcDanhsachsukien.MainView as DevExpress.XtraGrid.Views.Grid.GridView).AddNewRow();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cur = bdsDanhsachsukien.Current as Danhsachsukien;
            if (cur != null)
            {
                Model.InsertDanhsachsukien(cur);
            }
            bdsDanhsachsukien.DataSource = Model.GetDanhsachsukienItems();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var cur = bdsDanhsachsukien.Current as Danhsachsukien;
            if (cur != null)
            {
                Model.XoaDanhsachsukien(cur, cur.GetType().Name);
            }

            bdsDanhsachsukien.DataSource = Model.GetDanhsachsukienItems();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var cur = bdsDanhsachsukien.Current as Danhsachsukien;
            if (cur != null)
            {
                Model.Suadanhsachsukien(cur, cur.GetType().Name);
            }
            ucDanhsachsukien_Load(sender, e);
        }

        private void panelControl1_Paint_1(object sender, PaintEventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void ucDanhsachsukien_Load(object sender, EventArgs e)
        {
            bdsDanhsachsukien.DataSource = Model.GetDanhsachsukienItems();
        }

      
    }
}
