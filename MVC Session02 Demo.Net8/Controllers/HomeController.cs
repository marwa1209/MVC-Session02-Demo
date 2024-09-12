using Microsoft.AspNetCore.Mvc;

namespace MVC_Session02_Demo.Net8.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
