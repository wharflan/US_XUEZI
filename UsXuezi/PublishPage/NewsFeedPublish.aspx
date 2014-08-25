<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="NewsFeedPublish.aspx.cs" Title="问答专栏发布页" MasterPageFile="~/MainMasterPage.Master" Inherits="UsXuezi.PublishPage.NewsFeedPublish" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="/Css/PublishPage.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="msform top_50">
        <fieldset>
            <div class="col_100">
                <div class="floatleft" style="width: 642px;">
                    <asp:Label ID="Label2" runat="server" class="sub_heading" Style="text-align: left;" Text="标题"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Style="width: 545px; padding: 5px; font-size: 16px;" placeholder="如“西岸读UI/US设计哪个学校比较好？”"></asp:TextBox>
                </div>
                <div class=" fix-clear floatleft">
                </div>
                <div class="floatleft fix-clear editor top_20">
                            <BBS:Editor ID="Editor1" runat="server" Placeholder=" " />
                        </div>
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
                    <ContentTemplate>
                        <div id="tagblock" class="floatleft fix-clear" runat="server">
                            <asp:Button ID="Button4" CssClass="red_button" runat="server" Text="添加Tag" OnClick="Button4_Click" />
                            <asp:TextBox ID="TextBox1" Style="margin-left: 100px; width: 318px; padding: 5px; font-size: 16px; height: 40px" placeholder="请在20字以内" runat="server"></asp:TextBox>
                            <asp:Button ID="Button5" runat="server" CssClass="red_button" Text="确定" OnClick="Button5_Click" />
                        </div>
                        <div>
                            <asp:Label ID="Label1" runat="server" Style="width: 300px; margin-top: 30px; font-size: 20px;" Text=""></asp:Label>
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Button4" />
                        <asp:AsyncPostBackTrigger ControlID="Button5" />
                    </Triggers>
                </asp:UpdatePanel>

            </div>
            <div style="margin-top: -80px; float: left; margin-left: 762px;">
                <asp:Button ID="Button3" runat="server" class="submit red_button floatleft" Text="预览" OnClientClick="GetContents()" OnClick="Button3_Click" />
                <asp:Button ID="Button2" runat="server" class="submit red_button floatleft left_5" Text="发布" OnClientClick="GetContents()" OnClick="Button2_Click" />

            </div>
        </fieldset>
    </div>
</asp:Content>

