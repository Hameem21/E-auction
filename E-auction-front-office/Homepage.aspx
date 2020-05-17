<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Homepage.aspx.cs" Inherits="Homepage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <asp:Label ID="Header" runat="server" Text="E-Auction"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btn_SearchItems" runat="server" Text="Search Items" OnClick="btn_SearchItems_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_ViewProfileInfo" runat="server" Text="View Profile Information" OnClick="btn_ViewProfileInfo_Click" />
&nbsp;&nbsp;&nbsp;
            <asp:Button ID="btn_ListItems" runat="server" Text="List Items" OnClick="btn_ListItems_Click" />
            <br />
        </div>
    </form>
</body>
</html>
