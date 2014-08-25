using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls
{
    public partial class BusinessCard : System.Web.UI.UserControl
    {
        protected HttpCookie cookie;
        protected Maticsoft.Model.Tb_PostBusiness mpb;
        protected Maticsoft.Model.Tb_Post mp;

        int businessid;

        public int Businessid
        {
            get { return businessid; }
            set { businessid = value; }
        }

        int currentUserID;

        protected void Page_Load(object sender, EventArgs e)
        {
            Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
            cookie = CookieLibrary.GetCookie("User_ID");
            if (cookie != null)
            {
                currentUserID = int.Parse(cookie.Value);
            }

            Maticsoft.BLL.Tb_PostBusiness btb = new Maticsoft.BLL.Tb_PostBusiness();
            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            if (businessid != 0)
            {
                mpb = btb.GetModel(businessid);
                mp = bp.GetModel(businessid);
            }

            if (mpb != null)
            {
                buildCard();
            }
            else
            {
                //preview mode
            }
        }

        protected void buildModel()
        {

        }

        protected void buildCard()
        {
            Image1.ImageUrl = mpb.Business_Cover;
            Label1.Text = mp.Post_Title;
            Label3.Text = mpb.Business_Description;
            if (mpb.Business_Phone != null && mpb.Business_Phone != "")
            {
                Label5.Text = "电话&emsp;" + mpb.Business_Phone;
            }
            else
                Label5.Text = "";


            if (mpb.Business_Email != null && mpb.Business_Email != "")
            {
                Label6.Text = "邮箱&emsp;" + mpb.Business_Email;
            }
            else
                Label6.Text = "";

            if (mpb.Business_Wechat != null && mpb.Business_Wechat != "")
            {
                Label7.Text = "微信&emsp;" + mpb.Business_Wechat;
            }
            else
                Label7.Text = "";

            Maticsoft.BLL.Tb_City bc = new Maticsoft.BLL.Tb_City();
            Maticsoft.Model.Tb_City mc = bc.GetModel((int)mp.Post_CityID);
            Label4.Text = "地址&emsp;" + mc.City_NameCH + "地区";

            if (mpb.Business_AreaID != null && mpb.Business_AreaID != 0)
            {
                Maticsoft.BLL.Tb_Area ba = new Maticsoft.BLL.Tb_Area();
                Maticsoft.Model.Tb_Area ma = ba.GetModel((int)mpb.Business_AreaID);
                Label4.Text += "&emsp;" + ma.Area_Name;
            }

            if (mpb.Business_Address != null && mpb.Business_Address != "")
            {
                Label4.Text += "&emsp;" + mpb.Business_Address;
            }

            if (mpb.Business_QQ != null && mpb.Business_QQ != "")
            {
                Label9.Text = "QQ&emsp;" + mpb.Business_QQ;
            }
            else
                Label9.Text = "";

            if (cookie != null)
            {
                if (mp.Post_UserID != currentUserID)
                {
                    if (UserOperation.isFollowedPost(currentUserID, (int)mp.Post_UserID))
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

        //关注 Maticsoft.Model.Tb_UsertoPost
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (cookie != null)
            {
                if (currentUserID != mp.Post_UserID)
                {
                    if (UserOperation.isFollowedPost(currentUserID, (int)mp.Post_UserID))
                    {

                        UserOperation.cancelFollowPost(currentUserID, (int)mp.Post_UserID);
                        Button2.Text = "关注";
                    }
                    else
                    {
                        UserOperation.followPost(currentUserID, (int)mp.Post_UserID);
                        Button2.Text = "已关注";
                    }
                }
                else
                {
                    //修改个人信息
                    if (mp.Post_Type == 2)
                    {
                        EFun.Redirect_Webconfig(("BusinessPublish"), "?id=" + mp.Post_ID + "&method=Edit");
                    }
                    else
                    {
                        EFun.Redirect_Webconfig(("FoodPublish"), "?id=" + mp.Post_ID + "&method=Edit");
                    }
                }
            }
            else
            {
                Response.Write("<script>alert('请先登陆哟~')</script>");
            }

        }
        public Boolean PreviewBC(Maticsoft.Model.Tb_Post pmpb, Maticsoft.Model.Tb_PostBusiness pmpu)
        {
            try
            {
                mp = pmpb;
                mpb = pmpu;
                return true;
            }

            catch (Exception)
            {
                return false;
            }
        }
    }
}