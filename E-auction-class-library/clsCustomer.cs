using System;

namespace E_auction_class_library
{
    public class clsCustomer
    {
        private bool mVerifiedAccount;
        public bool VerifiedAccount {
            get
            {
                return mVerifiedAccount;
            }
            set
            {
                mVerifiedAccount = value;
            }
                }
        private DateTime mDateCreated;
        public DateTime DateCreated
        {
            get
            {
                return mDateCreated;
            }
            set
            {
                mDateCreated = value;
            }
        }


        private string mEmailAddress;
        public string EmailAddress
        {
            get
            {
                return mEmailAddress;
            }
            set
            {
                mEmailAddress = value;
            }
        }
        private string mUsername;
        public string Username
        {
            get
            {
                return mUsername;
            }
            set
            {
                mUsername = value;
            }
        }
        private string mPostcode;
        public string Postcode
        {
            get
            {
                return mPostcode;
            }
            set
            {
                mPostcode = value;
            }
        }
        private int mCustomerID;
        public int CustomerID {
            get
            {
                return mCustomerID;
            }     
            set
            {
                mCustomerID = value;
            }
                }

        public bool Find(Int32 CustomerID)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", CustomerID);
            DB.Execute("sproc_TblCustomer_FilterByCustomerID");
            if(DB.Count == 1)
            {
                mEmailAddress = Convert.ToString(DB.DataTable.Rows[0]["CustomerEmail"]);
                mCustomerID = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerID"]);
                mDateCreated = Convert.ToDateTime(DB.DataTable.Rows[0]["DateCreated"]);
                mVerifiedAccount = Convert.ToBoolean(DB.DataTable.Rows[0]["VerifiedAccount"]);
                mUsername = Convert.ToString(DB.DataTable.Rows[0]["CustomerUsername"]);
                mPostcode = Convert.ToString(DB.DataTable.Rows[0]["Postcode"]);
                return true;
            }
            else
            {
                return false;
            }

            
        }

        public string Valid(string username, string emailAddress, string dateAdded, string postcode)
        {
            String Error = "";
            if (username.Length < 1 || username.Length > 16)
            {
                Error = Error + "Username cannot be blank or over 16 characters! ";
            }

            if (!emailAddress.Contains("@")||emailAddress.Length<7||emailAddress.Length>70)
            {
                Error = Error + "Email is not valid";
            }
            try {
            if(Convert.ToDateTime(dateAdded)< Convert.ToDateTime("01/01/2020")|| Convert.ToDateTime(dateAdded)> DateTime.Now)
            {
                Error = Error + "Date added cannot be before the creation of the website or in the future! ";
            }
            }
            catch
            {
                Error = Error + "The date was provided in an invalid format! ";
            }

            if (8 < postcode.Length || 6 > postcode.Length)
            {
                Error = Error + "Postcode is in an invalid format! ";
            }
            return Error;
        }
    }
}