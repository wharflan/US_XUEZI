<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QAPublish.aspx.cs" Title="问答专栏发布页" MasterPageFile="~/MainMasterPage.Master" Inherits="UsXuezi.PublishPage.QAPublish" %>

<asp:Content ID="Content1" ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="/Css/PublishPage.css" rel="stylesheet" />
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="msform top_50">
        <fieldset class="box01 QAPublish">
            <div class="box01-hd">问答专栏</div>
            <div class="box01-bd">
                <div class="item-row">
                    <asp:Label ID="Label2" runat="server" class="sub_heading" Style="text-align: left;" Text="提问"></asp:Label>
                    <asp:TextBox ID="TextBox2" runat="server" Style="width: 545px; padding: 5px; font-size: 16px;" placeholder="如“在美生活，如何能够有效的提升逼格？”"></asp:TextBox>
                </div>
                <div class="item-row">
                    <span class="border_button btn-supplement">问题补充</span>
                </div>
                <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
                    <ContentTemplate>
                        <div class="fix-clear editor QAPubish-editor" style="display:none;" id="editorblock" runat="server">
                            <BBS:Editor ID="Editor1" runat="server" Placeholder=" " />
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="Button1" />
                        <asp:AsyncPostBackTrigger ControlID="Button4" />
                        <asp:AsyncPostBackTrigger ControlID="Button5" />
                    </Triggers>

                </asp:UpdatePanel>

                <div class="item-row" style="clear:both;margin-top:30px;">
                    <span class="label">已选标签：</span>
                    <a id="ContentHolder_tags1_洛杉矶text" class="tag blue_tag" href="javascript:__doPostBack('ctl00$ContentHolder$tags1$洛杉矶text','')">洛杉矶</a><input name="ctl00$ContentHolder$tags1$洛杉矶" id="ContentHolder_tags1_洛杉矶" src="/Images/delete.png" type="image" class="delete-tag">
                    <a id="ContentHolder_tags1_洛杉矶text" class="tag blue_tag" href="javascript:__doPostBack('ctl00$ContentHolder$tags1$洛杉矶text','')">芝加哥</a><input name="ctl00$ContentHolder$tags1$洛杉矶" id="ContentHolder_tags1_洛杉矶" src="/Images/delete.png" type="image" class="delete-tag">
                    <p class="text-note c-float">* 添加准确的话题与标签后，才能更好的让大家看到问题并回答喔</p>
                </div>
                <div class="item-row">
                    <div class="box-tag">
                        <span class="label">城市标签: </span>
                        <div class="cont labels">
                            <a href="" class="label-city">纽约</a>
                            <a href="" class="label-city">洛杉矶</a>
                            <a href="" class="label-city">旧金山</a>
                            <a href="" class="label-city">波士顿</a>
                            <a href="" class="label-city">芝加哥</a>
                        </div>
                    </div>
                    <div class="box-tag">
                        <span class="label">话题标签: </span>
                        <div class="cont labels">
                            <a href="" class="label-topic">生活</a>
                            <a href="" class="label-topic">工作</a>
                            <a href="" class="label-topic">学习</a>
                            <a href="" class="label-topic">学术</a>
                            <a href="" class="label-topic">娱乐</a>
                            <a href="" class="label-topic">生活</a>
                            <a href="" class="label-topic">工作</a>
                            <a href="" class="label-topic">学习</a>
                            <a href="" class="label-topic">学术</a>
                            <a href="" class="label-topic">娱乐</a>
                        </div>
                    </div>
                </div>
                <div class="item-row">
                    <span class="label" style="">自定义标签: </span>
                    <div class="cont">
                        <input type="text" style="width: 250px; padding: 3px; font-size: 16px; height: 20px;margin-right: 5px;" plcaeholder="请在20字以内">
                        <span class="border_button add-label">确定</span>
                    </div>
                </div>
            </div>
            <div class="modal" style="display:none;width:300px;">添加标签成功</div>
            <div class="btns-box">
                <asp:Button ID="Button3" runat="server" class="btn submit red_button" Text="预览" OnClientClick="GetContents()" OnClick="Button3_Click" />
                <asp:Button ID="Button2" runat="server" class="btn submit red_button left_5" Text="发布" OnClientClick="GetContents()" OnClick="Button2_Click" />
            </div>
        </fieldset>
        <script>
            $(function(){
                $(".btn-supplement").click(function(){
                    $(".QAPubish-editor").toggle();
                });
                $(".add-label").click(function(){
                    $(".modal").show();
                    setTimeout(function(){
                        $(".modal").fadeOut(1200);
                    }, 1500);
                });
            });
        </script>
    </div>
</asp:Content>

