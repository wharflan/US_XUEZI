<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Title="首页" Inherits="UsXuezi.Default" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link rel="stylesheet" href="Css/HomePage.css" />
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">

    <script type="text/javascript">
        $(document).ready(function () {
            $("#cityicons").mouseover(function () {
                $("#plates").stop(true,false);
                $("#plates").fadeIn(speed());
            });

            $("#cityicons").mouseout(function () {
                $("#plates").fadeOut(speed());
            });

            var speed = function () {
                return $.isNumeric($("#tb313").val()) ? parseInt($("#tb313").val()) : 300;
            }
        });
    </script>
    <div id="cityicons" class="cityicons blockstyle">
        <p>
            <asp:Label ID="Label1" runat="server" Text="选择您所在的城市"></asp:Label>
        </p>

        <BBS:CityIcon ID="BOSIcon" runat="server" CityName="波士顿" Class="cityicon" />
        <BBS:CityIcon ID="NYIcon" runat="server" CityName="纽约" Class="cityicon" />
        <BBS:CityIcon ID="CCGIcon" runat="server" CityName="芝加哥" Class="cityicon" />
        <BBS:CityIcon ID="LAIcon" runat="server" CityName="洛杉矶" Class="cityicon" />
        <BBS:CityIcon ID="SFIcon" runat="server" CityName="三藩市" Class="cityicon" />

        <asp:Label ID="Label3" runat="server" Text="zheli"></asp:Label>

        <div class="fix-clear"></div>
        <div id="plates" class="plates" style="display: none">
            <asp:Button ID="Button1" runat="server" Text="热门话题" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="二手市场" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="房屋租转" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="房产交易" OnClick="Button4_Click" />
            <asp:Button ID="Button5" runat="server" Text="美食餐饮" OnClick="Button5_Click" />
            <asp:Button ID="Button6" runat="server" Text="商家机构" OnClick="Button6_Click" />
            <asp:Button ID="Button7" runat="server" Text="问答专栏" OnClick="Button7_Click" />
            <asp:Button ID="Button8" runat="server" Text="吹水吐槽" OnClick="Button8_Click" />
        </div>
    </div>

    <div id="HotIssues" class="blockstyle">
        <p>
            <asp:Label ID="Label2" runat="server" Text="热门话题"></asp:Label>
        </p>
        <BBS:HotIssueBlock ID="HotIssueBlock1" runat="server" Name="A" />
        <BBS:HotIssueBlock ID="HotIssueBlock2" runat="server" Name="B" />
        <BBS:HotIssueBlock ID="HotIssueBlock3" runat="server" Name="C" />
        <BBS:HotIssueBlock ID="HotIssueBlock4" runat="server" Name="D" />
        <BBS:HotIssueBlock ID="HotIssueBlock5" runat="server" Name="E" />
        <BBS:HotIssueBlock ID="HotIssueBlock6" runat="server" Name="F" />
    </div>
</asp:Content>
