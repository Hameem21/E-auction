using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_auction_class_library;

public partial class DeleteItem : System.Web.UI.Page
{
    Int32 ItemNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the item to be deleted from the session object
        ItemNo = Convert.ToInt32(Session["ItemNo"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        clsItemsCollection ItemBook = new clsItemsCollection();
        ItemBook.ThisItem.Find(ItemNo);
        ItemBook.Delete();
        Response.Redirect("ItemsList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        Response.Redirect("ItemsList.aspx");
    }
}