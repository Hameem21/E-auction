using E_auction_class_library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Homepage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btn_SearchItems_Click(object sender, EventArgs e)
    {
        //Response.Redirect(""); - dont have information on this page
    }

    protected void btn_ViewProfileInfo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ACustomer.aspx");
    }

    protected void btn_ListItems_Click(object sender, EventArgs e)
    {
        //Response.Redirect(""); - dont have information on this page
    }
}