using Microsoft.AspNetCore.Mvc;

namespace webmvc.Controllers
{
    public class UtilitiesController : Controller
    {
        public IActionResult Colors()
        {
            return View();
        }

        public IActionResult Borders()
        {
            return View();
        }

        public IActionResult Animations()
        {
            return View();
        }
        
        public IActionResult Other()
        {
            return View();
        }
    }
}