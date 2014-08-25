<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="SignatureBlock.ascx.cs" Inherits="UsXuezi.UserControls.SignatureBlock" %>

<div class="signatureblock">
    
    <asp:Image ID="Image1" runat="server" />
    <div class="list_tag" runat="server" id="list_tag">
        <asp:Label ID="Label1" runat="server" CssClass="signaturename"></asp:Label>
    </div>
</div>


    <div class="list_tag" runat="server" id="Div1" visible="false">
        <asp:Label ID="Label2" runat="server" Text="$1,000" CssClass="postprice"></asp:Label>
    </div>

    