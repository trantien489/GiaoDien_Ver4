using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Danhsachkhachhang
    {
        public static int _num = 0;
        public Danhsachkhachhang()
        { _num++; }
        public int num { get { return _num; } }
        public string Makhachhang { get; set; }
        public string Tenkhachhang { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Gioitinh { get; set; }
        public string Diachi { get; set; }
        public int Cmnd { get; set; }
        public int Sdt { get; set; }
        public string Capbac { get; set; }
        public string Hinhanh { get; set; }
    }
}
