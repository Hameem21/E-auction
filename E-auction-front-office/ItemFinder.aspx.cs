using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_auction_class_library;

public partial class ItemFinder : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsItems AnItem = new clsItems();
        AnItem = (clsItems)Session["AnItem"];
        Response.Write(AnItem.ItemNo);
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {

        clsItems AnItem = new clsItems();
        Int32 ItemNo;
        Boolean Found = false;
        ItemNo = Convert.ToInt32(TxtItemNo.Text);
        Found = AnItem.Find(ItemNo);
        if (Found == true)
        {
            //display the values of the properties in the form
            TxtItemDescription.Text = AnItem.ItemDescription;
            TxtItemQuantity.Text = AnItem.ItemQuantity.ToString();
            TxtItemPricePerUnit.Text = AnItem.ItemPricePerUnit.ToString();
            TxtItemDateOfAvailability.Text = AnItem.ItemDateOfAvailability.ToString();
        }
    }
}