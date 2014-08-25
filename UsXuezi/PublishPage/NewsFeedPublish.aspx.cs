using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.PublishPage
{
    public partial class NewsFeedPublish : System.Web.UI.Page
    {
        HttpCookie cookieUser;
        HttpCookie cookieCity;
        protected static Maticsoft.Model.Tb_Post mp;
        protected static Maticsoft.Model.Tb_PostNormal mpn;
        protected static List<Maticsoft.Model.Tb_Tag> mlt;

        protected void Page_Load(object sender, EventArgs e)
        {
            cookieUser = CookieLibrary.GetCookie("User_ID");
            cookieCity = CookieLibrary.GetCookie("City_ID");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Label1.Text = "";
            
            if (!IsPostBack)
            {
                TextBox1.Visible = false;
                Button5.Visible = false;
            }

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
           
        }

        //publish
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (buildPost())
            {
                //Add to Tb_Post
                Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
                bp.Add(mp);
                int a = bp.GetMaxId();
                mp = bp.GetModel(bp.GetMaxId() - 1);
                //Add to Tb_PostNormal
                Maticsoft.BLL.Tb_PostNormal bpn = new Maticsoft.BLL.Tb_PostNormal();
                mpn.Post_ID = mp.Post_ID;
                bpn.Add(mpn);
                //Add to Tb_Tag
                Maticsoft.BLL.Tb_Tag bt = new Maticsoft.BLL.Tb_Tag();
                mlt = new List<Maticsoft.Model.Tb_Tag>();
                foreach (Maticsoft.Model.Tb_Tag mt in mlt)
                {
                    mt.Tag_PostID = mp.Post_ID;
                    bt.Add(mt);
                }
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["Chat"] + "?id=" + mp.Post_ID);
            }

        }

        //preview
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (buildPost())
            {
                Session["chat_pmp"] = mp;
                Session["chat_pmpn"] = mpn;
                Session["chat_pmlt"] = mlt;
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["Chat"] + "?id=0");
            }
        }
        //Add Tags
        protected void Button4_Click(object sender, EventArgs e)
        {
            if (mlt == null)
                mlt = new List<Maticsoft.Model.Tb_Tag>();
            if (mlt.Count < 10)
            {
                if (TextBox1.Visible)
                {
                    TextBox1.Visible = false;
                    Button5.Visible = false;
                }
                else
                {
                    TextBox1.Visible = true;
                    Button5.Visible = true;
                }
            }
            else
            {
                Label1.Text = "最多只支持10个tag!";
            }
        }

        //build model in Post, NormalPost(No Post_ID), Tag(No Post_ID)
        protected Boolean buildPost()
        {
            if (TextBox2.Text != "")
            {

                mp = new Maticsoft.Model.Tb_Post();
                mp.Post_Title = TextBox2.Text;
                mp.Post_CityID = int.Parse(cookieCity.Value);
                mp.Post_Type = 8;
                mp.Post_UserID = int.Parse(cookieUser.Value);
                mpn = new Maticsoft.Model.Tb_PostNormal();
                mpn.Post_Content = Editor1.GetContent();

                return true;
            }
            else
            {
                TextBox2.Attributes.Add("placeholder", "标题不能为空！");
                return false;
            }

        }
        //add tag
        protected void Button5_Click(object sender, EventArgs e)
        {
            string newtag = TextBox1.Text;
            if (newtag != "")
            {
                Maticsoft.Model.Tb_Tag mt = new Maticsoft.Model.Tb_Tag();
                mt.Tag_Content = newtag;
                if (mlt == null)
                {
                    mlt = new List<Maticsoft.Model.Tb_Tag>();
                }
                mlt.Add(mt);
                Label1.Text = "Tag添加成功！共有" + mlt.Count + "个";
                TextBox1.Visible = false;
                Button5.Visible = false;
            }
            else
                TextBox1.Attributes.Add("placeholder", "Tag不能为空！");
        }
    }
}