<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="page_login.aspx.cs" Inherits="INVENTORY_MANAGEMENT_SYSTEM.page_login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 1512px;
        }
        .auto-style4 {
            width: 755px;
            text-align: left;
        }
        .auto-style5 {
            text-align: center;
        }
        .auto-style6 {
            width: 649px;
            text-align: right;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />
            <table class="auto-style1">
                <tr>
                    <td class="auto-style6">ENTER USERNAME</td>
                    <td class="auto-style4">
                        &nbsp;&nbsp;
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style6">ENTER PASSWORD</td>
                    <td class="auto-style4">
                        &nbsp;&nbsp;
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2">
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="LOGIN" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style5" colspan="2">
                        <asp:Label ID="Label1" runat="server"></asp:Label>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
