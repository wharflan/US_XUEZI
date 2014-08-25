<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsedCarPublish.aspx.cs" MasterPageFile="~/PublishPage/ThreeStepPublish.Master" Title="二手车发布页" Inherits="UsXuezi.PublishPage.UsedCarPublish" %>

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

    <div class="item floatleft">
        <asp:Label ID="Label15" runat="server" Text="城市"></asp:Label>
        <asp:DropDownList ID="DropDownList4" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label3" runat="server" Text="地区"></asp:Label>
        <asp:DropDownList ID="DropDownList1" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label22" runat="server" Text="售价"></asp:Label><asp:TextBox ID="TextBox10" placeholder="USD" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label6" runat="server" Text="事故记录"></asp:Label>
        <asp:DropDownList ID="DropDownList3" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>无</asp:ListItem>
            <asp:ListItem>有</asp:ListItem>

        </asp:DropDownList>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label8" runat="server" Text="车系"></asp:Label>
        <asp:DropDownList ID="DropDownList2" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>日系</asp:ListItem>
            <asp:ListItem>美系</asp:ListItem>
            <asp:ListItem>欧系</asp:ListItem>
            <asp:ListItem>其他</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label5" runat="server" Text="车型"></asp:Label><asp:TextBox ID="TextBox6" placeholder="如“2011 Camry LE”" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="fix-clear"></div>
    <div class="item floatleft">
        <asp:Label ID="Label21" runat="server" Text="购入年份"></asp:Label>
        <asp:DropDownList ID="DropDownList5" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>2014</asp:ListItem>
            <asp:ListItem>2013</asp:ListItem>
            <asp:ListItem>2012</asp:ListItem>
            <asp:ListItem>2011</asp:ListItem>
            <asp:ListItem>2011</asp:ListItem>
            <asp:ListItem>2010</asp:ListItem>
            <asp:ListItem>2009</asp:ListItem>
            <asp:ListItem>2008</asp:ListItem>
            <asp:ListItem>2007</asp:ListItem>
            <asp:ListItem>2006</asp:ListItem>
            <asp:ListItem>2005</asp:ListItem>
            <asp:ListItem>2004</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label4" runat="server" Text="里程"></asp:Label><asp:TextBox ID="TextBox5" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>



    <div class="item floatleft">
        <asp:Label ID="Label9" runat="server" Text="电话"></asp:Label><asp:TextBox ID="TextBox2" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label10" runat="server" Text="微信"></asp:Label><asp:TextBox ID="TextBox4" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>



    <div class="item floatleft">
        <asp:Label ID="Label19" runat="server" Text="QQ"></asp:Label><asp:TextBox ID="TextBox14" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label20" runat="server" Text="邮箱"></asp:Label><asp:TextBox ID="TextBox3" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <input type="button" name="next" class="next red_button floatright" value="下一步" />


</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="secondholder" runat="server">
    <div class="col_49">
        <div class="sub_heading">
            <asp:Label ID="Label12" runat="server" class="sub_heading" Text="物品图片"></asp:Label>
        </div>

        <div class="top_50 bottom_10">
            <asp:Button ID="Button1" runat="server" CssClass="border_button floatleft right_5 " Text="浏览" />
            <asp:Button ID="Button2" runat="server" CssClass="border_button floatleft right_5 " Text="上传" />
            <asp:Label ID="Label31" runat="server" class="note floatleft" Style="width: 120px;" Text="多选可批量上传"></asp:Label>
            <br class="fix-clear" />
        </div>


        <div>
            <div class="img_preview cover">
                <div class="sub_heading top_90" style="width: 120px; text-align: left; font-size: 12px;">拖移选择封面</div>
            </div>
            <asp:ImageButton ID="ImageButton2" CssClass="img_preview" runat="server" />
            <asp:ImageButton ID="ImageButton3" CssClass="img_preview" runat="server" />
            <asp:ImageButton ID="ImageButton4" CssClass="img_preview" runat="server" />
            <asp:ImageButton ID="ImageButton5" CssClass="img_preview" runat="server" />

        </div>
    </div>

    <input type="button" name="previous" class="previous big_border_button top_15 right_10 left_63pc" value="上一步" />
    <input type="button" name="next" class="next red_button" value="下一步" />

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="thirdholder" runat="server">
    <div class="col_100">
        <div class="sub_heading floatleft">你造吗？物品描述越详细，成交率越高喔！<a href="#">参考其他售车贴</a></div>

        <div class="floatleft">
            <div class="floatleft fix-clear editor top_20">
                <BBS:Editor ID="Editor1" runat="server" Placeholder=" " />
            </div>
        </div>
    </div>

    <input type="button" name="previous" class="previous big_border_button floatleft" style="margin-top: -48px; margin-left: 660px;" value="上一步" />
    <input type="submit" name="submit" class="submit red_button floatleft" style="margin-top: -48px; margin-left: 762px;" value="预览" />
    <input type="submit" name="submit" class="submit red_button floatleft left_5" style="margin-top: -48px;" value="发布" />
</asp:Content>



