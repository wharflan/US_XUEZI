using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UsXuezi.UserControls;

namespace UsXuezi.PublishPage
{
    public partial class RentPublish : System.Web.UI.Page
    {
        protected static HttpCookie cookieUser;
        protected static HttpCookie cookieCity;
        protected Maticsoft.Model.Tb_Post mp;
        protected Maticsoft.Model.Tb_PostRent mpr;
        protected Maticsoft.Model.Tb_User mu;

        protected static Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
        protected static Maticsoft.BLL.Tb_PostRent bpr = new Maticsoft.BLL.Tb_PostRent();
        protected static Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();


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
            mu = bu.GetModel(int.Parse(cookieUser.Value));

            if (!IsPostBack)
            {
                //Edit Mode
                if (Request.QueryString["id"] != null && Request.QueryString["method"] != null)
                {
                    if (Request.QueryString["method"] == "Edit")
                    {
                        int postid = int.Parse(Request.QueryString["id"]);
                        mp = bp.GetModel(postid);
                        if (!EFun.VerifyUser(mp.Post_UserID.ToString()))
                        {
                            EFun.Redirect_Webconfig("404");
                        }

                        mpr = bpr.GetModel(postid);

                        fillpage(1);
                    }
                }
                else
                {
                    //Publish Mode 
                    fillpage(0);
                }
            }

        }

        //0-publish 1-edit
        protected void fillpage(int type)
        {

            DropDownList4.SelectedValue = cookieCity.Value;
            if (type == 1)
            {
                DropDownList4.SelectedValue = mp.Post_CityID.ToString();
            }
            Maticsoft.BLL.Tb_Area ba = new Maticsoft.BLL.Tb_Area();
            List<Maticsoft.Model.Tb_Area> mla = new List<Maticsoft.Model.Tb_Area>();
            mla = ba.GetModelList("Area_CityID=" + DropDownList4.SelectedValue);
            DropDownList1.Items.Clear();
            foreach (Maticsoft.Model.Tb_Area ma in mla)
            {
                ListItem li = new ListItem();
                li.Text = ma.Area_Name;
                li.Value = ma.Area_ID.ToString();
                DropDownList1.Items.Add(li);
            }
            if (type == 1)
            {

                TextBox9.Text = mp.Post_Title;
                TextBox3.Text = mpr.Rent_Price.ToString();
                if (mpr.Rent_IsSingleRoom == 1)
                    CheckBox6.Checked = true;
                if (mpr.Rent_IsWholeBuilding == 1)
                    CheckBox7.Checked = true;
                TextBox1.Text = mpr.Rent_Start.ToString();
                TextBox10.Text = mpr.Rent_End.ToString();
                TextBox5.Text = mpr.Rent_Address;
                DropDownList1.SelectedValue = mpr.Rent_Area.ToString();
                DropDownList2.SelectedValue = mpr.Rent_Pat;
                DropDownList3.SelectedValue = mpr.Rent_Furniture;
                if (mpr.Rent_StreetPark == 1)
                    CheckBox1.Checked = true;
                if (mpr.Rent_Garage == 1)
                    CheckBox2.Checked = true;
                MultiPics1.SetPic(mpr.Rent_Images);
                Editor1.SetContent(mpr.Rent_Description);
                TextBox4.Text = mpr.Rent_Phone;
                TextBox6.Text = mpr.Rent_Wechat;
                TextBox14.Text = mpr.Rent_QQ;
                TextBox15.Text = mpr.Rent_Email;
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
                    bpr.Update(mpr);
                    bu.Update(mu);
                    EFun.Redirect_Webconfig("Rent", "?id=" + mp.Post_ID);
                }
                else
                {
                    //Add to Tb_Post
                    Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
                    bp.Add(mp);
                    int a = bp.GetMaxId();
                    mp = bp.GetModel(bp.GetMaxId() - 1);
                    //Add to Tb_PostNormal
                    Maticsoft.BLL.Tb_PostRent bps = new Maticsoft.BLL.Tb_PostRent();
                    mpr.Rent_ID = mp.Post_ID;
                    bps.Add(mpr);
                    Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
                    bu.Update(mu);

                    Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["Rent"] + "?id=" + mp.Post_ID);

                }
            }
            else
            {

            }
        }


        protected Boolean buildPost()
        {
            try
            {
                mp = new Maticsoft.Model.Tb_Post();
                mpr = new Maticsoft.Model.Tb_PostRent();
                if (Request.QueryString["id"] != null)
                {
                    mp = bp.GetModel(int.Parse(Request.QueryString["id"]));
                    mpr = bpr.GetModel(mp.Post_ID);
                }
                mp.Post_Title = TextBox9.Text;
                mp.Post_CityID = int.Parse(DropDownList4.SelectedValue);
                mp.Post_UserID = int.Parse(cookieUser.Value);
                mp.Post_Type = 3;
                mpr.Rent_Area = int.Parse(DropDownList1.SelectedValue);
                mpr.Rent_Price = int.Parse(TextBox3.Text);
                if (CheckBox6.Checked)
                    mpr.Rent_IsSingleRoom = 1;
                if (CheckBox7.Checked)
                    mpr.Rent_IsWholeBuilding = 1;
                mpr.Rent_Start = DateTime.Parse(TextBox1.Text);
                mpr.Rent_End = DateTime.Parse(TextBox10.Text);
                mpr.Rent_Address = TextBox5.Text;
                mpr.Rent_Pat = DropDownList2.SelectedValue;
                mpr.Rent_Furniture = DropDownList3.SelectedValue;
                mpr.Rent_Images = MultiPics1.GetPic();
                mpr.Rent_Cover = MultiPics1.GetCover();
                if (CheckBox1.Checked)
                    mpr.Rent_StreetPark = 1;
                    
                if (CheckBox2.Checked)
                    mpr.Rent_Garage = 1;

                mpr.Rent_Description = Editor1.GetContent();
                mu = bu.GetModel(int.Parse(cookieUser.Value));
                mpr.Rent_Phone = TextBox14.Text;
                mpr.Rent_Wechat = TextBox6.Text;
                mpr.Rent_QQ = TextBox14.Text;
                mpr.Rent_Email = TextBox15.Text;


                return true;
            }
            catch
            {
                Response.Write("<script>alert('信息有错误')</script>");
                return false;
            }
        }


        protected void Button6_Click(object sender, EventArgs e)
        {
            if (buildPost())
            {
                Session["Rent_pmp"] = mp;
                Session["Rent_pmpr"] = mpr;
                bu.Update(mu);
                Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["Rent"] + "?id=0");
            }
        }

        protected void DropDownList4_SelectedIndexChanged(object sender, EventArgs e)
        {
            Maticsoft.BLL.Tb_Area ba = new Maticsoft.BLL.Tb_Area();
            List<Maticsoft.Model.Tb_Area> mla = new List<Maticsoft.Model.Tb_Area>();
            mla = ba.GetModelList("Area_CityID=" + DropDownList4.SelectedValue);
            DropDownList1.Items.Clear();
            foreach (Maticsoft.Model.Tb_Area ma in mla)
            {
                ListItem li = new ListItem();
                li.Text = ma.Area_Name;
                li.Value = ma.Area_ID.ToString();
                DropDownList1.Items.Add(li);
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

        protected void Button4_Click(object sender, EventArgs e)
        {
            MultiPics1.MorePic();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            MultiPics1.LessPic();
        }
    }
}