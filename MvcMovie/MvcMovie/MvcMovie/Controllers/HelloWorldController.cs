using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: /HelloWorld/
        public IActionResult Index()
        {
            return View();
        }

        // GET: /HelloWorld/Welcome/ 
        public IActionResult Welcome( string name, int id = 1,string msg = "I got nothing to say...")
        {
            ViewData["message"] = $"Hello {name}, here is your message: {msg}";
            ViewData["id"] = id;
            ViewData["numTimes"] = 5;

            return View();
        }
    }
}