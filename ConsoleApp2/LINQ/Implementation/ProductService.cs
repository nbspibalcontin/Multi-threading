using ConsoleApp2.LINQ.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2.LINQ.Implementation
{
    public class ProductService : IProduct
    {
        private readonly List<Product> products;

        public ProductService()
        {
            products = new List<Product>
            {
                new Product { Name = "Laptop", Price = 1200.00 },
                new Product { Name = "Smartphone", Price = 800.00 },
                new Product { Name = "Tablet", Price = 300.00 },
                new Product { Name = "Monitor", Price = 150.00 }
            };
        }

        // Get the product with above price
        public IEnumerable<string> GetProductNamesAbovePrice(double minPrice)
        {
            return products
                .Where(p => p.Price >= minPrice)
                .Select(p => p.Name.ToUpper());
        }
    }
}
