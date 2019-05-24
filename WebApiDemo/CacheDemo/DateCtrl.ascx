<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DateCtrl.ascx.cs" Inherits="CacheDemo.DateCtrl" %>
<%@ OutputCache Duration="60" VaryByParam="none" %>
<style type="text/css">
    .auto-style1 {
        width: 24%;
        height: 119px;
    }
</style>

<table align="left" cellpadding="5" cellspacing="6" class="auto-style1">
    <tr>
        <td>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
    <tr>
        <td>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        </td>
    </tr>
</table>

