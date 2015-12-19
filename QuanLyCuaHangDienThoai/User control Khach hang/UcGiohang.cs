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
    public partial class UcGiohang : UserControl
    {
        public UcGiohang()
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
        private void UcGiohang_Load(object sender, EventArgs e)
        {
            bdsGiohang.DataSource = Model.GetGioHangItems();
            cmb.Items.Add("Chuyển Khoảng");
            cmb.Items.Add("Thanh Toán Tại Cửa Hàng");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var cur = bdsGiohang.Current as Giohang;
            if (cur != null)
            {
                Model.XoaGioHang(cur, cur.GetType().Name);
            }
            bdsGiohang.DataSource = Model.GetGioHangItems();
        }

        private void bdsGiohang_PositionChanged(object sender, EventArgs e)
        {
            if (bdsGiohang.Count != 0)
            {
                var cur = bdsGiohang.Current as Giohang;
                if (cur.Mahang != null)
                {
                    var sql = "select Mahang, Count(Mahang) from HinhAnh where Mahang = " + "'" + cur.Mahang + "'" + "group by Mahang";
                    if (Model.dangnhap(sql) == 1)
                    {
                        bdsHinhanh.DataSource = Model.GetPicture(cur.Mahang);
                        Image hinh = ByteArrayToImage((byte[])DataGV.CurrentRow.Cells[1].Value);
                        pictureGioHang.Image = hinh;
                        ResetControlValues(DataGV);
                    }
                    else
                    {
                        pictureGioHang.Image = null;
                    }
                }
            }
            else
            {
                pictureGioHang.Image = null;
            }
                  
        }
     
       
    }
}
