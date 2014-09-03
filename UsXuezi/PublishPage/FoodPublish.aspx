<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FoodPublish.aspx.cs" MasterPageFile="/PublishPage/ThreeStepPublish.Master" Title="餐饮发布页" Inherits="UsXuezi.PublishPage.FoodPublish" %>


<asp:Content ID="Content1" ContentPlaceHolderID="stepname" runat="server">
    <li class="active">
        <a href="#firstholder" data-toggle="tab">1. 基本资料</a>
    </li>
    <li>
        <a href="#secondholder" data-toggle="tab">2. 图片上传</a>
    </li>
    <li>
        <a href="#thirdholder" data-toggle="tab">3. 详细介绍</a>
    </li>
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="publishType" runat="server">美食餐饮</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="firstholder" runat="server">
    <div style="color:#f00;">* 为必填项目</div>
    <table class="table table-1" style="width:800px;">
        <tbody>
            <tr>
                <th width="80">城市</th>
                <td width="260">
                    <select name="" id="" style="width:234px;">
                        <option value="">波士顿</option>
                        <option value="">纽约</option>
                        <option value="">芝加哥</option>
                        <option value="">洛杉矶</option>
                        <option value="">三藩市</option>
                    </select>
                </td>
                <th width="80">地区</th>
                <td width="260">
                    <select name="" id="" style="width:234px;">
                        <option value="">Downtown</option>
                        <option value="">Cambridge</option>
                        <option value="">Malden</option>
                        <option value="">Quincy</option>
                        <option value="">Allston/Brighton</option>
                    </select>
                </td>
            </tr>
            <tr>
                <th width="80">商家名称</th>
                <td colspan="3" width="260"><input type="text" class="input input-m"></td>
            </tr>
            <tr>
                <th valign="top">主打菜系</th>
                <td valign="top" colspan="3">
                    <textarea name="" id="" style="width:634px;height:100px;"></textarea>
                </td>
            </tr>
        </tbody>
    </table>
    <div><span style="color:#f00;">* </span>联系方式<span style="color:#f33;">（至少填写一项）</span></div>
    <table class="table table-1" style="width:800px;">
        <tbody>
            <tr>
                <th width="80">电话</th>
                <td width="260"><input type="text" class="input input-m"></td>
                <th width="80">微信</th>
                <td><input type="text" class="input input-m"></td>
            </tr>
            <tr>
                <th width="80">QQ</th>
                <td width="260"><input type="text" class="input input-m"></td>
                <th width="80">邮箱</th>
                <td width="260"><input type="text" class="input input-m"></td>
            </tr>
        </tbody>
    </table>
    <input type="button" name="next" class="next red_button floatright" value="下一步" />


</asp:Content>

<asp:Content ID="Content3" ContentPlaceHolderID="secondholder" runat="server">
    <div class="col_49">
        <div class="sub_heading">
            <asp:Label ID="Label12" runat="server" class="sub_heading" Text="上传封面"></asp:Label>

        </div>

        <div class="top_50 bottom_10">
            
            <BBS:CKPic ID="CKFinder2" PostType="post" Buttonname="上传封面" Width="130px" runat="server" />
        </div>
        <br class="fix-clear" />
        <div class="sub_heading">
            <asp:Label ID="Label6" runat="server" class="sub_heading" Text="招牌菜"></asp:Label>
        </div>

        <div>
            <div class="fix-clear"></div>
            <BBS:CKPic ID="CKFinder1" PostType="signature" Buttonname="招牌菜" Width="30%" runat="server" />
            <BBS:CKPic ID="CKFinder3" PostType="signature" Buttonname="招牌菜" Width="30%" runat="server" />
            <BBS:CKPic ID="CKFinder4" PostType="signature" Buttonname="招牌菜" Width="30%" runat="server" />
        </div>

    </div>



    <div class="col_49 floatright">
        <div class="floatleft expand">
            <asp:Label ID="Label20" runat="server" Style="text-align: left; width: auto;float:left;" CssClass="sub_heading" Text="地址"></asp:Label>
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
