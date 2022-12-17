using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Controllers
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
            UniversityContext universityContext = UniversityContext.Instantiate_University_Context();
            Debug.WriteLine("UniversityContext is instantiated {0} times", UniversityContext.count);
            List<Student> s = universityContext.student.ToList();

            foreach (Student student in s)
            {
                Debug.WriteLine("Student {0} {1} {2} {3}  ", student.Id, student.First_name, student.Last_name, student.Phone_number);
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
