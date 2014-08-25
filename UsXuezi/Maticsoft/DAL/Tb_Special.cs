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
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Maticsoft.DAL
{
	/// <summary>
	/// 数据访问类:Tb_Special
	/// </summary>
	public partial class Tb_Special
	{
		public Tb_Special()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Special_ID", "Tb_Special"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Special_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_Special");
			strSql.Append(" where Special_ID=@Special_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Special_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Special_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Tb_Special model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_Special(");
			strSql.Append("Special_ID,Special_Name,Special_Address)");
			strSql.Append(" values (");
			strSql.Append("@Special_ID,@Special_Name,@Special_Address)");
			SqlParameter[] parameters = {
					new SqlParameter("@Special_ID", SqlDbType.Int,4),
					new SqlParameter("@Special_Name", SqlDbType.NVarChar,-1),
					new SqlParameter("@Special_Address", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.Special_ID;
			parameters[1].Value = model.Special_Name;
			parameters[2].Value = model.Special_Address;

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
		public bool Update(Maticsoft.Model.Tb_Special model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_Special set ");
			strSql.Append("Special_Name=@Special_Name,");
			strSql.Append("Special_Address=@Special_Address");
			strSql.Append(" where Special_ID=@Special_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Special_Name", SqlDbType.NVarChar,-1),
					new SqlParameter("@Special_Address", SqlDbType.NVarChar,-1),
					new SqlParameter("@Special_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Special_Name;
			parameters[1].Value = model.Special_Address;
			parameters[2].Value = model.Special_ID;

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
		public bool Delete(int Special_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Special ");
			strSql.Append(" where Special_ID=@Special_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Special_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Special_ID;

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
		public bool DeleteList(string Special_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Special ");
			strSql.Append(" where Special_ID in ("+Special_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_Special GetModel(int Special_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Special_ID,Special_Name,Special_Address from Tb_Special ");
			strSql.Append(" where Special_ID=@Special_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Special_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Special_ID;

			Maticsoft.Model.Tb_Special model=new Maticsoft.Model.Tb_Special();
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
		public Maticsoft.Model.Tb_Special DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_Special model=new Maticsoft.Model.Tb_Special();
			if (row != null)
			{
				if(row["Special_ID"]!=null && row["Special_ID"].ToString()!="")
				{
					model.Special_ID=int.Parse(row["Special_ID"].ToString());
				}
				if(row["Special_Name"]!=null)
				{
					model.Special_Name=row["Special_Name"].ToString();
				}
				if(row["Special_Address"]!=null)
				{
					model.Special_Address=row["Special_Address"].ToString();
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
			strSql.Append("select Special_ID,Special_Name,Special_Address ");
			strSql.Append(" FROM Tb_Special ");
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
			strSql.Append(" Special_ID,Special_Name,Special_Address ");
			strSql.Append(" FROM Tb_Special ");
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
			strSql.Append("select count(1) FROM Tb_Special ");
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
				strSql.Append("order by T.Special_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_Special T ");
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
			parameters[0].Value = "Tb_Special";
			parameters[1].Value = "Special_ID";
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

