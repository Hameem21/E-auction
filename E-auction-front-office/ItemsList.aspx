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
            <asp:Button ID="btnEdit" runat="server" Text="Edit" OnClick="btnEdit_Click1" />
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click1" />
        </p>
        <p>
            Enter Item Description
            <asp:TextBox ID="TxtFilter" runat="server"></asp:TextBox>
        </p>
        <p>
           
            <asp:Button ID="btnApply" runat="server" OnClick="btnApply_Click" style="height: 26px" Text="Apply" />
            <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" style="height: 26px" Text="Clear" />
        </p>
        <asp:Label ID="lblError" runat="server" Text="[lblError]"></asp:Label>
    </form>
</body>
</html>
