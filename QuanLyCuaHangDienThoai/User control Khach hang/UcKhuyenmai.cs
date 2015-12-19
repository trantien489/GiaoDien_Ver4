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

namespace QuanLyCuaHangDienThoai.User_control_Khach_hang
{
    public partial class UcKhuyenmai : UserControl
    {
        public UcKhuyenmai()
        {
            InitializeComponent();
        }

        private void UcKhuyenmai_Load(object sender, EventArgs e)
        {
            bdsDanhsachsukien.DataSource = Model.GetDanhsachsukienItems();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }
    }
}
