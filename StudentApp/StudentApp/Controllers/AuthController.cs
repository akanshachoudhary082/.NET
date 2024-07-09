using Microsoft.AspNetCore.Mvc;
using StudentInfoWeb.Services;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace StudentInfoWeb.Controllers
{
    public class AuthController : Controller
    {
        private IStudentService _studentService;

        public  AuthController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

       

        [HttpPost]
        public IActionResult Login(string email,string password)
        {

            if (email == "ram@gmail.com"
                && password == "seed")
            {
                return RedirectToAction("index", "students");
            }
            return View();
        }

    }
}
