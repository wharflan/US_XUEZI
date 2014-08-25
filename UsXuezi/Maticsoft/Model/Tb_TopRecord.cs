/**  版本信息模板在安装目录下，可自行修改。
* Tb_TopRecord.cs
*
* 功 能： N/A
* 类 名： Tb_TopRecord
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:13 AM   N/A    初版
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
	public partial class Tb_TopRecord
	{
		public Tb_TopRecord()
		{}
		#region Model
		private int _top_id;
		private int? _top_postid;
		private int? _top_userid;
		private DateTime? _top_time= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int Top_ID
		{
			set{ _top_id=value;}
			get{return _top_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Top_PostID
		{
			set{ _top_postid=value;}
			get{return _top_postid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Top_UserID
		{
			set{ _top_userid=value;}
			get{return _top_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Top_Time
		{
			set{ _top_time=value;}
			get{return _top_time;}
		}
		#endregion Model

	}
}

