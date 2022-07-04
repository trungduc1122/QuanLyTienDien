using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class VNCustomer:Customer
    {
        public string type { get; set; }
        public int limit  { get; set; }

        public VNCustomer()
        {
        }

        public VNCustomer(string type, int limit)
        {
            this.type = type;
            this.limit = limit;
        }
    }
}
