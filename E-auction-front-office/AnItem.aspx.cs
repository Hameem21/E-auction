using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_auction_class_library;

public partial class AnItem : System.Web.UI.Page
{
    Int32 ItemNo;

    protected void Page_Load(object sender, EventArgs e)
    {
        ItemNo = Convert.ToInt32(Session["ItemNo"]);
        if (IsPostBack == false)
        {
            if (ItemNo != -1)
            {
                DisplayItems();
            }
        }

    }

    void DisplayItems()
    {
        clsItemsCollection ItemBook = new clsItemsCollection();
        ItemBook.ThisItem.Find(ItemNo);

        TxtItemNo.Text = ItemBook.ThisItem.ItemNo.ToString();
        TxtItemDescription.Text = ItemBook.ThisItem.ItemDescription;
        TxtItemQuantity.Text = ItemBook.ThisItem.ItemQuantity.ToString();
        TxtItemPricePerUnit.Text = ItemBook.ThisItem.ItemPricePerUnit.ToString();
        TxtItemDateOfAvailability.Text = ItemBook.ThisItem.ItemDateOfAvailability.ToString();
        ItemAvailability.Checked = ItemBook.ThisItem.ItemAvailability;

    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        clsItems AnItem = new clsItems();


        string ItemDescription = TxtItemDescription.Text;
        string ItemQuantity = TxtItemQuantity.Text;
        string ItemPricePerUnit = TxtItemPricePerUnit.Text;
        string ItemDateOfAvailability = TxtItemDateOfAvailability.Text;
        string Error = "";
        Error = AnItem.Valid(ItemDescription, ItemQuantity, ItemPricePerUnit, ItemDateOfAvailability);

        if (Error == "")
        {
            AnItem.ItemNo = ItemNo;
            AnItem.ItemDescription = ItemDescription;
            AnItem.ItemQuantity = Convert.ToInt32(ItemQuantity);
            AnItem.ItemPricePerUnit = Convert.ToDecimal(ItemPricePerUnit);
            AnItem.ItemDateOfAvailability = Convert.ToDateTime(ItemDateOfAvailability);
            AnItem.ItemAvailability = ItemAvailability.Checked;


            clsItemsCollection ItemsList = new clsItemsCollection();

            if (ItemNo == -1)
            {
                ItemsList.ThisItem = AnItem;
                ItemsList.Add();
            }


            else
            {
                ItemsList.ThisItem.Find(ItemNo);
                ItemsList.ThisItem = AnItem;
                ItemsList.Update();
            }
            Response.Redirect("ItemsList.aspx");
        }
        else
        {
            lblError.Text = Error;
        }
    }

    protected void btnFind_Click1(object sender, EventArgs e)
    {
        clsItems AnItem = new clsItems();
        Int32 ItemNo;
        Boolean Found = false;
        ItemNo = Convert.ToInt32(TxtItemNo.Text);
        Found = AnItem.Find(ItemNo);
        if (Found == true)
        {
            Session["AnItem"] = AnItem;
            Response.Redirect("AnItem.aspx");
            TxtItemNo.Text = AnItem.ItemNo.ToString();
            TxtItemDescription.Text = AnItem.ItemDescription;
            TxtItemQuantity.Text = AnItem.ItemQuantity.ToString();
            TxtItemPricePerUnit.Text = AnItem.ItemPricePerUnit.ToString();
            TxtItemDateOfAvailability.Text = AnItem.ItemDateOfAvailability.ToString();
        }
    }
}



