using Microsoft.AspNetCore.Mvc;

namespace webmvc.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        
    }
}