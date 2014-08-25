using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UsXuezi.UserControls;

namespace UsXuezi
{
    public partial class QuestionAnswer : System.Web.UI.Page
    {
        Maticsoft.Model.Tb_Post mp;
        Maticsoft.Model.Tb_PostNormal mpn;
        List<Maticsoft.Model.Tb_Tag> mlt;
        List<Maticsoft.Model.Tb_Reply> mlr;
        int PostID;
        HttpCookie cookieUser;

        Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
        Maticsoft.BLL.Tb_PostNormal bpn = new Maticsoft.BLL.Tb_PostNormal();
        Maticsoft.BLL.Tb_Tag bt = new Maticsoft.BLL.Tb_Tag();
        Maticsoft.BLL.Tb_Reply br = new Maticsoft.BLL.Tb_Reply();


        protected void Page_Load(object sender, EventArgs e)
        {

            cookieUser = CookieLibrary.GetCookie("User_ID");
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
                    mp = (Maticsoft.Model.Tb_Post)Session["QA_pmp"];
                    mpn = (Maticsoft.Model.Tb_PostNormal)Session["QA_pmpn"];
                    mlt = (List<Maticsoft.Model.Tb_Tag>)Session["QA_pmlt"];
                    Button1.Visible = false;
                }
            }

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
                mp = bp.GetModel(postid);
                mpn = bpn.GetModel(postid);
                mlt = bt.GetModelList("Tag_PostID = " + postid);
                mlr = br.GetModelList("Reply_PostID=" + postid + " and Reply_Status=0");
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
                Label2.Text = "发布时间：" + mp.Post_PostTime + " 回答（" + mlr.Count + "）";
                Label3.Text = mpn.Post_Content;
                foreach (Maticsoft.Model.Tb_Tag tag in mlt)
                {
                    LinkButton lb = new LinkButton();
                    lb.CssClass = "blue_tag";
                    lb.Text = tag.Tag_Content;
                    tagblock.Controls.Add(lb);
                }
                if (cookieUser.Value == mp.Post_UserID.ToString() && mp.Post_ID != 0)
                {
                    LinkButton1.PostBackUrl = EFun.getAddress("QAPublish") + "?id=" + mp.Post_ID + "&method=Edit";
                    LinkButton1.Visible = true;
                }

                foreach (Maticsoft.Model.Tb_Reply temp in mlr)
                {
                    ReplyBlock rb = new ReplyBlock();
                    rb = (ReplyBlock)rb.LoadControl("/UserControls/ReplyBlock.ascx");
                    rb.Replyid = temp.Reply_ID;
                    rb.ID = rb.Replyid.ToString();
                    AnswerPart.Controls.Add(rb);
                }


                return true;
            }
            catch
            {
                Editor1.SetContent("出错了");
                return false;
            }

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            if (cookieUser != null)
            {
                myanswer.Visible = false;
            }
            else { }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            //提交回复
            Maticsoft.BLL.Tb_Reply br = new Maticsoft.BLL.Tb_Reply();
            Maticsoft.Model.Tb_Reply mr = new Maticsoft.Model.Tb_Reply();
            mr.Reply_Content = Editor1.GetContent();
            mr.Reply_PostID = mp.Post_ID;
            mr.Reply_UserID = int.Parse(cookieUser.Value);
            br.Add(mr);

            AnswerPart.Controls.Clear();
            mlr = br.GetModelList("Reply_PostID=" + mp.Post_ID + " and Reply_Status=0");
            foreach (Maticsoft.Model.Tb_Reply temp in mlr)
            {
                ReplyBlock rb = new ReplyBlock();
                rb = (ReplyBlock)rb.LoadControl("/UserControls/ReplyBlock.ascx");
                rb.Replyid = temp.Reply_ID;
                rb.ID = rb.Replyid.ToString();
                AnswerPart.Controls.Add(rb);
            }

            if (myanswer.Visible)
            {
                myanswer.Visible = false;
            }
            else
            {
                myanswer.Visible = true;
            }
        }
    }
}