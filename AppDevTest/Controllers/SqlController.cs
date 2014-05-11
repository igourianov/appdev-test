using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppDevTest.Controllers
{
	public class SqlController : Controller
	{
		public ActionResult Index()
		{
			return View();
		}

		public ActionResult AllEmployees()
		{
			// Answer provided as a sample
			return TableView(@"
SELECT EmployeeID AS ID, FirstName + ' ' + LastName AS Name
FROM Employees
ORDER BY FirstName + ' ' + LastName");
		}

		public ActionResult OrdersShippedToLondon()
		{
			return TableView("");
		}

		public ActionResult RecentOrders()
		{
			return TableView("");
		}

		public ActionResult SweetToothCustomers()
		{
			return TableView("");
		}

		#region ADO helpers

		private ActionResult TableView(string sql)
		{
			return View("Table", ExecuteQuery(sql));
		}

		private DataTable ExecuteQuery(string sql)
		{
			if (String.IsNullOrEmpty(sql))
				return null;

			using (var conn = new SqlConnection(ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString))
			using (var adapter = new SqlDataAdapter(sql, conn))
			{
				var data = new DataTable();
				adapter.Fill(data);
				return data;
			}
		}

		#endregion
	}
}
