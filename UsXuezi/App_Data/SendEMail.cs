using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Net.Mail;

namespace UsXuezi
{
    public class SendEMail
    {
        static string strHost = String.Empty;
        static string strAccount = String.Empty;
        static string strPwd = String.Empty;
        static string strFrom = String.Empty;

        /// <summary>
        /// 发送邮件
        /// </summary>
        /// <param name="to">接收方邮件地址</param>
        /// <param name="title">邮件标题</param>
        /// <param name="content">邮件正文内容</param>
        public static bool sendmail(string to, string title, string content)
        {
            try
            {
                strHost = "mail.usxuezi.com";   //STMP服务器地址
                strAccount = "register@usxuezi.com";//SMTP服务帐号
                strPwd = "da%pIMy8PebT9Wu";       //SMTP服务密码
                strFrom = "register@usxuezi.com";  //发送方邮件地址

                SmtpClient _smtpClient = new SmtpClient();
                _smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;//指定电子邮件发送方式
                _smtpClient.Host = strHost; ;//指定SMTP服务器
                _smtpClient.Credentials = new System.Net.NetworkCredential(strAccount, strPwd);//用户名和密码
                _smtpClient.Port = 587;

                MailMessage _mailMessage = new MailMessage(strFrom, to);
                _mailMessage.Subject = title;//主题
                _mailMessage.Body = content;//内容
                _mailMessage.BodyEncoding = System.Text.Encoding.UTF8;//正文编码
                _mailMessage.IsBodyHtml = true;//设置为HTML格式
                _mailMessage.Priority = MailPriority.High;//优先级


                _smtpClient.Send(_mailMessage);
                return true;
            }
            catch
            {
                throw;
            }
        }


    }
}
