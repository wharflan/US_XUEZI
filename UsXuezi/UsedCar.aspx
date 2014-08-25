<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MainMasterPage.Master" Title="二手车" CodeBehind="UsedCar.aspx.cs" Inherits="UsXuezi.UsedCar" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link type="text/css" href="Css/ItemPage.css" rel="stylesheet" />
    <link rel="stylesheet" href="Css/ImgPage.css" />
</asp:Content>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentHolder" runat="server">
    

    <div id="renttitle" class="renttitle title_deco expand">

        <div class="col_66">
        <h1>
            <asp:Label ID="Label1" runat="server" class="big_heading" Text="转手2013 Honda Civic LX 5000 miles"></asp:Label></h1>
        <p>
            <asp:Label ID="Label2" runat="server" class="sub_heading" Text="纽约法拉盛 · 2005年购入 · 发布于2014-03-19"></asp:Label>
        </p>
        </div>

     <div class="weibo_wechat col_33">
         <BBS:SocialIcons ID="SocialIcons2" runat="server"></BBS:SocialIcons>
     </div>


    </div>


    <div class="twoblock64">
        <div class="leftblock">
            <div id="rentimg" class="rentimg">
                <asp:ImageButton ID="ImageButton1" runat="server" CssClass="pictures" />
                <div class="big_price_tag">
                    <span class="one">$1,600</span>
                    <span class="two">询问</span>
                </div>
            </div>
            <div id="rentcontent" class="rentcontent contentblock">
                <asp:Label ID="Label7" runat="server" class="medium_heading" Text="详细介绍"></asp:Label>
                <textarea id="TextArea1" rows="20" class="leftblock_detail">

無中介費!!!

出租多套Quincy Center 地鐡站旁邊的1室1廳, 2室2卫! 
可簽半年- 18月租約
新樓, 設施包括電梯健身房, 電腦窒, 室內停車埸.
屋內有無敵海景, 能看到波士頓. 洗衣樓, 更衣室, 全新高設備廚房跟洗手間.

實用面積由1076 - 1200 sqf!
租金: 1室1廳: $1625-$1880 2室1廳2卫 $1880 - $2100

歡迎查詢及看房
電話: 617-792-4156 (M-F: 9am-6pm)
Email: jason@eastcoastrealty.com (聯絡時請附上連結)</textarea>
            </div>
            <div id="rentdiscuss" class="rentdiscuss"></div>
        </div>
        <div class="rightblock">
            <div id="rentinfo" class="rentinfo sideblock">

                <!--非认证车行则不显示-->
                <div class="sideblock_tag">认证车行</div>

                <div id="basicinfo" class="basicinfo inner_sideblock">
                    <p>
                        <asp:Label ID="Label3" runat="server" Text="日系/欧系/美系"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label4" runat="server" Text="型号（自动/手动档）"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label5" runat="server" Text="里程"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label6" runat="server" Text="有/无事故记录"></asp:Label>
                    </p>
              
                
                    <p class="sub_heading top_20">有意请联系</p>
                    <p>
                        <asp:Label ID="Label8" runat="server" Text="微信"></asp:Label>
                    </p>
                   
                    <p>
                        <asp:Label ID="Label9" runat="server" Text="手机"></asp:Label>
                    </p>

                    <p>
                        <asp:Label ID="Label10" runat="server" Text="邮箱"></asp:Label>
                    </p>

                     <p>
                        <asp:Label ID="Label11" runat="server" Text="QQ"></asp:Label>
                    </p>

                </div>
            </div>

            <div id="rentcontact" class="rentcontact">
                <BBS:DealerCard ID="DealerCard1" runat="server" Type="horizon"></BBS:DealerCard>
            </div>

            <div id="rentsimilar" class="rentsimilar sideblock top_20">
                <h3 style="padding: 12px 18px;"> 类似二手车</h3>
                <ul>
               
                <li>
                    <asp:ImageButton ID="ImageButton0" runat="server" CssClass="thumb_img" />
                    <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton></li>
                <li>
                    <asp:ImageButton ID="ImageButton3" runat="server" CssClass="thumb_img" />
                    <asp:LinkButton ID="LinkButton2" runat="server">LinkButton</asp:LinkButton></li>
                <li>
                    <asp:ImageButton ID="ImageButton4" runat="server" CssClass="thumb_img" />
                    <asp:LinkButton ID="LinkButton3" runat="server">LinkButton</asp:LinkButton></li>

                <li>
                    <asp:ImageButton ID="ImageButton5" runat="server" CssClass="thumb_img" />
                    <asp:LinkButton ID="LinkButton4" runat="server">LinkButton</asp:LinkButton></li>
                <li>
                    <asp:ImageButton ID="ImageButton6" runat="server" CssClass="thumb_img" />
                    <asp:LinkButton ID="LinkButton5" runat="server">LinkButton</asp:LinkButton></li>
                <li>
                    <asp:ImageButton ID="ImageButton7" runat="server" CssClass="thumb_img" />
                    <asp:LinkButton ID="LinkButton6" runat="server">LinkButton</asp:LinkButton></li>

                </ul>
            </div>
        </div>
    </div>



</asp:Content>
