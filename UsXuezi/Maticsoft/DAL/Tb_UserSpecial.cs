/**  版本信息模板在安装目录下，可自行修改。
* Tb_UserSpecial.cs
*
* 功 能： N/A
* 类 名： Tb_UserSpecial
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:14 AM   N/A    初版
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
	/// 数据访问类:Tb_UserSpecial
	/// </summary>
	public partial class Tb_UserSpecial
	{
		public Tb_UserSpecial()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("User_ID", "Tb_UserSpecial"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int User_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_UserSpecial");
			strSql.Append(" where User_ID=@User_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@User_ID", SqlDbType.Int,4)			};
			parameters[0].Value = User_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Tb_UserSpecial model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_UserSpecial(");
			strSql.Append("User_ID,User_CompanyNameCH,User_CompanyNameEN,User_CompanyAddress,User_CompanyStatus)");
			strSql.Append(" values (");
			strSql.Append("@User_ID,@User_CompanyNameCH,@User_CompanyNameEN,@User_CompanyAddress,@User_CompanyStatus)");
			SqlParameter[] parameters = {
					new SqlParameter("@User_ID", SqlDbType.Int,4),
					new SqlParameter("@User_CompanyNameCH", SqlDbType.NVarChar,50),
					new SqlParameter("@User_CompanyNameEN", SqlDbType.NVarChar,50),
					new SqlParameter("@User_CompanyAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@User_CompanyStatus", SqlDbType.Int,4)};
			parameters[0].Value = model.User_ID;
			parameters[1].Value = model.User_CompanyNameCH;
			parameters[2].Value = model.User_CompanyNameEN;
			parameters[3].Value = model.User_CompanyAddress;
			parameters[4].Value = model.User_CompanyStatus;

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
		/// 更新一条数据
		/// </summary>
		public bool Update(Maticsoft.Model.Tb_UserSpecial model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_UserSpecial set ");
			strSql.Append("User_CompanyNameCH=@User_CompanyNameCH,");
			strSql.Append("User_CompanyNameEN=@User_CompanyNameEN,");
			strSql.Append("User_CompanyAddress=@User_CompanyAddress,");
			strSql.Append("User_CompanyStatus=@User_CompanyStatus");
			strSql.Append(" where User_ID=@User_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@User_CompanyNameCH", SqlDbType.NVarChar,50),
					new SqlParameter("@User_CompanyNameEN", SqlDbType.NVarChar,50),
					new SqlParameter("@User_CompanyAddress", SqlDbType.NVarChar,50),
					new SqlParameter("@User_CompanyStatus", SqlDbType.Int,4),
					new SqlParameter("@User_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.User_CompanyNameCH;
			parameters[1].Value = model.User_CompanyNameEN;
			parameters[2].Value = model.User_CompanyAddress;
			parameters[3].Value = model.User_CompanyStatus;
			parameters[4].Value = model.User_ID;

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
		public bool Delete(int User_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_UserSpecial ");
			strSql.Append(" where User_ID=@User_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@User_ID", SqlDbType.Int,4)			};
			parameters[0].Value = User_ID;

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
		public bool DeleteList(string User_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_UserSpecial ");
			strSql.Append(" where User_ID in ("+User_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_UserSpecial GetModel(int User_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 User_ID,User_CompanyNameCH,User_CompanyNameEN,User_CompanyAddress,User_CompanyStatus from Tb_UserSpecial ");
			strSql.Append(" where User_ID=@User_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@User_ID", SqlDbType.Int,4)			};
			parameters[0].Value = User_ID;

			Maticsoft.Model.Tb_UserSpecial model=new Maticsoft.Model.Tb_UserSpecial();
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
		public Maticsoft.Model.Tb_UserSpecial DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_UserSpecial model=new Maticsoft.Model.Tb_UserSpecial();
			if (row != null)
			{
				if(row["User_ID"]!=null && row["User_ID"].ToString()!="")
				{
					model.User_ID=int.Parse(row["User_ID"].ToString());
				}
				if(row["User_CompanyNameCH"]!=null)
				{
					model.User_CompanyNameCH=row["User_CompanyNameCH"].ToString();
				}
				if(row["User_CompanyNameEN"]!=null)
				{
					model.User_CompanyNameEN=row["User_CompanyNameEN"].ToString();
				}
				if(row["User_CompanyAddress"]!=null)
				{
					model.User_CompanyAddress=row["User_CompanyAddress"].ToString();
				}
				if(row["User_CompanyStatus"]!=null && row["User_CompanyStatus"].ToString()!="")
				{
					model.User_CompanyStatus=int.Parse(row["User_CompanyStatus"].ToString());
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
			strSql.Append("select User_ID,User_CompanyNameCH,User_CompanyNameEN,User_CompanyAddress,User_CompanyStatus ");
			strSql.Append(" FROM Tb_UserSpecial ");
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
			strSql.Append(" User_ID,User_CompanyNameCH,User_CompanyNameEN,User_CompanyAddress,User_CompanyStatus ");
			strSql.Append(" FROM Tb_UserSpecial ");
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
			strSql.Append("select count(1) FROM Tb_UserSpecial ");
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
				strSql.Append("order by T.User_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_UserSpecial T ");
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
			parameters[0].Value = "Tb_UserSpecial";
			parameters[1].Value = "User_ID";
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

