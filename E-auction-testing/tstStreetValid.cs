using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstStreetValid
    {
        [TestMethod]
        public void ValidStreet()
        {
            clsAddress AnAddress = new clsAddress();
            string TestData = "London Rd";
            AnAddress.Street = TestData;
            Assert.AreEqual(AnAddress.Street, TestData);

        }
    }
}
