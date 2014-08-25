using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Web;
using System.Web.UI;

namespace Uploadify_Simple_ASPNET
{
    [ToolboxData("<{0}:UploadifyControl runat=server></{0}:UploadifyControl>")]
    public class UploadifyControl : Control
    {
        #region 事件
        //缺陷：由于无法在uploadHandler中获取UploadifyControl的实例，只好搞成静态的，
        //这样带来的后果是一个web项目中所有的UploadifyControl只能是同一种处理方式
        //后期想办法完善
        public delegate void UploadEventHandler(HttpPostedFile file);
        /// <summary>
        /// 文件上传事件
        /// </summary>
        public static event UploadEventHandler UploadEvent;
        /// <summary>
        /// 触发上传事件
        /// </summary>
        /// <param name="file">上传的文件</param>
        public static void onUploadEvent(HttpPostedFile file)
        {
            if (UploadEvent != null)
            {
                UploadEvent(file);
            }
        }
        #endregion

        #region 字段、属性
        private string swf;
        private string buttonText;
        private string buttonImage;
        private uint? width;
        private uint? height;
        private string formData;
        private uint? queueSizeLimit;
        private uint? uploadLimit;
        private bool? auto;
        private bool? multi;
        private bool? removeCompleted;
        private uint? fileSizeLimit;
        private string fileTypeDesc;
        private string fileTypeExts;

        /// <summary>
        /// SWF核心文件路径（一般不需要设置）
        /// </summary>
        [Localizable(true)]
        public string SWF
        {
            get
            {
                if (this.ViewState["swf"] != null)
                {
                    swf = this.ViewState["swf"].ToString();
                }
                if (!string.IsNullOrEmpty(swf))
                {
                    if (swf.StartsWith("~"))
                    {
                        swf = this.ResolveUrl(swf);
                    }
                }
                return swf;
            }
            set
            {
                this.ViewState["swf"] = value.Trim();
                swf = value.Trim();
            }
        }

        /// <summary>
        /// 浏览按钮上显示的文字
        /// </summary>
        [Localizable(true)]
        public string ButtonText
        {
            get
            {
                if (this.ViewState["buttonText"] != null)
                {
                    buttonText = this.ViewState["buttonText"].ToString();
                }
                return buttonText;
            }

            set
            {
                this.ViewState["buttonText"] = value;
                buttonText = value;
            }
        }

        /// <summary>
        /// 浏览按钮图片路径
        /// </summary>
        [Localizable(true)]
        public string ButtonImage
        {
            get
            {
                if (this.ViewState["buttonImage"] != null)
                {
                    buttonImage = this.ViewState["buttonImage"].ToString();
                }
                if (!string.IsNullOrEmpty(buttonImage))
                {
                    if (buttonImage.StartsWith("~"))
                    {
                        buttonImage = this.ResolveUrl(buttonImage);
                    }
                }
                return buttonImage;
            }
            set
            {
                this.ViewState["buttonImage"] = value.Trim();
                buttonImage = value.Trim();
            }
        }

        /// <summary>
        /// 浏览按钮宽度（单位为像素）
        /// </summary>
        [Localizable(true)]
        public uint? Width
        {
            get
            {
                if (this.ViewState["width"] != null)
                {
                    width = Convert.ToUInt32(this.ViewState["width"]);
                }
                return width;
            }
            set
            {
                this.ViewState["width"] = value;
                width = value;
            }
        }

        /// <summary>
        /// 浏览按钮高度（单位为像素）
        /// </summary>
        [Localizable(true)]
        public uint? Height
        {
            get
            {
                if (this.ViewState["height"] != null)
                {
                    height = Convert.ToUInt32(this.ViewState["height"]);
                }
                return height;
            }
            set
            {
                this.ViewState["height"] = value;
                height = value;
            }
        }

        /// <summary>
        /// 表单数据
        /// </summary>
        [Localizable(true)]
        public string FormData
        {
            get
            {
                if (this.ViewState["formData"] != null)
                {
                    formData = this.ViewState["formData"].ToString();
                }
                return formData;
            }

            set
            {
                this.ViewState["formData"] = value;
                formData = value;
            }
        }

        /// <summary>
        /// 队列最多可上传文件数量
        /// </summary>
        [Localizable(true)]
        public uint? QueueSizeLimit
        {
            get
            {
                if (this.ViewState["queueSizeLimit"] != null)
                {
                    queueSizeLimit = Convert.ToUInt32(this.ViewState["queueSizeLimit"]);
                }
                return queueSizeLimit;
            }
            set
            {
                this.ViewState["queueSizeLimit"] = value;
                queueSizeLimit = value;
            }
        }

        /// <summary>
        /// 一次上传文件的数量
        /// </summary>
        [Localizable(true)]
        public uint? UploadLimit
        {
            get
            {
                if (this.ViewState["uploadLimit"] != null)
                {
                    uploadLimit = Convert.ToUInt32(this.ViewState["uploadLimit"]);
                }
                return uploadLimit;
            }
            set
            {
                this.ViewState["uploadLimit"] = value;
                uploadLimit = value;
            }
        }

