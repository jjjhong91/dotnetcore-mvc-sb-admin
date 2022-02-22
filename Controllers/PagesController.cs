using Microsoft.AspNetCore.Mvc;

namespace webmvc.Controllers
{
    public class PagesController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }
        public IActionResult ForgotPassword()
        {
            return View();
        }
        public IActionResult NotFoundPage()
        {
            return View();
        }
        public IActionResult Blank()
        {
            return View();
        }
    }
}