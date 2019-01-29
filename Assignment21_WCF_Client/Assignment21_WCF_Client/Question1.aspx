<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Question1.aspx.cs" Inherits="Assignment21_WCF_Client.Question1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Task 1</h2>
    <h4>Say Hello service</h4>
    <asp:Label ID="Label1" runat="server" Text="Enter your name:"></asp:Label>
    <asp:TextBox ID="TbxName" runat="server"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="SayHelloTCPButton" runat="server" Text="GetHelloMessage-TCP" OnClick="SayHelloTCPButton_Click" />
    <br />
    <br />
    <asp:Label ID="lblTcp" runat="server" Text="Using Tcp:"></asp:Label>
    <asp:Label ID="lblTcpMsg" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <asp:Button ID="SayHelloHttpButton" runat="server" Text="GetHelloMessage-Http" OnClick="SayHelloHttpButton_Click" />
    <br />
    <br />
    <asp:Label ID="lblHttp" runat="server" Text="Using Http:"></asp:Label>
    <asp:Label ID="lblHttpMsg" runat="server" Text=""></asp:Label>
    <hr />
    <h2>Task 2</h2>
    <h4>Job Openings service</h4>
    <asp:Button ID="AllOpnBtn" runat="server" Text="Get All Openings" OnClick="AllOpnBtn_Click"/>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Select Role: "></asp:Label>
    <asp:DropDownList ID="drpRoles" runat="server"></asp:DropDownList>
    <asp:Button ID="OpnByRolesBtn" runat="server" Text="Get Openings by the Role" OnClick="OpnByRolesBtn_Click"/>
    <br />
    <asp:GridView ID="GridView1" runat="server"></asp:GridView>
</asp:Content>
