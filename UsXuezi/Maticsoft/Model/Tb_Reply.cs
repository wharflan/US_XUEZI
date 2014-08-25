/**  版本信息模板在安装目录下，可自行修改。
* Tb_Reply.cs
*
* 功 能： N/A
* 类 名： Tb_Reply
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:12 AM   N/A    初版
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
	public partial class Tb_Reply
	{
		public Tb_Reply()
		{}
		#region Model
		private int _reply_id;
		private int? _reply_postid;
		private int? _reply_userid;
		private int? _reply_replieduserid;
		private int? _reply_status=0;
		private DateTime? _reply_time= DateTime.Now;
		private string _reply_content;
		/// <summary>
		/// 
		/// </summary>
		public int Reply_ID
		{
			set{ _reply_id=value;}
			get{return _reply_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Reply_PostID
		{
			set{ _reply_postid=value;}
			get{return _reply_postid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Reply_UserID
		{
			set{ _reply_userid=value;}
			get{return _reply_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Reply_RepliedUserID
		{
			set{ _reply_replieduserid=value;}
			get{return _reply_replieduserid;}
		}
		/// <summary>
		/// 0-Normal 1-Deleted
		/// </summary>
		public int? Reply_Status
		{
			set{ _reply_status=value;}
			get{return _reply_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Reply_Time
		{
			set{ _reply_time=value;}
			get{return _reply_time;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Reply_Content
		{
			set{ _reply_content=value;}
			get{return _reply_content;}
		}
		#endregion Model

	}
}

