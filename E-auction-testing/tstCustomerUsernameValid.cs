using System;
using E_auction_class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstCustomerUsernameValid
    {
        [TestMethod]
        public void UsernameValid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "User01";
            ACustomer.Username = TestData;
            Assert.AreEqual(ACustomer.Username, TestData);


        }
    }
}
