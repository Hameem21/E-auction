using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstHouseNumValid
    {
        [TestMethod]
        public void ValidHouseNum()
        {
            clsAddress AnAddress = new clsAddress();
            Int16 TestData = 1;
            AnAddress.HouseNum = TestData;
            Assert.AreEqual(AnAddress.HouseNum, TestData);
        }
    }
}
