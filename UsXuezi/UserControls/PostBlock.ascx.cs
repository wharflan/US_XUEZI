using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Configuration;

namespace UsXuezi.UserControls
{
    public partial class PostBlock : System.Web.UI.UserControl
    {
        /*
         *  1	Estate	    房产交易
            2	Business	商家
            3	Rent	    租房
            4	Item	    物品
            5	UsedCar	    二手车
            6	Job	        招聘
            7	QA	        问答专栏
            8	Chat	    吹水吐槽
            9	Food	    美食餐饮
         * 
         * */
        protected Maticsoft.Model.Tb_Post mp; //post model
        protected string posturl;
        protected string userurl;

        int post_id;

        public int Post_id
        {
            get { return post_id; }
            set { post_id = value; }
        }

        string type;  // bar or block

        public string Type
        {
            get { return type; }
            set { type = value; }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            mp = bp.GetModel(post_id);
            try
            {
                if (!buildmodel())
                {
                    //record fail_id

                }
            }
            catch (Exception)
            {
            }
        }

        protected Boolean buildmodel()
        {
            Insus.NET.InsusCharacterUtility icu = new Insus.NET.InsusCharacterUtility();
            //Posttitle.Text = icu.BriefContent(mp.Post_Title, 20);
            Boolean flag = false;
            switch (mp.Post_Type)
            {
                case 1:
                    flag = buildEstate();
                    break;
                case 2:
                    flag = buildBusiness();
                    break;
                case 3:
                    flag = buildRent();
                    break;
                case 4:
                    flag = buildItem();
                    break;
                case 5:
                    flag = buildUsedcar();
                    break;
                case 6:
                    flag = buildJob();
                    break;
                case 7:
                    flag = buildQA();
                    break;
                case 8:
                    flag = buildChat();
                    break;
                case 9:
                    flag = buildFood();
                    break;
            }
            return flag;
        }

        protected Boolean buildEstate()
        {
            Maticsoft.BLL.Tb_PostEstate bpe = new Maticsoft.BLL.Tb_PostEstate();
            Maticsoft.Model.Tb_PostEstate mpe = bpe.GetModel(mp.Post_ID);
            posturl = EFun.getAddress("Estate") + "?id=" + mp.Post_ID;

            Label4.Text = mp.Post_Title;
            Image1.ImageUrl = mpe.Estate_Cover;

            list_tag.Visible = true;
            Label1.Text = "$" + mpe.Estate_LivingFT + "Ftsq" + mpe.Estate_Type;
            //Label2.Text = mpi.Item_Description;

            return true;
        }

        protected Boolean buildBusiness()
        {
            Maticsoft.BLL.Tb_PostBusiness bpb = new Maticsoft.BLL.Tb_PostBusiness();
            Maticsoft.Model.Tb_PostBusiness mpb = bpb.GetModel(mp.Post_ID);
            posturl = EFun.getAddress("Business") + "?id=" + mp.Post_ID;

            Label4.Text = mp.Post_Title;
            Image1.ImageUrl = mpb.Business_Cover;
            //Label2.Text = mpi.Item_Description;

            return true;
        }

        protected Boolean buildRent()
        {
            Maticsoft.BLL.Tb_PostRent bpr = new Maticsoft.BLL.Tb_PostRent();
            Maticsoft.Model.Tb_PostRent mpr = bpr.GetModel(mp.Post_ID);

            posturl = EFun.getAddress("Rent") + "?id=" + mp.Post_ID;
            Label4.Text = mp.Post_Title;
            Image1.ImageUrl = mpr.Rent_Cover;

            list_tag.Visible = true;
            Label1.Text = "$" + mpr.Rent_Price.ToString();
            return true;
        }

        protected Boolean buildItem()
        {
            Maticsoft.BLL.Tb_PostItem bpi = new Maticsoft.BLL.Tb_PostItem();
            List<Maticsoft.Model.Tb_PostItem> mlpi = bpi.GetModelList("Item_Post_ID=" + mp.Post_ID);
            Maticsoft.Model.Tb_PostItem mpi = mlpi[0];

            posturl = EFun.getAddress("Item") + "?id=" + mp.Post_ID;
            Label4.Text = mp.Post_Title;
            Image1.ImageUrl = mpi.Item_Cover;

            list_tag.Visible = true;
            Label1.Text = "$" + mpi.Item_Price.ToString();
            //Label2.Text = mpi.Item_Description;

            return true;
        }

