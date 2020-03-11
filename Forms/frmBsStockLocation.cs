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
using WeifenLuo.WinFormsUI.Docking;

namespace cfvn.Forms
{
    public partial class frmBsStockLocation : DockContent //Form
    {
        
        public string m_id = "";    //臨時的主鍵值       
        public string m_state = ""; //新增或編號的狀態        
        public static string str_language = "0";
        public string m_msg_custom;
        public bool m_save_flag;
        string m_image_path = AppDomain.CurrentDomain.BaseDirectory;
        //string m_image_file = "";
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

       
        public frmBsStockLocation()
        {
            InitializeComponent();
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();

            //權限
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.SetToolBar();
            objToolbar.Set_Button_Image(toolStrip1);
        }

        private void frmBsStockLocation_Load(object sender, EventArgs e)
        {
            //狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);

            //主表結構
            const string ls_mostly = @"SELECT * FROM dbo.bs_productline WHERE 1=0";
            dtMostly = clsApp.GetDataTable(ls_mostly);
            bds_h.DataSource = dtMostly;

            //生成明細結構
            string ls_details = @"SELECT *,id as origin_id FROM dbo.bs_carton_code WHERE 1=0";
            dtDetail = clsApp.GetDataTable(ls_details);
            bds_d.DataSource = dtDetail;
            gridControl1.DataSource = bds_d;
         
            //生成臨時項目刪除表結構
            dtTempDel = dtDetail.Clone();
          
            //主表數據綁定
            Set_DataBindings();

        }

        private void frmBsStockLocation_FormClosed(object sender, FormClosedEventArgs e)
        {
            //
        }

        private void Set_DataBindings()
        {
            txtID.DataBindings.Add("Text", bds_h, "id");            
            txtname.DataBindings.Add("Text", bds_h, "name");
            txtarea.DataBindings.Add("Text", bds_h, "area");
            txtremark.DataBindings.Add("Text", bds_h, "remark");
            luestate.DataBindings.Add("EditValue", bds_h, "state");
            txtcreate_by.DataBindings.Add("Text", bds_h, "create_by");
            txtcreate_date.DataBindings.Add("Text", bds_h, "create_date");
            txtupdate_by.DataBindings.Add("Text", bds_h, "update_by");
            txtupdate_date.DataBindings.Add("Text", bds_h, "update_date");           
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
            luestate.EditValue = "0";
            txtID.Text = ""; clsTempReceipt.GetMaxNo();
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
                objToolbar.Set_Button_Enable_Status(toolStrip1, false);
                objToolbar.SetToolBar();//重檢查按鈕的權限
                SetObjValue.SetEditBackColor(tabPoPurchase.TabPages[0].Controls, true);
                Set_Grid_Status(true);
                m_state = "EDIT";
                txtID.Properties.ReadOnly = true;
                txtID.BackColor = System.Drawing.Color.White;
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
                string sql_d = string.Format(@"UPDATE dbo.bs_productline Set state = '2' WHERE id = '{0}'", txtID.Text);
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
            const string str1 = @"Update dbo.bs_productline Set state=@state Where id=@id";
            //反批準
            const string str2 = @"Update dbo.bs_productline Set state=@state ,update_by=@user_id,update_date=getdate() Where id=@id";
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
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "location_id", txtID.Text);
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
                    dr["location_id"] = txtID.Text;                    
                    dr["id"] = dgvDetails.GetRowCellDisplayText(row, "id");
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

