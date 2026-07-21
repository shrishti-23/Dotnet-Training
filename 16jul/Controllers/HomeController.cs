using _16jul.Models;
using Microsoft.AspNetCore.Mvc;

namespace _16jul.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students = new List<Student>()
            {
                new Student { Id = 101, Name = "abc", Age = 20, Course = "Dotnet framework", Qualification="BEcse" , Gender="F" },
                new Student { Id = 102, Name = "def", Age = 29, Course = "Java framework" ,Qualification="BEit" , Gender="M" },
                new Student { Id = 103, Name = "ghj", Age = 24, Course = "Frontend framework" ,Qualification="BEmech" , Gender="M" },
                new Student { Id = 104, Name = "nmo", Age = 21, Course = "Dotnet framework", Qualification="BEelectrical" , Gender="F" }
            };

            return View(students);
        }
    }
}
