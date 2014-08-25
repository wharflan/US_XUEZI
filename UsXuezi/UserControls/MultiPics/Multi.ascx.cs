using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace UsXuezi.UserControls.MultiPics
{
    public partial class Multi : System.Web.UI.UserControl
    {
        int maxnumber;

        public int Maxnumber
        {
            get { return maxnumber; }
            set { maxnumber = value; }
        }

        string width;

        public string Width
        {
            get { return width; }
            set { width = value; }
        }

        protected static string pics = "";

        protected string[] picstack;

        protected void Page_Load(object sender, EventArgs e)
        {
            //SetPic(pics);
        }


        public void MorePic()
        {
            for (int i = 1; i <= Maxnumber; i++)
            {
                CKPic thispic = (CKPic)Pics1.FindControl("MultiPic" + i);
                if (!thispic.Visible)
                {
                    thispic.Visible = true;
                    break;
                }
            }
            pics = GetPic();
            SetPic(pics);
        }

        public void LessPic()
        {
            for (int i = Maxnumber; i > 1; i--)
            {
                CKPic thispic = (CKPic)Pics1.FindControl("MultiPic" + i);
                if (thispic.Visible)
                {
                    thispic.Visible = false;
                    thispic.SetAddress("");
                    break;
                }
            }
            pics = GetPic();
            SetPic(pics);
        }

        public void SetPic(string temp)
        {

            if (temp != "" && temp != null)
            {
                picstack = temp.Split('|');
                for (int i = 1; i <= picstack.Length; i++)
                {
                    CKPic thispic = (CKPic)Pics1.FindControl("MultiPic" + i);
                    thispic.SetAddress(picstack[i - 1]);
                    thispic.Visible = true;
                }
            }

        }

        public string GetPic()
        {
            string temp = "";
            for (int i = 1; i <= Maxnumber; i++)
            {
                CKPic thispic = (CKPic)Pics1.FindControl("MultiPic" + i);
                if (thispic.GetAddress() != "")
                {
                    if (temp == "")
                    {
                        temp = thispic.GetAddress();
                    }
                    else
                        temp += "|" + thispic.GetAddress();
                }
            }
            return temp;
        }

        public string GetCover()
        {
            return MultiPic1.GetAddress();
        }

    }
}