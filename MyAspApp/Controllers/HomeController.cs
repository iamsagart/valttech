using Microsoft.AspNetCore.Mvc;

namespace MyAspApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
