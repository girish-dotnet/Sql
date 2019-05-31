<%@ Page Title="" Language="C#" MasterPageFile="~/BookManagementSystem.Master" AutoEventWireup="true" CodeBehind="UpdateBook.aspx.cs" Inherits="BMSWebApp.UpdateBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <p>
        <br />
    </p>
        <h2>Update Book Details</h2>
    Book ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
&nbsp;&nbsp;&nbsp;
    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" />
    </p>
    <p>
        Name&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
    </p>
    <p>
        Price&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
    </p>
    <p>
        Description
        <asp:TextBox ID="txtDescription" runat="server" Height="69px" TextMode="MultiLine" Width="235px"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnUpdateBook" runat="server" Text="Update Book" OnClick="btnUpdateBook_Click" />
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
