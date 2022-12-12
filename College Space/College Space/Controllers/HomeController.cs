using College_Space.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace College_Space.Controllers
{
    public class HomeController : Controller
    {

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        /*public IActionResult CheckUser(string Password, string username)
        {
            User us = new User();
            us.UserName = username;
            us.PassWord = Password;

            if (us.UserName == "admin" && us.PassWord == "admin")
            {
                return RedirectToAction("Index", "Events");
            }
            else
            {
                return this.RedirectToAction("StudentViewTable", "StudentView");
            }
        }*/

        public IActionResult Index()
        {
            return this.RedirectToAction("CheckUser","Auth");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }


    }
}