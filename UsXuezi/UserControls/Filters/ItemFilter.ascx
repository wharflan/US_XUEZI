<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemFilter.ascx.cs" Inherits="UsXuezi.UserControls.Filters.ItemFilter" %>
<div class="filter_content" style="padding: 0px">
    <div class="filter_item">
        <asp:Label ID="Label1" runat="server" Text="分类："></asp:Label>

        <asp:DropDownList ID="DropDownList5" runat="server">            
            <asp:ListItem>全部</asp:ListItem>
            <asp:ListItem>衣鞋包饰</asp:ListItem>
            <asp:ListItem>数码产品</asp:ListItem>
            <asp:ListItem>家具/家居</asp:ListItem>
            <asp:ListItem>书籍/影视/音乐</asp:ListItem>
            <asp:ListItem>美容/保健</asp:ListItem>
            <asp:ListItem>折扣/会员卡</asp:ListItem>
            <asp:ListItem>其他</asp:ListItem>
        </asp:DropDownList>
        <asp:Label ID="Label2" runat="server" Text="收取方式："></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">            
            <asp:ListItem Value="0">全部</asp:ListItem>
            <asp:ListItem Value="1">自取</asp:ListItem>
            <asp:ListItem Value="2">邮寄</asp:ListItem>
        </asp:DropDownList>

        <asp:Label ID="Label3" runat="server" Text="新旧程度："></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server">          
            <asp:ListItem Value="0">全部</asp:ListItem>
            <asp:ListItem Value="1">全新</asp:ListItem>
            <asp:ListItem Value="2">二手</asp:ListItem>
        </asp:DropDownList>
        
        <asp:Label ID="Label5" runat="server" Text="排序："></asp:Label>
        <asp:DropDownList ID="DropDownList4" runat="server">
            <asp:ListItem Value="1">最新发布</asp:ListItem>
            <asp:ListItem Value="2">由低到高</asp:ListItem>
            <asp:ListItem Value="3">由高到低</asp:ListItem>
            <asp:ListItem Selected="True" Value="4">默认排序</asp:ListItem>
        </asp:DropDownList>
    </div>
</div>
