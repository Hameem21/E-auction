using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace E_auction_class_library
{
    public class clsItemsCollection
    {
        List<clsItems> mItemsList = new List<clsItems>();
        clsItems mThisItem = new clsItems();


        public List<clsItems> ItemsList { get { return mItemsList; } set { mItemsList = value; } }
        public int Count { get { return mItemsList.Count; } set {; } }
        public clsItems ThisItem { get { return mThisItem; } set { mThisItem = value; } }

        public clsItemsCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblItems_SelectAll");
            PopulateArray(DB);

        }

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
            DB.AddParameter("@ItemNo", mThisItem.ItemNo);
            DB.AddParameter("@ItemDescription", mThisItem.ItemDescription);
            DB.AddParameter("@ItemQuantity", mThisItem.ItemQuantity);
            DB.AddParameter("@ItemPricePerUnit", mThisItem.ItemPricePerUnit);
            DB.AddParameter("@ItemDateOfAvailability", mThisItem.ItemDateOfAvailability);
            DB.AddParameter("@ItemAvailability", mThisItem.ItemAvailability);
            return DB.Execute("sproc_tblItems_Update");
        }

        public void FilterItemByDescription(string ItemDescription)
        {
            //filters the records based on a full or partial item description
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemDescription", ItemDescription);
            DB.Execute("sproc_tblItems_FilterItemByDescription");
            PopulateArray(DB);

        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 RecordCount;
            RecordCount = DB.Count;
            mItemsList = new List<clsItems>();
            while (Index < RecordCount)
            {
                clsItems AnItem = new clsItems();
                AnItem.ItemNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemNo"]);
                AnItem.ItemDescription = Convert.ToString(DB.DataTable.Rows[Index]["ItemDescription"]);
                AnItem.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);
                AnItem.ItemPricePerUnit = Convert.ToDecimal(DB.DataTable.Rows[Index]["ItemPricePerUnit"]);
                AnItem.ItemDateOfAvailability = Convert.ToDateTime(DB.DataTable.Rows[Index]["ItemDateOfAvailability"]);
                AnItem.ItemAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["ItemAvailability"]);

                mItemsList.Add(AnItem);
                Index++;
            }
        }
    }   


}















/*clsItems TestItemOfTestData = new clsItems();
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
     mItemList.Add(TestItemOfTestData);*/ // this was old code for itemscollection


/*
  mItemList = new List<clsItems>();
        this.ThisItem = new clsItems();

        Int32 Index = 0;
        Int32 RecordCount = 0;
        clsDataConnection DB = new clsDataConnection();
        DB.Execute("sproc_tblItems_SelectAll");
        RecordCount = DB.Count;
        while (Index < RecordCount)
        {
            clsItems AnItem = new clsItems();
            AnItem.ItemNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemNo"]);
            AnItem.ItemDescription = Convert.ToString(DB.DataTable.Rows[Index]["ItemDescription"]);
            AnItem.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);
            AnItem.ItemPricePerUnit = Convert.ToDecimal(DB.DataTable.Rows[Index]["ItemPricePerUnit"]);
            AnItem.ItemDateOfAvailability = Convert.ToDateTime(DB.DataTable.Rows[Index]["ItemDateOfAvailability"]);
            AnItem.ItemAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["ItemAvailability"]);

            mItemList.Add(AnItem);
            Index++;  */


    //oublic clsItemsCollection code before new change 
/*mItemList = new List<clsItems>();
            this.ThisItem = new clsItems();

            Int32 Index = 0;
            Int32 RecordCount = 0;
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_tblItems_SelectAll");
RecordCount = DB.Count;
            while (Index < RecordCount)
            {
    clsItems AnItem = new clsItems();
    AnItem.ItemNo = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemNo"]);
    AnItem.ItemDescription = Convert.ToString(DB.DataTable.Rows[Index]["ItemDescription"]);
    AnItem.ItemQuantity = Convert.ToInt32(DB.DataTable.Rows[Index]["ItemQuantity"]);
    AnItem.ItemPricePerUnit = Convert.ToDecimal(DB.DataTable.Rows[Index]["ItemPricePerUnit"]);
    AnItem.ItemDateOfAvailability = Convert.ToDateTime(DB.DataTable.Rows[Index]["ItemDateOfAvailability"]);
    AnItem.ItemAvailability = Convert.ToBoolean(DB.DataTable.Rows[Index]["ItemAvailability"]);

    mItemList.Add(AnItem);
    Index++;
}*/