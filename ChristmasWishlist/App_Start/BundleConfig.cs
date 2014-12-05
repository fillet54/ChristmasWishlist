using System.Web;
using System.Web.Optimization;

namespace ChristmasWishlist
{
    public class BundleConfig
    {
        // For more information on bundling, visit http://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(
                new ScriptBundle("~/bundles/scripts")
                   .Include("~/Content/js/jquery.min.js",
                            "~/Content/js/skel.min.js",
                            "~/Content/js/init.js"));

            bundles.Add(
                new StyleBundle("~/Content/css")
                   .Include("~/Content/css/skel.css", new CssRewriteUrlTransform())
                   .Include("~/Content/css/style.css", new CssRewriteUrlTransform())
                   .Include("~/Content/css/style-wide", new CssRewriteUrlTransform())
                   .Include("~/Content/css/font-awesome.min.css", new CssRewriteUrlTransform()));
        }
    }
}
