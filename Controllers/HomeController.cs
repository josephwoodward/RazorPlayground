using Microsoft.AspNetCore.Mvc;

namespace RazorDeepDive.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}