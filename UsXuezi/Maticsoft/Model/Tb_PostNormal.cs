/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostNormal.cs
*
* 功 能： N/A
* 类 名： Tb_PostNormal
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:10 AM   N/A    初版
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
	public partial class Tb_PostNormal
	{
		public Tb_PostNormal()
		{}
		#region Model
		private int _post_id;
		private string _post_content;
		/// <summary>
		/// 
		/// </summary>
		public int Post_ID
		{
			set{ _post_id=value;}
			get{return _post_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Post_Content
		{
			set{ _post_content=value;}
			get{return _post_content;}
		}
		#endregion Model

	}
}

