using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi
{
    public partial class NewsFeed : System.Web.UI.Page
    {
        Maticsoft.Model.Tb_Post mp;
        Maticsoft.Model.Tb_PostNormal mpn;
        List<Maticsoft.Model.Tb_Tag> mlt;
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
                    mp = (Maticsoft.Model.Tb_Post)Session["chat_pmp"];
                    mpn = (Maticsoft.Model.Tb_PostNormal)Session["chat_pmpn"];
                    mlt = (List<Maticsoft.Model.Tb_Tag>)Session["chat_pmlt"];

                }
            }
            cookie = CookieLibrary.GetCookie("User_ID");

            buildPage();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (myanswer.Visible)
            {
                myanswer.Visible = false;
            }
            else
            {
                myanswer.Visible = true;
            }
        }


        //Normal Page
        protected Boolean buildModel(int postid)
        {
            try
            {
                Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
                mp = bp.GetModel(postid);
                Maticsoft.BLL.Tb_PostNormal bpn = new Maticsoft.BLL.Tb_PostNormal();
                mpn = bpn.GetModel(postid);
                Maticsoft.BLL.Tb_Tag bt = new Maticsoft.BLL.Tb_Tag();
                mlt = bt.GetModelList("Tag_PostID = " + postid);

                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        //Build Page
        protected Boolean buildPage()
        {
            try
            {
                Label1.Text = mp.Post_Title;
                StudentCard1.Userid = (int)mp.Post_UserID;
                Maticsoft.BLL.Tb_Reply br = new Maticsoft.BLL.Tb_Reply();
                List<Maticsoft.Model.Tb_Reply> mlr = br.GetModelList("Reply_PostID=" + mp.Post_ID);
                Label2.Text = "发布时间：" + mp.Post_PostTime + " 回复（" + mlr.Count + "）";
                Label3.Text = mpn.Post_Content;
                foreach (Maticsoft.Model.Tb_Tag tag in mlt)
                {
                    LinkButton lb = new LinkButton();
                    lb.CssClass = "blue_tag";
                    lb.Text = tag.Tag_Content;
                    tagblock.Controls.Add(lb);
                }

                return true;
            }
            catch
            {
                QnA_answer.InnerText = "出错了";
                return false;
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (cookie != null)
            {
                QnA_answer.InnerText = "";
                myanswer.Visible = false;
            }
            else { }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //提交回复
            Maticsoft.BLL.Tb_Reply br = new Maticsoft.BLL.Tb_Reply();
            Maticsoft.Model.Tb_Reply mr = new Maticsoft.Model.Tb_Reply();
            mr.Reply_Content = QnA_answer.InnerText;
            mr.Reply_PostID = mp.Post_ID;
            mr.Reply_UserID = int.Parse(CookieLibrary.GetCookie("User_ID").Value);
            br.Add(mr);
        }
    }
}