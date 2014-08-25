/**  版本信息模板在安装目录下，可自行修改。
* Tb_Post.cs
*
* 功 能： N/A
* 类 名： Tb_Post
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:44 AM   N/A    初版
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
	/// 1. 关注
	///2. 收藏
	///3. 点赞
	/// </summary>
	[Serializable]
	public partial class Tb_Post
	{
		public Tb_Post()
		{}
		#region Model
		private int _post_id;
		private int? _post_cityid=1;
		private int? _post_othercity=0;
		private int? _post_visible=1;
		private int? _post_type;
		private int? _post_userid;
		private string _post_title;
		private int? _post_click=0;
		private DateTime? _post_posttime= DateTime.Now;
		private DateTime? _post_lastedittime= DateTime.Now;
		private int? _post_defaultsort;
		private int? _post_isanonymous=0;
		/// <summary>
		/// 
		/// </summary>
		public int Post_ID
		{
			set{ _post_id=value;}
			get{return _post_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Post_CityID
		{
			set{ _post_cityid=value;}
			get{return _post_cityid;}
		}
		/// <summary>
		/// 0-不推送 1-推送到其他城市
		/// </summary>
		public int? Post_OtherCity
		{
			set{ _post_othercity=value;}
			get{return _post_othercity;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Post_Visible
		{
			set{ _post_visible=value;}
			get{return _post_visible;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Post_Type
		{
			set{ _post_type=value;}
			get{return _post_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Post_UserID
		{
			set{ _post_userid=value;}
			get{return _post_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Post_Title
		{
			set{ _post_title=value;}
			get{return _post_title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Post_Click
		{
			set{ _post_click=value;}
			get{return _post_click;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Post_PostTime
		{
			set{ _post_posttime=value;}
			get{return _post_posttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Post_LastEditTime
		{
			set{ _post_lastedittime=value;}
			get{return _post_lastedittime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Post_DefaultSort
		{
			set{ _post_defaultsort=value;}
			get{return _post_defaultsort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Post_IsAnonymous
		{
			set{ _post_isanonymous=value;}
			get{return _post_isanonymous;}
		}
		#endregion Model

	}
}

