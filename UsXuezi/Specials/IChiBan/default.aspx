<%@ Page Language="C#" AutoEventWireup="true" Title="IChiBan烧酒屋" MasterPageFile="~/Special/Site1.Master" CodeBehind="default.aspx.cs" Inherits="BosTon_BBS.Special.IChiBan._default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="ichiban.css"/>
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="thiscontainer">
        <div id="header" class="iscentered">
            <div id="logo"><a href="/"></a></div>
            <div id="website">
                <p>www.ichibanboston.net</p>
            </div>
        </div>

        <div class="main_content iscentered">

            <div class="left_col isblock">

                <div class="slider_title">
                    <h1>店长热荐菜品</h1>
                </div>

                <div id="comslider_in_point_237409"></div>
                <script type="text/javascript">
                    var oCOMScript237409 = document.createElement('script');
                    oCOMScript237409.src = "comslider237409/comsliderd.js?timestamp=1400045446";
                    oCOMScript237409.type = 'text/javascript';
                    document.getElementsByTagName("head").item(0).appendChild(oCOMScript237409);
                </script>
                <div style="clear:both"></div>
            </div>

            <div class="right_col floatright">

                <div class="ribbon">
                    <ul>
                        <li class="info">外卖/订座</li>
                        <li class="info">617-236-7907 or 617-236-5135</li>
                        <li class="info">14a Westland Ave., Boston, MA 02115</li>
                    </ul>
                </div>

                <div class="side_block">
                    <div class="inner_content">
                        <h2>餐厅简介</h2>
                        <div class="blocktxt"><span>Ichiban开业半年，位于东北大学附近，whole foods对面。Fenway, Backbay可步行到店，主营日式餐点，特色中式烧烤。</span></div>
                    </div>
                </div>


                <div class="side_block">
                    <div class="inner_content">
                        <h2>营业时间</h2>
                        <table class="hours_table">
                            <tbody>
                                <tr>
                                    <th scope="row">周一至四</th>
                                    <td>
                                        <span class="nowrap">11:30 am</span> - <span class="nowrap">10:00 pm</span>
                                    </td>
                                </tr>

                                <tr>
                                    <th scope="row">周五至六</th>
                                    <td>
                                        <span class="nowrap">11:30 am</span> - <span class="nowrap">11:00 pm</span>
                                    </td>
                                </tr>

                                <tr>
                                    <th scope="row">周日</th>
                                    <td>
                                        <span class="nowrap">12:00 am</span> - <span class="nowrap">10:00 pm</span>
                                    </td>
                                </tr>
                            </tbody>
                        </table>
                    </div>
                </div>

                <div class="side_block">
                    <div class="inner_content">
                        <h2>学子网独家优惠</h2>
                        <div class="blocktxt"><span>学子网用户凭本页截图可享受全款九折（不包含酒水）以及每人一份软饮</span></div>
                    </div>
                </div>


            </div>
        </div>

    </div>
    

</asp:Content>
