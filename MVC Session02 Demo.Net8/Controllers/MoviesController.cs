using Microsoft.AspNetCore.Mvc;

namespace MVC_Session02_Demo.Net8.Controllers
{
    public class MoviesController : Controller
    {
        //action 
        //public non-static method
        //public string GetMovie(string id) { return $"id={id}"; }
        //public string Test() { return "Default"; }
        #region Action Return Type
        //Actions Has Special Data Types
        public ContentResult GetMovie(string id) {  ContentResult result = new ContentResult();
            result.Content = $"id={id}";
           // result.ContentType = "text/html" ;
          //  result.ContentType = "object/pdf" ;
            return result; }
        public RedirectToActionResult Test(string id)
        {
            RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies",new {id});
            return result;
        }
        public RedirectResult Test01(string id)
        {
            RedirectResult result = new RedirectResult("https://www.facebook.com");
            return result;
        }

        #endregion
    }
}
