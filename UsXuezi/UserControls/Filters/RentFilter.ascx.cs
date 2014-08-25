using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls.Filters
{
    public partial class RentFilter : System.Web.UI.UserControl, basefilter
    {
        public string getsql()
        {
            string sql = "";

            if (DropDownList5.SelectedValue != "0")
            {
                sql = "Rent_Area = " + DropDownList5.SelectedValue;
            }
            else
            {
                Maticsoft.BLL.Tb_Area ba = new Maticsoft.BLL.Tb_Area();
                List<Maticsoft.Model.Tb_Area> ma = ba.GetModelList("Area_CityID=" + Session["City_ID"]);
                sql = "Rent_Area>=" + ma[0].Area_ID + " and Rent_Area<=" + ma[ma.Count - 1].Area_ID;
            }

            if (DropDownList1.SelectedValue == "1")
            {
                sql += " and Rent_IsSingleRoom = 1";
            }
            else
            {
                sql += " and Rent_IsWholeBuilding = 1";
            }

            if (TextBox1.Text != null && TextBox1.Text != "")
            {
                try
                {
                    DateTime.Parse(TextBox1.Text);
                }
                catch (Exception)
                {
                    TextBox1.Text = DateTime.Now.ToShortDateString();
                }
                sql += " and Rent_Start<'" + TextBox1.Text + "'";
                sql += " and Rent_End>'" + TextBox1.Text + "'";

            }

            switch (DropDownList4.SelectedValue)
            {
                case "2":
                    sql += " order by Rent_Price DESC ";
                    break;
                case "3":
                    sql += " order by Rent_Price ASC";
                    break;
            }

            return sql;
        }

        public List<Maticsoft.Model.Tb_Post> buildMLP()
        {

            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            Maticsoft.BLL.Tb_PostRent bpr = new Maticsoft.BLL.Tb_PostRent();
            Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();

            List<Maticsoft.Model.Tb_PostRent> beforefilter = bpr.GetModelList(getsql());
            List<Maticsoft.Model.Tb_Post> afterfilter = new List<Maticsoft.Model.Tb_Post>();

            for (int i = beforefilter.Count - 1; i >= 0; i--)
            {
                try
                {
                    Maticsoft.Model.Tb_Post mp = bp.GetModel(beforefilter[i].Rent_ID);
                    Maticsoft.Model.Tb_User mu = bu.GetModel((int)mp.Post_UserID);
                    if (DropDownList3.SelectedValue == "0" || (DropDownList3.SelectedValue == "2" && mu.User_Type != 6) || (DropDownList3.SelectedValue == "1" && mu.User_Type == 6))
                        afterfilter.Add(mp);
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