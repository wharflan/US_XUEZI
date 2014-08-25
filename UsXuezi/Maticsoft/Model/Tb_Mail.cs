/**  版本信息模板在安装目录下，可自行修改。
* Tb_Mail.cs
*
* 功 能： N/A
* 类 名： Tb_Mail
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
	public partial class Tb_Mail
	{
		public Tb_Mail()
		{}
		#region Model
		private int _mail_id;
		private int? _mail_posterid;
		private int? _mail_recieverid;
		private int? _mail_status=0;
		private string _mail_content;
		private DateTime? _mail_time= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int Mail_ID
		{
			set{ _mail_id=value;}
			get{return _mail_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Mail_PosterID
		{
			set{ _mail_posterid=value;}
			get{return _mail_posterid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Mail_RecieverID
		{
			set{ _mail_recieverid=value;}
			get{return _mail_recieverid;}
		}
		/// <summary>
		/// 0-未读 1-已读
		/// </summary>
		public int? Mail_Status
		{
			set{ _mail_status=value;}
			get{return _mail_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Mail_Content
		{
			set{ _mail_content=value;}
			get{return _mail_content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Mail_Time
		{
			set{ _mail_time=value;}
			get{return _mail_time;}
		}
		#endregion Model

	}
}

