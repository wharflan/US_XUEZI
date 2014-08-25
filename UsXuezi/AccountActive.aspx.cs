using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi
{
    public partial class AccountActive : System.Web.UI.Page
    {
        string linkcode;

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
                if (Request.QueryString["link"] != null)
                {
                    linkcode = Request.QueryString["link"];
                    string username = Maticsoft.DBUtility.DESEncrypt.Decrypt(linkcode);
                    bu = new Maticsoft.BLL.Tb_User();
                    List<Maticsoft.Model.Tb_User> mlu = bu.GetModelList("User_UserName='" + username + "'");
                    if (mlu.Count == 1)
                    {
                        EFun.Alert("激活成功");
                        mlu[0].User_Status = 1;
                        bu.Update(mlu[0]);
                        EFun.Alert("激活成功");
                        EFun.Redirect_Webconfig("DefaultPage");
                    }
                    else
                        EFun.Alert("激活失败");
                }
                EFun.Redirect_Webconfig("DefaultPage");
            }catch(Exception)
            {
                EFun.Alert("激活失败");
            }
        }
    }
}