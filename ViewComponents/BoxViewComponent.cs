using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RazorDeepDive.Services;

namespace RazorDeepDive.ViewComponents
{
    public class BoxViewComponent : ViewComponent
    {
        private readonly IProductService _productService;

        public BoxViewComponent(IProductService productService)
        {
            _productService = productService;
        }

        public async Task<IViewComponentResult> InvokeAsync(int maxPriority, bool isDone)
        {
            var res = _productService;

            return View(new DummyViewModel
            {
                Products = res.GetProducts()
            });
        }
    }

    public class DummyViewModel
    {
        public IList<Product> Products { get; set; }
    }
}