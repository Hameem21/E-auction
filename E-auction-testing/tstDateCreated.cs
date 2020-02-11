using System;
using E_auction_class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstDateCreated
    {
        [TestMethod]
        public void DateCreatedValid()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateCreated = TestData;
            Assert.AreEqual(ACustomer.DateCreated, TestData);



        }
    }
}
