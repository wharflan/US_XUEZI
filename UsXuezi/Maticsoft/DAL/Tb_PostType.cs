/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostType.cs
*
* 功 能： N/A
* 类 名： Tb_PostType
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:11 AM   N/A    初版
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
	/// 数据访问类:Tb_PostType
	/// </summary>
	public partial class Tb_PostType
	{
		public Tb_PostType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("PostType_ID", "Tb_PostType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int PostType_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_PostType");
			strSql.Append(" where PostType_ID=@PostType_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@PostType_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = PostType_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_PostType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_PostType(");
			strSql.Append("PostType_NameEN,PostType_NameCN)");
			strSql.Append(" values (");
			strSql.Append("@PostType_NameEN,@PostType_NameCN)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@PostType_NameEN", SqlDbType.VarChar,-1),
					new SqlParameter("@PostType_NameCN", SqlDbType.VarChar,-1)};
			parameters[0].Value = model.PostType_NameEN;
			parameters[1].Value = model.PostType_NameCN;

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
		public bool Update(Maticsoft.Model.Tb_PostType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_PostType set ");
			strSql.Append("PostType_NameEN=@PostType_NameEN,");
			strSql.Append("PostType_NameCN=@PostType_NameCN");
			strSql.Append(" where PostType_ID=@PostType_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@PostType_NameEN", SqlDbType.VarChar,-1),
					new SqlParameter("@PostType_NameCN", SqlDbType.VarChar,-1),
					new SqlParameter("@PostType_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.PostType_NameEN;
			parameters[1].Value = model.PostType_NameCN;
			parameters[2].Value = model.PostType_ID;

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
		public bool Delete(int PostType_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostType ");
			strSql.Append(" where PostType_ID=@PostType_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@PostType_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = PostType_ID;

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
		public bool DeleteList(string PostType_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostType ");
			strSql.Append(" where PostType_ID in ("+PostType_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_PostType GetModel(int PostType_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 PostType_ID,PostType_NameEN,PostType_NameCN from Tb_PostType ");
			strSql.Append(" where PostType_ID=@PostType_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@PostType_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = PostType_ID;

			Maticsoft.Model.Tb_PostType model=new Maticsoft.Model.Tb_PostType();
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
		public Maticsoft.Model.Tb_PostType DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_PostType model=new Maticsoft.Model.Tb_PostType();
			if (row != null)
			{
				if(row["PostType_ID"]!=null && row["PostType_ID"].ToString()!="")
				{
					model.PostType_ID=int.Parse(row["PostType_ID"].ToString());
				}
				if(row["PostType_NameEN"]!=null)
				{
					model.PostType_NameEN=row["PostType_NameEN"].ToString();
				}
				if(row["PostType_NameCN"]!=null)
				{
					model.PostType_NameCN=row["PostType_NameCN"].ToString();
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
			strSql.Append("select PostType_ID,PostType_NameEN,PostType_NameCN ");
			strSql.Append(" FROM Tb_PostType ");
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
			strSql.Append(" PostType_ID,PostType_NameEN,PostType_NameCN ");
			strSql.Append(" FROM Tb_PostType ");
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
			strSql.Append("select count(1) FROM Tb_PostType ");
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
				strSql.Append("order by T.PostType_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_PostType T ");
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
			parameters[0].Value = "Tb_PostType";
			parameters[1].Value = "PostType_ID";
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

