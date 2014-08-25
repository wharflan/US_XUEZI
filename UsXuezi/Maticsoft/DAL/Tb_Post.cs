/**  版本信息模板在安装目录下，可自行修改。
* Tb_Post.cs
*
* 功 能： N/A
* 类 名： Tb_Post
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  7/31/2014 11:42:44 AM   N/A    初版
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
	/// 数据访问类:Tb_Post
	/// </summary>
	public partial class Tb_Post
	{
		public Tb_Post()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperSQL.GetMaxID("Post_ID", "Tb_Post"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Post_ID)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Tb_Post");
			strSql.Append(" where Post_ID=@Post_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Post_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Post_ID;

			return DbHelperSQL.Exists(strSql.ToString(),parameters);
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Maticsoft.Model.Tb_Post model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Tb_Post(");
			strSql.Append("Post_CityID,Post_OtherCity,Post_Visible,Post_Type,Post_UserID,Post_Title,Post_Click,Post_PostTime,Post_LastEditTime,Post_DefaultSort,Post_IsAnonymous)");
			strSql.Append(" values (");
			strSql.Append("@Post_CityID,@Post_OtherCity,@Post_Visible,@Post_Type,@Post_UserID,@Post_Title,@Post_Click,@Post_PostTime,@Post_LastEditTime,@Post_DefaultSort,@Post_IsAnonymous)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@Post_CityID", SqlDbType.Int,4),
					new SqlParameter("@Post_OtherCity", SqlDbType.Int,4),
					new SqlParameter("@Post_Visible", SqlDbType.Int,4),
					new SqlParameter("@Post_Type", SqlDbType.Int,4),
					new SqlParameter("@Post_UserID", SqlDbType.Int,4),
					new SqlParameter("@Post_Title", SqlDbType.NVarChar,50),
					new SqlParameter("@Post_Click", SqlDbType.Int,4),
					new SqlParameter("@Post_PostTime", SqlDbType.DateTime),
					new SqlParameter("@Post_LastEditTime", SqlDbType.DateTime),
					new SqlParameter("@Post_DefaultSort", SqlDbType.Int,4),
					new SqlParameter("@Post_IsAnonymous", SqlDbType.Int,4)};
			parameters[0].Value = model.Post_CityID;
			parameters[1].Value = model.Post_OtherCity;
			parameters[2].Value = model.Post_Visible;
			parameters[3].Value = model.Post_Type;
			parameters[4].Value = model.Post_UserID;
			parameters[5].Value = model.Post_Title;
			parameters[6].Value = model.Post_Click;
			parameters[7].Value = model.Post_PostTime;
			parameters[8].Value = model.Post_LastEditTime;
			parameters[9].Value = model.Post_DefaultSort;
			parameters[10].Value = model.Post_IsAnonymous;

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
		public bool Update(Maticsoft.Model.Tb_Post model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Tb_Post set ");
			strSql.Append("Post_CityID=@Post_CityID,");
			strSql.Append("Post_OtherCity=@Post_OtherCity,");
			strSql.Append("Post_Visible=@Post_Visible,");
			strSql.Append("Post_Type=@Post_Type,");
			strSql.Append("Post_UserID=@Post_UserID,");
			strSql.Append("Post_Title=@Post_Title,");
			strSql.Append("Post_Click=@Post_Click,");
			strSql.Append("Post_PostTime=@Post_PostTime,");
			strSql.Append("Post_LastEditTime=@Post_LastEditTime,");
			strSql.Append("Post_DefaultSort=@Post_DefaultSort,");
			strSql.Append("Post_IsAnonymous=@Post_IsAnonymous");
			strSql.Append(" where Post_ID=@Post_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Post_CityID", SqlDbType.Int,4),
					new SqlParameter("@Post_OtherCity", SqlDbType.Int,4),
					new SqlParameter("@Post_Visible", SqlDbType.Int,4),
					new SqlParameter("@Post_Type", SqlDbType.Int,4),
					new SqlParameter("@Post_UserID", SqlDbType.Int,4),
					new SqlParameter("@Post_Title", SqlDbType.NVarChar,50),
					new SqlParameter("@Post_Click", SqlDbType.Int,4),
					new SqlParameter("@Post_PostTime", SqlDbType.DateTime),
					new SqlParameter("@Post_LastEditTime", SqlDbType.DateTime),
					new SqlParameter("@Post_DefaultSort", SqlDbType.Int,4),
					new SqlParameter("@Post_IsAnonymous", SqlDbType.Int,4),
					new SqlParameter("@Post_ID", SqlDbType.Int,4)};
			parameters[0].Value = model.Post_CityID;
			parameters[1].Value = model.Post_OtherCity;
			parameters[2].Value = model.Post_Visible;
			parameters[3].Value = model.Post_Type;
			parameters[4].Value = model.Post_UserID;
			parameters[5].Value = model.Post_Title;
			parameters[6].Value = model.Post_Click;
			parameters[7].Value = model.Post_PostTime;
			parameters[8].Value = model.Post_LastEditTime;
			parameters[9].Value = model.Post_DefaultSort;
			parameters[10].Value = model.Post_IsAnonymous;
			parameters[11].Value = model.Post_ID;

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
		public bool Delete(int Post_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Post ");
			strSql.Append(" where Post_ID=@Post_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Post_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Post_ID;

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
		public bool DeleteList(string Post_IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Tb_Post ");
			strSql.Append(" where Post_ID in ("+Post_IDlist + ")  ");
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
		public Maticsoft.Model.Tb_Post GetModel(int Post_ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 Post_ID,Post_CityID,Post_OtherCity,Post_Visible,Post_Type,Post_UserID,Post_Title,Post_Click,Post_PostTime,Post_LastEditTime,Post_DefaultSort,Post_IsAnonymous from Tb_Post ");
			strSql.Append(" where Post_ID=@Post_ID");
			SqlParameter[] parameters = {
					new SqlParameter("@Post_ID", SqlDbType.Int,4)
			};
			parameters[0].Value = Post_ID;

			Maticsoft.Model.Tb_Post model=new Maticsoft.Model.Tb_Post();
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
		public Maticsoft.Model.Tb_Post DataRowToModel(DataRow row)
		{
			Maticsoft.Model.Tb_Post model=new Maticsoft.Model.Tb_Post();
			if (row != null)
			{
				if(row["Post_ID"]!=null && row["Post_ID"].ToString()!="")
				{
					model.Post_ID=int.Parse(row["Post_ID"].ToString());
				}
				if(row["Post_CityID"]!=null && row["Post_CityID"].ToString()!="")
				{
					model.Post_CityID=int.Parse(row["Post_CityID"].ToString());
				}
				if(row["Post_OtherCity"]!=null && row["Post_OtherCity"].ToString()!="")
				{
					model.Post_OtherCity=int.Parse(row["Post_OtherCity"].ToString());
				}
				if(row["Post_Visible"]!=null && row["Post_Visible"].ToString()!="")
				{
					model.Post_Visible=int.Parse(row["Post_Visible"].ToString());
				}
				if(row["Post_Type"]!=null && row["Post_Type"].ToString()!="")
				{
					model.Post_Type=int.Parse(row["Post_Type"].ToString());
				}
				if(row["Post_UserID"]!=null && row["Post_UserID"].ToString()!="")
				{
					model.Post_UserID=int.Parse(row["Post_UserID"].ToString());
				}
				if(row["Post_Title"]!=null)
				{
					model.Post_Title=row["Post_Title"].ToString();
				}
				if(row["Post_Click"]!=null && row["Post_Click"].ToString()!="")
				{
					model.Post_Click=int.Parse(row["Post_Click"].ToString());
				}
				if(row["Post_PostTime"]!=null && row["Post_PostTime"].ToString()!="")
				{
					model.Post_PostTime=DateTime.Parse(row["Post_PostTime"].ToString());
				}
				if(row["Post_LastEditTime"]!=null && row["Post_LastEditTime"].ToString()!="")
				{
					model.Post_LastEditTime=DateTime.Parse(row["Post_LastEditTime"].ToString());
				}
				if(row["Post_DefaultSort"]!=null && row["Post_DefaultSort"].ToString()!="")
				{
					model.Post_DefaultSort=int.Parse(row["Post_DefaultSort"].ToString());
				}
				if(row["Post_IsAnonymous"]!=null && row["Post_IsAnonymous"].ToString()!="")
				{
					model.Post_IsAnonymous=int.Parse(row["Post_IsAnonymous"].ToString());
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
			strSql.Append("select Post_ID,Post_CityID,Post_OtherCity,Post_Visible,Post_Type,Post_UserID,Post_Title,Post_Click,Post_PostTime,Post_LastEditTime,Post_DefaultSort,Post_IsAnonymous ");
			strSql.Append(" FROM Tb_Post ");
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
			strSql.Append(" Post_ID,Post_CityID,Post_OtherCity,Post_Visible,Post_Type,Post_UserID,Post_Title,Post_Click,Post_PostTime,Post_LastEditTime,Post_DefaultSort,Post_IsAnonymous ");
			strSql.Append(" FROM Tb_Post ");
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
			strSql.Append("select count(1) FROM Tb_Post ");
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
				strSql.Append("order by T.Post_ID desc");
			}
			strSql.Append(")AS Row, T.*  from Tb_Post T ");
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
			parameters[0].Value = "Tb_Post";
			parameters[1].Value = "Post_ID";
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

