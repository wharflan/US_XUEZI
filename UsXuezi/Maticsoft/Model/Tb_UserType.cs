/**  版本信息模板在安装目录下，可自行修改。
* Tb_UserType.cs
*
* 功 能： N/A
* 类 名： Tb_UserType
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:16 AM   N/A    初版
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
	/// 1. 关注
	///2. 收藏
	///3. 点赞
	/// </summary>
	[Serializable]
	public partial class Tb_UserType
	{
		public Tb_UserType()
		{}
		#region Model
		private int _usertype_id;
		private string _usertype_nameen;
		private string _usertype_namecn;
		/// <summary>
		/// 
		/// </summary>
		public int UserType_ID
		{
			set{ _usertype_id=value;}
			get{return _usertype_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserType_NameEN
		{
			set{ _usertype_nameen=value;}
			get{return _usertype_nameen;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UserType_NameCN
		{
			set{ _usertype_namecn=value;}
			get{return _usertype_namecn;}
		}
		#endregion Model

	}
}

