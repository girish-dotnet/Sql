<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddBusiness.aspx.cs" Inherits="BMS.WebApplication.AddBusiness" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 52%;
            height: 394px;
            border-style: solid;
            border-width: 4px;
        }
        .auto-style2 {
            width: 274px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center" cellpadding="5" cellspacing="6" class="auto-style1">
                <tr>
                    <td class="auto-style2">Business ID</td>
                    <td>
                        <asp:TextBox ID="txtBusinessID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Firm Name</td>
                    <td>
                        <asp:TextBox ID="txtFirmName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Activity Nature</td>
                    <td>
                        <asp:DropDownList ID="ddlActivityNature" runat="server" Height="16px" Width="160px">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Firm Address</td>
                    <td>
                        <asp:TextBox ID="txtFirmAddress" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Owner Name</td>
                    <td>
                        <asp:TextBox ID="txtOwnerName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Mobile Number</td>
                    <td>
                        <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Email ID</td>
                    <td>
                        <asp:TextBox ID="txtEmailID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add Business" Width="145px" />
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
