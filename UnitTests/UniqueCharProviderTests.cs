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
		public void sample_test()
		{
			Assert.AreEqual(4, provider.FindFirst("abbacbda"));
		}

        [TestMethod]
        public void no_unique()
        {
            Assert.AreEqual(-1, provider.FindFirst("aaaaa"));
        }

        [TestMethod]
        public void unique_not_until_end()
        {
            Assert.AreEqual(3, provider.FindFirst("aaab"));
        }




    }
}
