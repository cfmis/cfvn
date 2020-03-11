using cfvn.CLS;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
//using WeifenLuo.WinFormsUI.Docking;

namespace cfvn.Forms
{
    public partial class frmPoReceipt : Form
    {
        
        public string m_id = "";    //臨時的主鍵值       
        public string m_state = ""; //新增或編號的狀態        
        public static string str_language = "0";
        public string m_msg_custom;
        public bool m_save_flag;
        string m_image_path = AppDomain.CurrentDomain.BaseDirectory;
        string m_image_file = "";
        public BindingSource bds_h = new BindingSource();
        public static BindingSource bds_d = new BindingSource();

        DataTable dtMostly = new DataTable();
        DataTable dtDetail = new DataTable();
        DataTable dtTempDel = new DataTable();
        public DataTable dtUnit = new DataTable();
        public DataTable dtSec_Unit = new DataTable();

        readonly MsgInfo myMsg = new MsgInfo();//實例化Messagegox用到的提示 
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        public clsAppPublic objApp = new clsAppPublic();
        

        clsToolBar objToolbar;

       
        public frmPoReceipt()
        {
            InitializeComponent();
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();

            //權限
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.SetToolBar();
            objToolbar.Set_Button_Image(toolStrip1);
        }

        private void frmPoReceipt_Load(object sender, EventArgs e)
        {
            //狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);
            //供應商
            DataTable dtVendor = clsCommon.GetVendor();
            luevendor_id.Properties.DataSource = dtVendor;
            luevendor_id.Properties.ValueMember = "id";
            luevendor_id.Properties.DisplayMember = "id";
            //查詢介面中的供應商
            luevendor_id1.Properties.DataSource = dtVendor;
            luevendor_id1.Properties.ValueMember = "id";
            luevendor_id1.Properties.DisplayMember = "id";
            luevendor_id2.Properties.DataSource = dtVendor;
            luevendor_id2.Properties.ValueMember = "id";
            luevendor_id2.Properties.DisplayMember = "id";

            //開單來源
            DataTable dtBbill_Origin = clsCommon.Get_Bill_Origin("PO03");
            lueseparate.Properties.DataSource = dtBbill_Origin;
            lueseparate.Properties.ValueMember = "id";
            lueseparate.Properties.DisplayMember = "name";
            //部門
            clsCommon.Set_Drop_Box_Value(luedepartment_id, DBUtility._language, "bs_department");
            //查詢介面中的部門
            clsCommon.Set_Drop_Box_Value(luedept_id1, DBUtility._language, "bs_department");
            clsCommon.Set_Drop_Box_Value(luedept_id2, DBUtility._language, "bs_department");

            //單位
            dtUnit = clsCommon.GetUnit();
            cl_unit_code.DataSource = dtUnit;
            cl_unit_code.ValueMember = "id";
            cl_unit_code.DisplayMember = "id";
            
            //重量單位
            dtSec_Unit = clsCommon.GetSecUnit();
            cl_unit_code_sec.DataSource = dtSec_Unit;
            cl_unit_code_sec.ValueMember = "id";
            cl_unit_code_sec.DisplayMember = "id";
            //倉庫
            cl_location_id.DataSource = clsCommon.GetDepartment();
            cl_location_id.ValueMember = "id";
            cl_location_id.DisplayMember = "name";

            //QC狀態
            cl_qc_state.DataSource = clsCommon.Get_Iqc_State();
            cl_qc_state.ValueMember = "id";
            cl_qc_state.DisplayMember = "name";

            //QC結果
            cl_qc_result.DataSource = clsCommon.Get_Iqc_Result();
            cl_qc_result.ValueMember = "id";
            cl_qc_result.DisplayMember = "name";

            //主表結構
            const string ls_mostly = @"SELECT * FROM dbo.po_receipt_goods_temp WHERE 1=0";
            dtMostly = clsApp.GetDataTable(ls_mostly);
            bds_h.DataSource = dtMostly;

            //生成明細結構
            string ls_details = @"SELECT a.*,b.name as goods_name FROM dbo.po_receipt_details_temp a,it_goods b WHERE 1=0";
            dtDetail = clsApp.GetDataTable(ls_details);
            bds_d.DataSource = dtDetail;
            gridControl1.DataSource = bds_d;
         
            //生成臨時項目刪除表結構
            dtTempDel = dtDetail.Clone();
          
            //主表數據綁定
            Set_DataBindings();

        }

        private void frmPoReceipt_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
        }

