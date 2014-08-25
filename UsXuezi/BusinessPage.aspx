<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusinessPage.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Title="商家页" Inherits="UsXuezi.BusinessPage" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="Css/BusinessPage.css" rel="stylesheet" />
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <div id="maincontent" runat="server">
        <div id="busipageinfo" class="top_50">
            <BBS:BusinessCard ID="BusinessCard1" Type="horizon" runat="server"></BBS:BusinessCard>
            <BBS:SocialIcons ID="SocialIcons2" runat="server"></BBS:SocialIcons>
        </div>
        <div class="twoblock64">
            <div class="leftblock">
                <div class="businesscontent contentblock">
                    <asp:Label ID="Label4" runat="server" class="medium_heading" Text="招牌"></asp:Label>
                    <div id="signaturecontent" runat="server">
                    </div>
                </div>

                <div id="businesscontent" class="businesscontent contentblock">
                    <asp:Label ID="Label7" runat="server" class="medium_heading" Text="详细介绍"></asp:Label>
                    <div class="leftblock_detail">
                        <asp:Label ID="Label2" runat="server" CssClass="detailcontent" Text="Label"></asp:Label>
                    </div>

                </div>
            </div>

            <div class="rightblock">
                <div id="mapinfo" class="mapinfo top_20">
                    <BBS:MapBlock ID="Mapblock1" runat="server" Visible="false" />
                </div>

                <div id="Div1" class="coupon_block contentblock top_20">
                    <asp:Label ID="Label3" runat="server" class="medium_heading" Text="优惠劵"></asp:Label>
                    <div id="couponpart" runat="server" visible="false">
                        <asp:ImageButton ID="ImageButton1" runat="server" CssClass="coupon" />
                        <div class="countdown">
                            <p>离优惠结束还有<strong>27</strong>天</p>
                        </div>
                        <asp:Label ID="Label1" runat="server" Text="描述 很多的内容"></asp:Label>
                    </div>
                </div>

            </div>
        </div>
    </div>
</asp:Content>
