using Cel.Modelo.Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cel.Modelo.web.Controllers
{
    public abstract class ControllerBasico : Controller
    {

        #region Toast

        public void SetToast(Toast toast)
        {
            Session.Add("Toast", toast);

            HttpCookie coockie = new HttpCookie("Toast");
            coockie.Expires = DateTime.Now.AddMilliseconds(5000);
            coockie.Value = "True";

            HttpContext.Response.Cookies.Add(coockie);
        }

        public void ShowToast()
        {

            ViewBag.Toast = (Toast)Session["Toast"];

            Session["Toast"] = null;
        }

        #endregion 
    }
}