/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostBusiness.cs
*
* 功 能： N/A
* 类 名： Tb_PostBusiness
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:09 AM   N/A    初版
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
	/// 数据访问类:Tb_PostBusiness
	/// </summary>
	public partial class Tb_PostBusiness
	{
		public Tb_PostBusiness()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Business_PostID", "Tb_PostBusiness"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Business_PostID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_PostBusiness");
			strSql.Append(" where Business_PostID=@Business_PostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Business_PostID", SqlDbType.Int,4)			};
			parameters[0].Value = Business_PostID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Tb_PostBusiness model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_PostBusiness(");
			strSql.Append("Business_PostID,Business_AreaID,Business_TypeID,Business_Description,Business_Cover,Business_Address,Business_MainContent,Business_Status,Business_Phone,Business_Wechat,Business_Email,Business_QQ,Business_Weibo)");
			strSql.Append(" values (");
			strSql.Append("@Business_PostID,@Business_AreaID,@Business_TypeID,@Business_Description,@Business_Cover,@Business_Address,@Business_MainContent,@Business_Status,@Business_Phone,@Business_Wechat,@Business_Email,@Business_QQ,@Business_Weibo)");
			SqlParameter[] parameters = {
					new SqlParameter("@Business_PostID", SqlDbType.Int,4),
					new SqlParameter("@Business_AreaID", SqlDbType.Int,4),
					new SqlParameter("@Business_TypeID", SqlDbType.Int,4),
					new SqlParameter("@Business_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@Business_Cover", SqlDbType.NVarChar,-1),
					new SqlParameter("@Business_Address", SqlDbType.NVarChar,50),
					new SqlParameter("@Business_MainContent", SqlDbType.NVarChar,-1),
					new SqlParameter("@Business_Status", SqlDbType.Int,4),
					new SqlParameter("@Business_Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Business_Wechat", SqlDbType.NVarChar,50),
					new SqlParameter("@Business_Email", SqlDbType.NVarChar,50),
					new SqlParameter("@Business_QQ", SqlDbType.NVarChar,50),
					new SqlParameter("@Business_Weibo", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Business_PostID;
			parameters[1].Value = model.Business_AreaID;
			parameters[2].Value = model.Business_TypeID;
			parameters[3].Value = model.Business_Description;
			parameters[4].Value = model.Business_Cover;
			parameters[5].Value = model.Business_Address;
			parameters[6].Value = model.Business_MainContent;
			parameters[7].Value = model.Business_Status;
			parameters[8].Value = model.Business_Phone;
			parameters[9].Value = model.Business_Wechat;
			parameters[10].Value = model.Business_Email;
			parameters[11].Value = model.Business_QQ;
			parameters[12].Value = model.Business_Weibo;

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
		public bool Update(Maticsoft.Model.Tb_PostBusiness model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_PostBusiness set ");
			strSql.Append("Business_AreaID=@Business_AreaID,");
			strSql.Append("Business_TypeID=@Business_TypeID,");
			strSql.Append("Business_Description=@Business_Description,");
			strSql.Append("Business_Cover=@Business_Cover,");
			strSql.Append("Business_Address=@Business_Address,");
			strSql.Append("Business_MainContent=@Business_MainContent,");
			strSql.Append("Business_Status=@Business_Status,");
			strSql.Append("Business_Phone=@Business_Phone,");
			strSql.Append("Business_Wechat=@Business_Wechat,");
			strSql.Append("Business_Email=@Business_Email,");
			strSql.Append("Business_QQ=@Business_QQ,");
			strSql.Append("Business_Weibo=@Business_Weibo");
			strSql.Append(" where Business_PostID=@Business_PostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Business_AreaID", SqlDbType.Int,4),
					new SqlParameter("@Business_TypeID", SqlDbType.Int,4),
					new SqlParameter("@Business_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@Business_Cover", SqlDbType.NVarChar,-1),
					new SqlParameter("@Business_Address", SqlDbType.NVarChar,50),
					new SqlParameter("@Business_MainContent", SqlDbType.NVarChar,-1),
					new SqlParameter("@Business_Status", SqlDbType.Int,4),
					new SqlParameter("@Business_Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Business_Wechat", SqlDbType.NVarChar,50),
					new SqlParameter("@Business_Email", SqlDbType.NVarChar,50),
					new SqlParameter("@Business_QQ", SqlDbType.NVarChar,50),
					new SqlParameter("@Business_Weibo", SqlDbType.NVarChar,50),
					new SqlParameter("@Business_PostID", SqlDbType.Int,4)};
			parameters[0].Value = model.Business_AreaID;
			parameters[1].Value = model.Business_TypeID;
			parameters[2].Value = model.Business_Description;
			parameters[3].Value = model.Business_Cover;
			parameters[4].Value = model.Business_Address;
			parameters[5].Value = model.Business_MainContent;
			parameters[6].Value = model.Business_Status;
			parameters[7].Value = model.Business_Phone;
			parameters[8].Value = model.Business_Wechat;
			parameters[9].Value = model.Business_Email;
			parameters[10].Value = model.Business_QQ;
			parameters[11].Value = model.Business_Weibo;
			parameters[12].Value = model.Business_PostID;

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
		public bool Delete(int Business_PostID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostBusiness ");
			strSql.Append(" where Business_PostID=@Business_PostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Business_PostID", SqlDbType.Int,4)			};
			parameters[0].Value = Business_PostID;

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
		public bool DeleteList(string Business_PostIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostBusiness ");
			strSql.Append(" where Business_PostID in ("+Business_PostIDlist + ")  ");
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
		public Maticsoft.Model.Tb_PostBusiness GetModel(int Business_PostID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Business_PostID,Business_AreaID,Business_TypeID,Business_Description,Business_Cover,Business_Address,Business_MainContent,Business_Status,Business_Phone,Business_Wechat,Business_Email,Business_QQ,Business_Weibo from Tb_PostBusiness ");
			strSql.Append(" where Business_PostID=@Business_PostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Business_PostID", SqlDbType.Int,4)			};
			parameters[0].Value = Business_PostID;

			Maticsoft.Model.Tb_PostBusiness model=new Maticsoft.Model.Tb_PostBusiness();
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
		public Maticsoft.Model.Tb_PostBusiness DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_PostBusiness model=new Maticsoft.Model.Tb_PostBusiness();
			if (row != null)
			{
				if(row["Business_PostID"]!=null && row["Business_PostID"].ToString()!="")
				{
					model.Business_PostID=int.Parse(row["Business_PostID"].ToString());
				}
				if(row["Business_AreaID"]!=null && row["Business_AreaID"].ToString()!="")
				{
					model.Business_AreaID=int.Parse(row["Business_AreaID"].ToString());
				}
				if(row["Business_TypeID"]!=null && row["Business_TypeID"].ToString()!="")
				{
					model.Business_TypeID=int.Parse(row["Business_TypeID"].ToString());
				}
				if(row["Business_Description"]!=null)
				{
					model.Business_Description=row["Business_Description"].ToString();
				}
				if(row["Business_Cover"]!=null)
				{
					model.Business_Cover=row["Business_Cover"].ToString();
				}
				if(row["Business_Address"]!=null)
				{
					model.Business_Address=row["Business_Address"].ToString();
				}
				if(row["Business_MainContent"]!=null)
				{
					model.Business_MainContent=row["Business_MainContent"].ToString();
				}
				if(row["Business_Status"]!=null && row["Business_Status"].ToString()!="")
				{
					model.Business_Status=int.Parse(row["Business_Status"].ToString());
				}
				if(row["Business_Phone"]!=null)
				{
					model.Business_Phone=row["Business_Phone"].ToString();
				}
				if(row["Business_Wechat"]!=null)
				{
					model.Business_Wechat=row["Business_Wechat"].ToString();
				}
				if(row["Business_Email"]!=null)
				{
					model.Business_Email=row["Business_Email"].ToString();
				}
				if(row["Business_QQ"]!=null)
				{
					model.Business_QQ=row["Business_QQ"].ToString();
				}
				if(row["Business_Weibo"]!=null)
				{
					model.Business_Weibo=row["Business_Weibo"].ToString();
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
			strSql.Append("select Business_PostID,Business_AreaID,Business_TypeID,Business_Description,Business_Cover,Business_Address,Business_MainContent,Business_Status,Business_Phone,Business_Wechat,Business_Email,Business_QQ,Business_Weibo ");
			strSql.Append(" FROM Tb_PostBusiness ");
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
			strSql.Append(" Business_PostID,Business_AreaID,Business_TypeID,Business_Description,Business_Cover,Business_Address,Business_MainContent,Business_Status,Business_Phone,Business_Wechat,Business_Email,Business_QQ,Business_Weibo ");
			strSql.Append(" FROM Tb_PostBusiness ");
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
			strSql.Append("select count(1) FROM Tb_PostBusiness ");
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
				strSql.Append("order by T.Business_PostID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_PostBusiness T ");
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
			parameters[0].Value = "Tb_PostBusiness";
			parameters[1].Value = "Business_PostID";
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

