/**  版本信息模板在安装目录下，可自行修改。
* Tb_PostItem.cs
*
* 功 能： N/A
* 类 名： Tb_PostItem
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  8/18/2014 6:25:24 PM   N/A    初版
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
	/// 数据访问类:Tb_PostItem
	/// </summary>
	public partial class Tb_PostItem
	{
		public Tb_PostItem()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Item_ID", "Tb_PostItem"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Item_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_PostItem");
			strSql.Append(" where Item_ID=@Item_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Item_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Item_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_PostItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_PostItem(");
			strSql.Append("Item_Post_ID,Item_Name,Item_Price,Item_IsSelf,Item_IsMailed,Item_Type,Item_Status,Item_Images,Item_Description,Item_Cover,Item_Phone,Item_Wechat,Item_QQ,Item_Email)");
			strSql.Append(" values (");
			strSql.Append("@Item_Post_ID,@Item_Name,@Item_Price,@Item_IsSelf,@Item_IsMailed,@Item_Type,@Item_Status,@Item_Images,@Item_Description,@Item_Cover,@Item_Phone,@Item_Wechat,@Item_QQ,@Item_Email)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Item_Post_ID", SqlDbType.Int,4),
					new SqlParameter("@Item_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Item_Price", SqlDbType.Int,4),
					new SqlParameter("@Item_IsSelf", SqlDbType.Int,4),
					new SqlParameter("@Item_IsMailed", SqlDbType.Int,4),
					new SqlParameter("@Item_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Item_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Item_Images", SqlDbType.VarChar,-1),
					new SqlParameter("@Item_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@Item_Cover", SqlDbType.NVarChar,-1),
					new SqlParameter("@Item_Phone", SqlDbType.NVarChar,-1),
					new SqlParameter("@Item_Wechat", SqlDbType.NVarChar,-1),
					new SqlParameter("@Item_QQ", SqlDbType.NVarChar,-1),
					new SqlParameter("@Item_Email", SqlDbType.NVarChar,-1)};
			parameters[0].Value = model.Item_Post_ID;
			parameters[1].Value = model.Item_Name;
			parameters[2].Value = model.Item_Price;
			parameters[3].Value = model.Item_IsSelf;
			parameters[4].Value = model.Item_IsMailed;
			parameters[5].Value = model.Item_Type;
			parameters[6].Value = model.Item_Status;
			parameters[7].Value = model.Item_Images;
			parameters[8].Value = model.Item_Description;
			parameters[9].Value = model.Item_Cover;
			parameters[10].Value = model.Item_Phone;
			parameters[11].Value = model.Item_Wechat;
			parameters[12].Value = model.Item_QQ;
			parameters[13].Value = model.Item_Email;

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
		public bool Update(Maticsoft.Model.Tb_PostItem model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_PostItem set ");
			strSql.Append("Item_Post_ID=@Item_Post_ID,");
			strSql.Append("Item_Name=@Item_Name,");
			strSql.Append("Item_Price=@Item_Price,");
			strSql.Append("Item_IsSelf=@Item_IsSelf,");
			strSql.Append("Item_IsMailed=@Item_IsMailed,");
			strSql.Append("Item_Type=@Item_Type,");
			strSql.Append("Item_Status=@Item_Status,");
			strSql.Append("Item_Images=@Item_Images,");
			strSql.Append("Item_Description=@Item_Description,");
			strSql.Append("Item_Cover=@Item_Cover,");
			strSql.Append("Item_Phone=@Item_Phone,");
			strSql.Append("Item_Wechat=@Item_Wechat,");
			strSql.Append("Item_QQ=@Item_QQ,");
			strSql.Append("Item_Email=@Item_Email");
			strSql.Append(" where Item_ID=@Item_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Item_Post_ID", SqlDbType.Int,4),
					new SqlParameter("@Item_Name", SqlDbType.NVarChar,50),
					new SqlParameter("@Item_Price", SqlDbType.Int,4),
					new SqlParameter("@Item_IsSelf", SqlDbType.Int,4),
					new SqlParameter("@Item_IsMailed", SqlDbType.Int,4),
					new SqlParameter("@Item_Type", SqlDbType.NVarChar,50),
					new SqlParameter("@Item_Status", SqlDbType.NVarChar,50),
					new SqlParameter("@Item_Images", SqlDbType.VarChar,-1),
					new SqlParameter("@Item_Description", SqlDbType.NVarChar,-1),
					new SqlParameter("@Item_Cover", SqlDbType.NVarChar,-1),
					new SqlParameter("@Item_Phone", SqlDbType.NVarChar,-1),
					new SqlParameter("@Item_Wechat", SqlDbType.NVarChar,-1),
					new SqlParameter("@Item_QQ", SqlDbType.NVarChar,-1),
					new SqlParameter("@Item_Email", SqlDbType.NVarChar,-1),
					new SqlParameter("@Item_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Item_Post_ID;
			parameters[1].Value = model.Item_Name;
			parameters[2].Value = model.Item_Price;
			parameters[3].Value = model.Item_IsSelf;
			parameters[4].Value = model.Item_IsMailed;
			parameters[5].Value = model.Item_Type;
			parameters[6].Value = model.Item_Status;
			parameters[7].Value = model.Item_Images;
			parameters[8].Value = model.Item_Description;
			parameters[9].Value = model.Item_Cover;
			parameters[10].Value = model.Item_Phone;
			parameters[11].Value = model.Item_Wechat;
			parameters[12].Value = model.Item_QQ;
			parameters[13].Value = model.Item_Email;
			parameters[14].Value = model.Item_ID;

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
		public bool Delete(int Item_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostItem ");
			strSql.Append(" where Item_ID=@Item_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Item_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Item_ID;

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
		public bool DeleteList(string Item_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_PostItem ");
			strSql.Append(" where Item_ID in ("+Item_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_PostItem GetModel(int Item_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Item_ID,Item_Post_ID,Item_Name,Item_Price,Item_IsSelf,Item_IsMailed,Item_Type,Item_Status,Item_Images,Item_Description,Item_Cover,Item_Phone,Item_Wechat,Item_QQ,Item_Email from Tb_PostItem ");
			strSql.Append(" where Item_ID=@Item_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Item_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Item_ID;

			Maticsoft.Model.Tb_PostItem model=new Maticsoft.Model.Tb_PostItem();
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
		public Maticsoft.Model.Tb_PostItem DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_PostItem model=new Maticsoft.Model.Tb_PostItem();
			if (row != null)
			{
				if(row["Item_ID"]!=null && row["Item_ID"].ToString()!="")
				{
					model.Item_ID=int.Parse(row["Item_ID"].ToString());
				}
				if(row["Item_Post_ID"]!=null && row["Item_Post_ID"].ToString()!="")
				{
					model.Item_Post_ID=int.Parse(row["Item_Post_ID"].ToString());
				}
				if(row["Item_Name"]!=null)
				{
					model.Item_Name=row["Item_Name"].ToString();
				}
				if(row["Item_Price"]!=null && row["Item_Price"].ToString()!="")
				{
					model.Item_Price=int.Parse(row["Item_Price"].ToString());
				}
				if(row["Item_IsSelf"]!=null && row["Item_IsSelf"].ToString()!="")
				{
					model.Item_IsSelf=int.Parse(row["Item_IsSelf"].ToString());
				}
				if(row["Item_IsMailed"]!=null && row["Item_IsMailed"].ToString()!="")
				{
					model.Item_IsMailed=int.Parse(row["Item_IsMailed"].ToString());
				}
				if(row["Item_Type"]!=null)
				{
					model.Item_Type=row["Item_Type"].ToString();
				}
				if(row["Item_Status"]!=null)
				{
					model.Item_Status=row["Item_Status"].ToString();
				}
				if(row["Item_Images"]!=null)
				{
					model.Item_Images=row["Item_Images"].ToString();
				}
				if(row["Item_Description"]!=null)
				{
					model.Item_Description=row["Item_Description"].ToString();
				}
				if(row["Item_Cover"]!=null)
				{
					model.Item_Cover=row["Item_Cover"].ToString();
				}
				if(row["Item_Phone"]!=null)
				{
					model.Item_Phone=row["Item_Phone"].ToString();
				}
				if(row["Item_Wechat"]!=null)
				{
					model.Item_Wechat=row["Item_Wechat"].ToString();
				}
				if(row["Item_QQ"]!=null)
				{
					model.Item_QQ=row["Item_QQ"].ToString();
				}
				if(row["Item_Email"]!=null)
				{
					model.Item_Email=row["Item_Email"].ToString();
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
			strSql.Append("select Item_ID,Item_Post_ID,Item_Name,Item_Price,Item_IsSelf,Item_IsMailed,Item_Type,Item_Status,Item_Images,Item_Description,Item_Cover,Item_Phone,Item_Wechat,Item_QQ,Item_Email ");
			strSql.Append(" FROM Tb_PostItem ");
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
			strSql.Append(" Item_ID,Item_Post_ID,Item_Name,Item_Price,Item_IsSelf,Item_IsMailed,Item_Type,Item_Status,Item_Images,Item_Description,Item_Cover,Item_Phone,Item_Wechat,Item_QQ,Item_Email ");
			strSql.Append(" FROM Tb_PostItem ");
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
			strSql.Append("select count(1) FROM Tb_PostItem ");
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
				strSql.Append("order by T.Item_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_PostItem T ");
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
			parameters[0].Value = "Tb_PostItem";
			parameters[1].Value = "Item_ID";
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

