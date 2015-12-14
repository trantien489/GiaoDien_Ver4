using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public partial class Model
    {
        public static List<Danhsachkhachhang> GetKHthonghthuongItems ()
        {
            var sql = "Select * from Danhsachkhachhang Where Capbac = N'Thông Thường' ";
            return Select<Danhsachkhachhang>(sql);
        }
    }
}
