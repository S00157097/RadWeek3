using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Exercise2.Models;

namespace Exercise2.DAL
{
    public class ProductRepository : IProductRepository
    {
        private SampleDBEntities1 context;

        public ProductRepository(SampleDBEntities1 ctx)
        {
            this.context = ctx;
        }

        public void Dispose()
        {
            this.context.Dispose();
        }

        public Product GetProductById(int id)
        {
            return this.context.Products.Find(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return this.context.Products;
        }
    }
}