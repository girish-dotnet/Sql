<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DonarInsert.aspx.cs" Inherits="DMS.Client.DonarInsert" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 55%;
            height: 391px;
            border-style: solid;
            border-width: 6px;
        }
        .auto-style2 {
            width: 304px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <table align="center" cellpadding="7" cellspacing="7" class="auto-style1">
                <tr>
                    <td class="auto-style2">Donar ID</td>
                    <td>
                        <asp:TextBox ID="txtDonarID" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Donar Name</td>
                    <td>&nbsp;
                        <asp:TextBox ID="txtDonarName" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Gender</td>
                    <td>
                        <asp:RadioButton ID="rbnMale" runat="server" GroupName="g1" Text="Male" />
&nbsp;&nbsp;
                        <asp:RadioButton ID="rbnFemale" runat="server" GroupName="g1" Text="Female" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Date Of Birth</td>
                    <td>
                        <asp:TextBox ID="txtDateOfBirth" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">City</td>
                    <td>
                        <asp:DropDownList ID="ddlCity" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Mobile No</td>
                    <td>
                        <asp:TextBox ID="txtMobileNo" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Organ</td>
                    <td>
                        <asp:DropDownList ID="ddlOrgan" runat="server">
                        </asp:DropDownList>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;<asp:Button ID="btnAdd" runat="server" Text="Add Donar" Width="172px" OnClick="btnAdd_Click" />
                    </td>
                </tr>
            </table>

        </div>
    </form>
</body>
</html>
