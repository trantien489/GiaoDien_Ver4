using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccess;

namespace DataAccess
{
    public partial class Model
    {
        public static List<Danhsachkhachhang> GetKHthanthietItems()
        {
            var sql = "Select * from Danhsachkhachhang Where Capbac = N'Thân Thiết' ";
            return Select<Danhsachkhachhang>(sql);
        }
    }
}
