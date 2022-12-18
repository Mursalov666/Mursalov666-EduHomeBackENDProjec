using Microsoft.AspNetCore.Mvc;

namespace EduHomeProject.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Signup()
        {
            return View();
        }
    }
}
