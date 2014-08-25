<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EditPerson.aspx.cs" Title="编辑个人资料" MasterPageFile="~/MainMasterPage.Master" Inherits="UsXuezi.EditPerson" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="/Css/PublishPage.css" rel="stylesheet" />
    <link href="/Css/UsXueziCss.css" rel="stylesheet" />
    <link rel="stylesheet" href="/Script/jquery.custom/jquery-ui.css" />
    <script>
        $(function () {
            $("#<%=TextBox3.ClientID%>").datepicker();
        });
    </script>
    <script src="/Script/jquery.custom/jquery-ui.js"></script>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="msform top_50">
        <fieldset>
            <div class="sub_heading">
                <asp:Label ID="Label15" runat="server" class="sub_heading" Text="编辑资料"></asp:Label>
                <div class="fix-clear"></div>
            </div>
            <div>
                <div class="item floatleft">
                    <asp:Label ID="Label12" runat="server" Text="用户名"></asp:Label><asp:TextBox ID="TextBox8" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:BosTon_BBSConnectionString1 %>' SelectCommand="SELECT * FROM [Tb_City]"></asp:SqlDataSource>
                <div class="item floatleft">
                    <asp:Label ID="Label2" runat="server" Text="城市"></asp:Label><asp:DropDownList ID="DropDownList1" CssClass="basic-input" runat="server" DataSourceID="SqlDataSource1" DataTextField="City_NameCH" DataValueField="City_ID"></asp:DropDownList>
                </div>

                <div class="long_item floatleft">
                    <asp:Label ID="Label13" runat="server" Text="个性签名"></asp:Label><asp:TextBox ID="TextBox12" CssClass="basic-input" Width="70%" runat="server"></asp:TextBox>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label3" runat="server" Text="生日"></asp:Label><asp:TextBox ID="TextBox3" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label4" runat="server" Text="性别"></asp:Label>
                    <asp:DropDownList ID="DropDownList2" runat="server" CssClass="basic-input">
                        <asp:ListItem Text="保密" Value="0"></asp:ListItem>
                        <asp:ListItem Text="男" Value="1"></asp:ListItem>
                        <asp:ListItem Text="女" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="item floatleft">
                    <asp:Label ID="Label8" runat="server" Text="专业"></asp:Label><asp:TextBox ID="TextBox9" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>


                <div class="item floatleft">
                    <asp:Label ID="Label10" runat="server" Text="学校"></asp:Label><asp:TextBox ID="TextBox10" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label5" runat="server" Text="QQ"></asp:Label><asp:TextBox ID="TextBox5" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label6" runat="server" Text="微信"></asp:Label><asp:TextBox ID="TextBox6" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label7" runat="server" Text="微博"></asp:Label><asp:TextBox ID="TextBox7" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label14" runat="server" Text="电话"></asp:Label><asp:TextBox ID="TextBox13" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

            </div>

            <asp:Button ID="Button1" class="submit red_button floatright" OnClick="Button1_Click" runat="server" Text="确定" />
        </fieldset>
    </div>
</asp:Content>