        protected Boolean buildUsedcar()
        {
            Maticsoft.BLL.Tb_PostUsedCar bpuc = new Maticsoft.BLL.Tb_PostUsedCar();
            List<Maticsoft.Model.Tb_PostUsedCar> mlpuc = bpuc.GetModelList("UsedCar_PostID=" + mp.Post_ID);
            Maticsoft.Model.Tb_PostUsedCar mpuc = mlpuc[0];
            posturl = EFun.getAddress("UsedCar") + "?id=" + mp.Post_ID;

            Label4.Text = mp.Post_Title;
            Image1.ImageUrl = mpuc.UsedCar_Cover;

            list_tag.Visible = true;
            Label1.Text = "$" + mpuc.UsedCar_Price.ToString();
            //Label2.Text = mpuc.Item_Description;

            return true;
        }

        protected Boolean buildJob()
        {
            Maticsoft.BLL.Tb_PostJob bpj = new Maticsoft.BLL.Tb_PostJob();
            Maticsoft.Model.Tb_PostJob mpj = bpj.GetModel(mp.Post_ID);
            posturl = EFun.getAddress("Job") + "?id=" + mp.Post_ID;
            userurl = EFun.getAddress("Person") + "?id=" + mp.Post_UserID;

            Label4.Text = mp.Post_Title;
            Image1.ImageUrl = mpj.Job_Logo;//头像
            //Label2.Text = mpuc.Item_Description;
            return true;
        }

        protected Boolean buildQA()
        {
            Maticsoft.BLL.Tb_PostNormal bpn = new Maticsoft.BLL.Tb_PostNormal();
            Maticsoft.Model.Tb_PostNormal mpn = bpn.GetModel(mp.Post_ID);
            posturl = EFun.getAddress("QA") + "?id=" + mp.Post_ID;
            userurl = EFun.getAddress("Person") + "?id=" + mp.Post_UserID;

            Label4.Text = mp.Post_Title;
            Image1.ImageUrl = mp.Post_UserID.ToString();//头像
            
            Maticsoft.BLL.Tb_Reply btr = new Maticsoft.BLL.Tb_Reply();
            List<Maticsoft.Model.Tb_Reply> blmr = btr.GetModelList("reply_PostID=" + mp.Post_ID);

            Label3.Text = "查看/回答: " + mp.Post_Click + "/" + blmr.Count;

            Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
            Maticsoft.Model.Tb_User mu = bu.GetModel((int)mp.Post_UserID);
            Label5.Text = mu.User_UserName;
            //Label2.Text = mpuc.Item_Description;
            return true;
        }

        protected Boolean buildChat()
        {
            Maticsoft.BLL.Tb_PostNormal bpn = new Maticsoft.BLL.Tb_PostNormal();
            Maticsoft.Model.Tb_PostNormal mpn = bpn.GetModel(mp.Post_ID);
            posturl = EFun.getAddress("Chat") + "?id=" + mp.Post_ID;
            userurl = EFun.getAddress("Person") + "?id=" + mp.Post_UserID;

            Label4.Text = mp.Post_Title;

            Image1.ImageUrl = mp.Post_UserID.ToString();//头像

            Maticsoft.BLL.Tb_Reply btr = new Maticsoft.BLL.Tb_Reply();
            List<Maticsoft.Model.Tb_Reply> blmr = btr.GetModelList("reply_PostID=" + mp.Post_ID);

            Label3.Text = "点击/回复: " + mp.Post_Click + "/" + blmr.Count;

            Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
            Maticsoft.Model.Tb_User mu = bu.GetModel((int)mp.Post_UserID);
            Label5.Text = mu.User_UserName;
            //Label2.Text = mpuc.Item_Description;
            return true;
        }

        protected Boolean buildFood()
        {
            Maticsoft.BLL.Tb_PostBusiness bpb = new Maticsoft.BLL.Tb_PostBusiness();
            Maticsoft.Model.Tb_PostBusiness mpb = bpb.GetModel(mp.Post_ID);
            posturl = EFun.getAddress("Business") + "?id=" + mp.Post_ID; ;

            Label4.Text = mp.Post_Title;
            Image1.ImageUrl = mpb.Business_Cover;

            //Label2.Text = mpi.Item_Description;

            return true;
        }


    }
}