<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ItemPublish.aspx.cs" MasterPageFile="~/PublishPage/ThreeStepPublish.Master" Title="二手货发布页" Inherits="UsXuezi.PublishPage.ItemPublish" %>

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

<asp:Content ID="Content5" ContentPlaceHolderID="publishType" runat="server">二手市场</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="firstholder" runat="server">
    <div style="color:#f00;">* 为必填项目</div>
    <table class="table table-1" style="width:800px;">
        <tbody>
            <tr>
                <th width="80">标题</th>
                <td colspan="3"><input class="input" placeholder="" style="width:621px;" type="text"></td>
            </tr>
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
                <th width="80">物品类别</th>
                <td width="260"><input type="text" class="input input-m"></td>
                <th width="80">新旧程度</th>
                <td width="260">
                    <select name="" id="">
                        <option value="">全新</option>
                        <option value="">99新</option>
                        <option value="">95新</option>
                        <option value="">9新</option>
                        <option value="">8新</option>
                        <option value="">7新</option>
                    </select>
                </td>
            </tr>
            <tr>
                <th width="80">售价</th>
                <td colspan="3" width="260">
                    <input type="text" class="input input-s">
                    <label for=""><input type="checkbox" name="" id="">邮寄</label>
                    <label for=""><input type="checkbox" name="" id="">自取</label>
                    <span style="color:#f00;">价格错误</span>
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



