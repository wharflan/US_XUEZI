<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EstatePublish.aspx.cs" MasterPageFile="~/PublishPage/ThreeStepPublish.Master" Title="房产交易发布页" Inherits="UsXuezi.PublishPage.EstatePublish" %>

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

<asp:Content ID="Content5" ContentPlaceHolderID="publishType" runat="server">房产交易</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="firstholder" runat="server">

    <div style="color:#f00;">* 为必填项目</div>

    <table class="table table-1" style="width:800px;">
        <tbody>
            <tr>
                <th width="80">标题</th>
                <td colspan="3"><input type="text" class="input" placeholder="如“Brookline两室两卫征室友一枚”" style="width:621px;"></td>
            </tr>
            <tr>
                <th width="80">地区</th>
                <td width="260">
                    <select name="" id="" style="width:234px;">
                        <option value="">波士顿</option>
                        <option value="">纽约</option>
                        <option value="">芝加哥</option>
                        <option value="">洛杉矶</option>
                        <option value="">三藩市</option>
                    </select>
                </td>
                <th width="80">地段</th>
                <td width="260">
                    <select name="" id="" style="width:234px;">
                        <option value="">Downtown</option>
                        <option value="">Downtown</option>
                        <option value="">Downtown</option>
                        <option value="">Downtown</option>
                        <option value="">Downtown</option>
                    </select>
                </td>
            </tr>
            <tr>
                <th width="80">售价</th>
                <td width="260"><input type="text" class="input input-m"></td>
                <th width="80">户型</th>
                <td width="260">
                    <input type="text" class="input input-s datepicker">
                    <span>室</span>
                    <input type="text" class="input input-s datepicker">
                    <span>卫</span>
                </td>
            </tr>
            <tr>
                <th width="80">房型</th>
                <td width="260">
                    <select name="" id="" style="width:234px;">
                        <option value="Condo">Condo</option>
                        <option value="Condo">Condo</option>
                        <option value="Condo">Condo</option>
                        <option value="Condo">Condo</option>
                        <option value="Condo">Condo</option>
                    </select>
                </td>
                <th width="80">居住面积</th>
                <td width="260"><input type="text" class="input input-m" placeholder="sq ft"></td>
            </tr>
            <tr>
                <th width="80">土地面积</th>
                <td width="260"><input type="text" class="input input-m" placeholder="sq ft"></td>
                <th width="80">停车位</th>
                <td width="260">
                    <select name="" id="" style="width:234px;">
                        <option value="Condo">无停车位</option>
                        <option value="Condo">露天停车位</option>
                        <option value="Condo">地下停车位</option>
                    </select>
                </td>
            </tr>
            <tr>
                <th width="80">物管费</th>
                <td width="260"><input type="text" class="input input-s"></td>
                <th width="80">地产税</th>
                <td width="260"><input type="text" class="input input-s" placeholder="USD/Year"></td>
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
            <asp:Label ID="Label20" runat="server" Style="text-align: left; width: auto;float:left;" CssClass="sub_heading" Text="地址"></asp:Label>
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
