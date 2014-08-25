using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi
{
    public partial class Rent : System.Web.UI.Page
    {
        Maticsoft.Model.Tb_Post mp;
        Maticsoft.Model.Tb_PostRent mpr;
        int PostID;
        static HttpCookie cookie;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.QueryString["id"] != null)
            {
                if (Request.QueryString["id"] != "0")
                {
                    PostID = int.Parse(Request.QueryString["id"]);
                    buildModel(PostID);
                }
                else
                {
                    //run preview mode
                    mp = (Maticsoft.Model.Tb_Post)Session["Rent_pmp"];
                    mpr = (Maticsoft.Model.Tb_PostRent)Session["Rent_pmpr"];

                }
            }
            cookie = CookieLibrary.GetCookie("User_ID");

            buildPage();
        }

        //Item Page
        protected Boolean buildModel(int postid)
        {
            try
            {
                Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
                mp = bp.GetModel(postid);
                Maticsoft.BLL.Tb_PostRent bpr = new Maticsoft.BLL.Tb_PostRent();
                mpr = bpr.GetModel(mp.Post_ID);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        protected Boolean buildPage()
        {
            try
            {
                Label1.Text = mp.Post_Title;
                Maticsoft.BLL.Tb_City bc = new Maticsoft.BLL.Tb_City();
                Maticsoft.Model.Tb_City mc = bc.GetModel((int)mp.Post_CityID);
                Maticsoft.BLL.Tb_Area ba = new Maticsoft.BLL.Tb_Area();
                Maticsoft.Model.Tb_Area ma;
                string area = "";
                if (mpr.Rent_Area != null)
                {
                    ma = ba.GetModel((int)mpr.Rent_Area);
                    area = ma.Area_Name;
                }

                if (EFun.VerifyUser(mp.Post_UserID.ToString()))
                {
                    LinkButton7.Visible = true;
                }
                PicView1.Names = mpr.Rent_Images;
                Label2.Text = mc.City_NameCH + "&emsp;" + area + "&emsp;" + "发布于" + mp.Post_PostTime;
                StudentCard1.Userid = (int)mp.Post_UserID;
                Label5.Text = mpr.Rent_Description;

                if (mpr.Rent_IsSingleRoom == 1)
                {
                    Label13.Text = "单间&emsp;";
                }
                if (mpr.Rent_IsWholeBuilding == 1)
                {
                    Label13.Text += "整套";
                }

                if (Label13.Text == "")
                {
                    Label13.Text = "整套";
                }

                if (mpr.Rent_Price != null)
                {
                    Label4.Text = "基本月租&emsp;$" + mpr.Rent_Price;
                }

                if (mpr.Rent_StreetPark != 0 && mpr.Rent_StreetPark != null)
                {
                    Label14.Text = "街趴&emsp;";
                }
                if (mpr.Rent_Garage != 0 && mpr.Rent_StreetPark != null)
                {
                    Label14.Text += "车库";
                }
                if (Label14.Text == "")
                {
                    Label14.Text = "无";
                }

                if (mpr.Rent_Start != null)
                {
                    Label8.Text = "租期&emsp;" + ((DateTime)mpr.Rent_Start).ToShortDateString();
                }
                if (mpr.Rent_End != null && mpr.Rent_End > mpr.Rent_Start)
                {
                    Label8.Text += "至" + ((DateTime)mpr.Rent_End).ToShortDateString();
                }
                else Label9.Text = "";

                Label10.Text = "";

                if (mpr.Rent_Address != null && mpr.Rent_Address != "")
                {
                    Label11.Text = "地址&emsp;" + mpr.Rent_Address;
                    MapBlock1.Address = mpr.Rent_Address;
                }
                else
                    Label11.Text = "";

                Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
                Maticsoft.Model.Tb_User mu = bu.GetModel((int)mp.Post_UserID);
                if (mpr.Rent_Wechat != null && mpr.Rent_Wechat != "")
                {
                    Label12.Text = "微信&emsp;" + mpr.Rent_Wechat;
                }
                else
                    Label12.Text = "";

                if (mpr.Rent_QQ != null && mpr.Rent_QQ != "")
                {
                    Label15.Text = "QQ&emsp;" + mpr.Rent_QQ;
                }
                else
                    Label15.Text = "";

                if (mpr.Rent_Email != null && mpr.Rent_Email != "")
                {
                    Label16.Text = "邮箱&emsp;" + mpr.Rent_Email;
                }
                else
                    Label16.Text = "";

                if (mpr.Rent_Phone != null && mpr.Rent_Phone != "")
                {
                    Label17.Text = "电话&emsp;" + mpr.Rent_Phone;
                }
                else
                    Label17.Text = "";





                //相似区
                buildsimilar();

                return true;
            }
            catch
            {

                return false;
            }

        }

        protected Boolean buildsimilar()
        {
            return true;
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {

            EFun.Redirect_Webconfig(("RentPublish"), "?id=" + mp.Post_ID + "&method=Edit");
        }
    }
}