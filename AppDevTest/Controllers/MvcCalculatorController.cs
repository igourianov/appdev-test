using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AppDevTest.Models;

namespace AppDevTest.Controllers
{
	public class MvcCalculatorController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

        [HttpPost]
        public ActionResult Index(MvcCalculatorModel model) {
            if (ModelState.IsValid) {
                // Make sure inputs are valid
                if (!int.TryParse(model.Value1, out int n1) || !int.TryParse(model.Value2, out int n2)) {
                    ViewBag.err = "Values must be numbers";
                    return View();
                }
                double res;
                double v1 = Convert.ToDouble(model.Value1);
                double v2 = Convert.ToDouble(model.Value2);
                switch (model.Operation) {
                    case "Plus":
                        res =  v1 + v2;
                        break;
                    case "Multiply":
                        res = v1 * v2;
                        break;
                    case "Power":
                        res = Math.Pow(v1, v2);
                        break;
                    default:
                        ViewBag.err = "Operation not supported";
                        return View();
                }
                ViewBag.res = res;
            }
            return View();
        }
	}
}
