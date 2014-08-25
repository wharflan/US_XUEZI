<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MissingPage.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Title="出错啦！" Inherits="UsXuezi.MissingPage" %>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <div>
        <asp:Image ID="Image1" runat="server" ImageUrl="/Images/404报错.jpg" />
    </div>

    <div style="margin-top:20px;">
        <asp:LinkButton ID="LinkButton1" PostBackUrl="~/Default.aspx" Style="color: #0094ff;  font-size:xx-large; margin-left:370px;" runat="server">首页</asp:LinkButton>
        <asp:LinkButton ID="LinkButton2" OnClientClick="history.back(); return false;" Style="color: #0094ff;  font-size:xx-large; margin-left:70px;"  runat="server">上一页</asp:LinkButton>
    </div>
</asp:Content>
