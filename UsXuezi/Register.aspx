<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" MasterPageFile="~/MainMasterPage.Master" Title="注册" Inherits="UsXuezi.PublishPage.Register" %>

<asp:Content ContentPlaceHolderID="HeadHolder" runat="server">
    <link href="/Css/PublishPage.css" rel="stylesheet" />
    <link href="/Css/UsXueziCss.css" rel="stylesheet" />
</asp:Content>

<asp:Content ContentPlaceHolderID="ContentHolder" runat="server">
    <div class="msform top_50">
        <fieldset>

            <asp:Label ID="Label6" runat="server" Text="我是"></asp:Label>

            <div class="floatleft">
                <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" AutoPostBack="True" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" CellPadding="4" CellSpacing="4" Width="300px">
                    <asp:ListItem Text="个人用户" Value="1"></asp:ListItem>
                    <asp:ListItem Text="商家/机构用户" Value="2"></asp:ListItem>
                </asp:RadioButtonList>
            </div>

            <div>
                <div class="long_item floatleft">
                    <asp:Label ID="Label15" runat="server" Text="注册邮箱"></asp:Label><asp:TextBox ID="TextBox8" CssClass="basic-input" runat="server"></asp:TextBox>
                    <div class="note floatleft" style="line-height: 35px;">*如已注册，请<a herf="#">登录</a></div>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label9" runat="server" Text="密码"></asp:Label>
                    <asp:TextBox ID="TextBox2" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label1" runat="server" Text="确认密码"></asp:Label>
                    <asp:TextBox ID="TextBox1" CssClass="basic-input" runat="server"></asp:TextBox>
                </div>

                <!--如个人用户不显示此项-->
                <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
                    <ContentTemplate>
                        <div class="long_item floatleft" id="specialblock" runat="server">
                            <asp:Label ID="Label3" runat="server" Text="机构类别"></asp:Label>
                            <asp:DropDownList ID="DropDownList1" Style="width: 262px;" CssClass="basic-input" runat="server">
                                <asp:ListItem>车行Dealer</asp:ListItem>
                                <asp:ListItem>餐饮商家</asp:ListItem>
                                <asp:ListItem>本地商家</asp:ListItem>
                                <asp:ListItem>地产经纪</asp:ListItem>
                            </asp:DropDownList>
                            <div class="note floatleft" style="line-height: 35px;">*不同机构类别可获得对应的额外功能与权限。</div>
                        </div>
                        <div class="item floatleft">
                            <asp:Label ID="Label2" runat="server" Text="机构名称"></asp:Label>
                            <asp:TextBox ID="TextBox3" CssClass="basic-input" runat="server"></asp:TextBox>
                        </div>
                    </ContentTemplate>
                    <Triggers>
                        <asp:AsyncPostBackTrigger ControlID="RadioButtonList1" />
                    </Triggers>
                </asp:UpdatePanel>



                <div class="item floatleft">
                    <asp:Label ID="Label4" runat="server" Text="所在城市"></asp:Label>
                    <asp:DropDownList ID="DropDownList2" Style="width: 262px;" CssClass="basic-input" runat="server">
                        <asp:ListItem>波士顿</asp:ListItem>
                        <asp:ListItem>纽约</asp:ListItem>
                        <asp:ListItem>芝加哥</asp:ListItem>
                        <asp:ListItem>洛杉矶</asp:ListItem>
                        <asp:ListItem>三藩市</asp:ListItem>
                    </asp:DropDownList>
                </div>

                <div class="item floatleft">
                    <asp:Label ID="Label5" runat="server" Text="验证码"></asp:Label>
                    <asp:TextBox ID="TextBox5" CssClass="basic-input" Width="135px" runat="server"></asp:TextBox>
                    <asp:Image ID="Image1" ImageUrl="/UserControls/ValidateCode.aspx" Style="float: left;" Height="32" runat="server" />
                </div>

            </div>

            <asp:Button ID="Button1" OnClick="Button1_Click" class="submit red_button floatright" runat="server" Text="注册" />
        </fieldset>
        <div class="box02 reg-main">
            <div class="box02-hd">注册新账户</div>
            <div class="box02-bd">
                <div class="regform">
                    <div class="form-group">
                        <label class="label" for="username">类型：</label>
                        <label><input type="radio">个人用户</label>
                        <label><input type="radio">商家/机构用户</label>
                    </div>
                    <div class="form-group">
                        <label class="label" for="eamil">注册邮箱：</label>
                        <input type="email" class="inp" id="eamil" name="email">
                        <div id="email_notice" class="notic"><span class="notic-text">*</span></div>
                    </div>
                        
                    <div class="form-group">
                        <label class="label" for="password">密码：</label>
                        <input type="password" name="password" class="inp" id="password">
                        <div id="password_notice" class="notic"><span class="notic-text">*</span></div>
                    </div>
                        
                    <div class="form-group">
                        <label class="label" for="conform_password">确认密码：</label>
                        <input type="password" name="conform_password" class="inp" id="conform_password">
                        <div id="conform_password_notice" class="notic"><span class="notic-text">*</span></div>
                    </div>
                    <div class="form-group">
                        <label class="label" for="username">用户名：</label>
                        <input type="text" class="inp" id="username" name="username" onblur="is_registered(this.value);">
                        <div id="username_notice" class="notic"><span class="notic-text">*</span></div>
                    </div>
                    <div class="form-group">
                        <label class="label">机构类别：</label>
                        <select class="select">
                            <option value="车行Dealer">车行Dealer</option>
                            <option value="餐饮商家">餐饮商家</option>
                            <option value="本地商家">本地商家</option>
                            <option value="地产经纪">地产经纪</option>
                        </select>
                        <div id="username_notice" class="notic"><span class="notic-text">*不同机构类别可获得对应的额外功能与权限</span></div>
                    </div>
                    <div class="form-group">
                        <label class="label">机构名称：</label>
                        <input name="passwd_answer" type="text" class="inp"><span class="notic-text">&nbsp;*</span>
                    </div>
                    <div class="form-group">
                        <label class="label">所在城市：</label>
                        <select class="select">
                            <option value="波士顿">波士顿</option>
                            <option value="纽约">纽约</option>
                            <option value="芝加哥">芝加哥</option>
                            <option value="洛杉矶">洛杉矶</option>
                            <option value="三藩市">三藩市</option>
                        </select>
                    </div>               
                    <div class="form-group" id="veriCode">
                        <label class="label" for="captcha">验证码：</label>
                        <input type="text" name="captcha" class="inp inp-w1" id="captcha">
                        <img src="UserControls/ValidateCode.aspx">
                    </div>
                    
                    <div class="cbox">
                        <input name="agreement" type="checkbox" value="1" checked="checked" id="agreement">
                        <label for="agreement" class="agree">我已阅读并同意<a href="">《用户协议》</a></label>
                    </div>
                    
                    <div class="submit">
                        <input name="Submit" type="submit" value="立即注册" class="btn-register">
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>
