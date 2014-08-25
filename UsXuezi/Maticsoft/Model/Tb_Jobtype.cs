/**  版本信息模板在安装目录下，可自行修改。
* Tb_Jobtype.cs
*
* 功 能： N/A
* 类 名： Tb_Jobtype
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:08 AM   N/A    初版
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
	public partial class Tb_Jobtype
	{
		public Tb_Jobtype()
		{}
		#region Model
		private int _jobtype_id;
		private string _jobtype_name;
		/// <summary>
		/// 
		/// </summary>
		public int JobType_ID
		{
			set{ _jobtype_id=value;}
			get{return _jobtype_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string JobType_Name
		{
			set{ _jobtype_name=value;}
			get{return _jobtype_name;}
		}
		#endregion Model

	}
}

