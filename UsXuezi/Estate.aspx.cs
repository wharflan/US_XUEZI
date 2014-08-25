using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi
{
    public partial class Estate : System.Web.UI.Page
    {

        Maticsoft.Model.Tb_Post mp;
        Maticsoft.Model.Tb_PostEstate mpe;

        protected void Page_Load(object sender, EventArgs e)
        {
            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            Maticsoft.BLL.Tb_PostEstate bpe = new Maticsoft.BLL.Tb_PostEstate();

            if (Request.QueryString["id"] != null)
            {
                mp = bp.GetModel(int.Parse(Request.QueryString["id"].ToString()));

            }
            else
            {
                //Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["404"]);
            }
            if (mp != null)
            {
                mpe = bpe.GetModel(mp.Post_ID);
                StudentCard1.Userid = (int)mp.Post_UserID;
            }
            else
            {
                //Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["404"]);
            }
            if (mpe != null)
            {
                buildEstate();
            }
            else
            {
                //Response.Redirect(System.Configuration.ConfigurationManager.AppSettings["404"]);
            }
            StudentCard1.Userid = 14;
        }

        protected void buildEstate()
        {

        }
    }
}