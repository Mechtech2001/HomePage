using Microsoft.AspNetCore.Mvc;
using HomePage.Models;
using System.Collections.Generic;
using System.Linq;

namespace HomePage.Controllers
{
    public class StudentController : Controller
    {
        private StudentContext _context { get; set; }

        public StudentController(StudentContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Student()
        {
            // This would typically come from user input or authentication
            var model = new StudentAccess
            {
                AccessLevel = 1, // Example access level, replace with real data
                Students = _context.Student.ToList()
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Student(StudentAccess model)
        {
            if (ModelState.IsValid)
            {
                // Fetch students from the database
                model.Students = _context.Student.ToList();
                return View(model);
            }

            // If the model is invalid, return the same view with the current model
            return View(model);
        }
    }
}
