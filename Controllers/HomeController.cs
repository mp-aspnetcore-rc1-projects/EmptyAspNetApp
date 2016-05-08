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

        public string Welcome(string name,int ID=1)
        {
            return HtmlEncoder.Default.HtmlEncode(
                "Hello " + name + ",the ID is " + ID
            );
        }
        public IActionResult Error()
        {
            return View();
        }
    }
}