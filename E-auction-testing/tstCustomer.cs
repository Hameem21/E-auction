using System;
using E_auction_class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK(){
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        
        }

        [TestMethod]
        public void VerifiedAccount()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean TestData = true;
            ACustomer.VerifiedAccount = TestData;
            Assert.AreEqual(ACustomer.VerifiedAccount, TestData);
        }

        [TestMethod]
        public void ValidPostCode()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "NG1 1EX";
            ACustomer.Postcode = TestData;
            Assert.AreEqual(ACustomer.Postcode, TestData);
        }

        [TestMethod]
        public void DateCreatedValid()
        {
            clsCustomer ACustomer = new clsCustomer();
            DateTime TestData = DateTime.Now.Date;
            ACustomer.DateCreated = TestData;
            Assert.AreEqual(ACustomer.DateCreated, TestData);
        }


        [TestMethod]
        public void UsernameValid()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "User01";
            ACustomer.Username = TestData;
            Assert.AreEqual(ACustomer.Username, TestData);
        }

        [TestMethod]
        public void ValidCustomerEmail()
        {
            clsCustomer ACustomer = new clsCustomer();
            string TestData = "testing.email@tester.com";
            ACustomer.EmailAddress = TestData;
            Assert.AreEqual(ACustomer.EmailAddress, TestData);
        }

        [TestMethod]
        public void ValidCustomerID()
        {
            clsCustomer ACustomer = new clsCustomer();
            Int32 TestData = 1;
            ACustomer.CustomerID = TestData;
            Assert.AreEqual(ACustomer.CustomerID, TestData);
        }
        [TestMethod]
        public void FindMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            string Username = "test";
            Found = ACustomer.Find(Username);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        
        public void TestCustomerUsernameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            string Username = "test";
            Found = ACustomer.Find(Username);
            if (ACustomer.Username != "test")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerEmailFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            string Username = "test";
            Found = ACustomer.Find(Username);
            if (ACustomer.EmailAddress != "test@testing.com")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerPostcodeFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            string Username = "test";
            Found = ACustomer.Find(Username);
            if (ACustomer.Postcode != "LE1 2XW")
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerVerifiedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            string Username = "test";
            Found = ACustomer.Find(Username);
            if (ACustomer.VerifiedAccount != true)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void TestCustomerIDFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            string Username = "test";
            Found = ACustomer.Find(Username);
            if (ACustomer.CustomerID != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }
        [TestMethod]

        public void TestCustomerDateCreatedFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            string Username = "test";
            Found = ACustomer.Find(Username);
            if (ACustomer.DateCreated!= Convert.ToDateTime("16/01/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }



    }
}
