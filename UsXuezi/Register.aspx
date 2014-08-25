<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Title="注册" Inherits="UsXuezi.PublishPage.Register" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="/Css/PublishPage.css" rel="stylesheet" />
    <link href="/Css/UsXueziCss.css" rel="stylesheet" />
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="msform top_50">
        <fieldset>

            <asp:Label ID="Label6" runat="server" Text="我是"></asp:Label>

            <div class="floatleft">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" CellPadding="4" CellSpacing="4" Width="300px">
                    <asp:ListItem Text="个人用户" Value="1"></asp:ListItem>
                    <asp:ListItem Text="商家/机构用户" Value="2"></asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div>
                <div class="long_item floatleft">
                    <asp:Label ID="Label15" runat="server" Text="注册邮箱"></asp:Label><asp:TextBox ID="TextBox8" CssClass="basic-input" runat="server"></asp:TextBox>
                    <div class="note floatleft" style="line-height: 35px;">*如已注册，请<a herf="#">登录</a></div>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label9" runat="server" Text="密码"></asp:Label>
                    <asp:TextBox ID="TextBox2" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label1" runat="server" Text="确认密码"></asp:Label>
                    <asp:TextBox ID="TextBox1" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

                <!--如个人用户不显示此项-->
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
                    <ContentTemplate>
                        <div class="long_item floatleft" id="specialblock" runat="server">
                            <asp:Label ID="Label3" runat="server" Text="机构类别"></asp:Label>
                            <asp:DropDownList ID="DropDownList1" Style="width: 262px;" CssClass="basic-input" runat="server">
                                <asp:ListItem>车行Dealer</asp:ListItem>
                                <asp:ListItem>餐饮商家</asp:ListItem>
                                <asp:ListItem>本地商家</asp:ListItem>
                                <asp:ListItem>地产经纪</asp:ListItem>
                            </asp:DropDownList>
                            <div class="note floatleft" style="line-height: 35px;">*不同机构类别可获得对应的额外功能与权限。</div>
                        </div>
                        <div class="item floatleft">
                            <asp:Label ID="Label2" runat="server" Text="机构名称"></asp:Label>
                            <asp:TextBox ID="TextBox3" CssClass="basic-input" runat="server"></asp:TextBox>
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="RadioButtonList1" />
                    </Triggers>
                </asp:UpdatePanel>



                <div class="item floatleft">
                    <asp:Label ID="Label4" runat="server" Text="所在城市"></asp:Label>
                    <asp:DropDownList ID="DropDownList2" Style="width: 262px;" CssClass="basic-input" runat="server">
                        <asp:ListItem>波士顿</asp:ListItem>
                        <asp:ListItem>纽约</asp:ListItem>
                        <asp:ListItem>芝加哥</asp:ListItem>
                        <asp:ListItem>洛杉矶</asp:ListItem>
                        <asp:ListItem>三藩市</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label5" runat="server" Text="验证码"></asp:Label>
                    <asp:TextBox ID="TextBox5" CssClass="basic-input" Width="135px" runat="server"></asp:TextBox>
                    <asp:Image ID="Image1" ImageUrl="/UserControls/ValidateCode.aspx" Style="float: left;" Height="32" runat="server" />
                </div>

            </div>

            <asp:Button ID="Button1" OnClick="Button1_Click" class="submit red_button floatright" runat="server" Text="注册" />
        </fieldset>
    </div>
</asp:Content>
