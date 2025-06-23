using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessObjects;
using Services;

namespace DataAccessLayer
{
    public class CustomerDAO
    {
        static List<Customer> list = new List<Customer>();
        public void GenerateSampleDataSet()
        {
            customer.Add(new Customer() { Id = 1, Name = "john dove", Phone = "123-444-5554" });
            customer.Add(new Customer() { Id = 2, Name = "john dove1", Phone = "123-444-5554" });
            customer.Add(new Customer() { Id = 3, Name = "john dove2", Phone = "123-444-5554" });
            customer.Add(new Customer() { Id = 4, Name = "john dove3", Phone = "123-444-5554" });
        }
        public List<Customer> GetAllCustomers() 
        {
            return customers;
        }
    }
}
