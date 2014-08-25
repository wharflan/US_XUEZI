using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi
{
    public partial class EditPerson : System.Web.UI.Page
    {
        protected Maticsoft.Model.Tb_User mu;
        protected static Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
        protected HttpCookie currentUser;

        protected void Page_Load(object sender, EventArgs e)
        {
            currentUser = CookieLibrary.GetCookie("User_ID");
            if (!IsPostBack)
            {
                if (currentUser != null)
                {
                    fillblank();
                }
                else
                {
                    EFun.Redirect_Webconfig("Error");
                }
            }
        }

        protected Boolean fillblank()
        {
            mu = bu.GetModel(int.Parse(currentUser.Value));
            TextBox8.Text = mu.User_UserName;
            DropDownList1.SelectedValue = mu.User_CityID.ToString();
            TextBox12.Text = mu.User_Description;
            TextBox3.Text = mu.User_Birth;
            TextBox9.Text = mu.User_Major;
            DropDownList2.SelectedValue = mu.User_Sex.ToString();
            TextBox10.Text = mu.User_School;
            TextBox5.Text = mu.User_QQ;
            TextBox6.Text = mu.User_Wechat;
            TextBox7.Text = mu.User_Weibo;
            TextBox13.Text = mu.User_Phone;
            return true;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                mu = bu.GetModel(int.Parse(currentUser.Value));
                mu.User_UserName = TextBox8.Text;
                mu.User_CityID = int.Parse(DropDownList1.SelectedValue);
                mu.User_Description = TextBox12.Text;
                mu.User_Birth = TextBox3.Text;
                mu.User_Major = TextBox9.Text;
                mu.User_Sex = int.Parse(DropDownList2.SelectedValue);
                mu.User_School = TextBox10.Text;
                mu.User_QQ = TextBox5.Text;
                mu.User_Wechat = TextBox6.Text;
                mu.User_Weibo = TextBox7.Text;
                mu.User_Phone = TextBox13.Text;
                bu.Update(mu);
                EFun.Redirect_Webconfig("Person");
            }
            catch (Exception)
            {
                EFun.Redirect_Webconfig("Error");
            }
        }
    }
}