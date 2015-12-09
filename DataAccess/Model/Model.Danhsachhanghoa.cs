using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public partial class Model
    {
        public static List<Danhsachhanghoa> GetDanhsachhanghoaItems()
        {
            var item = new Danhsachhanghoa();
            return SelectGeneric<Danhsachhanghoa>(item);
        }
        public static int InsertDanhsachhanghoa(Danhsachhanghoa item)
        {
            return InsertGeneric(item);
        }
        public static int XoaDanhsachhanghoa(Danhsachhanghoa item, string table)
        {
            return DeleteGeneric(item, table);
        }
        public static int Suadanhsachhanghoa(Danhsachhanghoa item, string table)
        {
            return UpdateGeneric(item, table);
        }
    }
}
