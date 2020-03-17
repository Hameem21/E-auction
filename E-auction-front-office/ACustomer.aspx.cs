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
        string EmailAddress = txtEmail.Text;
        string Postcode = txtPostcode.Text;
        string Username = txtUsername.Text;
        string DateAdded = Convert.ToString(DateTime.Now);
        string Error = "";
        Error = ACustomer.Valid(EmailAddress, Postcode, Username, DateAdded);
        if (Error == "")
        {
            ACustomer.EmailAddress = txtEmail.Text;
            ACustomer.Postcode = txtPostcode.Text;
            ACustomer.Username = txtUsername.Text;
            ACustomer.DateCreated = DateTime.Now;
            Session["ACustomer"] = ACustomer;
            Response.Redirect("CustomerViewer.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
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