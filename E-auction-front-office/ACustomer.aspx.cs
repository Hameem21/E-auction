using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_auction_class_library;

public partial class ACustomer : System.Web.UI.Page
{
    Int32 CustomerID;

    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            if(CustomerID != -1)
            {
                DisplayCustomers();
            }
        }
    }

    void DisplayCustomers()
    {
        clsCustomerCollection CustomerList = new clsCustomerCollection();
        CustomerList.ThisCustomer.Find(CustomerID);
        txtCustomerID.Text = CustomerList.ThisCustomer.CustomerID.ToString();
        txtEmail.Text = CustomerList.ThisCustomer.EmailAddress;
        txtPostcode.Text = CustomerList.ThisCustomer.Postcode;
        txtUsername.Text = CustomerList.ThisCustomer.Username;
        txtDateAdded.Text = CustomerList.ThisCustomer.DateCreated.ToString();
        

    }
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
            clsCustomerCollection CustomerList = new clsCustomerCollection();
            CustomerList.ThisCustomer = ACustomer;
            CustomerList.Add();
            
            // Session["ACustomer"] = ACustomer;
            // Response.Redirect("CustomerViewer.aspx");
            if(CustomerID == -1)
            {
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Add();
            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerID);
                CustomerList.ThisCustomer = ACustomer;
                CustomerList.Update();
            }
            Response.Redirect("CustomerList.aspx");
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

    protected void lblError_TextChanged(object sender, EventArgs e)
    {

    }
}