using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls
{
    public partial class CKPic : System.Web.UI.UserControl
    {
        string posttype;

        public string Posttype
        {
            get { return posttype; }
            set { posttype = value; }
        }

        string buttonname;

        public string Buttonname
        {
            get { return buttonname; }
            set { buttonname = value; }
        }

        private string width;

        public string Width
        {
            get { return width; }
            set { width = value; }
        }

        private string height;

        public string Height
        {
            get { return height; }
            set { height = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            string basefolder = "/Uploads/Image/";
            string userid = CookieLibrary.GetCookie("User_ID").Value;
            string folder = "";
            switch (posttype)
            {
                case null:
                case "":
                    folder = "Default/" + userid + "/";
                    break;
                case "post":
                    folder = "Post/" + userid + "/";
                    break;
                case "signature":
                    folder = "Post/" + userid + "/";
                    signature.Visible = true;
                    break;
                case "potrait":
                    folder = "User/";
                    break;
                case "multi":
                    folder = "Post/" + userid + "/";
                    break;
            }

            Session["CKFinder:DynamicBaseUrl"] = basefolder + folder;
            
            registerjs();

        }

        public string GetAddress()
        {
            return HiddenField1.Value;
        }

        public void SetAddress(string address)
        {
            HiddenField1.Value = address;
            Image1.ImageUrl = address;
        }





        public string GetDescription()
        {
            return TextBox1.Text;
        }

        public string GetName()
        {
            return TextBox2.Text;
        }

        public void SetSignature(Maticsoft.Model.Tb_Signature ms)
        {
            TextBox1.Text = ms.Signature_Description;
            TextBox2.Text = ms.Signature_Name;
            Image1.ImageUrl = ms.Signature_Img;
            HiddenField1.Value = ms.Signature_Img;
        }

        protected void registerjs()
        {
            string myjs = @"
        function BrowseServer_" + this.ID + @"() {        
            var finder = new CKFinder();
            finder.basePath = '/Plugins/ckfinder/';	
            finder.selectActionFunction = SetFileField_" + this.ID + @";
            finder.popup();
        }

        function SetFileField_" + this.ID + @"(fileUrl) {
            document.getElementById('xFilePath_" + this.ID + @"').value = fileUrl;
            document.getElementById('" + HiddenField1.ClientID + @"').value = fileUrl;
            document.getElementById('" + Image1.ClientID + @"').src = fileUrl;
    }";
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