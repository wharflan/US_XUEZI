<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="StudentCard.ascx.cs" Inherits="UsXuezi.UserControls.StudentCard" %>

<div id="Card" runat="server">
    <div id="longbar" class="studentcard_horizon" runat="server">
        <div id="studentavatar" class="studentavatar">
            <asp:ImageButton ID="Image1" CssClass="avatar" runat="server" />
        </div>
        <div id="studentinfo" class="studentinfo inner_sideblock">
            <div class=" floatright">
                <asp:Label ID="Label4" runat="server" Text="等级"></asp:Label>
            </div>
            <h2>
                <asp:Label ID="Label1" runat="server" Text="用户名"></asp:Label></h2>
            <!--直接显示签名内容本身，不显示“个性签名”此四字-->
            <div>
                <asp:Label ID="Label6" runat="server" class="sub_heading" Text="个性签名"></asp:Label>
            </div>

            <div class="expand">
                <div class="item floatleft">
                    <asp:Label ID="Label2" runat="server" Text="所在地"></asp:Label>
                </div>
                <div class="item floatleft">
                    <asp:Label ID="Label3" runat="server" Text="学校"></asp:Label>
                </div>
            </div>
            <asp:Button ID="Button1" runat="server" CssClass="border_button" Text="私信" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" CssClass="border_button" Text="关注" OnClick="Button2_Click" />
        </div>
    </div>

    <div id="shortbar" class="usercard_horizon" runat="server">
        <div id="sml_useravatar" class="useravatar">

            <asp:ImageButton ID="Image2" CssClass="avatar" runat="server" />
        </div>
        <div id="sml_userinfo" class="userinfo">

            <h2>
                <asp:Label ID="Label5" runat="server" Text="用户名字"></asp:Label></h2>

            <div>
                <asp:Label ID="Label7" runat="server" Text="所在地"></asp:Label>
            </div>

            <div>
                <asp:Label ID="Label8" runat="server" Text="毕业/就读于XXX大学"></asp:Label>
            </div>

            <div class="top_10">

                <div class="contact_buttons floatright" style="margin-top: 5px;">
                    <asp:Button ID="Button3" runat="server" CssClass="border_button" Text="私信" OnClick="Button1_Click" />
                    <asp:Button ID="Button4" runat="server" CssClass="border_button" Text="关注" OnClick="Button2_Click" />
                </div>

            </div>
        </div>
    </div>


</div>
