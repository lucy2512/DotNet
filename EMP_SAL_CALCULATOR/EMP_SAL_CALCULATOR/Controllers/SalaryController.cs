using EMP_SAL_CALCULATOR.Models;
using Microsoft.AspNetCore.Mvc;

namespace EMP_SAL_CALCULATOR.Controllers
{
    public class SalaryController : Controller
    {
        public IActionResult Index()
        {
            return View(new SalDet());
        }

        
        [HttpPost]
        public ActionResult Index(SalDet s)
        {
            if (s.Salary > 100000)
            {
                s.Tax = s.Salary * 20 / 100;
            }
            else if(s.Salary > 80000)
            {
                s.Tax = s.Salary * 10 / 100;
            }
            else if (s.Salary > 60000)
            {
                s.Tax = s.Salary * 5 / 100;
            }
            else
            {
                s.Tax = 0;
            }

            s.AccSalary = s.Salary - s.Tax;
            return View(s);
        }
    }
}
