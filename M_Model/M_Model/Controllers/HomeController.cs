using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using M_Model.Models;

namespace M_Model.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = GetList();
            return View(data[0]);
        }

        private List<Student> GetList()
        {
            return new List<Student>()
            {
                new Student()
                {
                    RollNo = 1,
                    Name = "Rushi",
                    Standard = 9,
                    Class = 'B'
                },
                new Student()
                {
                    RollNo = 2,
                    Name = "Rohan",
                    Standard = 9,
                    Class = 'D'
                },
                new Student()
                {
                    RollNo = 3,
                    Name = "Samarth",
                    Standard = 10,
                    Class = 'B'
                },
                new Student()
                {
                    RollNo = 4,
                    Name = "Rizwan",
                    Standard = 12,
                    Class = 'A'
                }
            };
        }
    }
}