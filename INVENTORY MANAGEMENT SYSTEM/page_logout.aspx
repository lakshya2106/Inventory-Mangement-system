<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page_logout.aspx.cs" Inherits="INVENTORY_MANAGEMENT_SYSTEM.page_logout" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            text-align: center;
            font-size: xx-large;
        }
        .auto-style2 {
            font-size: xx-large;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <p class="auto-style1">
            <strong>YOU ARE LOGGED OUT!!</strong></p>
        <p class="auto-style1">
            &nbsp;</p>
        <p class="auto-style1">
            <asp:Button ID="Button1" runat="server" CssClass="auto-style2" Height="91px" OnClick="Button1_Click" Text="LOGIN" Width="207px" />
        </p>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
