<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentPublish.aspx.cs" MasterPageFile="~/PublishPage/ThreeStepPublish.Master" Title="租房发布页" Inherits="UsXuezi.PublishPage.RentPublish" %>


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


    <div class="item floatleft" style="width: 87%;">
        <asp:Label ID="Label2" runat="server" Text="标题"></asp:Label><asp:TextBox ID="TextBox9" placeholder="如“Brookline两室两卫征室友一枚”" Width="80%" CssClass="basic-input" runat="server"></asp:TextBox>

    </div>
    <asp:UpdatePanel ID="UpdatePanel1" runat="server" ChildrenAsTriggers="False" UpdateMode="Conditional">
        <ContentTemplate>
            <div class="item floatleft">
                <asp:Label ID="Label15" runat="server" Text="城市"></asp:Label>
                <asp:DropDownList ID="DropDownList4" OnSelectedIndexChanged="DropDownList4_SelectedIndexChanged" Style="width: 262px;" CssClass="basic-input" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="1">波士顿</asp:ListItem>
                    <asp:ListItem Value="2">纽约</asp:ListItem>
                    <asp:ListItem Value="3">芝加哥</asp:ListItem>
                    <asp:ListItem Value="4">洛杉矶</asp:ListItem>
                    <asp:ListItem Value="5">三藩市</asp:ListItem>
                </asp:DropDownList>
            </div>

            <div class="item floatleft">
                <asp:Label ID="Label3" runat="server" Text="地区"></asp:Label>
                <asp:DropDownList ID="DropDownList1" Style="width: 262px;" CssClass="basic-input" runat="server">
                </asp:DropDownList>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="DropDownList4" />
        </Triggers>
    </asp:UpdatePanel>


    <div class="item floatleft">
        <asp:Label ID="Label8" runat="server" Text="月租"></asp:Label>
        <asp:TextBox ID="TextBox3" CssClass="basic-input" Width="100px" runat="server"></asp:TextBox>
        <div class="floatleft" style="margin-left: -30px;">
            <asp:CheckBox ID="CheckBox6" CssClass="checkbox" runat="server" />
            <asp:Label ID="Label17" runat="server" Style="float: none;" Text="单间"></asp:Label>
        </div>
        <div class="floatleft" style="margin-left: -45px;">
            <asp:CheckBox ID="CheckBox7" CssClass="checkbox" runat="server" /><asp:Label ID="Label22" runat="server" Style="float: none;" Text="整套"></asp:Label>
        </div>
    </div>

    <script>
        $(function () {
            $("#<%=TextBox1.ClientID%>").datepicker();
        });
        $(function () {
            $("#<%=TextBox10.ClientID%>").datepicker();
        });
    </script>
    <link rel="stylesheet" href="/Script/jquery.custom/jquery-ui.css">
    <script src="/Script/jquery.custom/jquery-ui.js"></script>



    <div class="item floatleft">
        <div class="floatleft">
            <asp:Label ID="Label6" runat="server" Text="租期"></asp:Label>
            <asp:TextBox ID="TextBox1" CssClass="short-input"  runat="server"></asp:TextBox>至
            <asp:TextBox ID="TextBox10" CssClass="short-input" runat="server"></asp:TextBox>
        </div>
    </div>



    <div class="item floatleft">
        <asp:Label ID="Label11" runat="server" Text="电话"></asp:Label><asp:TextBox ID="TextBox4" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label16" runat="server" Text="微信"></asp:Label><asp:TextBox ID="TextBox6" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label18" runat="server" Text="QQ"></asp:Label><asp:TextBox ID="TextBox14" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label19" runat="server" Text="邮箱"></asp:Label><asp:TextBox ID="TextBox15" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <input type="button" name="next" class="next red_button floatright" value="下一步" />

