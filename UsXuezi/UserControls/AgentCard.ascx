<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AgentCard.ascx.cs" Inherits="UsXuezi.UserControls.AgentCard" %>


<div id="agentcard" class="usercard_horizon">
    <div id="agentavatar" class="useravatar">
        <asp:ImageButton ID="ImageButton1" runat="server" CssClass="avatar" />
    </div>
    <div id="agentinfo" class="userinfo">
      
        <h2><asp:Label ID="Label1" runat="server" Text="Cherry Yip"></asp:Label></h2>

        <div><asp:Label ID="Label2" runat="server" Text="Hamilton Real Estates Ltd."></asp:Label></div>

        <div><asp:Label ID="Label3" runat="server" Text="617-902-0683"></asp:Label></div>

      <div class= "top_10">
        <asp:Button ID="Button1" runat="server" CssClass="border_button" Text="私信" />
        <asp:Button ID="Button2" runat="server" CssClass="border_button " Text="关注" />
      </div>

    </div>
</div>