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
    public partial class ucDanhsachhanghoa : UserControl
    {
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
        public ucDanhsachhanghoa()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var cur = bdnDanhsachhanghoa.Current as Danhsachhanghoa;
            if (cur != null)
            {
                Model.XoaDanhsachhanghoa(cur, cur.GetType().Name);
            }
            var sql = "delete from Hinhanh where Mahang = " + "'" + cur.Mahang + "'";
            Model.DeletePicture(sql);
            bdnDanhsachhanghoa.DataSource = Model.GetDanhsachhanghoaItems();     
        }

        private void btnThemAnh_Click(object sender, EventArgs e)
        {
            Danhsachhanghoa item = bdnDanhsachhanghoa.Current as Danhsachhanghoa;
            capnhapanh frm = new capnhapanh(item.Mahang);
            frm.Show();
        }

        private void btnSuaAnh_Click(object sender, EventArgs e)
        {
            Danhsachhanghoa item = bdnDanhsachhanghoa.Current as Danhsachhanghoa;
            EditPicture frm = new EditPicture(item.Mahang);
            frm.Show();
        }

        private void bdnDanhsachhanghoa_PositionChanged(object sender, EventArgs e)
        {
            var cur = bdnDanhsachhanghoa.Current as Danhsachhanghoa;
            if (cur.Mahang != null)
            {
                var sql = "select Mahang, Count(Mahang) from Hinhanh where Mahang = " + "'" + cur.Mahang + "'" + "group by Mahang";
                if (Model.dangnhap(sql) == 1)
                {
                    DataGV.DataSource = Model.GetPictureHanghoa(cur.Mahang);
                    Image hinh = ByteArrayToImage((byte[])DataGV.CurrentRow.Cells[0].Value);
                    pictureDSHH.Image = hinh;
                    ResetControlValues(DataGV);
                }
                else
                {
                    pictureDSHH.Image = null;
                }
            }
        }

        private void btnThemDong_Click(object sender, EventArgs e)
        {
            (gcDanhsachhanghoa.MainView as DevExpress.XtraGrid.Views.Grid.GridView).AddNewRow();
            ResetControlValues(groupBox1);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var cur = bdnDanhsachhanghoa.Current as Danhsachhanghoa;
            if (cur != null)
            {
                Model.InsertDanhsachhanghoa(cur);
            }
            bdnDanhsachhanghoa.DataSource = Model.GetDanhsachhanghoaItems(); 
        }

        private void ucDanhsachhanghoa_Load(object sender, EventArgs e)
        {
            bdnDanhsachhanghoa.DataSource = Model.GetDanhsachhanghoaItems();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            var cur = bdnDanhsachhanghoa.Current as Danhsachhanghoa;
            if (cur != null)
            {
                Model.Suadanhsachhanghoa(cur, cur.GetType().Name);
            }
            bdnDanhsachhanghoa.DataSource = Model.GetDanhsachhanghoaItems();
        }
    }
}
