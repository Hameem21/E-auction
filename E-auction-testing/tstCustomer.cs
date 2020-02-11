using System;
using E_auction_class_library;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class tstCustomer
    {
        [TestMethod]
        public void InstanceOK(){
            //create an instance of the class we want to create
            clsCustomer ACustomer = new clsCustomer();
            Assert.IsNotNull(ACustomer);
        
        }
    }
}
