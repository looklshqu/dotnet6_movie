using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        // Get: /HelloWorld
        //public string Index()
        //{
        //    return "This is my default action.";
        //}

        // Get: /HelloWorld/Welcome
        //public string Welcome()
        //{
        //    return "This is the Welcome action method...";

        //public string Welcome(string name, int id = 1)
        //{
        //    return HtmlEncoder.Default.Encode($"Hello {name}, ID is: {id}");
        //}

        public IActionResult Welcome(string name, int numTimes = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["Numtimes"] = numTimes;

            return View();
        }
    }
}
