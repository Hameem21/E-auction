<%@ Page Language="C#" AutoEventWireup="true" CodeFile="CustomerList.aspx.cs" Inherits="CustomerList" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <asp:ListBox ID="lstCustomers" runat="server" Height="203px" OnSelectedIndexChanged="ListBox1_SelectedIndexChanged" Width="773px"></asp:ListBox>
        <p>
            <asp:Button ID="addBtn" runat="server" Text="Add" OnClick="addBtn_Click" />
            &nbsp;&nbsp;&nbsp;
            <asp:Button ID="editBtn" runat="server" Text="Edit" OnClick="editBtn_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="deleteBtn" runat="server" OnClick="deleteBtn_Click" Text="Delete" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Enter a Username"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txtUsername" runat="server"></asp:TextBox>
        </p>
        <p style="margin-left: 120px">
            <asp:Button ID="btnApply" runat="server" Text="Apply" OnClick="btnApply_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btnClear" runat="server" Text="Clear" OnClick="btnClear_Click" />
        </p>
    </form>
    <asp:Label ID="lblError" runat="server" Text=""></asp:Label>
</body>
</html>
