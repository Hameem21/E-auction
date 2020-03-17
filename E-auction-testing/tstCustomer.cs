using System;
using E_auction_class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstCustomer
    {
        string Username = "test";
        string EmailAddress = "test@tester.com";
        string DateAdded = "12/01/2020";
        string Postcode = "LE1 1AS";

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
            Int32 CustomerID = 11;
            Found = ACustomer.Find(CustomerID);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        
        public void TestCustomerUsernameFound()
        {
            clsCustomer ACustomer = new clsCustomer();
            Boolean Found = false;
            Boolean OK = true;
            Int32 CustomerID = 11;
            Found = ACustomer.Find(CustomerID);
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
            Int32 CustomerID = 11;
            Found = ACustomer.Find(CustomerID);
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
            Int32 CustomerID = 11;
            Found = ACustomer.Find(CustomerID);
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
            Int32 CustomerID = 11;
            Found = ACustomer.Find(CustomerID);
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
            Int32 CustomerID = 11;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.CustomerID != 11)
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
            Int32 CustomerID = 11;
            Found = ACustomer.Find(CustomerID);
            if (ACustomer.DateCreated!= Convert.ToDateTime("16/01/2020"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        [TestMethod]

        public void ValidMethodOK()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            Error = ACustomer.Valid(Username, EmailAddress, DateAdded, Postcode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void UsernameNotNull()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string username = "";
            Error = ACustomer.Valid(username, EmailAddress, DateAdded, Postcode);
            Assert.AreNotEqual(Error, "");
        }
        [TestMethod]
        public void UsernameLessthan16chars()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string username = "thisisatestingstringover16chars";
            Error = ACustomer.Valid(username, EmailAddress, DateAdded, Postcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void Emailcontainsat()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string emailAddress = "testtester.com";
            Error = ACustomer.Valid(Username, emailAddress, DateAdded, Postcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void EmailNotNull()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string emailAddress = "test@tester.com";
            Error = ACustomer.Valid(Username, emailAddress, DateAdded, Postcode);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void EmailNotOver70()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string emailAddress = ""; 
            emailAddress = emailAddress.PadRight(70, 'a');
            Error = ACustomer.Valid(Username, emailAddress, DateAdded, Postcode);
            Assert.AreNotEqual(Error, "");
        }


        [TestMethod]
        public void dateAddedBeforeLive()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string dateAdded = "";
            dateAdded = "01/01/2019";
            Error = ACustomer.Valid(Username, EmailAddress, dateAdded, Postcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dateAddedInFuture()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string dateAdded = "";
            dateAdded = "01/01/2021";
            Error = ACustomer.Valid(Username, EmailAddress, dateAdded, Postcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void dateAddedInvalidFormat()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string dateAdded = "";
            dateAdded = "hello";
            Error = ACustomer.Valid(Username, EmailAddress, dateAdded, Postcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void postcodeTooShort()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string postcode = "";
            postcode = "LE 3X";
            Error = ACustomer.Valid(Username, EmailAddress, DateAdded, postcode);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void postcodeTooLong()
        {
            clsCustomer ACustomer = new clsCustomer();
            String Error = "";
            string postcode = "";
            postcode = "LE 3X";
            Error = ACustomer.Valid(Username, EmailAddress, DateAdded, postcode);
            Assert.AreNotEqual(Error, "");
        }
    }
}
