<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Estate.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Title="地产" Inherits="UsXuezi.Estate" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link rel="stylesheet" href="Css/ImgPage.css" />
    <style type="text/css">
        #TextArea1 {
            width: 566px;
        }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <div id="renttitle" class="renttitle title_deco">
        <h1>
            <asp:Label ID="Label1" runat="server" class="big_heading" Text="Brookline校区重新装修2室1厅"></asp:Label></h1>
        <p>
            <asp:Label ID="Label2" runat="server" class="sub_heading" Text="地段 Newton · 发布于2014-04-27"></asp:Label>
        </p>
        <div class="weibo_wechat">
        </div>
    </div>
    <div class="twoblock64">
        <div class="leftblock">
            <div id="rentimg" class="rentimg">
                <asp:ImageButton ID="ImageButton1" runat="server" CssClass="pictures" />
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
                <!--非经纪房源则不显示-->
                <div class="sideblock_tag">经纪房源</div>

                <div id="basicinfo" class="basicinfo inner_sideblock">
                    <p>
                        <asp:Label ID="Label3" runat="server" Text="售价 $320,000"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label4" runat="server" Text="户型 2室1厅2卫"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label5" runat="server" Text="房型 Townhouse"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label6" runat="server" Text="面积 1,076-1,200 Sqf"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label8" runat="server" Text="停车位 2个"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label9" runat="server" Text="物管费 $300/月"></asp:Label>
                    </p>

                
                    <!--如非经纪人房源则不显示“中介费”-->
                    <p>
                        <asp:Label ID="Label16" runat="server" Text="中介费"></asp:Label>
                    </p>

                    <p>
                        <asp:Label ID="Label10" runat="server" Text="地址"></asp:Label>
                    </p>
                </div>


                <div id="mapinfo" class="mapinfo">
                    <asp:ImageButton ID="ImageButton2" runat="server" CssClass="map" />
                </div>
            </div>

            <div id="rentcontact" class="rentcontact">
                <BBS:StudentCard ID="StudentCard1" runat="server" Type="short"></BBS:StudentCard>
            </div>


            
            <div class="rentinfo sideblock top_20">
              <div id="Div1" class="basicinfo inner_sideblock">
                <h3> 其他联系方式</h3>
                    <p>
                        <asp:Label ID="Label12" runat="server" Text="微信"></asp:Label>
                    </p>
             
                    <p>
                        <asp:Label ID="Label15" runat="server" Text="QQ"></asp:Label>
                    </p>

                     <p>
                        <asp:Label ID="Label11" runat="server" Text="微博"></asp:Label>
                    </p>
                </div>
              </div>

            <div id="rentsimilar" class="rentsimilar sideblock top_20">
                <h3 style="padding: 12px 18px;"> 类似房源</h3>
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

