<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UsXuezi.Login" MasterPageFile="~/MainMasterPage.Master" Title="登陆" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="/Css/PublishPage.css" rel="stylesheet" />
    <link href="/Css/UsXueziCss.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="msform top_50">
        <fieldset>
            <div>
                <div class="long_item floatleft">
                    <asp:Label ID="Label15" runat="server" Text="邮箱"></asp:Label><asp:TextBox ID="TextBox8" CssClass="basic-input" runat="server"></asp:TextBox>
                    <div class="note floatleft" style="line-height: 35px;">*<a herf="/Register.aspx">注册</a></div>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label9" runat="server" Text="密码"></asp:Label><asp:TextBox ID="TextBox2" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

                <div class="floatleft">
                    <asp:Label ID="Label1" Width="300px" runat="server" Text=""></asp:Label>
                </div>
                <!--
                <div class="item floatleft" >
                    <asp:Label ID="Label5" runat="server" Text="验证码"></asp:Label>
                    <asp:TextBox ID="TextBox5" CssClass="basic-input" Width="135px" runat="server"></asp:TextBox>
                    <asp:Image ID="Image1" ImageUrl="/UserControls/ValidateCode.aspx" Style="float: left;" Height="32" runat="server" />
                </div>

                
                -->
            </div>

            <asp:Button ID="Button1" OnClick="Button1_Click" class="submit red_button floatright" runat="server" Text="登陆" />
        </fieldset>
    </div>
</asp:Content>
