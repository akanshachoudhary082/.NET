using Microsoft.AspNetCore.Mvc;
using StudentInfoWeb.Services;
using StudentInfoWeb.Models;
using System.Security.Cryptography.X509Certificates;

namespace StudentInfoWeb.Controllers
{
    public class StudentContoller : Controller

    {

        private IStudentService _studentService;

        public StudentContoller(IStudentService studentService)
        {
            _studentService = studentService;
        }


        [HttpPost]
       // [ValidateAntiForgeryToken]
        public IActionResult Insert(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.Insert(student);
                return RedirectToAction(nameof(Index));
            }
            return View(student);
        }
    }
}