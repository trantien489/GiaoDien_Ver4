using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;

namespace QuanLyCuaHangDienThoai
{
    public partial class dangnhap : Form
    {
        public dangnhap()
        {
            InitializeComponent();
        }

        private void dangnhap_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {

            if (radioAdmin.Checked == false && radioUser.Checked == false)
            {
                MessageBox.Show("Chưa chọn loại tài khoản");
            }
            else
            {
                #region //đăng nhập
                if (radioAdmin.Checked == true)
                {
                    string sql = "select TK, count(MK) from DangNhapAD where TK ='" + txtTaiKhoan.Text + "' and MK ='" + txtMatKhau.Text + "' group by TK";
                    int kq = Model.dangnhap(sql);
                    if (kq == 1)
                    {
                        admin ad = new admin();
                        ad.Show();
                        this.Hide();
                    }
                    else { MessageBox.Show("Dang nhap khong thanh cong"); }
                }
                if (radioUser.Checked == true)
                {
                    string sql = "select TK, count(MK) from DangNhap where TK ='" + txtTaiKhoan.Text + "' and MK ='" + txtMatKhau.Text + "' group by TK";
                    int kq = Model.dangnhap(sql);
                    if (kq == 1)
                    {
                        user us = new user();
                        us.Show();
                        this.Hide();
                    }
                    else { MessageBox.Show("Dang nhap khong thanh cong"); }
                }
                #endregion
            }     
        }

        private void radioAdmin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txtMatKhau_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("Enter key pressed");
                //btnDangNhap.PerformClick();
                btnDangNhap_Click(sender, e);
            }
        }

        private void radioAdmin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("Enter key pressed");
                //btnDangNhap.Select();
                //btnDangNhap.Focus();
                //this.btnDangNhap.PerformClick();
                btnDangNhap_Click(sender,e);
                
            }
        }

        private void radioUser_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnDangNhap_Click(sender, e);
            }
        }

  
 

      
    }
}
