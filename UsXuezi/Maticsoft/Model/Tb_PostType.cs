/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostType.cs
*
* 功 能： N/A
* 类 名： Tb_PostType
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
	public partial class Tb_PostType
	{
		public Tb_PostType()
		{}
		#region Model
		private int _posttype_id;
		private string _posttype_nameen;
		private string _posttype_namecn;
		/// <summary>
		/// 
		/// </summary>
		public int PostType_ID
		{
			set{ _posttype_id=value;}
			get{return _posttype_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PostType_NameEN
		{
			set{ _posttype_nameen=value;}
			get{return _posttype_nameen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string PostType_NameCN
		{
			set{ _posttype_namecn=value;}
			get{return _posttype_namecn;}
		}
		#endregion Model

	}
}

