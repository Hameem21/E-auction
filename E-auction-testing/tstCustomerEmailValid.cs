using System;
using E_auction_class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstCustomerEmailValid
    {
        [TestMethod]
        public void ValidCustomerEmail()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "testing.email@tester.com";
            ACustomer.EmailAddress = TestData;
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }
    }
}
