using Microsoft.AspNetCore.Mvc;
using MVC_Session02_Demo.Net8.Models;

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
        //public ContentResult GetMovie(string id) {  ContentResult result = new ContentResult();
        //    result.Content = $"id={id}";
        //   // result.ContentType = "text/html" ;
        //  //  result.ContentType = "object/pdf" ;
        //    return result; 
        //}
        //public RedirectToActionResult Test(string id)
        //{
        //    RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies",new {id});
        //    return result;
        //}
        //public RedirectResult Test01(string id)
        //{
        //    RedirectResult result = new RedirectResult("https://www.facebook.com");
        //    return result;
        //}
        //public ActionResult Test(string id)
        //{
        //    RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies", new { id });
        //    return result;
        //}
        //public ActionResult Test01(string id)

        //{
        //    RedirectResult result = new RedirectResult("https://www.facebook.com");
        //    return result;
        //}
        //[HttpGet]
        //[ActionName("test")]
        //public IActionResult Test(string id)
        //{
        //    RedirectToActionResult result = new RedirectToActionResult("GetMovie", "Movies", new { id });
        //    return result;
        //}
        //public IActionResult Test01(string id)

        //{
        //    //RedirectResult result = new RedirectResult("https://www.facebook.com");
        //    //return result;
        //    return Redirect("https://www.facebook.com");
        //}
        //public IActionResult GetMovie(string id)
        //{
        //  //  ContentResult result = new ContentResult();
        //   // result.Content = $"id={id}";
        //    // result.ContentType = "text/html" ;
        //    //  result.ContentType = "object/pdf" ;
        //    return Content($"id={id}", "object/pdf");
        //}
        //all action data types inherit from ActionResult
        //all of the implement iActionResult
        #endregion
        #region Action Parameters Binding
        //1.Form
        //2.Segment
        //3.queryParams , string
        //4.File

        public IActionResult GetMovie(int Id,string Name ,Movies movie)
        {
            return Content($"id={Id} Name= {Name}");
        }
        #endregion
    }
}
