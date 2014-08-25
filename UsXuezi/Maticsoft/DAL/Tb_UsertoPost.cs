/**  版本信息模板在安装目录下，可自行修改。
* Tb_UsertoPost.cs
*
* 功 能： N/A
* 类 名： Tb_UsertoPost
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:15 AM   N/A    初版
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
	/// 数据访问类:Tb_UsertoPost
	/// </summary>
	public partial class Tb_UsertoPost
	{
		public Tb_UsertoPost()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Operation_ID", "Tb_UsertoPost"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Operation_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_UsertoPost");
			strSql.Append(" where Operation_ID=@Operation_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Operation_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Operation_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_UsertoPost model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_UsertoPost(");
			strSql.Append("Operation_UserID,Operation_PostID,Operation_Type,Operation_Time)");
			strSql.Append(" values (");
			strSql.Append("@Operation_UserID,@Operation_PostID,@Operation_Type,@Operation_Time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Operation_UserID", SqlDbType.Int,4),
					new SqlParameter("@Operation_PostID", SqlDbType.Int,4),
					new SqlParameter("@Operation_Type", SqlDbType.Int,4),
					new SqlParameter("@Operation_Time", SqlDbType.DateTime)};
			parameters[0].Value = model.Operation_UserID;
			parameters[1].Value = model.Operation_PostID;
			parameters[2].Value = model.Operation_Type;
			parameters[3].Value = model.Operation_Time;

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
		public bool Update(Maticsoft.Model.Tb_UsertoPost model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_UsertoPost set ");
			strSql.Append("Operation_UserID=@Operation_UserID,");
			strSql.Append("Operation_PostID=@Operation_PostID,");
			strSql.Append("Operation_Type=@Operation_Type,");
			strSql.Append("Operation_Time=@Operation_Time");
			strSql.Append(" where Operation_ID=@Operation_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Operation_UserID", SqlDbType.Int,4),
					new SqlParameter("@Operation_PostID", SqlDbType.Int,4),
					new SqlParameter("@Operation_Type", SqlDbType.Int,4),
					new SqlParameter("@Operation_Time", SqlDbType.DateTime),
					new SqlParameter("@Operation_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Operation_UserID;
			parameters[1].Value = model.Operation_PostID;
			parameters[2].Value = model.Operation_Type;
			parameters[3].Value = model.Operation_Time;
			parameters[4].Value = model.Operation_ID;

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
		public bool Delete(int Operation_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_UsertoPost ");
			strSql.Append(" where Operation_ID=@Operation_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Operation_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Operation_ID;

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
		public bool DeleteList(string Operation_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_UsertoPost ");
			strSql.Append(" where Operation_ID in ("+Operation_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_UsertoPost GetModel(int Operation_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Operation_ID,Operation_UserID,Operation_PostID,Operation_Type,Operation_Time from Tb_UsertoPost ");
			strSql.Append(" where Operation_ID=@Operation_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Operation_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Operation_ID;

			Maticsoft.Model.Tb_UsertoPost model=new Maticsoft.Model.Tb_UsertoPost();
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
		public Maticsoft.Model.Tb_UsertoPost DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_UsertoPost model=new Maticsoft.Model.Tb_UsertoPost();
			if (row != null)
			{
				if(row["Operation_ID"]!=null && row["Operation_ID"].ToString()!="")
				{
					model.Operation_ID=int.Parse(row["Operation_ID"].ToString());
				}
				if(row["Operation_UserID"]!=null && row["Operation_UserID"].ToString()!="")
				{
					model.Operation_UserID=int.Parse(row["Operation_UserID"].ToString());
				}
				if(row["Operation_PostID"]!=null && row["Operation_PostID"].ToString()!="")
				{
					model.Operation_PostID=int.Parse(row["Operation_PostID"].ToString());
				}
				if(row["Operation_Type"]!=null && row["Operation_Type"].ToString()!="")
				{
					model.Operation_Type=int.Parse(row["Operation_Type"].ToString());
				}
				if(row["Operation_Time"]!=null && row["Operation_Time"].ToString()!="")
				{
					model.Operation_Time=DateTime.Parse(row["Operation_Time"].ToString());
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
			strSql.Append("select Operation_ID,Operation_UserID,Operation_PostID,Operation_Type,Operation_Time ");
			strSql.Append(" FROM Tb_UsertoPost ");
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
			strSql.Append(" Operation_ID,Operation_UserID,Operation_PostID,Operation_Type,Operation_Time ");
			strSql.Append(" FROM Tb_UsertoPost ");
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
			strSql.Append("select count(1) FROM Tb_UsertoPost ");
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
				strSql.Append("order by T.Operation_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_UsertoPost T ");
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
			parameters[0].Value = "Tb_UsertoPost";
			parameters[1].Value = "Operation_ID";
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

