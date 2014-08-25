/**  版本信息模板在安装目录下，可自行修改。
* Tb_City.cs
*
* 功 能： N/A
* 类 名： Tb_City
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
	/// Tb_City:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tb_City
	{
		public Tb_City()
		{}
		#region Model
		private int _city_id;
		private string _city_namech;
		private string _city_nameen;
		/// <summary>
		/// 
		/// </summary>
		public int City_ID
		{
			set{ _city_id=value;}
			get{return _city_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string City_NameCH
		{
			set{ _city_namech=value;}
			get{return _city_namech;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string City_NameEN
		{
			set{ _city_nameen=value;}
			get{return _city_nameen;}
		}
		#endregion Model

	}
}

