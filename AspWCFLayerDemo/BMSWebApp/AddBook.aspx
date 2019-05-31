<%@ Page Title="" Language="C#" MasterPageFile="~/BookManagementSystem.Master" AutoEventWireup="true" CodeBehind="AddBook.aspx.cs" Inherits="BMSWebApp.AddBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <p>
        <h2>Add Book Details</h2>
    Book ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
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
        <asp:Button ID="btnAddBook" runat="server" Text="Add Book" OnClick="btnAddBook_Click" />
    </p>
<p>
        <asp:Label ID="lblError" runat="server" Font-Bold="True" Font-Size="Medium" ForeColor="Red"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
