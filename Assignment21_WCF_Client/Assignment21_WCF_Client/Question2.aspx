<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Question2.aspx.cs" Inherits="Assignment21_WCF_Client.Question2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Calculator Service</h2>
    <asp:Label ID="Label1" runat="server" Text="Enter Number 1:"></asp:Label>
    <asp:TextBox ID="TbxNum1" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Text="Enter Number 2:"></asp:Label>
    <asp:TextBox ID="TbxNum2" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="AddBtn" runat="server" Text="Add" OnClick="AddBtn_Click" />
    <br />
    <br />
    <asp:Label ID="Label3" runat="server" Text="Added Value: "></asp:Label>
    <asp:Label ID="lblAddVal" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Button ID="SubBtn" runat="server" Text="Subtract" OnClick="SubBtn_Click" />
    <br />
    <br />
    <asp:Label ID="Label4" runat="server" Text="Subtracted Value: "></asp:Label>
    <asp:Label ID="lblSubVal" runat="server" Text=""></asp:Label>
</asp:Content>
