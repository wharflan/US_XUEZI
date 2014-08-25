using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Session["CheckCode"] != TextBox5.Text)
                {
                    Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
                    string sqltemp = "User_Email='" + TextBox8.Text + "' and User_Password = '" + TextBox2.Text +"'";
                    List<Maticsoft.Model.Tb_User> mlu = bu.GetModelList(sqltemp);
                    if (mlu.Count == 1)
                    {
                        CookieLibrary.AddCookie("User_ID", mlu[0].User_ID.ToString(), DateTime.Now.AddDays(10));
                        CookieLibrary.AddCookie("City_ID", mlu[0].User_CityID.ToString(), DateTime.Now.AddDays(10));
                        Response.Redirect("/Default.aspx");
                    }
                    else
                    {
                        Label1.Text = "用户账户错误";
                    }
                }
                else
                {
                    Label1.Text = "验证码错误";
                }
            }
            catch (Exception exp)
            {
                Label1.Text = "请填写账户名 密码" + exp.Message;
            }

        }

    }
}