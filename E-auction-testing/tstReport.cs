using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace E_auction_testing
{
    [TestClass]
    public class clsReport
    {
        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create 
            clsReport AnReport = new clsReport();
            //test to see that it exists
            Assert.IsNotNull(AnReport);
        }

    }
}
