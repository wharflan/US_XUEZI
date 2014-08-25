<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MainMasterPage.Master" Title="抱歉~" CodeBehind="ErrorPage.aspx.cs" Inherits="UsXuezi.ErrorPage" %>

<asp:Content runat="server" ContentPlaceHolderID="ContentHolder">
    <p>
        <asp:Label ID="Label1" runat="server" Text="抱歉，你没有权限执行此操作"></asp:Label></p>
</asp:Content>
