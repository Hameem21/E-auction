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
        ACustomer.EmailAddress = email.Text;
        ACustomer.Postcode = postcode.Text;
        ACustomer.Username = username.Text;
        ACustomer.DateCreated = DateTime.Now;
        Session["ACustomer"] = ACustomer;
        Response.Redirect("CustomerViewer.aspx");
    }
}