using System.Web;
using System.Web.Optimization;

namespace Invstack
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at http://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
            bundles.Add(new ScriptBundle("~/bundles/angular").Include(
                      "~/Scripts/angular.js",
                      "~/Scripts/angular.min.js",
                      "~/Scripts/angular-route.js",
                      "~/Scripts/angular-route.min.js",
                      "~/ScriptsNg/Module/app.js",
                      "~/ScriptsNg/Service/CrudService.js",
                      "~/ScriptsNg/Service/LoginService.js",
                      "~/ScriptsNg/Controllers/Stack.js",
                      "~/ScriptsNg/routes/ngRoutes.js"
                      ));
            bundles.Add(new ScriptBundle("~/bundles/scripts").Include(
                "~/Scripts/jquery.min.js",
                "~/Scripts/matrix.login.js"
                ));
            bundles.Add(new ScriptBundle("~/bundles/Ckeditor").Include(
                "~/Ckeditor/ckeditor.js",
                "~/Scripts/MarkdownDeepLib.min.js"

                ));
        }
    }
}
