using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UsXuezi.UserControls;

namespace UsXuezi.PublishPage
{
    public partial class ItemPublish : System.Web.UI.Page
    {
        protected static HttpCookie cookieUser;
        protected static HttpCookie cookieCity;
        protected Maticsoft.Model.Tb_Post mp;
        protected Maticsoft.Model.Tb_PostItem mpi;
        protected Maticsoft.Model.Tb_User mu;

        protected static Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
        protected static Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
        protected static Maticsoft.BLL.Tb_PostItem bpi = new Maticsoft.BLL.Tb_PostItem();


        protected void Page_Load(object sender, EventArgs e)
        {
            cookieUser = CookieLibrary.GetCookie("User_ID");
            cookieCity = CookieLibrary.GetCookie("City_ID");
        }
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            //Label1.Text = "";
            //Button6.Attributes.Add("onclick", "this.form.target='_blank'");
            //Button3.Attributes.Add("onclick", "this.form.target=''");
            //mu = bu.GetModel(int.Parse(cookieUser.Value));

            //if (!IsPostBack)
            //{
            //    //Edit Mode
            //    if (Request.QueryString["id"] != null && Request.QueryString["method"] != null)
            //    {
            //        if (Request.QueryString["method"] == "Edit")
            //        {
            //            int postid = int.Parse(Request.QueryString["id"]);
            //            mp = bp.GetModel(postid);
            //            if (!EFun.VerifyUser(mp.Post_UserID.ToString()))
            //            {
            //                EFun.Redirect_Webconfig("404");
            //            }
            //            List<Maticsoft.Model.Tb_PostItem> temp = bpi.GetModelList("Item_Post_ID=" + postid);
            //            mpi = temp[0];

            //            fillpage(1);
            //        }
            //    }
            //    else
            //    {
            //        //Publish Mode 
            //        fillpage(0);
            //    }
            //}
        }


        //0-publish 1-edit
        protected void fillpage(int type)
        {
            DropDownList2.SelectedValue = Session["City_ID"].ToString();


            if (type == 1)
            {
                TextBox1.Text = mp.Post_Title;
                DropDownList2.SelectedValue = mp.Post_CityID.ToString();
                TextBox9.Text = mpi.Item_Price.ToString();
                if (mpi.Item_IsSelf == 1)
                    CheckBox3.Checked = true;
                if (mpi.Item_IsMailed == 1)
                    CheckBox4.Checked = true;
                TextBox2.Text = mpi.Item_Phone;
                TextBox4.Text = mpi.Item_Wechat;
                TextBox14.Text = mpi.Item_QQ;
                TextBox5.Text = mpi.Item_Email;
                DropDownList1.SelectedValue = mpi.Item_Type;
                DropDownList3.SelectedValue = mpi.Item_Status;
                MultiPics1.SetPic(mpi.Item_Images);
                Editor1.SetContent(mpi.Item_Description);
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            //发布
            if (buildPost())
            {
                if (mp.Post_ID != 0)
                {
                    //Update
                    bp.Update(mp);
                    bpi.Update(mpi);
                    bu.Update(mu);
                    EFun.Redirect_Webconfig("Item", "?id=" + mp.Post_ID);
                }
                else
                {
                    //Add to Tb_Post
                    Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
                    bp.Add(mp);
                    int a = bp.GetMaxId();
                    mp = bp.GetModel(bp.GetMaxId() - 1);
                    //Add to Tb_PostNormal
                    Maticsoft.BLL.Tb_PostItem bps = new Maticsoft.BLL.Tb_PostItem();
                    mpi.Item_Post_ID = mp.Post_ID;
                    bpi.Add(mpi);
                    bu.Update(mu);

                    Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["Item"] + "?id=" + mp.Post_ID);

                }
            }
            else
            {

                Response.Write("<script>alert('信息不完整')</script>");
            }
        }


        protected Boolean buildPost()
        {
            try
            {
                mp = new Maticsoft.Model.Tb_Post();
                mpi = new Maticsoft.Model.Tb_PostItem();
                mu = bu.GetModel(int.Parse(cookieUser.Value));
                if (Request.QueryString["id"] != null)
                {
                    mp = bp.GetModel(int.Parse(Request.QueryString["id"]));
                    List<Maticsoft.Model.Tb_PostItem> mlpi = bpi.GetModelList("Item_Post_ID=" + mp.Post_ID);
                    mpi = mlpi[0];
                }

                mp.Post_Title = TextBox1.Text;
                mp.Post_CityID = int.Parse(DropDownList2.SelectedValue);
                mp.Post_UserID = int.Parse(cookieUser.Value);
                mp.Post_Type = 4;

                mpi.Item_Price = int.Parse(TextBox9.Text);
                mpi.Item_Images = MultiPics1.GetPic();
                mpi.Item_Cover = MultiPics1.GetCover();
                if (CheckBox3.Checked)
                    mpi.Item_IsSelf = 1;
                if (CheckBox4.Checked)
                    mpi.Item_IsMailed = 1;
                mpi.Item_Status = DropDownList3.SelectedValue;
                mpi.Item_Description = Editor1.GetContent();
                mpi.Item_Type = DropDownList1.SelectedValue;
                mpi.Item_Phone = TextBox2.Text;
                mpi.Item_Wechat = TextBox4.Text;
                mpi.Item_QQ = TextBox14.Text;
                mpi.Item_Email = TextBox5.Text;




                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }


        protected void Button6_Click(object sender, EventArgs e)
        {
            if (buildPost())
            {
                Session["Item_pmp"] = mp;
                Session["Item_pmpi"] = mpi;
                Session["Item_pmu"] = mu;
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["Item"] + "?id=0");
            }
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiPics1.MorePic();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            MultiPics1.LessPic();
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }


    }
}