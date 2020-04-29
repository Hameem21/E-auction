using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class ItemsList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ItemNo"] = -1;
        Response.Redirect("AnItem.aspx");
    }


    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 ItemNo;
        if (lstItemList.SelectedIndex != -1) 
        {
            ItemNo = Convert.ToInt32(1stItemList.SelectedValue);
            Session["ItemNo"] = ItemNo;
            Response.Redirect("DeleteItem.aspx");
        }
        else
        {
            lblError.Text = "Please select an item to delete from the list";
        }
    }
}