<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ItemViewer.aspx.cs" Inherits="ItemViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
            ItemNo<asp:TextBox ID="TextBox1" runat="server" style="margin-left: 62px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemDescription<asp:TextBox ID="TextBox2" runat="server" style="margin-left: 13px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemQuantity<asp:TextBox ID="TextBox3" runat="server" style="margin-left: 30px" Width="165px"></asp:TextBox>
        </p>
        <p>
            PricePerUnit<asp:TextBox ID="TextBox4" runat="server" style="margin-left: 30px" Width="165px"></asp:TextBox>
        </p>
        <p>
            DateofAvailability<asp:TextBox ID="TextBox5" runat="server" style="margin-left: 6px" Width="165px"></asp:TextBox>
        </p>
        <p>
            &nbsp;<asp:CheckBox ID="Available" runat="server" />
        </p>
        <p>
            <asp:Button ID="Button1" runat="server" Text="OK" />
            <asp:Button ID="Button2" runat="server" Text="Cancel" />
        </p>
    </form>
</body>
</html>
