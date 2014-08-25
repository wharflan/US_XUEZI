using System;
using System.Web;
using System.IO;

namespace Uploadify_Simple_ASPNET
{
    public class uploadHandler : IHttpHandler
    {
        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.Charset = "utf-8";

            HttpPostedFile file = context.Request.Files["Filedata"];

            if (file != null)
            {
                //触发上传事件
                UploadifyControl.onUploadEvent(file);

                //下面这句代码缺少的话，上传成功后上传队列的显示不会自动消失
                context.Response.Write("1");
            }
            else
            {
                context.Response.Write("0");
            }
        }

        public bool IsReusable
        {
            get
            {
                return true;
            }
        }

    }
}