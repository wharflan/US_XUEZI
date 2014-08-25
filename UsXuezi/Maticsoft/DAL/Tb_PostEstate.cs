/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostEstate.cs
*
* 功 能： N/A
* 类 名： Tb_PostEstate
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
	/// 数据访问类:Tb_PostEstate
	/// </summary>
	public partial class Tb_PostEstate
	{
		public Tb_PostEstate()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Estate_PostID", "Tb_PostEstate"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Estate_PostID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_PostEstate");
			strSql.Append(" where Estate_PostID=@Estate_PostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Estate_PostID", SqlDbType.Int,4)			};
			parameters[0].Value = Estate_PostID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Tb_PostEstate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_PostEstate(");
			strSql.Append("Estate_PostID,Estate_AreaID,Estate_Bedroom,Estate_Livingroom,Estate_Type,Estate_LivingFT,Estate_GroundFt,Estate_Parking,Estate_ManageFee,Estate_Cover,Estate_Image,Estate_Address)");
			strSql.Append(" values (");
			strSql.Append("@Estate_PostID,@Estate_AreaID,@Estate_Bedroom,@Estate_Livingroom,@Estate_Type,@Estate_LivingFT,@Estate_GroundFt,@Estate_Parking,@Estate_ManageFee,@Estate_Cover,@Estate_Image,@Estate_Address)");
			SqlParameter[] parameters = {
					new SqlParameter("@Estate_PostID", SqlDbType.Int,4),
					new SqlParameter("@Estate_AreaID", SqlDbType.Int,4),
					new SqlParameter("@Estate_Bedroom", SqlDbType.Int,4),
					new SqlParameter("@Estate_Livingroom", SqlDbType.Int,4),
					new SqlParameter("@Estate_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Estate_LivingFT", SqlDbType.Int,4),
					new SqlParameter("@Estate_GroundFt", SqlDbType.Int,4),
					new SqlParameter("@Estate_Parking", SqlDbType.NVarChar,50),
					new SqlParameter("@Estate_ManageFee", SqlDbType.Int,4),
					new SqlParameter("@Estate_Cover", SqlDbType.NVarChar,-1),
					new SqlParameter("@Estate_Image", SqlDbType.NVarChar,-1),
					new SqlParameter("@Estate_Address", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Estate_PostID;
			parameters[1].Value = model.Estate_AreaID;
			parameters[2].Value = model.Estate_Bedroom;
			parameters[3].Value = model.Estate_Livingroom;
			parameters[4].Value = model.Estate_Type;
			parameters[5].Value = model.Estate_LivingFT;
			parameters[6].Value = model.Estate_GroundFt;
			parameters[7].Value = model.Estate_Parking;
			parameters[8].Value = model.Estate_ManageFee;
			parameters[9].Value = model.Estate_Cover;
			parameters[10].Value = model.Estate_Image;
			parameters[11].Value = model.Estate_Address;

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
		public bool Update(Maticsoft.Model.Tb_PostEstate model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_PostEstate set ");
			strSql.Append("Estate_AreaID=@Estate_AreaID,");
			strSql.Append("Estate_Bedroom=@Estate_Bedroom,");
			strSql.Append("Estate_Livingroom=@Estate_Livingroom,");
			strSql.Append("Estate_Type=@Estate_Type,");
			strSql.Append("Estate_LivingFT=@Estate_LivingFT,");
			strSql.Append("Estate_GroundFt=@Estate_GroundFt,");
			strSql.Append("Estate_Parking=@Estate_Parking,");
			strSql.Append("Estate_ManageFee=@Estate_ManageFee,");
			strSql.Append("Estate_Cover=@Estate_Cover,");
			strSql.Append("Estate_Image=@Estate_Image,");
			strSql.Append("Estate_Address=@Estate_Address");
			strSql.Append(" where Estate_PostID=@Estate_PostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Estate_AreaID", SqlDbType.Int,4),
					new SqlParameter("@Estate_Bedroom", SqlDbType.Int,4),
					new SqlParameter("@Estate_Livingroom", SqlDbType.Int,4),
					new SqlParameter("@Estate_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Estate_LivingFT", SqlDbType.Int,4),
					new SqlParameter("@Estate_GroundFt", SqlDbType.Int,4),
					new SqlParameter("@Estate_Parking", SqlDbType.NVarChar,50),
					new SqlParameter("@Estate_ManageFee", SqlDbType.Int,4),
					new SqlParameter("@Estate_Cover", SqlDbType.NVarChar,-1),
					new SqlParameter("@Estate_Image", SqlDbType.NVarChar,-1),
					new SqlParameter("@Estate_Address", SqlDbType.NVarChar,50),
					new SqlParameter("@Estate_PostID", SqlDbType.Int,4)};
			parameters[0].Value = model.Estate_AreaID;
			parameters[1].Value = model.Estate_Bedroom;
			parameters[2].Value = model.Estate_Livingroom;
			parameters[3].Value = model.Estate_Type;
			parameters[4].Value = model.Estate_LivingFT;
			parameters[5].Value = model.Estate_GroundFt;
			parameters[6].Value = model.Estate_Parking;
			parameters[7].Value = model.Estate_ManageFee;
			parameters[8].Value = model.Estate_Cover;
			parameters[9].Value = model.Estate_Image;
			parameters[10].Value = model.Estate_Address;
			parameters[11].Value = model.Estate_PostID;

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
		public bool Delete(int Estate_PostID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostEstate ");
			strSql.Append(" where Estate_PostID=@Estate_PostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Estate_PostID", SqlDbType.Int,4)			};
			parameters[0].Value = Estate_PostID;

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
		public bool DeleteList(string Estate_PostIDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostEstate ");
			strSql.Append(" where Estate_PostID in ("+Estate_PostIDlist + ")  ");
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
		public Maticsoft.Model.Tb_PostEstate GetModel(int Estate_PostID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Estate_PostID,Estate_AreaID,Estate_Bedroom,Estate_Livingroom,Estate_Type,Estate_LivingFT,Estate_GroundFt,Estate_Parking,Estate_ManageFee,Estate_Cover,Estate_Image,Estate_Address from Tb_PostEstate ");
			strSql.Append(" where Estate_PostID=@Estate_PostID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Estate_PostID", SqlDbType.Int,4)			};
			parameters[0].Value = Estate_PostID;

			Maticsoft.Model.Tb_PostEstate model=new Maticsoft.Model.Tb_PostEstate();
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
		public Maticsoft.Model.Tb_PostEstate DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_PostEstate model=new Maticsoft.Model.Tb_PostEstate();
			if (row != null)
			{
				if(row["Estate_PostID"]!=null && row["Estate_PostID"].ToString()!="")
				{
					model.Estate_PostID=int.Parse(row["Estate_PostID"].ToString());
				}
				if(row["Estate_AreaID"]!=null && row["Estate_AreaID"].ToString()!="")
				{
					model.Estate_AreaID=int.Parse(row["Estate_AreaID"].ToString());
				}
				if(row["Estate_Bedroom"]!=null && row["Estate_Bedroom"].ToString()!="")
				{
					model.Estate_Bedroom=int.Parse(row["Estate_Bedroom"].ToString());
				}
				if(row["Estate_Livingroom"]!=null && row["Estate_Livingroom"].ToString()!="")
				{
					model.Estate_Livingroom=int.Parse(row["Estate_Livingroom"].ToString());
				}
				if(row["Estate_Type"]!=null)
				{
					model.Estate_Type=row["Estate_Type"].ToString();
				}
				if(row["Estate_LivingFT"]!=null && row["Estate_LivingFT"].ToString()!="")
				{
					model.Estate_LivingFT=int.Parse(row["Estate_LivingFT"].ToString());
				}
				if(row["Estate_GroundFt"]!=null && row["Estate_GroundFt"].ToString()!="")
				{
					model.Estate_GroundFt=int.Parse(row["Estate_GroundFt"].ToString());
				}
				if(row["Estate_Parking"]!=null)
				{
					model.Estate_Parking=row["Estate_Parking"].ToString();
				}
				if(row["Estate_ManageFee"]!=null && row["Estate_ManageFee"].ToString()!="")
				{
					model.Estate_ManageFee=int.Parse(row["Estate_ManageFee"].ToString());
				}
				if(row["Estate_Cover"]!=null)
				{
					model.Estate_Cover=row["Estate_Cover"].ToString();
				}
				if(row["Estate_Image"]!=null)
				{
					model.Estate_Image=row["Estate_Image"].ToString();
				}
				if(row["Estate_Address"]!=null)
				{
					model.Estate_Address=row["Estate_Address"].ToString();
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
			strSql.Append("select Estate_PostID,Estate_AreaID,Estate_Bedroom,Estate_Livingroom,Estate_Type,Estate_LivingFT,Estate_GroundFt,Estate_Parking,Estate_ManageFee,Estate_Cover,Estate_Image,Estate_Address ");
			strSql.Append(" FROM Tb_PostEstate ");
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
			strSql.Append(" Estate_PostID,Estate_AreaID,Estate_Bedroom,Estate_Livingroom,Estate_Type,Estate_LivingFT,Estate_GroundFt,Estate_Parking,Estate_ManageFee,Estate_Cover,Estate_Image,Estate_Address ");
			strSql.Append(" FROM Tb_PostEstate ");
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
			strSql.Append("select count(1) FROM Tb_PostEstate ");
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
				strSql.Append("order by T.Estate_PostID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_PostEstate T ");
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
			parameters[0].Value = "Tb_PostEstate";
			parameters[1].Value = "Estate_PostID";
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

