using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace V_View.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ViewResult Greet()
        {
            return View();
        }

        public ViewResult ViewWithDiffName()
        {
            return View("_ViewWithDiffName");
        }
    }
}