using System;
using E_auction_class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstItems
    {

        string ItemNo = "11";
        string ItemDescription = "test";
        string ItemQuantity = "1";
        string ItemPricePerUnit = "1";
        string ItemDateOfAvailability = "01/01/2020";
        string ItemAvailability = "True";

        [TestMethod]
        public void InstanceOK()
        {
            clsItems AnItem = new clsItems();
            Assert.IsNotNull(AnItem);
        }

        [TestMethod]
        public void ItemNoOK()
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
            String TestData = "test";
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

        public void ItemDateOfAvailabilityOK()
        {
            clsItems AnItem = new clsItems();
            DateTime TestData = DateTime.Now.Date;
            AnItem.ItemDateOfAvailability = TestData;
            Assert.AreEqual(AnItem.ItemDateOfAvailability, TestData);
        }

        [TestMethod]
        public void ItemAvailabilityOK()
        {
            clsItems AnItem = new clsItems();
            bool TestData = true;
            AnItem.ItemAvailability = TestData;
            Assert.AreEqual(AnItem.ItemAvailability, TestData);
        }

        /////////////////FIND METHOD STARTS FROM HERE/////////////////////////////


        [TestMethod]
        public void FindMethodOK()
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
            if (AnItem.ItemNo != 11)
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
            Int32 ItemNo = 11;
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
            if (AnItem.ItemPricePerUnit != Convert.ToDecimal("1"))
            {
                OK = false;
            }
            Assert.IsTrue(OK);
        }

        public void TestItemDateOfAvailabilityFound()
        {
            clsItems AnItem = new clsItems();
            Boolean Found = false;
            Boolean OK = true;
            Int32 ItemNo = 11;
            Found = AnItem.Find(ItemNo);
            if (AnItem.ItemDateOfAvailability != Convert.ToDateTime("01/01/2020"))
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
            if (AnItem.ItemAvailability != true)
            {
                OK = false;

            }
            Assert.IsTrue(OK);
        }


        /// /////VALID METHOD////////

        [TestMethod]
        public void ValidMethodOK()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNoNotNull()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemNo = "";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemNoMin()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemNo = "1";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNoMinPlusOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemNo = "12";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNoMaxLessOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemNo = "12345";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNoMax()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemNo = "123456";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }
        [TestMethod]
        public void ItemNoMid()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemNo = "123";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemNoMaxPlusOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            ItemNo = ItemNo.PadRight(7, '1');
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionNotNull()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemDescription = "";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMin()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemDescription = "a";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMinPlusOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemDescription = "ab";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMid()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadRight(25, 'a');
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMaxValue()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadRight(50, 'a');
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMaxLessOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadRight(49, 'a');
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDescriptionMaxPlusOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemDescription = "";
            ItemDescription = ItemDescription.PadRight(51, 'a');
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityNotNull()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemQuantity = "";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMin()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemQuantity = "1";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMinPlusOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemQuantity = "12";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMaxLessOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemQuantity = "";
            ItemQuantity = ItemQuantity.PadRight(9999, '1');
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemQuantityMax()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemQuantity = "";
            ItemQuantity = ItemQuantity.PadRight(10000, '1');
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }


        [TestMethod]
        public void ItemQuantityMaxPlusOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemQuantity = "";
            ItemQuantity = ItemQuantity.PadRight(10001, '1'); //this will fail
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPricePerUnitNotNull()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemPricePerUnit = "";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemPricePerUnitMin()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemPricePerUnit = "0.001";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPricePerUnitMinPlusOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemPricePerUnit = "0.010";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPricePerUnitMax()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemPricePerUnit = "999999999999.99";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemPricePerUnitCannotBeLetters()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemPricePerUnit = "fifteen pounds";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod] //not really sure about how to do this
        public void ItemDateOfAvailabilityPast()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemDateOfAvailability = "";
            ItemDateOfAvailability = "02/02/19";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateOfAvailabilityFuture()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemDateOfAvailability = "";
            ItemDateOfAvailability = "01/01/21";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreNotEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateOfAvailabilityInvalidFormat()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            string ItemNo = "11";
            string ItemDescription = "chairs";
            string ItemQuantity = "2";
            string ItemPricePerUnit = "2.30";
            string ItemDateOfAvailability = "this is just words!";
            ItemDateOfAvailability = "2nd February 2020";
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreNotEqual(Error, "");
        }

        /*[TestMethod]
        public void ItemDateOfAvailabilityMin()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            string ItemDateOfAvailability = TestDate.ToString();
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateOfAvailabilityMinLessOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-1);
            string ItemDateOfAvailability = TestDate.ToString();
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateOfAvailabilityExtremeMin()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(-100);
            string ItemDateOfAvailability = TestDate.ToString();
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateOfAvailabilityMinPlusOne()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddDays(1);
            string ItemDateOfAvailability = TestDate.ToString();
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }

        [TestMethod]
        public void ItemDateOfAvailabilityExtreme()
        {
            clsItems AnItem = new clsItems();
            String Error = "";
            DateTime TestDate;
            TestDate = DateTime.Now.Date;
            TestDate = TestDate.AddYears(100);
            string ItemDateOfAvailability = TestDate.ToString();
            Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
            Assert.AreEqual(Error, "");
        }*/
    }
}














