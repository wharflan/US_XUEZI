<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="UsXuezi.AdminTools.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style>
        img {
            max-width: 200px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div >
            <div id="postdetail" style="width: 500px; float: right;">
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString='<%$ ConnectionStrings:BosTon_BBSConnectionString1 %>' SelectCommand="SELECT * FROM [Tb_PostBusiness] WHERE ([Business_PostID] = @Business_PostID) ORDER BY [Business_PostID] DESC" DeleteCommand="DELETE FROM [Tb_PostBusiness] WHERE [Business_PostID] = @Business_PostID" InsertCommand="INSERT INTO [Tb_PostBusiness] ([Business_PostID], [Business_AreaID], [Business_TypeID], [Business_Description], [Business_Cover], [Business_Address], [Business_MainContent], [Business_Status], [Business_Phone], [Business_Wechat], [Business_Email], [Business_QQ], [Business_Weibo]) VALUES (@Business_PostID, @Business_AreaID, @Business_TypeID, @Business_Description, @Business_Cover, @Business_Address, @Business_MainContent, @Business_Status, @Business_Phone, @Business_Wechat, @Business_Email, @Business_QQ, @Business_Weibo)" UpdateCommand="UPDATE [Tb_PostBusiness] SET [Business_AreaID] = @Business_AreaID, [Business_TypeID] = @Business_TypeID, [Business_Description] = @Business_Description, [Business_Cover] = @Business_Cover, [Business_Address] = @Business_Address, [Business_MainContent] = @Business_MainContent, [Business_Status] = @Business_Status, [Business_Phone] = @Business_Phone, [Business_Wechat] = @Business_Wechat, [Business_Email] = @Business_Email, [Business_QQ] = @Business_QQ, [Business_Weibo] = @Business_Weibo WHERE [Business_PostID] = @Business_PostID">
                    <DeleteParameters>
                        <asp:Parameter Name="Business_PostID" Type="Int32"></asp:Parameter>
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Business_PostID" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Business_AreaID" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Business_TypeID" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Business_Description" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Cover" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Address" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_MainContent" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Status" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Business_Phone" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Wechat" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Email" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_QQ" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Weibo" Type="String"></asp:Parameter>
                    </InsertParameters>
                    <SelectParameters>
                        <asp:ControlParameter ControlID="GridView1" PropertyName="SelectedValue" Name="Business_PostID" Type="Int32"></asp:ControlParameter>
                    </SelectParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Business_AreaID" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Business_TypeID" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Business_Description" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Cover" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Address" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_MainContent" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Status" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Business_Phone" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Wechat" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Email" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_QQ" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_Weibo" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Business_PostID" Type="Int32"></asp:Parameter>
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" Width="460px" DataKeyNames="Business_PostID" DataSourceID="SqlDataSource2" BackColor="White" BorderColor="#E7E7FF" BorderStyle="None" BorderWidth="1px" CellPadding="3" GridLines="Horizontal">
                    <AlternatingRowStyle BackColor="#F7F7F7"></AlternatingRowStyle>

                    <EditRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="#F7F7F7"></EditRowStyle>
                    <Fields>
                        <asp:BoundField DataField="Business_PostID" HeaderText="PostID" ReadOnly="True" SortExpression="Business_PostID"></asp:BoundField>
                        <asp:BoundField DataField="Business_AreaID" HeaderText="地区ID" SortExpression="Business_AreaID"></asp:BoundField>
                        <asp:BoundField DataField="Business_TypeID" HeaderText="商家类型" SortExpression="Business_TypeID"></asp:BoundField>
                        <asp:BoundField DataField="Business_Description" HeaderText="描述" SortExpression="Business_Description"></asp:BoundField>
                        <asp:ImageField DataImageUrlField="Business_Cover" HeaderText="封面"></asp:ImageField>
                        <asp:BoundField DataField="Business_Address" HeaderText="地址" SortExpression="Business_Address"></asp:BoundField>
                        <asp:BoundField DataField="Business_MainContent" HeaderText="内容" SortExpression="Business_MainContent">
                            <ControlStyle Width="1500px"></ControlStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="Business_Status" HeaderText="状态()" SortExpression="Business_Status"></asp:BoundField>
                        <asp:BoundField DataField="Business_Phone" HeaderText="电话" SortExpression="Business_Phone"></asp:BoundField>
                        <asp:BoundField DataField="Business_Wechat" HeaderText="微信" SortExpression="Business_Wechat"></asp:BoundField>
                        <asp:BoundField DataField="Business_Email" HeaderText="邮件" SortExpression="Business_Email"></asp:BoundField>
                        <asp:BoundField DataField="Business_QQ" HeaderText="QQ" SortExpression="Business_QQ"></asp:BoundField>
                        <asp:BoundField DataField="Business_Weibo" HeaderText="Business_Weibo" SortExpression="Business_Weibo"></asp:BoundField>
                        <asp:CommandField ShowEditButton="True"></asp:CommandField>
                    </Fields>
                    <FooterStyle BackColor="#B5C7DE" ForeColor="#4A3C8C"></FooterStyle>

                    <HeaderStyle BackColor="#4A3C8C" Font-Bold="True" ForeColor="#F7F7F7"></HeaderStyle>

                    <PagerStyle HorizontalAlign="Right" BackColor="#E7E7FF" ForeColor="#4A3C8C"></PagerStyle>

                    <RowStyle BackColor="#E7E7FF" ForeColor="#4A3C8C"></RowStyle>
                </asp:DetailsView>

            </div>
            <div id="postlist" style="width: 1150px">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString='<%$ ConnectionStrings:BosTon_BBSConnectionString1 %>' SelectCommand="SELECT * FROM [Tb_Post] ORDER BY [Post_PostTime] DESC" DeleteCommand="DELETE FROM [Tb_Post] WHERE [Post_ID] = @Post_ID" InsertCommand="INSERT INTO [Tb_Post] ([Post_CityID], [Post_OtherCity], [Post_Type], [Post_UserID], [Post_Title], [Post_Click], [Post_PostTime], [Post_LastEditTime], [Post_DefaultSort]) VALUES (@Post_CityID, @Post_OtherCity, @Post_Type, @Post_UserID, @Post_Title, @Post_Click, @Post_PostTime, @Post_LastEditTime, @Post_DefaultSort)" UpdateCommand="UPDATE [Tb_Post] SET [Post_CityID] = @Post_CityID, [Post_OtherCity] = @Post_OtherCity, [Post_Type] = @Post_Type, [Post_UserID] = @Post_UserID, [Post_Title] = @Post_Title, [Post_Click] = @Post_Click, [Post_PostTime] = @Post_PostTime, [Post_LastEditTime] = @Post_LastEditTime, [Post_DefaultSort] = @Post_DefaultSort WHERE [Post_ID] = @Post_ID">
                    <DeleteParameters>
                        <asp:Parameter Name="Post_ID" Type="Int32"></asp:Parameter>
                    </DeleteParameters>
                    <InsertParameters>
                        <asp:Parameter Name="Post_CityID" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Post_OtherCity" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Post_Type" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Post_UserID" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Post_Title" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Post_Click" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Post_PostTime" Type="DateTime"></asp:Parameter>
                        <asp:Parameter Name="Post_LastEditTime" Type="DateTime"></asp:Parameter>
                        <asp:Parameter Name="Post_DefaultSort" Type="Int32"></asp:Parameter>
                    </InsertParameters>
                    <UpdateParameters>
                        <asp:Parameter Name="Post_CityID" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Post_OtherCity" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Post_Type" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Post_UserID" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Post_Title" Type="String"></asp:Parameter>
                        <asp:Parameter Name="Post_Click" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Post_PostTime" Type="DateTime"></asp:Parameter>
                        <asp:Parameter Name="Post_LastEditTime" Type="DateTime"></asp:Parameter>
                        <asp:Parameter Name="Post_DefaultSort" Type="Int32"></asp:Parameter>
                        <asp:Parameter Name="Post_ID" Type="Int32"></asp:Parameter>
                    </UpdateParameters>
                </asp:SqlDataSource>
                <asp:GridView ID="GridView1" runat="server" Width="1150px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" DataKeyNames="Post_ID" DataSourceID="SqlDataSource1" AllowPaging="True" AllowSorting="True" CellPadding="3" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                    <Columns>
                        <asp:CommandField ShowEditButton="True" ShowSelectButton="True"></asp:CommandField>
                        <asp:BoundField DataField="Post_ID" HeaderText="Post_ID" ReadOnly="True" SortExpression="Post_ID" InsertVisible="False"></asp:BoundField>
                        <asp:BoundField DataField="Post_Type" HeaderText="Post_Type" SortExpression="Post_Type"></asp:BoundField>
                        <asp:BoundField DataField="Post_OtherCity" HeaderText="推送其他城市" SortExpression="Post_OtherCity"></asp:BoundField>
                        <asp:BoundField DataField="Post_UserID" HeaderText="Post_UserID" SortExpression="Post_UserID" ReadOnly="True"></asp:BoundField>
                        <asp:BoundField DataField="Post_Title" HeaderText="Post_Title" SortExpression="Post_Title"></asp:BoundField>
                        <asp:BoundField DataField="Post_PostTime" HeaderText="Post_PostTime" SortExpression="Post_PostTime"></asp:BoundField>
                    </Columns>

                    <FooterStyle BackColor="White" ForeColor="#000066"></FooterStyle>

                    <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White"></HeaderStyle>

                    <PagerStyle HorizontalAlign="Left" BackColor="White" ForeColor="#000066"></PagerStyle>

                    <RowStyle ForeColor="#000066"></RowStyle>

                    <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White"></SelectedRowStyle>

                    <SortedAscendingCellStyle BackColor="#F1F1F1"></SortedAscendingCellStyle>

                    <SortedAscendingHeaderStyle BackColor="#007DBB"></SortedAscendingHeaderStyle>

                    <SortedDescendingCellStyle BackColor="#CAC9C9"></SortedDescendingCellStyle>

                    <SortedDescendingHeaderStyle BackColor="#00547E"></SortedDescendingHeaderStyle>
                </asp:GridView>
            </div>

            <div id="maincontent" style="width: 1150px">
                <iframe id="content" width="1150" height="500" runat="server" src="/Default.aspx"></iframe>
            </div>
        </div>
    </form>
</body>
</html>
