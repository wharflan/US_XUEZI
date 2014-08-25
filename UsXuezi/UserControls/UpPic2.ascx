<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UpPic2.ascx.cs" Inherits="UsXuezi.UserControls.UpPic2" %>

<script type="text/javascript">

</script>

<div style="position: absolute; z-index: 2; cursor: pointer;">
    <asp:FileUpload ID="FileUpload1" runat="server" Style="filter: alpha(opacity=0); opacity: 0; cursor: pointer;" Width="70px" Height="25px" onchange="uploadFile(this.value)" accept="image/*" />
</div>
<div style="position: absolute; z-index: 1; cursor: pointer; height: 25px;">
    <input type="button" name="btnUploadFile" id="btnUploadFile" runat="server" value="上傳新檔案" class="border_button" />    
</div>
<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label><asp:Image ID="Image1" runat="server" />

