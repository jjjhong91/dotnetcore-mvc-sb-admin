using Microsoft.AspNetCore.Mvc;

namespace webmvc.Controllers
{
    public class ComponentsController : Controller
    {
        public IActionResult Buttons()
        {
            return View();
        }

        public IActionResult Cards()
        {
            return View();
        }
        
    }
}