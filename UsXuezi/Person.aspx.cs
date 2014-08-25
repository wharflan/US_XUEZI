using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi
{
    public partial class Person : System.Web.UI.Page
    {
        Maticsoft.Model.Tb_User currentuser; //this model in person
        int UserID; // this userID

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                Maticsoft.BLL.Tb_User obu = new Maticsoft.BLL.Tb_User();
                if (Request.QueryString["id"] != null)
                {
                    UserID = int.Parse(Request.QueryString["id"]);
                }
                else
                    UserID = int.Parse(CookieLibrary.GetCookie("User_ID").Value);
                currentuser = obu.GetModel(UserID);
                buildPage();
            }
            catch (Exception)
            {
                EFun.Alert("请先登录");
            }
        }

        protected Boolean buildPage()
        {
            StudentCard1.Userid = UserID;
            Label7.Text = currentuser.User_UserName + "的发布";
            Label1.Text = currentuser.User_UserName + "的回复";

            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            List<Maticsoft.Model.Tb_Post> mlp = bp.GetModelList("Post_UserID=" + currentuser.User_ID);

            foreach (Maticsoft.Model.Tb_Post mp in mlp)
            {
                try
                {
                    LinkButton lb = new LinkButton();
                    lb.PostBackUrl = EFun.GetPostUrl(mp.Post_ID);
                    lb.Text = mp.Post_Title;
                    lb.Attributes.Add("style", "display:block");
                    publishpart.Controls.Add(lb);
                }
                catch (Exception)
                {
                    continue;
                }

            }

            Maticsoft.BLL.Tb_Reply br = new Maticsoft.BLL.Tb_Reply();
            List<Maticsoft.Model.Tb_Reply> mlr = br.GetModelList("Reply_UserID=" + currentuser.User_ID);

            foreach (Maticsoft.Model.Tb_Reply mr in mlr)
            {
                try
                {
                    LinkButton lb = new LinkButton();
                    lb.PostBackUrl = EFun.GetPostUrl((int)mr.Reply_PostID);
                    Insus.NET.InsusCharacterUtility icu = new Insus.NET.InsusCharacterUtility();
                    lb.Text = "<p>" + icu.BriefContent(mr.Reply_Content, 20) + "</p>";
                    lb.Attributes.Add("style", "display:block");
                    replypart.Controls.Add(lb);
                }
                catch (Exception)
                {
                    continue;
                }
            }
            string sex = "保密";
            switch (currentuser.User_Sex)
            {
                case 1:
                    sex = "男";
                    break;
                case 2:
                    sex = "女";
                    break;
            }
            Label9.Text = "性别:" + sex;
            Label3.Text = "生日:" + currentuser.User_Birth;
            Label4.Text = "QQ:" + currentuser.User_QQ;
            Label5.Text = "邮箱:" + currentuser.User_Email;
            Label6.Text = "微博:" + currentuser.User_Weibo;
            Label8.Text = "微信:" + currentuser.User_Wechat;

            return true;
        }

    }
}