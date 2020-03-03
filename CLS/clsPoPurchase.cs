using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using cfvn.MDL;

namespace cfvn.CLS
{
    public static class clsPoPurchase
    {
        private static clsPublicOfVN clsApp = new clsPublicOfVN();

        /// <summary>
        /// 取供應商信息
        /// </summary>
        /// <param name="ls_vendor_id"></param>
        /// <returns></returns>
        public static DataTable Get_Vendor_Info(string ls_vendor_id)
        {
            string ls_sql =string.Format(
                @"SELECT linkman,l_phone,add_address,money_id,payment_mode,fax FROM bs_vendor WHERE id='{0}' and (type='ALL' OR type='PUR') and state<>'2'", ls_vendor_id);
            DataTable dt = clsApp.GetDataTable(ls_sql);
            return dt;
        }

        /// <summary>
        /// 取客戶送貨地址
        /// </summary>
        /// <param name="ls_customer"></param>
        /// <returns></returns>
        public static DataTable Get_Customer_Send_Address(string ls_customer)
        {
            string ls_sql = string.Format(@"SELECT shipment_s_address FROM bs_customer WHERE id='{0}' and state<>'2'", ls_customer);
            DataTable dt = clsApp.GetDataTable(ls_sql);
            return dt;
        }

        /// <summary>
        /// 取最大單據編號
        /// </summary>
        /// <returns></returns>
        public static string GetMaxNo()
        {
            //VWH19110001
            string ls_result = "",ls_max;
            string ls_prefix ="V"+ clsCommon.Get_Bill_Prefix("PO02"); //"VWH";
            string ls_year_month = clsCommon.getYearMonth();
            ls_max = ls_prefix + ls_year_month;
            string ls_sql = string.Format(@"Select Max(id) as id From dbo.po_buy_manage with(nolock) Where id Like '{0}%'", ls_max);
            ls_result = clsApp.ExecuteSqlReturnObject(ls_sql);
            if (string.IsNullOrEmpty(ls_result))
            {
                ls_result = String.Format("{0}{1}0001", ls_prefix, ls_year_month);
            }
            else
            {               
                ls_result = ls_prefix + ls_year_month + (int.Parse(ls_result.Substring(7, 4)) + 1).ToString("0000");
            }
            return ls_result;
        }

        public static DataTable Get_Employer()
        {
            string ls_sql = @"SELECT id,name FROM bs_personnel WHERE len(id)=10 and state<>'2' order by id";
            DataTable dt = clsApp.GetDataTable(ls_sql);
            return dt;
        }

        public static string Get_Employer(string ls_emp_id)
        {
            string ls_result;
            string ls_sql = string.Format(@"SELECT name FROM bs_personnel WHERE id='{0}' and state<>'2' order by id", ls_emp_id);
            ls_result = clsApp.ExecuteSqlReturnObject(ls_sql);
            return ls_result;
        }

        public static int Delete_Mostly(string ls_id,string ls_ver)
        {
            int ls_result;
            string sql_d = string.Format(@"UPDATE dbo.po_buy_manage Set state = '2' WHERE id = '{0}' AND ver = '{1}'",ls_id,ls_ver);
            ls_result = clsApp.ExecuteSqlUpdate(sql_d);
            return ls_result;
        }

        /// <summary>
        ///取明細的序號
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        public static string Get_Details_Seq(string id, string ver) 
        {           
            string ls_seq_id = clsApp.ExecuteSqlReturnObject(
                String.Format("SELECT MAX(sequence_id) as sequence_id FROM dbo.po_buy_details with(nolock) WHERE id ='{0}' and ver='{1}'", id, ver)
                );
            string strSeq;
            if (String.IsNullOrEmpty(ls_seq_id))
            {
                strSeq = "001";
            }
            else
            {               
                strSeq = ls_seq_id.Substring(0, 3);               
                strSeq = (int.Parse(strSeq) + 1).ToString("000");
            }            
            return strSeq;
        }
        
        

        public static DataTable Get_MM_Info(string good_id) 
        {
            string ls_sql = string.Format(
            @"SELECT A.name,A.english_name,A.do_color,B.name as color FROM dbo.it_goods A With(nolock) left join dbo.bs_color B ON A.color=B.id WHERE A.id ='{0}'", good_id);
            DataTable dtMM = clsApp.GetDataTable(ls_sql);
            return dtMM;
        }


        public static DataSet Get_PO_Data(string ls_id, int li_ver)
        {
           SqlParameter[] paras = new System.Data.SqlClient.SqlParameter[] {
                new SqlParameter("@id",ls_id),
                new SqlParameter("@ver",li_ver)
            };
            DataSet dtsPo = clsApp.ExecuteProcedureReturnDataSet("usp_po_purchase", paras, null);
            return dtsPo;	
        }

        public static DataTable Get_MM(string mm)
        {
            DataTable dt = clsApp.GetDataTable(string.Format(
            @"SELECT S.* FROM (select '' as id,'' as name Union select top 100 id ,name from it_goods with(nolock) where id like '%{0}%') S order by S.id", mm));
            return dt;
        }

