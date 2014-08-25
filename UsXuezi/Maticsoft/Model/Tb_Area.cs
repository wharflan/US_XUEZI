/**  版本信息模板在安装目录下，可自行修改。
* Tb_Area.cs
*
* 功 能： N/A
* 类 名： Tb_Area
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:06 AM   N/A    初版
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
	/// Tb_Area:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tb_Area
	{
		public Tb_Area()
		{}
		#region Model
		private int _area_id;
		private int _area_cityid;
		private string _area_name;
		/// <summary>
		/// 
		/// </summary>
		public int Area_ID
		{
			set{ _area_id=value;}
			get{return _area_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Area_CityID
		{
			set{ _area_cityid=value;}
			get{return _area_cityid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Area_Name
		{
			set{ _area_name=value;}
			get{return _area_name;}
		}
		#endregion Model

	}
}

