/**  版本信息模板在安装目录下，可自行修改。
* Tb_Coupon.cs
*
* 功 能： N/A
* 类 名： Tb_Coupon
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:07 AM   N/A    初版
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
	/// 数据访问类:Tb_Coupon
	/// </summary>
	public partial class Tb_Coupon
	{
		public Tb_Coupon()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Coupon_ID", "Tb_Coupon"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Coupon_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_Coupon");
			strSql.Append(" where Coupon_ID=@Coupon_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Coupon_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Coupon_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_Coupon model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_Coupon(");
			strSql.Append("Coupon_BusinessID,Coupon_Name,Coupon_Description,Coupon_Img,Coupon_StartDate,Coupon_EndDate)");
			strSql.Append(" values (");
			strSql.Append("@Coupon_BusinessID,@Coupon_Name,@Coupon_Description,@Coupon_Img,@Coupon_StartDate,@Coupon_EndDate)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Coupon_BusinessID", SqlDbType.Int,4),
					new SqlParameter("@Coupon_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Coupon_Description", SqlDbType.NVarChar,20),
					new SqlParameter("@Coupon_Img", SqlDbType.NVarChar,-1),
					new SqlParameter("@Coupon_StartDate", SqlDbType.DateTime),
					new SqlParameter("@Coupon_EndDate", SqlDbType.DateTime)};
			parameters[0].Value = model.Coupon_BusinessID;
			parameters[1].Value = model.Coupon_Name;
			parameters[2].Value = model.Coupon_Description;
			parameters[3].Value = model.Coupon_Img;
			parameters[4].Value = model.Coupon_StartDate;
			parameters[5].Value = model.Coupon_EndDate;

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
		public bool Update(Maticsoft.Model.Tb_Coupon model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_Coupon set ");
			strSql.Append("Coupon_BusinessID=@Coupon_BusinessID,");
			strSql.Append("Coupon_Name=@Coupon_Name,");
			strSql.Append("Coupon_Description=@Coupon_Description,");
			strSql.Append("Coupon_Img=@Coupon_Img,");
			strSql.Append("Coupon_StartDate=@Coupon_StartDate,");
			strSql.Append("Coupon_EndDate=@Coupon_EndDate");
			strSql.Append(" where Coupon_ID=@Coupon_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Coupon_BusinessID", SqlDbType.Int,4),
					new SqlParameter("@Coupon_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Coupon_Description", SqlDbType.NVarChar,20),
					new SqlParameter("@Coupon_Img", SqlDbType.NVarChar,-1),
					new SqlParameter("@Coupon_StartDate", SqlDbType.DateTime),
					new SqlParameter("@Coupon_EndDate", SqlDbType.DateTime),
					new SqlParameter("@Coupon_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Coupon_BusinessID;
			parameters[1].Value = model.Coupon_Name;
			parameters[2].Value = model.Coupon_Description;
			parameters[3].Value = model.Coupon_Img;
			parameters[4].Value = model.Coupon_StartDate;
			parameters[5].Value = model.Coupon_EndDate;
			parameters[6].Value = model.Coupon_ID;

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
		public bool Delete(int Coupon_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Coupon ");
			strSql.Append(" where Coupon_ID=@Coupon_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Coupon_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Coupon_ID;

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
		public bool DeleteList(string Coupon_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Coupon ");
			strSql.Append(" where Coupon_ID in ("+Coupon_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_Coupon GetModel(int Coupon_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Coupon_ID,Coupon_BusinessID,Coupon_Name,Coupon_Description,Coupon_Img,Coupon_StartDate,Coupon_EndDate from Tb_Coupon ");
			strSql.Append(" where Coupon_ID=@Coupon_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Coupon_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Coupon_ID;

			Maticsoft.Model.Tb_Coupon model=new Maticsoft.Model.Tb_Coupon();
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
		public Maticsoft.Model.Tb_Coupon DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_Coupon model=new Maticsoft.Model.Tb_Coupon();
			if (row != null)
			{
				if(row["Coupon_ID"]!=null && row["Coupon_ID"].ToString()!="")
				{
					model.Coupon_ID=int.Parse(row["Coupon_ID"].ToString());
				}
				if(row["Coupon_BusinessID"]!=null && row["Coupon_BusinessID"].ToString()!="")
				{
					model.Coupon_BusinessID=int.Parse(row["Coupon_BusinessID"].ToString());
				}
				if(row["Coupon_Name"]!=null)
				{
					model.Coupon_Name=row["Coupon_Name"].ToString();
				}
				if(row["Coupon_Description"]!=null)
				{
					model.Coupon_Description=row["Coupon_Description"].ToString();
				}
				if(row["Coupon_Img"]!=null)
				{
					model.Coupon_Img=row["Coupon_Img"].ToString();
				}
				if(row["Coupon_StartDate"]!=null && row["Coupon_StartDate"].ToString()!="")
				{
					model.Coupon_StartDate=DateTime.Parse(row["Coupon_StartDate"].ToString());
				}
				if(row["Coupon_EndDate"]!=null && row["Coupon_EndDate"].ToString()!="")
				{
					model.Coupon_EndDate=DateTime.Parse(row["Coupon_EndDate"].ToString());
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
			strSql.Append("select Coupon_ID,Coupon_BusinessID,Coupon_Name,Coupon_Description,Coupon_Img,Coupon_StartDate,Coupon_EndDate ");
			strSql.Append(" FROM Tb_Coupon ");
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
			strSql.Append(" Coupon_ID,Coupon_BusinessID,Coupon_Name,Coupon_Description,Coupon_Img,Coupon_StartDate,Coupon_EndDate ");
			strSql.Append(" FROM Tb_Coupon ");
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
			strSql.Append("select count(1) FROM Tb_Coupon ");
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
				strSql.Append("order by T.Coupon_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_Coupon T ");
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
			parameters[0].Value = "Tb_Coupon";
			parameters[1].Value = "Coupon_ID";
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

