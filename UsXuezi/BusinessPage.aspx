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
                    <asp:Label ID="Label4" runat="server" class="medium_heading" Text="推荐产品"></asp:Label>
                    <div id="signaturecontent" runat="server">
                    </div>
                </div>

                <div id="businesscontent" class="businesscontent contentblock">
                    <asp:Label ID="Label7" runat="server" class="medium_heading" Text="详细介绍"></asp:Label>
                    <div class="leftblock_detail">
                        <asp:Label ID="Label2" runat="server" CssClass="detailcontent" Text="Label"></asp:Label>
                    </div>
                </div>
                <div class="answer-box">
                    <ul>
                        <li class="m-answer">
                            <div class="user-avatar"><img src="Images/user.png" alt="用户头像"></div>
                            <div class="main">
                                <a href="" class="username">林肯叔叔</a>
                                <div class="star-rating">
                                    <span>评分：</span>
                                    <div class="starbar">
                                        <ul class="current-rating" data-score="85">
                                            <li class="star5"></li>
                                            <li class="star4"></li>
                                            <li class="star3"></li>
                                            <li class="star2"></li>
                                            <li class="star1"></li>
                                        </ul>
                                    </div>
                                    <span class="score">9.5</span>
                                </div>
                                <div class="content">
                                    <p>非常简要的说明，没有。</p>
                                    <p>奥巴马的医保政策全称是Patient Protection</p>
                                </div>
                                <div class="answer-info">
                                    <span class="date">发布于2014/08/05</span>
                                    <span class="c-userful">有用(10)</span>
                                    <span class="">没有帮助(5)</span>
                                </div>
                            </div>
                        </li>
                        <li class="m-answer">
                            <div class="user-avatar"><img src="Images/user.png" alt="用户头像"></div>
                            <div class="main">
                                <a href="" class="username">林肯叔叔</a>
                                <div class="star-rating">
                                    <span>评分：</span>
                                    <div class="starbar">
                                        <ul class="current-rating" data-score="85">
                                            <li class="star5"></li>
                                            <li class="star4"></li>
                                            <li class="star3"></li>
                                            <li class="star2"></li>
                                            <li class="star1"></li>
                                        </ul>
                                    </div>
                                    <span class="score">9.5</span>
                                </div>
                                <div class="content">
                                    <p>非常简要的说明，没有。</p>
                                    <p>奥巴马的医保政策全称是Patient Protection</p>
                                </div>
                                <div class="answer-info">
                                    <span class="date">发布于2014/08/05</span>
                                    <span class="c-userful">有用(10)</span>
                                    <span class="">没有帮助(5)</span>
                                </div>
                            </div>
                        </li>
                    </ul>
                </div>
                <div class="reply-box">
                    <div class="inp-textBlock">
                        <textarea name="" id=""></textarea>
                    </div>
                    <button class="red_button">回复</button>
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
