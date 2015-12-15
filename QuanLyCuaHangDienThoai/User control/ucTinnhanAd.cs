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

namespace QuanLyCuaHangDienThoai.User_control
{
    public partial class ucTinnhanAd : UserControl
    {
        public ucTinnhanAd()
        {
            InitializeComponent();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            var cur = bdsTinnhanAd.Current as TinnhanAd;
            if (cur != null)
            {
                Model.XoaTinnhanAd(cur, cur.GetType().Name);
            }
            bdsTinnhanAd.DataSource = Model.GetTinnhanAdItems();
        }

        private void ucTinnhanAd_Load(object sender, EventArgs e)
        {
            (gcTinnhanAd.MainView as DevExpress.XtraGrid.Views.Grid.GridView).AddNewRow();
        }

    }
}
