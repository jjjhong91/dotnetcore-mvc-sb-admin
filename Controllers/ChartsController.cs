using Microsoft.AspNetCore.Mvc;

namespace webmvc.Controllers
{
    public class ChartsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}