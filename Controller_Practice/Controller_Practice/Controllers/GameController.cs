using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Controller_Practice.Controllers
{
    public class GameController : Controller
    {
        // GET: Game
        public ActionResult Index()
        {
            return View();
        }

        public string Name(string name)
        {
            return string.Format("<h3>Hi {0},<h3>", name);
        }

        public string FullName(string fname, string lname)
        {
            return string.Format("<h3>Hello {0} {1}</h3>", fname, lname);
        }
    }
}