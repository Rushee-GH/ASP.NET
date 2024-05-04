using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C_Controller.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }

        public string Role(int id)
        {
            switch(id)
            {
                case 0:
                    return "Admin";
                case 1:
                    return "Manager";
                case 2:
                    return "Employee";
                case 3:
                    return "Peoun";
                default:
                    return "Invalid Role";
            }
        }
    }
}