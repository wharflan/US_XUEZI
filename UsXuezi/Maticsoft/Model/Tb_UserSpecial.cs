/**  版本信息模板在安装目录下，可自行修改。
* Tb_UserSpecial.cs
*
* 功 能： N/A
* 类 名： Tb_UserSpecial
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:14 AM   N/A    初版
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
	public partial class Tb_UserSpecial
	{
		public Tb_UserSpecial()
		{}
		#region Model
		private int _user_id;
		private string _user_companynamech;
		private string _user_companynameen;
		private string _user_companyaddress;
		private int? _user_companystatus=0;
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
		public string User_CompanyNameCH
		{
			set{ _user_companynamech=value;}
			get{return _user_companynamech;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_CompanyNameEN
		{
			set{ _user_companynameen=value;}
			get{return _user_companynameen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string User_CompanyAddress
		{
			set{ _user_companyaddress=value;}
			get{return _user_companyaddress;}
		}
		/// <summary>
		/// 0-未认证 1-认证
		/// </summary>
		public int? User_CompanyStatus
		{
			set{ _user_companystatus=value;}
			get{return _user_companystatus;}
		}
		#endregion Model

	}
}

