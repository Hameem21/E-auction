﻿<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ItemViewer.aspx.cs" Inherits="ItemViewer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form2" runat="server">
        <p>
            ItemNo<asp:TextBox ID="TxtItemNo" runat="server" style="margin-left: 62px" Width="165px"></asp:TextBox>
        &nbsp;</p>
        <p>
            ItemDescription<asp:TextBox ID="TxtItemDescription" runat="server" style="margin-left: 13px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemQuantity<asp:TextBox ID="TxtItemQuantity" runat="server" style="margin-left: 30px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemPricePerUnit<asp:TextBox ID="TxtItemPricePerUnit" runat="server" style="margin-left: 30px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemDateofAvailability<asp:TextBox ID="TxtDateOfAvailability" runat="server" style="margin-left: 6px" Width="165px"></asp:TextBox>
        </p>
        <p>
            ItemAvailability
            <asp:TextBox ID="TxtItemAvailability" runat="server" style="margin-left: 16px" Width="168px"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btnOK" runat="server" Text="OK" OnClick="btnOK_Click1" />
        </p>
    </form>
</body>
</html>
