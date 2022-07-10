using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTDLibrary
{
    public class CustomerNuocNgoai:Customer
    {
        public string quoctich { get; set; }
        public CustomerNuocNgoai(int id, string ten, string diachi, int soluong,int dongia,string quoctich) : base(id, ten, diachi, soluong,dongia)
        {
            this.quoctich = quoctich;
        }
        public override double tongtien()
        {
            return base.tongtien();
        }
        public override void hienthi()
        {
            base.hienthi();
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("dia chi:");
            diachi = Console.ReadLine();
            Console.Write("quoc tich:");
            quoctich = Console.ReadLine();
        }
}
