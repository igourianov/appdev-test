using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppDevTest.Business;

namespace UnitTests
{
	[TestClass]
	public class BasinCalculatorTests
	{
		private BasinCalculator calc;

		[TestInitialize]
		public void Init()
		{
			calc = new BasinCalculator();
		}

		[TestMethod]
		public void sample_test()
		{
			Assert.AreEqual(20, calc.GetVolume(new int[] { 3, 5, 8, 7, 2, 6, 11, 3, 4, 9, 5, 1 }));
		}
	}
}
