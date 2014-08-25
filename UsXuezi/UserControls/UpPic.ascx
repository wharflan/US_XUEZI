<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UpPic.ascx.cs" Inherits="UsXuezi.UserControls.UpPic" %>

<div class="border_button floatleft right_5" style="width: 30px; height: 21px; cursor: pointer; display: inline-block">
    <asp:FileUpload ID="FileUpload1" CssClass="" runat="server" Style="width: 60px; opacity: 0.01; cursor: pointer;" />
    <asp:Label ID="Label1" runat="server" Text="浏览" Style="margin-left: -35px; margin-top: -30px;"></asp:Label>
</div>

<div class="border_button floatleft right_5" style="width: 30px; height: 21px; cursor: pointer; display: inline-block">
    <asp:Button ID="Button1" runat="server" CssClass="border_button floatleft" Style="opacity: 0.01" OnClick="Button1_Click" Text="上传" />
    <asp:Label ID="Label2" runat="server" Text="上传" Style="margin-left: -35px; margin-top: -30px;"></asp:Label>
</div>

<div>
    <asp:Label ID="Label3" runat="server" Text=""></asp:Label>
</div>


