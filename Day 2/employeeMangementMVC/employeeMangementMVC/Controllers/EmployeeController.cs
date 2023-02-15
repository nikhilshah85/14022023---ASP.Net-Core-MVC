using Microsoft.AspNetCore.Mvc;
using employeeMangementMVC.Models;
namespace employeeMangementMVC.Controllers
{
    public class EmployeeController : Controller
    {

        Employee empObj = new Employee(); //Model Object

        public IActionResult DisplayEmployeeList()
        {
            ViewBag.eList = empObj.GetAllEmployees();
            return View();
        }

        [HttpPost]
        public IActionResult DisplayEmployeeList(int empNo)
        {
            empObj.DeleteEmployee(empNo);
            ViewBag.eList = empObj.GetAllEmployees();
            return View();
        }

        public IActionResult AddNewEmployee()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddNewEmployee(Employee employee)
        {
            ViewBag.addMessage =  empObj.AddNewEmployee(employee);
            return RedirectToAction("DisplayEmployeeList");
        }




    }
}
