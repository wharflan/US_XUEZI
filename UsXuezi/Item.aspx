<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Item.aspx.cs" Inherits="UsXuezi.Item" MasterPageFile="~/MainMasterPage.Master" Title="二手货" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link type="text/css" href="Css/ItemPage.css" rel="stylesheet" />
    <link rel="stylesheet" href="Css/ImgPage.css" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div id="renttitle" class="renttitle title_deco expand">
        <div class="col_66">
            <h1>
                <asp:Label ID="Label1" runat="server" class="big_heading" Text="转手驴牌经典款包包"></asp:Label></h1>
            <p>
                <asp:Label ID="Label2" runat="server" class="sub_heading" Text="纽约曼哈顿 · 2012年购入 · 发布于2014-03-19"></asp:Label>
                <asp:LinkButton ID="LinkButton1" OnClick="LinkButton1_Click" runat="server">编辑</asp:LinkButton>

            </p>
        </div>

        <div class="weibo_wechat col_33">
            <BBS:SocialIcons ID="SocialIcons2" runat="server"></BBS:SocialIcons>
        </div>
    </div>
    <div class="twoblock64">
        <div class="leftblock">
            <div id="rentimg" class="rentimg">
                <BBS:PicView runat="server" ID="PicView1" />
                <div class="big_price_tag">
                    <span class="one">
                        <asp:Label ID="Label11" runat="server" Text="Label"></asp:Label></span>

                </div>
            </div>
            <div id="rentcontent" class="rentcontent contentblock">
                <asp:Label ID="Label7" runat="server" class="medium_heading" Text="详细介绍"></asp:Label>
                <div class="leftblock_detail">
                    <asp:Label ID="Label12" CssClass="detailcontent" runat="server" Text="Label"></asp:Label>
                </div>
            </div>

            <div id="rentdiscuss" class="rentdiscuss"></div>
        </div>
        <div class="rightblock">
            <div id="rentinfo" class="rentinfo sideblock">
                <div id="basicinfo" class="basicinfo inner_sideblock">
                    <p>
                        <asp:Label ID="Label3" runat="server" Text="新旧程度"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label4" runat="server" Text="包邮/面交/自取"></asp:Label>
                    </p>

                    <p class="sub_heading top_20">有意请联系</p>
                    <p>
                        <asp:Label ID="Label6" runat="server" Text="微信"></asp:Label>
                    </p>

                    <p>
                        <asp:Label ID="Label9" runat="server" Text="手机"></asp:Label>
                    </p>

                    <p>
                        <asp:Label ID="Label8" runat="server" Text="QQ"></asp:Label>
                    </p>

                    <p>
                        <asp:Label ID="Label10" runat="server" Text="邮箱"></asp:Label>
                    </p>
                </div>

            </div>
            <div id="rentcontact" class="rentcontact">
                <BBS:StudentCard ID="StudentCard1" runat="server" Type="short"></BBS:StudentCard>
            </div>
            <div id="rentsimilar" class="rentsimilar sideblock top_20" runat="server">
                <h3 style="padding: 12px 18px;">类似物品</h3>
                <!--
                <ul>                    
                    <li>
                        <asp:ImageButton ID="ImageButton7" runat="server" CssClass="thumb_img" />
                        <asp:LinkButton ID="LinkButton6" runat="server">LinkButton</asp:LinkButton></li>
                </ul>
                    -->
            </div>
        </div>
    </div>

</asp:Content>
