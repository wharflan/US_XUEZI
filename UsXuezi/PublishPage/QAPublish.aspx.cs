using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.PublishPage
{
    public partial class QAPublish : System.Web.UI.Page
    {
        HttpCookie cookieUser;
        HttpCookie cookieCity;
        protected Maticsoft.Model.Tb_Post mp;
        protected Maticsoft.Model.Tb_PostNormal mpn;
        protected List<Maticsoft.Model.Tb_Tag> mlt;
        Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
        Maticsoft.BLL.Tb_PostNormal bpn = new Maticsoft.BLL.Tb_PostNormal();
        Maticsoft.BLL.Tb_Tag bt = new Maticsoft.BLL.Tb_Tag();


        protected void Page_Load(object sender, EventArgs e)
        {
            cookieUser = CookieLibrary.GetCookie("User_ID");
            cookieCity = CookieLibrary.GetCookie("City_ID");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Button3.Attributes.Add("onclick", "this.form.target='_blank'");
            Button2.Attributes.Add("onclick", "this.form.target=''");

            if (!IsPostBack)
            {
                tagblock.Visible = true;
                editorblock.Visible = false;
                //Edit Mode
                if (Request.QueryString["id"] != null && Request.QueryString["method"] != null)
                {
                    if (Request.QueryString["method"] == "Edit")
                    {
                        int postid = int.Parse(Request.QueryString["id"]);
                        mp = bp.GetModel(postid);
                        if (cookieUser.Value != mp.Post_UserID.ToString())
                        {
                            EFun.Redirect_Webconfig("404");
                        }
                        mpn = bpn.GetModel(postid);
                        mlt = bt.GetModelList("Tag_PostID = " + postid);
                        fillblank();
                    }
                }
                else
                {
                    //Publish Mode                
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            tagblock.Visible = true;
            defaulttag.Visible = true;
            if (editorblock.Visible)
                editorblock.Visible = false;
            else
                editorblock.Visible = true;
        }

        //publish
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (buildPost())
            {
                if (mp.Post_ID != 0)
                {
                    //Update
                    bp.Update(mp);
                    bpn.Update(mpn);
                    List<Maticsoft.Model.Tb_Tag> oldtags = bt.GetModelList("Tag_PostID = " + mp.Post_ID);
                    foreach (Maticsoft.Model.Tb_Tag mt in oldtags)
                    {
                        bt.Delete(mt.Tag_ID);
                    }

                    foreach (Maticsoft.Model.Tb_Tag mt in mlt)
                    {
                        mt.Tag_PostID = mp.Post_ID;
                        bt.Add(mt);
                    }
                }
                else
                {
                    //Publish
                    //Add to Tb_Post
                    bp.Add(mp);
                    int a = bp.GetMaxId();
                    mp = bp.GetModel(bp.GetMaxId() - 1);
                    //Add to Tb_PostNormal
                    mpn.Post_ID = mp.Post_ID;
                    bpn.Add(mpn);
                    //Add to Tb_Tag
                    if (mlt != null)
                    {
                        foreach (Maticsoft.Model.Tb_Tag mt in mlt)
                        {
                            mt.Tag_PostID = mp.Post_ID;
                            bt.Add(mt);
                        }
                    }

                }

                EFun.Redirect_Webconfig("QA", "?id=" + mp.Post_ID);
            }

        }

        //preview
        protected void Button3_Click(object sender, EventArgs e)
        {
            if (buildPost())
            {
                Session["QA_pmp"] = mp;
                Session["QA_pmpn"] = mpn;
                Session["QA_pmlt"] = mlt;
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["QA"] + "?id=0");
            }
        }

        //Click "Add Tags"Button
        protected void Button4_Click(object sender, EventArgs e)
        {
            editorblock.Visible = false;
            if (tagblock.Visible)
            {
                tagblock.Visible = false;
                defaulttag.Visible = false;
            }
            else
            {
                tagblock.Visible = true;
                defaulttag.Visible = true;
            }

        }

        //build model in Post, NormalPost(No Post_ID), Tag(No Post_ID)
        protected Boolean buildPost()
        {
            if (TextBox2.Text != "")
            {
                mp = new Maticsoft.Model.Tb_Post();
                mpn = new Maticsoft.Model.Tb_PostNormal();
                if (Request.QueryString["id"] != null)
                {
                    mp.Post_ID = int.Parse(Request.QueryString["id"]);
                    mpn.Post_ID = int.Parse(Request.QueryString["id"]);
                }

                mp.Post_Title = TextBox2.Text;
                mp.Post_CityID = int.Parse(cookieCity.Value);
                mp.Post_Type = 7;
                mp.Post_UserID = int.Parse(cookieUser.Value);

                mpn.Post_Content = Editor1.GetContent();
                mlt = tags1.GetTags();
                return true;
            }
            else
            {
                return false;
            }

        }
        //add tag
        protected void Button5_Click(object sender, EventArgs e)
        {
            string newtag = TextBox1.Text;
            if (newtag != "" && newtag != null)
            {
                Label3.Text = tags1.addtag(newtag);
            }
            else
                Label3.Text = "Tag不能为空!";
        }


        protected void fillblank()
        {
            TextBox2.Text = mp.Post_Title;
            Editor1.Placeholder = mpn.Post_Content;
            tags1.SetTags(mlt);
        }



        //Add Default tag (eventHandler)
        protected void addtag(Object sender, EventArgs e)
        {

            Button b = (Button)sender;
            Label3.Text = tags1.addtag(b.Text);
        }
    }
}