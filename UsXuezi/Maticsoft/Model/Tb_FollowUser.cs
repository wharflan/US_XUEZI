/**  版本信息模板在安装目录下，可自行修改。
* Tb_FollowUser.cs
*
* 功 能： N/A
* 类 名： Tb_FollowUser
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:08 AM   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Maticsoft.Model
{
	/// <summary>
	/// 关注用户Bridge
	/// </summary>
	[Serializable]
	public partial class Tb_FollowUser
	{
		public Tb_FollowUser()
		{}
		#region Model
		private int _follow_id;
		private int _follow_followerid;
		private int _follow_followedid;
		/// <summary>
		/// 
		/// </summary>
		public int Follow_ID
		{
			set{ _follow_id=value;}
			get{return _follow_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Follow_FollowerID
		{
			set{ _follow_followerid=value;}
			get{return _follow_followerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Follow_FollowedID
		{
			set{ _follow_followedid=value;}
			get{return _follow_followedid;}
		}
		#endregion Model

	}
}

