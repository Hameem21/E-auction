using System;
using System.Collections.Generic;
using System.Web;
using System.Linq;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_auction_class_library;

public partial class AnItem : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsItems AnItem = new clsItems();
        AnItem = (clsItems)Session["AnItem"];
        Response.Write(AnItem.ItemNo);

    }

    protected void btnOk_Click(object sender, EventArgs e)
    { 
        clsItems AnItem = new clsItems();

        AnItem.ItemNo = Convert.ToInt32(TxtItemNo.Text);
        AnItem.ItemDescription = TxtItemDescription.Text;
        AnItem.ItemQuantity = Convert.ToInt32(TxtItemQuantity.Text);
        AnItem.ItemPricePerUnit = Convert.ToDecimal(TxtPricePerUnit.Text);
        AnItem.ItemDateofAvailability = Convert.ToDateTime(TxtDateOfAvailability.Text);

        Session["AnItem"] = AnItem;
        Response.Redirect("ItemViewer.aspx");
    }


   
}
