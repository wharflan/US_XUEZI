using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls
{
    public partial class DealerCard : System.Web.UI.UserControl
    {
        string cardtype;

        public string CardType
        {
            get { return cardtype; }
            set { cardtype = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }
    }
}