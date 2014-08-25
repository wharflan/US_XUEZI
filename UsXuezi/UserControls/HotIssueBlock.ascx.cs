using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls.HomePage
{
    public partial class HotIssueBlock : System.Web.UI.UserControl
    {
        string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            issuetitle.Text = "标题";
            issuecontent.Text = "内容内容内容内容内容内容内容内容内容内容内容内容内容内容内容内容内容内容内容内容内容内容";
            issueimg.ImageUrl = "~/images/CityIcon/" + Name + ".jpg";
        }

        protected void CityIconImage_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("~/city.aspx");
        }
    }
}