<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CityIcon.ascx.cs" Inherits="UsXuezi.UserControls.HomePage.CityIcon" %>

<div class="cityicon">
    <asp:ImageButton ID="CityIconImage" runat="server" OnClick="CityIconImage_Click" CssClass="image"  />
    <asp:Label ID="CityIconName" runat="server" Text="Label" CssClass="name"></asp:Label>
   
</div>
