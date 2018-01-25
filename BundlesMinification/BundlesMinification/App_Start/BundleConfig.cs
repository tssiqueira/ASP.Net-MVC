using System.Web;
using System.Web.Optimization;

namespace BundlesMinification
{
    public class BundleConfig
    {
        // For more information on bundling, visit https://go.microsoft.com/fwlink/?LinkId=301862
        public static void RegisterBundles(BundleCollection bundles)
        {
            BundleTable.EnableOptimizations = true; // usado para habilitar o bundle; se o bundle for 'false' ele vai carregar todos os arquivos .css e .js, mesmos os redundantes para a pagina alvo. Isso consome mais memoria

            //Ignora um arquivo JS
            //bundles.IgnoreList.Ignore("*.dbj.js");

            ////adiciona um arquivo JS 
            //bundles.Add(new ScriptBundle("~/comum")
            //    .IncludeDirectory("~/Scripts/comum","*.js",true));

            //var ordem = new BundleFileSetOrdering("meunome");
            //ordem.Files.Add("setup.js");
            //ordem.Files.Add("display.js");
            //bundles.FileSetOrderList.Insert(0, ordem);

            // para incluir os arquivos 
            bundles.Add(new ScriptBundle("~/bundles/comm")
                .include("~/Scripts/comum/*.js"));





            bundles.Add(new ScriptBundle("~/bundles/jquery").Include(
                        "~/Scripts/jquery-{version}.js"));

            bundles.Add(new ScriptBundle("~/bundles/jqueryval").Include(
                        "~/Scripts/jquery.validate*"));

            // Use the development version of Modernizr to develop with and learn from. Then, when you're
            // ready for production, use the build tool at https://modernizr.com to pick only the tests you need.
            bundles.Add(new ScriptBundle("~/bundles/modernizr").Include(
                        "~/Scripts/modernizr-*"));

            bundles.Add(new ScriptBundle("~/bundles/bootstrap").Include(
                      "~/Scripts/bootstrap.js",
                      "~/Scripts/respond.js"));

            bundles.Add(new StyleBundle("~/Content/css").Include(
                      "~/Content/bootstrap.css",
                      "~/Content/site.css"));
        }
    }
}
