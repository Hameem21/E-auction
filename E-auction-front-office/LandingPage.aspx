
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="LandingPage.aspx.cs" Inherits="LandingPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 40px">
            <asp:Label ID="Label1" runat="server" Text="E-auction Internet Auction website"></asp:Label>
            <br />
            <br />
        </div>
        <asp:Button ID="Btn_login" runat="server" Text="Login" OnClick="btnLogin_Click" />
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Btn_Create" runat="server" Text="Create Account" OnClick="btnCreate_Click" />

    &nbsp;&nbsp;&nbsp;
        <asp:Button ID="btn_Items" runat="server" OnClick="btnItems_Click" Text="Search Items" />

    </form>
</body>
</html>
