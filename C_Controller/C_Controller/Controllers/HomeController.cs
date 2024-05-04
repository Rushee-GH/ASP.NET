using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace C_Controller.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public string Index()
        {
            return "<h2> Hello from Rushi </h2>";
        }

        public string Greet()
        {
            return "<h3>Hello</h3><p>Hope you are doing well</p>";
        }
    }
}