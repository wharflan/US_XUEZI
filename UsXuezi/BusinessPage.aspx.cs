using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UsXuezi.UserControls;

namespace UsXuezi
{
    public partial class BusinessPage : System.Web.UI.Page
    {
        Maticsoft.Model.Tb_Post mp;
        Maticsoft.Model.Tb_PostBusiness mpb;
        List<Maticsoft.Model.Tb_Signature> mls;

        int PostID;
        static HttpCookie cookie;

        protected void Page_Load(object sender, EventArgs e)
        {
            //cookie = CookieLibrary.GetCookie("User_ID");
            //if (Request.QueryString["id"] != null)
            //{
            //    if (Request.QueryString["id"] != "0")
            //    {
            //        PostID = int.Parse(Request.QueryString["id"]);
            //        buildModel(PostID);
            //        switch (mpb.Business_Status)
            //        {
            //            case 0:

            //                buildPage();
            //                break;
            //            case 2:
            //                specialpage(PostID);
            //                break;
            //        }
            //    }
            //    else
            //    {
            //        //run preview mode
            //        mp = (Maticsoft.Model.Tb_Post)Session["Business_pmp"];
            //        mpb = (Maticsoft.Model.Tb_PostBusiness)Session["Business_pmps"];
            //        mls = (List<Maticsoft.Model.Tb_Signature>)Session["Business_pmls"];
            //        PostID = 0;
            //        buildPage();
            //    }
            //}


        }

        //Normal Page
        protected Boolean buildModel(int postid)
        {
            try
            {
                Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
                mp = bp.GetModel(postid);
                Maticsoft.BLL.Tb_PostBusiness bpb = new Maticsoft.BLL.Tb_PostBusiness();
                mpb = bpb.GetModel(postid);
                Maticsoft.BLL.Tb_Signature bs = new Maticsoft.BLL.Tb_Signature();
                mls = bs.GetModelList("Signature_BusinessID=" + mp.Post_ID);

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
                if (PostID != 0)
                    BusinessCard1.Businessid = PostID;
                else
                {
                    BusinessCard1.PreviewBC(mp, mpb);
                }
                Label2.Text = mpb.Business_MainContent;
                if (mpb.Business_Address != "" && mpb.Business_Address != null)
                {
                    Mapblock1.Address = mpb.Business_Address;
                    Mapblock1.Visible = true;
                }
                if (mls != null)
                {
                    foreach (Maticsoft.Model.Tb_Signature temp in mls)
                    {
                        SignatureBlock sb = new SignatureBlock();
                        sb = (SignatureBlock)sb.LoadControl("/UserControls/SignatureBlock.ascx");
                        sb.Ms = temp;
                        signaturecontent.Controls.Add(sb);
                    }
                }


                //Coupon区
                return true;
            }
            catch
            {

                return false;
            }

        }

        //Special Page
        protected Boolean specialpage(int id)
        {
            maincontent.Controls.Clear();
            Maticsoft.BLL.Tb_Special bsp = new Maticsoft.BLL.Tb_Special();
            Maticsoft.Model.Tb_Special msp = bsp.GetModel(id);
            UserControl uc = new UserControl();
            uc = (UserControl)uc.LoadControl(msp.Special_Address);
            maincontent.Controls.Add(uc);

            return false;
        }

    }
}