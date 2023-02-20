using Microsoft.AspNetCore.Mvc;
using employeeManagement.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace employeeManagement.Controllers
{
    public class EmployeeController : Controller
    {

        Employee empObj = new Employee(); //we should use DI instead of this

        public IActionResult EmployeeList()
        {
            ViewBag.emplist = empObj.GetALlEmp();
            return View();
        }

        public IActionResult SearchEmployee()
        {
            ViewBag.hasEmp = false;
            ViewBag.errMessage = "";
            return View();
        }

        [HttpPost]
        public IActionResult SearchEmployee(int searchId)
        {
            try
            {
                ViewBag.empinfo = empObj.GetEmployeeById(searchId);
                ViewBag.hasEmp = true;
            }
            catch (Exception es)
            {
                ViewBag.hasEmp = false;
                ViewBag.errMessage = es.Message; 
                return View();
            }
           

            return View();
        }

        public IActionResult EditEmployee(int searchId)
        {
            ViewBag.emp = empObj.GetEmployeeById(searchId);
            return View();
        }


        [HttpPost]
        public IActionResult EditEmployee(Employee empChanges)
        {
            ViewBag.editresult = empObj.EditEmployee(empChanges);
            return View();
        }



    }
}
