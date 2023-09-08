using Microsoft.AspNetCore.Mvc;
using MyFirstApp.Models;
using System.Diagnostics;

namespace MyFirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Products()
        {
            return View("OurCompanyProduct");
        }
        public IActionResult Contact()
        {
            return View();
        }

        public IActionResult GetEmpName(int EmpId)
        {
            var employees = new[]
                    {
                new { EmpId = 1, EmpName = "Scott", Salary = 8000 },
                new { EmpId = 2, EmpName = "Smith", Salary = 7000 },
                new { EmpId = 3, EmpName = "Allen", Salary = 9000 },
            };
            string matchEmpName = null;
            foreach (var item in employees)
            {
                if (item.EmpId == EmpId)
                {
                    matchEmpName = item.EmpName;
                }
            }

            return Content(matchEmpName, "text/plan");
        }
        public IActionResult GetPaySlip(int EmpId)
        {
            string fileName = "~/PaySlip" + EmpId + ".pdf";
            return File(fileName,"application/pdf");
        }
        public IActionResult EmpFacebookPage(int EmpId)
        {
            string fbUrl = "https://www.facebook.com/emp" + EmpId;
            return Redirect(fbUrl);
        }

        public IActionResult StudentDetails()
        {
            ViewBag.StudentId = 101;
            ViewBag.StudentName = "Scott";
            ViewBag.Marks = 80;
            ViewBag.Semester = 6;
            ViewBag.Subjects = new List<String>() {"Math", "Physic", "Chemestry"};  

            return View();
        }

        //[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        //public IActionResult Error()
        //{
        //    return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        //}

    }

} 


