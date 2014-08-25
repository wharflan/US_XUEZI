/**  版本信息模板在安装目录下，可自行修改。
* Tb_UsertoReply.cs
*
* 功 能： N/A
* 类 名： Tb_UsertoReply
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:15 AM   N/A    初版
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
	public partial class Tb_UsertoReply
	{
		public Tb_UsertoReply()
		{}
		#region Model
		private int _operation_id;
		private int? _operation_userid;
		private int? _opertaion_replyid;
		private int? _operation_type;
		private DateTime? _operation_time;
		/// <summary>
		/// 
		/// </summary>
		public int Operation_ID
		{
			set{ _operation_id=value;}
			get{return _operation_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Operation_UserID
		{
			set{ _operation_userid=value;}
			get{return _operation_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Opertaion_ReplyId
		{
			set{ _opertaion_replyid=value;}
			get{return _opertaion_replyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Operation_Type
		{
			set{ _operation_type=value;}
			get{return _operation_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Operation_Time
		{
			set{ _operation_time=value;}
			get{return _operation_time;}
		}
		#endregion Model

	}
}

