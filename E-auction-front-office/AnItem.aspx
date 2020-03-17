<%@ Page Language="C#" AutoEventWireup="true" CodeFile="AnItem.aspx.cs" Inherits="AnItem" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <p>
            ItemNo<asp:TextBox ID="TxtItemNo" runat="server" style="margin-left: 62px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemDescription<asp:TextBox ID="TxtItemDescription" runat="server" style="margin-left: 13px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemQuantity<asp:TextBox ID="TxtItemQuantity" runat="server" style="margin-left: 30px" Width="165px"></asp:TextBox>
        </p>
        <p>
            PricePerUnit<asp:TextBox ID="TxtPricePerUnit" runat="server" style="margin-left: 30px" Width="165px"></asp:TextBox>
        </p>
        <p>
            DateofAvailability<asp:TextBox ID="TxtDateOfAvailability" runat="server" style="margin-left: 6px" Width="165px"></asp:TextBox>
        </p>
        <p>
            &nbsp;<asp:CheckBox ID="Available" runat="server" />
        </p>
        <p>
            <asp:Button ID="btnOk" runat="server" Text="OK" OnClick="btnOk_Click" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
