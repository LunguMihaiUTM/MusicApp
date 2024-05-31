using System.Web;
using System.Web.Optimization;

namespace MusicApp.Web
{
    public class BundleConfig
    {
        public static void RegisterBundles(BundleCollection bundles)
        {
            //Styles bundle
            bundles.Add(new StyleBundle("~/bundles/fonts/css").Include("~/Vendor/css/fonts.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/bootstrap/css").Include("~/Vendor/css/bootstrap.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/font-awesome/css").Include("~/Vendor/css/font-awesome.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/swiper/css").Include("~/Vendor/js/plugins/swiper/css/swiper.min.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/nice-select/css").Include("~/Vendor/js/plugins/nice_select/nice-select.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/volume/css").Include("~/Vendor/js/plugins/player/volume.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/mCustomScrollbar/css").Include("~/Vendor/js/plugins/scroll/jquery.mCustomScrollbar.css", new CssRewriteUrlTransform()));
            bundles.Add(new StyleBundle("~/bundles/style/css").Include("~/Vendor/css/style.css", new CssRewriteUrlTransform()));

            //Script bundle
            bundles.Add(new ScriptBundle("~/bundles/jquery/js").Include("~/Vendor/js/jquery.js"));
            bundles.Add(new ScriptBundle("~/bundles/bootstrap/js").Include("~/Vendor/js/bootstrap.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/swiper/js").Include("~/Vendor/js/plugins/swiper/js/swiper.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/playlist/js").Include("~/Vendor/js/plugins/player/jplayer.playlist.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/jplayer/js").Include("~/Vendor/js/plugins/player/jquery.jplayer.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/audio-player/js").Include("~/Vendor/js/plugins/player/audio-player.js"));
            bundles.Add(new ScriptBundle("~/bundles/volume/js").Include("~/Vendor/js/plugins/player/volume.js"));
            bundles.Add(new ScriptBundle("~/bundles/nice-select/js").Include("~/Vendor/js/plugins/nice_select/jquery.nice-select.min.js"));
            bundles.Add(new ScriptBundle("~/bundles/mCustomScrollbar/js").Include("~/Vendor/js/plugins/scroll/jquery.mCustomScrollbar.js"));
            bundles.Add(new ScriptBundle("~/bundles/custom/js").Include("~/Vendor/js/custom.js"));
            BundleTable.EnableOptimizations = true;
        }
    }
}
