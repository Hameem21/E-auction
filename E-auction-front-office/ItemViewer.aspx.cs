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
    }


    protected void btnOK_Click(object sender, EventArgs e)
    {
    
            clsItems AnItem = new clsItems();
            AnItem.ItemNo = Convert.ToInt32(TxtItemNo.Text);
            AnItem.ItemDescription = TxtItemDescription.Text;
            AnItem.ItemQuantity = Convert.ToInt32(TxtItemQuantity.Text);
            AnItem.ItemPricePerUnit = Convert.ToDecimal(TxtItemPricePerUnit.Text);
            AnItem.ItemDateOfAvailability = Convert.ToDateTime(TxtDateOfAvailability.Text);
            AnItem.ItemAvailability = Convert.ToBoolean(TxtItemAvailability.Text);

            Session["AnItem"] = AnItem;
            Response.Redirect("ItemViewer.aspx");

        
    }
}
