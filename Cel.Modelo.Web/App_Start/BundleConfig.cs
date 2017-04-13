using System.Web;
using System.Web.Optimization;

namespace Cel.Modelo.web
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {

            #region CSS

            bundles.Add(new StyleBundle("~/Content/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/font-awesome.min.css",
                        "~/Content/Toast.css",
                        "~/Content/jquery-confirm.css"
            ));

            bundles.Add(new StyleBundle("~/Custom/css").Include(
                       "~/Content/Custom/morris.css",
                       "~/Content/Custom/sb-admin.css",
                       "~/Content/Custom/sb-admin-rtl.css"
                    //"~/Content/Custom/bootstrap.min.css"
                    //	 "~/Content/site.css"
                    ));


            #endregion

            #region JS

            bundles.Add(new ScriptBundle("~/bundles/jqueryBootstrap").Include(
                       "~/Scripts/Custom/bootstrap.js",
                        "~/Scripts/Custom/jquery.js",
                        "~/Scripts/bootstrap.js",
                        // "~/Scripts/jquery-{version}.js",
                        "~/Scripts/jquery-3.2.1.js",
                        "~/Scripts/jquery.confirm.js",
                        "~/Scripts/jquery.dataTables.min.js",
                        "~/Scripts/dataTables.bootstrap.min.js"
                        ));


            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include("~/Scripts/jquery.validate*"));

            bundles.Add(new ScriptBundle("~/bundles/ScriptLibs").Include(
                        "~/Scripts/jquery.backstretch.js",
                        "~/Scripts/jquery.backstretch.min.js"
                        ));

            bundles.Add(new ScriptBundle("~/Custom/js").Include(
                          //"~/Scripts/Custom/flot/bootstrap.min.js",
                          //"~/Scripts/Custom/flot/excanvas.min.js",
                          //"~/Scripts/Custom/flot/flot-data.js",
                          //"~/Scripts/Custom/flot/jquery.flot.js",
                          //"~/Scripts/Custom/flot/jquery.flot.pie.js",
                          //"~/Scripts/Custom/flot/jquery.flot.resize.js",
                          //"~/Scripts/Custom/flot/jquery.flot.tooltip.min.js",
                          //"~/Scripts/Custom/flot/jquery.flot.time.js",
                          //"~/Scripts/Custom/morris/morris-data.js",
                          // "~/Scripts/Custom/morris/morris.js",
                          // "~/Scripts/Custom/morris/raphael.min.js",
                           "~/Scripts/Telas/use.js",
                            "~/Scripts/Toast.js",
                            "~/Scripts/Utils.js"
                       ));

            #endregion

            //Aplica o processo de bundle para otimizar minificação
            //BundleTable.EnableOptimizations = true;
        }
    }
}
