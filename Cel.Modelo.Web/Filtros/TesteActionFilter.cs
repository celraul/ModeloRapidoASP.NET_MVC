using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cel.Modelo.web.ActionsFilters
{
    public class TesteActionFilter : ActionFilterAttribute, IActionFilter
    {
        void IActionFilter.OnActionExecuting(ActionExecutingContext filterContext)
        {
            //filterContext.Controller.ViewBag.ConteudoAd = GerarConteudoAD();
        }

        void IActionFilter.OnActionExecuted(ActionExecutedContext filterContext)
        {

        }

    }
}