<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page_all_suppliers.aspx.cs" Inherits="INVENTORY_MANAGEMENT_SYSTEM.page_all_suppliers" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style8 {
            margin-left: 451px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;<br />
        <div class="auto-style1">
    <asp:GridView ID="GridView1" runat="server" Width="375px" CssClass="auto-style8">
    </asp:GridView>
        &nbsp;
        </div>
</p>
</asp:Content>
