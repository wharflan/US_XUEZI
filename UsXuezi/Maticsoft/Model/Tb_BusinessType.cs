/**  版本信息模板在安装目录下，可自行修改。
* Tb_BusinessType.cs
*
* 功 能： N/A
* 类 名： Tb_BusinessType
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
	/// Tb_BusinessType:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tb_BusinessType
	{
		public Tb_BusinessType()
		{}
		#region Model
		private int _bt_id;
		private string _bt_content;
		/// <summary>
		/// 
		/// </summary>
		public int BT_ID
		{
			set{ _bt_id=value;}
			get{return _bt_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BT_Content
		{
			set{ _bt_content=value;}
			get{return _bt_content;}
		}
		#endregion Model

	}
}

