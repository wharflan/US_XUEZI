<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Job.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Title="招聘" Inherits="UsXuezi.Job" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="Css/JobPage.css" rel="stylesheet" />
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">

    <div id="renttitle" class="QuestionPart title_deco expand">
        <div class="col_66">
            <h1>
                <asp:Label ID="Label1" runat="server" class="big_heading" Text="招聘职位title"></asp:Label></h1>
            <p>
                <asp:Label ID="Label2" runat="server" class="sub_heading" Text="纽约曼哈顿 · 发布时间2014-09-10"></asp:Label>
            </p>
        </div>

        <div class="weibo_wechat col_33">
            <BBS:SocialIcons ID="SocialIcons2" runat="server"></BBS:SocialIcons>
        </div>
    </div>

    <div class="twoblock64">
        <div class="leftblock">
            <div>
                <asp:ImageButton ID="JobLogo" runat="server" />
            </div>

            <div class="bottom_20 inner_sideblock">

                <div class="floatleft" style="width: 270px;">
                    <asp:Label ID="Label3" runat="server" Text="性质 合同"></asp:Label>

                </div>

                <div class="floatleft" style="width: 270px;">
                    <asp:Label ID="Label4" runat="server" Text=" 薪酬 $2,000/月"></asp:Label>
                </div>

                <p>
                    <asp:Label ID="Label5" runat="server" Text=" 年资 2-4年"></asp:Label>
                </p>

                <p>
                    <asp:Label ID="Label7" runat="server" Text="申请 网址/邮箱"></asp:Label>
                </p>

                <p>
                    <asp:Label ID="Label8" runat="server" Text="截止时间"></asp:Label>
                </p>


            </div>

            <hr style="FILTER: alpha(opacity=100,finishopacity=0,style=1)" width="100%" color="#3c5a72" />

            <div class="text_content top_20">

                <p>
                    作范围+公司简介英语交流流利， 英语写作水平中上等，擅长用office软件，性格外向，善于沟通，懂得接电话礼貌用语（电话几乎都是英文交流）,有合法身
                </p>

                <div class="top_20">
                    <asp:Button ID="Button1" runat="server" class="red_button" Text="评论" /><asp:Button ID="Button2" runat="server" class="big_border_button" Style="margin-left: 12px;" Text="推荐朋友" />

                </div>
            </div>
        </div>
        <div class="rightblock">
            <div class="QAcontact">
                <BBS:StudentCard ID="StudentCard1" runat="server" Type="horizon"></BBS:StudentCard>

            </div>

            <div id="rentsimilar" class="sideblock top_20">
                <h3 style="padding: 12px 18px;">更多相关招聘</h3>
                <ul>

                    <li>
                        <asp:ImageButton ID="ImageButton0" runat="server" CssClass="thumb_img" />
                        <asp:LinkButton ID="LinkButton2" runat="server">LinkButton</asp:LinkButton></li>
                    <li>
                        <asp:ImageButton ID="ImageButton3" runat="server" CssClass="thumb_img" />
                        <asp:LinkButton ID="LinkButton3" runat="server">LinkButton</asp:LinkButton></li>
                    <li>
                        <asp:ImageButton ID="ImageButton4" runat="server" CssClass="thumb_img" />
                        <asp:LinkButton ID="LinkButton4" runat="server">LinkButton</asp:LinkButton></li>

                    <li>
                        <asp:ImageButton ID="ImageButton5" runat="server" CssClass="thumb_img" />
                        <asp:LinkButton ID="LinkButton5" runat="server">LinkButton</asp:LinkButton></li>
                    <li>
                        <asp:ImageButton ID="ImageButton6" runat="server" CssClass="thumb_img" />
                        <asp:LinkButton ID="LinkButton6" runat="server">LinkButton</asp:LinkButton></li>
                    <li>
                        <asp:ImageButton ID="ImageButton7" runat="server" CssClass="thumb_img" />
                        <asp:LinkButton ID="LinkButton7" runat="server">LinkButton</asp:LinkButton></li>

                </ul>
            </div>
        </div>
    </div>

</asp:Content>
