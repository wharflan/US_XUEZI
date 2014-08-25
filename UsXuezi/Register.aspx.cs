using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UsXuezi.UserControls;

namespace UsXuezi.PublishPage
{
    public partial class Register : System.Web.UI.Page
    {
        Maticsoft.Model.Tb_User mu;

        protected void Page_Load(object sender, EventArgs e)
        {
            EFun.Redirect_Webconfig("DefaultPage");
        }

        protected void RadioButtonList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (RadioButtonList1.SelectedValue == "1")
            {
                specialblock.Attributes.Add("style", "display:none");

                Label2.Text = "用户名";
            }
            else
            {
                specialblock.Attributes.Add("style", "display:block");
                Label2.Text = "机构名称";
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                mu = new Maticsoft.Model.Tb_User();
                if (RadioButtonList1.SelectedValue == "1")
                {
                    mu.User_Type = 2;
                }
                else
                {
                    mu.User_Type = DropDownList1.SelectedIndex + 3;
                }
                mu.User_UserName = TextBox3.Text;
                mu.User_Email = TextBox8.Text;
                mu.User_Password = TextBox2.Text;
                mu.User_Status = 0;
                mu.User_CityID = DropDownList2.SelectedIndex + 1;
                string message = checkavailable(mu);
                if (message == "OK")
                {
                    string linkcode = "bostonxuezi.com/AccountActive.aspx?link=" + Maticsoft.DBUtility.DESEncrypt.Encrypt(mu.User_UserName);
                    SendEMail.sendmail(mu.User_Email, "UsXuezi激活", "点击<a href='" + linkcode + "'>这里</a>激活,或者输入以下地址" + linkcode);
                    Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
                    bu.Add(mu);
                }
                else
                    EFun.Alert(message);
            }
            catch (Exception)
            {
                throw;
            }
        }

        //
        protected string checkavailable(Maticsoft.Model.Tb_User mu)
        {
            Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
            List<Maticsoft.Model.Tb_User> mtu = new List<Maticsoft.Model.Tb_User>();
            mtu = bu.GetModelList("User_Email ='" + mu.User_Email+"'");
            if(mtu.Count>0)
            {
                return "邮箱已注册";
            }
            mtu = bu.GetModelList("User_UserName ='" + mu.User_UserName+"'");
            if (mtu.Count > 0)
            {
                return "用户名已注册";
            }
            if (TextBox2.Text != TextBox1.Text)
            {
                return "密码不一样";
            }
            //others
            return "OK";
        }
    }
}