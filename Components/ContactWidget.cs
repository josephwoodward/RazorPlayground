using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace RazorDeepDive.Components
{
    public class ContactWidget : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}