using _21jul.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace _21jul.Controllers
{
    public class HomeController : Controller
    {
        //display form
        public IActionResult Register()
        {
            return View();
        }

        //handle form submission
        [HttpPost]
        public ActionResult Register(Student student)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Message = "Student" + student.Name + "register successfully in College";
            }
            return View(student);
        }



    }
}
