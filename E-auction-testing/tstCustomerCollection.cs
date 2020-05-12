using E_auction_class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_auction_testing
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            Assert.IsNotNull(AllCustomers);
        }

        [TestMethod]
        public void CustomerListOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.VerifiedAccount = true;
            TestItem.Username = "test";
            TestItem.EmailAddress = "testedItem@testing.com";
            TestItem.Postcode = "ng4 1an";
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.CustomerID = 414;
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.CustomerList, TestList);
        }

       

        [TestMethod]
        public void ThisCustomerPropertyOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomer TestCustomer = new clsCustomer();
            TestCustomer.CustomerID = 519;
            TestCustomer.DateCreated = DateTime.Now.Date;
            TestCustomer.EmailAddress = "unqiquetestingemail@email.com";
            TestCustomer.Postcode = "te1 1me";
            TestCustomer.Username = "user_001";
            TestCustomer.VerifiedAccount = true;
            AllCustomers.ThisCustomer = TestCustomer;
            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);
        }

        [TestMethod]
        public void ListAndCountOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.VerifiedAccount = true;
            TestItem.CustomerID = 1111;
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.EmailAddress = "unqiquetestingemail@email.com";
            TestItem.Postcode = "te1 1me";
            TestItem.Username = "user_001";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;
            Assert.AreEqual(AllCustomers.Count, TestList.Count);

        }

        [TestMethod]
        public void AddMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.VerifiedAccount = true;
            TestItem.CustomerID = 123;
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.EmailAddress = "atestingemail@email.com";
            TestItem.Postcode = "tr1 3es";
            TestItem.Username = "user_0011";
            AllCustomers.ThisCustomer = TestItem;
            Int32 PrimaryKey = AllCustomers.Add();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

        }

        [TestMethod]
        public void DeleteMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.VerifiedAccount = true;
            TestItem.CustomerID = 123;
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.EmailAddress = "atestingemail@email.com";
            TestItem.Postcode = "tr1 3es";
            TestItem.Username = "user_0011";
            AllCustomers.ThisCustomer = TestItem;
            Int32 PrimaryKey = AllCustomers.Add();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            AllCustomers.Delete();
            Boolean Found = AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.IsFalse(Found);

        }


        [TestMethod]
        public void UpdateMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();
            clsCustomer TestItem = new clsCustomer();
            TestItem.VerifiedAccount = true;
            TestItem.CustomerID = 123;
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.EmailAddress = "atestingemail@email.com";
            TestItem.Postcode = "tr1 3es";
            TestItem.Username = "user_0011";
            AllCustomers.ThisCustomer = TestItem;
            Int32 PrimaryKey = AllCustomers.Add();
            TestItem.CustomerID = PrimaryKey;
            TestItem.VerifiedAccount = false;
            TestItem.DateCreated = DateTime.Now.Date;
            TestItem.EmailAddress = "uremail@servers.com";
            TestItem.Postcode = "Pl3 4se";
            TestItem.Username = "xXUserXx";
            AllCustomers.ThisCustomer = TestItem;
            AllCustomers.Update();
            AllCustomers.ThisCustomer.Find(PrimaryKey);
            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }

        [TestMethod]
        public void ReportByUsernameMethodOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredUsernames = new clsCustomerCollection();
            FilteredUsernames.ReportByUsername("");
            Assert.AreEqual(AllCustomers.Count, FilteredUsernames.Count);


        }

        [TestMethod]
        public void ReportByUsernameNoneFound()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            clsCustomerCollection FilteredUsernames = new clsCustomerCollection();
            FilteredUsernames.ReportByUsername("__");
            Assert.AreEqual(0, FilteredUsernames.Count);


        }

        [TestMethod]
        public void ReportByUsernameTestDataFound()
        {
            clsCustomerCollection FilteredUsernames = new clsCustomerCollection();
            Boolean OK = true;
            FilteredUsernames.ReportByUsername("UsernameFilter");
            if (FilteredUsernames.Count == 2)
            {
                if (FilteredUsernames.CustomerList[0].CustomerID != 13) { 
                
                    OK = false;
                }
                if (FilteredUsernames.CustomerList[1].CustomerID != 14)
                {
                    OK = false;
                }
            }
            else {
                OK = false;

            }
            Assert.IsTrue(OK);
            }


        }

    }

    

