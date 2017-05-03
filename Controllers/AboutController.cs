using Microsoft.AspNetCore.Mvc;

namespace RazorDeepDive.Controllers
{
    public class ExampleViewModel
    {
        public string Name { get; set; }
    }

    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = "Your application description page.";

            return View(new ExampleViewModel());
        }
    }
}