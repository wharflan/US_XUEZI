<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Editor.ascx.cs" Inherits="UsXuezi.UserControls.Editor" %>

<script src="/Plugins/ckeditor/ckeditor.js"></script>
<script src="/Plugins/ckfinder/ckfinder.js"></script>

<textarea id="Editor_Content_Only" name="post_content" class="editor top_20" runat="server"><p>你好</p></textarea>
<asp:HiddenField ID="HiddenField1" runat="server" />
<script type="text/javascript">
    var editor = CKEDITOR.replace('<%= Editor_Content_Only.ClientID %>');          // 创建编辑器
    CKFinder.setupCKEditor(editor, '/PlugIns/ckfinder/');   // 为编辑器绑定上传控件"

    function GetContents() {
        var editor = CKEDITOR.instances.<%= Editor_Content_Only.ClientID %>;
        $(<%= HiddenField1.ClientID %>).val(editor.getData());
    }

    function SetContents() {
        var editor = CKEDITOR.instances.<%= Editor_Content_Only.ClientID %>;
        value = document.getElementById( 'htmlArea' ).value;
        editor.setData( value );
    }
</script>


