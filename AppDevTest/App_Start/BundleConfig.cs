using System.Web;
using System.Web.Optimization;

namespace AppDevTest
{
	public class BundleConfig
	{
		public static void RegisterBundles(BundleCollection bundles)
		{
			BundleTable.EnableOptimizations = true;
			bundles.Add(new StyleBundle("~/static/css").Include("~/Content/*.css"));
			bundles.Add(new ScriptBundle("~/static/jquery").Include("~/Scripts/jquery-{version}.js"));
			bundles.Add(new ScriptBundle("~/static/modernizr").Include("~/Scripts/modernizr-*"));
		}
	}
}
