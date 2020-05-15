using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using E_auction_class_library;


public partial class ItemsList : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplayItems();
        }
    }

    void DisplayItems()
    {
        //create an instance of the County Collection 
        E_auction_class_library.clsItemsCollection Items = new E_auction_class_library.clsItemsCollection();
        lstItemsList.DataSource = Items.ItemsList;
        lstItemsList.DataValueField = "ItemNo";
        lstItemsList.DataTextField = "ItemDescription";
        //bind the data to the list
        lstItemsList.DataBind();
    }


    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["ItemNo"] = -1;
        Response.Redirect("AnItem.aspx");
    }

    
    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsItemsCollection Items = new clsItemsCollection();
        Items.FilterItemByDescription(TxtFilter.Text);
        lstItemsList.DataSource = Items.ItemsList;
        //set the name of the primary key which is the ItemNo
        lstItemsList.DataValueField = "ItemNo";
        //set the name of the field to display
        lstItemsList.DataTextField = "ItemDescription";
        //bind the data to the list
        lstItemsList.DataBind();
    }


    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsItemsCollection Items = new clsItemsCollection();
        Items.FilterItemByDescription("");
        TxtFilter.Text = "";
        lstItemsList.DataSource = Items.ItemsList;
        lstItemsList.DataValueField = "ItemNo";
        lstItemsList.DataTextField = "ItemDescription";
        lstItemsList.DataBind();
    }

    protected void btnDelete_Click1(object sender, EventArgs e)
    {
        Int32 ItemNo;
        if (lstItemsList.SelectedIndex != -1)
        {
            ItemNo = Convert.ToInt32(lstItemsList.SelectedValue);
            Session["ItemNo"] = ItemNo;
            Response.Redirect("DeleteItem.aspx");
        }
        else
        {
            lblError.Text = "Please select an item to delete from the list";
        }
    }

    protected void btnEdit_Click1(object sender, EventArgs e)
    {
        Int32 ItemNo;
        if (lstItemsList.SelectedIndex != -1)
        {
            ItemNo = Convert.ToInt32(lstItemsList.SelectedValue);
            Session["ItemNo"] = ItemNo;
            Response.Redirect("AnItem.aspx");
        }
        else
        {
            lblError.Text = "Please select a record to edit from the list";
        }
    }
}