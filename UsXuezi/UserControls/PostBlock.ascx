<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PostBlock.ascx.cs" Inherits="UsXuezi.UserControls.PostBlock" %>
<div class="postblock <%=Type %>">
    <a href="<%=posturl %>" target="_blank" >
        <asp:Image ID="Image1" runat="server" class="postimg" /></a>
    <div class="posttitle">
        <asp:Label ID="Label3" Style="float: right;" runat="server" Text=""></asp:Label>
        <a href="<%=posturl %>" target="_blank">
            <asp:Label ID="Label4" runat="server" Text="Label"></asp:Label></a>
    </div>


    <!--只在”二手车“和”二手市场“列表中出现-->
    <div class="list_tag" runat="server" id="list_tag" visible="false">
        <asp:Label ID="Label1" runat="server" Text="$1,000" CssClass="postprice"></asp:Label>
    </div>

    <div id="details" class="postdetail">
        <a href="<%=userurl %>" target="_blank">
            <asp:Label ID="Label5" runat="server" Text=""></asp:Label></a>
        <asp:Label ID="Label2" runat="server" Text=""></asp:Label>
    </div>
</div>
