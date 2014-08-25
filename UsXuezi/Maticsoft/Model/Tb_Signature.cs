/**  版本信息模板在安装目录下，可自行修改。
* Tb_Signature.cs
*
* 功 能： N/A
* 类 名： Tb_Signature
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:12 AM   N/A    初版
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
	public partial class Tb_Signature
	{
		public Tb_Signature()
		{}
		#region Model
		private int _signature_id;
		private int? _signature_businessid;
		private string _signature_name;
		private string _signature_description;
		private string _signature_img;
		/// <summary>
		/// 
		/// </summary>
		public int Signature_ID
		{
			set{ _signature_id=value;}
			get{return _signature_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Signature_BusinessID
		{
			set{ _signature_businessid=value;}
			get{return _signature_businessid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Signature_Name
		{
			set{ _signature_name=value;}
			get{return _signature_name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Signature_Description
		{
			set{ _signature_description=value;}
			get{return _signature_description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Signature_Img
		{
			set{ _signature_img=value;}
			get{return _signature_img;}
		}
		#endregion Model

	}
}

