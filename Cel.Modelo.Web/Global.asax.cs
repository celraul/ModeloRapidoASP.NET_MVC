using Cel.Modelo.web.Controllers;
using CrossCuttingSimpleInjetiction;
using ManagerMVC.AutoMapper;
using SimpleInjector.Integration.Web.Mvc;
using System;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;

namespace Cel.Modelo.web
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);

            var container = SimpleInjectorContainer.RegisterServices();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
            
            ////auto Mapper
            AutoMapperConfig.RegisterMapping();
        }

        protected void Session_Start(object sender, EventArgs e)
        {

        }

        protected void Application_BeginRequest(object sender, EventArgs e)
        {

        }

        protected void Application_AuthenticateRequest(object sender, EventArgs e)
        {

        }

        protected void Application_Error(object sender, EventArgs e)
        {
            //Exception exception = Server.GetLastError();
            //Response.Clear();

            //HttpException httpException = exception as HttpException;

            //if (httpException != null)
            //{
            //    string action;

            //    switch (httpException.GetHttpCode())
            //    {
            //        case 404:
            //            // page not found
            //            action = "NotFound";
            //            break;
            //        case 500:
            //            // server error
            //            action = "Error";
            //            break;
            //        default:
            //            action = "Default";
            //            break;
            //    }
            //    Server.ClearError();

            //    Response.Redirect(String.Format("~/Error/{0}/?message={1}", action, exception.Message));
            //}
            //else
            //    Response.Redirect(String.Format("~/Error/Default/?message={0}", "Erro interno."));

        }

        protected void Session_End(object sender, EventArgs e)
        {

        }

        protected void Application_End(object sender, EventArgs e)
        {

        }
    }
}