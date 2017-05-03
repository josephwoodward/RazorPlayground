using System.Collections.Generic;

namespace RazorDeepDive.Services
{
    public interface IProductService
    {
        IList<Product> GetProducts();
    }
}