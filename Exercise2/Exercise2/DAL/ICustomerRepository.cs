using Exercise2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise2.DAL
{
    public interface ICustomerRepository : IDisposable
    {
        List<Customer> GetCustomers();
        Customer GetCustomerById(int id);
    }
}