using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if(IsPostBack == false)
        {
            DisplayCustomers();
        }
    }
    void DisplayCustomers()
    {
        E_auction_class_library.clsCustomerCollection Customers = new E_auction_class_library.clsCustomerCollection();
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerNo";
        lstCustomers.DataTextField = "CustomerUsername";
        lstCustomers.DataBind();
    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void addBtn_Click(object sender, EventArgs e)
    {
        Session["CustomerID"] = -1;
        Response.Redirect("ACustomer.aspx");
    }

    protected void deleteBtn_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if(lstCustomers.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("DeleteAddress.aspx");

        }
        else
        {
            lblError.Text = "Please select a record to delete from the list";
        }
    }

    protected void editBtn_Click(object sender, EventArgs e)
    {
        Int32 CustomerID;
        if(lstCustomers.SelectedIndex != -1)
        {
            CustomerID = Convert.ToInt32(lstCustomers.SelectedValue);
            Session["CustomerID"] = CustomerID;
            Response.Redirect("ACustomer.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from the list to edit";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        E_auction_class_library.clsCustomerCollection Customers = new E_auction_class_library.clsCustomerCollection();
        Customers.ReportByUsername(txtUsername.Text);
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerID";
        lstCustomers.DataTextField = "CustomerUsername";
        lstCustomers.DataBind();
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        E_auction_class_library.clsCustomerCollection Customers = new E_auction_class_library.clsCustomerCollection();
        Customers.ReportByUsername("");
        txtUsername.Text = "";
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerID";
        lstCustomers.DataTextField = "CustomerUsername";
        lstCustomers.DataBind();
    }
}