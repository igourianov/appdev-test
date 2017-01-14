using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AppDevTest.Business;

namespace UnitTests
{
	[TestClass]
	public class UniqueCharProviderTests
	{
		private UniqueCharProvider provider;

		[TestInitialize]
		public void Init()
		{
			provider = new UniqueCharProvider();
		}

		[TestMethod]
		public void sample_string()
		{
			Assert.AreEqual(4, provider.FindFirst("abbacbda"));
		}
	}
}
