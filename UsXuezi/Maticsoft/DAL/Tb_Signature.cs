﻿/**  版本信息模板在安装目录下，可自行修改。
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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Tb_Signature
	/// </summary>
	public partial class Tb_Signature
	{
		public Tb_Signature()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Signature_ID", "Tb_Signature"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Signature_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_Signature");
			strSql.Append(" where Signature_ID=@Signature_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Signature_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Signature_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_Signature model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_Signature(");
			strSql.Append("Signature_BusinessID,Signature_Name,Signature_Description,Signature_Img)");
			strSql.Append(" values (");
			strSql.Append("@Signature_BusinessID,@Signature_Name,@Signature_Description,@Signature_Img)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Signature_BusinessID", SqlDbType.Int,4),
					new SqlParameter("@Signature_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Signature_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@Signature_Img", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.Signature_BusinessID;
			parameters[1].Value = model.Signature_Name;
			parameters[2].Value = model.Signature_Description;
			parameters[3].Value = model.Signature_Img;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Tb_Signature model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_Signature set ");
			strSql.Append("Signature_BusinessID=@Signature_BusinessID,");
			strSql.Append("Signature_Name=@Signature_Name,");
			strSql.Append("Signature_Description=@Signature_Description,");
			strSql.Append("Signature_Img=@Signature_Img");
			strSql.Append(" where Signature_ID=@Signature_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Signature_BusinessID", SqlDbType.Int,4),
					new SqlParameter("@Signature_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Signature_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@Signature_Img", SqlDbType.NVarChar,-1),
					new SqlParameter("@Signature_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Signature_BusinessID;
			parameters[1].Value = model.Signature_Name;
			parameters[2].Value = model.Signature_Description;
			parameters[3].Value = model.Signature_Img;
			parameters[4].Value = model.Signature_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Signature_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Signature ");
			strSql.Append(" where Signature_ID=@Signature_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Signature_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Signature_ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string Signature_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Signature ");
			strSql.Append(" where Signature_ID in ("+Signature_IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Tb_Signature GetModel(int Signature_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Signature_ID,Signature_BusinessID,Signature_Name,Signature_Description,Signature_Img from Tb_Signature ");
			strSql.Append(" where Signature_ID=@Signature_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Signature_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Signature_ID;

			Maticsoft.Model.Tb_Signature model=new Maticsoft.Model.Tb_Signature();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Maticsoft.Model.Tb_Signature DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_Signature model=new Maticsoft.Model.Tb_Signature();
			if (row != null)
			{
				if(row["Signature_ID"]!=null && row["Signature_ID"].ToString()!="")
				{
					model.Signature_ID=int.Parse(row["Signature_ID"].ToString());
				}
				if(row["Signature_BusinessID"]!=null && row["Signature_BusinessID"].ToString()!="")
				{
					model.Signature_BusinessID=int.Parse(row["Signature_BusinessID"].ToString());
				}
				if(row["Signature_Name"]!=null)
				{
					model.Signature_Name=row["Signature_Name"].ToString();
				}
				if(row["Signature_Description"]!=null)
				{
					model.Signature_Description=row["Signature_Description"].ToString();
				}
				if(row["Signature_Img"]!=null)
				{
					model.Signature_Img=row["Signature_Img"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Signature_ID,Signature_BusinessID,Signature_Name,Signature_Description,Signature_Img ");
			strSql.Append(" FROM Tb_Signature ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" Signature_ID,Signature_BusinessID,Signature_Name,Signature_Description,Signature_Img ");
			strSql.Append(" FROM Tb_Signature ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM Tb_Signature ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Signature_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_Signature T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "Tb_Signature";
			parameters[1].Value = "Signature_ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

