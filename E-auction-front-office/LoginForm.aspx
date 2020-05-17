<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LoginForm.aspx.cs" Inherits="LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Lbl_Username" runat="server" Text="Username"></asp:Label>&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Lbl_password" runat="server" Text="Password"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_password" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" />
        </div>
    </form>
</body>
</html>
