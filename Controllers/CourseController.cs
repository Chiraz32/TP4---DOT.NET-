using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication4.Data;
using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class CourseController : Controller
    {
       
        public IActionResult AllCourses()
        {
            UniversityContext universityContext = UniversityContext.Instantiate_University_Context();
            StudentRepository studentRepository = new StudentRepository(universityContext);
           
            foreach (String s in studentRepository.GetCourses())
                Debug.WriteLine(s);

            return View(studentRepository.GetCourses());
            
        }

        public IActionResult ShowCourse(string id)
        {
            UniversityContext universityContext = UniversityContext.Instantiate_University_Context();
            StudentRepository studentRepository = new StudentRepository(universityContext);
            IEnumerable<Student> res = (IEnumerable<Student>)studentRepository.Find(v => v.Course.ToLower() == id.ToLower());
           foreach (Student s in res)
            {
              Debug.WriteLine(s.Id);
            }

            if (res.Count() != 0)
            { ViewBag.Id = res.First().Course; }
            return View(res);
        }
    }
}
