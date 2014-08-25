/**  版本信息模板在安装目录下，可自行修改。
* Tb_BusinessGrade.cs
*
* 功 能： N/A
* 类 名： Tb_BusinessGrade
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
	/// Tb_BusinessGrade:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Tb_BusinessGrade
	{
		public Tb_BusinessGrade()
		{}
		#region Model
		private int _businessgrade_id;
		private int? _businessgrade_postid;
		private int? _businessgrade_userid;
		private int? _businessgrade_grade;
		private DateTime? _businessgrade_date= DateTime.Now;
		/// <summary>
		/// 
		/// </summary>
		public int BusinessGrade_ID
		{
			set{ _businessgrade_id=value;}
			get{return _businessgrade_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BusinessGrade_PostID
		{
			set{ _businessgrade_postid=value;}
			get{return _businessgrade_postid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BusinessGrade_UserID
		{
			set{ _businessgrade_userid=value;}
			get{return _businessgrade_userid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? BusinessGrade_Grade
		{
			set{ _businessgrade_grade=value;}
			get{return _businessgrade_grade;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Businessgrade_Date
		{
			set{ _businessgrade_date=value;}
			get{return _businessgrade_date;}
		}
		#endregion Model

	}
}

