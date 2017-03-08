using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise2.Models;

namespace Exercise2.DAL
{
    public class DummyProductRepository : IProductRepository
    {
        public DummyProductRepository() { }

        public void Dispose() { }

        public Product GetProductById(int id)
        {
            return new Product
            {
                ProductName = "Product 1",
                UnitPrice = 12.50m,
                UnitsInStock = 100
            };
        }

        public IEnumerable<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    ProductName = "Product 1",
                    UnitPrice = 12.50m,
                    UnitsInStock = 100
                },
                    new Product
                {
                    ProductName = "Product 2",
                    UnitPrice = 50.50m,
                    UnitsInStock = 15
                }
            };
        }
    }
}