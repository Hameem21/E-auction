using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstAddessID
    {
        [TestMethod]
        public void ValidAddressID()
        {
            clsAddress AnAddress = new clsAddress();
            Int32 TestData = 1;
            AnAddress.AddressID = TestData;
            Assert.AreEqual(AnAddress.AddressID, TestData);
        }
    }
}
