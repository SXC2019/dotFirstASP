using Microsoft.AspNetCore.Mvc;

namespace WebApplication5.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