        /// <summary>
        /// 选择文件后是否自动上传
        /// </summary>
        [Localizable(true)]
        public bool? Auto
        {
            get
            {
                if (this.ViewState["auto"] != null)
                {
                    auto = Convert.ToBoolean(this.ViewState["uploadLimit"]);
                }
                return auto;
            }
            set
            {
                this.ViewState["auto"] = value;
                auto = value;
            }
        }

        /// <summary>
        /// 是否为多选
        /// </summary>
        [Localizable(true)]
        public bool? Multi
        {
            get
            {
                if (this.ViewState["multi"] != null)
                {
                    multi = Convert.ToBoolean(this.ViewState["multi"]);
                }
                return multi;
            }
            set
            {
                this.ViewState["multi"] = value;
                multi = value;
            }
        }

        /// <summary>
        /// 是否完成后移除序列
        /// </summary>
        [Localizable(true)]
        public bool? RemoveCompleted
        {
            get
            {
                if (this.ViewState["removeCompleted"] != null)
                {
                    removeCompleted = Convert.ToBoolean(this.ViewState["removeCompleted"]);
                }
                return removeCompleted;
            }
            set
            {
                this.ViewState["removeCompleted"] = value;
                removeCompleted = value;
            }
        }

        /// <summary>
        /// 单个文件大小最大值，0为无限制(单位为MB)
        /// </summary>
        [Localizable(true)]
        public uint? FileSizeLimit
        {
            get
            {
                if (this.ViewState["fileSizeLimit"] != null)
                {
                    fileSizeLimit = Convert.ToUInt32(this.ViewState["fileSizeLimit"]);
                }
                return fileSizeLimit;
            }
            set
            {
                this.ViewState["fileSizeLimit"] = value;
                fileSizeLimit = value;
            }
        }

        /// <summary>
        /// 文件描述
        /// </summary>
        [Localizable(true)]
        public string FileTypeDesc
        {
            get
            {
                if (this.ViewState["fileTypeDesc"] != null)
                {
                    fileTypeDesc = this.ViewState["fileTypeDesc"].ToString();
                }
                return fileTypeDesc;
            }

            set
            {
                this.ViewState["fileTypeDesc"] = value;
                fileTypeDesc = value;
            }
        }

        /// <summary>
        /// 上传的文件后缀过滤器（例:*.gif; *.jpg; *.png; *.bmp）
        /// </summary>
        [Localizable(true)]
        public string FileTypeExts
        {
            get
            {
                if (this.ViewState["fileTypeExts"] != null)
                {
                    fileTypeExts = this.ViewState["fileTypeExts"].ToString();
                }
                return fileTypeExts;
            }

            set
            {
                this.ViewState["fileTypeExts"] = value;
                fileTypeExts = value;
            }
        } 
        #endregion

        #region 方法
        /// <summary>
        /// 上传全部
        /// </summary>
        public string Upload()
        {
            return "javascript:$('#" + this.ClientID + "_fileupload').uploadify('upload','*')";
        }

        /// <summary>
        /// 取消全部
        /// </summary>
        public string Cancel()
        {
            return "javascript:$('#" + this.ClientID + "_fileupload').uploadify('cancel', '*')";
        }

        /// <summary>
        /// 取消第一个
        /// </summary>
        public string CancelFirst()
        {
            return "javascript:$('#" + this.ClientID + "_fileupload').uploadify('cancel')";
        }

        /// <summary>
        /// 停止上传
        /// </summary>
        public string Stop()
        {
            return "javascript:$('#" + this.ClientID + "_fileupload').uploadify('stop')";
        }
        #endregion

