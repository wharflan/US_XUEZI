/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostRent.cs
*
* 功 能： N/A
* 类 名： Tb_PostRent
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  8/5/2014 10:43:31 AM   N/A    初版
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
	/// Tb_PostRent:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tb_PostRent
	{
		public Tb_PostRent()
		{}
		#region Model
		private int _rent_id;
		private int? _rent_area;
		private int? _rent_price;
		private int? _rent_issingleroom;
		private int? _rent_iswholebuilding;
		private DateTime? _rent_start;
		private DateTime? _rent_end;
		private string _rent_cover;
		private string _rent_images;
		private string _rent_address;
		private string _rent_description;
		private string _rent_furniture;
		private string _rent_pat;
		private int? _rent_streetpark;
		private int? _rent_garage;
		private string _rent_phone;
		private string _rent_wechat;
		private string _rent_qq;
		private string _rent_email;
		/// <summary>
		/// 
		/// </summary>
		public int Rent_ID
		{
			set{ _rent_id=value;}
			get{return _rent_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Rent_Area
		{
			set{ _rent_area=value;}
			get{return _rent_area;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Rent_Price
		{
			set{ _rent_price=value;}
			get{return _rent_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Rent_IsSingleRoom
		{
			set{ _rent_issingleroom=value;}
			get{return _rent_issingleroom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Rent_IsWholeBuilding
		{
			set{ _rent_iswholebuilding=value;}
			get{return _rent_iswholebuilding;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Rent_Start
		{
			set{ _rent_start=value;}
			get{return _rent_start;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Rent_End
		{
			set{ _rent_end=value;}
			get{return _rent_end;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rent_Cover
		{
			set{ _rent_cover=value;}
			get{return _rent_cover;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rent_Images
		{
			set{ _rent_images=value;}
			get{return _rent_images;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rent_Address
		{
			set{ _rent_address=value;}
			get{return _rent_address;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rent_Description
		{
			set{ _rent_description=value;}
			get{return _rent_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rent_Furniture
		{
			set{ _rent_furniture=value;}
			get{return _rent_furniture;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rent_Pat
		{
			set{ _rent_pat=value;}
			get{return _rent_pat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Rent_StreetPark
		{
			set{ _rent_streetpark=value;}
			get{return _rent_streetpark;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Rent_Garage
		{
			set{ _rent_garage=value;}
			get{return _rent_garage;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rent_Phone
		{
			set{ _rent_phone=value;}
			get{return _rent_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rent_Wechat
		{
			set{ _rent_wechat=value;}
			get{return _rent_wechat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rent_QQ
		{
			set{ _rent_qq=value;}
			get{return _rent_qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Rent_Email
		{
			set{ _rent_email=value;}
			get{return _rent_email;}
		}
		#endregion Model

	}
}

