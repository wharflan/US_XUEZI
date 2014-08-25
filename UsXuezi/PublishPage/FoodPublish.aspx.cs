using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UsXuezi.UserControls;

namespace UsXuezi.PublishPage
{
    public partial class FoodPublish : System.Web.UI.Page
    {
        HttpCookie cookieUser;
        HttpCookie cookieCity;
        protected Maticsoft.Model.Tb_Post mp;
        protected Maticsoft.Model.Tb_PostBusiness mps;
        protected List<Maticsoft.Model.Tb_Signature> mls;

        protected static Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
        protected static Maticsoft.BLL.Tb_PostBusiness bps = new Maticsoft.BLL.Tb_PostBusiness();
        protected static Maticsoft.BLL.Tb_Signature bs = new Maticsoft.BLL.Tb_Signature();

        protected void Page_Load(object sender, EventArgs e)
        {
            cookieUser = CookieLibrary.GetCookie("User_ID");
            cookieCity = CookieLibrary.GetCookie("City_ID");
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            Label1.Text = "";
            Button6.Attributes.Add("onclick", "this.form.target='_blank'");
            Button3.Attributes.Add("onclick", "this.form.target=''");

            Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
            Maticsoft.Model.Tb_User mu = bu.GetModel(int.Parse(cookieUser.Value));
            if (mu.User_Type != 1 && mu.User_Type != 5 && mu.User_Type != 4)
            {
                EFun.Redirect_Webconfig("Error");
            }

            if (!IsPostBack)
            {
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
                        mps = bps.GetModel(postid);
                        mls = bs.GetModelList("Signature_BusinessID = " + postid);
                        fillblank();
                    }
                }
                else
                {
                    //Publish Mode        
                }
            }
        }


        protected void fillblank()
        {

            TextBox1.Text = mp.Post_Title;

            DropDownList4.SelectedValue = mp.Post_CityID.ToString();
            if (mps.Business_AreaID != null && mps.Business_AreaID != 0)
            {
                DropDownList2.SelectedValue = mps.Business_AreaID.ToString();
            }
            else
            {
                DropDownList2.SelectedIndex = 0;
            }
            Biz_TextArea.InnerText = mps.Business_Description;
            Editor1.Placeholder = mps.Business_MainContent;
            TextBox6.Text = mps.Business_Phone;
            TextBox2.Text = mps.Business_Wechat;
            TextBox4.Text = mps.Business_Email;
            TextBox7.Text = mps.Business_QQ;
            TextBox5.Text = mps.Business_Address;
            CKFinder2.SetAddress(mps.Business_Cover);
            try
            {
                CKFinder1.SetSignature(mls[0]);
                CKFinder3.SetSignature(mls[1]);
                CKFinder4.SetSignature(mls[2]);
                mls = new List<Maticsoft.Model.Tb_Signature>();
            }
            catch
            {
                mls = new List<Maticsoft.Model.Tb_Signature>();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {

            if (BuildModel())
            {
                if (mp.Post_ID != 0)
                {
                    //Update
                    bp.Update(mp);
                    bps.Update(mps);
                    List<Maticsoft.Model.Tb_Signature> oldsignature = bs.GetModelList("Signature_BusinessID = " + mp.Post_ID);
                    if (oldsignature != null)
                    {
                        foreach (Maticsoft.Model.Tb_Signature temp in oldsignature)
                        {
                            bs.Delete(temp.Signature_ID);
                        }
                    }
                    if (mls != null)
                    {
                        foreach (Maticsoft.Model.Tb_Signature ms in mls)
                        {
                            ms.Signature_BusinessID = mp.Post_ID;
                            bs.Add(ms);
                        }
                    }
                    EFun.Redirect_Webconfig("Business", "?id=" + mp.Post_ID);
                }
                else
                {
                    //Publish
                    //Add to Tb_Post
                    bp.Add(mp);
                    int a = bp.GetMaxId();
                    mp = bp.GetModel(bp.GetMaxId() - 1);
                    //Add to Tb_PostBusiness
                    mps.Business_PostID = mp.Post_ID;
                    bps.Add(mps);
                    if (mls != null)
                    {
                        foreach (Maticsoft.Model.Tb_Signature temp in mls)
                        {
                            temp.Signature_BusinessID = mp.Post_ID;
                            bs.Add(temp);
                        }
                    }
                    EFun.Redirect_Webconfig("Business", "?id=" + mp.Post_ID);
                }


            }
            else
            {
                Response.Write("<script>alert('信息不完整')</script>");
            }
        }


        protected Boolean BuildModel()
        {
            try
            {
                mp = new Maticsoft.Model.Tb_Post();
                mps = new Maticsoft.Model.Tb_PostBusiness();
                mls = new List<Maticsoft.Model.Tb_Signature>();

                if (Request.QueryString["id"] != null)
                {
                    mp.Post_ID = int.Parse(Request.QueryString["id"]);
                    mps.Business_PostID = int.Parse(Request.QueryString["id"]);
                }

                mp.Post_Title = TextBox1.Text;
                mp.Post_CityID = int.Parse(DropDownList4.SelectedValue);
                mp.Post_Type = 9;
                mp.Post_UserID = int.Parse(cookieUser.Value);
                if (mps == null)
                {
                    mps = new Maticsoft.Model.Tb_PostBusiness();
                }
                mps.Business_AreaID = int.Parse(DropDownList2.SelectedValue);
                mps.Business_Description = Biz_TextArea.InnerText;
                mps.Business_Phone = TextBox6.Text;
                mps.Business_Wechat = TextBox2.Text;
                mps.Business_Email = TextBox4.Text;
                mps.Business_QQ = TextBox7.Text;
                mps.Business_Address = TextBox5.Text;
                mps.Business_Cover = CKFinder2.GetAddress();
                mps.Business_MainContent = Editor1.GetContent();

                if (CKFinder1.GetAddress() != "" && CKFinder1.GetDescription() != "" && CKFinder1.GetName() != "")
                {
                    Maticsoft.Model.Tb_Signature ms = new Maticsoft.Model.Tb_Signature();
                    ms.Signature_Description = CKFinder1.GetDescription();
                    ms.Signature_Img = CKFinder1.GetAddress();
                    ms.Signature_Name = CKFinder1.GetName();
                    if (mls == null)
                    {
                        mls = new List<Maticsoft.Model.Tb_Signature>();
                    }
                    mls.Add(ms);
                }
                if (CKFinder3.GetAddress() != "" && CKFinder3.GetDescription() != "" && CKFinder3.GetName() != "")
                {
                    Maticsoft.Model.Tb_Signature ms = new Maticsoft.Model.Tb_Signature();
                    ms.Signature_Description = CKFinder3.GetDescription();
                    ms.Signature_Img = CKFinder3.GetAddress();
                    ms.Signature_Name = CKFinder3.GetName();
                    if (mls == null)
                    {
                        mls = new List<Maticsoft.Model.Tb_Signature>();
                    }
                    mls.Add(ms);
                }
                if (CKFinder4.GetAddress() != "" && CKFinder4.GetDescription() != "" && CKFinder4.GetName() != "")
                {
                    Maticsoft.Model.Tb_Signature ms = new Maticsoft.Model.Tb_Signature();
                    ms.Signature_Description = CKFinder4.GetDescription();
                    ms.Signature_Img = CKFinder4.GetAddress();
                    ms.Signature_Name = CKFinder4.GetName();
                    if (mls == null)
                    {
                        mls = new List<Maticsoft.Model.Tb_Signature>();
                    }
                    mls.Add(ms);
                }

                return true;
            }
            catch
            {
                return false;
            }


        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            MapBlock newmap = new MapBlock();
            newmap = (MapBlock)newmap.LoadControl("/UserControls/MapBlock.ascx");
            newmap.ID = "map1";
            newmap.Address = TextBox5.Text;
            mappart.Controls.Clear();
            mappart.Controls.Add(newmap);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            //Preview Mode
            if (BuildModel())
            {
                Session["Business_pmp"] = mp;
                Session["Business_pmps"] = mps;
                Session["Business_pmls"] = mls;
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["Business"] + "?id=0");
            }
        }


    }
}