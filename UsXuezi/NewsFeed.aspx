﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsFeed.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Title="杂谈" Inherits="UsXuezi.NewsFeed" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="Css/QAPage.css" rel="stylesheet" />
    <style type="text/css">
        #TextArea1 {
            width: 680px;
        }
    </style>
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <div id="renttitle" class="QuestionPart title_deco expand">
        <div class="col_66">
            <h1>
                <asp:Label ID="Label1" runat="server" class="big_heading" Text="我就上想问问本特利大学怎么样"></asp:Label></h1>
            <p>
                <asp:Label ID="Label2" runat="server" class="sub_heading" Text="发布时间2014-09-10 回答（n）"></asp:Label>
            </p>
        </div>

        <div class="weibo_wechat col_33">
            <BBS:SocialIcons ID="SocialIcons2" runat="server"></BBS:SocialIcons>
        </div>

    </div>

    <div class="twoblock64">
        <div class="leftblock">
            <div class="text_content">
                <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>

                <div id="tagblock" style="margin-top: 30px;" runat="server">
                    <span>Tags:</span>
                </div>

                <p>
                    <asp:Button ID="Button1" runat="server" class="red_button" Text="回复" OnClick="Button1_Click" />
                </p>

                <div id="myanswer" class="myanswer" visible="false" runat="server">
                    <asp:ImageButton ID="ImageButton1" runat="server" CssClass="avatar" />
                    <textarea id="QnA_answer" rows="7" runat="server"></textarea>
                    <div>
                        <asp:Button ID="Button3" runat="server" class="border_button floatright left_5 top_10" Text="取消" OnClick="Button3_Click" />
                        <asp:Button ID="Button2" runat="server" class="border_button floatright left_5 top_10" Text="提交" OnClick="Button2_Click" />
                    </div>
                </div>
            </div>

            <div id="AnswerPart" class="AnswerPart" runat="server">
            </div>
        </div>

        <div class="rightblock">
            <div class="QAcontact">
                <BBS:StudentCard ID="StudentCard1" runat="server" Type="horizon"></BBS:StudentCard>
            </div>

            <div id="similar" class="sideblock top_20">
                <h3 style="padding: 12px 18px;">更多相关提问</h3>
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


