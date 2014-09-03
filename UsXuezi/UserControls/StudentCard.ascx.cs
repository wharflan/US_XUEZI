using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls
{
    public partial class StudentCard : System.Web.UI.UserControl
    {
        protected HttpCookie cookie;
        protected Maticsoft.Model.Tb_User student;

        string cardtype = "";

        public string CardType  //long or short
        {
            get { return cardtype; }
            set { cardtype = value; }
        }

        int userid = 0;

        public int Userid
        {
            get { return userid; }
            set { userid = value; }
        }

        int currentUserID;
        int pageUserID;

        protected void Page_Load(object sender, EventArgs e)
        {
            Maticsoft.BLL.Tb_User stub = new Maticsoft.BLL.Tb_User();
            cookie = CookieLibrary.GetCookie("User_ID");
            if (cookie != null)
            {
                currentUserID = int.Parse(cookie.Value);
            }

            if (userid != 0)
            {
                student = stub.GetModel(userid);
                pageUserID = student.User_ID;
            }

            if (student != null)
            {
                if (cardtype == "long")
                {
                    buildlongbar();
                }
                else
                    buildshortbar();
            }
            else
            {
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["404"]);
            }
        }

        protected void buildshortbar()
        {
            Card.Controls.Remove(longbar);
            Image2.ImageUrl = "/Uploads/Image/User/" + student.User_ID + ".jpg";
            Image2.PostBackUrl = "/Person.aspx?id=" + student.User_ID;
            Label5.Text = student.User_UserName;
            Maticsoft.BLL.Tb_City obc = new Maticsoft.BLL.Tb_City();
            Maticsoft.Model.Tb_City omc = obc.GetModel((int)student.User_CityID);
            Label7.Text = "所在地：" + omc.City_NameCH;
            Label8.Text = "毕业/就读于" + student.User_School;
            if (cookie != null)
            {
                if (pageUserID != currentUserID)
                {
                    if (UserOperation.isFollowedUser(currentUserID, pageUserID))
                    {
                        Button4.Text = "已关注";
                    }
                    else
                    {
                        Button4.Text = "关注";
                    }
                }
                else
                {
                    Button3.Text = "个人备忘";
                    Button4.Text = "编辑信息";
                }
            }
            else
            {
                Button4.Text = "关注";
            }

        }

        protected void buildlongbar()
        {
            Card.Controls.Remove(shortbar);
            //Image1.ImageUrl = "/Uploads/Image/User/" + student.User_ID + ".jpg";
            //Image1.PostBackUrl = "/Person.aspx?id=" + student.User_ID;
            Label4.Text = "新生";
            Label1.Text = student.User_UserName;
            Label6.Text = student.User_Description;
            Maticsoft.BLL.Tb_City obc = new Maticsoft.BLL.Tb_City();
            Maticsoft.Model.Tb_City omc = obc.GetModel((int)student.User_CityID);
            Label2.Text = "所在地：" + omc.City_NameCH;
            Label3.Text = "毕业/就读于" + student.User_School;
            if (cookie != null)
            {
                if (pageUserID != currentUserID)
                {
                    if (UserOperation.isFollowedUser(currentUserID, pageUserID))
                    {
                        Button2.Text = "已关注";
                    }
                    else
                    {
                        Button2.Text = "关注";
                    }
                }
                else
                {
                    Button2.Text = "编辑信息";
                }
            }
        }

        //私信 Maticsoft.Model.Tb_Mail
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (cookie != null)
            {
                //私信
            }
            else
            {
                Response.Write("<script>alert('请先登陆哟~')</script>");
            }

        }

        //关注 Maticsoft.Model.Tb_FollowUser
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (cookie != null)
            {
                if (currentUserID != pageUserID)
                {
                    if (UserOperation.isFollowedUser(currentUserID, pageUserID))
                    {

                        UserOperation.cancelFollowUser(currentUserID, pageUserID);
                        Button2.Text = "关注";
                        Button4.Text = "关注";
                    }
                    else
                    {
                        UserOperation.followUser(currentUserID, pageUserID);
                        Button2.Text = "已关注";
                        Button4.Text = "已关注";
                    }
                }
                else
                {
                    //修改个人信息
                    EFun.Redirect_Webconfig("EditPerson");
                }
            }
            else
            {
                Response.Write("<script>alert('请先登陆哟~')</script>");
            }
        }
    }
}