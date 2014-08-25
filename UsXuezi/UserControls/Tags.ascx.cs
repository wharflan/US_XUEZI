using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls
{
    public partial class Tags : System.Web.UI.UserControl
    {
        protected string type;

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        protected int maxnum;

        public int Maxnum
        {
            get { return maxnum; }
            set { maxnum = value; }
        }

        protected List<string> taglist;

        protected void Page_Load(object sender, EventArgs e)
        {
            SetTags();
            if (!IsPostBack)
            {
                Session["taglist"] = null;
            }
        }

        public string addtag(string newtag)
        {
            taglist = Session["taglist"] as List<string>;
            if (taglist == null)
            {
                taglist = new List<string>();
            }
            if (!taglist.Contains(newtag))
            {
                if (taglist.Count < Maxnum)
                {
                    taglist.Add(newtag);
                    LinkButton lb = new LinkButton();
                    lb.CssClass = "blue_tag";
                    lb.ID = newtag + "text";
                    lb.Text = newtag;
                    tagblock.Controls.Add(lb);

                    if (Type == "edit")
                    {
                        ImageButton ib = new ImageButton();
                        ib.ImageUrl = "/Images/delete.png";
                        ib.ID = newtag;
                        ib.Click += deletetag;
                        tagblock.Controls.Add(ib);
                    }
                    Session["taglist"] = taglist;
                    return "";
                }
                else
                {
                    return "数量已达上限";
                }
            }
            else
            {
                return "已存在";
            }


        }

        //delete tag (eventHandler)
        protected void deletetag(Object sender, EventArgs e)
        {

            ImageButton ib = (ImageButton)sender;
            tagblock.Controls.Remove(ib);
            LinkButton lb = (LinkButton)tagblock.FindControl(ib.ID + "text");
            string temp = lb.Text;
            taglist.Remove(temp);
            tagblock.Controls.Remove(lb);
        }

        protected void SetTags()
        {
            taglist = Session["taglist"] as List<string>;
            if (taglist == null)
            {
                taglist = new List<string>();
            }
            foreach (string t in taglist)
            {
                LinkButton lb = new LinkButton();
                lb.CssClass = "blue_tag";
                lb.ID = t + "text";
                lb.Text = t;
                tagblock.Controls.Add(lb);

                if (Type == "edit")
                {
                    ImageButton ib = new ImageButton();
                    ib.ImageUrl = "/Images/delete.png";
                    ib.ID = t;
                    ib.Click += deletetag;
                    tagblock.Controls.Add(ib);
                }
            }
        }

        public void SetTags(List<Maticsoft.Model.Tb_Tag> mlt)
        {
            taglist = new List<string>();
            foreach (Maticsoft.Model.Tb_Tag mt in mlt)
            {
                string temp = mt.Tag_Content;
                taglist.Add(temp);
            }
        }

        public List<Maticsoft.Model.Tb_Tag> GetTags()
        {
            List<Maticsoft.Model.Tb_Tag> mlt = new List<Maticsoft.Model.Tb_Tag>();
            foreach (string s in taglist)
            {
                Maticsoft.Model.Tb_Tag mt = new Maticsoft.Model.Tb_Tag();
                mt.Tag_Content = s;
                mlt.Add(mt);
            }
            return mlt;
        }
    }
}