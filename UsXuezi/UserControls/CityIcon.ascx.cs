using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls.HomePage
{
    public partial class CityIcon : System.Web.UI.UserControl
    {
        string cityname;

        public string CityName
        {
            get { return cityname; }
            set { cityname = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            CityIconName.Text = CityName;
            string selectcity = "document.getElementById('ContentHolder_Label3').innerText = '上一个城市ID是" + this.ID + "';";
            string changeimg = "this.src='Images/CityIcon/" + CityName + "_hover.png'";//鼠标移上去更换新的图片";
            string deselctcity = "this.src='Images/CityIcon/" + CityName + ".png'";//鼠标移开回复原来图
            CityIconImage.ImageUrl = "/Images/CityIcon/" + CityName + ".png";
            CityIconImage.Attributes.Add("onmouseover", selectcity + changeimg);
            CityIconImage.Attributes.Add("onmouseout", deselctcity);

        }

        protected void CityIconImage_Click(object sender, ImageClickEventArgs e)
        {
            switch (CityName)
            {
                case "波士顿":
                    Session["City_ID"] = 1;
                    EFun.Redirect_Webconfig("City");
                    break;
                case "纽约":
                    Session["City_ID"] = 2;
                    EFun.Redirect_Webconfig("City");
                    break;
                case "芝加哥":
                    Session["City_ID"] = 3;
                    EFun.Redirect_Webconfig("City");
                    break;
                case "洛杉矶":
                    Session["City_ID"] = 4;
                    EFun.Redirect_Webconfig("City");
                    break;
                case "三藩市":
                    Session["City_ID"] = 5;
                    EFun.Redirect_Webconfig("City");
                    break;
            }

            Session["City_Name"] = CityName;
            Response.Redirect("~/city.aspx");
        }
    }
}