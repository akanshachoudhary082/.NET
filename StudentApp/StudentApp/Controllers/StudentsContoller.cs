using Microsoft.AspNetCore.Mvc;
using StudentInfoWeb.Services;
using StudentInfoWeb.Models;
using System.Security.Cryptography.X509Certificates;

namespace StudentInfoWeb.Controllers
{
    public class StudentsContoller : Controller

    {

        private IStudentService _studentService;

        public StudentsContoller(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]

        public IActionResult Index()
        {
            return View();
        }


        [HttpPost]
        public IActionResult GetAllStudents()
        {
            List<Student> list = _studentService.GetAllStudents();
            ViewData["catalog"] = list;
            return View();

        }

        //[HttpGet]
        public IActionResult Add()
        {
            return View();
        }
        [HttpPost]
        // [ValidateAntiForgeryToken]
        public IActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                return View();
                _studentService.Insert(student);
                return RedirectToAction(nameof(Index));
            }
            _studentService.Insert(student);
            return RedirectToAction("getAllStudents");
        }
    }
}

/*using Microsoft.AspNetCore.Mvc;
using StudentInfoWeb.Models;
using StudentInfoWeb.Services;
using System.Collections.Generic;

namespace StudentInfoWeb.Controllers
{
    public class StudentsController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var students = _studentService.GetAllStudents();
            ViewBag.Students = students;
            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.Insert(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            var student = _studentService.GetById(id);
            if (student == null)
            {
                return NotFound();
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentService.Update(student);
                return RedirectToAction("Index");
            }
            return View(student);
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            _studentService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
*/