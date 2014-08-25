<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="CKPic.ascx.cs" Inherits="UsXuezi.UserControls.CKPic" %>
<script src="/Plugins/ckfinder/ckfinder.js"></script>

<div style="width: <%=Width%>; display: inline" class="floatleft">
    <div style="height: 60px">
        <asp:Image ID="Image1" runat="server" CssClass="right_5 " Width="98%" Height="100%" />
    </div>
    <br />
    <input type="button" value="<%=Buttonname %>" class="border_button  right_5" style="width: 98%;" onclick="BrowseServer_<%=this.ID%>()" />

    <input id="xFilePath_<%=this.ID %>" name="FilePath" type="text" style="opacity: 0.01; width: 0.01px;" />
    <div id="signature" runat="server" visible="false">
        <asp:TextBox ID="TextBox2" placeholder="名字" Width="98%" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox1" placeholder="描述" Width="98%" runat="server"></asp:TextBox>
    </div>
    <asp:HiddenField ID="HiddenField1" Value="" runat="server" />
    <br />
</div>