</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="secondholder" runat="server">

    <div class="col_49">
        <div class="sub_heading">
            <asp:Label ID="Label12" runat="server" class="sub_heading" Text="上传图片"></asp:Label>
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

    <div class="col_49 floatright">
        <div class="floatleft expand">
            <asp:Label ID="Label20" runat="server" Style="text-align: left; width: auto;" CssClass="sub_heading" Text="地址"></asp:Label>
            <asp:TextBox ID="TextBox5" class="basic-input" Style="width: 260px;" runat="server"></asp:TextBox>
            <asp:Button ID="Button7" runat="server" Text="Search" CssClass="border_button" OnClick="Button7_Click" />
        </div>

        <div class="floatleft top_20">
            <asp:UpdatePanel ID="UpdatePanel2" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
                <ContentTemplate>
                    <div class="map_publish" id="mappart" runat="server">
                        <BBS:MapBlock ID="map" Width="360px" Height="200px" runat="server" />
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button7" />
                </Triggers>
            </asp:UpdatePanel>
        </div>

    </div>
    <input type="button" name="previous" class="previous big_border_button top_15 right_10 left_63pc" value="上一步" />
    <input type="button" name="next" class="next red_button" value="下一步" />

</asp:Content>

<asp:Content ID="Content4" ContentPlaceHolderID="thirdholder" runat="server">

    <div class="col_100">
        <div class="floatleft">
            <div class="sub_heading">此处可具体介绍居所的设施，现居室友的情况，以及对租客的要求等。<a href="#">参考其他招租贴</a></div>
            <div class="floatleft fix-clear editor top_20">
                <BBS:Editor ID="Editor1" runat="server" Placeholder=" " />
            </div>
        </div>
        <div class="floatleft" style="width: 30%; margin-left: 20px">
            <div class="sub_heading floatleft">附带信息</div>
            <div class="fix-clear"></div>
            <div class="floatleft" style="margin-top: 20px">
                <asp:Label ID="Label14" runat="server" Text="家具"></asp:Label>
                <asp:DropDownList ID="DropDownList3" Style="width: 170px;" CssClass="basic-input" runat="server">
                    <asp:ListItem>带全套家具</asp:ListItem>
                    <asp:ListItem>带部分家具</asp:ListItem>
                    <asp:ListItem>不带家具</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="fix-clear"></div>
            <div class=" floatleft" style="margin-top: 20px">
                <asp:Label ID="Label27" runat="server" Text="宠物制度"></asp:Label>
                <asp:DropDownList ID="DropDownList2" Style="width: 170px;" CssClass="basic-input" runat="server">
                    <asp:ListItem>可养任何宠物</asp:ListItem>
                    <asp:ListItem>只能养狗</asp:ListItem>
                    <asp:ListItem>只能养猫</asp:ListItem>
                    <asp:ListItem>不可养任何宠物</asp:ListItem>
                </asp:DropDownList>
            </div>
            <div class="fix-clear"></div>
            <div class="floatleft" style="margin-top: 20px">
                <asp:Label ID="Label7" runat="server" Text="停车位"></asp:Label>

                <div class="floatleft" style="margin-left: -30px;">
                    <asp:CheckBox ID="CheckBox1" CssClass="checkbox" runat="server" /><asp:Label ID="Label9" runat="server" Style="float: none;" Text="街泊"></asp:Label>
                </div>
                <div class="floatleft" style="margin-left: -30px;">
                    <asp:CheckBox ID="CheckBox2" CssClass="checkbox" runat="server" /><asp:Label ID="Label10" runat="server" Style="float: none;" Text="车库"></asp:Label>
                </div>

            </div>
        </div>

    </div>

    <input type="button" name="previous" class="previous big_border_button floatleft" style="margin-top: -48px; margin-left: 660px;" value="上一步" />

    <asp:Button ID="Button6" runat="server" class="red_button floatleft left_5" OnClientClick="GetContents()" Style="margin-top: -48px; margin-left: 762px;" Text="预览" OnClick="Button6_Click" />
    <asp:Button ID="Button3" runat="server" class="red_button floatleft left_5" OnClientClick="GetContents()" Style="margin-top: -48px;" Text="发布" OnClick="Button3_Click" />

</asp:Content>



