<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ItemViewer.aspx.cs" Inherits="ItemViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
        &nbsp;ItemDescription<asp:TextBox ID="TxtItemDescription" runat="server" style="margin-left: 13px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemQuantity<asp:TextBox ID="TxtItemQuantity" runat="server" style="margin-left: 30px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemPricePerUnit<asp:TextBox ID="TxtItemPricePerUnit" runat="server" style="margin-left: 30px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemDateofAvailability<asp:TextBox ID="TxtItemDateOfAvailability" runat="server" style="margin-left: 6px" Width="165px"></asp:TextBox>
        </p>
        <p>
            &nbsp;<asp:CheckBox ID="ItemAvailability" runat="server" />
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
