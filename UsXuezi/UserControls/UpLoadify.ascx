<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="UpLoadify.ascx.cs" Inherits="UsXuezi.UserControls.UpLoadify" %>
<link rel="Stylesheet" type="text/css" href="/Plugins/uploadify/uploadify.css" />
<script src="/Plugins/uploadify/jquery.uploadify.js"></script>
<script src="/Plugins/uploadify/jquery.uploadify.min.js"></script>
<script type="text/javascript">
    $(window).load(
        function () {
            $("#<%=FileUpload1.ClientID %>").uploadify({
                'debug': true,
                'swf': '/Plugins/uploadify/uploadify.swf',
                'buttonText': '浏览',
                'uploader': '/Plugins/uploadify/upload.ashx',
                'fileDesc': 'Image Files',
                'fileExt': '*.jpg;*.jpeg;*.gif;*.png',
                'queueID': 'fileQueue',
                'multi': true,
                'auto': true,
                'onUploadError': function (file, errorCode, errorMsg, errorString) {
                    alert('The file ' + file.name + ' could not be uploaded: ' + errorString);
                }
            });
        }
);
</script>

<div style="padding: 40px">
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <div id="fileQueue"></div>
</div>


