<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnItem.aspx.cs" Inherits="AnItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            ItemNo<asp:TextBox ID="TxtItemNo" runat="server"  style="margin-left: 29px" Width="145px"></asp:TextBox>
            <br />
            <br />
            ItemDescription
            <asp:TextBox ID="TxtItemDescription" runat="server" style="margin-left: 10px" Width="147px"></asp:TextBox>
            <asp:Button ID="btnFind" runat="server" Text="Find" OnClick="btnFind_Click1" />
            <br />
            <br />
            ItemQuantity<asp:TextBox ID="TxtItemQuantity" runat="server" style="margin-left: 21px" Width="154px"></asp:TextBox>
            <br />
            <br />
            ItemPricePerUnit<asp:TextBox ID="TxtItemPricePerUnit" runat="server" style="margin-left: 14px" Width="150px"></asp:TextBox>
            <br />
            <br />
            ItemDateOfAvailability<asp:TextBox ID="TxtItemDateOfAvailability" runat="server" style="margin-left: 12px" Width="144px"></asp:TextBox>
            <br />
            <br />
            <asp:CheckBox ID="ItemAvailability" runat="server" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" Text="lblError"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnOK" runat="server" OnClick="btnOK_Click" Text="OK" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </div>
    </form>
</body>
</html>
