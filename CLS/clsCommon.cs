using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace cfvn.CLS
{

   public class clsCommon
    {
       private static clsPublicOfVN clsApp = new clsPublicOfVN();
       readonly MsgInfo myMsg = new MsgInfo();
       public static DataTable Get_All_User()
       {
           string strSql = @"Select user_id,user_name,group_id From sys_user ORDER BY user_id";           
           DataTable dtUser = clsApp.GetDataTable(strSql);
           return dtUser;
       }

       public static bool Is_Allow_Edit_Data(string bill_type, string current_data)
       {
           bool flag;
           string strSql = string.Format(@"SELECT dbo.fn_modify_time_limit('{0}','{1}')", bill_type, current_data);
           if (clsApp.ExecuteSqlReturnObject(strSql) == "Y")
           {
               flag = true;
           }
           else
           {
               flag = false;
           }
           return flag;
       }

       public static void ConfirmSatus(System.Windows.Forms.ToolStripButton objButton,DevExpress.XtraEditors.LookUpEdit objState)
       {
           string ls_confirm_c = "", ls_unconfirm_c = "";
           const string ls_confirm_e = "Confirm",ls_unconfirm_e = "UnConfirm";           
           if (DBUtility._language != "2")
           {
               ls_confirm_c = DBUtility._language == "1" ? "批准" : "批準";
               ls_unconfirm_c = DBUtility._language == "1" ? "反批准" : "反批準";
           }
           
           if (objState.EditValue.ToString() == "0")
           {
               //反批準成功后按鈕的顯示               
               objButton.Image = objButton.Image = Properties.Resources.p_ok;
               objButton.Text = DBUtility._language == "2" ? ls_confirm_e : ls_confirm_c;//批準成功后按鈕顯示“反批準”字樣
           }
           else
           {
               //批準成功后按鈕的顯示              
               objButton.Image = objButton.Image = Properties.Resources.p_unok;
               objButton.Text = DBUtility._language == "2" ? ls_unconfirm_e : ls_unconfirm_c;
           }
       }

       public static bool CheckCurrentOperation(string ls_status)
       {
           string msg_is_cancel, msg_is_confirm ; 
           if (DBUtility._language == "2")
           {
               msg_is_cancel = "Cannot be edited because the current status is cancel.";
               msg_is_confirm = "Cannot be edited because the current status is Confirm";
           }
           else
           {
               msg_is_cancel = DBUtility._language == "1" ? "当前记录为注销状态，操作无效！" : "當前記錄為註銷狀態，操作無效！";
               msg_is_confirm = DBUtility._language == "1" ? "当前记录为批准状态，操作无效！" : "當前記錄為批準狀態，操作無效！";
           }
           
           bool lb_resault = true;
           if (ls_status == "2")
           {
               //註銷狀態，不可編輯
               MessageBox.Show(msg_is_cancel, "System Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               lb_resault = false;
           }
           if (ls_status == "1")
           {
               //批準狀態，不可編輯
               MessageBox.Show(msg_is_confirm, "System Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               lb_resault = false;
           }
           return lb_resault;
       }

        public static string Get_Bill_Prefix(string ls_module)
        {
            string ls_result = clsApp.ExecuteSqlReturnObject(string.Format(@"SELECT fixation_value_1 FROM sys_bill_rule WHERE bill_id = '{0}'", ls_module));            
            return ls_result;
        }

       /// <summary>
       /// 取年份(yyyy)
       /// </summary>
       /// <returns></returns>
       public static string getYear()
       {
           string ls_year= clsApp.ExecuteSqlReturnObject("Select Substring(Convert(varchar(10),GETDATE(),112),1,4)");           
           return ls_year;
       }

       /// <summary>
       /// 取年月份(yymm)
       /// </summary>
       /// <returns></returns>
       public static string getYearMonth()
       {
           string ls_year_month= clsApp.ExecuteSqlReturnObject("Select SUBSTRING(Convert(varchar(10),GETDATE(),112),3,4)");
           return ls_year_month;
       }

       /// <summary>
       /// 返回標題翻譯
       /// </summary>
       /// <param name="ls_title"></param>
       /// <returns></returns>
       public static string GetTitle(string ls_title)
       {
           string ls_result = clsApp.ExecuteSqlReturnObject(string.Format("Select col_name From dbo.sys_dictionary where col_code='{0}' and  language_id='{1}'",ls_title,DBUtility._language));
           return ls_result;
       }

        /// <summary>
        /// //主建值是否已存在
        /// </summary>
        /// <param name="ls_sql"></param>
        /// <returns></returns>
        public static bool Valid_Doc(string ls_sql) 
        {
           bool flag;           
           if (!string.IsNullOrEmpty(clsApp.ExecuteSqlReturnObject(ls_sql)))
           {
               MessageBox.Show(GetTitle("t_msg_is_exists_key"),"System Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
               flag = true;
           }
           else
           {
               flag = false;
           }
           return flag;
        }

        /// <summary>
        /// 供應商資料
        /// </summary>
        /// <returns></returns>
        public static DataTable GetVendor()
        {
            DataTable dt = clsApp.GetDataTable(@"SELECT id,name From bs_vendor Where state='1' ORDER BY id");
            return dt;
        }

        /// <summary>
        /// 開單來源
        /// </summary>
        /// <returns></returns>
        public static DataTable Get_Bill_Origin(string bill_type)
        {
            DataTable dt = clsApp.GetDataTable(
            string.Format(@"SELECT id,name FROM sys_bill_origin WHERE function_id='{0}' AND language ='{1}' order by id", bill_type, DBUtility._language));
            return dt;
        }

        /// <summary>
        /// 開單類型
        /// </summary>
        /// <returns></returns>
        public static DataTable Get_Bill_Type(string bill_id)
        {
            DataTable dt = clsApp.GetDataTable(
            string.Format(@"Select id,name From dbo.sy_bill_type Where function_id='{0}' AND language_id='{1}' order by id",bill_id,DBUtility._language));
            return dt;
        }

        /// <summary>
        /// 幣種資料
        /// </summary>
        /// <returns></returns>
        public static DataTable Get_Money()
        {
            const string ls_sql =
                 @"SELECT M.id,M.name,M.english_name,S2.sequence_id
                FROM bs_money M INNER JOIN 
                (
                SELECT A.sequence_id,A.exchange_rate,A.id AS money_id
                FROM dbo.bs_exchange_rate A 
                INNER JOIN (SELECT id,MAX(days) AS days FROM dbo.bs_exchange_rate GROUP BY id) S
	                ON A.id=S.id and A.days=S.days 
                ) S2 ON M.id=S2.money_id
                ORDER BY M.id";
            DataTable dt = clsApp.GetDataTable(ls_sql);
            return dt;
        }

        /// <summary>
        /// 幣種匯率
        /// </summary>
        /// <returns></returns>
        public static DataTable Get_Money_Rate()
        {
            const string ls_sql =
                @"SELECT A.sequence_id as id,A.exchange_rate,A.id AS money_id
                FROM dbo.bs_exchange_rate A 
                INNER JOIN (SELECT id,MAX(days) AS days FROM dbo.bs_exchange_rate GROUP BY id) S
	                ON A.id=S.id and A.days=S.days 
                ORDER BY A.id";
            DataTable dt = clsApp.GetDataTable(ls_sql);
            return dt;
        }

        /// <summary>
        /// 數量、重量 單位
        /// </summary>
        /// <returns></returns>
        public static DataTable GetUnitAll()
        {
            DataTable dtUnit = clsApp.GetDataTable(
            @"SELECT S.* FROM (select '' as id,'05' as kind Union select id, kind from dbo.bs_unit where kind in('05','03')) S ORDER BY S.kind DESC,S.id ASC");
            return dtUnit;
        }

        /// <summary>
        /// 數量單位
        /// </summary>
        /// <returns></returns>
        public static DataTable GetUnit()
        {
            DataTable dtUnit = clsApp.GetDataTable(
            @"SELECT S.* FROM (select '' as id Union select id from dbo.bs_unit where kind='05' ) S ORDER BY S.id ASC");
            return dtUnit;
        }

        
        /// <summary>
        /// 重量單位
        /// </summary>
        /// <returns></returns>
        public static DataTable GetSecUnit()
        {
            DataTable dtSecUnit = clsApp.GetDataTable(@"SELECT id FROM dbo.bs_unit WHERE kind='03' ORDER BY id");
            return dtSecUnit;
        }
        /// <summary>
        /// 附加費ID
        /// </summary>
        /// <returns></returns>
        public static DataTable Get_Fare_id()
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT id,english_name as name FROM dbo.bs_tack_fare where use_buy ='1' order by id";
            }
            else
            {
                strsql = @"SELECT id,name FROM dbo.bs_tack_fare where use_buy ='1' order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            return dt;
        }


        /// <summary>
        /// 設置供應商下拉列表框
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="lang"></param>
        public static void Set_Vendor(DevExpress.XtraEditors.LookUpEdit obj, string lang)
        {
            string ls_sql = "";
            if (lang == "2")
            {
                //英文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,english_name FROM dbo.bs_vendor with(nolock) WHERE state<>'2') S order by S.id";
            }
            else
            {
                //中文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,name FROM dbo.bs_vendor with(nolock) WHERE state<>'2') S order by S.id";
            }
            DataTable dtVendor = new DataTable();
            dtVendor = clsApp.GetDataTable(ls_sql);
            obj.Properties.DataSource = dtVendor;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "id";
        }

        /// <summary>
        /// 設置客戶下拉列表框
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="lang"></param>
        public static void Set_Customer(DevExpress.XtraEditors.LookUpEdit obj, string lang)
        {
            string ls_sql = "";
            if (lang == "2")
            {
                //英文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,english_name FROM dbo.bs_customer with(nolock) WHERE state<>'2') S order by S.id";
            }
            else
            {
                //中文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,name FROM dbo.bs_customer with(nolock) WHERE state<>'2') S order by S.id";
            }
            DataTable dtCust = new DataTable();
            dtCust = clsApp.GetDataTable(ls_sql);
            obj.Properties.DataSource = dtCust;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "id";
        }

        /// <summary>
        /// 下拉列表框公共方法
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="lang"></param>
        /// <param name="table_name"></param>
        public static void Set_Drop_Box_Value(DevExpress.XtraEditors.LookUpEdit obj, string lang, string table_name)
        {
            string ls_sql = "";
            if (lang == "2")
            {
                //英文描述
                ls_sql = string.Format(@"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,english_name FROM dbo.{0} with(nolock) WHERE state<>'2') S order by S.id", table_name);
            }
            else
            {
                //中文描述
                ls_sql = string.Format(@"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,name FROM dbo.{0} with(nolock) WHERE state<>'2') S order by S.id", table_name);
            }
            DataTable dt = new DataTable();
            dt = clsApp.GetDataTable(ls_sql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// 檢查貨品編號是否存在
        /// </summary>
        /// <param name="goods_id"></param>
        /// <returns></returns>
        public static bool Is_Exists_Goods(string goods_id)
        {
            string result = clsApp.ExecuteSqlReturnObject(String.Format("SELECT '1' FROM dbo.it_goods with(nolock) WHERE id ='{0}'", goods_id));
            if (result != "")
                return true;
            else
            {
                MessageBox.Show(GetTitle("t_msg_goods_not_exists"), "System Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        /// <summary>
        /// 檢查OC頁數是否存在
        /// </summary>
        /// <param name="goods_id"></param>
        /// <returns></returns>
        public static bool Is_Exists_MO(string mo_id)
        {
            string result = clsApp.ExecuteSqlReturnObject(String.Format("SELECT '1' FROM dbo.so_order_details with(nolock) WHERE mo_id ='{0}'", mo_id));
            if (result != "")
                return true;
            else
            {
                MessageBox.Show(GetTitle("t_msg_mo_id_not_exist"), "System Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
        }

        /// <summary>
        /// 部門資料
        /// </summary>
        /// <returns></returns>
        public static DataTable GetDepartment()
        {
            DataTable dt = clsApp.GetDataTable(@"Select id,name,english_name From bs_department WHERE LEN(id)>2 and LEN(id)<=4 and state='0' ORDER BY id");
            return dt;
        }

        /// <summary>
        /// QC狀態
        /// </summary>
        /// <returns></returns>
        public static DataTable Get_Iqc_State()
        {
            DataTable dt = clsApp.GetDataTable(string.Format(@"Select id,name From sys_bill_origin WHERE function_id='IQC1' and language='{0}' ORDER BY id",DBUtility._language));
            return dt;
        }

        /// <summary>
        /// QC結果
        /// </summary>
        /// <returns></returns>
        public static DataTable Get_Iqc_Result()
        {
            DataTable dt = clsApp.GetDataTable(string.Format(@"Select id,name From sys_bill_origin WHERE function_id='IQC2' and language='{0}' ORDER BY id", DBUtility._language));
            return dt;
        }

       

    }
}
