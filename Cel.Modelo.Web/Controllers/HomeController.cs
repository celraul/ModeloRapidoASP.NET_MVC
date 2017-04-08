using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cel.Modelo.web.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Application for Demonstrate";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Raul R. da Silva";

            return View();
        }
    }
}