<%@ Page Title="" Language="C#" MasterPageFile="~/BookManagementSystem.Master" AutoEventWireup="true" CodeBehind="SearchBook.aspx.cs" Inherits="BMSWebApp.SearchBook" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <p>
    </p>
    <h2>Search Book Details</h2>
    Book ID&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
    <asp:TextBox ID="txtID" runat="server"></asp:TextBox>
    </p>
    <p>
        <asp:Button ID="btnSearchBook" runat="server" Text="Search Book" OnClick="btnSearchBook_Click" />
    </p>
      <p>
          <asp:DetailsView ID="DetailsView1" runat="server" CellPadding="4" ForeColor="#333333" GridLines="None" Height="50px" Width="125px">
              <AlternatingRowStyle BackColor="White" />
              <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
              <EditRowStyle BackColor="#2461BF" />
              <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
              <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
              <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
              <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
              <RowStyle BackColor="#EFF3FB" />
          </asp:DetailsView>
</asp:Content>
