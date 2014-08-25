/**  版本信息模板在安装目录下，可自行修改。
* Tb_Reply.cs
*
* 功 能： N/A
* 类 名： Tb_Reply
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
	/// 数据访问类:Tb_Reply
	/// </summary>
	public partial class Tb_Reply
	{
		public Tb_Reply()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Reply_ID", "Tb_Reply"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Reply_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_Reply");
			strSql.Append(" where Reply_ID=@Reply_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Reply_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Reply_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_Reply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_Reply(");
			strSql.Append("Reply_PostID,Reply_UserID,Reply_RepliedUserID,Reply_Status,Reply_Time,Reply_Content)");
			strSql.Append(" values (");
			strSql.Append("@Reply_PostID,@Reply_UserID,@Reply_RepliedUserID,@Reply_Status,@Reply_Time,@Reply_Content)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Reply_PostID", SqlDbType.Int,4),
					new SqlParameter("@Reply_UserID", SqlDbType.Int,4),
					new SqlParameter("@Reply_RepliedUserID", SqlDbType.Int,4),
					new SqlParameter("@Reply_Status", SqlDbType.Int,4),
					new SqlParameter("@Reply_Time", SqlDbType.DateTime),
					new SqlParameter("@Reply_Content", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.Reply_PostID;
			parameters[1].Value = model.Reply_UserID;
			parameters[2].Value = model.Reply_RepliedUserID;
			parameters[3].Value = model.Reply_Status;
			parameters[4].Value = model.Reply_Time;
			parameters[5].Value = model.Reply_Content;

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
		public bool Update(Maticsoft.Model.Tb_Reply model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_Reply set ");
			strSql.Append("Reply_PostID=@Reply_PostID,");
			strSql.Append("Reply_UserID=@Reply_UserID,");
			strSql.Append("Reply_RepliedUserID=@Reply_RepliedUserID,");
			strSql.Append("Reply_Status=@Reply_Status,");
			strSql.Append("Reply_Time=@Reply_Time,");
			strSql.Append("Reply_Content=@Reply_Content");
			strSql.Append(" where Reply_ID=@Reply_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Reply_PostID", SqlDbType.Int,4),
					new SqlParameter("@Reply_UserID", SqlDbType.Int,4),
					new SqlParameter("@Reply_RepliedUserID", SqlDbType.Int,4),
					new SqlParameter("@Reply_Status", SqlDbType.Int,4),
					new SqlParameter("@Reply_Time", SqlDbType.DateTime),
					new SqlParameter("@Reply_Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@Reply_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Reply_PostID;
			parameters[1].Value = model.Reply_UserID;
			parameters[2].Value = model.Reply_RepliedUserID;
			parameters[3].Value = model.Reply_Status;
			parameters[4].Value = model.Reply_Time;
			parameters[5].Value = model.Reply_Content;
			parameters[6].Value = model.Reply_ID;

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
		public bool Delete(int Reply_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Reply ");
			strSql.Append(" where Reply_ID=@Reply_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Reply_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Reply_ID;

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
		public bool DeleteList(string Reply_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Reply ");
			strSql.Append(" where Reply_ID in ("+Reply_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_Reply GetModel(int Reply_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Reply_ID,Reply_PostID,Reply_UserID,Reply_RepliedUserID,Reply_Status,Reply_Time,Reply_Content from Tb_Reply ");
			strSql.Append(" where Reply_ID=@Reply_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Reply_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Reply_ID;

			Maticsoft.Model.Tb_Reply model=new Maticsoft.Model.Tb_Reply();
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
		public Maticsoft.Model.Tb_Reply DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_Reply model=new Maticsoft.Model.Tb_Reply();
			if (row != null)
			{
				if(row["Reply_ID"]!=null && row["Reply_ID"].ToString()!="")
				{
					model.Reply_ID=int.Parse(row["Reply_ID"].ToString());
				}
				if(row["Reply_PostID"]!=null && row["Reply_PostID"].ToString()!="")
				{
					model.Reply_PostID=int.Parse(row["Reply_PostID"].ToString());
				}
				if(row["Reply_UserID"]!=null && row["Reply_UserID"].ToString()!="")
				{
					model.Reply_UserID=int.Parse(row["Reply_UserID"].ToString());
				}
				if(row["Reply_RepliedUserID"]!=null && row["Reply_RepliedUserID"].ToString()!="")
				{
					model.Reply_RepliedUserID=int.Parse(row["Reply_RepliedUserID"].ToString());
				}
				if(row["Reply_Status"]!=null && row["Reply_Status"].ToString()!="")
				{
					model.Reply_Status=int.Parse(row["Reply_Status"].ToString());
				}
				if(row["Reply_Time"]!=null && row["Reply_Time"].ToString()!="")
				{
					model.Reply_Time=DateTime.Parse(row["Reply_Time"].ToString());
				}
				if(row["Reply_Content"]!=null)
				{
					model.Reply_Content=row["Reply_Content"].ToString();
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
			strSql.Append("select Reply_ID,Reply_PostID,Reply_UserID,Reply_RepliedUserID,Reply_Status,Reply_Time,Reply_Content ");
			strSql.Append(" FROM Tb_Reply ");
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
			strSql.Append(" Reply_ID,Reply_PostID,Reply_UserID,Reply_RepliedUserID,Reply_Status,Reply_Time,Reply_Content ");
			strSql.Append(" FROM Tb_Reply ");
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
			strSql.Append("select count(1) FROM Tb_Reply ");
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
				strSql.Append("order by T.Reply_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_Reply T ");
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
			parameters[0].Value = "Tb_Reply";
			parameters[1].Value = "Reply_ID";
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

