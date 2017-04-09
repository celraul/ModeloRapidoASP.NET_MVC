using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cel.Modelo.web.Controllers
{
    [HandleError]
    public class ErrorController : Controller
    {
        public ActionResult Default(string message)
        {
            ViewBag.ExMensage = message;
            Server.ClearError();

            return View();
        }

        public ActionResult NotFound(string message)
        {

            ViewBag.ExMensage = message;
            Server.ClearError();

            return View();
        }

        public ActionResult Error(string message)
        {
            ViewBag.ExMensage = message;
            Server.ClearError();

            return View();
        }

        //401 – Unauthorized
        //403 – Forbidden
        //404 – Not Found
        //405 – Method Not Allowed
        //406 – Not Acceptable
        //412 – Precondition Failed
        //500 – Internal Server Error
        //501 – Not Implemented
        //502 – Bad Gateway

    }
}