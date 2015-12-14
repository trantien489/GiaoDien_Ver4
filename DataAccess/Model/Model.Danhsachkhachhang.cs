using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public partial class Model
    {
        public static List<Danhsachkhachhang> GetDanhsachkhachhangItems()
        {
            var item = new Danhsachkhachhang();
            return SelectGeneric<Danhsachkhachhang>(item);
        }
        public static int InsertDanhsachkhachhang(Danhsachkhachhang item)
        {
            return InsertGeneric(item);
        }
        public static int XoaDanhsachkhachhang(Danhsachkhachhang item, string table)
        {
            return DeleteGeneric(item, table);
        }
        public static int Suadanhsachkhachhang(Danhsachkhachhang item, string table)
        {
            return UpdateGeneric(item, table);
        }
    }
}
