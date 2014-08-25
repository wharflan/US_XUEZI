/**  版本信息模板在安装目录下，可自行修改。
* Tb_Special.cs
*
* 功 能： N/A
* 类 名： Tb_Special
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:13 AM   N/A    初版
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
	public partial class Tb_Special
	{
		public Tb_Special()
		{}
		#region Model
		private int _special_id;
		private string _special_name;
		private string _special_address;
		/// <summary>
		/// 
		/// </summary>
		public int Special_ID
		{
			set{ _special_id=value;}
			get{return _special_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Special_Name
		{
			set{ _special_name=value;}
			get{return _special_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Special_Address
		{
			set{ _special_address=value;}
			get{return _special_address;}
		}
		#endregion Model

	}
}

