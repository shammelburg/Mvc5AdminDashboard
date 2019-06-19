using System.Web;
using System.Web.Optimization;

namespace AdminTemplate.API
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.bundle.js",
                      "~/Scripts/jquery.easing.js",
                      "~/Scripts/sb-admin-2.js",
                      "~/Scripts/angular.js",
                      "~/Scripts/angular-drag-and-drop-lists.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/sb-admin-2.css",
                      "~/Content/site.css"));

            BundleTable.EnableOptimizations = true;

        }
    }
}
