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
        public void ItemListOK()
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
            AllItems.ItemList = TestList;
            Assert.AreEqual(AllItems.ItemList, TestList);
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
            AllItems.ItemList = TestList;
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

        }
    }

} 
