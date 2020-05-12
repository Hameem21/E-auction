using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;


namespace E_auction_class_library
{
    public class clsCustomerCollection
    {
        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        clsCustomer mThisCustomer = new clsCustomer();

        public clsCustomerCollection()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.Execute("sproc_TblCustomer_SelectAll");
            PopulateArray(DB);
        }




        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;
            }
            set
            {
                mCustomerList = value;
            }
        }


        public clsCustomer ThisCustomer
        {
            get
            { return mThisCustomer;
            }
            set 
            {
                mThisCustomer = value;
            }
        }

        public int Count {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }

        }

        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerEmail", mThisCustomer.EmailAddress);
            DB.AddParameter("@CustomerUsername", mThisCustomer.Username);
            DB.AddParameter("@DateCreated", mThisCustomer.DateCreated);
            DB.AddParameter("@Postcode", mThisCustomer.Postcode);
            DB.AddParameter("@VerifiedAccount", mThisCustomer.VerifiedAccount);
            return DB.Execute("sproc_TblCustomer_Insert");
            
        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerID", mThisCustomer.CustomerID);
            DB.Execute("sproc_TblCustomer_Delete");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerEmail", mThisCustomer.EmailAddress);
            DB.AddParameter("@CustomerUsername", mThisCustomer.Username);
            DB.AddParameter("@DateCreated", mThisCustomer.DateCreated);
            DB.AddParameter("@Postcode", mThisCustomer.Postcode);
            DB.AddParameter("@VerifiedAccount", mThisCustomer.VerifiedAccount);
            DB.Execute("sproc_TblCustomer_Update");

        }

        public void ReportByUsername(string Username)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Username", Username);
            DB.Execute("sproc_TblCustomer_FilterByUsername");
            PopulateArray(DB);
        }

        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;
            Int32 recordCount = 0;
            recordCount = DB.Count;
            mCustomerList = new List<clsCustomer>();
            while (Index < recordCount)
            {
                clsCustomer ACustomer = new clsCustomer();
                ACustomer.CustomerID = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerID"]);
                ACustomer.EmailAddress = Convert.ToString(DB.DataTable.Rows[Index]["CustomerEmail"]);
                ACustomer.DateCreated = Convert.ToDateTime(DB.DataTable.Rows[Index]["DateCreated"]);
                ACustomer.VerifiedAccount = Convert.ToBoolean(DB.DataTable.Rows[Index]["VerifiedAccount"]);
                ACustomer.Username = Convert.ToString(DB.DataTable.Rows[Index]["CustomerUsername"]);
                ACustomer.Postcode = Convert.ToString(DB.DataTable.Rows[Index]["Postcode"]);
                mCustomerList.Add(ACustomer);
                Index++;
            }

        }
    }
}
