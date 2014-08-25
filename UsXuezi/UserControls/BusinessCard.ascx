<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BusinessCard.ascx.cs" Inherits="UsXuezi.UserControls.BusinessCard" %>

<div id="businesscard" class="businesscard_horizon">
    <div id="businessavatar" class="businessavatar">
        <asp:Image ID="Image1" runat="server"  CssClass="avatar" />
    </div>
    <div id="businessinfo" class="businessinfo inner_sideblock">

        <div class="expand" style="width: 100%;">
            <h1>
                <asp:Label ID="Label1" runat="server" class="floatleft" Text="游美网"></asp:Label></h1>

            <!--如有评分则直接显示星星，不显示“评分”二字-->
            <div class="floatleft left_30">
                <asp:Label ID="Label2" runat="server" class="note" Text="暂无评分"></asp:Label><span class="starts"></span>
            </div>
        </div>

        <div>
            <asp:Label ID="Label3" runat="server" class="sub_heading top_50" Text="主营&emsp;"></asp:Label>
        </div>

        <div class="biz_contact top_10 expand" style="width: 70%;">

            <div class="item floatleft">
                <asp:Label ID="Label5" runat="server" Text="电话&emsp;"></asp:Label>
            </div>

            <div class="item floatleft">
                <asp:Label ID="Label6" runat="server" Text="邮箱&emsp;"></asp:Label>
            </div>
            <div class="item floatleft">
                <asp:Label ID="Label7" runat="server" Text="微信&emsp;"></asp:Label>
            </div>
            
            <!--
            <div class="item floatleft">
                <asp:Label ID="Label8" runat="server" Text="微博"></asp:Label>
            </div>
                -->
            <div class="item floatleft">
                <asp:Label ID="Label9" runat="server" Text="QQ&emsp;"></asp:Label>
            </div>
            <div class="longitem floatleft">
                <asp:Label ID="Label4" runat="server" Text="地址&emsp;"></asp:Label>
            </div>

        </div>

        <asp:Button ID="Button2" runat="server" Style="margin-top: -30px; height: 31px;" class="floatright border_button" Text="关注" OnClick="Button2_Click" />





    </div>
</div>
