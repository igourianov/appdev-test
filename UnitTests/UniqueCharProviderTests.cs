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
            string inputstring = "ababbcded";
            int expected = 5;
            Assert.AreEqual(expected, provider.FindFirst(inputstring));
		}

        [TestMethod]
        public void No_Unique()
        {
            string inputstring = "aabbccddee";
            int expected = -1;
            Assert.AreEqual(expected, provider.FindFirst(inputstring));
        }

        [TestMethod]
        public void Empty_String()
        {
            string inputstring = "";
            int expected = -1;
            Assert.AreEqual(expected, provider.FindFirst(inputstring));
        }

        [TestMethod]
        public void Null_Input()
        {
            string inputstring = null;
            int expected = -1;
            Assert.AreEqual(expected, provider.FindFirst(inputstring));
        }

        [TestMethod]
        public void All_Unique()
        {
            string inputstring = "abcdefg";
            int expected = 0;
            Assert.AreEqual(expected, provider.FindFirst(inputstring));
        }

        [TestMethod]
        public void Last_Is_Unique()
        {
            string inputstring = "abbabaccddadcf";
            int expected = 13;
            Assert.AreEqual(expected, provider.FindFirst(inputstring));
        }
    }
}
