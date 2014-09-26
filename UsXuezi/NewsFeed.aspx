<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsFeed.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Title="杂谈" Inherits="UsXuezi.NewsFeed" %>

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

                <div class="reply-box">
                    <div class="inp-textBlock">
                        <textarea name="" id=""></textarea>
                    </div>
                    <button class="red_button">回复</button>
                </div>
                <div class="answer-box">
                    <ul>
                        <li class="m-answer">
                            <div class="user-avatar"><img src="Images/user.png" alt="用户头像"></div>
                            <div class="main">
                                <a href="" class="username">林肯叔叔</a>
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
                <h3 style="padding: 12px 18px;">更多相关文章</h3>
                <ul class="rel-question">
                    <li><a href="">相关文章相关文章相关文章相关文章</a></li>
                    <li><a href="">相关文章相关文章相关文章相关文章</a></li>
                    <li><a href="">相关文章相关文章相关文章相关文章</a></li>
                    <li><a href="">相关文章相关文章相关文章相关文章</a></li>
                    <li><a href="">相关文章相关文章相关文章相关文章</a></li>
                    <li><a href="">相关文章相关文章相关文章相关文章</a></li>
                    <li><a href="">相关文章相关文章相关文章相关文章</a></li>
                    <li><a href="">相关文章相关文章相关文章相关文章</a></li>
                    <li><a href="">相关文章相关文章相关文章相关文章</a></li>
                    <li><a href="">相关文章相关文章相关文章相关文章</a></li>
                </ul>
            </div>
        </div>
    </div>
</asp:Content>


