using System.Web;
using System.Web.Optimization;

namespace QuanLyNhanSu
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            var scriptbundle = new ScriptBundle("~/Script/bundle");
            var stylebundle = new StyleBundle("~/Content/bundle");

            scriptbundle
                // Bootstrap core JavaScript
                .Include("~/Assets/vendor/jquery/jquery.min.js")
                .Include("~/Assets/vendor/bootstrap/js/bootstrap.bundle.min.js")
                // Core plugin JavaScript
                .Include("~/Assets/vendor/jquery-easing/jquery.easing.min.js")
                // Custom scripts for all pages
                .Include("~/Assets/js/sb-admin-2.min.js")
                // Custom scripts for datatables
                .Include("~/Assets/js/demo/datatables-demo.js")
                .Include("~/Assets/vendor/datatables/jquery.dataTables.min.js")
                .Include("~/Assets/vendor/datatables/dataTables.bootstrap4.min.js");
            stylebundle
                // Custom fonts for this template
                .Include("~/Assets/vendor/fontawesome-free/css/all.min.css")
                .Include("~/Assets/vendor/fontawesome-free/css/font.css")
                // Custom styles for this template
                .Include("~/Assets/css/sb-admin-2.min.css")
                // Custom styles for datatables
                .Include("~/Assets/vendor/datatables/dataTables.bootstrap4.min.css");
            bundles.Add(scriptbundle);
            bundles.Add(stylebundle);

            // datatable
            bundles.Add(new ScriptBundle("~/bundles/datatable").Include(
                      "~/Scripts/dataTable/datatables.min.js"));
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
                      "~/Scripts/respond.js",
                      "~/Scripts/customjs/activedatatable.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                     "~/Content/bootstrap.css",
                     "~/Content/bootstrap.min.css",
                     "~/Content/bootstrap.css.map",
                     "~/Content/boostrap.min.css.map",
                     "~/Content/css/font-awesome.min.css",
                     "~/Content/css/account.css",
                     "~/Content/site.css",
                     "~/Content/css/index.css"));
            bundles.Add(new StyleBundle("~/Content/Admin/css").Include(
                        "~/Content/bootstrap.css",
                        "~/Content/bootstrap.min.css",
                        "~/Content/bootstrap.css.map",
                        "~/Content/boostrap.min.css.map",
                        "~/Content/datatables.min.css",
                        "~/Content/css/font-awesome.min.css",
                        "~/Content/sb-admin.css",
                        "~/Assets/vendor/fontawesome-free/css/all.min.css",
                        "~/Assets/vendor/fontawesome-free/css/font.css",
                        "~/Assets/css/sb-admin-2.min.css"));
            bundles.Add(new ScriptBundle("~/Scripts/Admin/js").Include(
                        "~/Assets/vendor/jquery/jquery.min.js",
                        "~/Assets/vendor/bootstrap/js/bootstrap.bundle.min.js",
                        "~/Assets/vendor/jquery-easing/jquery.easing.min.js",
                        "~/Assets/js/sb-admin-2.min.js",
                        "~/Assets/vendor/chart.js/Chart.min.js",
                        "~/Assets/js/demo/chart-area-demo.js",
                        "~/Assets/js/demo/chart-pie-demo.js"));

        }
    }
}
