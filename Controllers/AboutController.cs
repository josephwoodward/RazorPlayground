using Microsoft.AspNetCore.Mvc;

namespace RazorDeepDive.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}