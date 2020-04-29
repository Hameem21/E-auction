using System.Collections.Generic;

namespace E_auction_class_library
{
    public class clsItemsCollection
    {
        List<clsItems> mItemList = new List<clsItems>();
        clsItems mThisItem = new clsItems();
        

        public List<clsItems> ItemList { get { return mItemList; } set { mItemList = value; } }
        public int Count { get { return mItemList.Count; } set {; } }
        public clsItems ThisItem { get { return mThisItem; } set { mThisItem = value; } }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemDescription", mThisItem.ItemDescription);
            DB.AddParameter("@ItemQuantity", mThisItem.ItemQuantity);
            DB.AddParameter("@ItemPricePerUnit", mThisItem.ItemPricePerUnit);
            DB.AddParameter("@ItemDateOfAvailability", mThisItem.ItemDateOfAvailability);
            DB.AddParameter("@ItemAvailability", mThisItem.ItemAvailability);
            return DB.Execute("sproc_tblItems_Insert");
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemNo", mThisItem.ItemNo);
            DB.Execute("sproc_tblItems_Delete");
        }

        public int Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemDescription", mThisItem.ItemDescription);
            DB.AddParameter("@ItemQuantity", mThisItem.ItemQuantity);
            DB.AddParameter("@ItemPricePerUnit", mThisItem.ItemPricePerUnit);
            DB.AddParameter("@ItemDateOfAvailability", mThisItem.ItemDateOfAvailability);
            DB.AddParameter("@ItemAvailability", mThisItem.ItemAvailability);
            return DB.Execute("sproc_tblItems_Update");
        }

        public clsItemsCollection()
        {
            clsItems TestItemOfTestData = new clsItems();
            TestItemOfTestData.ItemNo = 11;
            TestItemOfTestData.ItemDescription = "test";
            TestItemOfTestData.ItemPricePerUnit = 1;
            TestItemOfTestData.ItemQuantity = 1;
            TestItemOfTestData.ItemDateOfAvailability = System.DateTime.Now.Date;
            TestItemOfTestData.ItemAvailability = true;
            mItemList.Add(TestItemOfTestData);
            TestItemOfTestData = new clsItems();
            TestItemOfTestData.ItemNo = 3;
            TestItemOfTestData.ItemDescription = "job";
            TestItemOfTestData.ItemPricePerUnit = 3;
            TestItemOfTestData.ItemQuantity = 3;
            TestItemOfTestData.ItemDateOfAvailability = System.DateTime.Now.Date;
            TestItemOfTestData.ItemAvailability = true;
            mItemList.Add(TestItemOfTestData);
        }
    }

} 