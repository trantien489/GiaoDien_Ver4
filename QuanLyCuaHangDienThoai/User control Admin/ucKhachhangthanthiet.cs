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

namespace QuanLyCuaHangDienThoai.User_control
{
    public partial class ucKhachhangthanthiet : UserControl
    {
        public ucKhachhangthanthiet()
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
        private void ucKhachhangthanthiet_Load(object sender, EventArgs e)
        {
            bdsDanhsachkhachhang.DataSource = Model.GetKHthanthietItems();
        }
         public static Image ByteArrayToImage(byte[] array)
        {
            MemoryStream ms = new MemoryStream(array);
            return Image.FromStream(ms);
        }
        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            var cur = bdsDanhsachkhachhang.Current as Danhsachkhachhang;
            using (var frm = new capnhapanh(cur.Makhachhang))
            {
                frm.ShowDialog();
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
            bdsDanhsachkhachhang.DataSource = Model.GetKHthanthietItems();
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
            bdsDanhsachkhachhang.DataSource = Model.GetKHthanthietItems();  
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var cur = bdsDanhsachkhachhang.Current as Danhsachkhachhang;
            if (cur != null)
            {
                Model.Suadanhsachkhachhang(cur, cur.GetType().Name);
            }
            bdsDanhsachkhachhang.DataSource = Model.GetKHthanthietItems(); 
        }

        private void bdsDanhsachkhachhang_PositionChanged(object sender, EventArgs e)
        {
            if (bdsDanhsachkhachhang.Count != 0)
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
            else
            {
                pictureDSKH.Image = null;
            }
        }

    }
}
