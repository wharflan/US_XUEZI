/**  版本信息模板在安装目录下，可自行修改。
* Tb_User.cs
*
* 功 能： N/A
* 类 名： Tb_User
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  8/5/2014 3:07:29 AM   N/A    初版
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
	/// Tb_User:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tb_User
	{
		public Tb_User()
		{}
		#region Model
		private int _user_id;
		private string _user_email;
		private string _user_username;
		private string _user_password;
		private int? _user_type;
		private int? _user_status=0;
		private int? _user_cityid;
		private int? _user_points;
		private int? _user_sex=0;
		private string _user_birth;
		private string _user_phone;
		private string _user_qq;
		private string _user_wechat;
		private string _user_weibo;
		private string _user_usingemail;
		private string _user_major;
		private string _user_school;
		private string _user_description;
		private DateTime? _user_registerdate= DateTime.Now;
		private DateTime? _user_lastonline= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int User_ID
		{
			set{ _user_id=value;}
			get{return _user_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_Email
		{
			set{ _user_email=value;}
			get{return _user_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_UserName
		{
			set{ _user_username=value;}
			get{return _user_username;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_Password
		{
			set{ _user_password=value;}
			get{return _user_password;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? User_Type
		{
			set{ _user_type=value;}
			get{return _user_type;}
		}
		/// <summary>
		/// 0-未激活 1-正常 2-黑名单
		/// </summary>
		public int? User_Status
		{
			set{ _user_status=value;}
			get{return _user_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? User_CityID
		{
			set{ _user_cityid=value;}
			get{return _user_cityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? User_Points
		{
			set{ _user_points=value;}
			get{return _user_points;}
		}
		/// <summary>
		/// 0
		/// </summary>
		public int? User_Sex
		{
			set{ _user_sex=value;}
			get{return _user_sex;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_Birth
		{
			set{ _user_birth=value;}
			get{return _user_birth;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_Phone
		{
			set{ _user_phone=value;}
			get{return _user_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_QQ
		{
			set{ _user_qq=value;}
			get{return _user_qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_Wechat
		{
			set{ _user_wechat=value;}
			get{return _user_wechat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_Weibo
		{
			set{ _user_weibo=value;}
			get{return _user_weibo;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_UsingEmail
		{
			set{ _user_usingemail=value;}
			get{return _user_usingemail;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_Major
		{
			set{ _user_major=value;}
			get{return _user_major;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_School
		{
			set{ _user_school=value;}
			get{return _user_school;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_Description
		{
			set{ _user_description=value;}
			get{return _user_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? User_RegisterDate
		{
			set{ _user_registerdate=value;}
			get{return _user_registerdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? User_LastOnline
		{
			set{ _user_lastonline=value;}
			get{return _user_lastonline;}
		}
		#endregion Model

	}
}

