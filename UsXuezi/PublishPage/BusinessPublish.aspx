<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="BusinessPublish.aspx.cs" MasterPageFile="/PublishPage/ThreeStepPublish.Master" Title="商家发布页" Inherits="UsXuezi.PublishPage.BusinessPublish" %>


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

    <asp:UpdatePanel ID="UpdatePanel2" runat="server" ChildrenAsTriggers="False" UpdateMode="Conditional">
        <ContentTemplate>
            <div class="item floatleft">
                <asp:Label ID="Label15" runat="server" Text="城市"></asp:Label>
                <asp:DropDownList ID="DropDownList4" Style="width: 262px;" CssClass="basic-input" runat="server" AutoPostBack="True">
                    <asp:ListItem Value="1">波士顿</asp:ListItem>
                    <asp:ListItem Value="2">纽约</asp:ListItem>
                    <asp:ListItem Value="3">芝加哥</asp:ListItem>
                    <asp:ListItem Value="4">洛杉矶</asp:ListItem>
                    <asp:ListItem Value="5">三藩市</asp:ListItem>
                </asp:DropDownList>
            </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:BosTon_BBSConnectionString1 %>' SelectCommand="SELECT * FROM [Tb_Area] WHERE ([Area_CityID] = @Area_CityID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList4" PropertyName="SelectedValue" DefaultValue="Value" Name="Area_CityID" Type="Int32"></asp:ControlParameter>
                </SelectParameters>
            </asp:SqlDataSource>
            <div class="item floatleft">
                <asp:Label ID="Label4" runat="server" Text="地区"></asp:Label>
                <asp:DropDownList ID="DropDownList2" Style="width: 262px;" CssClass="basic-input" runat="server" DataSourceID="SqlDataSource1" DataTextField="Area_Name" DataValueField="Area_ID">
                </asp:DropDownList>
            </div>
        </ContentTemplate>
        <Triggers>
            <asp:AsyncPostBackTrigger ControlID="DropDownList4" />
        </Triggers>
    </asp:UpdatePanel>

    <div class="fix-clear"></div>
    <div class="item floatleft">
        <asp:Label ID="Label2" runat="server" Text="商家名称"></asp:Label><asp:TextBox ID="TextBox1" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label3" runat="server" Text="商家类别"></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString='<%$ ConnectionStrings:BosTon_BBSConnectionString1 %>' SelectCommand="SELECT * FROM [Tb_BusinessType]"></asp:SqlDataSource>
        <asp:DropDownList ID="DropDownList1" Style="width: 262px;" CssClass="basic-input" runat="server" DataSourceID="SqlDataSource2" DataTextField="BT_Content" DataValueField="BT_ID">
            
        </asp:DropDownList>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label5" runat="server" Text="主营业务"></asp:Label>
        <textarea id="Biz_TextArea" placeholder="如“家政服务，机票预订，旅游订制，汽车修理美容….”" style="width: 262px; height: 200px; margin-left: -90px" cols="10" rows="2" maxlength="120" runat="server"></textarea>
        <div class="fix-clear"></div>
        <div class="note right_50" node-type="num">120</div>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label7" runat="server" Text="电话"></asp:Label><asp:TextBox ID="TextBox6" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label9" runat="server" Text="微信"></asp:Label><asp:TextBox ID="TextBox2" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label10" runat="server" Text="邮箱"></asp:Label><asp:TextBox ID="TextBox4" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>

    <div class="item floatleft">
        <asp:Label ID="Label11" runat="server" Text="QQ"></asp:Label><asp:TextBox ID="TextBox7" CssClass="basic-input" runat="server"></asp:TextBox>
    </div>


    <input type="button" name="next" class="next red_button floatright" value="下一步" />


</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="secondholder" runat="server">
    <div class="col_49">
        <div class="sub_heading">
            <asp:Label ID="Label12" runat="server" class="sub_heading" Text="上传封面"></asp:Label>

        </div>

        <div class="top_50 bottom_10">
            
            <BBS:CKPic ID="CKFinder2" PostType="post" Buttonname="上传封面" Width="150px" runat="server" />
        </div>
        <br class="fix-clear" />
        <div class="sub_heading">
            <asp:Label ID="Label6" runat="server" class="sub_heading" Text="推荐产品"></asp:Label>
        </div>

        <div>
            <div class="fix-clear"></div>
            <BBS:CKPic ID="CKFinder1" PostType="signature" Buttonname="推荐产品" Width="30%" runat="server" />
            <BBS:CKPic ID="CKFinder3" PostType="signature" Buttonname="推荐产品" Width="30%" runat="server" />
            <BBS:CKPic ID="CKFinder4" PostType="signature" Buttonname="推荐产品" Width="30%" runat="server" />
        </div>

    </div>



    <div class="col_49 floatright">
        <div class="floatleft expand">
            <asp:Label ID="Label20" runat="server" Style="text-align: left; width: auto;" CssClass="sub_heading" Text="地址"></asp:Label>
            <asp:TextBox ID="TextBox5" class="basic-input" Style="width: 260px;" runat="server"></asp:TextBox>
            <asp:Button ID="Button7" runat="server" Text="Search" CssClass="border_button" OnClick="Button7_Click" />
        </div>

        <div class="floatleft top_20">
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
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

    <div class="sub_heading floatleft">详细介绍你的服务，帮助用户加深了解，可有效提高到店率喔！<a href="#">参考其他商家</a></div>

    <div class="floatleft fix-clear editor top_20">
        <BBS:Editor ID="Editor1" runat="server" Placeholder=" " />
    </div>

    <div class="sub_heading floatleft top_20 fix-clear">*你还可以发布优惠劵，吸引新顾客，留住老主顾</div>
    <asp:Button ID="Button4" runat="server" CssClass="border_button floatleft top_20 left_30 right_5 " Text="上传现有优惠劵" />
    <asp:Button ID="Button5" runat="server" CssClass="border_button floatleft top_20 right_5 " Text="设计新的优惠劵" />

    <input type="button" name="previous" class="previous big_border_button floatleft top_15 left_80" value="上一步" />
    <asp:Button ID="Button6" runat="server" class="red_button floatleft left_5" Text="预览" OnClientClick="GetContents()" OnClick="Button6_Click" />
    <asp:Button ID="Button3" runat="server" class="red_button floatleft left_5" Text="发布" OnClientClick="GetContents()" OnClick="Button3_Click" />




</asp:Content>
