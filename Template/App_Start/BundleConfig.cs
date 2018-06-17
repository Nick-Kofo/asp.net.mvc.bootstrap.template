using System.Web;
using System.Web.Optimization;

namespace Template
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.min.js"));

            bundles.Add(new ScriptBundle("~/bundles/plugins").Include(
                      "~/Scripts/respond.min.js",
                      "~/Scripts/datatables.min.js",
                      "~/Scripts/dataTables.buttons.min.js",
                      "~/Scripts/buttons.print.min.js",
                      "~/Scripts/buttons.html5.min.js",
                      "~/Scripts/buttons.flash.min.js",
                      "~/Scripts/buttons.bootstrap.min.js",
                      "~/Scripts/jszip.min.js",
                      "~/Scripts/pdfmake.min.js",
                      "~/Scripts/vfs_fonts.js",
                      "~/Scripts/adminlte.js"));

            bundles.Add(new ScriptBundle("~/bundles/app").Include(
                      "~/Scripts/app.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.min.css",
                      "~/Content/bootstrap.min.css.map",
                      "~/Content/font-awesome.min.css",
                      "~/Content/datatables.min.css",
                      "~/Content/buttons.dataTables.min.css",
                      "~/Content/skin-yellow-light.css",
                      "~/Content/adminlte.css",
                      "~/Content/app.css"));
        }
    }
}
