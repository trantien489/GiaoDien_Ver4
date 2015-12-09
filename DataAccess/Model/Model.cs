using DatabaseLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static partial class Model
    {
        static SqlDatabase db = new SqlDatabase();
        public static int dangnhap(string sql)
        {
            return db.KiemTraDngNhap(sql);
        }
        public static int InsertGeneric(object item)
        {
            return db.ExecuteNonQuery(item.ToSqlInsert(), item.ToSqlParameter());
        }
        public static List<T> SelectGeneric<T>(object item, string tableName = null) where T : new()
        {
            return db.GetList<T>(item.ToSqlSelect());
        }
        public static int DeleteGeneric(object item, string tableName)
        {
            var sql = item.ToSqlDelete(tableName);
            var param = item.ToSqlParameter();
            return db.ExecuteNonQuery(sql, param);
        }
        public static int UpdateGeneric(object item, string tableName)
        {
            var sql = item.ToSqlUpdate(tableName);
            var param = item.ToSqlParameter();
            return db.ExecuteNonQuery(sql, param);
        }
        public static int UploadPicture(string cmd, List<SqlParameter> param)
        {

            return db.ExecuteNonQuery(cmd, param);
        }



    }
}
