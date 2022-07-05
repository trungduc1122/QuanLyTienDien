namespace QLTDLIbrary
{
    public class Customer
    {
        public Customer()
        {
        }

        public string Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Quantity { get; set; }
        public int Price { get; set; }
        public string Type { get; set; }
        public int Limit { get; set; }

        public Customer(string id, string name, string address, int quantity, int price, string type, int limit)
        {
            Id = id;
            Name = name;
            Address = address;
            Quantity = quantity;
            Price = price;
            Type = type;
            Limit = limit;
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
        }
        public double ToCash()
        {
            double total;
            if (Quantity <= Limit)
            {
                total=Quantity*Price;
            }
            else
            {
                total = Quantity * Price * Limit + (Quantity - Limit) * Price * 2.5;
            }
            return total;
        }
    }
}