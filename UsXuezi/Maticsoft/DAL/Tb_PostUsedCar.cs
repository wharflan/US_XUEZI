/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostUsedCar.cs
*
* 功 能： N/A
* 类 名： Tb_PostUsedCar
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
	/// 数据访问类:Tb_PostUsedCar
	/// </summary>
	public partial class Tb_PostUsedCar
	{
		public Tb_PostUsedCar()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("UsedCar_ID", "Tb_PostUsedCar"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int UsedCar_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_PostUsedCar");
			strSql.Append(" where UsedCar_ID=@UsedCar_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UsedCar_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = UsedCar_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_PostUsedCar model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_PostUsedCar(");
			strSql.Append("UsedCar_PostID,UsedCar_AreaID,UsedCar_Price,UsedCar_CleanTitle,UsedCar_Type,UsedCar_Model,UsedCar_BuyYear,UsedCar_Miles,UsedCar_Cover,UsedCar_Imgs,UsedCar_Description)");
			strSql.Append(" values (");
			strSql.Append("@UsedCar_PostID,@UsedCar_AreaID,@UsedCar_Price,@UsedCar_CleanTitle,@UsedCar_Type,@UsedCar_Model,@UsedCar_BuyYear,@UsedCar_Miles,@UsedCar_Cover,@UsedCar_Imgs,@UsedCar_Description)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@UsedCar_PostID", SqlDbType.Int,4),
					new SqlParameter("@UsedCar_AreaID", SqlDbType.Int,4),
					new SqlParameter("@UsedCar_Price", SqlDbType.Int,4),
					new SqlParameter("@UsedCar_CleanTitle", SqlDbType.Int,4),
					new SqlParameter("@UsedCar_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@UsedCar_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@UsedCar_BuyYear", SqlDbType.NVarChar,10),
					new SqlParameter("@UsedCar_Miles", SqlDbType.Int,4),
					new SqlParameter("@UsedCar_Cover", SqlDbType.NVarChar,-1),
					new SqlParameter("@UsedCar_Imgs", SqlDbType.NVarChar,-1),
					new SqlParameter("@UsedCar_Description", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.UsedCar_PostID;
			parameters[1].Value = model.UsedCar_AreaID;
			parameters[2].Value = model.UsedCar_Price;
			parameters[3].Value = model.UsedCar_CleanTitle;
			parameters[4].Value = model.UsedCar_Type;
			parameters[5].Value = model.UsedCar_Model;
			parameters[6].Value = model.UsedCar_BuyYear;
			parameters[7].Value = model.UsedCar_Miles;
			parameters[8].Value = model.UsedCar_Cover;
			parameters[9].Value = model.UsedCar_Imgs;
			parameters[10].Value = model.UsedCar_Description;

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
		public bool Update(Maticsoft.Model.Tb_PostUsedCar model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_PostUsedCar set ");
			strSql.Append("UsedCar_PostID=@UsedCar_PostID,");
			strSql.Append("UsedCar_AreaID=@UsedCar_AreaID,");
			strSql.Append("UsedCar_Price=@UsedCar_Price,");
			strSql.Append("UsedCar_CleanTitle=@UsedCar_CleanTitle,");
			strSql.Append("UsedCar_Type=@UsedCar_Type,");
			strSql.Append("UsedCar_Model=@UsedCar_Model,");
			strSql.Append("UsedCar_BuyYear=@UsedCar_BuyYear,");
			strSql.Append("UsedCar_Miles=@UsedCar_Miles,");
			strSql.Append("UsedCar_Cover=@UsedCar_Cover,");
			strSql.Append("UsedCar_Imgs=@UsedCar_Imgs,");
			strSql.Append("UsedCar_Description=@UsedCar_Description");
			strSql.Append(" where UsedCar_ID=@UsedCar_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UsedCar_PostID", SqlDbType.Int,4),
					new SqlParameter("@UsedCar_AreaID", SqlDbType.Int,4),
					new SqlParameter("@UsedCar_Price", SqlDbType.Int,4),
					new SqlParameter("@UsedCar_CleanTitle", SqlDbType.Int,4),
					new SqlParameter("@UsedCar_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@UsedCar_Model", SqlDbType.NVarChar,50),
					new SqlParameter("@UsedCar_BuyYear", SqlDbType.NVarChar,10),
					new SqlParameter("@UsedCar_Miles", SqlDbType.Int,4),
					new SqlParameter("@UsedCar_Cover", SqlDbType.NVarChar,-1),
					new SqlParameter("@UsedCar_Imgs", SqlDbType.NVarChar,-1),
					new SqlParameter("@UsedCar_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@UsedCar_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.UsedCar_PostID;
			parameters[1].Value = model.UsedCar_AreaID;
			parameters[2].Value = model.UsedCar_Price;
			parameters[3].Value = model.UsedCar_CleanTitle;
			parameters[4].Value = model.UsedCar_Type;
			parameters[5].Value = model.UsedCar_Model;
			parameters[6].Value = model.UsedCar_BuyYear;
			parameters[7].Value = model.UsedCar_Miles;
			parameters[8].Value = model.UsedCar_Cover;
			parameters[9].Value = model.UsedCar_Imgs;
			parameters[10].Value = model.UsedCar_Description;
			parameters[11].Value = model.UsedCar_ID;

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
		public bool Delete(int UsedCar_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostUsedCar ");
			strSql.Append(" where UsedCar_ID=@UsedCar_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UsedCar_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = UsedCar_ID;

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
		public bool DeleteList(string UsedCar_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostUsedCar ");
			strSql.Append(" where UsedCar_ID in ("+UsedCar_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_PostUsedCar GetModel(int UsedCar_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 UsedCar_ID,UsedCar_PostID,UsedCar_AreaID,UsedCar_Price,UsedCar_CleanTitle,UsedCar_Type,UsedCar_Model,UsedCar_BuyYear,UsedCar_Miles,UsedCar_Cover,UsedCar_Imgs,UsedCar_Description from Tb_PostUsedCar ");
			strSql.Append(" where UsedCar_ID=@UsedCar_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@UsedCar_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = UsedCar_ID;

			Maticsoft.Model.Tb_PostUsedCar model=new Maticsoft.Model.Tb_PostUsedCar();
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
		public Maticsoft.Model.Tb_PostUsedCar DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_PostUsedCar model=new Maticsoft.Model.Tb_PostUsedCar();
			if (row != null)
			{
				if(row["UsedCar_ID"]!=null && row["UsedCar_ID"].ToString()!="")
				{
					model.UsedCar_ID=int.Parse(row["UsedCar_ID"].ToString());
				}
				if(row["UsedCar_PostID"]!=null && row["UsedCar_PostID"].ToString()!="")
				{
					model.UsedCar_PostID=int.Parse(row["UsedCar_PostID"].ToString());
				}
				if(row["UsedCar_AreaID"]!=null && row["UsedCar_AreaID"].ToString()!="")
				{
					model.UsedCar_AreaID=int.Parse(row["UsedCar_AreaID"].ToString());
				}
				if(row["UsedCar_Price"]!=null && row["UsedCar_Price"].ToString()!="")
				{
					model.UsedCar_Price=int.Parse(row["UsedCar_Price"].ToString());
				}
				if(row["UsedCar_CleanTitle"]!=null && row["UsedCar_CleanTitle"].ToString()!="")
				{
					model.UsedCar_CleanTitle=int.Parse(row["UsedCar_CleanTitle"].ToString());
				}
				if(row["UsedCar_Type"]!=null)
				{
					model.UsedCar_Type=row["UsedCar_Type"].ToString();
				}
				if(row["UsedCar_Model"]!=null)
				{
					model.UsedCar_Model=row["UsedCar_Model"].ToString();
				}
				if(row["UsedCar_BuyYear"]!=null)
				{
					model.UsedCar_BuyYear=row["UsedCar_BuyYear"].ToString();
				}
				if(row["UsedCar_Miles"]!=null && row["UsedCar_Miles"].ToString()!="")
				{
					model.UsedCar_Miles=int.Parse(row["UsedCar_Miles"].ToString());
				}
				if(row["UsedCar_Cover"]!=null)
				{
					model.UsedCar_Cover=row["UsedCar_Cover"].ToString();
				}
				if(row["UsedCar_Imgs"]!=null)
				{
					model.UsedCar_Imgs=row["UsedCar_Imgs"].ToString();
				}
				if(row["UsedCar_Description"]!=null)
				{
					model.UsedCar_Description=row["UsedCar_Description"].ToString();
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
			strSql.Append("select UsedCar_ID,UsedCar_PostID,UsedCar_AreaID,UsedCar_Price,UsedCar_CleanTitle,UsedCar_Type,UsedCar_Model,UsedCar_BuyYear,UsedCar_Miles,UsedCar_Cover,UsedCar_Imgs,UsedCar_Description ");
			strSql.Append(" FROM Tb_PostUsedCar ");
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
			strSql.Append(" UsedCar_ID,UsedCar_PostID,UsedCar_AreaID,UsedCar_Price,UsedCar_CleanTitle,UsedCar_Type,UsedCar_Model,UsedCar_BuyYear,UsedCar_Miles,UsedCar_Cover,UsedCar_Imgs,UsedCar_Description ");
			strSql.Append(" FROM Tb_PostUsedCar ");
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
			strSql.Append("select count(1) FROM Tb_PostUsedCar ");
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
				strSql.Append("order by T.UsedCar_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_PostUsedCar T ");
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
			parameters[0].Value = "Tb_PostUsedCar";
			parameters[1].Value = "UsedCar_ID";
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

