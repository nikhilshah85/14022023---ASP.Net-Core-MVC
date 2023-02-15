using Microsoft.AspNetCore.Mvc;

namespace bankingMVC.Controllers
{
    public class AccountsController : Controller
    {


# region Pass the data from Controller to View
        public IActionResult AccountDetails()
        {

            //this is how controller will pass the data to a view, 
            //this are hard-coded as well loosely typed
            ViewBag.accNo = 101;
            ViewBag.accName = "Nikhil";
            ViewBag.accType = "Savings";
            ViewBag.accBalance = 6000;
            ViewBag.accIsActive = false;

            return View();
        }
        #endregion

 #region Pass data from View to controller - Example 1
        //this is a 2 step process, very much as per Design pattern, MVC
        //step 1 : you need to have 2 methods, 1 GET and 2 Post
        //step 2 : In the view, pass the parameter as name atribute

        [HttpGet] //all methods by default are HttpGet, attribute is optional
        public IActionResult GreetUser()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GreetUser(string guestName)
        {
            ViewBag.message = "Hello and Welcome to MVC " + guestName;
            return View();
        }

        #endregion

 #region Pass data from View to Controller  - Example 2

        public IActionResult CalculateNumbers()
        {
            ViewBag.errMessage = "";
            ViewBag.hasError = false;
            ViewBag.hasData = false;
            return View();
        }
        [HttpPost]
        public IActionResult CalculateNumbers(int num1, int num2)
        {
            if (num1 == 0 || num2 == 0)
            {
                ViewBag.errMessage = "Plaese enter values greater 0";
            }
            else if(num1 < 0 || num2 <0)
            {
                ViewBag.errMessage = "Enter Only Positive Numbers";
            }
            if (num2 > num1)
            {
                ViewBag.errMessage = "This will result in Negative values,we do not process them";
            }
            ViewBag.hasData = true;
            ViewBag.add = num1 + num2;
            ViewBag.sub = num1 - num2;
            ViewBag.div = num1 / num2;
            ViewBag.multi = num1 * num2;
           
            return View();

        }


        #endregion
    }
}
