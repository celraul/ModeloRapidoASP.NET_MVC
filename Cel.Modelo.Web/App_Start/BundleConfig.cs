using System.Web;
using System.Web.Optimization;

namespace Cel.Modelo.web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region comuns

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/font-awesome.min.css",
                        "~/Content/Toast.css"
            ));

            //bundles.Add(new ScriptBundle("~/bundles/jquery").Include("~/Scripts/jquery-{version}.js"));
            bundles.Add(new ScriptBundle("~/bundles/jqueryBootstrap").Include(
                        "~/Scripts/Custom/bootstrap.js",
                        "~/Scripts/Custom/jquery.js",
                        "~/Scripts/jquery.confirm.js",
                        "~/Scripts/Utils.js",
                        "~/Scripts/Toast.js"
                        ));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

            #endregion

            #region login

            bundles.Add(new ScriptBundle("~/bundles/ScriptLibs").Include(
                        "~/Scripts/jquery.backstretch.js",
                        "~/Scripts/jquery.backstretch.min.js"));

            #endregion

            #region dashboard home JS

            bundles.Add(new ScriptBundle("~/Custom/js").Include(
                       "~/Scripts/Custom/flot/bootstrap.min.js",
                       "~/Scripts/Custom/flot/excanvas.min.js",
                       "~/Scripts/Custom/flot/flot-data.js",
                       "~/Scripts/Custom/flot/jquery.flot.js",
                       "~/Scripts/Custom/flot/jquery.flot.pie.js",
                       "~/Scripts/Custom/flot/jquery.flot.resize.js",
                       "~/Scripts/Custom/flot/jquery.flot.tooltip.min.js",
                       "~/Scripts/Custom/morris/morris-data.js",
                        "~/Scripts/Custom/morris/morris.js",
                        "~/Scripts/Custom/morris/raphael.min.js"
                       ));

            #endregion

            #region dashboard home CSS

            bundles.Add(new StyleBundle("~/Custom/css").Include(
                        "~/Content/Custom/morris.css",
                        "~/Content/Custom/sb-admin.css",
                        "~/Content/Custom/sb-admin-rtl.css"
						//"~/Content/Custom/bootstrap.min.css"
					//	 "~/Content/site.css"
                     ));

            #endregion

            //Aplica o processo de bundle para otimizar minificação
            //BundleTable.EnableOptimizations = true;
        }
    }
}
