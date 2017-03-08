using Exercise2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise2.DAL
{
    public class CustomerRepository : ICustomerRepository
    {
        private SampleDBEntities1 context;

        public CustomerRepository(SampleDBEntities1 ctx)
        {
            this.context = ctx;
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public Customer GetCustomerById(int id)
        {
            return this.context.Customers.Find(id);
        }

        public List<Customer> GetCustomers()
        {
            return this.context.Customers.ToList();
        }
    }
}