            bool save_flag = false;
            #region  保存新增
            if (m_state == "NEW" || m_state == "EDIT")
            {
                if (m_state == "NEW")
                {
                    string ls_sql = String.Format("Select '1' FROM dbo.bs_productline WHERE id='{0}'", txtID.Text);
                    if (clsCommon.Valid_Doc(ls_sql)) //檢查主鍵是否存在
                    {
                        //重新取最大單據編號
                        //MessageBox.Show(clsCommon.GetTitle("t_msg_is_exists_key")+"["+txtID.Text+"]","System Info");
                        return;
                    }
                }
                const string ls_sql_i =
                    @"INSERT dbo.bs_productline(id,name,area,state,remark,part_mrp,create_date,create_by) 
					  VALUES(@id,@name,@area,@state,@remark,@part_mrp,getdate(),@user_id)";
                const string ls_sql_u =
                    @"UPDATE dbo.bs_productline 
                     SET name=@name,area=@area,state=@state,remark=@remark,part_mrp=@part_mrp,update_date=getdate(),update_by=@user_id
                     WHERE id=@id";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);
                myCon.Open();
                SqlTransaction myTrans = myCon.BeginTransaction();
                using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
                {
                    try
                    {
                        if (m_state == "NEW")
                        {
                            myCommand.CommandText = ls_sql_i;
                        }
                        else
                        {
                            myCommand.CommandText = ls_sql_u;
                        }
                        myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@id", txtID.Text.Trim()); 
                        myCommand.Parameters.AddWithValue("@name", txtname.Text);
                        myCommand.Parameters.AddWithValue("@area", txtarea.Text);
                        myCommand.Parameters.AddWithValue("@state", luestate.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@remark", txtremark.Text);                        
                        myCommand.Parameters.AddWithValue("@part_mrp", chkpart_mrp.Checked?true :false );
                        myCommand.Parameters.AddWithValue("@user_id", DBUtility._user_id);
                        myCommand.ExecuteNonQuery();

                        //處理明細資料
                        string ls_row_status = "";
                        if (dgvDetails.RowCount > 0)
                        {
                            const string sql_item_i =
                                @"INSERT INTO dbo.bs_carton_code(location_id,id,name,part_mrp,public_inventory,remark,lot_prefix)
                                VALUES(@location_id,@id,@name,@part_mrp,@public_inventory,@remark,@lot_prefix)";
                            const string sql_item_u =
                                @"UPDATE dbo.bs_carton_code 
                                SET id=@id,name=@name,part_mrp=@part_mrp,public_inventory=@public_inventory,remark=@remark,lot_prefix=@lot_prefix
                                WHERE location_id=@location_id and id=@origin_id";
                            const string sql_item_d = @"DELETE FROM dbo.bs_carton_code WHERE location_id=@location_id and id=@id";
                            //處進點擊[項目刪除]操作刪除的記錄
                            if (m_state == "EDIT")
                            {
                                if (dtTempDel.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dtTempDel.Rows.Count; i++)
                                    {
                                        myCommand.CommandText = sql_item_d;
                                        myCommand.Parameters.Clear();
                                        myCommand.Parameters.AddWithValue("@location_id", txtID.Text.Trim());                         
                                        myCommand.Parameters.AddWithValue("@id", dtTempDel.Rows[i]["id"].ToString());
                                        myCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                            //保存明細                            
                            for (int i = 0; i < dtDetail.Rows.Count; i++)
                            {                                
                                ls_row_status = dtDetail.Rows[i].RowState.ToString();
                                if (ls_row_status == "Added" || ls_row_status == "Modified")
                                {
                                    myCommand.Parameters.Clear();
                                    if (ls_row_status == "Added")
                                    {
                                        myCommand.CommandText = sql_item_i;
                                        //ls_seq_id = clsTempReceipt.Get_Details_Seq(txtID.Text.Trim()); //新增狀態重新取最大序號;                                        
                                        //dgvDetails.SetRowCellValue(i, "sequence_id", ls_seq_id);
                                    }
                                    else
                                    {
                                        myCommand.CommandText = sql_item_u;
                                        myCommand.Parameters.AddWithValue("@origin_id", dtDetail.Rows[i]["origin_id"].ToString());
                                        //ls_seq_id = dtDetail.Rows[i]["sequence_id"].ToString(); //編輯時序號;
                                    }
                                    if (m_state == "NEW")
                                    {
                                        dgvDetails.SetRowCellValue(i, "location_id", txtID.Text);
                                        myCommand.Parameters.AddWithValue("@location_id", txtID.Text);
                                    }
                                    else
                                    {
                                        myCommand.Parameters.AddWithValue("@location_id", dtDetail.Rows[i]["location_id"].ToString());
                                    }
                                    myCommand.Parameters.AddWithValue("@id", dtDetail.Rows[i]["id"].ToString());
                                    myCommand.Parameters.AddWithValue("@name", dtDetail.Rows[i]["name"].ToString());
                                    myCommand.Parameters.AddWithValue("@part_mrp", dtDetail.Rows[i]["part_mrp"].ToString()=="True"?true :false );
                                    myCommand.Parameters.AddWithValue("@public_inventory", dtDetail.Rows[i]["public_inventory"].ToString() == "True" ? true : false);
                                    myCommand.Parameters.AddWithValue("@remark", dtDetail.Rows[i]["remark"].ToString());//備註
                                    myCommand.Parameters.AddWithValue("@lot_prefix", dtDetail.Rows[i]["lot_prefix"].ToString());//批號前綴                                                                                          
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
                string ls_tips;
                if (DBUtility._language == "2")
                {
                    ls_tips = "Store Place or name cannot empty.";                    
                }
                else
                {
                    ls_tips = "貨架位置或名稱不可爲空!";                   
                }
                ColumnView columnView = dgvDetails;
                string ls_rowStatus = "";
                for (int i = 0; i < dgvDetails.RowCount; i++)
                {
                    ls_rowStatus = dtDetail.Rows[i].RowState.ToString();
                    if (ls_rowStatus == "Added" || ls_rowStatus == "Modified")
                    {
                        int rowHandle = dgvDetails.GetRowHandle(i);
                        string strId = dgvDetails.GetRowCellDisplayText(rowHandle, "id");
                        string strName = dgvDetails.GetRowCellDisplayText(rowHandle, "name");                        
                        if (string.IsNullOrEmpty(strName) || string.IsNullOrEmpty(strId))
                        {
                            result = false;
                            MessageBox.Show(ls_tips, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            columnView.FocusedColumn = columnView.Columns["id"];
                            columnView.ShowEditor();
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
            string ls_sql = string.Format(
                @"Select * FROM bs_productline with(nolock) Where id='{0}' and state<>'2'
                  Select B.*,B.id as origin_id FROM bs_productline A with(nolock), bs_carton_code B with(nolock) 
                  Where A.id=B.location_id and A.id='{0}' and A.state<>'2' Order by B.location_id,B.id", txtID.Text);
            DataSet dts = clsApp.ExcuteSqlReturnDataSet(ls_sql, null);
            if (dts.Tables[0].Rows.Count > 0)
            {
                dtMostly = dts.Tables[0];
                if(dtMostly.Rows[0]["part_mrp"].ToString() =="True")
                {
                    chkpart_mrp.Checked = true;
                }
                else
                {
                    chkpart_mrp.Checked = false;
                }
                bds_h.DataSource = dtMostly;
                dtDetail = dts.Tables[1];               
                bds_d.DataSource = dtDetail;               
                m_id = txtID.Text;    
            }
        }
        
        private void BTNFIND_Click(object sender, EventArgs e)
        {
            string ls_sql =
                @"Select A.id,A.name,B.id as storage_place,B.name as storage_place_name,B.part_mrp,B.public_inventory,B.remark,B.lot_prefix
                FROM bs_productline A with(nolock) 
                INNER JOIN bs_carton_code B with(nolock) ON A.id=B.location_id                
                WHERE 1>0 ";
            if (txtid1.Text != "")
                ls_sql += " AND A.id>='" + txtid1.Text + "'";
            if (txtid2.Text  != "")
                ls_sql += " AND A.id<='" + txtid2.Text + "'";
            if (txtname1.Text != "")
                ls_sql += " AND b.id >='" + txtname1.Text + "'";
            if (txtname2.Text != "")
                ls_sql += " AND b.id <='" + txtname2.Text + "'";
            ls_sql += " AND A.state<>'2' Order by A.id,B.id";
            DataTable dtFind = clsApp.GetDataTable(ls_sql);
            dgvFind.DataSource = dtFind;
            if (dtFind.Rows.Count == 0)
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_no_data"), "System Info");
            }
        }

        private void txtid1_Properties_Leave(object sender, EventArgs e)
        {
            txtid2.Text = txtid1.Text;
        }       

        private void txtmo_id1_Leave(object sender, EventArgs e)
        {
            txtname2.Text = txtname1.Text;
        }

        private void dgvFind_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFind.Rows.Count > 0 && m_state == "")
            {               
                txtID.Text = dgvFind.CurrentRow.Cells["id1"].Value.ToString();
                Find_Doc();
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


    }
}
