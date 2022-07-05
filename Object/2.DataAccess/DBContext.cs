using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using QLTDLIbrary._1.BusinessObject;

namespace QLTDLIbrary._2.DataAccess
{
    public class DBContext
    {
        private static List<Customer> list = new List<Customer>()
        {
            new VNCusomter{Id=1, Name="",Address="",Quantity=10000,Price=10000,Type="",Limit=8000},
            new VNCusomter{Id=2, Name="",Address="",Quantity=6000,Price=10000,Type="",Limit=8000},
            new ForeignerCustomer{Id=3,Name="",Address="",Quantity=10000,Price=10000,Nationality=""}
        };

        private static DBContext instance = null;
        private static readonly object instanceLock = null;
        private DBContext() { }
        public static DBContext Instance
        {
            get
            {
                lock (instanceLock)
                {
                    if (instance == null)
                    {
                        instance = new DBContext();
                    }
                    return instance;
                }
            }
        }
        public List<Customer>customers=>list;

        public Customer GetCustomerByID(int id)
        {
            Customer customer = customers.SingleOrDefault(x=>x.Id==id);
            return customer;
        }
        public double total(Customer customer)
        {
            double total;
            Customer customer1 = GetCustomerByID(customer.Id);
            if (customer1 != null)
            {
                total=0+0;   
            }
            return total;
        }
    }
}
