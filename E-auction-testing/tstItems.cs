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

        [TestMethod]
        public void ItemNoOk()
        {
            clsItems AnItem = new clsItems();
            int TestData = 11;
            AnItem.ItemNo = TestData;
            Assert.AreEqual(AnItem.ItemNo, TestData);
        }

        [TestMethod]
        public void ItemDescriptionOK()
        {

            clsItems AnItem = new clsItems();
            String TestData = "wooden table";
            AnItem.ItemDescription = TestData;
            Assert.AreEqual(AnItem.ItemDescription, TestData);
        }

        [TestMethod]
        public void ItemQuantityOK()
        {
            clsItems AnItem = new clsItems();
            int TestData = 1;
            AnItem.ItemQuantity = TestData;
            Assert.AreEqual(AnItem.ItemQuantity, TestData);
        }

        [TestMethod]
        public void ItemPricePerUnitOK()
        {
            clsItems AnItem = new clsItems();
            Decimal TestData = Convert.ToDecimal("1");
            AnItem.ItemPricePerUnit = TestData;
            Assert.AreEqual(AnItem.ItemPricePerUnit, TestData);
        }

        [TestMethod]
        public void ItemAvailabilityOK()
        {
            clsItems AnItem = new clsItems();
            bool TestData = 1;
            AnItem.ItemAvailability = TestData;
            Assert.AreEqual(AnItem.ItemAvailability, TestData);
        }

        [TestMethod]

        public void ItemDateofAvailabilityOK()
        {
            clsItems AnItem = new clsItems();
            DateTime TestData = DateTime.Now.Date;
            AnItem.ItemDateofAvailability = TestData;
            Assert.AreEqual(AnItem.ItemDateofAvailability, TestData);
        }

        /////////////////FIND METHOD STARTS FROM HERE/////////////////////////////


        [TestMethod]
        public void FindMethodOk()
        {
            clsItems AnItem = new clsItems();
            Boolean Found = false;
            Int32 ItemNo = 11;
            Found = AnItem.Find(ItemNo);
            Assert.IsTrue(Found);
        }

        [TestMethod]
        public void TestItemNoFound()
        {
            clsItems AnItem = new clsItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 11;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemNo != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestItemDescriptionFound()
        {
            clsItems AnItem = new clsItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 11;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemDescription != Convert.ToString("test"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestItemQuantityFound()
        {
            clsItems AnItem = new clsItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 111;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemQuantity != 1)
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestItemPricePerUnitFound()
        {
            clsItems AnItem = new clsItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 11;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemPricePerUnit != Convert.ToDecimal("3.80"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestItemAvailabilityFound()
        {
            clsItems AnItem = new clsItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 11;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemAvailability != true))
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }

        public void TestItemDateofAvailabilityFound()
        {
            clsItems AnItem = new clsItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 1;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemDateofAvailability != Convert.ToDateTime("16/04/2020"))
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }
    }
}















