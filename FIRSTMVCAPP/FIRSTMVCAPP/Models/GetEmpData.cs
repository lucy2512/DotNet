namespace FIRSTMVCAPP.Models
{
    public class GetEmpData
    {
        //Static Part
        /*public Employee GetEmpDet()
        {
            Employee emp = new Employee();
            emp.empID = 01;
            emp.empName = "Parthib";
            emp.empTitle = "SDE";
            emp.empSal = 90000;
            return emp;
        }*/

        //Dynamic Part
        public Employee GetEmpDet(int id,string name,string titile,int sal)
        {
            Employee emp = new Employee();
            emp.empID = id;
            emp.empName = name;
            emp.empTitle = titile;
            emp.empSal = sal;
            return emp;
        }
    }
}
