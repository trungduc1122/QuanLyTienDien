// See https://aka.ms/new-console-template for more information
using QLTDLibrary;
namespace QLTDApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("a - vn customer");
            Console.WriteLine("b - foreign customer");
            Console.Write("chon:");
            switch (Console.ReadLine())
            {
                case "a":
                    CustomerVN customer1 = new CustomerVN();
                    customer1.nhap();
                    customer1.tongtien();
                    customer1.hienthi();
                    break;
                case "b":
                    CustomerNuocNgoai customer2 = new CustomerNuocNgoai();
                    customer2.nhap();
                    customer2.tongtien();
                    customer2.hienthi();
                    break;
            }
        }
    }
}
