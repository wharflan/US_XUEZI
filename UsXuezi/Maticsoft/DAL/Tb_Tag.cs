/**  版本信息模板在安装目录下，可自行修改。
* Tb_Tag.cs
*
* 功 能： N/A
* 类 名： Tb_Tag
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
	/// 数据访问类:Tb_Tag
	/// </summary>
	public partial class Tb_Tag
	{
		public Tb_Tag()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Tag_ID", "Tb_Tag"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Tag_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_Tag");
			strSql.Append(" where Tag_ID=@Tag_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Tag_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Tag_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_Tag model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_Tag(");
			strSql.Append("Tag_PostID,Tag_Content)");
			strSql.Append(" values (");
			strSql.Append("@Tag_PostID,@Tag_Content)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Tag_PostID", SqlDbType.Int,4),
					new SqlParameter("@Tag_Content", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Tag_PostID;
			parameters[1].Value = model.Tag_Content;

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
		public bool Update(Maticsoft.Model.Tb_Tag model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_Tag set ");
			strSql.Append("Tag_PostID=@Tag_PostID,");
			strSql.Append("Tag_Content=@Tag_Content");
			strSql.Append(" where Tag_ID=@Tag_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Tag_PostID", SqlDbType.Int,4),
					new SqlParameter("@Tag_Content", SqlDbType.NVarChar,50),
					new SqlParameter("@Tag_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Tag_PostID;
			parameters[1].Value = model.Tag_Content;
			parameters[2].Value = model.Tag_ID;

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
		public bool Delete(int Tag_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Tag ");
			strSql.Append(" where Tag_ID=@Tag_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Tag_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Tag_ID;

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
		public bool DeleteList(string Tag_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Tag ");
			strSql.Append(" where Tag_ID in ("+Tag_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_Tag GetModel(int Tag_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Tag_ID,Tag_PostID,Tag_Content from Tb_Tag ");
			strSql.Append(" where Tag_ID=@Tag_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Tag_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Tag_ID;

			Maticsoft.Model.Tb_Tag model=new Maticsoft.Model.Tb_Tag();
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
		public Maticsoft.Model.Tb_Tag DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_Tag model=new Maticsoft.Model.Tb_Tag();
			if (row != null)
			{
				if(row["Tag_ID"]!=null && row["Tag_ID"].ToString()!="")
				{
					model.Tag_ID=int.Parse(row["Tag_ID"].ToString());
				}
				if(row["Tag_PostID"]!=null && row["Tag_PostID"].ToString()!="")
				{
					model.Tag_PostID=int.Parse(row["Tag_PostID"].ToString());
				}
				if(row["Tag_Content"]!=null)
				{
					model.Tag_Content=row["Tag_Content"].ToString();
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
			strSql.Append("select Tag_ID,Tag_PostID,Tag_Content ");
			strSql.Append(" FROM Tb_Tag ");
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
			strSql.Append(" Tag_ID,Tag_PostID,Tag_Content ");
			strSql.Append(" FROM Tb_Tag ");
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
			strSql.Append("select count(1) FROM Tb_Tag ");
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
				strSql.Append("order by T.Tag_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_Tag T ");
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
			parameters[0].Value = "Tb_Tag";
			parameters[1].Value = "Tag_ID";
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

