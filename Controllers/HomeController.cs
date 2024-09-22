using Microsoft.AspNetCore.Mvc;
using Portfolio.Models;

namespace Portfolio.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ME me = new ME()
            {
                Id = 1,
                Age=21,
                Name="Ibrahem Arafa",
                Specialization= "ASP.NET Core development",
                University= "Tanta University"
            };
            return View(me);
        }
        public IActionResult Skills()
        {
            ViewData["SoftwareSkills"] = new List<string>
    {
        "OOP, SOLID principles, Data Structures and Algorithms",
        "Design Patterns, DBMS, System Design"
    };

            ViewData["OtherSkills"] = new List<string>
    {
        "Git, GitHub and GitLab"
    };
           
            ViewBag.ProgrammingLanguages = new List<string>
    {
        "C#, C++, Java, SQL, Python"
    };

            ViewBag.FrontEndTechnologies = new List<string>
    {
        "HTML, CSS, JavaScript"
    };

            return View();
        }
            
        public IActionResult Projects()
        {
            return View();
        }
        public IActionResult ContactMe()
        {
            return View();
        }
        public IActionResult Detalis()
        {
            return View();
        }

    }
}
