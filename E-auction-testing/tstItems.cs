using System;
using E_auction_class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstItems
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsItems AnItem = new clsItems();
            Assert.IsNotNull(AnItem);
        }
    }
}
