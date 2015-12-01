<%@ Page Title="" Language="C#" MasterPageFile="~/Site.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="Admin_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" Runat="Server">
    <div class="jumbotron">
        <h1>Security Administration</h1>
    </div>
    <div class="row">
        <div class="col-md-6">
            <h2>Users</h2>
            <asp:GridView ID="SiteUsers" runat="server"></asp:GridView>
        </div>
        <div class="col-md-6">
            <h2>Roles</h2>
            <asp:GridView ID="SiteRoles" runat="server"></asp:GridView>
        </div>
    </div>
</asp:Content>

