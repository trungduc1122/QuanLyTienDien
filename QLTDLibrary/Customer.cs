using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTDLibrary
{
    public class Customer
    {
        public int id { get; set; }
        public string ten { get; set; }
        public string diachi { get; set; }
        public int soluong { get; set; }
        public int dongia { get; set; }

        public Customer(int id, string ten, string diachi, int soluong, int dongia)
        {
            this.id = id;
            this.ten = ten;
            this.diachi = diachi;
            this.soluong = soluong;
            this.dongia = dongia;
        }

        public virtual void nhap()
        {
            Console.Write("id:");
            id=Convert.ToInt32(Console.ReadLine());
            Console.Write("ten:");
            ten = Console.ReadLine();
            Console.Write("dia chi:");
            diachi = Console.ReadLine();
            Console.Write("so luong:");
            soluong = Convert.ToInt32(Console.ReadLine());
            Console.Write("don gia:");
            dongia = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void hienthi()
        {
            Console.WriteLine($"id:{id} ,ten:{ten} ,dia chi:{diachi}, so luong:{soluong}, tong tien:{tongtien()}");
        }
        public virtual double tongtien()
        {
            return soluong*dongia;
        }
    }
}
