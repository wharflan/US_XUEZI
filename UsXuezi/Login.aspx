<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="UsXuezi.Login" MasterPageFile="~/MainMasterPage.Master" Title="登录" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="/Css/PublishPage.css" rel="stylesheet" />
    <link href="/Css/UsXueziCss.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="msform top_50">
        <div class="w1 mc-1 loginbox">
            <div class="box02">
                <h4 class="box02-hd">登录账户</h4>
                <div class="box02-bd">
                    <div class="loginform">
                        <div class="form-group">
                            <label class="label" for="username">邮箱：</label><asp:TextBox ID="TextBox8" CssClass="inp" runat="server"></asp:TextBox>
                        </div>

                        <div class="form-group">
                            <label class="label" for="password">密码：</label><asp:TextBox ID="TextBox2" CssClass="inp" runat="server"></asp:TextBox>
                        </div>

                        <div style="display:none;">
                            <asp:Label ID="Label1" Width="300px" runat="server" Text=""></asp:Label>
                        </div>
                        
                        <div class="form-group verifyCode" >
                            <label class="label" for="password">验证码：</label>
                            <asp:TextBox ID="TextBox5" CssClass="inp" Width="135px" runat="server"></asp:TextBox>
                            <asp:Image ID="Image1" ImageUrl="/UserControls/ValidateCode.aspx" Style="float: left;" Height="32" runat="server" />
                        </div>
                        <div class="submit">
                            <asp:Button ID="Button1" OnClick="Button1_Click" class="btn-login" runat="server" Text="登录" />
                        </div>
                    </div>

                    <div class="login-help">
                        <p class="info text1">还不是会员？</p>
                        <a href="/register.aspx" class="btn-register">注册</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="footer">
        <div class="links"><a href="" target="_blank">关于我们</a>|<a href="" target="_blank">联系我们</a>|<a href="" target="_blank">加入我们</a>|<a href="" target="_blank">用户协议</a>|<a href="" target="_blank">用户指南</a></div>
        <p>Copyright © 2014 usxuezi.com    All rights reserved.</p>
    </div>
</asp:Content>


