<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ItemFinder.aspx.cs" Inherits="ItemFinder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
     <div>
        <p>
            ItemNo<asp:TextBox ID="TxtItemNo" runat="server" style="margin-left: 62px" Width="165px"></asp:TextBox>
        &nbsp;<asp:Button ID="btnFind" runat="server" OnClick="btnFind_Click" Text="Find" />
        </p>
        <p>
            ItemDescription<asp:TextBox ID="TxtItemDescription" runat="server" style="margin-left: 13px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemQuantity<asp:TextBox ID="TxtItemQuantity" runat="server" style="margin-left: 30px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemPricePerUnit<asp:TextBox ID="TxtItemPricePerUnit" runat="server" style="margin-left: 10px" Width="159px"></asp:TextBox>
        </p>
        <p>
            ItemDateOfAvailability<asp:TextBox ID="TxtItemDateOfAvailability" runat="server" style="margin-left: 6px" Width="165px"></asp:TextBox>
        </p>
         <p>
             <asp:CheckBox ID="ItemAvailability" runat="server" />
        </p>
         <p>
             &nbsp;</p>
        </div>
    </form>
</body>
</html>