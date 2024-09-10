using Microsoft.AspNetCore.Mvc;

namespace MVC_Session02_Demo.Net8.Controllers
{
    public class MoviesController : Controller
    {
        //action 
        //public non-static method
        public string GetMovie(string id) { return $"id={id}"; }
        public string Test() { return "Default"; }
    }
}
