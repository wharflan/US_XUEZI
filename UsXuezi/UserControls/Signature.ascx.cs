using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls
{
    public partial class Signature : System.Web.UI.UserControl
    {
        List<Maticsoft.Model.Tb_Signature> mls;

        public List<Maticsoft.Model.Tb_Signature> Mls
        {
            get { return mls; }
            set { mls = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (mls == null)
            {
                mls = new List<Maticsoft.Model.Tb_Signature>();
            }
        }

    }
}