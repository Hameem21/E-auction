using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstPostcodeValid
    {
        [TestMethod]
        public void ValidPostCode()
        {
            clsAddress AnAddress = new clsAddress();
            string TestData = "NG1 1EX";
            AnAddress.Postcode = TestData;
            Assert.AreEqual(AnAddress.Postcode, TestData);
        }
    }
}
