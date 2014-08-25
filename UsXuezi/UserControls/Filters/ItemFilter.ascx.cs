using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls.Filters
{
    public partial class ItemFilter : System.Web.UI.UserControl
    {
        public string getsql()
        {
            string sql = "";

            if (DropDownList5.SelectedValue != "全部")
            {
                sql = "Item_Type = '" + DropDownList5.SelectedValue + "'";
            }
            else
            {
                sql = "Item_ID>0";
            }

            if (DropDownList1.SelectedValue == "1")
            {
                sql += " and Item_IsSelf = 1";
            }
            else if (DropDownList1.SelectedValue == "2")
            {
                sql += " and Item_IsMailed = 1";
            }

            if (DropDownList2.SelectedValue == "1")
            {
                sql += " and Item_Status = '全新'";
            }
            else if (DropDownList2.SelectedValue == "2")
            {
                sql += " and Item_Status != '全新'";
            }


            switch (DropDownList4.SelectedValue)
            {
                case "2":
                    sql += " order by Item_Price DESC ";
                    break;
                case "3":
                    sql += " order by Item_Price ASC";
                    break;
            }

            return sql;
        }

        public List<Maticsoft.Model.Tb_Post> buildMLP()
        {

            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            Maticsoft.BLL.Tb_PostItem bpi = new Maticsoft.BLL.Tb_PostItem();

            List<Maticsoft.Model.Tb_PostItem> beforefilter = bpi.GetModelList(getsql());
            List<Maticsoft.Model.Tb_Post> afterfilter = new List<Maticsoft.Model.Tb_Post>();

            for (int i = beforefilter.Count - 1; i >= 0; i--)
            {
                try
                {
                    Maticsoft.Model.Tb_Post mp = bp.GetModel(beforefilter[i].Item_Post_ID);
                    if (mp.Post_CityID.ToString() == Session["City_ID"].ToString())
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

        public void updatelist()
        {
            List<Maticsoft.Model.Tb_Post> mlp = buildMLP();
            Session["CityPostList"] = mlp;
        }
    }

}