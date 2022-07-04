namespace Object
{
    public class Customer
    {
        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }

        public Customer(string id, string name, string address, int quantity, int price)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.quantity = quantity;
            this.price = price;
        }

        public Customer()
        {
        }
    }
}