<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MainMasterPage.Master" Title="租房" CodeBehind="Rent.aspx.cs" Inherits="UsXuezi.Rent" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link rel="stylesheet" href="Css/ImgPage.css" />
    <style type="text/css">
        #TextArea1 {
            width: 566px;
        }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <div id="renttitle" class="renttitle title_deco expand">
        <div class="col_66">
            <h1>
                <asp:Label ID="Label1" runat="server" class="big_heading" Text="Brookline 校区无铅2室1厅-可马上入住！"></asp:Label></h1>
            <p>
                <asp:Label ID="Label2" runat="server" class="sub_heading" Text="地段 Newton · 发布于2014-04-27"></asp:Label>
                <asp:LinkButton ID="LinkButton7" runat="server" Visible="false" OnClick="LinkButton7_Click">编辑</asp:LinkButton>
            </p>
        </div>
        <div class="weibo_wechat col_33">
            <BBS:SocialIcons ID="SocialIcons2" runat="server"></BBS:SocialIcons>
        </div>
    </div>
    <div class="twoblock64">
        <div class="leftblock">
            <div id="rentimg" class="rentimg">
                <BBS:PicView runat="server" ID="PicView1"/>
            </div>
            <div id="rentcontent" class="rentcontent contentblock">
                <asp:Label ID="Label7" runat="server" class="medium_heading" Text="详细介绍"></asp:Label>
                <div class="leftblock_detail">
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
            <div id="rentdiscuss" class="rentdiscuss"></div>
        </div>
        <div class="rightblock">
            <div id="rentinfo" class="rentinfo sideblock">
                <div id="basicinfo" class="basicinfo inner_sideblock">
                    <p>
                        <asp:Label ID="Label3" runat="server" Text="出租方式&emsp;"></asp:Label>
                        <asp:Label ID="Label13" runat="server" Text=""></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label4" runat="server" Text="基本月租&emsp;"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label6" runat="server" Text="停车状况&emsp;"></asp:Label>
                        <asp:Label ID="Label14" runat="server" Text=""></asp:Label>
                    </p>

                    <p>
                        <asp:Label ID="Label8" runat="server" Text="最早入住&emsp;"></asp:Label>
                    </p>

                    <p>
                        <asp:Label ID="Label9" runat="server" Text=""></asp:Label>
                    </p>

                    <!--如非经纪人房源则不显示“中介费”-->
                    <p>
                        <asp:Label ID="Label10" runat="server" Text="中介费&emsp;"></asp:Label>
                    </p>

                    <p>
                        <asp:Label ID="Label11" runat="server" Text="地址&emsp;"></asp:Label>
                    </p>


                </div>
                <div id="mapinfo" class="mapinfo">
                    <BBS:MapBlock ID="MapBlock1" runat="server" />
                </div>
            </div>


            <div id="rentcontact" class="rentcontact">
                <BBS:StudentCard ID="StudentCard1" runat="server" CardType="short" />
            </div>



            <div class="rentinfo sideblock top_20">
                <div id="Div1" class="basicinfo inner_sideblock">
                    <h3>联系方式</h3>
                    <p>
                        <asp:Label ID="Label12" runat="server" Text="微信"></asp:Label>
                    </p>

                    <p>
                        <asp:Label ID="Label15" runat="server" Text="QQ"></asp:Label>
                    </p>

                    <p>
                        <asp:Label ID="Label16" runat="server" Text="邮件"></asp:Label>
                    </p>

                    <p>
                        <asp:Label ID="Label17" runat="server" Text="电话"></asp:Label>
                    </p>
                </div>
            </div>

            <div id="rentsimilar" class="rentsimilar sideblock top_20">
                <h3 style="padding: 12px 18px;">类似房源</h3>
                <ul class="rel-pd">                    
                    <li>
                        <div class="pic">
                            <img src="Uploads/Image/Post/63/_thumbs/Files/1_(2).jpg" alt="">
                        </div>
                        <div class="main">
                            <h3 class="title">物品标题物品标题</h3>
                            <div class="price">租金：888刀</div>
                            <div class="date">发布日期：8月15日</div>
                        </div>
                    </li>
                    <li>
                        <div class="pic">
                            <img src="Uploads/Image/Post/63/_thumbs/Files/1_(2).jpg" alt="">
                        </div>
                        <div class="main">
                            <h3 class="title">物品标题物品标题</h3>
                            <div class="price">租金：888刀</div>
                            <div class="date">发布日期：8月15日</div>
                        </div>
                    </li>
                    <li>
                        <div class="pic">
                            <img src="Uploads/Image/Post/63/_thumbs/Files/1_(2).jpg" alt="">
                        </div>
                        <div class="main">
                            <h3 class="title">物品标题物品标题</h3>
                            <div class="price">租金：888刀</div>
                            <div class="date">发布日期：8月15日</div>
                        </div>
                    </li>
                    <li>
                        <div class="pic">
                            <img src="Uploads/Image/Post/63/_thumbs/Files/1_(2).jpg" alt="">
                        </div>
                        <div class="main">
                            <h3 class="title">物品标题物品标题</h3>
                            <div class="price">租金：888刀</div>
                            <div class="date">发布日期：8月15日</div>
                        </div>
                    </li>
                </ul>
            </div>
        </div>
    </div>



</asp:Content>