        private void Set_DataBindings()
        {
            txtID.DataBindings.Add("Text", bds_h, "id");
            detir_date.DataBindings.Add("EditValue", bds_h, "ir_date");
            luevendor_id.DataBindings.Add("EditValue", bds_h, "vendor_id");
            txtvendor.DataBindings.Add("Text", bds_h, "vendor");
            txtconsignee.DataBindings.Add("Text", bds_h, "consignee");
            txtdeliveryman.DataBindings.Add("Text", bds_h, "deliveryman");
            txtdeliver_id.DataBindings.Add("Text", bds_h, "deliver_id");
            lueseparate.DataBindings.Add("EditValue", bds_h, "separate");//bill type           
            luedepartment_id.DataBindings.Add("EditValue", bds_h, "department_id");
            txtremark.DataBindings.Add("Text", bds_h, "remark");
            luestate.DataBindings.Add("EditValue", bds_h, "state");
            txtcreate_by.DataBindings.Add("Text", bds_h, "create_by");
            txtcreate_date.DataBindings.Add("Text", bds_h, "create_date");
            txtupdate_by.DataBindings.Add("Text", bds_h, "update_by");
            txtupdate_date.DataBindings.Add("Text", bds_h, "Update_date");
           
        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNNEW_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void BTNITEMADD_Click(object sender, EventArgs e)
        {
            AddNew_Item();
        }

        private void BTNITEMDEL_Click(object sender, EventArgs e)
        {
            Del_Item();
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            txtremark.Focus();//Toolscript焦點問題
            Save();
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void BTNAPPROVE_Click(object sender, EventArgs e)
        {
            if (luestate.EditValue.ToString() == "0")
            {
                ApproveState("1"); //批準單據                
                return;
            }
            if (luestate.EditValue.ToString() == "1")
            {
                ApproveState("0");//反批準單據
            }
        }

        private void BTNPRINT_Click(object sender, EventArgs e)
        {
            //Print();
        }

        private void AddNew()
        {
            m_state = "NEW";
            objToolbar.Set_Button_Enable_Status(toolStrip1, false);
            objToolbar.SetToolBar();//重檢查按鈕的權限
           
            SetObjValue.SetEditBackColor(tabPoPurchase.TabPages[0].Controls, true);
            SetObjValue.ClearObjValue(tabPoPurchase.TabPages[0].Controls, "2");//1 清空主檔，2全部            

            lueseparate.EditValue = "1";            
            luestate.EditValue = "0";
            BTNAPPROVE.Tag = "0";
            detir_date.EditValue = DateTime.Now.Date.ToString("yyyy/MM/dd");
            txtID.Text = clsTempReceipt.GetMaxNo();
            //DataRow dr = dtArt_request.NewRow(); //插一空行
            //dtArt_request.Rows.InsertAt(dr, 0);
            dtDetail.Clear();
            bds_d.DataSource = dtDetail;            
            gridControl1.DataSource = bds_d;           
            tabPoPurchase.SelectedIndex = 0;
        }

        private void Edit()
        {
            if (!(txtID.Text == ""))
            {
                if (BTNAPPROVE.Tag.ToString() == "1")
                {
                    //已批準狀態,不可以編輯!
                    MessageBox.Show(clsCommon.GetTitle("t_ check_is_can_edit"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (BTNAPPROVE.Tag.ToString() == "2")
                {
                    //注銷狀態,不可以編輯!
                    MessageBox.Show(clsCommon.GetTitle("t_ check_is_can_cancel"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }                
                
                objToolbar.Set_Button_Enable_Status(toolStrip1, false);
                objToolbar.SetToolBar();//重檢查按鈕的權限
                SetObjValue.SetEditBackColor(tabPoPurchase.TabPages[0].Controls, true);
                Set_Grid_Status(true);
                m_state = "EDIT";
                txtID.Properties.ReadOnly = true;
                txtID.BackColor = System.Drawing.Color.White;
                lueseparate.Properties.ReadOnly = true;
                lueseparate.BackColor = System.Drawing.Color.White;

                tabPoPurchase.SelectedIndex = 0;
                
            }
        }

        private void Delete()
        {
            if (BTNSAVE.Enabled || txtID.Text == "")
            {
                return;
            }
            if (luestate.EditValue.ToString() == "1")
            {
                //已批準狀態,不可以刪除!
                MessageBox.Show(clsCommon.GetTitle("t_ check_is_can_delete"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            DialogResult dialogResult = MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                int ls_result;
                string sql_d = string.Format(@"UPDATE dbo.po_receipt_goods_temp Set state = '2' WHERE id = '{0}'", txtID.Text);
                ls_result = clsApp.ExecuteSqlUpdate(sql_d);
                if (ls_result > 0)
                {
                    MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(myMsg.msgSave_error, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Cancel()
        {
            lueseparate.Properties.ReadOnly = false;
            lueseparate.BackColor = System.Drawing.Color.White;
            SetObjValue.SetEditBackColor(Controls, false);
            objToolbar.Set_Button_Enable_Status(toolStrip1, true);
            objToolbar.SetToolBar();
            Set_Grid_Status(false);
            m_state = "";
            bds_h.CancelEdit();
            bds_d.CancelEdit();
            dtMostly.RejectChanges();
            dtDetail.RejectChanges();
            dtTempDel.Clear();
            
            if (!String.IsNullOrEmpty(m_id))
            {
                //Find_Doc(m_id);
            }
        }

        private void Set_Grid_Status(bool _flag) //表格可編號否
        {
            //false--不可編輯;true--可以編輯
            dgvDetails.OptionsBehavior.Editable = _flag;            
        }

        private void ApproveState(string state) //批準或反批準
        {
            if (txtID.Text == "")
            {
                return;
            }
            //批準
            const string str1 = @"Update dbo.po_receipt_goods_temp Set state=@state Where id=@id";
            //反批準
            const string str2 = @"Update dbo.po_receipt_goods_temp Set state=@state ,update_by=@user_id,update_date=getdate() Where id=@id";
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@state", state),
                new SqlParameter("@user_id", DBUtility._user_id),
                new SqlParameter("@id", txtID.Text)
            };
            string strSql;
            if (state == "0")
            {
                strSql = str2;
            }
            else
            {
                strSql = str1;
            }
            int num = clsApp.ExecuteNonQuery(strSql, paras, false);
            if (num > 0)
            {
                luestate.EditValue = state;
                //state=1狀態是1時直接更新庫存.
                //TO DO
            }
        }

        public void AddNew_Item()
        {            
            if (Valid_Data_H())
            {
                Set_Grid_Status(true);
                dgvDetails.AddNewRow();
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "id", txtID.Text);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "unit_code", "PCS");
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "mo_id", "Z99999999");
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "sec_unit", "KG");

                Set_gridView_Focus();
            }
        }

        public void Del_Item()
        {            
            if (dgvDetails.RowCount != 0)
            {
                DialogResult dialogResult = MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int row = dgvDetails.FocusedRowHandle;
                    DataRow dr = dtTempDel.NewRow();
                    dr["id"] = txtID.Text;                    
                    dr["sequence_id"] = dgvDetails.GetRowCellDisplayText(row, "sequence_id");
                    dtTempDel.Rows.Add(dr);
                    dgvDetails.DeleteRow(row);
                }
            }
           
        }

        private void Set_gridView_Focus()  //項目新增時設置表格當前焦點
        {
            ColumnView columnView = dgvDetails;
            columnView.FocusedColumn = columnView.Columns["mo_id"];
            columnView.Focus();
            columnView.ShowEditor();
        }

        private bool Valid_Data_H() //保存前檢查主表的合法性
        {
            if (txtID.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_id_cannot_empty"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Focus();
                return false;
            }
            if (detir_date.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_order_date"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                detir_date.Focus();
                return false;
            }           
            if (lueseparate.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_bill_origin_id"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lueseparate.Focus();
                return false;
            }
            //if (luevendor_id.Text == "")
            //{
            //    MessageBox.Show(clsCommon.GetTitle("t_msg_vendor_id_cannot_empty"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    luevendor_id.Focus();
            //    return false;
            //}            
            return true;
        }

        private void Save()//保存新增,編輯或刪除的資料
        {
            if (m_state == "")
            {
                return;
            }
            if (!Valid_Data_H())
            {
                return;
            }
            dgvDetails.CloseEditor();
            if (!Valid_Data_D())//檢查明細資料的有效性
            {
                return;
            }
            if (luevendor_id.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_vendor_id_cannot_empty"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                luevendor_id.Focus();
                return ;
            }

            bool save_flag = false;
            #region  保存新增
            if (m_state == "NEW" || m_state == "EDIT")
            {
                if (m_state == "NEW")
                {
                    string ls_sql = String.Format("Select '1' FROM dbo.po_receipt_goods_temp WHERE id='{0}'", txtID.Text);
                    if (clsCommon.Valid_Doc(ls_sql)) //檢查主鍵是否存在
                    {
                        //重新取最大單據編號
                        txtID.Text = clsTempReceipt.GetMaxNo();
                    }
                }
                const string ls_sql_i =
                    @"INSERT dbo.po_receipt_goods_temp(id,ir_date,vendor,vendor_id,deliveryman,deliver_id,consignee,remark,iqc_result,iqc_state,
                             iqc_complete_date,department_id,separate,state,create_date,create_by) 
					  VALUES(@id,@ir_date,@vendor,@vendor_id,@deliveryman,@deliver_id,@consignee,@remark,@iqc_result,@iqc_state,
                             @iqc_complete_date,@department_id,@separate,@state,getdate(),@user_id)";
                const string ls_sql_u =
                    @"UPDATE dbo.po_receipt_goods_temp 
                     SET separate=@separate,ir_date=@ir_date,vendor=@vendor,vendor_id=@vendor_id,deliveryman=@deliveryman,deliver_id=@deliver_id,
                        consignee=@consignee,remark=@remark,iqc_result=@iqc_result,iqc_state=@iqc_state,iqc_complete_date=@iqc_complete_date,
                        department_id=@department_id,state=@state,update_date=getdate(),update_by=@user_id
                     WHERE id=@id";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);
                myCon.Open();
                SqlTransaction myTrans = myCon.BeginTransaction();
                using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
                {
                    try
                    {
                        if (m_state == "NEW")
                            myCommand.CommandText = ls_sql_i;
                        else
                            myCommand.CommandText = ls_sql_u;
                        myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@id", txtID.Text.Trim());                       
                        myCommand.Parameters.AddWithValue("@ir_date", detir_date.Text);                        
                        myCommand.Parameters.AddWithValue("@vendor_id", luevendor_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@vendor", txtvendor.Text);
                        myCommand.Parameters.AddWithValue("@deliveryman", txtdeliveryman.Text);
                        myCommand.Parameters.AddWithValue("@deliver_id", txtdeliver_id.Text);
                        myCommand.Parameters.AddWithValue("@consignee", txtconsignee.Text);
                        myCommand.Parameters.AddWithValue("@remark", txtremark.Text);
                        myCommand.Parameters.AddWithValue("@iqc_result", "");
                        myCommand.Parameters.AddWithValue("@iqc_state", "");
                        myCommand.Parameters.AddWithValue("@iqc_complete_date", DBNull.Value);
                        myCommand.Parameters.AddWithValue("@department_id", luedepartment_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@separate", lueseparate.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@state", luestate.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@user_id", DBUtility._user_id);
                        myCommand.ExecuteNonQuery();

                        //處理明細資料
                        string ls_row_status = "";
                        if (dgvDetails.RowCount > 0)
                        {
                            const string sql_item_i =
                                @"INSERT INTO dbo.po_receipt_details_temp(
                                  id,sequence_id,mo_id,goods_id,color,po_id,po_ver,po_sequence_id,temp_qty,m_receipt_qty,fact_qty,basic_unit,unit_code,location_id,carton_code,location,
                                  price,m_rate,exchange_rate,total_sum,sec_qty,sec_unit,qc_result,qc_state,currency,s_qty,s_date,remark,sell_order)
                                  VALUES(@id,@sequence_id,@mo_id,@goods_id,@color,@po_id,@po_ver,@po_sequence_id,@temp_qty,@m_receipt_qty,@fact_qty,@basic_unit,@unit_code,
                                  @location_id,@carton_code,@location,@price,@m_rate,@exchange_rate,@total_sum,@sec_qty,@sec_unit,@qc_result,@qc_state,@currency,@s_qty,
                                  CASE WHEN LEN(@s_date)=0 THEN NULL ELSE @s_date END,@remark,@sell_order,@location)";
                            const string sql_item_u =
                                @"UPDATE dbo.po_receipt_details_temp
                                  SET mo_id=@mo_id,goods_id=@goods_id,color=@color,po_id=@po_id,po_ver=@po_ver,po_sequence_id=@po_sequence_id,temp_qty=@temp_qty,m_receipt_qty=@m_receipt_qty,
                                  fact_qty=@fact_qty,basic_unit=@basic_unit,unit_code=@unit_code,location_id=@location_id,carton_code=@carton_code,location=@location,
                                  price=@price,m_rate=@m_rate,exchange_rate=@exchange_rate,total_sum=@total_sum,sec_qty=@sec_qty,sec_unit=@sec_unit,qc_result=@qc_result,qc_state=@qc_state,currency=@currency,
                                  s_qty=@s_qty,s_date=CASE WHEN LEN(@s_date)=0 THEN NULL ELSE @s_date END,remark=@remark,sell_order=@sell_order
                                  WHERE id=@id and sequence_id=@sequence_id";
                            const string sql_item_d = @"DELETE FROM dbo.po_receipt_details_temp WHERE id=@id and sequence_id=@sequence_id";
                            //處進點擊[項目刪除]操作刪除的記錄
                            if (m_state == "EDIT")
                            {
                                if (dtTempDel.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dtTempDel.Rows.Count; i++)
                                    {
                                        myCommand.CommandText = sql_item_d;
                                        myCommand.Parameters.Clear();
                                        myCommand.Parameters.AddWithValue("@id", txtID.Text.Trim());                                        
                                        myCommand.Parameters.AddWithValue("@sequence_id", dtTempDel.Rows[i]["sequence_id"].ToString());
                                        myCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                            //保存明細
                            string ls_seq_id = "";
                            for (int i = 0; i < dtDetail.Rows.Count; i++)
                            {
                                if (m_state == "NEW")
                                {
                                    dgvDetails.SetRowCellValue(i, "id", txtID.Text);
                                }
                                ls_row_status = dtDetail.Rows[i].RowState.ToString();
                                if (ls_row_status == "Added" || ls_row_status == "Modified")
                                {
                                    if (ls_row_status == "Added")
                                    {
                                        myCommand.CommandText = sql_item_i;
                                        ls_seq_id = clsTempReceipt.Get_Details_Seq(txtID.Text.Trim()); //新增狀態重新取最大序號;                                        
                                        dgvDetails.SetRowCellValue(i, "sequence_id", ls_seq_id);
                                    }
                                    else
                                    {
                                        myCommand.CommandText = sql_item_u;
                                        ls_seq_id = dtDetail.Rows[i]["sequence_id"].ToString(); //編輯時序號;
                                    }
                                    myCommand.Parameters.Clear();
                                    myCommand.Parameters.AddWithValue("@id", txtID.Text.Trim());                                   
                                    myCommand.Parameters.AddWithValue("@sequence_id", ls_seq_id);
                                    myCommand.Parameters.AddWithValue("@mo_id", dtDetail.Rows[i]["mo_id"].ToString());
                                    myCommand.Parameters.AddWithValue("@goods_id", dtDetail.Rows[i]["goods_id"].ToString());
                                    myCommand.Parameters.AddWithValue("@color", dtDetail.Rows[i]["color"].ToString());
                                    myCommand.Parameters.AddWithValue("@po_id", dtDetail.Rows[i]["po_id"].ToString());//採購單號
                                    myCommand.Parameters.AddWithValue("@po_ver", dtDetail.Rows[i]["po_ver"].ToString());//採購單版本號
                                    myCommand.Parameters.AddWithValue("@po_sequence_id", dtDetail.Rows[i]["po_sequence_id"].ToString());//採購單序號
                                    myCommand.Parameters.AddWithValue("@temp_qty", objApp.Return_Float_Value(dtDetail.Rows[i]["temp_qty"].ToString()));//暫收數量
                                    myCommand.Parameters.AddWithValue("@m_receipt_qty", objApp.Return_Float_Value(dtDetail.Rows[i]["m_receipt_qty"].ToString()));//多收數量
                                    myCommand.Parameters.AddWithValue("@fact_qty", objApp.Return_Float_Value(dtDetail.Rows[i]["fact_qty"].ToString()));//實際收貨數量
                                    //myCommand.Parameters.AddWithValue("@already_temp_qty", objApp.Return_Float_Value(dtDetail.Rows[i]["already_temp_qty"].ToString()));
                                    myCommand.Parameters.AddWithValue("@basic_unit", dtDetail.Rows[i]["basic_unit"].ToString());
                                    myCommand.Parameters.AddWithValue("@unit_code", dtDetail.Rows[i]["unit_code"].ToString());//單位
                                    myCommand.Parameters.AddWithValue("@location_id", dtDetail.Rows[i]["location_id"].ToString());//倉庫
                                    myCommand.Parameters.AddWithValue("@carton_code", dtDetail.Rows[i]["carton_code"].ToString());//倉位
                                    myCommand.Parameters.AddWithValue("@location", dtDetail.Rows[i]["location"].ToString());
                                    myCommand.Parameters.AddWithValue("@price", objApp.Return_Float_Value(dtDetail.Rows[i]["price"].ToString()));//單價
                                    myCommand.Parameters.AddWithValue("@currency", dtDetail.Rows[i]["currency"].ToString());//貨幣
                                    myCommand.Parameters.AddWithValue("@m_rate", objApp.Return_Float_Value(dtDetail.Rows[i]["m_rate"].ToString()));//當時匯率
                                    myCommand.Parameters.AddWithValue("@exchange_rate", objApp.Return_Float_Value(dtDetail.Rows[i]["exchange_rate"].ToString()));//當時匯率                                    
                                    myCommand.Parameters.AddWithValue("@total_sum", objApp.Return_Float_Value(dtDetail.Rows[i]["total_sum"].ToString()));//貨品金額
                                    myCommand.Parameters.AddWithValue("@sec_qty", objApp.Return_Float_Value(dtDetail.Rows[i]["sec_qty"].ToString()));//重量
                                    myCommand.Parameters.AddWithValue("@sec_unit", dtDetail.Rows[i]["sec_unit"].ToString());//重量單位
                                    myCommand.Parameters.AddWithValue("@qc_result", dtDetail.Rows[i]["qc_result"].ToString());//QC結果
                                    myCommand.Parameters.AddWithValue("@qc_state", dtDetail.Rows[i]["qc_state"].ToString());//QC狀態
                                    myCommand.Parameters.AddWithValue("@s_qty", objApp.Return_Float_Value(dtDetail.Rows[i]["s_qty"].ToString()));//訂單數量
                                    myCommand.Parameters.AddWithValue("@s_date", !string.IsNullOrEmpty(dtDetail.Rows[i]["s_date"].ToString()) ? dtDetail.Rows[i]["s_date"].ToString() : ""); //要求送貨日期                                 
                                    myCommand.Parameters.AddWithValue("@remark", dtDetail.Rows[i]["remark"].ToString());//備註
                                    myCommand.Parameters.AddWithValue("@sell_order", dtDetail.Rows[i]["sell_order"].ToString());  //銷售訂單號                                                           
                                    myCommand.ExecuteNonQuery();
                                }
                            }
                        }                        
                        myTrans.Commit(); //數據提交
                        save_flag = true;
                    }
                    catch (Exception E)
                    {
                        myTrans.Rollback(); //數據回滾
                        save_flag = false;
                        throw new Exception(E.Message);
                    }
                    finally
                    {
                        myCon.Close();
                        myCon.Dispose();
                        myTrans.Dispose();
                    }
                }
            }
            #endregion


            objToolbar.Set_Button_Enable_Status(toolStrip1, true);
            objToolbar.SetToolBar();
            lueseparate.Properties.ReadOnly = false;
            lueseparate.BackColor = System.Drawing.Color.White;
            SetObjValue.SetEditBackColor(this.Controls, false);
            Set_Grid_Status(false);
            m_state = "";
            dtTempDel.Clear();            
            if (save_flag)
            {
                Find_Doc();
                DBUtility.myMessageBox(myMsg.msgSave_ok, myMsg.msgTitle);
                m_id = txtID.Text;                
            }
            else
            {
                MessageBox.Show(myMsg.msgSave_error, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private bool Valid_Data_D() //保存前檢查明細資料的合法性
        {
            bool result = true;
            if (dgvDetails.RowCount > 0)
            {
                string ls_tips, ls_tips_goods;
                if (DBUtility._language == "2")
                {
                    ls_tips = "mo、goods、temp qty,unit or location cannot empty.";
                    //ls_tips_mo = "Invalid mo id ";
                    ls_tips_goods = "Invalid goods id";
                }
                else
                {
                    ls_tips = "頁數、貨品編號、單位、暫收數量、倉位不可爲空!";
                    //ls_tips_mo = "無效的頁數.";
                    ls_tips_goods = "無效的貨品編號";
                }

                ColumnView columnView = dgvDetails;
                string ls_rowStatus = "";
                for (int i = 0; i < dgvDetails.RowCount; i++)
                {
                    ls_rowStatus = dtDetail.Rows[i].RowState.ToString();
                    if (ls_rowStatus == "Added" || ls_rowStatus == "Modified")
                    {
                        int rowHandle = dgvDetails.GetRowHandle(i);                      
                        string mo_id = dgvDetails.GetRowCellDisplayText(rowHandle, "mo_id");
                        string temp_qty = dgvDetails.GetRowCellDisplayText(rowHandle, "temp_qty");
                        if (string.IsNullOrEmpty(dgvDetails.GetRowCellDisplayText(rowHandle, "goods_id")) || mo_id == "" || temp_qty == "0" ||
                            string.IsNullOrEmpty(dgvDetails.GetRowCellDisplayText(rowHandle, "unit_code")))
                        {
                            result = false;
                            MessageBox.Show(ls_tips, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            columnView.FocusedColumn = columnView.Columns["mo_id"];
                            columnView.ShowEditor();
                            break;
                        }
                        ////檢查頁數是否有效
                        //if (!clsCommon.Is_Exists_MO(mo_id))
                        //{
                        //    MessageBox.Show(ls_tips_mo, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //    columnView.FocusedColumn = columnView.Columns["mo_id"];
                        //    result = false;
                        //    break;
                        //}
                        //檢查物料是否有效
                        string strGoods_id = dgvDetails.GetRowCellDisplayText(rowHandle, "goods_id");
                        if (!clsCommon.Is_Exists_Goods(strGoods_id))
                        {
                            MessageBox.Show(ls_tips_goods, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            columnView.FocusedColumn = columnView.Columns["goods_id"];
                            columnView.ShowEditor();
                            result = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        private void Find_Doc()
        {
            DataSet dts = clsTempReceipt.Get_Data(txtID.Text);
            if (dts.Tables[0].Rows.Count > 0)
            {
                dtMostly = dts.Tables[0];
                bds_h.DataSource = dtMostly;
                dtDetail = dts.Tables[1];               
                bds_d.DataSource = dtDetail;               
                m_id = txtID.Text;    
            }
        }

        private void BTNFIND_Click(object sender, EventArgs e)
        {
            DataTable dtFind= clsTempReceipt.Find_Data(
                txtid1.Text, txtid2.Text, 
                dteir_date1.Text, dteir_date2.Text,
                luevendor_id1.EditValue.ToString(), luevendor_id2.EditValue.ToString(),
                luedept_id1.EditValue.ToString(), luedept_id2.EditValue.ToString(), 
                txtmo_id1.Text, txtmo_id2.Text);
            dgvFind.DataSource = dtFind;
            if (dtFind.Rows.Count == 0)
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_no_data"),"System Info");
            }
        }

        private void txtid1_Properties_Leave(object sender, EventArgs e)
        {
            txtmo_id2.Text = txtmo_id1.Text;
        }

        private void dteir_date1_Leave(object sender, EventArgs e)
        {
            dteir_date2.Text = dteir_date1.Text;
        }

        private void luevendor_id1_Leave(object sender, EventArgs e)
        {
            luevendor_id2.EditValue = luevendor_id1.EditValue;
        }

        private void luedept_id1_Leave(object sender, EventArgs e)
        {
            luedept_id2.EditValue  = luedept_id1.EditValue;
        }

        private void txtmo_id1_Leave(object sender, EventArgs e)
        {
            txtmo_id2.Text = txtmo_id1.Text;
        }

        private void luevendor_id_EditValueChanged(object sender, EventArgs e)
        {
            if (m_state != ""&& luevendor_id.Text !="")
            {
                txtvendor.Text = luevendor_id.GetColumnValue("name").ToString();
            }
        }

        private void dgvFind_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFind.Rows.Count > 0 && m_state == "")
            {               
                txtID.Text = dgvFind.CurrentRow.Cells["id1"].Value.ToString();
                Find_Doc();
            }
        }

        private void cl_goods_id_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                dgvDetails.CloseEditor();
                string ls_goods_id = dgvDetails.GetRowCellDisplayText(dgvDetails.FocusedRowHandle, "goods_id");
                //if (!clsCommon.Is_Exists_Goods(ls_goods_id))
                //{
                //    // ColumnView columnView = dgvDetails;

                //    //ColumnView columnView = (ColumnView)dgvDetails;                    
                //    //columnView.FocusedColumn = columnView.Columns["goods_id"];
                //    //columnView.Focus();                   
                //    //columnView.ShowEditor();     
                //    SetFocuse(dgvDetails, dgvDetails.FocusedRowHandle, ls_goods_id);
                //    return;
                //}
                if (lueseparate.EditValue.ToString() == "1")
                {
                    //手工輸入帶出物料基本資料中的描述
                    string ls_goods_name = clsApp.ExecuteSqlReturnObject(string.Format(@"Select english_name From it_goods with(nolock) where id='{0}'", ls_goods_id));
                    dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "goods_name", ls_goods_name);
                }
            }
        }

        /// <summary>
        /// 設置某單元格獲得焦點
        /// </summary>
        /// <param name="view"></param>
        /// <param name="rowHandle"></param>
        /// <param name="columnName"></param>
        private void SetFocuse(DevExpress.XtraGrid.Views.Grid.GridView view, Int32 rowHandle, string columnName)
        {
            view.Focus();
            view.FocusedRowHandle = rowHandle;
            view.FocusedColumn = view.Columns[columnName];
            //view.ShowEditor();

            //DoMouseClick();
            dgvDetails.SelectCell(rowHandle, view.FocusedColumn);
            dgvDetails.ShowEditor();
           
            // MouseFlag.AutoClick(201, 32);


            //    MouseHelper.SetCursorPos(201, 32);
            //    MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
            //    MouseHelper.mouse_event(MouseHelper.MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
        }




        private void cl_mo_id_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                //檢查頁數有效性
                //if (!clsCommon.Is_Exists_MO(dgvDetails.GetRowCellDisplayText(dgvDetails.FocusedRowHandle, "mo_id")))
                //{
                //   Set_gridView_Focus();
                //}         
            }
        }

        private void Calculation_fact_qty(bool is_recipt)
        {
            if (m_state !="")
            {
                float lf_fact_qty, lf_temp_qty, lf_temp_qty_original, lf_m_receipt_qty, lf_m_receipt_qty_original, lf_fact_qty_original,lf_total_sum;
                if (is_recipt)
                {
                    lf_fact_qty = objApp.Return_Float_Value(dgvDetails.GetRowCellDisplayText(dgvDetails.FocusedRowHandle, "temp_qty")) + objApp.Return_Float_Value(dgvDetails.GetRowCellDisplayText(dgvDetails.FocusedRowHandle, "m_receipt_qty"));
                    dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "fact_qty", lf_fact_qty);
                }
                else
                {
                    //還原舊值                    
                    //獲取修改前的原始值
                    int cur_row = dgvDetails.FocusedRowHandle;                    
                    lf_temp_qty = objApp.Return_Float_Value(dgvDetails.GetRowCellDisplayText(cur_row, "temp_qty"));
                    lf_m_receipt_qty = objApp.Return_Float_Value(dgvDetails.GetRowCellDisplayText(cur_row, "m_receipt_qty"));                    
                    DataRow myDataRow = dgvDetails.GetDataRow(cur_row);
                    try
                    {
                        lf_temp_qty_original = objApp.Return_Float_Value(myDataRow["temp_qty", DataRowVersion.Original].ToString());
                    }
                    catch (Exception)
                    {
                        //新增的行因不存在原始值,重新取原始值會引發異常,故作此處理
                        lf_temp_qty_original = 0;
                    }

                    try
                    {
                        lf_m_receipt_qty_original = objApp.Return_Float_Value(myDataRow["m_receipt_qty", DataRowVersion.Original].ToString());
                    }
                    catch (Exception)
                    {
                        lf_m_receipt_qty_original = 0;
                    }

                    try
                    {
                        lf_fact_qty_original = objApp.Return_Float_Value(myDataRow["fact_qty", DataRowVersion.Original].ToString());
                    }
                    catch (Exception)
                    {
                        lf_fact_qty_original = 0;
                    }
                    dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "temp_qty", lf_temp_qty_original);
                    dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "m_receipt_qty", lf_m_receipt_qty_original);
                    dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "fact_qty", lf_fact_qty_original);                    
                }
                //Amount
                lf_total_sum = objApp.Return_Float_Value(dgvDetails.GetRowCellDisplayText(dgvDetails.FocusedRowHandle, "fact_qty")) * objApp.Return_Float_Value(dgvDetails.GetRowCellDisplayText(dgvDetails.FocusedRowHandle, "price"));
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "total_sum", lf_total_sum);
                
            }
        }

        private void cl_temp_qty_Leave(object sender, EventArgs e)
        {
            Input_qty();
        }

        private void cl_m_receipt_qty_Leave(object sender, EventArgs e)
        {
            Input_qty();
        }

        private void Input_qty()
        {
            if(m_state=="")
            {
                return;
            }
            if (lueseparate.EditValue.ToString() == "2")//根據采購單
            {
                //檢查是否可以收貨
                dgvDetails.CloseEditor();
                DataRow myDataRow = dgvDetails.GetDataRow(dgvDetails.FocusedRowHandle);
                if (clsTempReceipt.Verify_recipt_qty(myDataRow))
                {
                    //可以收貨
                    Calculation_fact_qty(true);
                }
                else
                    Calculation_fact_qty(false);
            }
            else
            {
                //不檢查是否超收,直接收貨
                Calculation_fact_qty(true);
            }
        }


        /// <summary>
        /// 非新增或編輯狀態下雙擊打開編輯窗體
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2) // 判断是否是用鼠标双击    
            {
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo ghi = dgvDetails.CalcHitInfo(new Point(e.X, e.Y));
                if (ghi.InRow)  // 判断光标是否在行内    
                {
                    Open_Edit_Window();
                }
            }
           

        }

       
        //新增或編輯狀態下雙擊表格彈出編輯窗體
        private void dgvDetails_ShownEditor(object sender, EventArgs e)
        {           
            DevExpress.XtraGrid.Views.Grid.GridView view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            view.ActiveEditor.DoubleClick += new EventHandler(ActiveEditor_DoubleClick);
            
        }

        private void ActiveEditor_DoubleClick(object sender, System.EventArgs e)
        {
            Open_Edit_Window();
        }

      

        private void Open_Edit_Window()
        {
            if (m_state != "")
            {
                dgvDetails.CloseEditor();//使輸入或更改有效
            }
            using (frmPoReceiptEdit ofrm = new frmPoReceiptEdit(this, m_state, txtID.Text, lueseparate.EditValue.ToString()))
            {
                ofrm.ShowDialog();
            }
        }

        private void cl_location_id_EditValueChanged(object sender, EventArgs e)
        {
            if(m_state !="")
            {
                dgvDetails.CloseEditor();//使輸入或更改有效
                string ls_location_id = dgvDetails.GetRowCellValue(dgvDetails.FocusedRowHandle, "location_id").ToString();
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "location", ls_location_id);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "carton_code", ls_location_id);
            }
        }


        private void dgvDetails_ValidatingEditor(object sender, DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventArgs e)
        {
            if (!String.IsNullOrEmpty(e.Value.ToString()))
            {
                //检查货品編碼是否存在
                if (dgvDetails.FocusedColumn.FieldName == "goods_id")
                {                   
                    if (!clsCommon.Is_Exists_Goods(e.Value.ToString()))
                    {
                        e.ErrorText = clsCommon.GetTitle("t_msg_goods_not_exists");
                        e.Valid = false;
                    }
                    //decimal v = 0;
                    //if (!Decimal.TryParse(e.Value.ToString(), out v))
                    //{
                    //    e.ErrorText = "货品价格输入错误！";
                    //    e.Valid = false;
                    //}
                }
            }
        }

        private void luestate_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(luestate.Text))
            {
                SetButton_ApproveSatus(luestate.EditValue.ToString());
            }
        }

