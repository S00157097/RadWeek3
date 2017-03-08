using Exercise2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Exercise2.DAL
{
    public interface IProductRepository : IDisposable
    {
        IEnumerable<Product> GetProducts();
        Product GetProductById(int id);
    }
}