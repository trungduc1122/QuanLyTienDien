using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object
{
    public class ForeignerCustomer:Customer
    {
        public ForeignerCustomer()
        {
        }

        public string nationality { get; set; }

        public ForeignerCustomer(string nationality)
        {
            this.nationality = nationality;
        }
    }
}
