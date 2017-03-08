using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise2.Models;

namespace Exercise2.DAL
{
    public class DummyCustomerRepository : ICustomerRepository
    {
        public DummyCustomerRepository() { }

        public void Dispose() { }

        public Customer GetCustomerById(int id)
        {
            return new Customer
            {
                CustomerID = "cust01",
                ContactName = "Fake Name",
                Country = "Ireland"
            };
        }

        public List<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer
                {
                    CustomerID = "cust01",
                    ContactName = "Fake Name",
                    Country = "Ireland"
                },
                new Customer
                {
                    CustomerID = "cust03",
                    ContactName = "Fake Name 2",
                    Country = "Germany"
                }
            };
        }
    }
}