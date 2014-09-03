<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Person.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Title="个人主页" Inherits="UsXuezi.Person" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link rel="stylesheet" href="Css/personal.css" />   
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">

    <div id="studentinfo" class="top_50 studentinfo mh">
        <BBS:StudentCard ID="StudentCard1" runat="server" CardType="long" />
    </div>

    <div class="mc">
        <div class="m-side">
            <div id="myinfo" class="sideblock" style="min-height: 118px;">
                <h3 style="padding: 12px 18px;">个人档案</h3>
                <div class="inner_sideblock">
                    <p>
                        <asp:Label ID="Label9" runat="server" Text="性别"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label3" runat="server" Text="生日"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label4" runat="server" Text="QQ"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label5" runat="server" Text="邮箱"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label6" runat="server" Text="微博"></asp:Label>
                    </p>
                    <p>
                        <asp:Label ID="Label8" runat="server" Text="微信"></asp:Label>
                    </p>
                </div>
            </div>
            <div id="myfollow" class="sideblock" style="min-height: 218px; display: inline-block;">
                <h3 style="padding: 12px 18px;">用户名关注</h3>
                <div style="margin-left: 13px;">
                    <ul class="fix-clear">

                        <li class="following_list">
                            <asp:ImageButton ID="ImageButton1" runat="server" CssClass="sml_thumb_img" />
                            <asp:LinkButton ID="LinkButton5" runat="server" CssClass="following_name">用户名</asp:LinkButton>

                        </li>

                        <li class="following_list">
                            <asp:ImageButton ID="ImageButton2" runat="server" CssClass="sml_thumb_img" />
                            <asp:LinkButton ID="LinkButton6" runat="server" CssClass="following_name">用户名</asp:LinkButton>

                        </li>

                        <li class="following_list">
                            <asp:ImageButton ID="ImageButton6" runat="server" CssClass="sml_thumb_img" />
                            <asp:LinkButton ID="LinkButton12" runat="server" CssClass="following_name">用户名</asp:LinkButton>

                        </li>

                        <li class="following_list">
                            <asp:ImageButton ID="ImageButton7" runat="server" CssClass="sml_thumb_img" />
                            <asp:LinkButton ID="LinkButton13" runat="server" CssClass="following_name">用户名</asp:LinkButton>

                        </li>

                        <li class="following_list">
                            <asp:ImageButton ID="ImageButton8" runat="server" CssClass="sml_thumb_img" />
                            <asp:LinkButton ID="LinkButton14" runat="server" CssClass="following_name">用户名</asp:LinkButton>

                        </li>

                        <li class="following_list">
                            <asp:ImageButton ID="ImageButton9" runat="server" CssClass="sml_thumb_img" />
                            <asp:LinkButton ID="LinkButton15" runat="server" CssClass="following_name">用户名</asp:LinkButton>

                        </li>

                        <li class="following_list">
                            <asp:ImageButton ID="ImageButton10" runat="server" CssClass="sml_thumb_img" />
                            <asp:LinkButton ID="LinkButton16" runat="server" CssClass="following_name">用户名</asp:LinkButton>

                        </li>

                        <li class="following_list">
                            <asp:ImageButton ID="ImageButton11" runat="server" CssClass="sml_thumb_img" />
                            <asp:LinkButton ID="LinkButton17" runat="server" CssClass="following_name">用户名</asp:LinkButton>

                        </li>
                    </ul>
                </div>
            </div>
        </div>
        <div class="m-main">
            <div class="activities clearfix">
                <div id="mypublish" class="box-ac">
                    <div class="box-ac-hd">
                        <asp:Label ID="Label7" runat="server" class="title" Text="用户名的发布"></asp:Label>
                    </div>
                    <div id="publishpart" runat="server" class="box-ac-bd">
                    </div>
                </div>
                <div id="myreply" class="box-ac">
                    <div class="box-ac-hd">
                        <asp:Label ID="Label1" runat="server" class="title" Text="用户名的评论"></asp:Label>
                    </div>
                    <div id="replypart" runat="server" class="box-ac-bd">
                    </div>
                </div>
                <div id="mycollected" class="box-ac">
                    <div class="box-ac-hd">
                        <span id="ContentHolder_Label1" class="title">Lancev5的收藏</span>
                    </div>
                    <div id="collectedpart" class="box-ac-bd">
                        <a href="" class="item">超高性价比房子超高性价比房子超高性价比房子超高性价比房子</a>
                        <a href="" class="item">超高性价比房子超高性</a>
                        <a href="" class="item">超高性价比房子超高性比房子超高性</a>
                        <a href="" class="item">超高性价比房子超高性价比房子超高性价比房子超高性价比房子</a>
                        <a href="" class="item">超高性价比房子超高性</a>
                        <a href="" class="item">超高性价比房子超高性比房子超高性</a>
                        <a href="" class="item">超高性价比房子超高性价比房子超高性价比房子超高性价比房子</a>
                        <a href="" class="item">超高性价比房子超高性</a>
                        <a href="" class="item">超高性价比房子超高性比房子超高性</a>
                        <a href="" class="item">超高性价比房子超高性价比房子超高性价比房子超高性价比房子</a>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


