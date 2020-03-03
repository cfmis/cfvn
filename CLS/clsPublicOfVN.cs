using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace cfvn.CLS
{
    public class clsPublicOfVN
    {

        private String strConn = DBUtility.ConnectionString;
    
        public int GenNo(string gen_id)
        {
            int gen_no = 0;
            DataTable dtGenNo = GetDataTable(String.Format("Select gen_no from gen_no where gen_id='{0}'", gen_id));
            if (dtGenNo.Rows.Count > 0)
            {
                if (updGenNo(1, gen_id) > 0)
                    gen_no = (int)dtGenNo.Rows[0]["gen_no"];
                else
                    gen_no = 0;
            }
            else
            {
                if (updGenNo(0, gen_id) > 0)
                    gen_no = 1;
                else
                    gen_no = 0;
            }
            return gen_no;
        }

        private int updGenNo(int upd_type, string gen_id)
        {
            int Result = 0;
            try
            {
                string strSql = "";
                if (upd_type == 1)
                    strSql = "Update gen_no Set gen_no=gen_no+1 Where gen_id=@gen_id";
                else
                    strSql = "Insert Into gen_no (gen_id,gen_no) Values (@gen_id,2)";

                SqlParameter[] paras = new SqlParameter[]{
                   new SqlParameter("@gen_id",gen_id)
                };

                Result = ExecuteNonQuery(strSql, paras, false);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Result;
        }

        /// <summary>
        /// 執行SQL，返回 DataTable 類型
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTable(string strSQL)
        {
            DataTable dtData = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    using (SqlDataAdapter da = new SqlDataAdapter(strSQL, conn))
                    {
                        da.Fill(dtData);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dtData;
        }

        /// <summary>
        /// 執行存儲過程返回DataTable
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public DataTable ExecuteProcedureReturnTable(string strSql, SqlParameter[] paras)
        {
            DataTable dtData = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand() { 
                        Connection = conn, 
                        CommandText = strSql, 
                        CommandType = CommandType.StoredProcedure 
                    };
                    cmd.Parameters.AddRange(paras);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dtData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dtData;
        }

        /// <summary>
        /// 執行存儲過程，返回DataSet
        /// </summary>
        /// <param name="proce"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public DataSet ExecuteProcedureReturnDataSet(string proce, SqlParameter[] paras, string TableName)
        {
            DataSet ds = new DataSet();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand() { 
                        Connection = conn, 
                        CommandType = CommandType.StoredProcedure, 
                        CommandText = proce 
                    };
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);
                    }
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    if (!string.IsNullOrEmpty(TableName))
                    {
                        sda.Fill(ds, TableName);
                    }
                    else
                    {
                        sda.Fill(ds);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ds;
        }

        /// <summary>
        /// 執行sql 語句或存儲過程，返回結果 int 
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="paras"></param>
        /// <param name="isProce"></param>
        /// <returns></returns>
        public int ExecuteNonQuery(string strSql, SqlParameter[] paras, bool isProce)
        {
            int Result = 0;
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand() { Connection = conn, CommandText = strSql };
                    if (paras != null)
                    {
                        cmd.Parameters.AddRange(paras);
                    }
                    if (isProce)
                    {
                        cmd.CommandType = CommandType.StoredProcedure;
                    }
                    Result = cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return Result;
        }

        /// <summary>
        /// 執行SQL 語句，返回string
        /// </summary>
        /// <param name="strSQL"></param>
        /// <returns></returns>
        public String ExecuteSqlReturnObject(string strSQL)
        {
            string objStrValue = "";
            try
            {
                DataTable dts = GetDataTable(strSQL);
                if (dts.Rows.Count > 0)
                {
                    objStrValue = dts.Rows[0][0].ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return objStrValue;
        }

        /// <summary>
        ///執行Sql語句，返回DataSet 
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="TableName"></param>
        /// <returns></returns>
        public DataSet ExcuteSqlReturnDataSet(string strSql, string TableName)
        {
            SqlConnection m_Conn = null;
            DataSet ds = new DataSet();
            try
            {
                m_Conn = new SqlConnection(strConn);
            }
            catch (Exception er)
            {
                throw er;
            }
            try
            {
                SqlDataAdapter sda = new SqlDataAdapter(strSql, m_Conn);
                if (!string.IsNullOrEmpty(TableName))
                {
                    sda.Fill(ds, TableName);
                }
                else
                {
                    sda.Fill(ds);
                }
            }
            catch (Exception er)
            {
                throw er;
            }
            m_Conn.Close();
            return ds;
        }

        //執行SQL語句
        public int ExecuteSqlUpdate(string strSql)
        {
            int Result_str =0;
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand() { Connection = conn, CommandText = strSql };
                Result_str=cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//
            }
            return Result_str;
        }

        
        /// <summary>
        /// 執行SQL，返回 dataTable 類型
        /// </summary>
        /// <returns></returns>
        public DataTable ExecuteSqlReturnDataTable(string strSQL)
        {
            DataTable dtData = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    SqlDataAdapter sda = new SqlDataAdapter(strSQL, conn);
                    sda.Fill(dtData);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            return dtData;
        }

        /// <summary>
        ///執行存儲過程，返回dataTable 
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public DataTable ExecuteProcedure(string strSql, SqlParameter[] paras)
        {
            DataTable dtData = new DataTable();
            try
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    SqlCommand cmd = new SqlCommand() { 
                        Connection = conn, 
                        CommandText = strSql, 
                        CommandType = CommandType.StoredProcedure 
                    };
                    cmd.Parameters.AddRange(paras);
                    SqlDataAdapter sda = new SqlDataAdapter(cmd);
                    sda.Fill(dtData);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return dtData;
        }
    }
}
