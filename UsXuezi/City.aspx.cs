using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using UsXuezi.UserControls;


namespace UsXuezi
{
    public partial class City : System.Web.UI.Page
    {
        /*
         *  1	Estate	    房产交易    block   
            2	Business	商家        block
            3	Rent	    租房        block
            4	Item	    物品        block
            5	UsedCar	    二手车      block
            6	Job	        招聘        bar
            7	QA	        答疑解惑    bar
            8	Chat	    吹水吐槽    bar
            9	Food	    美食餐饮    block
         * 
         * */

        protected List<Maticsoft.Model.Tb_Post> mlp;
        protected static int block_per_page = 9;
        protected HttpCookie cookie_City;
        public string citytitle;

        protected override void OnInit(EventArgs e)
        {
            base.OnInit(e);

            DropDownList dpl1 = ((MasterPage)this.Master).FindControl("DropDownList1") as DropDownList;
            dpl1.SelectedIndexChanged += new EventHandler(city_SelectedIndexChanged);
        }

        void city_SelectedIndexChanged(object sender, EventArgs e)
        {
            string city_type = Request.QueryString["type"];
            getfirstpage(int.Parse(city_type));
        }

        protected void Page_LoadComplete(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cookie_City = CookieLibrary.GetCookie("City_ID");
                string city_type = Request.QueryString["type"];
                Session["CityPostList"] = null;
                if (city_type != null)
                {
                    if (city_type != "0")
                    {
                        //Others Issues

                        this.Title = Session["City_Name"].ToString();
                        switch (int.Parse(city_type))
                        {
                            case 1:
                                this.Title += "房产交易";
                                EF1.Visible = true;
                                break;
                            case 2:
                                this.Title += "商家机构";
                                BF1.Visible = true;
                                BF1.updatelist();
                                break;
                            case 3:
                                this.Title += "房屋转租";
                                RF1.Visible = true;
                                RF1.updatelist();
                                break;
                            case 4:
                                this.Title += "二手市场";
                                IF1.Visible = true;
                                IF1.updatelist();
                                break;
                            case 5:
                                this.Title += "二手车";
                                UCF1.Visible = true;
                                break;
                            case 6:
                                this.Title += "招聘";
                                JF1.Visible = true;
                                break;
                            case 7:
                                this.Title += "答疑解惑";
                                break;
                            case 8:
                                this.Title += "吹水吐槽";
                                break;
                            case 9:
                                this.Title += "美食餐饮";
                                FF1.Visible = true;
                                break;
                        }
                        getfirstpage(int.Parse(city_type));
                    }
                    else
                    {
                        //Hot Issues
                        this.Title = Session["City_Name"].ToString() + "热门话题";
                    }
                }
                else
                {
                    Response.Redirect(Request.RawUrl + "?type=0");
                }

                if (HiddenField1.Value != "1")
                {
                    Button3.Visible = true;
                }
                else
                    Button3.Visible = false;

            }
        }


        protected Boolean getList(int post_type)
        {
            mlp = new List<Maticsoft.Model.Tb_Post>();
            mlp = Session["CityPostList"] as List<Maticsoft.Model.Tb_Post>;
            if (int.Parse(Request.QueryString["type"]) > 6)
            {
                Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
                string str = "Post_Type = " + post_type + " and Post_CityID = " + Session["City_ID"].ToString();
                str += " order by Post_ID Desc";
                mlp = bp.GetModelList(str);
                Session["CityPostList"] = mlp;
            }
            return true;

        }

        //第一页
        protected void getfirstpage(int type)
        {
            HiddenField1.Value = "1";
            getList(type);
            getpagecontent(1);
            //page count
            int totalpage = (mlp.Count + block_per_page - 1) / block_per_page;
            if (totalpage > 1)
            {
                DropDownList1.Visible = true;
                DropDownList1.Items.Clear();
                for (int i = 0; i < totalpage; i++)
                {
                    ListItem li = new ListItem();
                    li.Text = (i + 1).ToString();
                    li.Value = li.Text;
                    DropDownList1.Items.Add(li);
                }
            }
            else
                DropDownList1.Visible = false;
        }

