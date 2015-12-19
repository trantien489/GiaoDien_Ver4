using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public partial class Model
    {
        public static List<Giohang> GetGioHangItems()
        {
            var item = new Giohang();
            return SelectGeneric<Giohang>(item);
        }
        public static int XoaGioHang(Giohang item, string table)
        {
            return DeleteGeneric(item, table);
        }
        public static int InsertGioHang(Giohang item)
        {
            return InsertGeneric(item);
        }
    }
}
