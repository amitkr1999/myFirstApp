using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Dashboard()
        {
            return View();
        }
        public IActionResult Contact()
        {
            
            return View();
        }   
    }
}
