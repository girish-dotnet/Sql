<%@ Page Title="" Language="C#" MasterPageFile="~/BookManagementSystem.Master" AutoEventWireup="true" CodeBehind="DeleteBook.aspx.cs" Inherits="BMSWebApp.DeleteBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h2>Delete Book Details</h2>
    Book ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnDeleteBook" runat="server" Text="Delete Book" OnClick="btnDeleteBook_Click" />
    </p>
    <p>
        &nbsp;</p>
</asp:Content>
