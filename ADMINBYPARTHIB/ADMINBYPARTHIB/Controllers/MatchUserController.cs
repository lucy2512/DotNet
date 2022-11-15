using ADMINBYPARTHIB.Models;
using Microsoft.AspNetCore.Mvc;

namespace ADMINBYPARTHIB.Controllers
{
    public class MatchUserController : Controller
    {
        public IActionResult CheckUser(string Password, string username)
        {
            User us = new User();
            us.userName = username;
            us.password = Password;

            if(us.userName == "admin" && us.password == "admin")
            {
                return View("Welcome");
            }
            return View("IncorrectPassword");


        }
        public IActionResult Home()
        {
            return View();
        }
    }
}
