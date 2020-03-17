using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_auction_class_library;


public partial class ItemViewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

        clsItems AnItem = new clsItems();
        AnItem = (clsItems)Session["AnItem"];
        Response.Write(AnItem.ItemNo);
        Response.Write(AnItem.ItemDescription);
        Response.Write(AnItem.ItemQuantity);
        Response.Write(AnItem.ItemPricePerUnit);
        Response.Write(AnItem.ItemDateofAvailability);
    }
}
