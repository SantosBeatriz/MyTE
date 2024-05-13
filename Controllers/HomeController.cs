using Microsoft.AspNetCore.Mvc;

namespace MyTE.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }
}
