using DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public partial class Model
    {
        public static List<TinnhanAd> GetTinnhanAdItems()
        {
            var item = new TinnhanAd();
            return SelectGeneric<TinnhanAd>(item);
        }
        public static int InsertTinnhanAd(TinnhanAd item)
        {
            return InsertGeneric(item);
        }
        public static int XoaTinnhanAd(TinnhanAd item, string table)
        {
            return DeleteGeneric(item, table);
        }
        public static int SuaTinnhanAd(TinnhanAd item, string table)
        {
            return UpdateGeneric(item, table);
        }
    }
}
