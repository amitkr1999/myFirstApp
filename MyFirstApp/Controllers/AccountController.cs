using Microsoft.AspNetCore.Mvc;

namespace MyFirstApp.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Login(string Username, string Password)
        {
            if (Username=="admin" && Password == "manager")
            {
                return RedirectToAction("Dashboard", "Admin");
            }
            else
            {
                return RedirectToAction("InvalidLogin");
            }

           
        }
        public IActionResult InvalidLogin()
        {
            return View();
        }
    }
}
