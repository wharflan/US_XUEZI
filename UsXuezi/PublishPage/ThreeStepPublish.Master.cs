using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.PublishPage
{
    public partial class ThreeStepPublish : System.Web.UI.MasterPage
    {
        HttpCookie cookieUser;
        protected void Page_Load(object sender, EventArgs e)
        {
            cookieUser = CookieLibrary.GetCookie("User_ID");
            if (cookieUser == null)
            {
                //Not Login
                EFun.Redirect_Webconfig("Login");
            }
            else if (!CheckStatus())
            {
                //"无权限"
                EFun.Redirect_Webconfig("Error");
            }
        }

        protected Boolean CheckStatus()
        {
            Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
            Maticsoft.Model.Tb_User mu = bu.GetModel(int.Parse(cookieUser.Value));
            if (mu.User_Status != 1)
                return false;
            return true;
        }
    }
}