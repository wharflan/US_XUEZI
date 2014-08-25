/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostEstate.cs
*
* 功 能： N/A
* 类 名： Tb_PostEstate
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
	public partial class Tb_PostEstate
	{
		public Tb_PostEstate()
		{}
		#region Model
		private int _estate_postid;
		private int? _estate_areaid;
		private int? _estate_bedroom;
		private int? _estate_livingroom;
		private string _estate_type;
		private int? _estate_livingft;
		private int? _estate_groundft;
		private string _estate_parking;
		private int? _estate_managefee;
		private string _estate_cover;
		private string _estate_image;
		private string _estate_address;
		/// <summary>
		/// 
		/// </summary>
		public int Estate_PostID
		{
			set{ _estate_postid=value;}
			get{return _estate_postid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Estate_AreaID
		{
			set{ _estate_areaid=value;}
			get{return _estate_areaid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Estate_Bedroom
		{
			set{ _estate_bedroom=value;}
			get{return _estate_bedroom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Estate_Livingroom
		{
			set{ _estate_livingroom=value;}
			get{return _estate_livingroom;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Estate_Type
		{
			set{ _estate_type=value;}
			get{return _estate_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Estate_LivingFT
		{
			set{ _estate_livingft=value;}
			get{return _estate_livingft;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Estate_GroundFt
		{
			set{ _estate_groundft=value;}
			get{return _estate_groundft;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Estate_Parking
		{
			set{ _estate_parking=value;}
			get{return _estate_parking;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Estate_ManageFee
		{
			set{ _estate_managefee=value;}
			get{return _estate_managefee;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Estate_Cover
		{
			set{ _estate_cover=value;}
			get{return _estate_cover;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Estate_Image
		{
			set{ _estate_image=value;}
			get{return _estate_image;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Estate_Address
		{
			set{ _estate_address=value;}
			get{return _estate_address;}
		}
		#endregion Model

	}
}

