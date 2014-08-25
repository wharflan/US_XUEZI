/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostUsedCar.cs
*
* 功 能： N/A
* 类 名： Tb_PostUsedCar
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:11 AM   N/A    初版
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
	public partial class Tb_PostUsedCar
	{
		public Tb_PostUsedCar()
		{}
		#region Model
		private int _usedcar_id;
		private int? _usedcar_postid;
		private int? _usedcar_areaid;
		private int? _usedcar_price;
		private int? _usedcar_cleantitle;
		private string _usedcar_type;
		private string _usedcar_model;
		private string _usedcar_buyyear;
		private int? _usedcar_miles;
		private string _usedcar_cover;
		private string _usedcar_imgs;
		private string _usedcar_description;
		/// <summary>
		/// 
		/// </summary>
		public int UsedCar_ID
		{
			set{ _usedcar_id=value;}
			get{return _usedcar_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UsedCar_PostID
		{
			set{ _usedcar_postid=value;}
			get{return _usedcar_postid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UsedCar_AreaID
		{
			set{ _usedcar_areaid=value;}
			get{return _usedcar_areaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UsedCar_Price
		{
			set{ _usedcar_price=value;}
			get{return _usedcar_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UsedCar_CleanTitle
		{
			set{ _usedcar_cleantitle=value;}
			get{return _usedcar_cleantitle;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UsedCar_Type
		{
			set{ _usedcar_type=value;}
			get{return _usedcar_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UsedCar_Model
		{
			set{ _usedcar_model=value;}
			get{return _usedcar_model;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UsedCar_BuyYear
		{
			set{ _usedcar_buyyear=value;}
			get{return _usedcar_buyyear;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? UsedCar_Miles
		{
			set{ _usedcar_miles=value;}
			get{return _usedcar_miles;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UsedCar_Cover
		{
			set{ _usedcar_cover=value;}
			get{return _usedcar_cover;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UsedCar_Imgs
		{
			set{ _usedcar_imgs=value;}
			get{return _usedcar_imgs;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UsedCar_Description
		{
			set{ _usedcar_description=value;}
			get{return _usedcar_description;}
		}
		#endregion Model

	}
}

