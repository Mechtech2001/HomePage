using Microsoft.AspNetCore.Mvc;
using HomePage.Models;

namespace HomePage.Controllers
{
    public class StudentController : Controller
    {
      
        public IActionResult AccessLevel()
        {
            return View();
        }

        [HttpPost]
        
        public IActionResult AccessLevel(int accessLevel)
        {
            var students = new List<Student>
        {
            new Student { FirstName = "Tommy", LastName = "Wells", Grade = "A" },
            new Student { FirstName = "Eli", LastName = "Ashby", Grade = "B" },
            new Student { FirstName = "Emily", LastName = "Jones", Grade = "C" },
            new Student { FirstName = "Michael", LastName = "Harvey", Grade = "B+" },
            new Student { FirstName = "Amanda", LastName = "Christie", Grade = "A-" }
        };

            var viewModel = new StudentAccess
            {
                Students = students,
                AccessLevel = accessLevel
            };

            return View("Student", viewModel);
            
        }

       



    }
}
