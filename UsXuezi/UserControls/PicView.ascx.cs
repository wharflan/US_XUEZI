using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls
{
    public partial class PicView : System.Web.UI.UserControl
    {
        string names;

        public string Names
        {
            get { return names; }
            set { names = value; }
        }

        protected string[] filenames;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (names != null && names != "")
            {
                filenames = names.Split('|');
            }
            else
            {
                content.Visible = false;
            }
        }

        
    }
}