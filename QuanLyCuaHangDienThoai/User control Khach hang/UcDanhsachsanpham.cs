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

namespace QuanLyCuaHangDienThoai.User_control_Khach_hang
{
    public partial class UcDanhsachsanpham : UserControl
    {
        public string Taikhoan { get; set; }
        public UcDanhsachsanpham( string s)
        {
            Taikhoan = s;
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
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private void UcDanhsachsanpham_Load(object sender, EventArgs e)
        {
            bdnDanhsachhanghoa.DataSource = Model.GetDanhsachhanghoaItems();
        }

        private void bdnDanhsachhanghoa_PositionChanged(object sender, EventArgs e)
        {
            var cur = bdnDanhsachhanghoa.Current as Danhsachhanghoa;
            if (cur.Mahang != null)
            {
                var sql = "select Mahang, Count(Mahang) from HinhAnh where Mahang = " + "'" + cur.Mahang + "'" + "group by Mahang";
                if (Model.dangnhap(sql) == 1)
                {
                    bdsHinhanh.DataSource = Model.GetPicture(cur.Mahang);
                    Image hinh = ByteArrayToImage((byte[])DataGV.CurrentRow.Cells[1].Value);
                    pictureSP.Image = hinh;
                    ResetControlValues(DataGV);
                }
                else
                {
                    pictureSP.Image = null;
                }
            }
        }

        private void btnThemGioHang_Click(object sender, EventArgs e)
        {
            var cur = bdnDanhsachhanghoa.Current as Danhsachhanghoa;
            Giohang giohang = new Giohang();
            giohang.Mahang = cur.Mahang;
            giohang.Tenhang = cur.Tenhang;
            giohang.Giaban = cur.Giaban;
            bdsGiohang.DataSource = Model.GetGioHangItems();
            //gridView2.GetRowCellValue();
            if (cur != null)
            {
                Model.InsertGioHang(giohang);
            }
            bdnDanhsachhanghoa.DataSource = Model.GetDanhsachhanghoaItems();
            MessageBox.Show("Đã thêm vào giỏ hàng");
        }
    }
}
