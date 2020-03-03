using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace cfvn.CLS
{
   
    public class clsTempReceipt
    {
        private static clsPublicOfVN clsApp = new clsPublicOfVN();

        /// <summary>
        /// 取最大單據編號
        /// </summary>
        /// <returns></returns>
        public static string GetMaxNo()
        {
            //VID19110001
            string ls_result = "", ls_max;
            string ls_prefix =clsCommon.Get_Bill_Prefix("PO03");
            string ls_year_month = clsCommon.getYearMonth();
            ls_max = ls_prefix + ls_year_month;
            string ls_sql = string.Format(@"Select Max(id) as id From dbo.po_receipt_goods_temp with(nolock) Where id Like '{0}%'", ls_max);
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

        /// <summary>
        ///取明細最大序號
        /// </summary>
        /// <param name="id"></param>
        /// <param name="ver"></param>
        /// <returns></returns>
        public static string Get_Details_Seq(string id)
        {
            string ls_seq_id = clsApp.ExecuteSqlReturnObject(
                String.Format("SELECT MAX(sequence_id) as sequence_id FROM dbo.po_receipt_details_temp with(nolock) WHERE id ='{0}'", id)
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

        public static DataSet Get_Data(string ls_id)
        {
            string ls_sql =string.Format(
                @"Select * FROM po_receipt_goods_temp with(nolock) Where id='{0}' and state<>'2'
                  Select B.* FROM po_receipt_goods_temp A with(nolock), po_receipt_details_temp B with(nolock) 
                  Where A.id=B.id and A.id='{0}' and A.state<>'2' Order by B.id,B.sequence_id",ls_id);            
            DataSet dts = clsApp.ExcuteSqlReturnDataSet(ls_sql, null);
            return dts;
        }

        public static DataTable Find_Data(string id1,string id2,string date1, string date2,string vendor_id1,string vendor_id2,
                                          string dept_id1,string dept_id2,string mo_id1,string mo_id2)
        {
            string ls_sql =
                @"Select A.id,A.ir_date,A.vendor_id,A.vendor,A.department_id,B.mo_id,B.goods_id,B.goods_name,B.s_qty,B.unit_code,B.temp_qty,B.remark
                FROM po_receipt_goods_temp A with(nolock) 
                INNER JOIN po_receipt_details_temp B with(nolock) ON A.id=B.id                
                WHERE 1>0 ";
            if (id1 != "")
                ls_sql += " AND A.id>='" + id1 + "'";
            if (id2 != "")
                ls_sql += " AND A.id<='" + id2 + "'";
            if (date1 != "")
                ls_sql += " AND A.ir_date>='" + date1 + "'";
            if (date2 != "")
                ls_sql += " AND A.ir_date<='" + date2 + "'";
            if (vendor_id1 != "")
                ls_sql += " AND A.vendor_id>='" + vendor_id1 + "'";
            if (vendor_id2 != "")
                ls_sql += " AND A.vendor_id<='" + vendor_id2 + "'";
            if (dept_id1 != "")
                ls_sql += " AND A.department_id>='" + dept_id1 + "'";
            if (dept_id2 != "")
                ls_sql += " AND A.department_id<='" + dept_id2 + "'";
            if (mo_id1 != "")
                ls_sql += " AND B.mo_id>='" + mo_id1 + "'";
            if (mo_id2 != "")
                ls_sql += " AND B.mo_id<='" + mo_id2 + "'";

            ls_sql += " AND A.state<>'2' Order by A.id,B.sequence_id";

            DataTable dt = clsApp.GetDataTable(ls_sql);
            return dt;
        }


        /**************************************************************************
        功能名称：verify_recipt_qty
        功能描述：检验收货数量是否超量
        参    数：myDataRow  ----表格當前行對象
        返回值  ：false      ------不允许收货
                  true       ------允许按正常收货
        **************************************************************************/
        public static bool Verify_recipt_qty(DataRow myDataRow)
        {
            bool lb_result = false;           
            string ls_goods_id, ls_po_id, ls_mo_id, ls_reate, ls_rmk;
            decimal ldc_temp_qty, ldc_already_receipt_qty, ldc_rate = 0, ldc_order_qty;           
            ldc_order_qty = decimal.Parse(myDataRow["s_qty"].ToString());
            ldc_temp_qty = decimal.Parse(myDataRow["temp_qty"].ToString()) + decimal.Parse(myDataRow["m_receipt_qty"].ToString()); 
            ls_po_id = myDataRow["po_id"].ToString();
            ls_mo_id = myDataRow["mo_id"].ToString();
            ls_goods_id = myDataRow["goods_id"].ToString();

            //已確認收貨入庫總數量            
            string ls_sql = string.Format(
                @"SELECT SUM(B.receipt_qty) AS receipt_qty
                FROM po_receipt_goods A, po_receipt_details B Where A.id = B.id and A.state = '1' and B.po_id = '{0}' and B.mo_id = '{1}' and goods_id = '{2}'
                GROUP BY B.po_id, B.mo_id, B.goods_id", ls_po_id, ls_mo_id, ls_goods_id);
            DataTable dt = clsApp.GetDataTable(ls_sql);
            if (dt.Rows.Count == 0)
                ldc_already_receipt_qty = 0;
            else
                ldc_already_receipt_qty = decimal.Parse(dt.Rows[0]["already_temp_qty"].ToString());

            //提取設置的超收比率
            dt = clsApp.GetDataTable("Select value, remark From sy_parameters_setup Where sequence_id = 'PO0306'");
            if (dt.Rows.Count > 0)
            {
                if (dt.Rows[0]["value"].ToString() == "1")//有超收比例
                {
                    ls_reate = dt.Rows[0]["remark"].ToString();
                    if (ls_reate.IndexOf("%")>0)
                    {
                        int ii = ls_reate.IndexOf("%");
                        ls_reate = ls_reate.Substring(0, ls_reate.Length - 1);
                    }
                    ldc_rate = decimal.Parse(ls_reate);
                }
            }
            //超收數不可以大于等于設定的值
            //ldc_temp_qty 暫收數量
            //ldc_already_receipt_qty 已收確認收貨入庫總數量
            if (ldc_temp_qty > (ldc_order_qty - ldc_already_receipt_qty) * (1 + ldc_rate / 100))
            {
                ls_rmk = "\r\n\r\n Receivable quantity:" + (ldc_order_qty - ldc_already_receipt_qty).ToString() + "     Rate:" + ldc_rate.ToString("0.00") + "%" + "     Total:" + ((ldc_order_qty - ldc_already_receipt_qty) * (1 + ldc_rate / 100)).ToString("F2");
                if (System.Windows.Forms.MessageBox.Show(clsCommon.GetTitle("t_msg_po0306") + ls_rmk, "system info",System.Windows.Forms.MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
                    lb_result = true;
                else
                    lb_result = false;
            }
            else
                lb_result = true;

            return lb_result;
        }


    }

   
}
