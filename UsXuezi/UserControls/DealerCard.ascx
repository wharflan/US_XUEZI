<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="DealerCard.ascx.cs" Inherits="UsXuezi.UserControls.DealerCard" %>


<div id="dealercard" class="usercard_horizon">
    <div id="dealeravatar" class="useravatar">
        <asp:ImageButton ID="ImageButton1" runat="server" CssClass="avatar" />
    </div>
    <div id="dealerinfo" class="userinfo">
      
        <h2><asp:Label ID="Label1" runat="server" Text="车行名字"></asp:Label></h2>

        <div><asp:Label ID="Label2" runat="server" Text="车行地址"></asp:Label></div>

        <div><asp:Label ID="Label3" runat="server" Text="电话"></asp:Label></div>

      <div class= "top_10">
        <asp:Button ID="Button1" runat="server" CssClass="border_button" Text="私信" />
        <asp:Button ID="Button2" runat="server" CssClass="border_button " Text="关注" />
      </div>

    </div>
</div>