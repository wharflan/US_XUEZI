using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls
{
    public partial class ReplyBlock : System.Web.UI.UserControl
    {
        protected Maticsoft.Model.Tb_Reply thisreply;
        protected Maticsoft.Model.Tb_User mu;
        HttpCookie currentuser_id;

        int replyid;

        public int Replyid
        {
            get { return replyid; }
            set { replyid = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            currentuser_id = CookieLibrary.GetCookie("User_ID");
            Maticsoft.BLL.Tb_Reply br = new Maticsoft.BLL.Tb_Reply();
            thisreply = br.GetModel(replyid);
            if (thisreply != null)
            {
                if (thisreply.Reply_Status == 0)
                {
                    buildreply();
                }
                else
                {
                    builddeletereply();
                }
            }
        }

        protected Boolean buildreply()
        {
            try
            {

                Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
                mu = bu.GetModel((int)thisreply.Reply_UserID);
                Image1.ImageUrl = "/Uploads/Image/User/" + mu.User_ID + ".jpg";
                Label4.Text = mu.User_UserName;
                Label5.Text = mu.User_Description;
                Label1.Text = thisreply.Reply_Time.ToString();

                if (currentuser_id.Value == thisreply.Reply_UserID.ToString())
                {
                    LinkButton1.Visible = false;
                    LinkButton2.Visible = false;
                    LinkButton3.Visible = false;
                    LinkButton4.Visible = true;
                }
                else
                {
                    LinkButton1.Visible = true;
                    LinkButton2.Visible = true;
                    LinkButton3.Visible = true;
                    LinkButton4.Visible = false;
                }
                if (thisreply.Reply_RepliedUserID != null)
                {
                    mu = bu.GetModel((int)thisreply.Reply_RepliedUserID);
                    Label2.Text = "回复" + mu.User_UserName + ":" + thisreply.Reply_Content;
                }
                Insus.NET.InsusCharacterUtility icu = new Insus.NET.InsusCharacterUtility();
                Label2.Text = icu.BriefContent(thisreply.Reply_Content, 100);
                Label3.Text = "5有用" + "&nbsp2评论";
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        protected void builddeletereply()
        {
            Label2.Text = "内容已被删除";
            LinkButton1.Visible = false;
            LinkButton2.Visible = false;
            LinkButton3.Visible = false;
            LinkButton4.Visible = false;
            LinkButton5.Visible = false;
            LinkButton6.Visible = false;
            LinkButton7.Visible = false;
            Label3.Text = "";
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            //Response to this reply
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            //is useful
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            //retwit
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            LinkButton6.Visible = true;
            LinkButton7.Visible = true;

        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            //展开
            Maticsoft.BLL.Tb_Reply br = new Maticsoft.BLL.Tb_Reply();
            thisreply = br.GetModel(replyid);
            if (thisreply != null)
            {

                Label2.Text = thisreply.Reply_Content;

            }
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            thisreply.Reply_Status = 1;
            Maticsoft.BLL.Tb_Reply br = new Maticsoft.BLL.Tb_Reply();
            br.Update(thisreply);
            builddeletereply();
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            LinkButton6.Visible = false;
            LinkButton7.Visible = false;
        }
    }
}