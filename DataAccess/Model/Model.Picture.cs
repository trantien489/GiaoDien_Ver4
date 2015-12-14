using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using DatabaseLib;
using System.Configuration;

namespace DataAccess
{
    public partial class Model
    {
        public static int ChenAnh(string Mahang, string filename)
        {
            var sql = "insert into Hinhanh(Mahang,Hinhanh) values(@Mahang,@Hinhanh)";
            //var sql = "update Danhsachkhachhang set Hinhanh = @Hinhanh where Makhachhang =" + Mahang;
            byte[] ImageData = null;
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                ImageData = new byte[fs.Length];
                fs.Read(ImageData, 0, (int)fs.Length);
            }
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter
            {
                ParameterName = "@Mahang",
                Value = Mahang,
                SqlDbType = SqlDbType.VarChar
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@Hinhanh",
                Value = ImageData,
                SqlDbType = SqlDbType.Image
            });
            return UploadPicture(sql, param);
        }
        public static int SuaAnh(string Mahang, string filename)
        {
            var sql = "update Hinhanh set Mahang = @Mahang, Hinhanh = @Hinhanh where Mahang =@Mahang";
            byte[] ImageData = null;
            using (FileStream fs = new FileStream(filename, FileMode.Open, FileAccess.Read))
            {
                ImageData = new byte[fs.Length];
                fs.Read(ImageData, 0, (int)fs.Length);
            }
            var param = new List<SqlParameter>();
            param.Add(new SqlParameter
            {
                ParameterName = "@Mahang",
                Value = Mahang,
                SqlDbType = SqlDbType.VarChar
            });
            param.Add(new SqlParameter
            {
                ParameterName = "@Hinhanh",
                Value = ImageData,
                SqlDbType = SqlDbType.Image
            });
            return UploadPicture(sql, param);
        }
        public static DataTable GetPictureHanghoa(string s)
        {
            string sql = "select Hinhanh from Hinhanh where Mahang = " + "'" + s + "'";
            return db.GetDataTable(sql);
        }
        public static List<HinhAnh> GetPicture(string s)
        {
            string sql = "select * from HinhAnh where Mahang = " + "'" + s + "'";
            return db.GetList<HinhAnh>(sql);
        }
        public static int DeletePicture(string s)
        {
            return db.ExecuteNonQuery(s);
        }


    }
}
