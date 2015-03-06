<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="Clerk-NewAdjustmentVoucherUI.aspx.cs" Inherits="LU.Clerk_NewAdjustmentVoucherUI" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-size: x-large;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style4 {
            width: 104px;
        }
        .auto-style5 {
            width: 228px;
        }
        .auto-style7 {
            width: 227px;
        }
        .auto-style8 {
            width: 287px;
        }
        .auto-style9 {
            width: 240px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; <span class="auto-style1"><strong>Adjustment Voucher</strong></span></p>
    <hr aria-checked="false" style="border-color: #4AB7FF" />
    <table class="auto-style2">
        <tr>
            <td class="auto-style5">
        <asp:Label ID="Label4" runat="server" Text="Category"></asp:Label>
            </td>
            <td class="auto-style9">
        <asp:Label ID="Label5" runat="server" Text="Item"></asp:Label>
            </td>
            <td class="auto-style8">
        <asp:Label ID="Label6" runat="server" Text="Balance Stock"></asp:Label>
            </td>
            <td class="auto-style7">
        <asp:Label ID="Label7" runat="server" Text="Actual Stock"></asp:Label>
            </td>
            <td class="auto-style4">
        <asp:Label ID="Label8" runat="server" Text="UOM"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">
        <asp:DropDownList ID="Category_DropDownList1"   runat="server" AutoPostBack="True" OnTextChanged="Category_DropDownList1_IndexChanged1"  >
        </asp:DropDownList>
            </td>
            <td class="auto-style9">
        <asp:DropDownList ID="DropDownList_item" runat="server" OnSelectedIndexChanged="DropDownList_item_SelectedIndexChanged" AutoPostBack="True">
        </asp:DropDownList>
            </td>
            <td class="auto-style8">
        <asp:Label ID="Label_BalanceStock" runat="server" Text="Label"></asp:Label>
            </td>
            <td class="auto-style7">
        <asp:TextBox ID="txtActualStock" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style4">
        <asp:Label ID="Label_uom" runat="server"></asp:Label>
            </td>
            <td>
        <asp:Button ID="Button1" runat="server" Text="Add" BackColor="#0066FF" BorderColor="#0066FF" ForeColor="White" />
            </td>
        </tr>
    </table>
    <p style="height: 16px; width: 1296px; margin-top: 6px; margin-bottom: 5px">
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="Button2" runat="server" PostBackUrl="~/Clerk-ViewAdjustmentLisUI.aspx" Text="Cancel" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button3" runat="server" PostBackUrl="~/Clerk-ViewAdjustmentLisUI.aspx" Text="Submit" BackColor="#5DB65C" BorderColor="#5DB65C" ForeColor="White" />
    </p>
</asp:Content>
