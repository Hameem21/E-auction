using System;

namespace E_auction_class_library
{
    public class clsCustomer
    {
        public bool VerifiedAccount { get; set; }
        public DateTime DateCreated { get; set; }
        public string EmailAddress { get; set; }
        public string Username { get; set; }
        public int CustomerID { get; set; }
    }
}