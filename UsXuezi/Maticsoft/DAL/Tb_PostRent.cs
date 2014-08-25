/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostRent.cs
*
* 功 能： N/A
* 类 名： Tb_PostRent
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  8/5/2014 10:43:31 AM   N/A    初版
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
	/// 数据访问类:Tb_PostRent
	/// </summary>
	public partial class Tb_PostRent
	{
		public Tb_PostRent()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Rent_ID", "Tb_PostRent"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Rent_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_PostRent");
			strSql.Append(" where Rent_ID=@Rent_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Rent_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Rent_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Maticsoft.Model.Tb_PostRent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_PostRent(");
			strSql.Append("Rent_ID,Rent_Area,Rent_Price,Rent_IsSingleRoom,Rent_IsWholeBuilding,Rent_Start,Rent_End,Rent_Cover,Rent_Images,Rent_Address,Rent_Description,Rent_Furniture,Rent_Pat,Rent_StreetPark,Rent_Garage,Rent_Phone,Rent_Wechat,Rent_QQ,Rent_Email)");
			strSql.Append(" values (");
			strSql.Append("@Rent_ID,@Rent_Area,@Rent_Price,@Rent_IsSingleRoom,@Rent_IsWholeBuilding,@Rent_Start,@Rent_End,@Rent_Cover,@Rent_Images,@Rent_Address,@Rent_Description,@Rent_Furniture,@Rent_Pat,@Rent_StreetPark,@Rent_Garage,@Rent_Phone,@Rent_Wechat,@Rent_QQ,@Rent_Email)");
			SqlParameter[] parameters = {
					new SqlParameter("@Rent_ID", SqlDbType.Int,4),
					new SqlParameter("@Rent_Area", SqlDbType.Int,4),
					new SqlParameter("@Rent_Price", SqlDbType.Int,4),
					new SqlParameter("@Rent_IsSingleRoom", SqlDbType.Int,4),
					new SqlParameter("@Rent_IsWholeBuilding", SqlDbType.Int,4),
					new SqlParameter("@Rent_Start", SqlDbType.DateTime),
					new SqlParameter("@Rent_End", SqlDbType.DateTime),
					new SqlParameter("@Rent_Cover", SqlDbType.NVarChar,-1),
					new SqlParameter("@Rent_Images", SqlDbType.NVarChar,-1),
					new SqlParameter("@Rent_Address", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@Rent_Furniture", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_Pat", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_StreetPark", SqlDbType.Int,4),
					new SqlParameter("@Rent_Garage", SqlDbType.Int,4),
					new SqlParameter("@Rent_Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_Wechat", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_QQ", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_Email", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.Rent_ID;
			parameters[1].Value = model.Rent_Area;
			parameters[2].Value = model.Rent_Price;
			parameters[3].Value = model.Rent_IsSingleRoom;
			parameters[4].Value = model.Rent_IsWholeBuilding;
			parameters[5].Value = model.Rent_Start;
			parameters[6].Value = model.Rent_End;
			parameters[7].Value = model.Rent_Cover;
			parameters[8].Value = model.Rent_Images;
			parameters[9].Value = model.Rent_Address;
			parameters[10].Value = model.Rent_Description;
			parameters[11].Value = model.Rent_Furniture;
			parameters[12].Value = model.Rent_Pat;
			parameters[13].Value = model.Rent_StreetPark;
			parameters[14].Value = model.Rent_Garage;
			parameters[15].Value = model.Rent_Phone;
			parameters[16].Value = model.Rent_Wechat;
			parameters[17].Value = model.Rent_QQ;
			parameters[18].Value = model.Rent_Email;

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
		public bool Update(Maticsoft.Model.Tb_PostRent model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_PostRent set ");
			strSql.Append("Rent_Area=@Rent_Area,");
			strSql.Append("Rent_Price=@Rent_Price,");
			strSql.Append("Rent_IsSingleRoom=@Rent_IsSingleRoom,");
			strSql.Append("Rent_IsWholeBuilding=@Rent_IsWholeBuilding,");
			strSql.Append("Rent_Start=@Rent_Start,");
			strSql.Append("Rent_End=@Rent_End,");
			strSql.Append("Rent_Cover=@Rent_Cover,");
			strSql.Append("Rent_Images=@Rent_Images,");
			strSql.Append("Rent_Address=@Rent_Address,");
			strSql.Append("Rent_Description=@Rent_Description,");
			strSql.Append("Rent_Furniture=@Rent_Furniture,");
			strSql.Append("Rent_Pat=@Rent_Pat,");
			strSql.Append("Rent_StreetPark=@Rent_StreetPark,");
			strSql.Append("Rent_Garage=@Rent_Garage,");
			strSql.Append("Rent_Phone=@Rent_Phone,");
			strSql.Append("Rent_Wechat=@Rent_Wechat,");
			strSql.Append("Rent_QQ=@Rent_QQ,");
			strSql.Append("Rent_Email=@Rent_Email");
			strSql.Append(" where Rent_ID=@Rent_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Rent_Area", SqlDbType.Int,4),
					new SqlParameter("@Rent_Price", SqlDbType.Int,4),
					new SqlParameter("@Rent_IsSingleRoom", SqlDbType.Int,4),
					new SqlParameter("@Rent_IsWholeBuilding", SqlDbType.Int,4),
					new SqlParameter("@Rent_Start", SqlDbType.DateTime),
					new SqlParameter("@Rent_End", SqlDbType.DateTime),
					new SqlParameter("@Rent_Cover", SqlDbType.NVarChar,-1),
					new SqlParameter("@Rent_Images", SqlDbType.NVarChar,-1),
					new SqlParameter("@Rent_Address", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@Rent_Furniture", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_Pat", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_StreetPark", SqlDbType.Int,4),
					new SqlParameter("@Rent_Garage", SqlDbType.Int,4),
					new SqlParameter("@Rent_Phone", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_Wechat", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_QQ", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_Email", SqlDbType.NVarChar,50),
					new SqlParameter("@Rent_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Rent_Area;
			parameters[1].Value = model.Rent_Price;
			parameters[2].Value = model.Rent_IsSingleRoom;
			parameters[3].Value = model.Rent_IsWholeBuilding;
			parameters[4].Value = model.Rent_Start;
			parameters[5].Value = model.Rent_End;
			parameters[6].Value = model.Rent_Cover;
			parameters[7].Value = model.Rent_Images;
			parameters[8].Value = model.Rent_Address;
			parameters[9].Value = model.Rent_Description;
			parameters[10].Value = model.Rent_Furniture;
			parameters[11].Value = model.Rent_Pat;
			parameters[12].Value = model.Rent_StreetPark;
			parameters[13].Value = model.Rent_Garage;
			parameters[14].Value = model.Rent_Phone;
			parameters[15].Value = model.Rent_Wechat;
			parameters[16].Value = model.Rent_QQ;
			parameters[17].Value = model.Rent_Email;
			parameters[18].Value = model.Rent_ID;

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
		public bool Delete(int Rent_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostRent ");
			strSql.Append(" where Rent_ID=@Rent_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Rent_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Rent_ID;

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
		public bool DeleteList(string Rent_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostRent ");
			strSql.Append(" where Rent_ID in ("+Rent_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_PostRent GetModel(int Rent_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Rent_ID,Rent_Area,Rent_Price,Rent_IsSingleRoom,Rent_IsWholeBuilding,Rent_Start,Rent_End,Rent_Cover,Rent_Images,Rent_Address,Rent_Description,Rent_Furniture,Rent_Pat,Rent_StreetPark,Rent_Garage,Rent_Phone,Rent_Wechat,Rent_QQ,Rent_Email from Tb_PostRent ");
			strSql.Append(" where Rent_ID=@Rent_ID ");
			SqlParameter[] parameters = {
					new SqlParameter("@Rent_ID", SqlDbType.Int,4)			};
			parameters[0].Value = Rent_ID;

			Maticsoft.Model.Tb_PostRent model=new Maticsoft.Model.Tb_PostRent();
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
		public Maticsoft.Model.Tb_PostRent DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_PostRent model=new Maticsoft.Model.Tb_PostRent();
			if (row != null)
			{
				if(row["Rent_ID"]!=null && row["Rent_ID"].ToString()!="")
				{
					model.Rent_ID=int.Parse(row["Rent_ID"].ToString());
				}
				if(row["Rent_Area"]!=null && row["Rent_Area"].ToString()!="")
				{
					model.Rent_Area=int.Parse(row["Rent_Area"].ToString());
				}
				if(row["Rent_Price"]!=null && row["Rent_Price"].ToString()!="")
				{
					model.Rent_Price=int.Parse(row["Rent_Price"].ToString());
				}
				if(row["Rent_IsSingleRoom"]!=null && row["Rent_IsSingleRoom"].ToString()!="")
				{
					model.Rent_IsSingleRoom=int.Parse(row["Rent_IsSingleRoom"].ToString());
				}
				if(row["Rent_IsWholeBuilding"]!=null && row["Rent_IsWholeBuilding"].ToString()!="")
				{
					model.Rent_IsWholeBuilding=int.Parse(row["Rent_IsWholeBuilding"].ToString());
				}
				if(row["Rent_Start"]!=null && row["Rent_Start"].ToString()!="")
				{
					model.Rent_Start=DateTime.Parse(row["Rent_Start"].ToString());
				}
				if(row["Rent_End"]!=null && row["Rent_End"].ToString()!="")
				{
					model.Rent_End=DateTime.Parse(row["Rent_End"].ToString());
				}
				if(row["Rent_Cover"]!=null)
				{
					model.Rent_Cover=row["Rent_Cover"].ToString();
				}
				if(row["Rent_Images"]!=null)
				{
					model.Rent_Images=row["Rent_Images"].ToString();
				}
				if(row["Rent_Address"]!=null)
				{
					model.Rent_Address=row["Rent_Address"].ToString();
				}
				if(row["Rent_Description"]!=null)
				{
					model.Rent_Description=row["Rent_Description"].ToString();
				}
				if(row["Rent_Furniture"]!=null)
				{
					model.Rent_Furniture=row["Rent_Furniture"].ToString();
				}
				if(row["Rent_Pat"]!=null)
				{
					model.Rent_Pat=row["Rent_Pat"].ToString();
				}
				if(row["Rent_StreetPark"]!=null && row["Rent_StreetPark"].ToString()!="")
				{
					model.Rent_StreetPark=int.Parse(row["Rent_StreetPark"].ToString());
				}
				if(row["Rent_Garage"]!=null && row["Rent_Garage"].ToString()!="")
				{
					model.Rent_Garage=int.Parse(row["Rent_Garage"].ToString());
				}
				if(row["Rent_Phone"]!=null)
				{
					model.Rent_Phone=row["Rent_Phone"].ToString();
				}
				if(row["Rent_Wechat"]!=null)
				{
					model.Rent_Wechat=row["Rent_Wechat"].ToString();
				}
				if(row["Rent_QQ"]!=null)
				{
					model.Rent_QQ=row["Rent_QQ"].ToString();
				}
				if(row["Rent_Email"]!=null)
				{
					model.Rent_Email=row["Rent_Email"].ToString();
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
			strSql.Append("select Rent_ID,Rent_Area,Rent_Price,Rent_IsSingleRoom,Rent_IsWholeBuilding,Rent_Start,Rent_End,Rent_Cover,Rent_Images,Rent_Address,Rent_Description,Rent_Furniture,Rent_Pat,Rent_StreetPark,Rent_Garage,Rent_Phone,Rent_Wechat,Rent_QQ,Rent_Email ");
			strSql.Append(" FROM Tb_PostRent ");
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
			strSql.Append(" Rent_ID,Rent_Area,Rent_Price,Rent_IsSingleRoom,Rent_IsWholeBuilding,Rent_Start,Rent_End,Rent_Cover,Rent_Images,Rent_Address,Rent_Description,Rent_Furniture,Rent_Pat,Rent_StreetPark,Rent_Garage,Rent_Phone,Rent_Wechat,Rent_QQ,Rent_Email ");
			strSql.Append(" FROM Tb_PostRent ");
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
			strSql.Append("select count(1) FROM Tb_PostRent ");
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
				strSql.Append("order by T.Rent_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_PostRent T ");
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
			parameters[0].Value = "Tb_PostRent";
			parameters[1].Value = "Rent_ID";
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

