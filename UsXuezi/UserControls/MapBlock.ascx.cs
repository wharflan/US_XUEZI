using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls
{
    public partial class MapBlock : System.Web.UI.UserControl
    {
        string address = "";

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        string width = "100%";

        public string Width
        {
            get { return width; }
            set { width = value; }
        }
        string height = "100%";

        public string Height
        {
            get { return height; }
            set { height = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (address == ""||address==null)
            {
                HttpCookie cookie = CookieLibrary.GetCookie("City_ID");            
                Maticsoft.BLL.Tb_City bc = new Maticsoft.BLL.Tb_City();
                Maticsoft.Model.Tb_City mc = bc.GetModel(int.Parse(cookie.Value));
                address = mc.City_NameEN;
            }
            registerjs();
        }


        protected void registerjs()
        {
            string myjs = @"
        $(document).ready(function() {   
            var map;
            map = new GMaps({
            div: '#googlemapblock',
            lat: 0,
            lng: 0
            });

        GMaps.geocode({
            address: '" + this.Address + @"'.trim(),
            callback: function (results, status) {
                if (status == 'OK') {
                    var latlng = results[0].geometry.location;
                    map.setCenter(latlng.lat(), latlng.lng());
                    map.addMarker({
                        lat: latlng.lat(),
                        lng: latlng.lng()
                    });
                }
            }
        });

})";
            //Add this Script 
            if (ScriptManager.GetCurrent(this.Page) != null)
            {
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), this.ClientID + "map", myjs, true);
            }
            else
            {
                this.Page.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), this.ClientID + "map", myjs, true);
            }
        }
    }
}


/*Dynamic Insert Methed 
 * 
 *  Client 
 *  
            <asp:UpdatePanel ID="UpdatePanel1" runat="server" UpdateMode="Conditional" ChildrenAsTriggers="False">
                <ContentTemplate>
                    <div class="map_publish" id="mappart" runat="server">
                        <BBS:MapBlock ID="map" Width="360px" Height="200px" runat="server" />
                    </div>
                </ContentTemplate>
                <Triggers>
                    <asp:AsyncPostBackTrigger ControlID="Button3" />
                </Triggers>
            </asp:UpdatePanel>
 
 * 
 * Server 
 * 
            MapBlock newmap = new MapBlock();
            newmap = (MapBlock)newmap.LoadControl("/UserControls/MapBlock.ascx");
            newmap.ID = "map1";
            newmap.Address = TextBox5.Text;
            mappart.Controls.Clear();
            mappart.Controls.Add(newmap);
*/