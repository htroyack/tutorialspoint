using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCFirstApp.Controllers
{
    public class InternautasController : Controller
    {
        // GET: Internautas
        public string Index()
        {
            return "dilma rousseff";
        }
        public string Internautas()
        {
            return "- Oi Internautas";
        }
    }
}