using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls.Filters
{
    public partial class BusinessFilter : System.Web.UI.UserControl, basefilter
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        public string getsql()
        {
            string sql = "";

            sql = "Post_Type = 2 ";

            switch (DropDownList2.SelectedValue)
            {
                case "1":
                    sql += " order by Post_PostTime DESC ";
                    break;
                case "2":
                    sql += " order by Post_LastEditTime DESC ";
                    break;
                case "3":
                    sql += " order by Post_PostTime ASC";
                    break;

            }

            return sql;
        }

        public void updatelist()
        {
            List<Maticsoft.Model.Tb_Post> mlp = buildMLP();
            Session["CityPostList"] = mlp;
        }

        public List<Maticsoft.Model.Tb_Post> buildMLP()
        {

            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            Maticsoft.BLL.Tb_PostBusiness bpb = new Maticsoft.BLL.Tb_PostBusiness();
            List<Maticsoft.Model.Tb_Post> beforefilter = bp.GetModelList(getsql());
            if (DropDownList1.SelectedValue == "0")
            {
                return beforefilter;
            }
            List<Maticsoft.Model.Tb_Post> afterfilter = new List<Maticsoft.Model.Tb_Post>();
            foreach (Maticsoft.Model.Tb_Post mp in beforefilter)
            {
                try
                {
                    Maticsoft.Model.Tb_PostBusiness mpb = bpb.GetModel(mp.Post_ID);
                    if (mpb.Business_TypeID.ToString() == DropDownList1.SelectedValue)
                    {
                        afterfilter.Add(mp);
                    }
                }

                catch (Exception)
                {
                    continue;
                }
            }

            return afterfilter;
        }



    }
}