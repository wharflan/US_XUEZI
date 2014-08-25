/**  版本信息模板在安装目录下，可自行修改。
* Tb_Tag.cs
*
* 功 能： N/A
* 类 名： Tb_Tag
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
	public partial class Tb_Tag
	{
		public Tb_Tag()
		{}
		#region Model
		private int _tag_id;
		private int? _tag_postid;
		private string _tag_content;
		/// <summary>
		/// 
		/// </summary>
		public int Tag_ID
		{
			set{ _tag_id=value;}
			get{return _tag_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Tag_PostID
		{
			set{ _tag_postid=value;}
			get{return _tag_postid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Tag_Content
		{
			set{ _tag_content=value;}
			get{return _tag_content;}
		}
		#endregion Model

	}
}

