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
    <div class="city-catalog blockstyle">
        <div class="m-hd">
            <asp:Label ID="Label1" runat="server" Text="选择您所在的城市" Class="text-l"></asp:Label>
            <asp:Label ID="Label3" runat="server" Text="zheli" Class="text-r"></asp:Label>
        </div>
        <div class="m-bd">
            <div class="cities">
                <div class="city boston">
                    <a href="" class="icon"></a>
                    <p class="name">波士顿</p>
                    <ul class="info-list">
                        <li><a href="">热门话题</a></li>
                        <li><a href="">二手市场</a></li>
                        <li><a href="">房屋租转</a></li>
                        <li><a href="">问答专栏</a></li>
                    </ul>
                </div>
                <div class="city newYork">
                    <a href="" class="icon"></a>
                    <p class="name">纽约</p>
                    <ul class="info-list">
                        <li><a href="">热门话题</a></li>
                        <li><a href="">二手市场</a></li>
                        <li><a href="">房屋租转</a></li>
                        <li><a href="">问答专栏</a></li>
                        <li><a href="">吹水吐槽</a></li>
                    </ul>
                </div>
                <div class="city chicago">
                    <a href="" class="icon"></a>
                    <p class="name">芝加哥</p>
                    <ul class="info-list">
                        <li><a href="">热门话题</a></li>
                        <li><a href="">二手市场</a></li>
                        <li><a href="">房屋租转</a></li>
                        <li><a href="">房产交易</a></li>
                    </ul>
                </div>
                <div class="city la">
                    <a href="" class="icon"></a>
                    <p class="name">洛杉矶</p>
                    <ul class="info-list">
                        <li><a href="">热门话题</a></li>
                        <li><a href="">二手市场</a></li>
                        <li><a href="">房屋租转</a></li>
                        <li><a href="">房产交易</a></li>
                        <li><a href="">美食餐饮</a></li>
                        <li><a href="">商家机构</a></li>
                    </ul>
                </div>
                <div class="city sfo">
                    <a href="" class="icon"></a>
                    <p class="name">三藩市</p>
                    <ul class="info-list">
                        <li><a href="">热门话题</a></li>
                        <li><a href="">二手市场</a></li>
                        <li><a href="">房屋租转</a></li>
                        <li><a href="">房产交易</a></li>
                        <li><a href="">美食餐饮</a></li>
                    </ul>
                </div>
                <a class="moreCity" href="">
                    <div class="wrap">
                        <p>更多城市</p>
                        <p>Coming Soon</p>
                    </div>
                </a>
            </div>
        </div>
    </div>

    <div id="HotIssues">
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
