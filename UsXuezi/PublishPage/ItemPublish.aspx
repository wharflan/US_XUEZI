<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemPublish.aspx.cs" MasterPageFile="~/PublishPage/ThreeStepPublish.Master" Title="二手货发布页" Inherits="UsXuezi.PublishPage.ItemPublish" %>

<asp:Content ID="Content1" ContentPlaceHolderID="stepname" runat="server">
    <li class="active">
        <div class="floatleft left_10">基本资料</div>
    </li>
    <li>
        <div class="floatleft left_10">图片上传</div>
    </li>
    <li>
        <div class="floatleft left_10">详细介绍</div>
    </li>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="firstholder" runat="server">
    <div class="sub_heading">
        <asp:Label ID="Label1" runat="server" Style="width: 100%; text-align: left;" Text="*为必填项目"></asp:Label>
    </div>


    <div class="item floatleft" style="width: 86%;">
        <asp:Label ID="Label2" runat="server" Text="标题"></asp:Label>
        <asp:TextBox ID="TextBox1" CssClass="basic-input" placeholder="如“9成新Iphone 包邮出”" Style="width: 81%;" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="请输入标题" ControlToValidate="TextBox1"></asp:RequiredFieldValidator>

    </div>

    <div class="item floatleft">
        <asp:Label ID="Label15" runat="server" Text="地区"></asp:Label>
        <asp:DropDownList ID="DropDownList2" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem Value="1">波士顿</asp:ListItem>
            <asp:ListItem Value="2">纽约</asp:ListItem>
            <asp:ListItem Value="3">芝加哥</asp:ListItem>
            <asp:ListItem Value="4">洛杉矶</asp:ListItem>
            <asp:ListItem Value="5">三藩市</asp:ListItem>
        </asp:DropDownList>
    </div>

    <!--只在列表页作筛选只用，不在内容页显示-->
    <div class="item floatleft">
        <asp:Label ID="Label3" runat="server" Text="物品类别"></asp:Label><asp:DropDownList ID="DropDownList1" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>衣鞋包饰</asp:ListItem>
            <asp:ListItem>数码产品</asp:ListItem>
            <asp:ListItem>家具/家居</asp:ListItem>
            <asp:ListItem>书籍/影视/音乐</asp:ListItem>
            <asp:ListItem>美容/保健</asp:ListItem>
            <asp:ListItem>折扣/会员卡</asp:ListItem>
            <asp:ListItem>其他</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label16" runat="server" Text="售价"></asp:Label>
        <asp:TextBox ID="TextBox9" CssClass="basic-input" Width="50px" runat="server"></asp:TextBox>
        <div class="floatleft" style="margin-left: -30px;">
            <asp:CheckBox ID="CheckBox3" CssClass="checkbox" runat="server" /><asp:Label ID="Label6" runat="server" Style="float: none;" Text="自取"></asp:Label>
        </div>
        <div class="floatleft" style="margin-left: -50px;">
            <asp:CheckBox ID="CheckBox4" CssClass="checkbox" runat="server" /><asp:Label ID="Label7" runat="server" Style="float: none;" Text="邮寄"></asp:Label>
        </div>
        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="价格错误" ValidationExpression="^\+?[1-9][0-9]*$" ControlToValidate="TextBox9" SetFocusOnError="True"></asp:RegularExpressionValidator>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="价格错误" ControlToValidate="TextBox9"></asp:RequiredFieldValidator>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label8" runat="server" Text="新旧程度"></asp:Label>
        <asp:DropDownList ID="DropDownList3" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>全新</asp:ListItem>
            <asp:ListItem>99新</asp:ListItem>
            <asp:ListItem>95新</asp:ListItem>
            <asp:ListItem>9新</asp:ListItem>
            <asp:ListItem>8新</asp:ListItem>
            <asp:ListItem>7新</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="fix-clear"></div>
    <div class="item floatleft">
        <asp:Label ID="Label9" runat="server" Text="电话"></asp:Label>
        <asp:TextBox ID="TextBox2" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label10" runat="server" Text="微信"></asp:Label>
        <asp:TextBox ID="TextBox4" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>


    <div class="item floatleft">
        <asp:Label ID="Label17" runat="server" Text="QQ"></asp:Label>
        <asp:TextBox ID="TextBox14" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label14" runat="server" Text="邮箱"></asp:Label>
        <asp:TextBox ID="TextBox5" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <input type="button" name="next" class="next red_button floatright" value="下一步" />

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="secondholder" runat="server">
    <div class="col_49">

        <div class="sub_heading">
            <asp:Label ID="Label4" runat="server" class="sub_heading" Text="物品图片"></asp:Label>
            <br class="fix-clear" />
        </div>

        <div class="top_50 bottom_10">
            <asp:Button ID="Button4" OnClick="Button4_Click" CssClass="border_button floatleft right_5" runat="server" Text="更多" />
            <asp:Button ID="Button5" OnClick="Button5_Click" CssClass="border_button floatleft right_5" runat="server" Text="减少" />

            <br class="fix-clear" />
        </div>


        <div>
            <asp:UpdatePanel ID="UpdatePanel3" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
                <ContentTemplate>
                    <BBS:MultiPics ID="MultiPics1" Maxnumber="8" runat="server" />
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button4" />
                    <asp:AsyncPostBackTrigger ControlID="Button5" />
                </Triggers>
            </asp:UpdatePanel>

        </div>

    </div>

    <input type="button" name="previous" class="previous big_border_button top_15 right_10 left_63pc" value="上一步" />
    <input type="button" name="next" class="next red_button" value="下一步" />

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="thirdholder" runat="server">

    <div class="col_100">
        <div class="sub_heading floatleft">你造吗？物品描述越详细，成交率越高喔！<a href="#">参考其他卖家</a></div>

        <div class="floatleft fix-clear editor top_20">
            <BBS:Editor ID="Editor1" runat="server" />
        </div>
    </div>

    <input type="button" name="previous" class="previous big_border_button floatleft" style="margin-top: -48px; margin-left: 660px;" value="上一步" />
    <asp:Button ID="Button6" runat="server" class="red_button floatleft left_5" Style="margin-top: -48px; margin-left: 762px;" Text="预览" OnClientClick="GetContents()" OnClick="Button6_Click" />
    <asp:Button ID="Button3" runat="server" class="red_button floatleft left_5" Style="margin-top: -48px;" Text="发布" OnClientClick="GetContents()" OnClick="Button3_Click" />



</asp:Content>



