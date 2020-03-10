using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_auction_class_library;

public partial class ACustomer : System.Web.UI.Page
{
    protected void btnSubmit_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer.EmailAddress = txtEmail.Text;
        ACustomer.Postcode = txtPostcode.Text;
        ACustomer.Username = txtUsername.Text;
        ACustomer.DateCreated = DateTime.Now;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        Int32 CustomerID;
        Boolean Found = false;
        CustomerID =Convert.ToInt32( txtCustomerID.Text);
        Found = ACustomer.Find(CustomerID);
        if (Found == true)
        {
            txtEmail.Text = ACustomer.EmailAddress;
            txtPostcode.Text = ACustomer.Postcode;
            txtUsername.Text = ACustomer.Username;
            txtCustomerID.Text = ACustomer.CustomerID.ToString();
            txtDateAdded.Text = ACustomer.DateCreated.ToString();
        }
    }
}