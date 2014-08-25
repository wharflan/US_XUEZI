using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls
{
    public partial class SignatureBlock : System.Web.UI.UserControl
    {
        Maticsoft.Model.Tb_Signature ms;

        public Maticsoft.Model.Tb_Signature Ms
        {
            get { return ms; }
            set { ms = value; }
        }        

        protected void Page_Load(object sender, EventArgs e)
        {
            BuildModel(ms);
        }

        protected void BuildModel(Maticsoft.Model.Tb_Signature ms)
        {
            Image1.ImageUrl = ms.Signature_Img;
            Image1.ToolTip = ms.Signature_Description;
            Label1.Text = ms.Signature_Name;
        }

    }
}