using System;
using E_auction_class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstVerifiedAccount
    {
        [TestMethod]
        public void VerifiedAccount()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.VerifiedAccount = TestData;
            Assert.AreEqual(ACustomer.VerifiedAccount, TestData);
        }
    }
}
