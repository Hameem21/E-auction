using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    //this function handles the load event for the page 
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
        lstItemList.DataSource = Items.ItemList;
        lstItemList.DataValueField = "ItemNo";
        lstItemList.DataTextField = "ItemDescription";
        //bind the data to the list
        lstItemList.DataBind();
    }

}