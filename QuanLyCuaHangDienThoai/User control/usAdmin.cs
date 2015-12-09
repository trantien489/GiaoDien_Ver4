using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using DataAccess;

namespace QuanLyCuaHangDienThoai.User_control
{
    public partial class usAdmin : UserControl
    {
        public usAdmin()
        {
            InitializeComponent();
        }
        public static Image ByteArrayToImage(byte[] array)
        {
            MemoryStream ms = new MemoryStream(array);
            return Image.FromStream(ms);
        }
        private void usAdmin_Load(object sender, EventArgs e)
        {
            //var cur = bdnDanhsachhanghoa.Current as Danhsachhanghoa;
            var sql = "select Mahang, Count(Mahang) from Hinhanh where Mahang = 'admin' group by Mahang";
            if (Model.dangnhap(sql) == 1)
            {
                DataGV.DataSource = Model.GetPictureHanghoa("admin");
                Image hinh = ByteArrayToImage((byte[])DataGV.CurrentRow.Cells[0].Value);
                pictureBox.Image = hinh;               
             }
             else
             {
                 pictureBox.Image = null;
             }
        }
    }
}
