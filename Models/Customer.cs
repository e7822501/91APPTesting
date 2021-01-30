using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _91APPTesting.Models
{
    [Serializable]
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
    }
    public class CustomerDao
    {
        private static IList<Customer> _customers = new List<Customer>()
        {
            new Customer(){ CustomerId = 1, Name = "UserA" },
        };

        public IList<Customer> GetCustomers() 
        {
            return _customers;
        }
    }
}