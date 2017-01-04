using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppDevTest.Business;

namespace UnitTests
{
	[TestClass]
	public class NonRepeatingCharProviderTests
	{
		private NonRepeatingCharProvider provider;

		[TestInitialize]
		public void Init()
		{
			provider = new NonRepeatingCharProvider();
		}

		[TestMethod]
		public void sample_test()
		{
			Assert.AreEqual(3, provider.FindFirst("accba"));
		}
	}
}
