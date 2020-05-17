using System;
using System.Collections.Generic;
using System.Linq;
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
        Response.Write(AnItem.ItemDescription + "" + AnItem.ItemQuantity + "" + AnItem.ItemPricePerUnit + "" + AnItem.ItemDateOfAvailability);

    }


    protected void btnOK_Click(object sender, EventArgs e)
    {

        clsItems AnItem = new clsItems();
        AnItem.ItemDescription = TxtItemDescription.Text;
        AnItem.ItemQuantity = Convert.ToInt32(TxtItemQuantity.Text);
        AnItem.ItemPricePerUnit = Convert.ToDecimal(TxtItemPricePerUnit.Text);
        AnItem.ItemDateOfAvailability = Convert.ToDateTime(TxtItemDateOfAvailability.Text);
        AnItem.ItemAvailability = ItemAvailability.Checked;

        Session["AnItem"] = AnItem;
        Response.Redirect("ItemViewer.aspx");


    }
}
