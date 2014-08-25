/**  版本信息模板在安装目录下，可自行修改。
* Tb_Coupon.cs
*
* 功 能： N/A
* 类 名： Tb_Coupon
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:07 AM   N/A    初版
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
	/// Tb_Coupon:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tb_Coupon
	{
		public Tb_Coupon()
		{}
		#region Model
		private int _coupon_id;
		private int? _coupon_businessid;
		private string _coupon_name;
		private string _coupon_description;
		private string _coupon_img;
		private DateTime? _coupon_startdate;
		private DateTime? _coupon_enddate;
		/// <summary>
		/// 
		/// </summary>
		public int Coupon_ID
		{
			set{ _coupon_id=value;}
			get{return _coupon_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Coupon_BusinessID
		{
			set{ _coupon_businessid=value;}
			get{return _coupon_businessid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Coupon_Name
		{
			set{ _coupon_name=value;}
			get{return _coupon_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Coupon_Description
		{
			set{ _coupon_description=value;}
			get{return _coupon_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Coupon_Img
		{
			set{ _coupon_img=value;}
			get{return _coupon_img;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Coupon_StartDate
		{
			set{ _coupon_startdate=value;}
			get{return _coupon_startdate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Coupon_EndDate
		{
			set{ _coupon_enddate=value;}
			get{return _coupon_enddate;}
		}
		#endregion Model

	}
}

