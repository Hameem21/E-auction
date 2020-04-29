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

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsItems AnItem = new clsItems();
        string ItemNo = TxtItemNo.Text;
        string ItemDescription = TxtItemDescription.Text;
        string ItemQuantity = TxtItemQuantity.Text;
        string ItemPricePerUnit = TxtItemPricePerUnit.Text;
        string ItemDateOfAvailability = TxtItemDateOfAvailability.Text;
        string ItemAvailability = TxtItemAvailability.Text;
        string Error = "";
        Error = AnItem.Valid(ItemNo, ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);

        if (Error == "")
        {
            AnItem.ItemNo = Convert.ToInt32(ItemNo);
            AnItem.ItemDescription = ItemDescription;
            AnItem.ItemQuantity = Convert.ToInt32(ItemQuantity);
            AnItem.ItemPricePerUnit = Convert.ToDecimal(ItemPricePerUnit);
            AnItem.ItemDateOfAvailability = Convert.ToDateTime(ItemDateOfAvailability);
            AnItem.ItemAvailability = Convert.ToBoolean(ItemAvailability);

            Session["AnItem"] = AnItem;
            Response.Redirect("ItemViewer.aspx");


        }
        else
        {
            lblError.Text = Error;
        }
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
            TxtItemNo.Text = AnItem.ItemNo.ToString();
            TxtItemDescription.Text = AnItem.ItemDescription;
            TxtItemQuantity.Text = AnItem.ItemQuantity.ToString();
            TxtItemPricePerUnit.Text = AnItem.ItemPricePerUnit.ToString();
            TxtItemDateOfAvailability.Text = AnItem.ItemDateOfAvailability.ToString();
            TxtItemAvailability.Text = AnItem.ItemAvailability.ToString();

        }

    }
}








/* this is for btnOK_click before 
       clsItems AnItem = new clsItems();
       AnItem.ItemNo = Convert.ToInt32(TxtItemNo.Text);
       AnItem.ItemDescription = TxtItemDescription.Text;
       AnItem.ItemQuantity = Convert.ToInt32(TxtItemQuantity.Text);
       AnItem.ItemPricePerUnit = Convert.ToDecimal(TxtItemPricePerUnit.Text);
       AnItem.ItemDateOfAvailability = Convert.ToDateTime(TxtItemDateOfAvailability.Text);
       AnItem.ItemAvailability = Convert.ToBoolean(TxtItemAvailability.Text);

       Session["AnItem"] = AnItem;
       Response.Redirect("ItemViewer.aspx"); */











/*string ItemDescription = TxtItemDescription.Text;
string ItemQuantity = TxtItemQuantity.Text;
string ItemPricePerUnit = TxtPricePerUnit.Text;
string ItemDateOfAvailability = TxtDateOfAvailability.Text;
string ItemAvailability = TxtItemAvailability.Text;
string Error = "";
Error = AnItem.Valid(ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability, ItemAvailability);
if (Error == "")
{
AnItem.ItemDescription = TxtItemDescription.Text;
AnItem.ItemQuantity = Convert.ToInt32(TxtItemQuantity.Text);
AnItem.ItemPricePerUnit = Convert.ToDecimal(TxtPricePerUnit.Text);
AnItem.ItemDateofAvailability = Convert.ToDateTime(TxtDateOfAvailability.Text);
AnItem.ItemAvailability = Convert.ToBoolean(TxtItemAvailability.Text);
clsItemsCollection ItemsList = new clsItemsCollection();
ItemsList.ThisItem = AnItem;
ItemsList.Add();
Response.Redirect("ItemsList.aspx");
}
else
{
lblError.Text = Error;
}*/













/* AnItem.ItemNo = Convert.ToInt32(TxtItemNo.Text);
 AnItem.ItemDescription = TxtItemDescription.Text;
 AnItem.ItemQuantity = Convert.ToInt32(TxtItemQuantity.Text);
 AnItem.ItemPricePerUnit = Convert.ToDecimal(TxtPricePerUnit.Text);
 AnItem.ItemDateofAvailability = Convert.ToDateTime(TxtDateOfAvailability.Text);
 AnItem.ItemAvailability = Convert.ToBoolean(TxtItemAvailability.Text);

 Session["AnItem"] = AnItem;
 Response.Redirect("ItemViewer.aspx"); */





























