<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="RentFilter.ascx.cs" Inherits="UsXuezi.UserControls.Filters.RentFilter" %>

<div class="filter_content filter-box rent-filter" style="padding: 0px">
    <div class="filter_item">
        <dl class="filter-region">
            <dt>地区：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Boston</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Cambridge</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Quincy</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Waltham</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Newton</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Dochestor</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Boston</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Cambridge</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Quincy</span></label>
                <label class="m-ra"><input type="radio" name="filter-region"><span>Waltham</span></label>
            </dd>
        </dl>
        <dl class="filter-type">
            <dt>类型：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="filter-type"><span>单间</span></label>
                <label class="m-ra"><input type="radio" name="filter-type"><span>整套</span></label>
                <label class="m-ra"><input type="radio" name="filter-type"><span>不限</span></label>
            </dd>
        </dl>
        <span class="divide"></span>
        <dl class="filter-agent">
            <dt>中介房源：</dt>
            <dd>
                <label class="m-ra"><input type="radio" name="filter-agent"><span>是</span></label>
                <label class="m-ra"><input type="radio" name="filter-agent"><span>否</span></label>
                <label class="m-ra"><input type="radio" name="filter-agent"><span>不限</span></label>
            </dd>
        </dl>
        <span class="divide"></span>
        <dl class="filter-checkinDate">
            <dt>入住日期：</dt>
            <dd><input type="text" value="" class="input-s"></dd>
        </dl>

        <!-- <asp:Label ID="Label1" runat="server" Text="地区："></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:BosTon_BBSConnectionString1 %>' SelectCommand="SELECT * FROM [Tb_Area] WHERE ([Area_CityID] = @Area_CityID)">
            <SelectParameters>
                <asp:SessionParameter SessionField="City_ID" DefaultValue="1" Name="Area_CityID" Type="Int32"></asp:SessionParameter>
            </SelectParameters>
        </asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList5" runat="server" DataSourceID="SqlDataSource1" DataTextField="Area_Name" DataValueField="Area_ID" AppendDataBoundItems="True">

            <asp:ListItem Value="0">所有地区</asp:ListItem>
        </asp:DropDownList>
        <div runat="server" id="areapart"></div>
        <br />
        <asp:Label ID="Label2" runat="server" Text="筛选："></asp:Label>
        <asp:DropDownList ID="DropDownList1" runat="server">
            <asp:ListItem Value="1">单间</asp:ListItem>
            <asp:ListItem Value="2">整套</asp:ListItem>
        </asp:DropDownList>
        <script>
            $(function () {
                $("#<%=TextBox1.ClientID%>").datepicker();
            });
        </script>
        <link rel="stylesheet" href="/Script/jquery.custom/jquery-ui.css">
        <script src="/Script/jquery.custom/jquery-ui.js"></script>

        <asp:Label ID="Label3" runat="server" Text="起租时间"></asp:Label>
        <asp:TextBox ID="TextBox1" Width="100px" runat="server" ReadOnly="False"></asp:TextBox>
        <asp:Label ID="Label4" runat="server" Text="经纪人房源"></asp:Label>
        <asp:DropDownList ID="DropDownList3" runat="server">
            <asp:ListItem Value="0" Selected="True">不限</asp:ListItem>
            <asp:ListItem Value="1">是</asp:ListItem>
            <asp:ListItem Value="2">否</asp:ListItem>
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
                <label class="m-ra"><input type="radio" name="sortord"><span>最低租金</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord"><span>最高租金</span></label>
                <span class="divide"></span>
                <label class="m-ra"><input type="radio" name="sortord" checked=""><span>默认排序</span></label>
            </dd>
        </dl>
    </div>
    <script>
        $(function(){
            $(".filter-checkinDate input").datepicker();
        });
    </script>
    <link rel="stylesheet" href="/Script/jquery.custom/jquery-ui.css">
    <script src="/Script/jquery.custom/jquery-ui.js"></script>
</div>
