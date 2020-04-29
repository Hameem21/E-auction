<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ItemsList.aspx.cs" Inherits="ItemsList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ListBox ID="lstItemsList" runat="server" Height="409px" Width="372px"></asp:ListBox>
        <p>
            <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" />
        </p>
        <asp:Label ID="Label1" runat="server" Text="lblError"></asp:Label>
    </form>
</body>
</html>
