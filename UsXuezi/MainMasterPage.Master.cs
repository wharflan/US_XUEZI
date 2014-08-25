using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi
{
    public partial class MainMasterPage : System.Web.UI.MasterPage
    {
        protected HttpCookie cookieUser;
        protected HttpCookie cookieCity;


        protected void Page_Load(object sender, EventArgs e)
        {
            cookieUser = CookieLibrary.GetCookie("User_ID");
            if (cookieUser != null)
            {
                if (cookieUser.Value != "0")
                {
                    iflogin.Controls.Remove(not_login);
                }
                else
                {
                    iflogin.Controls.Remove(infoblock);
                }
            }
            else
                iflogin.Controls.Remove(infoblock);

            if (Request.QueryString["city"] != null)
            {
                int cityid = int.Parse(Request.QueryString["city"]);
                if (cityid >= 1 && cityid <= 5)
                {
                    CookieLibrary.SetCookie("City_ID", cityid.ToString(), DateTime.Now.AddDays(10));
                    Session["City_ID"] = cityid.ToString();
                    Maticsoft.BLL.Tb_City bc = new Maticsoft.BLL.Tb_City();
                    Maticsoft.Model.Tb_City mc = bc.GetModel(cityid);
                    Session["City_Name"] = mc.City_NameCH;
                }
                else
                {
                    CookieLibrary.SetCookie("City_ID", "1", DateTime.Now.AddDays(10));
                    Session["City_ID"] = "1";
                    Session["City_Name"] = "波士顿";
                }
            }
            if (CookieLibrary.GetCookie("City_ID") == null)
            {
                CookieLibrary.SetCookie("City_ID", "1", DateTime.Now.AddDays(10));
            }

            if (Session["City_ID"] == null)
            {
                Session["City_ID"] = "1";
                Session["City_Name"] = "波士顿";
            };
            cookieCity = CookieLibrary.GetCookie("City_ID");
            if (!IsPostBack)
            {
                DropDownList1.SelectedValue = Session["City_ID"].ToString();
            }
        }


        protected void sml_profile_Click(object sender, ImageClickEventArgs e)
        {

            Response.Redirect("~/Person.aspx");

        }


        protected void alert_icon_Click(object sender, ImageClickEventArgs e)
        {
            CookieLibrary.RemoveCookie("User_ID");
            EFun.Redirect_Webconfig("DefaultPage");
        }


        protected void register_Click(object sender, EventArgs e)
        {
            EFun.Redirect_Webconfig("LogOut");
        }

        protected void logon_Click(object sender, EventArgs e)
        {
            EFun.Redirect_Webconfig("Login");
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            CookieLibrary.SetCookie("City_ID", DropDownList1.SelectedValue);
            Session["City_ID"] = DropDownList1.SelectedValue;
            Maticsoft.BLL.Tb_City bc = new Maticsoft.BLL.Tb_City();
            Maticsoft.Model.Tb_City mc = bc.GetModel(int.Parse(DropDownList1.SelectedValue));
            Session["City_Name"] = mc.City_NameCH;
            /*
            string url = Request.RawUrl.ToLower();
            if (url.Contains("city.aspx"))
            {
                if (url.Contains("&city="))
                    url = url.Substring(0, url.LastIndexOf("&"));
                Response.Redirect(url + "&city=" + DropDownList1.SelectedValue);
            }

            /* Clear cookie
            foreach (string cookieName in Request.Cookies.AllKeys)
            {
                HttpCookie cookie = Request.Cookies[cookieName];
                cookie.Expires = DateTime.Today.AddDays(-5);
                Response.Cookies.Add(cookie);
            }
             */
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["RentPublish"]);
        }
        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["ItemPublish"]);
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            //Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["UsedCarPublish"]);
        }
        protected void Button4_Click(object sender, EventArgs e)
        {
            //Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["EstatePublish"]);
        }
        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["FoodPublish"]);
        }
        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["BusinessPublish"]);
        }
        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["QAPublish"]);
        }
        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["ChatPublish"]);
        }

    }
}