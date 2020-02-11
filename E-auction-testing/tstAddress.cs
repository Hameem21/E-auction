using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstAddress
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsAddress AnAddress = new clsAddress();
            Assert.IsNotNull(AnAddress);
        }
    }
}
