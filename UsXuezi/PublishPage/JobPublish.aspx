<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PublishPage/ThreeStepPublish.Master" Title="职业发布" CodeBehind="JobPublish.aspx.cs" Inherits="UsXuezi.PublishPage.JobPublish" %>


<asp:Content ID="Content1" ContentPlaceHolderID="stepname" runat="server">
    <li class="active">
        <div class="floatleft left_10">基本资料</div>
    </li>
    <li>
        <div class="floatleft left_10">LOGO上传</div>
    </li>
    <li>
        <div class="floatleft left_10">详细介绍</div>
    </li>
</asp:Content>


<asp:Content ID="Content2" ContentPlaceHolderID="firstholder" runat="server">


    <div class="sub_heading">
        <asp:Label ID="Label1" runat="server" Style="width: 100%; text-align: left;" Text="*为必填项目"></asp:Label>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label2" runat="server" Text="职位"></asp:Label><asp:TextBox ID="TextBox1" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label5" runat="server" Text="工作地点"></asp:Label><asp:TextBox ID="TextBox3" CssClass="basic-input" placeholder="如 “Boston 纽约”" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label3" runat="server" Text="性质"></asp:Label>
        <div class="floatleft" style="margin-left: -40px;">
            <asp:CheckBox ID="CheckBox6" CssClass="checkbox" runat="server" /><asp:Label ID="Label20" runat="server" Style="float: none;" Text="全职"></asp:Label>
        </div>
        <div class="floatleft" style="margin-left: -40px;">
            <asp:CheckBox ID="CheckBox7" CssClass="checkbox" runat="server" /><asp:Label ID="Label21" runat="server" Style="float: none;" Text="兼职"></asp:Label>
        </div>
        <div class="floatleft" style="margin-left: -40px;">
            <asp:CheckBox ID="CheckBox8" CssClass="checkbox" runat="server" /><asp:Label ID="Label22" runat="server" Style="float: none;" Text="合同"></asp:Label>
        </div>
        <div class="floatleft" style="margin-left: -40px;">
            <asp:CheckBox ID="CheckBox2" CssClass="checkbox" runat="server" /><asp:Label ID="Label13" runat="server" Style="float: none;" Text="实习"></asp:Label>
        </div>
    </div>

    <!--职能不显示在内容页，只作搜索时筛选之用-->
    <div class="item floatleft">
        <asp:Label ID="Label4" runat="server" Text="职能"></asp:Label><asp:DropDownList ID="DropDownList2" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>餐饮/服务/零售</asp:ListItem>
            <asp:ListItem>计算机/电子/通讯</asp:ListItem>
            <asp:ListItem>会计/金融/保险</asp:ListItem>
            <asp:ListItem>销售/客服/技术支持</asp:ListItem>
            <asp:ListItem>广告/市场/媒体</asp:ListItem>
            <asp:ListItem>生产/物流/采购</asp:ListItem>
            <asp:ListItem>制药/医疗/护理</asp:ListItem>
            <asp:ListItem>建筑/房地产</asp:ListItem>
            <asp:ListItem>人事/行政/翻译</asp:ListItem>
            <asp:ListItem>咨询/法律/科研/教育</asp:ListItem>
            <asp:ListItem>艺术/表演</asp:ListItem>
            <asp:ListItem>其他</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="item floatleft" style="width: 75%;">
        <asp:Label ID="Label16" runat="server" Text="薪酬"></asp:Label>
        <asp:TextBox ID="TextBox5" CssClass="basic-input" Style="width: 80px;" runat="server"></asp:TextBox>
        <asp:DropDownList ID="DropDownList3" Style="width: 80px;" CssClass="basic-input" runat="server">
            <asp:ListItem>/小时</asp:ListItem>
            <asp:ListItem>/周</asp:ListItem>
            <asp:ListItem>/月</asp:ListItem>
            <asp:ListItem>/年</asp:ListItem>
            <asp:ListItem>/项目</asp:ListItem>
        </asp:DropDownList>

        <div class="floatleft" style="margin-left: -30px;">
            <asp:CheckBox ID="CheckBox1" CssClass="checkbox" runat="server" /><asp:Label ID="Label6" runat="server" Style="float: none;" Text="面议"></asp:Label>
        </div>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label17" runat="server" Text="经验年资"></asp:Label><asp:DropDownList ID="DropDownList4" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>1年及以下</asp:ListItem>
            <asp:ListItem>2-4年</asp:ListItem>
            <asp:ListItem>5-8年</asp:ListItem>
            <asp:ListItem>8年以上</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label8" runat="server" Text="申请方式"></asp:Label><asp:TextBox ID="TextBox8" placeholder="邮箱,网址,或电话" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>
    <div class="fix-clear"></div>
    <div class="item floatleft">
        <asp:Label ID="Label15" runat="server" Text="截止时间"></asp:Label><asp:TextBox ID="TextBox9" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>


    <input type="button" name="next" class="next red_button floatright" value="下一步" />

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="secondholder" runat="server">

    <div class="floatleft">
        <asp:Label ID="Label12" runat="server" class="sub_heading" Style="width: 200px; text-align: left;" Text="公司LOGO"></asp:Label>
    </div>

    <div class="top_50 bottom_10">
        <asp:Button ID="Button1" runat="server" CssClass="border_button floatleft right_5 " Text="浏览" />
        <asp:Button ID="Button2" runat="server" CssClass="border_button floatleft right_5 " Text="上传" />
        <br class="fix-clear" />
    </div>

    <asp:ImageButton ID="ImageButton2" CssClass="img_preview" runat="server" />

    <input type="button" name="previous" class="previous big_border_button top_60 right_10 left_63pc" value="上一步" />
    <input type="button" name="next" class="next red_button" value="下一步" />

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="thirdholder" runat="server">
    <div class="col_100">
        <div class="sub_heading floatleft">此处可填写职责范围、应聘人员需符合的条件、以及公司的背景文化。<a href="#">参考其他招聘公司</a></div>

        <div class="floatleft fix-clear editor top_20">
            <BBS:Editor ID="Editor1" runat="server" Placeholder=" " />
        </div>
    </div>

    <input type="button" name="previous" class="previous big_border_button floatleft" style="margin-top: -48px; margin-left: 660px;" value="上一步" />
    <input type="submit" name="submit" class="submit red_button floatleft" style="margin-top: -48px; margin-left: 762px;" value="预览" />
    <input type="submit" name="submit" class="submit red_button floatleft left_5" style="margin-top: -48px;" value="发布" />
</asp:Content>
