using FIRSTMVCAPP.Models;
using Microsoft.AspNetCore.Mvc;

namespace FIRSTMVCAPP.Controllers
{
    public class GetEmpDataController : Controller
    {
        //Static Part
        /*public IActionResult ShowEmpData()
        {
            Models.GetEmpData getEmpData = new Models.GetEmpData();
            Employee employee = getEmpData.GetEmpDet();
            return View(employee);
        }*/

        //Dynamic Part
        public IActionResult ShowEmpDet(int id,string name,string title,int sal)
        {
            Employee emp = new Employee();
            emp.empID = id;
            emp.empName = name;
            emp.empTitle = title;
            emp.empSal = sal;
            return View(emp);
        }
        public IActionResult GetEmpDet()
        {
            return View();
        }
    }
}
