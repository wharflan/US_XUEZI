<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ItemFilter.ascx.cs" Inherits="UsXuezi.UserControls.Filters.ItemFilter" %>
<div class="filter_content filter-box sh-filter" style="padding: 0px">
    <div class="filter_item">
        <dl class="filter-type">
            <dt>分类：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="filter-type"><span>衣鞋包饰</span></label>
                <label class="m-ra"><input type="radio" name="filter-type"><span>数码产品</span></label>
                <label class="m-ra"><input type="radio" name="filter-type"><span>家具/家居</span></label>
                <label class="m-ra"><input type="radio" name="filter-type"><span>书籍/出版物</span></label>
                <label class="m-ra"><input type="radio" name="filter-type"><span>其他</span></label>
            </dd>
        </dl>
        <dl class="filter-tradeMode">
            <dt>交易方式：</dt>
            <dd>
                <label class="m-cb"><input type="checkbox" name="filter-tradeMode"><span>面交</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-tradeMode"><span>邮寄</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-tradeMode"><span>自取</span></label>
                <label class="m-cb"><input type="checkbox" name="filter-tradeMode"><span>送达</span></label>
            </dd>
        </dl>
        <span class="divide"></span>
        <dl class="filter-quality">
            <dt>成色：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="filter-quality"><span>全新</span></label>
                <label class="m-ra"><input type="radio" name="filter-quality"><span>二手</span></label>
                <label class="m-ra"><input type="radio" name="filter-quality"><span>不限</span></label>
            </dd>
        </dl>
        <!-- <asp:Label ID="Label1" runat="server" Text="分类："></asp:Label>

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
        </asp:DropDownList> -->
    </div>
    <div class="m-sort">
        <dl>
            <dt>排序方式：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="sortord"><span>最新发布</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord"><span>最低价格</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord"><span>最高价格</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord" checked=""><span>默认排序</span></label>
            </dd>
        </dl>
    </div>
</div>
