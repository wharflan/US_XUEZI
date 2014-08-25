using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls
{
    public partial class Editor : System.Web.UI.UserControl
    {
        string placeholder;

        public string Placeholder
        {
            get { return placeholder; }
            set { placeholder = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (placeholder != "" && placeholder != null)
                {
                    Editor_Content_Only.InnerHtml = placeholder;
                }
                string userid = CookieLibrary.GetCookie("User_ID").Value;
                Session["CKFinder:DynamicBaseUrl"] = "/Uploads/Image/Post/" + userid + "/";
                registerjs();
            }
            catch
            {
                EFun.Redirect_Webconfig("Login");
            }
        }

        public string GetContent()
        {
            string content = HiddenField1.Value;
            //content = Editor_Content_Only.Value;
            return content;
        }

        public string GetContent1()
        {
            string content = Editor_Content_Only.Value;
            return content;
        }
        public void SetContent(string content)
        {
            Editor_Content_Only.InnerText = content;
        }

        protected void registerjs()
        {
            string myjs = @"
            var editor = CKEDITOR.replace('" + Editor_Content_Only.ClientID + @"');          // 创建编辑器
            CKFinder.setupCKEditor(editor, '/PlugIns/ckfinder/');   // 为编辑器绑定上传控件

            function GetContents() {
                var editor = CKEDITOR.instances." + Editor_Content_Only.ClientID + @";
                $(" + HiddenField1.ClientID + @").val(editor.getData());
            }

            function SetContents() {
                var editor = CKEDITOR.instances." + Editor_Content_Only.ClientID + @";
                value = document.getElementById( 'htmlArea' ).value;
                editor.setData( value );
            }
        ";


            string ckjs = "/Plugins/ckeditor/ckeditor.js";
            string cfjs = "/Plugins/ckfinder/ckfinder.js";

            //Add this Script 
            if (ScriptManager.GetCurrent(this.Page) != null)
            {
                ScriptManager.RegisterClientScriptInclude(this.Page, this.Page.GetType(), this.ClientID + "ck", ckjs);
                ScriptManager.RegisterClientScriptInclude(this.Page, this.Page.GetType(), this.ClientID + "cf", cfjs);
                ScriptManager.RegisterClientScriptBlock(this.Page, this.Page.GetType(), this.ClientID + "editor", myjs, true);
            }
            else
            {
                this.Page.ClientScript.RegisterClientScriptInclude("ck", ckjs);
                this.Page.ClientScript.RegisterClientScriptInclude("cf", cfjs);
                this.Page.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), this.ClientID + "editor", myjs, true);
            }
        }
    }
}