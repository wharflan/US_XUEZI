using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UsXuezi.UserControls;

namespace UsXuezi.PublishPage
{
    public partial class EstatePublish : System.Web.UI.Page
    {
        
        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            
        }        

        protected void Button3_Click(object sender, EventArgs e)
        {
            MapBlock newmap = new MapBlock();
            newmap = (MapBlock)newmap.LoadControl("/UserControls/MapBlock.ascx");
            newmap.ID = "map1";
            newmap.Address = TextBox5.Text;
            mappart.Controls.Clear();
            mappart.Controls.Add(newmap);
        }

       
    }
}