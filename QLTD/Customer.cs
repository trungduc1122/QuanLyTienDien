using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTD
{
    public class Customer
    {
        public int id { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }
        public int soluong { get; set; }

        public Customer(int id, string ten, string diachi, int soluong)
        {
            this.id = id;
            this.ten = ten;
            this.diachi = diachi;
            this.soluong = soluong;
        }
    }
}
