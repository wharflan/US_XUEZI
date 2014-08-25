<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UsXuezi.WebForm1" MasterPageFile="~/MainMasterPage.Master" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <script type="text/javascript" src="/jquery/jquery.js"></script>
    <script type="text/javascript">
        $(document).ready(function () {
            $("button").toggle(function () {
                $("body").css("background-color", "green");
            },
              function () {
                  $("body").css("background-color", "red");
              },
              function () {
                  $("body").css("background-color", "yellow");
              }
            );
        });
    </script>

</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="top_90">

        <button>请点击这里，来切换不同的背景颜色</button>
    </div>
    <BBS:BusinessFilter runat="server" ID="Busin" />
</asp:Content>
