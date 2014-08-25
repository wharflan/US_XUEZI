<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="HotIssueBlock.ascx.cs" Inherits="UsXuezi.UserControls.HomePage.HotIssueBlock" %>
<script>
    function show() {
        document.getElementById("detail").className = "hotissueblock_detail show";
    }

    function hide() {
        document.getElementById("detail").className = "hotissueblock_detail hide";
    }
</script>

<div class="hotissueblock">
    <div class="hotissueblock_left">
        <asp:ImageButton ID="issueimg" runat="server" CssClass="issueimg" onmouseover="show()" onmouseout="hide()" />
    </div>
    <div class="hotissueblock_right">
        <p>
            <asp:Label ID="issuetitle" runat="server" Text="Title" CssClass="issuetitle"></asp:Label>
        </p>
        <p>
            <asp:Label ID="issuecontent" runat="server" Text="Content" CssClass="issuecontent"></asp:Label>
        </p>
    </div>


    <div id="detail" class="hotissueblock_detail hide">
        <p>
            <asp:Label ID="Label1" runat="server" Text="Title" CssClass="issuetitle"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Content" CssClass="issuecontent"></asp:Label>
        </p>
    </div>
</div>
