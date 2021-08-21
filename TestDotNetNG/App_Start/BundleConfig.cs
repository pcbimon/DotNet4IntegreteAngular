using System.Web;
using System.Web.Optimization;

namespace TestDotNetNG
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js"));

            
            // Angular bundles
            bundles.Add(new Bundle("~/bundles/Angular")
              .Include(
                "~/Bundles/AngularOutput/polyfills.*",
                "~/Bundles/AngularOutput/runtime.*",
                "~/Bundles/AngularOutput/main.*"));

            bundles.Add(new StyleBundle("~/Content/Angular")
              .Include("~/Bundles/AngularOutput/styles.*"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
