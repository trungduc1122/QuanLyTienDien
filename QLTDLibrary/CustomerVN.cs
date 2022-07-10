using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTDLibrary
{
    public class CustomerVN:Customer
    {
        private string kieu { get; set; }
        private int dinhmuc { get; set; }
        public CustomerVN(int id, string ten, string diachi, int soluong,int dongia,string kieu,int dinhmuc) : base(id, ten, diachi, soluong,dongia)
        {
            this.kieu = kieu;
            this.dinhmuc = dinhmuc;
        }
        public override void nhap()
        {
            base.nhap();
            Console.Write("kieu:");
            kieu = Console.ReadLine();
            Console.Write("dinh muc:");
            dinhmuc = Convert.ToInt32(Console.ReadLine());
        }
        public override double tongtien()
        {
            if (soluong > dinhmuc)
            {
                return soluong * dongia * dinhmuc + (soluong - dinhmuc);
            }
            else
            {
                return soluong * dongia;
            }
        }
        public override void hienthi()
        {
            base.hienthi();

        }

    }
}
