using Microsoft.AspNet.Mvc;
using Microsoft.Extensions.WebEncoders;

namespace BasicAspApp.Controllers
{
    public class HomeController : Controller
    {

        // Index is the default handler
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Welcome(string name, int ID = 1)
        {
            ViewData["Name"] = name;
            ViewData["ID"] = ID;

            return View();
        }
        public IActionResult Error()
        {
            return View();
        }

        public IActionResult StatusCodePage()
        {
            return View("~/Views/Shared/StatusCodePage.cshtml");
        }
    }
}