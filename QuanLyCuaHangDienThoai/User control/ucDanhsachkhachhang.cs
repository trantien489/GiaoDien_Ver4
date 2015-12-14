using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using System.IO;
using DevExpress.Xpf.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace QuanLyCuaHangDienThoai.User_control
{
    public partial class ucDanhsachkhachhang: UserControl
    {
        public ucDanhsachkhachhang()
        {
            InitializeComponent();
        }
        public static void ResetControlValues(Control Parent)
        {
            foreach (Control mycontrols in Parent.Controls)
                if (mycontrols is TextBox)
                {
                    (mycontrols as TextBox).Text = string.Empty;
                }
                else if (mycontrols is DateTimePicker)
                {
                    (mycontrols as DateTimePicker).Value = DateTime.Now;
                }
                else if (mycontrols is ComboBox)
                {
                    (mycontrols as ComboBox).SelectedIndex = 0;
                }
                else if (mycontrols is DataGridView)
                {
                    (mycontrols as DataGridView).Rows.Clear();
                }
        }
        public static Image ByteArrayToImage(byte[] array)
        {
            MemoryStream ms = new MemoryStream(array);
            return Image.FromStream(ms);
        }
        private void panelControl1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ucDanhsachkhachhang_Load(object sender, EventArgs e)
        {
            bdsDanhsachkhachhang.DataSource = Model.GetDanhsachkhachhangItems();
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            var cur = bdsDanhsachkhachhang.Current as Danhsachkhachhang;
            using(var frm = new capnhapanh(cur.Makhachhang))
            {
                frm.ShowDialog();
            }
        }

        private void bdsDanhsachkhachhang_PositionChanged(object sender, EventArgs e)
        {
            var cur = bdsDanhsachkhachhang.Current as Danhsachkhachhang;
            if (cur.Makhachhang != null)
            {
                var sql = "select Mahang, Count(Mahang) from HinhAnh where Mahang = " + "'" + cur.Makhachhang + "'" + "group by Mahang";
                if (Model.dangnhap(sql) == 1)
                {
                    bdsHinhanh.DataSource = Model.GetPicture(cur.Makhachhang);
                    Image hinh = ByteArrayToImage((byte[])DataGV.CurrentRow.Cells[1].Value);   
                    pictureDSKH.Image = hinh;
                    ResetControlValues(DataGV);
                }
                else
                {
                    pictureDSKH.Image = null;
                }
            }
        }

        private void btnSuaAnh_Click(object sender, EventArgs e)
        {
            Danhsachkhachhang item = bdsDanhsachkhachhang.Current as Danhsachkhachhang;
            EditPicture frm = new EditPicture(item.Makhachhang);
            frm.Show();
        }

        private void btnThemDong_Click(object sender, EventArgs e)
        {
            (gcDanhsachkhachhang.MainView as DevExpress.XtraGrid.Views.Grid.GridView).AddNewRow();
            ResetControlValues(groupBox1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cur = bdsDanhsachkhachhang.Current as Danhsachkhachhang;
            if (cur != null)
            {
                Model.InsertDanhsachkhachhang(cur);
            }
            bdsDanhsachkhachhang.DataSource = Model.GetDanhsachkhachhangItems();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var cur = bdsDanhsachkhachhang.Current as Danhsachkhachhang;
            if (cur != null)
            {
                Model.XoaDanhsachkhachhang(cur, cur.GetType().Name);
            }
            var sql = "delete from HinhAnh where Mahang = " + "'" + cur.Makhachhang + "'";
            Model.DeletePicture(sql);
            bdsDanhsachkhachhang.DataSource = Model.GetDanhsachkhachhangItems();  
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var cur = bdsDanhsachkhachhang.Current as Danhsachkhachhang;
            if (cur != null)
            {
                Model.Suadanhsachkhachhang(cur, cur.GetType().Name);
            }
            bdsDanhsachkhachhang.DataSource = Model.GetDanhsachkhachhangItems(); 
        }
    }
}
