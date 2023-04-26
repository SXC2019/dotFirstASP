using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
  
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [Route("Mero/con")]
        public IActionResult Contact()
        {
            return View();
        }

        [Route("Mero/abt")]
        public IActionResult AboutUs()
        {
            return View("About");
        }

        public IActionResult Add()
        {
            
            

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
