using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTD
{
    public class CustomerNuocNgoai:Customer
    {
        public string quoctich { get; set; }
        public CustomerNuocNgoai(int id, string ten, string diachi, int soluong,string quoctich) : base(id, ten, diachi, soluong)
        {
            this.quoctich = quoctich;
        }
    }
}
