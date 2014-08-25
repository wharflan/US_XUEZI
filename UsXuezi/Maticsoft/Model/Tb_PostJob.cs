/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostJob.cs
*
* 功 能： N/A
* 类 名： Tb_PostJob
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:10 AM   N/A    初版
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
	public partial class Tb_PostJob
	{
		public Tb_PostJob()
		{}
		#region Model
		private int _job_id;
		private int? _job_postid;
		private string _job_type;
		private string _job_location;
		private int? _job_isfulltime;
		private int? _job_isparttime;
		private int? _job_iscontract;
		private int? _job_ispractice;
		private string _job_price;
		private string _job_experience;
		private string _job_contact;
		private DateTime? _job_enddate;
		private string _job_logo;
		private string _job_description;
		/// <summary>
		/// 
		/// </summary>
		public int Job_ID
		{
			set{ _job_id=value;}
			get{return _job_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Job_PostID
		{
			set{ _job_postid=value;}
			get{return _job_postid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Job_Type
		{
			set{ _job_type=value;}
			get{return _job_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Job_Location
		{
			set{ _job_location=value;}
			get{return _job_location;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Job_IsFullTime
		{
			set{ _job_isfulltime=value;}
			get{return _job_isfulltime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Job_IsPartTime
		{
			set{ _job_isparttime=value;}
			get{return _job_isparttime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Job_IsContract
		{
			set{ _job_iscontract=value;}
			get{return _job_iscontract;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Job_IsPractice
		{
			set{ _job_ispractice=value;}
			get{return _job_ispractice;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Job_Price
		{
			set{ _job_price=value;}
			get{return _job_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Job_Experience
		{
			set{ _job_experience=value;}
			get{return _job_experience;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Job_Contact
		{
			set{ _job_contact=value;}
			get{return _job_contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Job_EndDate
		{
			set{ _job_enddate=value;}
			get{return _job_enddate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Job_Logo
		{
			set{ _job_logo=value;}
			get{return _job_logo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Job_Description
		{
			set{ _job_description=value;}
			get{return _job_description;}
		}
		#endregion Model

	}
}

