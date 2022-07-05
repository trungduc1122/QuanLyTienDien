namespace Object
{
    public class Customer
    {
        public Customer()
        {
        }

        public string id { get; set; }
        public string name { get; set; }
        public string address { get; set; }
        public int quantity { get; set; }
        public int price { get; set; }
        public string nationality { get; set; }
        public string type { get; set; }
        public int limit { get; set; }

        public Customer(string id, string name, string address, int quantity, int price, string nationality, string type, int limit)
        {
            this.id = id;
            this.name = name;
            this.address = address;
            this.quantity = quantity;
            this.price = price;
            this.nationality = nationality;
            this.type = type;
            this.limit = limit;
        }
    }
}