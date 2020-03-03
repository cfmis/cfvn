using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace cfvn.CLS
{
    public static class clsArtwork
    {
        private static clsPublicOfVN clsApp = new clsPublicOfVN();


        public static bool Check_Serial_No(string serial_no)
        {
            bool isExists;
            string strSql = string.Format(@"Select '1' From levelall WHERE serial_no='{0}'",serial_no);
            if (clsApp.ExecuteSqlReturnObject(strSql) != "")
            {
                isExists = true;
            }
            else
            {
                isExists = false;
            }
            return isExists;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="ls_field_value">key value</param>
        /// <param name="ls_field_type">is finded Key field</param>
        /// <returns></returns>
        public static bool Is_Used_in_mm_master(string ls_field_value, string ls_field_type)
        {
            string ls_field = "";
            switch (ls_field_type)
            {
                case "datum"://material type
                    ls_field = "datum";
                    break;
                case "base_class"://Product type
                    ls_field = "base_class";
                    break;
                case "blueprint_id"://Artwork code
                    ls_field = "blueprint_id";
                    break;
                case "size_id"://Size id
                    ls_field = "size_id";
                    break; 
                case "color"://Color id
                    ls_field = "color";
                    break;
                default :
                    break ;
            }
            bool result = false;
            if (ls_field == "")
            {
                if (clsApp.ExecuteSqlReturnObject(string.Format("select '1' from dbo.it_goods with(nolock) where {0}='{1}'", ls_field, ls_field_value)) == "")
                    result = false;
                else
                    result = true;
            }
            return result;
        }

        public static DataTable Return_mat_type()
        {
            string ls_sql;
            if (DBUtility._language == "2")
                ls_sql = "SELECT id,english_name as name FROM bs_mat_type WHERE state<>'2'";
            else
                ls_sql = "SELECT id,name FROM bs_mat_type WHERE state<>'2'";
            DataTable dt = clsApp.GetDataTable(ls_sql);
            return dt;
        }

        public static DataTable Return_product_type()
        {
            string ls_sql;
            if (DBUtility._language == "2")
                ls_sql = "SELECT id,english_name as name FROM bs_product_type WHERE state<>'2'";
            else
                ls_sql = "SELECT id,name FROM bs_product_type WHERE state<>'2'";
            DataTable dt = clsApp.GetDataTable(ls_sql);
            return dt;
        }

        public static DataTable Return_size_range()
        {
            string ls_sql;
            if (DBUtility._language == "2")
                ls_sql = "Select id,english_name as name FROM dbo.cd_size_range WHERE state<>'2'";
            else
                ls_sql = "Select id,name FROM dbo.cd_size_range WHERE state<>'2'";
            DataTable dt = clsApp.GetDataTable(ls_sql);
            return dt;
        }

        /// <summary>
        /// 回樣類型
        /// </summary>
        /// <returns></returns>
        public static DataTable Return_cd_acus()
        {
            string ls_sql;
            if (DBUtility._language == "2")
                ls_sql = "SELECT id,english_name as name FROM cd_acus WHERE state<>'2'";
            else
                ls_sql = "SELECT id,name FROM cd_acus WHERE state<>'2'";
            DataTable dt = clsApp.GetDataTable(ls_sql);
            return dt;
        }

       

        //public static string GetDocNo() //取最大單據編號
        //{
        //    string strYear = clsPublicOfCF01.ExecuteSqlReturnObject("Select substring(convert(varchar(10),GETDATE(),120),1,4)");
        //    string strDoc = String.Format("{0}{1}", strArea, strYear);
        //    string strSeq;
        //    string strMaxSeq;
        //    DataTable dtMaxSeq = new DataTable();
        //    dtMaxSeq = clsPublicOfCF01.GetDataTable(String.Format("SELECT MAX(id) as id FROM dbo.quotation_mostly WHERE id LIKE '{0}%'", strDoc));
        //    if (String.IsNullOrEmpty(dtMaxSeq.Rows[0]["id"].ToString()))
        //    {
        //        strSeq = "000001";
        //    }
        //    else
        //    {
        //        strMaxSeq = dtMaxSeq.Rows[0]["id"].ToString();
        //        strSeq = strMaxSeq.Substring(strMaxSeq.Length - 6);
        //        strSeq = (Convert.ToInt32(strSeq) + 1).ToString("000000");
        //    }
        //    strMaxSeq = strDoc + strSeq;
        //    txtID.Text = strMaxSeq;
        //}
    }
}
