using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public partial class Model
    {
        public static List<Danhsachsukien> GetDanhsachsukienItems()
        {
            var item = new Danhsachsukien();
            return SelectGeneric<Danhsachsukien>(item);
        }
        public static int InsertDanhsachsukien(Danhsachsukien item)
        {
            return InsertGeneric(item);
        }
        public static int XoaDanhsachsukien(Danhsachsukien item, string table)
        {
            return DeleteGeneric(item, table);
        }
        public static int Suadanhsachsukien(Danhsachsukien item, string table)
        {
            return UpdateGeneric(item, table);
        }
    }
}
