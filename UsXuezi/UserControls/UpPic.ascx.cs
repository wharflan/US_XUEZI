using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;


namespace UsXuezi.UserControls
{
    public partial class UpPic : System.Web.UI.UserControl
    {
        string names;

        public string Names
        {
            get { return names; }
            set { names = value; }
        }

        string type; //"single" "multiple"

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        HttpCookie cookie;
        protected void Page_Load(object sender, EventArgs e)
        {
            cookie = CookieLibrary.GetCookie("User_ID");
            if (!IsPostBack)
            {
                names = "";
            }
        }
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string fileExrensio = System.IO.Path.GetExtension(FileUpload1.FileName).ToLower();//ToLower转化为小写
                string FileType = FileUpload1.PostedFile.ContentType;
                string UploadURL = Server.MapPath("/Uploads/Images/Temp/") + cookie.Value + ("\\");//上传的目录
                if (FileType == "image/bmp" || FileType == "image/gif" || FileType == "image/jpeg" || FileType == "image/jpg" || FileType == "image/png")//判断文件类型
                {

                    try
                    {
                        if (!System.IO.Directory.Exists(UploadURL))//判断文件夹是否已经存在
                        {
                            System.IO.Directory.CreateDirectory(UploadURL);//创建文件夹
                        }

                        FileUpload1.PostedFile.SaveAs(UploadURL + FileUpload1.FileName);
                        Label3.Text = Label3.Text + FileUpload1.FileName + "上传成功";
                        names = names + "|" + FileUpload1.FileName;
                    }
                    catch
                    {
                        Label3.Text = "失败";
                    }
                }
                else
                {
                    Label3.Text = "格式错误";
                }
            }
            else
                Label3.Text = "请选择文件";
        }

        public string[] getNames()
        {
            string[] temp;
            if (names != "")
            {
                temp = names.Split('|');
            }
            else
            {
                temp = null;
            } 
            return temp;

        }
    }
}