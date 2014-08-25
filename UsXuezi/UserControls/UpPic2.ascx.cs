using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace UsXuezi.UserControls
{
    public partial class UpPic2 : System.Web.UI.UserControl
    {
        HttpCookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            cookie = CookieLibrary.GetCookie("User_ID");
            btnUploadFile.ServerClick += new EventHandler(UploadButton_Click);
        }
        protected void UploadButton_Click(object sender, EventArgs e)
        {

            if (this.FileUpload1.HasFile)
            {
                string fileName = this.FileUpload1.PostedFile.FileName;                  // 客户端文件路径
                string extension = System.IO.Path.GetExtension(fileName);
                if (extension.ToLower() != ".jpg" && extension.ToLower() != ".png")
                {
                    ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('只允许jpg 和 png！');", true);
                    return;
                }

                string pathBase = Server.MapPath("/Uploads/Images/Temp/") + cookie.Value + ("/");//上传的目录
                if (!Directory.Exists(pathBase))
                    Directory.CreateDirectory(pathBase);
                string webFilePath = Path.Combine(pathBase, fileName); // 数据库保存文件路径（相对全路径）
                this.FileUpload1.SaveAs(webFilePath);  // 使用 SaveAs 方法保存文件
                ScriptManager.RegisterStartupScript(this, this.GetType(), "msg", "alert('上傳成功，我們會盡快進行核對！');", true);
            }
        }
    }
}