        /// <summary>
        /// 數據加載
        /// </summary>
        /// <param name="lst"></param>
        /// <returns></returns>
        public static DataTable Get_Pur_Data(mdlPoPurchase lst)
        {           
            string ls_sql =
                @"SELECT a.id,a.ver,convert(varchar(10),a.order_date,120) as order_date,a.state,a.vendor_id,a.department_id,a.buyer_id ,a.cd_buyer,a.origin_id,a.remark,b.name as vendor_name,c.name as dept_name
                FROM dbo.po_buy_manage a with(nolock) 
                inner join bs_vendor b on a.vendor_id=b.id
                inner join bs_department c on a.department_id=c.id 
                WHERE 1=1 ";
            if (lst.id1 != "")
            {
                ls_sql += string.Format(" and a.id>='{0}'", lst.id1);
            }
            if (lst.id2 != "")
            {
                ls_sql += string.Format(" and a.id<='{0}'", lst.id2);
            }
            if (lst.order_date1 != "")
            {
                ls_sql += string.Format(" and a.order_date>='{0}'", lst.order_date1);
            }
            if (lst.order_date2 != "")
            {
                ls_sql += string.Format(" and a.order_date<='{0}'", lst.order_date2);
            }
            if (lst.vendor_id1 != "")
            {
                ls_sql += string.Format(" and a.vendor_id>='{0}'", lst.vendor_id1);
            }
            if (lst.vendor_id2 != "")
            {
                ls_sql += string.Format(" and a.vendor_id<='{0}'", lst.vendor_id2);
            }
            if (lst.dept_id1 != "")
            {
                ls_sql += string.Format(" and a.department_id>='{0}'", lst.dept_id1);
            }
            if (lst.dept_id2 != "")
            {
                ls_sql += string.Format(" and a.department_id<='{0}'", lst.dept_id2);
            }
            if (lst.buyer_id1 != "")
            {
                ls_sql += string.Format(" and a.department_id>='{0}'", lst.buyer_id1);
            }
            if (lst.buyer_id2 != "")
            {
                ls_sql += string.Format(" and a.department_id<='{0}'", lst.buyer_id2);
            }
            ls_sql += " and a.state<>'2' order by a.order_date,a.id ";            
            DataTable dt = clsApp.GetDataTable(ls_sql);

            return dt;
        }

        /// <summary>
        /// 列印報表數據
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public static DataTable Get_Print_Data(string id)
        {
            DataTable dt = clsApp.GetDataTable(string.Format(
            @"SELECT S.* FROM
            (SELECT A.id,Convert(varchar(10),A.order_date,120) as order_date,A.m_id,Round(convert(float,A.total_sum),2) as total_sum ,A.department_id,A.linkman,B.bill_origin,B.dept_id,B.goods_id,B.goods_name,
            Round(Convert(float,B.order_qty),0) as order_qty,B.unit_code,B.do_color,B.spec,
            Round(convert(float,B.price),2) as price,B.p_unit,Round(convert(float,B.sec_qty),2) as sec_qty ,B.sec_unit,Round(convert(float,B.total_sum),2) as total_sum_d,Convert(varchar(10),B.fact_date,120) as fact_date,
            B.remark,C.english_name AS department_name ,D.name as vendor_name,D.english_name as vendor_name_en,A.create_by,B.sequence_id
            FROM dbo.po_buy_manage A with(nolock) 
            INNER JOIN dbo.po_buy_details B with(nolock) ON A.id=B.id And A.ver=B.ver 
            LEFT JOIN dbo.bs_department C ON A.department_id =C.id
            INNER JOIN bs_vendor D ON A.vendor_id=D.id
            WHERE A.id='{0}' 
            UNION ALL
            SELECT aa.id,Convert(varchar(10),aa.order_date,120) as order_date,aa.m_id,Round(convert(float,aa.total_sum),2) as total_sum ,aa.department_id,aa.linkman,'' as bill_origin,'' as dept_id,bb.fare_id as goods_id,bb.name as goods_name,
            Round(Convert(float,bb.qty),0) as order_qty,bb.unit_code,'' as do_color,'' as spec,
            Round(convert(float,bb.price),2) as price,'' as unit_code,0.00 as sec_qty ,'' as sec_unit,Round(convert(float,bb.fare_sum),2) as total_sum_d,'' as fact_date,
            '' as remark,C.english_name AS department_name,D.name as vendor_name,D.english_name as vendor_name_en,aa.create_by as create_by,
            (select MAX(po_buy_details.sequence_id) from po_buy_details with(nolock) where po_buy_details.id=bb.id and po_buy_details.ver=bb.ver and po_buy_details.goods_id = bb.goods_id) + '1' as sequence_id
            FROM dbo.po_buy_manage aa with(nolock) 
            INNER JOIN dbo.po_other_fare bb with(nolock) ON aa.id=bb.id And aa.ver=bb.ver 
            LEFT JOIN dbo.bs_department C ON aa.department_id =C.id
            INNER JOIN bs_vendor D ON aa.vendor_id=D.id
            WHERE aa.id='{0}') S
            ORDER BY S.id,S.sequence_id ", id));
            
            return dt;
        }

        public static bool Check_Is_New_Version(string id,int ver)
        {
            bool lb_result = true;
            DataTable dt = new DataTable();
            dt = clsApp.GetDataTable(string.Format(@"Select order_qty,unit_code,sec_qty,sec_unit,p_unit,receipt_qty From po_buy_details Where id='{0}' and ver={1}",id,ver));
            decimal ldc_receipt_qty;
            for (int i=0; i < dt.Rows.Count; i++)
            {
                if (string.IsNullOrEmpty(dt.Rows[i]["receipt_qty"].ToString()))
                    ldc_receipt_qty = 0;
                else
                    ldc_receipt_qty = decimal.Parse(dt.Rows[i]["receipt_qty"].ToString());
                if (ldc_receipt_qty > 0)
                {
                    lb_result = false;
                    break;
                }
                //與數量單位一致則判煙收貨數量是否大于訂單數量
                //if (string.Compare(dt.Rows[i]["p_unit"].ToString(), dt.Rows[i]["unit_code"].ToString(),true)==0)
                //{
                //    if (ldc_receipt_qty >= ldc_order_qty)
                //    {
                //        lb_result = true;
                //    }
                //}               
            }
            return lb_result;
        }

    }
}
