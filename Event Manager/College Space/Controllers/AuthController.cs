using College_Space.Models;
using Microsoft.AspNetCore.Mvc;

namespace College_Space.Controllers
{
    public class AuthController : Controller
    {
        public IActionResult CheckUser(string Password, string username)
        {
            User us = new User();
            us.UserName = username;
            us.PassWord = Password;

            if (us.UserName == "teacher" && us.PassWord == "teacher")
            {
                return this.RedirectToAction("Index", "Events");
            }
            else if (us.UserName == "student" && us.PassWord == "student")
            {
                return this.RedirectToAction("StudentViewTable", "StudentView");
            }
            else
            {
                return View();
            }

        }
        public IActionResult Home()
        {
            return View();
        }
    }
}
