<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/PublishPage/ThreeStepPublish.Master" Title="职业发布" CodeBehind="JobPublish.aspx.cs" Inherits="UsXuezi.PublishPage.JobPublish" %>


<asp:Content ID="Content1" ContentPlaceHolderID="stepname" runat="server">
    <li class="active">
        <a href="#firstholder" data-toggle="tab">1. 基本资料</a>
    </li>
    <li>
        <a href="#secondholder" data-toggle="tab">2. LOGO上传</a>
    </li>
    <li>
        <a href="#thirdholder" data-toggle="tab">3. 详细介绍</a>
    </li>
</asp:Content>

<asp:Content ID="Content5" ContentPlaceHolderID="publishType" runat="server">工作发布</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="firstholder" runat="server">

<div style="color:#f00;">* 为必填项目</div>
    <table class="table table-1" style="width:800px;">
        <tbody>
            <tr>
                <th width="80">职位</th>
                <td width="260"><input type="text" class="input input-m"></td>
                <th width="80">工作地点</th>
                <td width="260"><input type="text" class="input input-m" placeholder="如 “Boston 纽约”"></td>
            </tr>
            <tr>
                <th width="80">商家名称</th>
                <td width="260">
                    <label for=""><input type="checkbox" name="" id="">全职</label>
                    <label for=""><input type="checkbox" name="" id="">兼职</label>
                    <label for=""><input type="checkbox" name="" id="">合同</label>
                    <label for=""><input type="checkbox" name="" id="">实习</label>
                </td>
                <th width="80">职能</th>
                <td width="260">
                    <select name="" id="">
                        <option value="餐饮/服务/零售">餐饮/服务/零售</option>
                        <option value="计算机/电子/通讯">计算机/电子/通讯</option>
                        <option value="会计/金融/保险">会计/金融/保险</option>
                        <option value="销售/客服/技术支持">销售/客服/技术支持</option>
                        <option value="广告/市场/媒体">广告/市场/媒体</option>
                        <option value="生产/物流/采购">生产/物流/采购</option>
                        <option value="制药/医疗/护理">制药/医疗/护理</option>
                        <option value="建筑/房地产">建筑/房地产</option>
                        <option value="人事/行政/翻译">人事/行政/翻译</option>
                        <option value="咨询/法律/科研/教育">咨询/法律/科研/教育</option>
                        <option value="艺术/表演">艺术/表演</option>
                        <option value="其他">其他</option>
                    </select>
                </td>
            </tr>
            <tr>
                <th width="80">薪酬</th>
                <td width="260">
                    <input type="text" class="input input-s">
                    <select name="" id="">
                        <option value="/小时">/小时</option>
                        <option value="/周">/周</option>
                        <option value="/月">/月</option>
                        <option value="/年">/年</option>
                        <option value="/项目">/项目</option>
                    </select>
                    <label for=""><input type="checkbox" name="" id="">面议</label>
                </td>
                <th width="80">经验年资</th>
                <td width="260">
                    <select name="" id="">
                        <option value="1年及以下">1年及以下</option>
                        <option value="2-4年">2-4年</option>
                        <option value="5-8年">5-8年</option>
                        <option value="8年以上">8年以上</option>
                    </select>
                </td>
            </tr>
            <tr>
                <th width="80">申请方式</th>
                <td width="260"><input type="text" class="input input-m" placeholder="邮箱,网址,或电话"></td>
                <th width="80">截止时间</th>
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
