using System.Web;
using System.Web.Optimization;

namespace PhotoGalleryMVC.App_Start
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                "~/Scripts/jquery-{version}.js",
                "~/Scripts/jquery.validate.js",
                "~/Scripts/jquery.isotope.min.js",
                "~/Scripts/photoGalleryMVC.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(                     
                      "~/Content/Styles/animated-masonry-gallery.css",
                      "~/Content/Styles/Site.css"));
        }
    }
}