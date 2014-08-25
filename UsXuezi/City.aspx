<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="City.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Inherits="UsXuezi.City" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link rel="stylesheet" href="Css/CityPage.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="threeblock">
        <div id="leftpanel" class="leftpanel">
            <div class="menu_col">
                <div class="left_navlist">
                    <ul>
                        <li class="list_item" id="hottopic">
                            <a href="/City.aspx?type=0">
                                <div class="list_icon">
                                    <span class="list_title">热门话题</span>
                                </div>
                            </a>
                        </li>


                        <li class="list_item" id="secondhanded">
                            <a href="/City.aspx?type=4">
                                <div class="list_icon">
                                    <span class="list_title">二手市场</span>
                                </div>
                            </a>
                        </li>

                        <li class="list_item" id="usedcars">
                            <a href="/City.aspx?type=5">
                                <div class="list_icon active">
                                    <span class="list_title">二手车</span>
                                </div>
                            </a>
                        </li>

                        <li class="list_item" id="housing_rent">
                            <a href="/City.aspx?type=3">
                                <div class="list_icon">
                                    <span class="list_title">房屋租转</span>
                                </div>
                            </a>
                        </li>

                        <li class="list_item" id="housing_sale">
                            <a href="/City.aspx?type=1">
                                <div class="list_icon">
                                    <span class="list_title">房产交易</span>
                                </div>
                            </a>
                        </li>

                        <li class="list_item" id="restaurants">
                            <a href="/City.aspx?type=9">
                                <div class="list_icon">
                                    <span class="list_title">美食餐饮</span>
                                </div>
                            </a>
                        </li>

                        <li class="list_item" id="businesses">
                            <a href="/City.aspx?type=2">
                                <div class="list_icon">
                                    <span class="list_title">商家机构</span>
                                </div>
                            </a>
                        </li>

                        <li class="list_item" id="QnA">
                            <a href="/City.aspx?type=7">
                                <div class="list_icon">
                                    <span class="list_title">答疑解惑</span>
                                </div>
                            </a>
                        </li>

                        <li class="list_item" id="chitchat">
                            <a href="/City.aspx?type=8">
                                <div class="list_icon">
                                    <span class="list_title">吹水吐槽</span>
                                </div>
                            </a>
                        </li>
                    </ul>
                </div>

                <div class="more_similar sideblock">
                    <div class="inner_sideblock">
                        <h3>
                            <asp:Label ID="Label4" runat="server" Text="更多二手交易在："></asp:Label>
                        </h3>
                        <asp:LinkButton ID="LinkButton1" runat="server" CssClass="citylink blue_tag">纽约</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton2" runat="server" CssClass="citylink blue_tag">三藩市</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton3" runat="server" CssClass="citylink blue_tag">芝加哥</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton4" runat="server" OnClick="LinkButton4_Click" CssClass="citylink blue_tag">洛杉矶</asp:LinkButton>
                        <asp:LinkButton ID="LinkButton5" runat="server" OnClick="LinkButton5_Click" CssClass="citylink blue_tag">波士顿</asp:LinkButton>

                    </div>
                </div>
            </div>
        </div>

        <div id="midpanel" class="midpanel">
            <div id="filter" class="filter">
                <BBS:RentFilter runat="server" ID="RF1" Visible="false" />
                <BBS:BusinessFilter runat="server" ID="BF1" Visible="false" />
                <BBS:ItemFilter runat="server" ID="IF1" Visible="false" />
                <asp:Button ID="Button1" CssClass="border_button " OnClick="Button1_Click" runat="server" Text="筛选" />
                <div class="fix-clear"></div>
            </div>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
                <ContentTemplate>

                    <div id="postcontents" class="postcontents" runat="server">
                    </div>
                    <div class="floatleft">
                        <asp:Button ID="Button3" runat="server" CssClass="big_border_button fix-clear" OnClick="Button3_Click" Text="上一页" Visible="false" />
                        <asp:DropDownList ID="DropDownList1" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged" AutoPostBack="true" runat="server" Visible="false"></asp:DropDownList>
                        <asp:Button ID="Button2" runat="server" CssClass="big_border_button fix-clear" OnClick="Button2_Click" Text="下一页" Visible="false" />
                    </div>
                    <asp:HiddenField ID="HiddenField1" runat="server" Value="1" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button1" />
                    <asp:AsyncPostBackTrigger ControlID="Button2" />
                    <asp:AsyncPostBackTrigger ControlID="Button3" />
                    <asp:AsyncPostBackTrigger ControlID="DropDownList1" />
                </Triggers>
            </asp:UpdatePanel>
        </div>
        <div id="rightpanel" class="rightpanel">
            <div class="certf_block">
                <a href="#">
                    <div class="certf_img floatleft">
                        <div class="certf_txt">我要成为认证商家</div>
                    </div>
                </a>
            </div>
        </div>
    </div>
</asp:Content>
