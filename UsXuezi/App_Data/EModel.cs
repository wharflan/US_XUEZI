using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsXuezi
{
    public class EModel
    {
        protected static Maticsoft.Model.Tb_User mu;
        protected static Maticsoft.Model.Tb_Post mp;

        public static Maticsoft.Model.Tb_User getPoster(int postid)
        {
            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            mp = bp.GetModel(postid);
            Maticsoft.BLL.Tb_User bu = new Maticsoft.BLL.Tb_User();
            mu = bu.GetModel((int)mp.Post_UserID);
            return mu;
        }

        public static Maticsoft.Model.Tb_PostItem getItem(int postid)
        {
            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            mp = bp.GetModel(postid);
            Maticsoft.BLL.Tb_PostItem bpi = new Maticsoft.BLL.Tb_PostItem();
            List<Maticsoft.Model.Tb_PostItem> mlpi = bpi.GetModelList("Item_Post_ID=" + mp.Post_ID);
            Maticsoft.Model.Tb_PostItem mpi = mlpi[0];

            return mpi;
        }

        public static Maticsoft.Model.Tb_PostJob getJob(int postid)
        {
            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            mp = bp.GetModel(postid);
            Maticsoft.BLL.Tb_PostJob bpj = new Maticsoft.BLL.Tb_PostJob();
            List<Maticsoft.Model.Tb_PostJob> mlpj = bpj.GetModelList("Job_PostID=" + mp.Post_ID);
            Maticsoft.Model.Tb_PostJob mpj = mlpj[0];

            return mpj;
        }

        public static Maticsoft.Model.Tb_City getCity(int postid)
        {
            Maticsoft.BLL.Tb_Post bp = new Maticsoft.BLL.Tb_Post();
            mp = bp.GetModel(postid);
            Maticsoft.BLL.Tb_City bc = new Maticsoft.BLL.Tb_City();
            Maticsoft.Model.Tb_City mc = bc.GetModel((int)mp.Post_CityID);
            return mc;
        }

       

    }
}