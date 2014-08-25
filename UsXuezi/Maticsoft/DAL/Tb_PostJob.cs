/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostJob.cs
*
* 功 能： N/A
* 类 名： Tb_PostJob
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:10 AM   N/A    初版
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
	/// 数据访问类:Tb_PostJob
	/// </summary>
	public partial class Tb_PostJob
	{
		public Tb_PostJob()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Job_ID", "Tb_PostJob"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Job_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_PostJob");
			strSql.Append(" where Job_ID=@Job_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Job_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Job_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_PostJob model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_PostJob(");
			strSql.Append("Job_PostID,Job_Type,Job_Location,Job_IsFullTime,Job_IsPartTime,Job_IsContract,Job_IsPractice,Job_Price,Job_Experience,Job_Contact,Job_EndDate,Job_Logo,Job_Description)");
			strSql.Append(" values (");
			strSql.Append("@Job_PostID,@Job_Type,@Job_Location,@Job_IsFullTime,@Job_IsPartTime,@Job_IsContract,@Job_IsPractice,@Job_Price,@Job_Experience,@Job_Contact,@Job_EndDate,@Job_Logo,@Job_Description)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Job_PostID", SqlDbType.Int,4),
					new SqlParameter("@Job_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_Location", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_IsFullTime", SqlDbType.Int,4),
					new SqlParameter("@Job_IsPartTime", SqlDbType.Int,4),
					new SqlParameter("@Job_IsContract", SqlDbType.Int,4),
					new SqlParameter("@Job_IsPractice", SqlDbType.Int,4),
					new SqlParameter("@Job_Price", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_Experience", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_Contact", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_EndDate", SqlDbType.DateTime),
					new SqlParameter("@Job_Logo", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_Description", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.Job_PostID;
			parameters[1].Value = model.Job_Type;
			parameters[2].Value = model.Job_Location;
			parameters[3].Value = model.Job_IsFullTime;
			parameters[4].Value = model.Job_IsPartTime;
			parameters[5].Value = model.Job_IsContract;
			parameters[6].Value = model.Job_IsPractice;
			parameters[7].Value = model.Job_Price;
			parameters[8].Value = model.Job_Experience;
			parameters[9].Value = model.Job_Contact;
			parameters[10].Value = model.Job_EndDate;
			parameters[11].Value = model.Job_Logo;
			parameters[12].Value = model.Job_Description;

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
		public bool Update(Maticsoft.Model.Tb_PostJob model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_PostJob set ");
			strSql.Append("Job_PostID=@Job_PostID,");
			strSql.Append("Job_Type=@Job_Type,");
			strSql.Append("Job_Location=@Job_Location,");
			strSql.Append("Job_IsFullTime=@Job_IsFullTime,");
			strSql.Append("Job_IsPartTime=@Job_IsPartTime,");
			strSql.Append("Job_IsContract=@Job_IsContract,");
			strSql.Append("Job_IsPractice=@Job_IsPractice,");
			strSql.Append("Job_Price=@Job_Price,");
			strSql.Append("Job_Experience=@Job_Experience,");
			strSql.Append("Job_Contact=@Job_Contact,");
			strSql.Append("Job_EndDate=@Job_EndDate,");
			strSql.Append("Job_Logo=@Job_Logo,");
			strSql.Append("Job_Description=@Job_Description");
			strSql.Append(" where Job_ID=@Job_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Job_PostID", SqlDbType.Int,4),
					new SqlParameter("@Job_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_Location", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_IsFullTime", SqlDbType.Int,4),
					new SqlParameter("@Job_IsPartTime", SqlDbType.Int,4),
					new SqlParameter("@Job_IsContract", SqlDbType.Int,4),
					new SqlParameter("@Job_IsPractice", SqlDbType.Int,4),
					new SqlParameter("@Job_Price", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_Experience", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_Contact", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_EndDate", SqlDbType.DateTime),
					new SqlParameter("@Job_Logo", SqlDbType.NVarChar,50),
					new SqlParameter("@Job_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@Job_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Job_PostID;
			parameters[1].Value = model.Job_Type;
			parameters[2].Value = model.Job_Location;
			parameters[3].Value = model.Job_IsFullTime;
			parameters[4].Value = model.Job_IsPartTime;
			parameters[5].Value = model.Job_IsContract;
			parameters[6].Value = model.Job_IsPractice;
			parameters[7].Value = model.Job_Price;
			parameters[8].Value = model.Job_Experience;
			parameters[9].Value = model.Job_Contact;
			parameters[10].Value = model.Job_EndDate;
			parameters[11].Value = model.Job_Logo;
			parameters[12].Value = model.Job_Description;
			parameters[13].Value = model.Job_ID;

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
		public bool Delete(int Job_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostJob ");
			strSql.Append(" where Job_ID=@Job_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Job_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Job_ID;

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
		public bool DeleteList(string Job_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostJob ");
			strSql.Append(" where Job_ID in ("+Job_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_PostJob GetModel(int Job_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Job_ID,Job_PostID,Job_Type,Job_Location,Job_IsFullTime,Job_IsPartTime,Job_IsContract,Job_IsPractice,Job_Price,Job_Experience,Job_Contact,Job_EndDate,Job_Logo,Job_Description from Tb_PostJob ");
			strSql.Append(" where Job_ID=@Job_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Job_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Job_ID;

			Maticsoft.Model.Tb_PostJob model=new Maticsoft.Model.Tb_PostJob();
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
		public Maticsoft.Model.Tb_PostJob DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_PostJob model=new Maticsoft.Model.Tb_PostJob();
			if (row != null)
			{
				if(row["Job_ID"]!=null && row["Job_ID"].ToString()!="")
				{
					model.Job_ID=int.Parse(row["Job_ID"].ToString());
				}
				if(row["Job_PostID"]!=null && row["Job_PostID"].ToString()!="")
				{
					model.Job_PostID=int.Parse(row["Job_PostID"].ToString());
				}
				if(row["Job_Type"]!=null)
				{
					model.Job_Type=row["Job_Type"].ToString();
				}
				if(row["Job_Location"]!=null)
				{
					model.Job_Location=row["Job_Location"].ToString();
				}
				if(row["Job_IsFullTime"]!=null && row["Job_IsFullTime"].ToString()!="")
				{
					model.Job_IsFullTime=int.Parse(row["Job_IsFullTime"].ToString());
				}
				if(row["Job_IsPartTime"]!=null && row["Job_IsPartTime"].ToString()!="")
				{
					model.Job_IsPartTime=int.Parse(row["Job_IsPartTime"].ToString());
				}
				if(row["Job_IsContract"]!=null && row["Job_IsContract"].ToString()!="")
				{
					model.Job_IsContract=int.Parse(row["Job_IsContract"].ToString());
				}
				if(row["Job_IsPractice"]!=null && row["Job_IsPractice"].ToString()!="")
				{
					model.Job_IsPractice=int.Parse(row["Job_IsPractice"].ToString());
				}
				if(row["Job_Price"]!=null)
				{
					model.Job_Price=row["Job_Price"].ToString();
				}
				if(row["Job_Experience"]!=null)
				{
					model.Job_Experience=row["Job_Experience"].ToString();
				}
				if(row["Job_Contact"]!=null)
				{
					model.Job_Contact=row["Job_Contact"].ToString();
				}
				if(row["Job_EndDate"]!=null && row["Job_EndDate"].ToString()!="")
				{
					model.Job_EndDate=DateTime.Parse(row["Job_EndDate"].ToString());
				}
				if(row["Job_Logo"]!=null)
				{
					model.Job_Logo=row["Job_Logo"].ToString();
				}
				if(row["Job_Description"]!=null)
				{
					model.Job_Description=row["Job_Description"].ToString();
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
			strSql.Append("select Job_ID,Job_PostID,Job_Type,Job_Location,Job_IsFullTime,Job_IsPartTime,Job_IsContract,Job_IsPractice,Job_Price,Job_Experience,Job_Contact,Job_EndDate,Job_Logo,Job_Description ");
			strSql.Append(" FROM Tb_PostJob ");
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
			strSql.Append(" Job_ID,Job_PostID,Job_Type,Job_Location,Job_IsFullTime,Job_IsPartTime,Job_IsContract,Job_IsPractice,Job_Price,Job_Experience,Job_Contact,Job_EndDate,Job_Logo,Job_Description ");
			strSql.Append(" FROM Tb_PostJob ");
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
			strSql.Append("select count(1) FROM Tb_PostJob ");
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
				strSql.Append("order by T.Job_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_PostJob T ");
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
			parameters[0].Value = "Tb_PostJob";
			parameters[1].Value = "Job_ID";
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

