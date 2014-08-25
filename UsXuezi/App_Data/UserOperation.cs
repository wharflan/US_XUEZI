using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace UsXuezi
{
    public class UserOperation
    {
        public static Boolean followUser(int FollowerID, int FollowedID)
        {
            try
            {
                Maticsoft.BLL.Tb_FollowUser bfu = new Maticsoft.BLL.Tb_FollowUser();
                Maticsoft.Model.Tb_FollowUser mfu = new Maticsoft.Model.Tb_FollowUser();
                mfu.Follow_FollowerID = FollowerID;
                mfu.Follow_FollowedID = FollowedID;
                bfu.Add(mfu);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static Boolean cancelFollowUser(int FollowerID, int FollowedID)
        {
            try
            {
                Maticsoft.BLL.Tb_FollowUser bfu = new Maticsoft.BLL.Tb_FollowUser();
                List<Maticsoft.Model.Tb_FollowUser> fulist = bfu.GetModelList("Follow_FollowerID=" + FollowerID.ToString() + " and Follow_FollowedID=" + FollowedID.ToString());
                bfu.Delete(fulist[0].Follow_ID);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean isFollowedUser(int FollowerID, int FollowedID)
        {
            try
            {
                Maticsoft.BLL.Tb_FollowUser bfu = new Maticsoft.BLL.Tb_FollowUser();
                List<Maticsoft.Model.Tb_FollowUser> fulist = bfu.GetModelList("Follow_FollowerID=" + FollowerID.ToString() + " and Follow_FollowedID=" + FollowedID.ToString());
                if (fulist.Count != 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean followPost(int UserID, int PostID)
        {
            try
            {
                Maticsoft.BLL.Tb_UsertoPost bup = new Maticsoft.BLL.Tb_UsertoPost();
                Maticsoft.Model.Tb_UsertoPost mup = new Maticsoft.Model.Tb_UsertoPost();
                mup.Operation_PostID = PostID;
                mup.Operation_UserID = UserID;
                mup.Operation_Type = 1;
                bup.Add(mup);
                return true;
            }
            catch (Exception)
            {
                return false;
            }

        }

        public static Boolean cancelFollowPost(int UserID, int PostID)
        {
            try
            {
                Maticsoft.BLL.Tb_UsertoPost bup = new Maticsoft.BLL.Tb_UsertoPost();
                string sql = "Operation_UserID=" + UserID + "and Operation_PostID=" + PostID + "and Operation_Type=1";
                List<Maticsoft.Model.Tb_UsertoPost> mlup = bup.GetModelList(sql);
                bup.Delete(mlup[0].Operation_ID);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static Boolean isFollowedPost(int UserID, int PostID)
        {
            try
            {
                Maticsoft.BLL.Tb_UsertoPost bup = new Maticsoft.BLL.Tb_UsertoPost();
                string sql = "Operation_UserID=" + UserID + "and Operation_PostID=" + PostID + "and Operation_Type=1";
                List<Maticsoft.Model.Tb_UsertoPost> mlup = bup.GetModelList(sql);
                if (mlup.Count != 0)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}