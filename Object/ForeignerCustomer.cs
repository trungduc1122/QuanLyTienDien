using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTDLIbrary
{
    public class ForeignerCustomer : Customer
    {
        public string Nationality;

        public ForeignerCustomer()
        {
        }

        public ForeignerCustomer(string id, string name, string address, int quantity, int price, string type, int limit, string nationality) : base(id, name, address, quantity, price, type, limit)
        {
            Nationality=nationality;
        }
        public void Input()
        {
            Console.WriteLine("id:");
            Id = Console.ReadLine();
            Console.WriteLine("name:");
            Name = Console.ReadLine();
            Console.WriteLine("address:");
            Address = Console.ReadLine();
            Console.WriteLine("quantity:");
            Quantity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("price:");
            Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("type:");
            Type = Console.ReadLine();
            Console.WriteLine("limit:");
            Limit = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nationality:");
            Nationality = Console.ReadLine();
        }
        public double ToCash()
        {
            double total;
            total=Quantity*Price;
            return total;
        }
    }
}
