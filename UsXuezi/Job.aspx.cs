using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi
{
    public partial class Job : System.Web.UI.Page
    {
        Maticsoft.Model.Tb_Post mp;
        Maticsoft.Model.Tb_PostJob mpj;
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
                Maticsoft.BLL.Tb_PostJob bpj = new Maticsoft.BLL.Tb_PostJob();
                mpj = EModel.getJob(postid);
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
                Label2.Text = "";

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
    }
}