using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsXuezi
{
    public class EFun
    {
        public static void Alert(string message)
        {
            HttpContext.Current.Response.Write("<script>alert('" + message + "')</script>");
        }

        public static void Redirect_Webconfig(string keyword)
        {
            string address = System.Configuration.ConfigurationManager.AppSettings[keyword];
            HttpContext.Current.Response.Redirect(address);
        }

        public static void Redirect_Webconfig(string keyword, string parameter)
        {
            string address = System.Configuration.ConfigurationManager.AppSettings[keyword];
            HttpContext.Current.Response.Redirect(address + parameter);
        }

        public static string GetKey(string keyword)
        {
            string address = System.Configuration.ConfigurationManager.AppSettings[keyword];
            return address;
        }

        public static string getAddress(string keyword)
        {
            string address = System.Configuration.ConfigurationManager.AppSettings[keyword];
            return address;
        }

        public void movePics(int userid, int postid)
        {

        }

        public static Boolean VerifyUser(string id)
        {
            HttpCookie currentuser = CookieLibrary.GetCookie("User_ID");
            if (currentuser != null)
            {
                if (currentuser.Value == id)
                {
                    return true;
                }
                else return false;
            }
            else return false;
        }

        public static string GetPostUrl(int postid)
        {
            string url = "";
            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            Maticsoft.Model.Tb_Post mp = bp.GetModel(postid);
            switch (mp.Post_Type)
            {
                case 1:
                    return GetKey("Estate") + "?id=" + postid;

                case 2:
                    return GetKey("Business") + "?id=" + postid;

                case 3:
                    return GetKey("Rent") + "?id=" + postid;

                case 4:
                    return GetKey("Item") + "?id=" + postid;

                case 5:
                    return GetKey("UsedCar") + "?id=" + postid;

                case 6:
                    return GetKey("Job") + "?id=" + postid;

                case 7:
                    return GetKey("QA") + "?id=" + postid;

                case 8:
                    return GetKey("Chat") + "?id=" + postid;

                case 9:
                    return GetKey("Business") + "?id=" + postid;

            }
            return url;
        }

    }
}