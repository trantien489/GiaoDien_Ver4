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
    public partial class EditPicture : Form
    {
        string Mahang;
        public EditPicture(string s)
        {
            Mahang = s;
            InitializeComponent();
        }

        private void EditPicture_Load(object sender, EventArgs e)
        {

        }

        private void btbOpenFile_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialog.ShowDialog();
                string file = openFileDialog.FileName;
                txtimage.Text = file;
                if (string.IsNullOrEmpty(file))
                {
                    MessageBox.Show("File rỗng");
                }
                Image hinh = Image.FromFile(file);
                pictureBox.Image = hinh;
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi");
                throw;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Model.SuaAnh(Mahang, txtimage.Text);
            txtimage.Clear();
            this.Close();
        }
    }
}
