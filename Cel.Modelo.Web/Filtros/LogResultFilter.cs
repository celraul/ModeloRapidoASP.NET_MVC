using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cel.Modelo.web.Filtros
{
    public class LogResultFilter : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            string mensagem = String.Format("{0} Resultado: {1}/{2}  |  {3} ",
                                             DateTime.Now,
                                             filterContext.RouteData.Values["controller"].ToString(),
                                             filterContext.RouteData.Values["action"].ToString(),
                                             filterContext.Result.ToString()
                                             );

            Debug.WriteLine(mensagem);
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            string mensagem = String.Format("{0} Processando resultados: {1}/{2}  |  {3} ",
                                             DateTime.Now,
                                             filterContext.RouteData.Values["controller"].ToString(),
                                             filterContext.RouteData.Values["action"].ToString(),
                                             filterContext.Result.ToString()
                                             );

            Debug.WriteLine(mensagem);
        }
    }
}