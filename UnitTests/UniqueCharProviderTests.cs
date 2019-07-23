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

		/*
		[TestMethod]
		public void sample_test()
		{
			Assert.AreEqual(<expected result>, provider.FindFirst(<input string>));
		}
		*/




	}
}
