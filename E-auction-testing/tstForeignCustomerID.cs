using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstForeignCustomerID
    {
        [TestMethod]
        public void ValidForeignCustomerID()
        {
            clsAddress AnAddress = new clsAddress();
            Int32 TestData = 1;
            AnAddress.CustomerID = TestData;
            Assert.AreEqual(AnAddress.CustomerID, TestData);
        }
    }
}
