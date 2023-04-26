using Microsoft.AspNetCore.Mvc;
using WebApplication5.Models;

namespace WebApplication5.Controllers
{
    public class AccountController : Controller
    {
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register(RegisterModel registerModel) 
        {
            //string email = registerModel.Email;

            //ViewBag.Info = email;
            //return View("Information");

            if(ModelState.IsValid)
            {
                Response.Redirect("https://www.gmail.com");

            }
            return View();
        }
    }
}
