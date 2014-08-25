/**  版本信息模板在安装目录下，可自行修改。
* Tb_User.cs
*
* 功 能： N/A
* 类 名： Tb_User
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  8/5/2014 3:07:29 AM   N/A    初版
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
	/// 数据访问类:Tb_User
	/// </summary>
	public partial class Tb_User
	{
		public Tb_User()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("User_ID", "Tb_User"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int User_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_User");
			strSql.Append(" where User_ID=@User_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@User_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = User_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_User(");
			strSql.Append("User_Email,User_UserName,User_Password,User_Type,User_Status,User_CityID,User_Points,User_Sex,User_Birth,User_Phone,User_QQ,User_Wechat,User_Weibo,User_UsingEmail,User_Major,User_School,User_Description,User_RegisterDate,User_LastOnline)");
			strSql.Append(" values (");
			strSql.Append("@User_Email,@User_UserName,@User_Password,@User_Type,@User_Status,@User_CityID,@User_Points,@User_Sex,@User_Birth,@User_Phone,@User_QQ,@User_Wechat,@User_Weibo,@User_UsingEmail,@User_Major,@User_School,@User_Description,@User_RegisterDate,@User_LastOnline)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@User_Email", SqlDbType.NVarChar,50),
					new SqlParameter("@User_UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Password", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Type", SqlDbType.Int,4),
					new SqlParameter("@User_Status", SqlDbType.Int,4),
					new SqlParameter("@User_CityID", SqlDbType.Int,4),
					new SqlParameter("@User_Points", SqlDbType.Int,4),
					new SqlParameter("@User_Sex", SqlDbType.Int,4),
					new SqlParameter("@User_Birth", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@User_QQ", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Wechat", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Weibo", SqlDbType.NVarChar,50),
					new SqlParameter("@User_UsingEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Major", SqlDbType.NVarChar,50),
					new SqlParameter("@User_School", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@User_RegisterDate", SqlDbType.DateTime),
					new SqlParameter("@User_LastOnline", SqlDbType.DateTime)};
			parameters[0].Value = model.User_Email;
			parameters[1].Value = model.User_UserName;
			parameters[2].Value = model.User_Password;
			parameters[3].Value = model.User_Type;
			parameters[4].Value = model.User_Status;
			parameters[5].Value = model.User_CityID;
			parameters[6].Value = model.User_Points;
			parameters[7].Value = model.User_Sex;
			parameters[8].Value = model.User_Birth;
			parameters[9].Value = model.User_Phone;
			parameters[10].Value = model.User_QQ;
			parameters[11].Value = model.User_Wechat;
			parameters[12].Value = model.User_Weibo;
			parameters[13].Value = model.User_UsingEmail;
			parameters[14].Value = model.User_Major;
			parameters[15].Value = model.User_School;
			parameters[16].Value = model.User_Description;
			parameters[17].Value = model.User_RegisterDate;
			parameters[18].Value = model.User_LastOnline;

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
		public bool Update(Maticsoft.Model.Tb_User model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_User set ");
			strSql.Append("User_Email=@User_Email,");
			strSql.Append("User_UserName=@User_UserName,");
			strSql.Append("User_Password=@User_Password,");
			strSql.Append("User_Type=@User_Type,");
			strSql.Append("User_Status=@User_Status,");
			strSql.Append("User_CityID=@User_CityID,");
			strSql.Append("User_Points=@User_Points,");
			strSql.Append("User_Sex=@User_Sex,");
			strSql.Append("User_Birth=@User_Birth,");
			strSql.Append("User_Phone=@User_Phone,");
			strSql.Append("User_QQ=@User_QQ,");
			strSql.Append("User_Wechat=@User_Wechat,");
			strSql.Append("User_Weibo=@User_Weibo,");
			strSql.Append("User_UsingEmail=@User_UsingEmail,");
			strSql.Append("User_Major=@User_Major,");
			strSql.Append("User_School=@User_School,");
			strSql.Append("User_Description=@User_Description,");
			strSql.Append("User_RegisterDate=@User_RegisterDate,");
			strSql.Append("User_LastOnline=@User_LastOnline");
			strSql.Append(" where User_ID=@User_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@User_Email", SqlDbType.NVarChar,50),
					new SqlParameter("@User_UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Password", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Type", SqlDbType.Int,4),
					new SqlParameter("@User_Status", SqlDbType.Int,4),
					new SqlParameter("@User_CityID", SqlDbType.Int,4),
					new SqlParameter("@User_Points", SqlDbType.Int,4),
					new SqlParameter("@User_Sex", SqlDbType.Int,4),
					new SqlParameter("@User_Birth", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@User_QQ", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Wechat", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Weibo", SqlDbType.NVarChar,50),
					new SqlParameter("@User_UsingEmail", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Major", SqlDbType.NVarChar,50),
					new SqlParameter("@User_School", SqlDbType.NVarChar,50),
					new SqlParameter("@User_Description", SqlDbType.NVarChar,50),
					new SqlParameter("@User_RegisterDate", SqlDbType.DateTime),
					new SqlParameter("@User_LastOnline", SqlDbType.DateTime),
					new SqlParameter("@User_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.User_Email;
			parameters[1].Value = model.User_UserName;
			parameters[2].Value = model.User_Password;
			parameters[3].Value = model.User_Type;
			parameters[4].Value = model.User_Status;
			parameters[5].Value = model.User_CityID;
			parameters[6].Value = model.User_Points;
			parameters[7].Value = model.User_Sex;
			parameters[8].Value = model.User_Birth;
			parameters[9].Value = model.User_Phone;
			parameters[10].Value = model.User_QQ;
			parameters[11].Value = model.User_Wechat;
			parameters[12].Value = model.User_Weibo;
			parameters[13].Value = model.User_UsingEmail;
			parameters[14].Value = model.User_Major;
			parameters[15].Value = model.User_School;
			parameters[16].Value = model.User_Description;
			parameters[17].Value = model.User_RegisterDate;
			parameters[18].Value = model.User_LastOnline;
			parameters[19].Value = model.User_ID;

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
			strSql.Append("delete from Tb_User ");
			strSql.Append(" where User_ID=@User_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@User_ID", SqlDbType.Int,4)
			};
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
			strSql.Append("delete from Tb_User ");
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
		public Maticsoft.Model.Tb_User GetModel(int User_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 User_ID,User_Email,User_UserName,User_Password,User_Type,User_Status,User_CityID,User_Points,User_Sex,User_Birth,User_Phone,User_QQ,User_Wechat,User_Weibo,User_UsingEmail,User_Major,User_School,User_Description,User_RegisterDate,User_LastOnline from Tb_User ");
			strSql.Append(" where User_ID=@User_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@User_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = User_ID;

			Maticsoft.Model.Tb_User model=new Maticsoft.Model.Tb_User();
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
		public Maticsoft.Model.Tb_User DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_User model=new Maticsoft.Model.Tb_User();
			if (row != null)
			{
				if(row["User_ID"]!=null && row["User_ID"].ToString()!="")
				{
					model.User_ID=int.Parse(row["User_ID"].ToString());
				}
				if(row["User_Email"]!=null)
				{
					model.User_Email=row["User_Email"].ToString();
				}
				if(row["User_UserName"]!=null)
				{
					model.User_UserName=row["User_UserName"].ToString();
				}
				if(row["User_Password"]!=null)
				{
					model.User_Password=row["User_Password"].ToString();
				}
				if(row["User_Type"]!=null && row["User_Type"].ToString()!="")
				{
					model.User_Type=int.Parse(row["User_Type"].ToString());
				}
				if(row["User_Status"]!=null && row["User_Status"].ToString()!="")
				{
					model.User_Status=int.Parse(row["User_Status"].ToString());
				}
				if(row["User_CityID"]!=null && row["User_CityID"].ToString()!="")
				{
					model.User_CityID=int.Parse(row["User_CityID"].ToString());
				}
				if(row["User_Points"]!=null && row["User_Points"].ToString()!="")
				{
					model.User_Points=int.Parse(row["User_Points"].ToString());
				}
				if(row["User_Sex"]!=null && row["User_Sex"].ToString()!="")
				{
					model.User_Sex=int.Parse(row["User_Sex"].ToString());
				}
				if(row["User_Birth"]!=null)
				{
					model.User_Birth=row["User_Birth"].ToString();
				}
				if(row["User_Phone"]!=null)
				{
					model.User_Phone=row["User_Phone"].ToString();
				}
				if(row["User_QQ"]!=null)
				{
					model.User_QQ=row["User_QQ"].ToString();
				}
				if(row["User_Wechat"]!=null)
				{
					model.User_Wechat=row["User_Wechat"].ToString();
				}
				if(row["User_Weibo"]!=null)
				{
					model.User_Weibo=row["User_Weibo"].ToString();
				}
				if(row["User_UsingEmail"]!=null)
				{
					model.User_UsingEmail=row["User_UsingEmail"].ToString();
				}
				if(row["User_Major"]!=null)
				{
					model.User_Major=row["User_Major"].ToString();
				}
				if(row["User_School"]!=null)
				{
					model.User_School=row["User_School"].ToString();
				}
				if(row["User_Description"]!=null)
				{
					model.User_Description=row["User_Description"].ToString();
				}
				if(row["User_RegisterDate"]!=null && row["User_RegisterDate"].ToString()!="")
				{
					model.User_RegisterDate=DateTime.Parse(row["User_RegisterDate"].ToString());
				}
				if(row["User_LastOnline"]!=null && row["User_LastOnline"].ToString()!="")
				{
					model.User_LastOnline=DateTime.Parse(row["User_LastOnline"].ToString());
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
			strSql.Append("select User_ID,User_Email,User_UserName,User_Password,User_Type,User_Status,User_CityID,User_Points,User_Sex,User_Birth,User_Phone,User_QQ,User_Wechat,User_Weibo,User_UsingEmail,User_Major,User_School,User_Description,User_RegisterDate,User_LastOnline ");
			strSql.Append(" FROM Tb_User ");
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
			strSql.Append(" User_ID,User_Email,User_UserName,User_Password,User_Type,User_Status,User_CityID,User_Points,User_Sex,User_Birth,User_Phone,User_QQ,User_Wechat,User_Weibo,User_UsingEmail,User_Major,User_School,User_Description,User_RegisterDate,User_LastOnline ");
			strSql.Append(" FROM Tb_User ");
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
			strSql.Append("select count(1) FROM Tb_User ");
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
			strSql.Append(")AS Row, T.*  from Tb_User T ");
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
			parameters[0].Value = "Tb_User";
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

