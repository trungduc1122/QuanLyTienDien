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
            new Customer{Id=1, Name="",Address="",Quantity=10000,Price=10000,Type="",Limit=8000,Nationality="VN"},
            new Customer{Id=2, Name="",Address="",Quantity=6000,Price=10000,Type="",Limit=8000,Nationality="VN"},
            new Customer{Id=3,Name="",Address="",Quantity=10000,Price=10000,Nationality="US"}
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
        public double total(Customer customer)
        {
            double total=0;
            if (customer.Nationality == "VN")
            {

            }
            else
            {

            }
            return total;
        }
    }
}
