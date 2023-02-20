using Microsoft.AspNetCore.Mvc;
using employeeManagementMVC.Models;

namespace employeeManagementMVC.Controllers
{
    public class EmployeeController : Controller
    {
        Employee empObj = new Employee(); // we use DI here

        public IActionResult ShowAllEmployees()
        {
            ViewBag.allEmp = empObj.GetAllEmployee();
            return View();
        }


        public IActionResult ShowEmployeeById()
        {
            ViewBag.hasErr = false;
            ViewBag.message = "";
            return View();
        }
        [HttpPost]
        public IActionResult ShowEmployeeById(int id)
        {
            try
            {
                
                ViewBag.emp = empObj.GetEmployeeById(id);
                ViewBag.hasErr = true;
                return View();
            }
            catch (Exception es)
            {
                ViewBag.hasErr = false;
                ViewBag.message = es.Message;
                return View();
            }
           
        }

        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employee newEmp)
        {

            try
            {
                ViewBag.message = empObj.AddEmployee(newEmp);
                return RedirectToAction("ShowAllEmployees");
            }
            catch (Exception es)
            {

                ViewBag.message = es.Message;
            }

            return View();


           
        }


    }
}










