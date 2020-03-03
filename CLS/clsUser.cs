using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using cfvn.MDL;

namespace cfvn.CLS
{
	public class clsUser
	{
		/// <summary>
		/// 查找用戶是否存在:非空--存在;空--不存在        
		/// </summary>
		/// <param name="strUserID"></param>
		/// <returns>sqlserver=dgerp2</returns>
        private clsPublicOfVN clsApp = new clsPublicOfVN();
		public string IsExistUser(string userid)
		{
			string username = "";
			bool flag = true;
			if (userid == "")
			{
                MessageBox.Show("User account cannot be empty！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
				flag = false;
				username = "";
			}

			if (flag) //帳號是否為為空
			{
                string strSql = String.Format("Select user_id,user_name From dbo.sys_user Where user_id ='{0}' and typeid ='U'", userid);
				try
				{
                    DataTable dtUserInfo = clsApp.GetDataTable(strSql);
					if (dtUserInfo.Rows.Count > 0)
					{                        
						username = dtUserInfo.Rows[0]["user_name"].ToString();						
					}
					else
					{
                        MessageBox.Show("Incorrect account number！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
						username = "";
					}
				}
				catch (Exception ex)
				{
                    MessageBox.Show(ex.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
					username = "";
				}
			}
			else			
				username = "";			
			userid = username;
			return userid;
		}

		/// <summary>
		/// 登錄    
		/// </summary>
		/// <param name="strUserID">用戶帳號</param>
		/// <param name="strpassword">帳號密碼</param>
		/// <returns>sqlserver=dgerp2</returns>
		public bool GetUserInfo(string userid, string password)
		{
			bool result = false;
            if (string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password cannot be empty！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                result = false;
            }
            else
            {
                string strSql = String.Format("Select user_id,user_name,password,language,mis_date From dbo.sys_user Where user_id ='{0}' and typeid ='U'", userid);
                try
                {
                    DataTable dtUserInfo = clsApp.GetDataTable(strSql);
                    if (dtUserInfo.Rows.Count > 0)
                    {
                        if (DBUtility.GeoEncrypt(password) == dtUserInfo.Rows[0]["password"].ToString())
                        {
                            result = true;
                            DBUtility._language = dtUserInfo.Rows[0]["language"].ToString();   //2013-08-21更改
                        }
                        else
                        {
                            result = false;
                            MessageBox.Show("Incorrect password！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (!string.IsNullOrEmpty(dtUserInfo.Rows[0]["mis_date"].ToString()))
                        {
                            DateTime ts1 = Convert.ToDateTime(DateTime.Parse(dtUserInfo.Rows[0]["mis_date"].ToString()));
                            DateTime ts2 = Convert.ToDateTime(DateTime.Now.Date.ToString("yyyy/MM/dd"));                         
                            if (DateTime.Compare(ts1, ts2)<0) 
                            {
                                MessageBox.Show("Login date has expired！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                result = false;
                            }
                        }
                    }
                    else
                    {
                        result = false;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString(), "Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    result = false;
                }
            }
			return result;
		}

		/// <summary>
		///根据用户ID查询用户权限 
		/// </summary>
		/// <param name="UserId"></param>
		/// <param name="UserName"></param>
		/// <returns> sqlserver=dgerp2</returns>
		public DataTable GetUserById(string UserId, string UserName)
		{
			DataTable dt = new DataTable();

			string strSQL = "SELECT user_id AS Uname,user_name AS Uname_desc,password FROM  sys_user ";
			if (UserId != "")
			{
                strSQL += String.Format(" WHERE user_id LIKE '%{0}%'", UserId);
			}
			if (UserName != "")
			{
                strSQL += String.Format(" OR user_id LIKE '%{0}%'", UserName);
			}
			try
			{
                dt = clsApp.GetDataTable(strSQL);
			}
			catch (SqlException ex)
			{
				throw new Exception(ex.Message);
			}
			return dt;
		}

		/// <summary>
		/// 查詢用戶信息
		/// </summary>
		/// <param name="UserID"></param>
		/// <param name="UserName"></param>
		/// <returns>dgsql1</returns>
		public DataTable QueryUserInfo(string UserID, string UserName)
		{
			DataTable dt = new DataTable();

			string strSQL = @" SELECT A.Uid,A.Uname,A.Uname_desc,B.Rid,B.Rname ,
					(CASE WHEN A.language='0' THEN '繁體中文' WHEN A.language='1' THEN '簡體中文' 
						  WHEN A.language='2' THEN 'English' ELSE NULL END)AS Language " +
							 "FROM dbo.tb_sy_user A left join tb_sy_role B on A.rid = b.rid ";
			if (UserID != "" && UserName != "")
			{
				strSQL += " WHERE A.Uname LIKE " + "'%" + UserID + "%'";
				strSQL += " AND A.Uname_desc LIKE " + "'%" + UserName + "%'";
			}
			if (UserName != "" && UserID == "")
			{
				strSQL += " WHERE A.Uname_desc LIKE " + "'%" + UserName + "%'";
			}
			if (UserName == "" && UserID != "")
			{
				strSQL += " WHERE A.Uname LIKE " + "'%" + UserID + "%'";
			}
			try
			{
                dt = clsApp.GetDataTable(strSQL);
			}
			catch (SqlException ex)
			{
				throw new Exception(ex.Message);
			}
			return dt;

		}

		/// <summary>
		/// 添加新用戶
		/// </summary>
		/// <param name="modelUser"></param>
		/// <returns>dgsql1</returns>
		public int AddUserInfo(mdlUser modelUser)
		{
			int Result = -1;
			try
			{
				string strSQL = @"INSERT INTO tb_sy_user(Uname, Uname_desc, Pwd, Rid, language) VALUES (@Uname, @Uname_desc, @Pwd, @Rid, @language)";

				SqlParameter[] paras = new SqlParameter[] { 
                    new SqlParameter("@user_id",modelUser.user_id),
					new SqlParameter("@user_name",modelUser.user_name),					
					new SqlParameter("@password",modelUser.password),				
					new SqlParameter("@language",modelUser.language)
			   };

                Result = clsApp.ExecuteNonQuery(strSQL, paras, false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return Result;
		}

		/// <summary>
		/// 刪除用戶
		/// </summary>
		/// <param name="uid"></param>
		/// <returns>dgsql1</returns>
		public int DelUserInfo(int uid)
		{
			int Result = -1;
			try
			{
				string strSQL = "DELETE FROM sys_user WHERE user_id=@Uid ";
				SqlParameter[] paras = new SqlParameter[] { 
				   new SqlParameter("@Uid", uid)
				};

                Result = clsApp.ExecuteNonQuery(strSQL, paras, false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return Result;
		}

		/// <summary>
		/// 編輯用戶
		/// </summary>
		/// <param name="modelUser"></param>
		/// <returns>dgsql1</returns>
		public int UpdateUserInfo(mdlUser modelUser)
		{
			int Result = -1;
			try
			{
                string strSQL = @" UPDATE sys_user SET language=@language WHERE  user_id=@user_id AND Uname=@user_name";

				SqlParameter[] paras = new SqlParameter[] { 
					new SqlParameter("@user_id",modelUser.user_id),
					new SqlParameter("@user_name",modelUser.user_name),					
					new SqlParameter("@language",modelUser.language)
				};

                Result = clsApp.ExecuteNonQuery(strSQL, paras, false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return Result;
		}

		/// <summary>
		/// 變更用戶語言
		/// </summary>
		/// <param name="pLanguage"></param>
		/// <param name="pUname"></param>
		/// <returns>dgsql1</returns>
		public int UpdateUserLanguage(string pLanguage, string pUname)
		{
			int Result = -1;
			try
			{
				string strSQL = @" Update dbo.sys_user set language =@language  Where user_id=@user_id ";

				SqlParameter[] paras = new SqlParameter[] { 
					new SqlParameter("@user_id",pUname),
					new SqlParameter("@language",pLanguage)
				};

                Result = clsApp.ExecuteNonQuery(strSQL, paras, false);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return Result;
		}

		/// <summary>
		/// 判斷該用戶是否存在
		/// </summary>
		/// <param name="pUname"></param>
		/// <returns>dgsql1</returns>
		public bool IsExistForAdd(string pUname)
		{
			bool IsExist = true;
			try
			{
				string strSql = @"SELECT * FROM sys_user WHERE user_id='" + pUname + "' ";
                string strUname = clsApp.ExecuteSqlReturnObject(strSql);
				if (strUname.Length > 0)
				{
					IsExist = false;
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
			return IsExist;
		}

        public void Save_LoginInfo(string pUser_id,string pUser_name)
        {
            //保存用戶信息
            string strMachine_id = System.Environment.MachineName;            
            string strsql_f = string.Format("Select '1' From sys_login with(nolock) Where machine_id='{0}'", strMachine_id);
            string strsql_i = string.Format("INSERT INTO sys_login(machine_id,user_id,user_name) Values('{0}','{1}','{2}')", strMachine_id, pUser_id, pUser_name);
            string strsql_u = string.Format("Update sys_login SET user_id='{0}',user_name='{1}' Where machine_id='{2}'", pUser_id, pUser_name, strMachine_id);
            DataTable dt = clsApp.GetDataTable(strsql_f);           
            if (dt.Rows.Count == 0)
                clsApp.ExecuteSqlUpdate(strsql_i);
            else
                clsApp.ExecuteSqlUpdate(strsql_u);
            dt = null;
        }

        public string GetMachineName()
        {
            try
            {
                string strReturn = "";
                string strmac_id = System.Environment.MachineName;
                string strSql = @"Select user_id+'&'+user_name From sys_login Where machine_id='" + strmac_id + "'";
                strReturn = clsApp.ExecuteSqlReturnObject(strSql);               
                return strReturn;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString());
                return "";
            }
        }


	}
}
