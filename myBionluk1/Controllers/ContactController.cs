using Microsoft.AspNetCore.Mvc;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace myBionluk1.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        // [HttpPost, ValidateAntiForgeryToken]

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

