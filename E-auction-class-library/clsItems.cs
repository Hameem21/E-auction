using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace E_auction_class_library
{
    public class clsItems
    {

        private Int32 mItemNo;
        public Int32 ItemNo { get { return mItemNo; } set { mItemNo = value; } }

        private string mItemDescription;
        public string ItemDescription { get { return mItemDescription; } set { mItemDescription = value; } }

        private Int32 mItemQuantity;
        public Int32 ItemQuantity { get { return mItemQuantity; } set { mItemQuantity = value; } }

        private decimal mItemPricePerUnit;
        public decimal ItemPricePerUnit { get { return mItemPricePerUnit; } set { mItemPricePerUnit = value; } }

        private DateTime mItemDateOfAvailability;
        public DateTime ItemDateOfAvailability { get { return mItemDateOfAvailability; } set { mItemDateOfAvailability = value; } }

        private bool mItemAvailability;
        public Boolean ItemAvailability { get { return mItemAvailability; } set { mItemAvailability = value; } }

        

        public bool Find(int ItemNo)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@ItemNo", ItemNo);
            DB.Execute("sproc_tblItems_FilterByItemNo");
            if (DB.Count == 1)
            {
                mItemNo = Convert.ToInt32(DB.DataTable.Rows[0]["ItemNo"]);
                mItemDescription = Convert.ToString(DB.DataTable.Rows[0]["ItemDescription"]);
                mItemQuantity = Convert.ToInt32(DB.DataTable.Rows[0]["ItemQuantity"]);
                mItemPricePerUnit = Convert.ToDecimal(DB.DataTable.Rows[0]["ItemPricePerUnit"]);
                mItemDateOfAvailability = Convert.ToDateTime(DB.DataTable.Rows[0]["ItemDateOfAvailability"]);
                mItemAvailability = Convert.ToBoolean(DB.DataTable.Rows[0]["ItemAvailability"]);
               
                return true;
            }

            else
            {
                return false;
            }
        }

        public string Valid(string ItemDescription, string ItemQuantity, string ItemPricePerUnit, string ItemDateOfAvailability)
        {
            String Error = "";

            if (ItemDescription.Length == 0)
            {

                Error = Error + "The Item Description may not be blank  ";
            }

            if (ItemDescription.Length > 50)
            {

                Error = Error + "The Item Description must be less than 50 characters  ";
            }
            if (ItemQuantity.Length == 0)
            {

                Error = Error + "The Item Quantity cannot be blank  ";
            }

            if (ItemQuantity.Length > 10000)
            {

                Error = Error + "The Item Quantity must be less than 10000  ";
            }
            if (ItemPricePerUnit.Length == 0)
            {

                Error = Error + "The Item PricePerUnit cannot be blank  ";
            }

            if (ItemQuantity.Length > 999999999999.99)
            {

                Error = Error + "The Item Quantity must be less than 999999999999.99  ";
            }

            try
            {

                if (Convert.ToDateTime(ItemDateOfAvailability) > DateTime.Now)
                {
                    Error = Error + "The Date Of Availability cannot be in the future";
                }

                
            }

            catch
            {
                Error = Error + "The date was provided in an invalid format please change this!";

            }

            return Error;
        }
    }
}




       




