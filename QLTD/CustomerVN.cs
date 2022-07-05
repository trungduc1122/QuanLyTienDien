using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTD
{
    public class CustomerVN:Customer
    {
        public string kieu { get; set; }
        public int dinhmuc { get; set; }
        public CustomerVN(int id, string ten, string diachi, int soluong,string kieu,int dinhmuc) : base(id, ten, diachi, soluong)
        {
            this.kieu = kieu;
            this.dinhmuc = dinhmuc;
        }


    }
}
