using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstCityValid
    {
        [TestMethod]
        public void ValidCity()
        {
            clsAddress AnAddress = new clsAddress();
            string TestData = "Nottingham";
            AnAddress.City = TestData;
            Assert.AreEqual(AnAddress.City, TestData);

        }
    }
}