        private void SetButton_ApproveSatus(string state)
        {                    
            switch (state)
            {
                case "0":
                    luestate.EditValue = "0";//txtState.Text = "未批準";
                    if (DBUtility._language == "2")
                        BTNAPPROVE.Text = "Approve(&Y)";
                    else
                    {
                        BTNAPPROVE.Text = "批準(&Y)";
                        BTNAPPROVE.Tag = "0";
                    }
                    m_image_file = m_image_path + "Images\\p_ok.png";
                    if (File.Exists(m_image_file))
                    {
                        BTNAPPROVE.Image = Image.FromFile(m_image_file);
                    }
                    break;
                case "1":
                    luestate.EditValue = "1"; // txtState.Text = "已批準";
                    if (DBUtility._language == "2")
                        BTNAPPROVE.Text = "Un Approve(&Y)";
                    else
                    {
                        BTNAPPROVE.Text = "反批準(&Y)";
                        BTNAPPROVE.Tag = "1";
                    }
                    m_image_file = m_image_path + "Images\\p_unok.png";
                    if (File.Exists(m_image_file))
                    {
                        BTNAPPROVE.Image = Image.FromFile(m_image_file);
                    }
                    break;
                case "2":
                    luestate.EditValue = "2"; // txtState.Text = "已注銷狀態";
                    if (DBUtility._language == "2")
                        BTNAPPROVE.Text = "Approve(&Y)";
                    else
                    {
                        BTNAPPROVE.Text = "批準(&Y)";
                        BTNAPPROVE.Tag = "2";
                    }
                    m_image_file = m_image_path + "Images\\p_ok.png";
                    if (File.Exists(m_image_file))
                    {
                        BTNAPPROVE.Image = Image.FromFile(m_image_file);
                    }
                    BTNAPPROVE.Enabled = false;
                    break;
            }
        }
    }
}
