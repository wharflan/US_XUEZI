<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ReplyBlock.ascx.cs" Inherits="UsXuezi.UserControls.ReplyBlock" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
    <ContentTemplate>
        <div class="replyblock" runat="server" id="allblock">
            <div class="replyavatar">
                <p>
                    <a href="<%= "/Person.aspx?id=" + mu.User_ID %>">
                        <asp:Image ID="Image1" CssClass="img" runat="server" /></a>
                    <asp:Label ID="Label4" runat="server" Text="Label" CssClass="label"></asp:Label>
                    <asp:Label ID="Label5" runat="server" Text="Label"></asp:Label>
                </p>
            </div>
            <div class="replycontent" id="contentpart" runat="server">
                <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>

            </div>
            <div class="replyfoot">
                <div class="replyinfo">
                    <asp:Label ID="Label1" runat="server" Text="时间"></asp:Label>
                    <asp:LinkButton ID="LinkButton1" runat="server" CssClass="linkbutton" OnClick="LinkButton1_Click">回复</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton2" runat="server" CssClass="linkbutton" OnClick="LinkButton2_Click">有用</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton3" runat="server" CssClass="linkbutton" OnClick="LinkButton3_Click">转发</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton4" runat="server" CssClass="linkbutton" OnClick="LinkButton4_Click">删除</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton6" runat="server" Visible="false" CssClass="linkbutton" OnClick="LinkButton6_Click">是</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton7" runat="server" Visible="false" CssClass="linkbutton" OnClick="LinkButton7_Click">否</asp:LinkButton>
                    <asp:LinkButton ID="LinkButton5" runat="server" CssClass="linkbutton" OnClick="LinkButton5_Click">展开</asp:LinkButton>
                    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
                </div>
            </div>
        </div>
    </ContentTemplate>
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="LinkButton1" />
        <asp:AsyncPostBackTrigger ControlID="LinkButton2" />
        <asp:AsyncPostBackTrigger ControlID="LinkButton3" />
        <asp:AsyncPostBackTrigger ControlID="LinkButton4" />
        <asp:AsyncPostBackTrigger ControlID="LinkButton5" />
        <asp:AsyncPostBackTrigger ControlID="LinkButton6" />
        <asp:AsyncPostBackTrigger ControlID="LinkButton7" />
    </Triggers>
</asp:UpdatePanel>