        protected override void OnInit(EventArgs e)
        {
            //注册必要的javascript脚本和样式
            const string keyJquery = "jquery";
            string jqueryobjectfile = Page.ClientScript.GetWebResourceUrl(this.GetType(), "Uploadify_Simple_ASPNET.jquery-1.8.3.min.js");
            const string keyUploadify = "uploadify";
            string uploadifyobjectfile = Page.ClientScript.GetWebResourceUrl(this.GetType(), "Uploadify_Simple_ASPNET.jquery.uploadify-3.1.min.js");
            const string keyUploadifyCss = "uploadifyCss";
            string uploadifyCssobjectfile = Page.ClientScript.GetWebResourceUrl(this.GetType(), "Uploadify_Simple_ASPNET.uploadify.css");
            //由于"取消图片"路径的原因，需要在这里注册它的样式(否则图片显示不出来)
            const string keyCancel = "uploadifyCancel";
            string uploadifyCancelobjectfile = Page.ClientScript.GetWebResourceUrl(this.GetType(), "Uploadify_Simple_ASPNET.uploadify-cancel.png");

            if (!this.Page.ClientScript.IsClientScriptBlockRegistered(keyJquery))
            {
                this.Page.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), keyJquery, "<script type=\"text/javascript\" src=\"" + jqueryobjectfile + "\"></script>\r\n");
            }
            if (!this.Page.ClientScript.IsClientScriptBlockRegistered(keyUploadify))
            {
                this.Page.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), keyUploadify, "<script type=\"text/javascript\" src=\"" + uploadifyobjectfile + "\"></script>\r\n");
            }
            if (!this.Page.ClientScript.IsClientScriptBlockRegistered(keyUploadifyCss))
            {
                this.Page.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), keyUploadifyCss, "<link href=\"" + uploadifyCssobjectfile + "\" rel=\"stylesheet\" type=\"text/css\" />\r\n");
            }
            //由于"取消图片"路径的原因，需要在这里注册它的样式(否则图片显示不出来)
            if (!this.Page.ClientScript.IsClientScriptBlockRegistered(keyCancel))
            {
                StringBuilder uploadifyCancelTemp=new StringBuilder();
                uploadifyCancelTemp.AppendLine("<style type=\"text/css\">");
                uploadifyCancelTemp.AppendLine(".uploadify-queue-item .cancel a {");
                uploadifyCancelTemp.AppendFormat("background: url('{0}') 0 0 no-repeat;", uploadifyCancelobjectfile);
                uploadifyCancelTemp.AppendLine();
	            uploadifyCancelTemp.AppendLine("</style>");
                this.Page.ClientScript.RegisterClientScriptBlock(this.Page.GetType(), keyCancel, uploadifyCancelTemp.ToString());
            }

            base.OnInit(e);
        }

        public override void RenderControl(HtmlTextWriter writer)
        {
            //输出前端
            StringBuilder builder = new StringBuilder();
            builder.AppendLine("<!--上传控件  开始-->");
            builder.AppendLine("<div>");
            if (string.IsNullOrEmpty(SWF))
                SWF = Page.ClientScript.GetWebResourceUrl(this.GetType(), "Uploadify_Simple_ASPNET.uploadify.swf");
            builder.AppendFormat("<div id=\"{0}_fileQueue\">", this.ClientID);
            builder.AppendLine("</div>");
            builder.AppendFormat("<input type=\"file\" name=\"{0}_fileupload\" id=\"{0}_fileupload\"/>", this.ClientID);
            builder.AppendLine();
            builder.AppendLine("</div>");
            builder.AppendLine("<script type=\"text/javascript\">");
            builder.AppendLine("$(document).ready(function () {$('#" + this.ClientID + "_fileupload').uploadify({");

            builder.AppendFormat("\'swf\':\'{0}\'", SWF);
            builder.AppendLine();
            builder.AppendFormat(",\'queueID\':\'{0}_fileQueue\'", this.ClientID);
            builder.AppendLine();
            builder.AppendFormat(",\'uploader\':\'{0}\'", "./Uploadify_Simple_ASPNET/uploadHandler.ashx");
            builder.AppendLine();
            
            if (!string.IsNullOrEmpty(ButtonText))
            {
                builder.AppendFormat(",\'buttonText\':\'{0}\'", ButtonText);
                builder.AppendLine();
            }
            if (!string.IsNullOrEmpty(ButtonImage))
            {
                builder.AppendFormat(",\'buttonImage\':\'{0}\'", ButtonImage);
                builder.AppendLine();
            }
            if (Width!=null)
            {
                builder.AppendFormat(",\'width\':{0}", Width);
                builder.AppendLine();
            }
            if (Height != null)
            {
                builder.AppendFormat(",\'height\':{0}", Height);
                builder.AppendLine();
            }
            if (!string.IsNullOrEmpty(FormData))
            {
                builder.AppendFormat(",\'formData\':\'{0}\'", FormData);
                builder.AppendLine();
            }
            if (QueueSizeLimit != null)
            {
                builder.AppendFormat(",\'queueSizeLimit\':{0}", QueueSizeLimit);
                builder.AppendLine();
            }
            if (UploadLimit != null)
            {
                builder.AppendFormat(",\'uploadLimit\':{0}", UploadLimit);
                builder.AppendLine();
            }
            if (Auto != null)
            {
                builder.AppendFormat(",\'auto\':{0}", Auto.ToString().ToLower());
                builder.AppendLine();
            }
            if (Multi != null)
            {
                builder.AppendFormat(",\'multi\':{0}", Multi.ToString().ToLower());
                builder.AppendLine();
            }
            if (RemoveCompleted != null)
            {
                builder.AppendFormat(",\'removeCompleted\':{0}", RemoveCompleted.ToString().ToLower());
                builder.AppendLine();
            }
            if (FileSizeLimit != null)
            {
                //单位为MB
                builder.AppendFormat(",\'fileSizeLimit\':\'{0}MB\'", FileSizeLimit);
                builder.AppendLine();
            }
            if (!string.IsNullOrEmpty(FileTypeDesc))
            {
                builder.AppendFormat(",\'fileTypeDesc\':\'{0}\'", FileTypeDesc);
                builder.AppendLine();
            }
            if (!string.IsNullOrEmpty(FileTypeExts))
            {
                builder.AppendFormat(",\'fileTypeExts\':\'{0}\'", FileTypeExts);
                builder.AppendLine();
            }


            builder.Append("});});");
            builder.AppendLine();
            builder.AppendLine("</script>");
            builder.AppendLine("<!--上传控件  结束-->");

            writer.Write(builder.ToString());
            base.RenderControl(writer);
        }
    }
}
