<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="BusinessFilter.ascx.cs" Inherits="UsXuezi.UserControls.Filters.BusinessFilter" %>

<div class="filter_content filter-box business-filter" style="padding: 0px">
    <div class="filter_item">
        <dl class="filter-business">
            <dt>商户：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="filter-business"><span>生活服务</span></label>
                <label class="m-ra"><input type="radio" name="filter-business"><span>娱乐休闲</span></label>
                <label class="m-ra"><input type="radio" name="filter-business"><span>旅游相关</span></label>
            </dd>
        </dl>
        <!-- <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:BosTon_BBSConnectionString1 %>' SelectCommand="SELECT * FROM [Tb_BusinessType]"></asp:SqlDataSource>
        <asp:Label ID="Label1" runat="server" Text="行业"></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="SqlDataSource1" DataTextField="BT_Content" DataValueField="BT_ID" AppendDataBoundItems="True">
            <asp:ListItem Selected="True" Value="0">全部行业</asp:ListItem>
        </asp:DropDownList>

        <asp:Label ID="Label2" runat="server" Text="排序"></asp:Label>
        <asp:DropDownList ID="DropDownList2" runat="server">
            <asp:ListItem Value="1">最新发布</asp:ListItem>
            <asp:ListItem Value="2">评价最高</asp:ListItem>
            <asp:ListItem Selected="True" Value="3">默认排序</asp:ListItem>
        </asp:DropDownList> -->


    </div>
    <div class="m-sort">
        <dl>
            <dt>排序方式：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="sortord"><span>最新发布</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord"><span>最高评价</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord"><span>提供优惠</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord" checked=""><span>默认排序</span></label>
            </dd>
        </dl>
    </div>
</div>
