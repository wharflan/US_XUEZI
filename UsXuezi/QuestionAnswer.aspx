<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuestionAnswer.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Title="问答专栏" Inherits="UsXuezi.QuestionAnswer" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="Css/QAPage.css" rel="stylesheet" />
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">

    <div id="renttitle" class="QuestionPart title_deco expand">
        <div class="col_66">
            <h1>
                <asp:Label ID="Label1" runat="server" class="big_heading" Text="我就上想问问本特利大学怎么样"></asp:Label></h1>
            <p>
                <asp:Label ID="Label2" runat="server" class="sub_heading" Text="发布时间2014-09-10 回答（n）"></asp:Label>
                <asp:LinkButton ID="LinkButton1" runat="server" Visible="false">编辑</asp:LinkButton>
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
                    <asp:Button ID="Button1" runat="server" class="red_button" Text="我来回答" OnClick="Button1_Click" />
                </p>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="False" UpdateMode="Conditional">
                    <ContentTemplate>
                        <div id="myanswer" class="myanswer" runat="server">
                            <BBS:Editor runat="server" ID="Editor1" Placeholder=" " />
                            <div>
                                <asp:Button ID="Button3" runat="server" class="border_button floatright left_5 top_10" Text="取消" OnClick="Button3_Click" />
                                <asp:Button ID="Button2" runat="server" class="border_button floatright left_5 top_10" Text="提交" OnClick="Button2_Click" />
                            </div>
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
                                            <span class="c-comments">99条评论</span>
                                            <span class="c-userful">有用(10)</span>
                                            <span class="">没有帮助(5)</span>
                                        </div>
                                        <div class="ans-comments">
                                            <ul class="comments-list">
                                                <li>
                                                    <div class="user-avatar"><img src="Images/user.png" alt="用户头像"></div>
                                                    <div class="main">
                                                        <a href="" class="username">熊猫叔叔</a>
                                                        <div class="content">
                                                            <p>非常简要的说明，没有。</p>
                                                            <p>奥巴马的医保政策全称是Patient Protection</p>
                                                        </div>
                                                        <span class="date">2014/08/05 22:59</span>
                                                        <span class="likes">1赞</span>
                                                    </div>
                                                </li>
                                                <li>
                                                    <div class="user-avatar"><img src="Images/user.png" alt="用户头像"></div>
                                                    <div class="main">
                                                        <a href="" class="username">熊猫叔叔</a>
                                                        <div class="content">
                                                            <p>非常简要的说明，没有。</p>
                                                            <p>奥巴马的医保政策全称是Patient Protection</p>
                                                        </div>
                                                        <span class="date">2014/08/05 22:59</span>
                                                        <span class="likes">1赞</span>
                                                    </div>
                                                </li>
                                            </ul>
                                            <div class="comment-box">
                                                <div class="cont">
                                                    <textarea name="" id="" placeholder="写下你的评论"></textarea>
                                                </div>
                                            </div>
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
                                            <span class="c-comments">99条评论</span>
                                            <span class="c-userful">有用(10)</span>
                                            <span class="">没有帮助(5)</span>
                                        </div>
                                        <div class="ans-comments">
                                            <ul class="comments-list">
                                                <li>
                                                    <div class="user-avatar"><img src="Images/user.png" alt="用户头像"></div>
                                                    <div class="main">
                                                        <a href="" class="username">熊猫叔叔</a>
                                                        <div class="content">
                                                            <p>非常简要的说明，没有。</p>
                                                            <p>奥巴马的医保政策全称是Patient Protection</p>
                                                        </div>
                                                        <span class="date">2014/08/05 22:59</span>
                                                        <span class="likes">1赞</span>
                                                    </div>
                                                </li>
                                                <li>
                                                    <div class="user-avatar"><img src="Images/user.png" alt="用户头像"></div>
                                                    <div class="main">
                                                        <a href="" class="username">熊猫叔叔</a>
                                                        <div class="content">
                                                            <p>非常简要的说明，没有。</p>
                                                            <p>奥巴马的医保政策全称是Patient Protection</p>
                                                        </div>
                                                        <span class="date">2014/08/05 22:59</span>
                                                        <span class="likes">1赞</span>
                                                    </div>
                                                </li>
                                            </ul>
                                            <div class="comment-box">
                                                <div class="cont">
                                                    <textarea name="" id="" placeholder="写下你的评论"></textarea>
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                </li>
                            </ul>
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Button1" />
                        <asp:AsyncPostBackTrigger ControlID="Button2" />
                        <asp:AsyncPostBackTrigger ControlID="Button3" />
                    </Triggers>
                </asp:UpdatePanel>

            </div>


        </div>

        <div class="rightblock">
            <div class="QAcontact">
                <BBS:StudentCard ID="StudentCard1" runat="server" Type="horizon"></BBS:StudentCard>
            </div>

            <div id="similar" class="sideblock top_20">
                <h3 style="padding: 12px 18px;">更多相关提问</h3>
                <ul class="rel-question">
                    <li><a href="">相关问题相关问题相关问题相关问题</a></li>
                    <li><a href="">相关问题相关问题相关问题相关问题</a></li>
                    <li><a href="">相关问题相关问题相关问题相关问题</a></li>
                    <li><a href="">相关问题相关问题相关问题相关问题</a></li>
                    <li><a href="">相关问题相关问题相关问题相关问题</a></li>
                    <li><a href="">相关问题相关问题相关问题相关问题</a></li>
                    <li><a href="">相关问题相关问题相关问题相关问题</a></li>
                    <li><a href="">相关问题相关问题相关问题相关问题</a></li>
                    <li><a href="">相关问题相关问题相关问题相关问题</a></li>
                    <li><a href="">相关问题相关问题相关问题相关问题</a></li>
                </ul>
            </div>
        </div>

        <script>
        $(function(){
            $('#ContentHolder_myanswer').remove();
            $('.c-comments').click(function(ev){
                $(this).parents('.m-answer').toggleClass('show-comments');
            });
        });
        </script>
    </div>
</asp:Content>

