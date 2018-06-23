using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        /*
        public ActionResult Index() {
            return View();
        }
        */

        public string Index()
        {
            var myst = new { controller = "Home", action = "Index", id = UrlParameter.Optional };

            return "Hello World, this is ASP.Net MVC Tutorials";
        }

        public string Internautas()
        {
            return "Primeiro eu queria cumprimentar os internautas. -Oi Internautas";
        }
    }
}
