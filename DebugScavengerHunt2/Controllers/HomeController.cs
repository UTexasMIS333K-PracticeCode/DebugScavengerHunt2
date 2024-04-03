using Microsoft.AspNetCore.Mvc;

namespace DebugScavengerHunt2.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //return the home page with the links to the other pages
            return View();
        }
    }
}