        //下一页
        protected void Button2_Click(object sender, EventArgs e)
        {
            int pagenum = int.Parse(HiddenField1.Value);
            pagenum++;
            HiddenField1.Value = pagenum.ToString();
            getpagecontent(pagenum);
            DropDownList1.SelectedIndex = DropDownList1.SelectedIndex + 1;
        }

        //上一页
        protected void Button3_Click(object sender, EventArgs e)
        {
            int pagenum = int.Parse(HiddenField1.Value);
            pagenum--;
            HiddenField1.Value = pagenum.ToString();
            getpagecontent(pagenum);
            DropDownList1.SelectedIndex = DropDownList1.SelectedIndex - 1;
        }

        protected void getpagecontent(int pagenum)
        {
            postcontents.Controls.Clear();
            List<PostBlock> temp = new List<PostBlock>();
            mlp = Session["CityPostList"] as List<Maticsoft.Model.Tb_Post>;
            if (mlp == null)
            {
                mlp = new List<Maticsoft.Model.Tb_Post>();
            }
            for (int i = (pagenum - 1) * block_per_page; i < pagenum * block_per_page && i < mlp.Count; i++)
            {
                try
                {
                    PostBlock pb = new PostBlock();
                    pb = (PostBlock)pb.LoadControl("/UserControls/PostBlock.ascx");
                    pb.Post_id = mlp[i].Post_ID;
                    pb.ID = mlp[i].Post_ID.ToString();
                    if (mlp[i].Post_Type >= 6 && mlp[i].Post_Type <= 8)
                        pb.Type = "bar";
                    else
                        pb.Type = "block";
                    temp.Add(pb);
                }
                catch (Exception)
                {
                    continue;
                }
            }
            foreach (PostBlock tpb in temp)
            {
                postcontents.Controls.Add(tpb);
            }

            //next button
            if ((pagenum * block_per_page >= mlp.Count))
            {
                Button2.Visible = false;
            }
            else
            {
                Button2.Visible = true;
            }



            //previous button
            if (HiddenField1.Value != "1")
            {
                Button3.Visible = true;
            }
            else
                Button3.Visible = false;


        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            DropDownList dpl1 = (DropDownList)this.Master.FindControl("DropDownList1");
            dpl1.SelectedIndex = 0;
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            DropDownList dpl1 = (DropDownList)this.Master.FindControl("DropDownList1");
            dpl1.SelectedIndex = 3;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HiddenField1.Value = DropDownList1.SelectedValue;
            getpagecontent(int.Parse(DropDownList1.SelectedValue));
        }

        protected void showallbusiness(int post_type)
        {
            Maticsoft.BLL.Tb_PostBusiness bpb = new Maticsoft.BLL.Tb_PostBusiness();
            List<Maticsoft.Model.Tb_PostBusiness> mlpb;

            if (post_type == 9)
            {
                mlpb = bpb.GetModelList("Business_Status = 0 and Business_TypeID IS NULL");
            }
            else
            {
                mlpb = bpb.GetModelList("Business_Status = 0 and Business_TypeID IS NOT NULL");
            }
            foreach (Maticsoft.Model.Tb_PostBusiness temp in mlpb)
            {
                try
                {
                    Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
                    Maticsoft.Model.Tb_Post mp = bp.GetModel(temp.Business_PostID);
                    mlp.Add(mp);
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string city_type = Request.QueryString["type"];
            if (city_type != null)
            {
                if (city_type != "0")
                {
                    //Others Issues
                    switch (int.Parse(city_type))
                    {
                        case 1:
                            this.Title += "房产交易";
                            break;
                        case 2:
                            this.Title += "商家机构";

                            BF1.updatelist();
                            break;
                        case 3:
                            this.Title += "房屋转租";
                            RF1.updatelist();
                            break;
                        case 4:
                            this.Title += "二手市场";
                            IF1.updatelist();
                            break;
                        case 5:
                            this.Title += "二手车";
                            break;
                        case 6:
                            this.Title += "招聘";
                            break;
                        case 7:
                            this.Title += "答疑解惑";
                            break;
                        case 8:
                            this.Title += "吹水吐槽";
                            break;
                        case 9:
                            this.Title += "美食餐饮";
                            break;
                    }
                    getfirstpage(int.Parse(city_type));
                }
            }
        }
    }
}