using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;       //these are libraries
using TechAcadStudentsMVC.Models;

namespace TechAcadStudentsMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Instructors()
        {
            List<Instructor> instructors = new List<Instructor>
            {
                new Instructor
                {
                    Id = 1, FirstName = "Rick", LastName = "Ramen"
                },
                 new Instructor
                {
                    Id = 1, FirstName = "Brett", LastName = "Calendar"
                },
                  new Instructor
                {
                    Id = 1, FirstName = "Adam", LastName = "Smithsonian"
                }
            };
            return View(instructors);
        }

        public ActionResult Instructor(int id)
        {
            ViewBag.Id = id;
            Instructor dayTimeInstructor = new Instructor
            {
                Id = id,
                FirstName = "Erik",
                LastName = "Gross"
            };
            return View(dayTimeInstructor);
        }
    }

}