using System.Collections.Generic;

namespace RazorDeepDive.Services
{
    public class ProductService : IProductService
    {
        public IList<Product> GetProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Name = "Product 1"
                },
                new Product
                {
                    Name = "Product 2"
                }
            };
        }
    }

    public class Product
    {
        public string Name { get; set; }
    }
}