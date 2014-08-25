/**  版本信息模板在安装目录下，可自行修改。
* Tb_Area.cs
*
* 功 能： N/A
* 类 名： Tb_Area
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
	/// 数据访问类:Tb_Area
	/// </summary>
	public partial class Tb_Area
	{
		public Tb_Area()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Area_ID", "Tb_Area"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Area_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_Area");
			strSql.Append(" where Area_ID=@Area_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Area_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Area_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_Area model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_Area(");
			strSql.Append("Area_CityID,Area_Name)");
			strSql.Append(" values (");
			strSql.Append("@Area_CityID,@Area_Name)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Area_CityID", SqlDbType.Int,4),
					new SqlParameter("@Area_Name", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Area_CityID;
			parameters[1].Value = model.Area_Name;

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
		public bool Update(Maticsoft.Model.Tb_Area model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_Area set ");
			strSql.Append("Area_CityID=@Area_CityID,");
			strSql.Append("Area_Name=@Area_Name");
			strSql.Append(" where Area_ID=@Area_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Area_CityID", SqlDbType.Int,4),
					new SqlParameter("@Area_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Area_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Area_CityID;
			parameters[1].Value = model.Area_Name;
			parameters[2].Value = model.Area_ID;

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
		public bool Delete(int Area_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Area ");
			strSql.Append(" where Area_ID=@Area_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Area_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Area_ID;

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
		public bool DeleteList(string Area_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Area ");
			strSql.Append(" where Area_ID in ("+Area_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_Area GetModel(int Area_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Area_ID,Area_CityID,Area_Name from Tb_Area ");
			strSql.Append(" where Area_ID=@Area_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Area_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Area_ID;

			Maticsoft.Model.Tb_Area model=new Maticsoft.Model.Tb_Area();
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
		public Maticsoft.Model.Tb_Area DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_Area model=new Maticsoft.Model.Tb_Area();
			if (row != null)
			{
				if(row["Area_ID"]!=null && row["Area_ID"].ToString()!="")
				{
					model.Area_ID=int.Parse(row["Area_ID"].ToString());
				}
				if(row["Area_CityID"]!=null && row["Area_CityID"].ToString()!="")
				{
					model.Area_CityID=int.Parse(row["Area_CityID"].ToString());
				}
				if(row["Area_Name"]!=null)
				{
					model.Area_Name=row["Area_Name"].ToString();
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
			strSql.Append("select Area_ID,Area_CityID,Area_Name ");
			strSql.Append(" FROM Tb_Area ");
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
			strSql.Append(" Area_ID,Area_CityID,Area_Name ");
			strSql.Append(" FROM Tb_Area ");
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
			strSql.Append("select count(1) FROM Tb_Area ");
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
				strSql.Append("order by T.Area_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_Area T ");
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
			parameters[0].Value = "Tb_Area";
			parameters[1].Value = "Area_ID";
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

