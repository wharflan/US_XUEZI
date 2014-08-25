using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi
{
    public partial class Item : System.Web.UI.Page
    {
        Maticsoft.Model.Tb_Post mp;
        Maticsoft.Model.Tb_PostItem mpi;
        Maticsoft.Model.Tb_User mu;
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
                    cookie = CookieLibrary.GetCookie("User_ID");

                    buildPage();
                }
                else
                {
                    //run preview mode
                    mp = (Maticsoft.Model.Tb_Post)Session["Item_pmp"];
                    mpi = (Maticsoft.Model.Tb_PostItem)Session["Item_pmpi"];
                    mu = (Maticsoft.Model.Tb_User)Session["Item_pmu"];
                    cookie = CookieLibrary.GetCookie("User_ID");

                    buildPage();
                }
            }

        }

        //Item Page
        protected Boolean buildModel(int postid)
        {
            try
            {
                Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
                mp = bp.GetModel(postid);
                Maticsoft.BLL.Tb_PostItem bpi = new Maticsoft.BLL.Tb_PostItem();
                List<Maticsoft.Model.Tb_PostItem> mlpi = bpi.GetModelList("Item_Post_ID=" + mp.Post_ID);
                mpi = EModel.getItem(mp.Post_ID);
                mu = EModel.getPoster(mp.Post_ID);
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
                Maticsoft.BLL.Tb_City bc = new Maticsoft.BLL.Tb_City();
                Maticsoft.Model.Tb_City mc = bc.GetModel((int)mp.Post_CityID);
                Label2.Text = mc.City_NameCH + "&emsp;" + mpi.Item_Name + "&emsp;" + "发布于" + mp.Post_PostTime;

                if (EFun.VerifyUser(mp.Post_UserID.ToString()))
                {
                    LinkButton1.Visible = true;
                }
                PicView1.Names = mpi.Item_Images;
                StudentCard1.Userid = (int)mp.Post_UserID;
                Label11.Text = "$" + mpi.Item_Price;
                Label12.Text = mpi.Item_Description;
                Label3.Text = "新旧程度" + mpi.Item_Status;
                string delivery = "";
                if (mpi.Item_IsSelf != 0)
                {
                    delivery = "自取&emsp;";
                }
                if (mpi.Item_IsMailed != 0)
                {
                    delivery += "邮寄";
                }
                Label4.Text = "交易方式&emsp;" + delivery;


                if (mpi.Item_Wechat != null && mpi.Item_Wechat != "")
                {
                    Label6.Text = "微信&emsp;" + mpi.Item_Wechat;
                }
                else Label6.Text = "";

                if (mpi.Item_Phone != null && mpi.Item_Phone != "")
                {
                    Label9.Text = "手机&emsp;" + mpi.Item_Phone;
                }
                else Label9.Text = "";


                if (mpi.Item_QQ != null && mpi.Item_QQ != "")
                {
                    Label8.Text = "QQ&emsp;" + mpi.Item_QQ;
                }
                else Label8.Text = "";

                if (mpi.Item_Email != null && mpi.Item_Email != "")
                {
                    Label10.Text = "邮箱&emsp;" + mpi.Item_Email;
                }
                else Label10.Text = "";

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

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            EFun.Redirect_Webconfig(("ItemPublish"), "?id=" + mp.Post_ID + "&method=Edit");
        }
    }
}