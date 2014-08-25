using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.AdminTools
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        string posttype;
        string postid;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

            postid = GridView1.SelectedRow.Cells[1].Text;
            posttype = GridView1.SelectedRow.Cells[2].Text;
            showpage(postid, posttype);
        }

        protected void showpage(string id, string type)
        {
            string keyword = "";
            switch (int.Parse(type))
            {
                case 1:
                    keyword = "Estate";
                    break;
                case 2:
                    keyword = "Business";
                    break;
                case 3:
                    keyword = "Rent";
                    break;
                case 4:
                    keyword = "Item";
                    break;
                case 5:
                    keyword = "UsedCar";
                    break;
                case 6:
                    keyword = "Job";
                    break;
                case 7:
                    keyword = "QA";
                    break;
                case 8:
                    keyword = "Chat";
                    break;
                case 9:
                    keyword = "Food";
                    break;
            }
            string src = EFun.getAddress(keyword) + "?id=" + id;
            content.Attributes.Add("src", src);
        }


    }
}