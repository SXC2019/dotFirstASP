using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View("About");
        }

        public IActionResult Add()
        {
            int a = 3, b = 0, c;
            c = a / b;

            string fname = Request.Query["txtFirst"];
            string lname = Request.Query["txtSecond"];

            string fullName = fname + lname;

            ViewBag.Info= fullName; 
            return View("Information");
        }

        public IActionResult Error()
        {

            return View("PageNotFound");
        }
    }
}
