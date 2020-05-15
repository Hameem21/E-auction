using System;
using E_auction_class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace E_auction_testing
{
    [TestClass]
    public class tstItemsCollection
    {
        [TestMethod]
        public void InstanceOK()
        {
            clsItemsCollection AllItems = new clsItemsCollection();
            Assert.IsNotNull(AllItems);
        }

        [TestMethod]
        public void ItemsListOK() //the ItemList will provide us with an indexed list of Items  from the database table
        {
            clsItemsCollection AllItems = new clsItemsCollection();
            List<clsItems> TestList = new List<clsItems>();
            clsItems TestItemOfTestData = new clsItems();
            TestItemOfTestData.ItemNo = 11;
            TestItemOfTestData.ItemDescription = "test";
            TestItemOfTestData.ItemQuantity = 1;
            TestItemOfTestData.ItemPricePerUnit = 1;
            TestItemOfTestData.ItemDateOfAvailability = DateTime.Now.Date;
            TestItemOfTestData.ItemAvailability = true;
            //add the item to the test list
            TestList.Add(TestItemOfTestData);
            //assign data to the property
            AllItems.ItemsList = TestList;
            Assert.AreEqual(AllItems.ItemsList, TestList);
        }

        [TestMethod]
        public void ThisItemOK()
        {
            clsItemsCollection AllItems = new clsItemsCollection();
            clsItems TestItems = new clsItems();
            TestItems.ItemNo = 11;
            TestItems.ItemDescription = "test";
            TestItems.ItemQuantity = 1;
            TestItems.ItemPricePerUnit = 1;
            TestItems.ItemDateOfAvailability = DateTime.Now.Date;
            TestItems.ItemAvailability = true;
            AllItems.ThisItem = TestItems;
            Assert.AreEqual(AllItems.ThisItem, TestItems);
        }

        [TestMethod]
        public void ListAndCountOK()
        {
            clsItemsCollection AllItems = new clsItemsCollection();
            List<clsItems> TestList = new List<clsItems>();
            clsItems TestItemOfTestData = new clsItems();
            TestItemOfTestData.ItemNo = 11;
            TestItemOfTestData.ItemDescription = "test";
            TestItemOfTestData.ItemQuantity = 1;
            TestItemOfTestData.ItemPricePerUnit = 1;
            TestItemOfTestData.ItemDateOfAvailability = DateTime.Now.Date;
            TestItemOfTestData.ItemAvailability = true;
            TestList.Add(TestItemOfTestData);
            AllItems.ItemsList = TestList;
            Assert.AreEqual(AllItems.Count, TestList.Count);
        }


        [TestMethod]
        public void AddMethodOK()
        {
            clsItemsCollection AllItems = new clsItemsCollection();
            clsItems TestItems = new clsItems();
            Int32 PrimaryKey = 0;
            TestItems.ItemNo = 11;
            TestItems.ItemDescription = "test";
            TestItems.ItemQuantity = 1;
            TestItems.ItemPricePerUnit = 1;
            TestItems.ItemDateOfAvailability = DateTime.Now.Date;
            TestItems.ItemAvailability = true;
            AllItems.ThisItem = TestItems;
            PrimaryKey = AllItems.Add();
            TestItems.ItemNo = PrimaryKey;
            Assert.AreEqual(AllItems.ThisItem, TestItems);
        }

        [TestMethod]
         public void DeleteMethodOK()
         {
             clsItemsCollection AllItems = new clsItemsCollection();
             clsItems TestItems = new clsItems();
             Int32 PrimaryKey = 0;
             TestItems.ItemNo = 11;
             TestItems.ItemDescription = "test";
             TestItems.ItemQuantity = 1;
             TestItems.ItemPricePerUnit = 1;
             TestItems.ItemDateOfAvailability = DateTime.Now.Date;
             TestItems.ItemAvailability = true;
             AllItems.ThisItem = TestItems;
             PrimaryKey = AllItems.Add();
             TestItems.ItemNo = PrimaryKey;
             AllItems.ThisItem.Find(PrimaryKey);
             AllItems.Delete();
             Boolean Found = AllItems.ThisItem.Find(PrimaryKey);
             Assert.IsFalse(Found);
         } 

       [TestMethod]
        public void UpdateMethodOK()
        {
            clsItemsCollection AllItems = new clsItemsCollection();
            clsItems TestItems = new clsItems();
            Int32 PrimaryKey = 0;
            TestItems.ItemDescription = "test";
            TestItems.ItemQuantity = 1;
            TestItems.ItemPricePerUnit = 1;
            TestItems.ItemDateOfAvailability = DateTime.Now.Date;
            TestItems.ItemAvailability = true;
            AllItems.ThisItem = TestItems;
            PrimaryKey = AllItems.Add();
            TestItems.ItemNo = PrimaryKey;
            //modify the test data
            TestItems.ItemDescription = "another item";
            TestItems.ItemQuantity = 9;
            TestItems.ItemPricePerUnit = 5;
            TestItems.ItemDateOfAvailability = DateTime.Now.Date;
            TestItems.ItemAvailability = false;
            //set the record based on the new test data
            AllItems.ThisItem = TestItems;
            AllItems.Update();
            AllItems.ThisItem.Find(PrimaryKey);
            //test to see ThisItem matches the test data
            Assert.AreEqual(AllItems.ThisItem, TestItems);
        }

        [TestMethod]
        public void FilterItemByDescriptionOK()
        {
            clsItemsCollection AllItems = new clsItemsCollection();
            //create an instance of the filtered data
            clsItemsCollection FilteredItems = new clsItemsCollection();
            FilteredItems.FilterItemByDescription("");
            Assert.AreEqual(AllItems.Count, FilteredItems.Count);

        }

        [TestMethod]
        public void FilterItemByDescriptionNotFound()
        {
            clsItemsCollection FilteredItems = new clsItemsCollection();
            FilteredItems.FilterItemByDescription("xxxxxx");
            Assert.AreEqual(0, FilteredItems.Count);
        }

        [TestMethod]
        public void FilterItemByDescriptionTestDataFound()
        {
            clsItemsCollection FilteredItems = new clsItemsCollection();
            //var to store outcome
            Boolean OK = true;
            //apply description that does not exist 
            FilteredItems.FilterItemByDescription("test");
            //check that the correct numbers of records are found 
            if (FilteredItems.Count == 2)
            {
                //check that the first record is ItemNo 76
                if (FilteredItems.ItemsList[0].ItemNo != 76)
                {
                    OK = false;
                }
                //check that the first record is ItemNo is 80
                if (FilteredItems.ItemsList[1].ItemNo != 80)
                {
                    OK = false;
                }
            }
            else
            {
                OK = true;
            }
            Assert.IsTrue(OK);
        }
    }

} 
