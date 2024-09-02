using Microsoft.AspNetCore.Mvc;

namespace MVC03.Controllers
{
    public class HomeController : Controller
    {
        // Dafault Action
        // GetAll => Index 
        public IActionResult Index()
        {
            //ViewResult viewResult = new ViewResult();
            //return viewResult;

            return View(); // Return view with the same name of action (Index)
        }
        public IActionResult AboutUs()
        {
            return View(); 
        }
        public IActionResult Privcy()
        {
            return View();
        }
        public IActionResult ContactUs()
        {
            return View();
        }
    }
}
