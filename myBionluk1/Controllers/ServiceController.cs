using Microsoft.AspNetCore.Mvc;

namespace myBionluk1.Controllers
{
    public class ServiceController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult EnIndex()
        {
            return View();
        }

        public IActionResult DeIndex()
        {
            return View();
        }
    }
}
