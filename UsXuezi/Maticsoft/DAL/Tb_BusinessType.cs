/**  版本信息模板在安装目录下，可自行修改。
* Tb_BusinessType.cs
*
* 功 能： N/A
* 类 名： Tb_BusinessType
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:06 AM   N/A    初版
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
	/// 数据访问类:Tb_BusinessType
	/// </summary>
	public partial class Tb_BusinessType
	{
		public Tb_BusinessType()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("BT_ID", "Tb_BusinessType"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int BT_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_BusinessType");
			strSql.Append(" where BT_ID=@BT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@BT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = BT_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_BusinessType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_BusinessType(");
			strSql.Append("BT_Content)");
			strSql.Append(" values (");
			strSql.Append("@BT_Content)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@BT_Content", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.BT_Content;

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
		public bool Update(Maticsoft.Model.Tb_BusinessType model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_BusinessType set ");
			strSql.Append("BT_Content=@BT_Content");
			strSql.Append(" where BT_ID=@BT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@BT_Content", SqlDbType.NVarChar,50),
					new SqlParameter("@BT_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.BT_Content;
			parameters[1].Value = model.BT_ID;

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
		public bool Delete(int BT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_BusinessType ");
			strSql.Append(" where BT_ID=@BT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@BT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = BT_ID;

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
		public bool DeleteList(string BT_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_BusinessType ");
			strSql.Append(" where BT_ID in ("+BT_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_BusinessType GetModel(int BT_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 BT_ID,BT_Content from Tb_BusinessType ");
			strSql.Append(" where BT_ID=@BT_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@BT_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = BT_ID;

			Maticsoft.Model.Tb_BusinessType model=new Maticsoft.Model.Tb_BusinessType();
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
		public Maticsoft.Model.Tb_BusinessType DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_BusinessType model=new Maticsoft.Model.Tb_BusinessType();
			if (row != null)
			{
				if(row["BT_ID"]!=null && row["BT_ID"].ToString()!="")
				{
					model.BT_ID=int.Parse(row["BT_ID"].ToString());
				}
				if(row["BT_Content"]!=null)
				{
					model.BT_Content=row["BT_Content"].ToString();
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
			strSql.Append("select BT_ID,BT_Content ");
			strSql.Append(" FROM Tb_BusinessType ");
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
			strSql.Append(" BT_ID,BT_Content ");
			strSql.Append(" FROM Tb_BusinessType ");
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
			strSql.Append("select count(1) FROM Tb_BusinessType ");
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
				strSql.Append("order by T.BT_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_BusinessType T ");
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
			parameters[0].Value = "Tb_BusinessType";
			parameters[1].Value = "BT_ID";
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

