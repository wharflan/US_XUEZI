/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostBusiness.cs
*
* 功 能： N/A
* 类 名： Tb_PostBusiness
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:09 AM   N/A    初版
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
	public partial class Tb_PostBusiness
	{
		public Tb_PostBusiness()
		{}
		#region Model
		private int _business_postid;
		private int? _business_areaid;
		private int? _business_typeid;
		private string _business_description="暂无";
		private string _business_cover;
		private string _business_address;
		private string _business_maincontent;
		private int? _business_status=0;
		private string _business_phone;
		private string _business_wechat;
		private string _business_email;
		private string _business_qq;
		private string _business_weibo;
		/// <summary>
		/// 
		/// </summary>
		public int Business_PostID
		{
			set{ _business_postid=value;}
			get{return _business_postid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Business_AreaID
		{
			set{ _business_areaid=value;}
			get{return _business_areaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Business_TypeID
		{
			set{ _business_typeid=value;}
			get{return _business_typeid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Business_Description
		{
			set{ _business_description=value;}
			get{return _business_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Business_Cover
		{
			set{ _business_cover=value;}
			get{return _business_cover;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Business_Address
		{
			set{ _business_address=value;}
			get{return _business_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Business_MainContent
		{
			set{ _business_maincontent=value;}
			get{return _business_maincontent;}
		}
		/// <summary>
		/// 0-未认证 1-认证
		/// </summary>
		public int? Business_Status
		{
			set{ _business_status=value;}
			get{return _business_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Business_Phone
		{
			set{ _business_phone=value;}
			get{return _business_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Business_Wechat
		{
			set{ _business_wechat=value;}
			get{return _business_wechat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Business_Email
		{
			set{ _business_email=value;}
			get{return _business_email;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Business_QQ
		{
			set{ _business_qq=value;}
			get{return _business_qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Business_Weibo
		{
			set{ _business_weibo=value;}
			get{return _business_weibo;}
		}
		#endregion Model

	}
}

