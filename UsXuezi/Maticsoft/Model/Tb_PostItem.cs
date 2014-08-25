/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostItem.cs
*
* 功 能： N/A
* 类 名： Tb_PostItem
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  8/18/2014 6:25:24 PM   N/A    初版
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
	/// Tb_PostItem:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tb_PostItem
	{
		public Tb_PostItem()
		{}
		#region Model
		private int _item_id;
		private int _item_post_id;
		private string _item_name;
		private int? _item_price;
		private int? _item_isself=0;
		private int? _item_ismailed=0;
		private string _item_type="其他";
		private string _item_status;
		private string _item_images;
		private string _item_description;
		private string _item_cover;
		private string _item_phone;
		private string _item_wechat;
		private string _item_qq;
		private string _item_email;
		/// <summary>
		/// 
		/// </summary>
		public int Item_ID
		{
			set{ _item_id=value;}
			get{return _item_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Item_Post_ID
		{
			set{ _item_post_id=value;}
			get{return _item_post_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Item_Name
		{
			set{ _item_name=value;}
			get{return _item_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Item_Price
		{
			set{ _item_price=value;}
			get{return _item_price;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Item_IsSelf
		{
			set{ _item_isself=value;}
			get{return _item_isself;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Item_IsMailed
		{
			set{ _item_ismailed=value;}
			get{return _item_ismailed;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Item_Type
		{
			set{ _item_type=value;}
			get{return _item_type;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Item_Status
		{
			set{ _item_status=value;}
			get{return _item_status;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Item_Images
		{
			set{ _item_images=value;}
			get{return _item_images;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Item_Description
		{
			set{ _item_description=value;}
			get{return _item_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Item_Cover
		{
			set{ _item_cover=value;}
			get{return _item_cover;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Item_Phone
		{
			set{ _item_phone=value;}
			get{return _item_phone;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Item_Wechat
		{
			set{ _item_wechat=value;}
			get{return _item_wechat;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Item_QQ
		{
			set{ _item_qq=value;}
			get{return _item_qq;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Item_Email
		{
			set{ _item_email=value;}
			get{return _item_email;}
		}
		#endregion Model

	}
}

