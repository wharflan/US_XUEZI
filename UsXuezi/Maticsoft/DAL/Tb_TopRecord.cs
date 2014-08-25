/**  版本信息模板在安装目录下，可自行修改。
* Tb_TopRecord.cs
*
* 功 能： N/A
* 类 名： Tb_TopRecord
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
	/// 数据访问类:Tb_TopRecord
	/// </summary>
	public partial class Tb_TopRecord
	{
		public Tb_TopRecord()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Top_ID", "Tb_TopRecord"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Top_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_TopRecord");
			strSql.Append(" where Top_ID=@Top_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Top_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Top_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_TopRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_TopRecord(");
			strSql.Append("Top_PostID,Top_UserID,Top_Time)");
			strSql.Append(" values (");
			strSql.Append("@Top_PostID,@Top_UserID,@Top_Time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Top_PostID", SqlDbType.Int,4),
					new SqlParameter("@Top_UserID", SqlDbType.Int,4),
					new SqlParameter("@Top_Time", SqlDbType.DateTime)};
			parameters[0].Value = model.Top_PostID;
			parameters[1].Value = model.Top_UserID;
			parameters[2].Value = model.Top_Time;

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
		public bool Update(Maticsoft.Model.Tb_TopRecord model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_TopRecord set ");
			strSql.Append("Top_PostID=@Top_PostID,");
			strSql.Append("Top_UserID=@Top_UserID,");
			strSql.Append("Top_Time=@Top_Time");
			strSql.Append(" where Top_ID=@Top_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Top_PostID", SqlDbType.Int,4),
					new SqlParameter("@Top_UserID", SqlDbType.Int,4),
					new SqlParameter("@Top_Time", SqlDbType.DateTime),
					new SqlParameter("@Top_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Top_PostID;
			parameters[1].Value = model.Top_UserID;
			parameters[2].Value = model.Top_Time;
			parameters[3].Value = model.Top_ID;

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
		public bool Delete(int Top_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_TopRecord ");
			strSql.Append(" where Top_ID=@Top_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Top_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Top_ID;

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
		public bool DeleteList(string Top_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_TopRecord ");
			strSql.Append(" where Top_ID in ("+Top_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_TopRecord GetModel(int Top_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Top_ID,Top_PostID,Top_UserID,Top_Time from Tb_TopRecord ");
			strSql.Append(" where Top_ID=@Top_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Top_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Top_ID;

			Maticsoft.Model.Tb_TopRecord model=new Maticsoft.Model.Tb_TopRecord();
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
		public Maticsoft.Model.Tb_TopRecord DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_TopRecord model=new Maticsoft.Model.Tb_TopRecord();
			if (row != null)
			{
				if(row["Top_ID"]!=null && row["Top_ID"].ToString()!="")
				{
					model.Top_ID=int.Parse(row["Top_ID"].ToString());
				}
				if(row["Top_PostID"]!=null && row["Top_PostID"].ToString()!="")
				{
					model.Top_PostID=int.Parse(row["Top_PostID"].ToString());
				}
				if(row["Top_UserID"]!=null && row["Top_UserID"].ToString()!="")
				{
					model.Top_UserID=int.Parse(row["Top_UserID"].ToString());
				}
				if(row["Top_Time"]!=null && row["Top_Time"].ToString()!="")
				{
					model.Top_Time=DateTime.Parse(row["Top_Time"].ToString());
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
			strSql.Append("select Top_ID,Top_PostID,Top_UserID,Top_Time ");
			strSql.Append(" FROM Tb_TopRecord ");
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
			strSql.Append(" Top_ID,Top_PostID,Top_UserID,Top_Time ");
			strSql.Append(" FROM Tb_TopRecord ");
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
			strSql.Append("select count(1) FROM Tb_TopRecord ");
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
				strSql.Append("order by T.Top_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_TopRecord T ");
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
			parameters[0].Value = "Tb_TopRecord";
			parameters[1].Value = "Top_ID";
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

