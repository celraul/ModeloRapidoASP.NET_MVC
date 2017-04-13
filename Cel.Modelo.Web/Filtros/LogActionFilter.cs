using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cel.Modelo.web.Filtros
{
    public class LogActionFilter : FilterAttribute, IActionFilter
    {

        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            string mensagem = String.Format("{0} Finalizou: {1}/{2}  ",
                                            DateTime.Now,
                                            filterContext.RouteData.Values["controller"].ToString(),
                                            filterContext.RouteData.Values["action"].ToString()
                                            );

            Debug.WriteLine(mensagem);
            //TODO implementar log ao excutar uma acion

        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            string mensagem = String.Format("{0} Iniciou: {1}/{2}  ",
                                           DateTime.Now,
                                           filterContext.RouteData.Values["controller"].ToString(),
                                           filterContext.RouteData.Values["action"].ToString()
                                           );

            Debug.WriteLine(mensagem);
        }
    }
}