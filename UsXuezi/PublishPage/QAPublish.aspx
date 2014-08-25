<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QAPublish.aspx.cs" Title="问答专栏发布页" MasterPageFile="~/MainMasterPage.Master" Inherits="UsXuezi.PublishPage.QAPublish" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="/Css/PublishPage.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="msform top_50">
        <fieldset>
            <div class="col_100">
                <div class="floatleft" style="width: 642px;">
                    <asp:Label ID="Label2" runat="server" class="sub_heading" Style="text-align: left;" Text="提问"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Style="width: 545px; padding: 5px; font-size: 16px;" placeholder="如“西岸读UI/US设计哪个学校比较好？”"></asp:TextBox>
                </div>
                <div class=" fix-clear floatleft">
                    <asp:Button ID="Button1" CssClass="border_button top_25" runat="server" Text="问题补充" OnClick="Button1_Click" />

                </div>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
                    <ContentTemplate>
                        <div class="floatleft fix-clear editor top_20" id="editorblock" runat="server">
                            <BBS:Editor ID="Editor1" runat="server" Placeholder=" " />
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Button1" />
                        <asp:AsyncPostBackTrigger ControlID="Button4" />
                        <asp:AsyncPostBackTrigger ControlID="Button5" />
                    </Triggers>

                </asp:UpdatePanel>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="true">
                    <ContentTemplate>

                        <div id="tagshow" class="floatleft fix-clear" style="width: 500px" runat="server">
                            <div class="fix-clear"></div>

                            <asp:Label ID="Label5" Width="80px" runat="server" Text="已选标签："></asp:Label>

                            <BBS:Tags ID="tags1" Type="edit" Maxnum="5" runat="server" />

                        </div>

                        <div id="defaulttag" class="sub_heading" style="text-align: left;" runat="server">
                            <div class="fix-clear"></div>
                            <asp:Label ID="Label4" Width="120px" CssClass="top_20" runat="server" Text="点击选择标签："></asp:Label>

                            <div class="fix-clear"></div>
                            <asp:Button ID="Button6" runat="server" CssClass="border_button" OnClick="addtag" Text="纽约" />
                            <asp:Button ID="Button7" runat="server" CssClass="border_button" OnClick="addtag" Text="洛杉矶" />
                            <asp:Button ID="Button8" runat="server" CssClass="border_button" OnClick="addtag" Text="旧金山" />
                            <asp:Button ID="Button9" runat="server" CssClass="border_button" OnClick="addtag" Text="波士顿" />
                            <asp:Button ID="Button10" runat="server" CssClass="border_button" OnClick="addtag" Text="芝加哥" />
                            <asp:Button ID="Button11" runat="server" CssClass="border_button" OnClick="addtag" Text="生活" />
                            <asp:Button ID="Button12" runat="server" CssClass="border_button" OnClick="addtag" Text="工作" />
                            <asp:Button ID="Button4" runat="server" CssClass="border_button" OnClick="addtag" Text="学习" />
                            <asp:Button ID="Button13" runat="server" CssClass="border_button" OnClick="addtag" Text="学术" />
                            <asp:Button ID="Button14" runat="server" CssClass="border_button" OnClick="addtag" Text="购物" />
                            <asp:Button ID="Button15" runat="server" CssClass="border_button" OnClick="addtag" Text="法律" />
                            <asp:Button ID="Button16" runat="server" CssClass="border_button" OnClick="addtag" Text="商务" />
                            <asp:Button ID="Button17" runat="server" CssClass="border_button" OnClick="addtag" Text="居住" />
                            <asp:Button ID="Button18" runat="server" CssClass="border_button" OnClick="addtag" Text="饮食" />
                            <asp:Button ID="Button19" runat="server" CssClass="border_button" OnClick="addtag" Text="旅游" />
                            <asp:Button ID="Button20" runat="server" CssClass="border_button" OnClick="addtag" Text="汽车" />
                            <asp:Button ID="Button21" runat="server" CssClass="border_button" OnClick="addtag" Text="体育" />
                            <asp:Button ID="Button22" runat="server" CssClass="border_button" OnClick="addtag" Text="游戏" />
                            <asp:Button ID="Button23" runat="server" CssClass="border_button" OnClick="addtag" Text="娱乐" />
                            <asp:Button ID="Button24" runat="server" CssClass="border_button" OnClick="addtag" Text="政治" />
                            <asp:Button ID="Button25" runat="server" CssClass="border_button" OnClick="addtag" Text="文化" />
                            <asp:Button ID="Button26" runat="server" CssClass="border_button" OnClick="addtag" Text="语言" />

                        </div>
                        <div id="tagblock" class="floatleft fix-clear top_15" style="text-align: left" runat="server">
                            <asp:Label ID="Label1" Width="100px" runat="server" Text="自定义标签："></asp:Label>

                            <asp:TextBox ID="TextBox1" Style="width: 250px; padding: 3px; font-size: 16px; height: 20px" placeholder="请在20字以内" runat="server"></asp:TextBox>
                            <asp:Button ID="Button5" runat="server" CssClass="border_button" Text="确定" OnClick="Button5_Click" />
                            <asp:Label ID="Label3" runat="server" CssClass="floatleft" Width="100px" Text=""></asp:Label>

                        </div>

                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Button1" />
                        <asp:AsyncPostBackTrigger ControlID="Button4" />
                        <asp:AsyncPostBackTrigger ControlID="Button5" />
                    </Triggers>
                </asp:UpdatePanel>

            </div>
            <asp:Button ID="Button3" runat="server" class="submit red_button floatleft" Style="margin-top: -48px; margin-left: 762px;" Text="预览" OnClientClick="GetContents()" OnClick="Button3_Click" />
            <asp:Button ID="Button2" runat="server" class="submit red_button floatleft left_5" Style="margin-top: -48px;" Text="发布" OnClientClick="GetContents()" OnClick="Button2_Click" />
        </fieldset>
    </div>
</asp:Content>

