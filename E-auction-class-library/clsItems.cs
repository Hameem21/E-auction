using System;

namespace E_auction_class_library
{
    public class clsItems
    {
       
        private int mItemNo;
        public int ItemNo { get {return mItemNo;} set { mItemNo = value; } }

        private string mItemDescription;
        public string ItemDescription { get { return mItemDescription; } set { mItemDescription = value; } }

        private int mItemQuantity;
        public int ItemQuantity { get { return mItemQuantity; } set { mItemQuantity = value; } }

        private decimal mItemPricePerUnit;
        public decimal ItemPricePerUnit { get { return mItemPricePerUnit; } set { mItemPricePerUnit = value; } }

        private bool mItemAvailability;
        public Boolean ItemAvailability { get { return mItemAvailability; } set { mItemAvailability = value; } }
        
        private DateTime mItemDateofAvailability;
        public DateTime ItemDateofAvailability { get { return mItemDateofAvailability; } set { mItemDateofAvailability = value; } }

        public bool Find(int ItemNo)
        {

            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemNo", ItemNo);
            DB.Execute("sproc_tblItems_FilterByItemNo");
            if (DB.Count == 1)
            {
                mItemNo = Convert.ToInt32 (DB.DataTable.Rows[0]["ItemNo"]);
                mItemDescription = Convert.ToString(DB.DataTable.Rows[0]["ItemDescription"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mItemPricePerUnit = Convert.ToDecimal(DB.DataTable.Rows[0]["ItemPricePerUnit"]);
                mItemAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["ItemAvailability"]));
                mItemDateofAvailability = Convert.ToDateTime(DB.DataTable.Rows[0]["ItemDateOfAvailability"]);

                return true;
            }

            else
            {
                return false;
            }
        }
    }
}
