/**  版本信息模板在安装目录下，可自行修改。
* Tb_Mail.cs
*
* 功 能： N/A
* 类 名： Tb_Mail
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:08 AM   N/A    初版
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
	/// 数据访问类:Tb_Mail
	/// </summary>
	public partial class Tb_Mail
	{
		public Tb_Mail()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Mail_ID", "Tb_Mail"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Mail_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_Mail");
			strSql.Append(" where Mail_ID=@Mail_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Mail_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Mail_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_Mail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_Mail(");
			strSql.Append("Mail_PosterID,Mail_RecieverID,Mail_Status,Mail_Content,Mail_Time)");
			strSql.Append(" values (");
			strSql.Append("@Mail_PosterID,@Mail_RecieverID,@Mail_Status,@Mail_Content,@Mail_Time)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Mail_PosterID", SqlDbType.Int,4),
					new SqlParameter("@Mail_RecieverID", SqlDbType.Int,4),
					new SqlParameter("@Mail_Status", SqlDbType.Int,4),
					new SqlParameter("@Mail_Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@Mail_Time", SqlDbType.DateTime)};
			parameters[0].Value = model.Mail_PosterID;
			parameters[1].Value = model.Mail_RecieverID;
			parameters[2].Value = model.Mail_Status;
			parameters[3].Value = model.Mail_Content;
			parameters[4].Value = model.Mail_Time;

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
		public bool Update(Maticsoft.Model.Tb_Mail model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_Mail set ");
			strSql.Append("Mail_PosterID=@Mail_PosterID,");
			strSql.Append("Mail_RecieverID=@Mail_RecieverID,");
			strSql.Append("Mail_Status=@Mail_Status,");
			strSql.Append("Mail_Content=@Mail_Content,");
			strSql.Append("Mail_Time=@Mail_Time");
			strSql.Append(" where Mail_ID=@Mail_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Mail_PosterID", SqlDbType.Int,4),
					new SqlParameter("@Mail_RecieverID", SqlDbType.Int,4),
					new SqlParameter("@Mail_Status", SqlDbType.Int,4),
					new SqlParameter("@Mail_Content", SqlDbType.NVarChar,-1),
					new SqlParameter("@Mail_Time", SqlDbType.DateTime),
					new SqlParameter("@Mail_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Mail_PosterID;
			parameters[1].Value = model.Mail_RecieverID;
			parameters[2].Value = model.Mail_Status;
			parameters[3].Value = model.Mail_Content;
			parameters[4].Value = model.Mail_Time;
			parameters[5].Value = model.Mail_ID;

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
		public bool Delete(int Mail_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Mail ");
			strSql.Append(" where Mail_ID=@Mail_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Mail_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Mail_ID;

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
		public bool DeleteList(string Mail_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Mail ");
			strSql.Append(" where Mail_ID in ("+Mail_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_Mail GetModel(int Mail_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Mail_ID,Mail_PosterID,Mail_RecieverID,Mail_Status,Mail_Content,Mail_Time from Tb_Mail ");
			strSql.Append(" where Mail_ID=@Mail_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Mail_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Mail_ID;

			Maticsoft.Model.Tb_Mail model=new Maticsoft.Model.Tb_Mail();
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
		public Maticsoft.Model.Tb_Mail DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_Mail model=new Maticsoft.Model.Tb_Mail();
			if (row != null)
			{
				if(row["Mail_ID"]!=null && row["Mail_ID"].ToString()!="")
				{
					model.Mail_ID=int.Parse(row["Mail_ID"].ToString());
				}
				if(row["Mail_PosterID"]!=null && row["Mail_PosterID"].ToString()!="")
				{
					model.Mail_PosterID=int.Parse(row["Mail_PosterID"].ToString());
				}
				if(row["Mail_RecieverID"]!=null && row["Mail_RecieverID"].ToString()!="")
				{
					model.Mail_RecieverID=int.Parse(row["Mail_RecieverID"].ToString());
				}
				if(row["Mail_Status"]!=null && row["Mail_Status"].ToString()!="")
				{
					model.Mail_Status=int.Parse(row["Mail_Status"].ToString());
				}
				if(row["Mail_Content"]!=null)
				{
					model.Mail_Content=row["Mail_Content"].ToString();
				}
				if(row["Mail_Time"]!=null && row["Mail_Time"].ToString()!="")
				{
					model.Mail_Time=DateTime.Parse(row["Mail_Time"].ToString());
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
			strSql.Append("select Mail_ID,Mail_PosterID,Mail_RecieverID,Mail_Status,Mail_Content,Mail_Time ");
			strSql.Append(" FROM Tb_Mail ");
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
			strSql.Append(" Mail_ID,Mail_PosterID,Mail_RecieverID,Mail_Status,Mail_Content,Mail_Time ");
			strSql.Append(" FROM Tb_Mail ");
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
			strSql.Append("select count(1) FROM Tb_Mail ");
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
				strSql.Append("order by T.Mail_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_Mail T ");
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
			parameters[0].Value = "Tb_Mail";
			parameters[1].Value = "Mail_ID";
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

