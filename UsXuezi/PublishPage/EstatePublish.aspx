<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstatePublish.aspx.cs" MasterPageFile="~/PublishPage/ThreeStepPublish.Master" Title="房产交易发布页" Inherits="UsXuezi.PublishPage.EstatePublish" %>

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
        <asp:Label ID="Label15" runat="server" Text="地区">
        </asp:Label><asp:DropDownList ID="DropDownList3" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label3" runat="server" Text="地段"></asp:Label><asp:DropDownList ID="DropDownList1" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
            <asp:ListItem>a</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="item floatleft" style="width: 75%;">
        <asp:Label ID="Label5" runat="server" Text="售价"></asp:Label>
        <asp:TextBox ID="TextBox8" CssClass="basic-input" placeholder="USD" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label7" runat="server" Text="户型"></asp:Label>
        <div class="floatleft">
            <asp:TextBox ID="TextBox6" CssClass="short-input" Style="width: 100px;" runat="server"></asp:TextBox>室<asp:TextBox ID="TextBox10" CssClass="short-input" Style="width: 100px;" runat="server"></asp:TextBox>卫
        </div>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label6" runat="server" Text="房型"></asp:Label><asp:DropDownList ID="DropDownList2" Style="width: 262px;" CssClass="basic-input" runat="server">
            <asp:ListItem>Condo</asp:ListItem>
            <asp:ListItem>Single Family</asp:ListItem>
            <asp:ListItem>Apartment</asp:ListItem>
            <asp:ListItem>Townhouse</asp:ListItem>
            <asp:ListItem>Commercial</asp:ListItem>
            <asp:ListItem>Land</asp:ListItem>
            <asp:ListItem>其他</asp:ListItem>
        </asp:DropDownList>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label2" runat="server" Text="居住面积"></asp:Label>
        <div class="floatleft">

            <asp:TextBox ID="TextBox9" CssClass="basic-input" placeholder="Sqft" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label19" runat="server" Text="土地面积"></asp:Label>
        <div class="floatleft">
            <asp:TextBox ID="TextBox1" CssClass="basic-input" placeholder="Sqft" runat="server"></asp:TextBox>
        </div>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label14" runat="server" Text="停车位"></asp:Label>
        <div class="floatleft">
            <asp:DropDownList ID="DropDownList4" CssClass="basic-input" runat="server">
                <asp:ListItem>无停车位</asp:ListItem>
                <asp:ListItem>露天车库</asp:ListItem>
                <asp:ListItem>地下停车位</asp:ListItem>
            </asp:DropDownList>
        </div>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label18" runat="server" Text="物管费"></asp:Label>
        <div class="floatleft">

            <asp:TextBox ID="TextBox3" CssClass="basic-input" placeholder="USD" runat="server"></asp:TextBox>

        </div>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label9" runat="server" Text="电话"></asp:Label><asp:TextBox ID="TextBox2" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label10" runat="server" Text="微信"></asp:Label><asp:TextBox ID="TextBox4" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label17" runat="server" Text="QQ"></asp:Label><asp:TextBox ID="TextBox14" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label8" runat="server" Text="邮箱"></asp:Label><asp:TextBox ID="TextBox15" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>
    <input type="button" name="next" class="next red_button floatright" value="下一步" />
</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="secondholder" runat="server">

    <div class="col_49">
        <div class="sub_heading">
            <asp:Label ID="Label12" runat="server" class="sub_heading" Text="上传图片"></asp:Label>
        </div>

        <div class="top_50 bottom_10">
            <asp:Button ID="Button1" runat="server" CssClass="border_button floatleft right_5 " Text="浏览" />
            <asp:Button ID="Button2" runat="server" CssClass="border_button floatleft right_5 " Text="上传" />
            <asp:Label ID="Label4" runat="server" class="note floatleft" Style="width: 120px;" Text="多选可批量上传"></asp:Label>
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

    <div class="col_49 floatright">
        <div class="floatleft expand">
            <asp:Label ID="Label20" runat="server" Style="text-align: left; width: auto;" CssClass="sub_heading" Text="地址"></asp:Label>
            <asp:TextBox ID="TextBox5" class="basic-input" Style="width: 350px;" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="Search" OnClick="Button3_Click" />
        </div>

        <div class="floatleft top_20">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
                <ContentTemplate>
                    <div class="map_publish" id="mappart" runat="server">
                        <BBS:MapBlock ID="map" Width="360px" Height="200px" runat="server" />
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button3" />
                </Triggers>
            </asp:UpdatePanel>
        </div>

    </div>
    <input type="button" name="previous" class="previous big_border_button top_15 right_10 left_63pc" value="上一步" />
    <input type="button" name="next" class="next red_button" value="下一步" />


</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="thirdholder" runat="server">
    <div class="col_100">
        <div class="sub_heading floatleft">此处可具体介绍居所设施以及周边环境。<a href="#">参考其他售房贴</a></div>

        <div class="floatleft fix-clear editor top_20">
            <BBS:Editor ID="Editor1" runat="server" />
        </div>
    </div>

    <input type="button" name="previous" class="previous big_border_button floatleft" style="margin-top: -48px; margin-left: 660px;" value="上一步" />
    <input type="submit" name="submit" class="submit red_button floatleft" style="margin-top: -48px; margin-left: 762px;" value="预览" />
    <input type="submit" name="submit" class="submit red_button floatleft left_5" style="margin-top: -48px;" value="发布" />
</asp:Content>
