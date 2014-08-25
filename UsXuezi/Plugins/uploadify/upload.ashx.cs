using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;
using System.Web.SessionState;
using System.IO;

namespace UsXuezi
{
    /// <summary>
    /// $codebehindclassname$ 的摘要说明
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    public class upload : IHttpHandler, IRequiresSessionState
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "utf-8";

            try
            {
                HttpPostedFile file = context.Request.Files["Filedata"];
                HttpCookie cookie = CookieLibrary.GetCookie("User_ID");
                string uploadPath = context.Server.MapPath("~\\uploadFiles\\");
                //string uploadPath = context.Server.MapPath("/Uploads/Image/" + cookie.Value + "/");

                if (file != null)
                {
                    if (!Directory.Exists(uploadPath))
                    {
                        Directory.CreateDirectory(uploadPath);
                    }
                    string filename =
                        DateTime.Now.ToShortDateString().Replace("/", "-") + "_" +
                        DateTime.Now.ToLongTimeString().Replace(":", "-") +
                        file.FileName.Substring(file.FileName.LastIndexOf("."));
                    file.SaveAs(uploadPath + filename);
                    //生成缩略图
                    //MakeThumbnail(uploadPath + filename, uploadPath + "\\s\\" + file.FileName, 200, 160);
                    context.Response.StatusCode = 200;
                }
            }
            catch (Exception ex)
            {
                context.Response.Write("Error: " + ex.Message);
            }
        }


        private void MakeThumbnail(string sourcePath, string newPath, int width, int height)
        {
            System.Drawing.Image ig = System.Drawing.Image.FromFile(sourcePath);
            int towidth = width;
            int toheight = height;
            int x = 0;
            int y = 0;
            int ow = ig.Width;
            int oh = ig.Height;
            if ((double)ig.Width / (double)ig.Height > (double)towidth / (double)toheight)
            {
                oh = ig.Height;
                ow = ig.Height * towidth / toheight;
                y = 0;
                x = (ig.Width - ow) / 2;

            }
            else
            {
                ow = ig.Width;
                oh = ig.Width * height / towidth;
                x = 0;
                y = (ig.Height - oh) / 2;
            }
            System.Drawing.Image bitmap = new System.Drawing.Bitmap(towidth, toheight);
            System.Drawing.Graphics g = System.Drawing.Graphics.FromImage(bitmap);
            g.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.High;
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            g.Clear(System.Drawing.Color.Transparent);
            g.DrawImage(ig, new System.Drawing.Rectangle(0, 0, towidth, toheight), new System.Drawing.Rectangle(x, y, ow, oh), System.Drawing.GraphicsUnit.Pixel);
            try
            {
                bitmap.Save(newPath, System.Drawing.Imaging.ImageFormat.Jpeg);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                ig.Dispose();
                bitmap.Dispose();
                g.Dispose();
            }

        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}

