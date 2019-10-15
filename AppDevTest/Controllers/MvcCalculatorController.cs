using AppDevTest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppDevTest.Controllers
{
	public class MvcCalculatorController : Controller
	{
        [HttpGet]
		public ActionResult Index()
		{
			return View();
		}

        [HttpPost]
        public ActionResult Index(MvcCalculatorModel model, string operation)
        {
            if (!(Double.TryParse(model.Value1, out double v1) && Double.TryParse(model.Value2, out double v2)))
            {
                model.Error = "ERROR: INVALID INPUT";
                ViewBag.Error = model.Error;
                return View(model);
            }

            double value1 = Double.Parse(model.Value1);
            double value2 = Double.Parse(model.Value2);

            switch (operation)
            {
                case "Plus":
                    model.Result = value1 + value2;
                    break;

                case "Multiply":
                    model.Result = value1 * value2;
                    break;

                case "Power":
                    model.Result = Math.Pow(value1, value2);
                    break;
            }

            ViewBag.Result = model.Result;

            return View(model);
        }
	}
}
