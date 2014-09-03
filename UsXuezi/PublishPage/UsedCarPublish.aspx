<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UsedCarPublish.aspx.cs" MasterPageFile="~/PublishPage/ThreeStepPublish.Master" Title="二手车发布页" Inherits="UsXuezi.PublishPage.UsedCarPublish" %>

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

<asp:Content ID="Content5" ContentPlaceHolderID="publishType" runat="server">二手车</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="firstholder" runat="server">
    <div style="color:#f00;">* 为必填项目</div>
    <table class="table table-1" style="width:800px;">
        <tbody>
            <tr>
                <th width="80">标题</th>
                <td colspan="3"><input type="text" class="input input-l"></td>
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
                <th width="80">售价</th>
                <td width="260"><input type="text" placeholder="USD" class="input input-m"></td>
            </tr>
            <tr>
                <th width="80">事故记录</th>
                <td width="260">
                    <select name="" id="">
                        <option value="">是</option>
                        <option value="">否</option>
                    </select>
                </td>
                <th width="80">车系</th>
                <td width="260">
                    <select name="" id="">
                        <option value="">日系</option>
                        <option value="">欧系</option>
                        <option value="">韩系</option>
                        <option value="">其他系</option>
                    </select>
                </td>
            </tr>
            <tr>
                <th width="80">购入年份</th>
                <td width="260">
                    <select name="" id="">
                        <option value="">1992</option>
                        <option value="">1993</option>
                        <option value="">1994</option>
                        <option value="">1995</option>
                        <option value="">1996</option>
                        <option value="">1997</option>
                        <option value="">1998</option>
                    </select>
                </td>
                <th width="80">里程</th>
                <td width="260"><input type="text" class="input input-m"></td>
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



