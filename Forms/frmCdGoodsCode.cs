using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cfvn.CLS;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;

namespace cfvn.Forms
{
    public partial class frmCdGoodsCode : DockContent
    {
        DataTable dtDetail = new DataTable();
        public SqlDataAdapter SDA;
        public string mState = "";
        private const string mTitle = "Operation Information";
        SqlConnection conn;
        private clsPublicOfVN clsApp = new clsPublicOfVN();
        clsToolBar objToolbar;  
 
        public frmCdGoodsCode()
        {
            InitializeComponent();
            
            //翻譯
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();

            //權限
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.SetToolBar();
            objToolbar.Set_Button_Image(toolStrip1);
        }

        private void frmCdGoodsCode_Load(object sender, EventArgs e)
        {
            dgvDetails.AutoGenerateColumns = false;
            Load_Date();
            Set_DataBindings();
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(state, DBUtility._language);
            //管制類型            
            clsGoodsCode.Set_DropBox_For_Modality(modality, DBUtility._language);
            //取值方式
            clsGoodsCode.Set_Genno(sfm_1);
            clsGoodsCode.Set_Genno(sfm_2);
            clsGoodsCode.Set_Genno(sfm_3);
            clsGoodsCode.Set_Genno(sfm_4);
            clsGoodsCode.Set_Genno(sfm_5);
            clsGoodsCode.Set_Genno(sfm_6);
            clsGoodsCode.Set_Genno(sfm_7);
            clsGoodsCode.Set_Genno(sfm_8);
            clsGoodsCode.Set_Genno(sfm_9);
            clsGoodsCode.Set_Genno(sfm_10);

            Set_Goods_id_Format();
            
        }

        private void frmCdGoodsCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtDetail = null;
            SDA = null;
            conn.Close();
            conn.Dispose();
            clsApp = null;
            objToolbar = null;
        }

        private void Load_Date()
        {
            dtDetail.Clear();           
            const string sql = @"SELECT * From cd_goodscode with(nolock) Where state<>'2'";            
            conn = new SqlConnection(DBUtility.ConnectionString);
            SDA = new SqlDataAdapter(sql, conn);
            SDA.Fill(dtDetail);

            bds1.DataSource = dtDetail;
            dgvDetails.DataSource = bds1;
        }

        private void Set_DataBindings()
        {
            log_no.DataBindings.Add("Text", bds1, "log_no");
            type.DataBindings.Add("Text", bds1, "type");
            modality.DataBindings.Add("EditValue", bds1, "modality");
            english_type.DataBindings.Add("Text", bds1, "english_type");

            segment_length_1.DataBindings.Add("Text", bds1, "segment_length_1");
            segment_length_2.DataBindings.Add("Text", bds1, "segment_length_2");
            segment_length_3.DataBindings.Add("Text", bds1, "segment_length_3");
            segment_length_4.DataBindings.Add("Text", bds1, "segment_length_4");
            segment_length_5.DataBindings.Add("Text", bds1, "segment_length_5");
            segment_length_6.DataBindings.Add("Text", bds1, "segment_length_6");
            segment_length_7.DataBindings.Add("Text", bds1, "segment_length_7");
            segment_length_8.DataBindings.Add("Text", bds1, "segment_length_8");
            segment_length_9.DataBindings.Add("Text", bds1, "segment_length_9");
            segment_length_10.DataBindings.Add("Text", bds1, "segment_length_10");

            segment_name_1.DataBindings.Add("Text", bds1, "segment_name_1");
            segment_name_2.DataBindings.Add("Text", bds1, "segment_name_2");
            segment_name_3.DataBindings.Add("Text", bds1, "segment_name_3");
            segment_name_4.DataBindings.Add("Text", bds1, "segment_name_4");
            segment_name_5.DataBindings.Add("Text", bds1, "segment_name_5");
            segment_name_6.DataBindings.Add("Text", bds1, "segment_name_6");
            segment_name_7.DataBindings.Add("Text", bds1, "segment_name_7");
            segment_name_8.DataBindings.Add("Text", bds1, "segment_name_8");
            segment_name_9.DataBindings.Add("Text", bds1, "segment_name_9");
            segment_name_10.DataBindings.Add("Text", bds1, "segment_name_10");

            sfm_1.DataBindings.Add("EditValue", bds1, "sfm_1");
            sfm_2.DataBindings.Add("EditValue", bds1, "sfm_2");
            sfm_3.DataBindings.Add("EditValue", bds1, "sfm_3");
            sfm_4.DataBindings.Add("EditValue", bds1, "sfm_4");
            sfm_5.DataBindings.Add("EditValue", bds1, "sfm_5");
            sfm_6.DataBindings.Add("EditValue", bds1, "sfm_6");
            sfm_7.DataBindings.Add("EditValue", bds1, "sfm_7");
            sfm_8.DataBindings.Add("EditValue", bds1, "sfm_8");
            sfm_9.DataBindings.Add("EditValue", bds1, "sfm_9");
            sfm_10.DataBindings.Add("EditValue", bds1, "sfm_10");

            other_1.DataBindings.Add("EditValue", bds1, "other_1");
            other_2.DataBindings.Add("EditValue", bds1, "other_2");
            other_3.DataBindings.Add("EditValue", bds1, "other_3");
            other_4.DataBindings.Add("EditValue", bds1, "other_4");
            other_5.DataBindings.Add("EditValue", bds1, "other_5");
            other_6.DataBindings.Add("EditValue", bds1, "other_6");
            other_7.DataBindings.Add("EditValue", bds1, "other_7");
            other_8.DataBindings.Add("EditValue", bds1, "other_8");
            other_9.DataBindings.Add("EditValue", bds1, "other_9");
            other_10.DataBindings.Add("EditValue", bds1, "other_10");

            segment_start_1.DataBindings.Add("Text", bds1, "segment_start_1");
            segment_start_2.DataBindings.Add("Text", bds1, "segment_start_2");
            segment_start_3.DataBindings.Add("Text", bds1, "segment_start_3");
            segment_start_4.DataBindings.Add("Text", bds1, "segment_start_4");
            segment_start_5.DataBindings.Add("Text", bds1, "segment_start_5");
            segment_start_6.DataBindings.Add("Text", bds1, "segment_start_6");
            segment_start_7.DataBindings.Add("Text", bds1, "segment_start_7");
            segment_start_8.DataBindings.Add("Text", bds1, "segment_start_8");
            segment_start_9.DataBindings.Add("Text", bds1, "segment_start_9");
            segment_start_10.DataBindings.Add("Text", bds1, "segment_start_10");

            //segment_end_1.DataBindings.Add("Text", bds1, "segment_end_1");
            //segment_end_2.DataBindings.Add("Text", bds1, "segment_end_2");
            //segment_end_3.DataBindings.Add("Text", bds1, "segment_end_3");
            //segment_end_4.DataBindings.Add("Text", bds1, "segment_end_4");
            //segment_end_5.DataBindings.Add("Text", bds1, "segment_end_5");
            //segment_end_6.DataBindings.Add("Text", bds1, "segment_end_6");
            //segment_end_7.DataBindings.Add("Text", bds1, "segment_end_7");
            //segment_end_8.DataBindings.Add("Text", bds1, "segment_end_8");
            //segment_end_9.DataBindings.Add("Text", bds1, "segment_end_9");
            //segment_end_10.DataBindings.Add("Text", bds1, "segment_end_10");
            
            //segment_end_1.DataBindings.Add("Text", bds1, "segment_end_1");
            //segment_end_2.DataBindings.Add("Text", bds1, "segment_end_2");
            //segment_end_3.DataBindings.Add("Text", bds1, "segment_end_3");
            //segment_end_4.DataBindings.Add("Text", bds1, "segment_end_4");
            //segment_end_5.DataBindings.Add("Text", bds1, "segment_end_5");
            //segment_end_6.DataBindings.Add("Text", bds1, "segment_end_6");
            //segment_end_7.DataBindings.Add("Text", bds1, "segment_end_7");
            //segment_end_8.DataBindings.Add("Text", bds1, "segment_end_8");
            //segment_end_9.DataBindings.Add("Text", bds1, "segment_end_9");
            //segment_end_10.DataBindings.Add("Text", bds1, "segment_end_10");

            sfx_1.DataBindings.Add("Text", bds1, "sfx_1");
            sfx_2.DataBindings.Add("Text", bds1, "sfx_2");
            sfx_3.DataBindings.Add("Text", bds1, "sfx_3");
            sfx_4.DataBindings.Add("Text", bds1, "sfx_4");
            sfx_5.DataBindings.Add("Text", bds1, "sfx_5");
            sfx_6.DataBindings.Add("Text", bds1, "sfx_6");
            sfx_7.DataBindings.Add("Text", bds1, "sfx_7");
            sfx_8.DataBindings.Add("Text", bds1, "sfx_8");
            sfx_9.DataBindings.Add("Text", bds1, "sfx_9");
            sfx_10.DataBindings.Add("Text", bds1, "sfx_10");

            fixation_value_1.DataBindings.Add("Text", bds1, "fixation_value_1");
            fixation_value_2.DataBindings.Add("Text", bds1, "fixation_value_2");
            fixation_value_3.DataBindings.Add("Text", bds1, "fixation_value_3");
            fixation_value_4.DataBindings.Add("Text", bds1, "fixation_value_4");
            fixation_value_5.DataBindings.Add("Text", bds1, "fixation_value_5");
            fixation_value_6.DataBindings.Add("Text", bds1, "fixation_value_6");
            fixation_value_7.DataBindings.Add("Text", bds1, "fixation_value_7");
            fixation_value_8.DataBindings.Add("Text", bds1, "fixation_value_8");
            fixation_value_9.DataBindings.Add("Text", bds1, "fixation_value_9");
            fixation_value_10.DataBindings.Add("Text", bds1, "fixation_value_10");

            column_1.DataBindings.Add("EditValue", bds1, "column_1");
            column_2.DataBindings.Add("EditValue", bds1, "column_2");
            column_3.DataBindings.Add("EditValue", bds1, "column_3");
            column_4.DataBindings.Add("EditValue", bds1, "column_4");
            column_5.DataBindings.Add("EditValue", bds1, "column_5");
            column_6.DataBindings.Add("EditValue", bds1, "column_6");
            column_7.DataBindings.Add("EditValue", bds1, "column_7");
            column_8.DataBindings.Add("EditValue", bds1, "column_8");
            column_9.DataBindings.Add("EditValue", bds1, "column_9");
            column_10.DataBindings.Add("EditValue", bds1, "column_10");
            state.DataBindings.Add("EditValue", bds1, "state");

            create_by.DataBindings.Add("Text", bds1, "create_by");
            create_date.DataBindings.Add("Text", bds1, "create_date");
            update_by.DataBindings.Add("Text", bds1, "update_by");
            update_date.DataBindings.Add("Text", bds1, "Update_date");
        }
            
       
        private void sfm_1_EditValueChanged(object sender, EventArgs e)
        { 
            clsGoodsCode.SetValue(sfm_1.EditValue.ToString(), other_1, segment_start_1, fixation_value_1, column_1 ,mState);
            Call_Goods_id_Format(sfm_1);
        }

        private void sfm_2_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.SetValue(sfm_2.EditValue.ToString(), other_2, segment_start_2, fixation_value_2, column_2,mState);
            Call_Goods_id_Format(sfm_2); 
        }

        private void sfm_3_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.SetValue(sfm_3.EditValue.ToString(), other_3, segment_start_3, fixation_value_3, column_3, mState);
            Call_Goods_id_Format(sfm_3); 
        }

        private void sfm_4_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.SetValue(sfm_4.EditValue.ToString(), other_4, segment_start_4, fixation_value_4, column_4, mState);
            Call_Goods_id_Format(sfm_4); 
        }

        private void sfm_5_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.SetValue(sfm_5.EditValue.ToString(), other_5, segment_start_5, fixation_value_5, column_5, mState);
            Call_Goods_id_Format(sfm_5); 
        }

        private void sfm_6_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.SetValue(sfm_6.EditValue.ToString(), other_6, segment_start_6, fixation_value_6, column_6, mState);
            Call_Goods_id_Format(sfm_6); 
        }

        private void sfm_7_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.SetValue(sfm_7.EditValue.ToString(), other_7, segment_start_7, fixation_value_7, column_7, mState);
            Call_Goods_id_Format(sfm_7); 
        }

        private void sfm_8_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.SetValue(sfm_8.EditValue.ToString(), other_8, segment_start_8, fixation_value_8, column_8, mState);
            Call_Goods_id_Format(sfm_8); 
        }

        private void sfm_9_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.SetValue(sfm_9.EditValue.ToString(), other_9, segment_start_9, fixation_value_9, column_9, mState);
            Call_Goods_id_Format(sfm_9);            
        }

        private void sfm_10_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.SetValue(sfm_10.EditValue.ToString(), other_10, segment_start_10, fixation_value_10, column_10, mState);
            Call_Goods_id_Format(sfm_10);
        }

        private void Set_Goods_id_Format()
        {
            if (dgvDetails.Rows.Count > 0)
            {
                //長度編號
                goodscode_length.Text = (
                    segment_length_1.Text==""?0:int.Parse(segment_length_1.Text) + (string.IsNullOrEmpty(sfx_1.Text) ? "" : sfx_1.Text).Length +
                    segment_length_2.Text == "" ? 0 : int.Parse(segment_length_2.Text) + (string.IsNullOrEmpty(sfx_2.Text) ? "" : sfx_2.Text).Length +
                    segment_length_3.Text == "" ? 0 : int.Parse(segment_length_3.Text) + (string.IsNullOrEmpty(sfx_3.Text) ? "" : sfx_3.Text).Length +
                    segment_length_4.Text == "" ? 0 : int.Parse(segment_length_4.Text) + (string.IsNullOrEmpty(sfx_4.Text) ? "" : sfx_4.Text).Length +
                    segment_length_5.Text == "" ? 0 : int.Parse(segment_length_5.Text) + (string.IsNullOrEmpty(sfx_5.Text) ? "" : sfx_5.Text).Length +
                    segment_length_6.Text == "" ? 0 : int.Parse(segment_length_6.Text) + (string.IsNullOrEmpty(sfx_6.Text) ? "" : sfx_6.Text).Length +
                    segment_length_7.Text == "" ? 0 : int.Parse(segment_length_7.Text) + (string.IsNullOrEmpty(sfx_7.Text) ? "" : sfx_7.Text).Length +
                    segment_length_8.Text == "" ? 0 : int.Parse(segment_length_8.Text) + (string.IsNullOrEmpty(sfx_8.Text) ? "" : sfx_8.Text).Length +
                    segment_length_9.Text == "" ? 0 : int.Parse(segment_length_9.Text) + (string.IsNullOrEmpty(sfx_9.Text) ? "" : sfx_9.Text).Length +
                    segment_length_10.Text == "" ? 0 : int.Parse(segment_length_10.Text) + (string.IsNullOrEmpty(sfx_10.Text) ? "" : sfx_10.Text).Length
                    ).ToString();

                //貨品格式            
                string ls_goods_id = "";
                ls_goods_id = clsGoodsCode.Set_Goods_id(segment_length_1, sfm_1, sfx_1, fixation_value_1);
                ls_goods_id += clsGoodsCode.Set_Goods_id(segment_length_2, sfm_2, sfx_2, fixation_value_2);
                ls_goods_id += clsGoodsCode.Set_Goods_id(segment_length_3, sfm_3, sfx_3, fixation_value_3);
                ls_goods_id += clsGoodsCode.Set_Goods_id(segment_length_4, sfm_4, sfx_4, fixation_value_4);
                ls_goods_id += clsGoodsCode.Set_Goods_id(segment_length_5, sfm_5, sfx_5, fixation_value_5);
                ls_goods_id += clsGoodsCode.Set_Goods_id(segment_length_6, sfm_6, sfx_6, fixation_value_6);
                ls_goods_id += clsGoodsCode.Set_Goods_id(segment_length_7, sfm_7, sfx_7, fixation_value_7);
                ls_goods_id += clsGoodsCode.Set_Goods_id(segment_length_8, sfm_8, sfx_8, fixation_value_8);
                ls_goods_id += clsGoodsCode.Set_Goods_id(segment_length_9, sfm_9, sfx_9, fixation_value_9);
                ls_goods_id += clsGoodsCode.Set_Goods_id(segment_length_10, sfm_10, sfx_10, fixation_value_10);
                goods_id.Text = ls_goods_id;
            }
        }

        private void Call_Goods_id_Format(DevExpress.XtraEditors.LookUpEdit sfm)
        {
            if (sfm.Text != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void segment_start_1_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.Set_lenth(segment_length_1, segment_start_1, segment_end_1);
        }

        private void segment_start_2_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.Set_lenth(segment_length_2, segment_start_2, segment_end_2);
        }        

        private void segment_start_3_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.Set_lenth(segment_length_3, segment_start_3, segment_end_3);
        }

        private void segment_start_4_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.Set_lenth(segment_length_4, segment_start_4, segment_end_4);
        }

        private void segment_start_5_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.Set_lenth(segment_length_5, segment_start_5, segment_end_5);
        }

        private void segment_start_6_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.Set_lenth(segment_length_6, segment_start_6, segment_end_6);
        }

        private void segment_start_7_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.Set_lenth(segment_length_7, segment_start_7, segment_end_7);
        }

        private void segment_start_8_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.Set_lenth(segment_length_8, segment_start_8, segment_end_8);
        }

        private void segment_start_9_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.Set_lenth(segment_length_9, segment_start_9, segment_end_9);
        }

        private void segment_start_10_EditValueChanged(object sender, EventArgs e)
        {
            clsGoodsCode.Set_lenth(segment_length_10, segment_start_10, segment_end_10);
        }

        private void dgvDetails_SelectionChanged(object sender, EventArgs e)
        {
            Set_Goods_id_Format();
        }        

        private void SetButtonSatus(bool _flag)
        {
            btnNew.Enabled = _flag;
            btnEdit.Enabled = _flag;
            btnDelete.Enabled = _flag;
           
            btnSave.Enabled = !_flag;
            btnUndo.Enabled = !_flag;

            if (objToolbar != null)
            {
                objToolbar.SetToolBar();
            }
           
        }

        private void btnNew_Click(object sender, EventArgs e)
        {          
            bds1.AddNew();
            bds1.EndEdit();
            mState = "NEW";
            SetButtonSatus(false);
            
            ////dgvDetails.DataSource = dtDetail;
            //dgvDetails.MultiSelect = false;
            //// dgvRecView.Rows[dgvRecView.Rows.Count - 1].Selected = true;
            //dgvDetails.CurrentCell = dgvDetails.Rows[0].Cells[0];
            //dgvDetails.CurrentCell = dgvDetails.Rows[this.dgvDetails.Rows.Count - 1].Cells[0];

            SetObjValue.SetEditBackColor(panel1.Controls, true);
            state.EditValue = "0";
            create_by.Text = DBUtility._user_id;
            create_date.Text = DateTime.Now.Date.ToString();
            string ls_max_serial = clsApp.ExecuteSqlReturnObject(@"Select CONVERT(int,max(log_no)) + 1 as log_no FROM dbo.cd_goodscode");
            if (ls_max_serial != "")
            {
                log_no.Text = string.Format("{0:d4}", int.Parse(ls_max_serial));
            }
            else
            {
                log_no.Text = string.Format("{0:d4}", 1);
            }

            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (log_no.Text == "")
            {
                return;
            }
            mState = "Edit";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            update_by.Text = DBUtility._user_id;
            update_date.Text = DateTime.Now.Date.ToString();
            
            type.Properties.ReadOnly = true;
            type.BackColor = Color.White;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDetails.Rows.Count == 0)
            {
                return;
            }

            if (MessageBox.Show("Verify that you want to delete the current recor？", mTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //modify Current row state to Cancel
                    state.EditValue = "2";
                    bds1.EndEdit();                    
                    //数据库中进行删除
                    SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                    SDA.UpdateCommand = SCB.GetUpdateCommand();
                    SDA.Update(dtDetail);
                    MessageBox.Show("Successful deletion！", mTitle);
                    SCB = null;
                    Load_Date();
                    //dgvDetails.Rows.RemoveAt(dgvDetails.CurrentCell.RowIndex);//remove Current Row 
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (type.Text == "" && modality.Text == "")
            {
                MessageBox.Show("Coding type cannot be empty ", mTitle);
                type.Focus();
                return;
            }
            if (modality.Text == "")
            {
                MessageBox.Show("Modality type cannot be empty ", mTitle);
                modality.Focus();
                return;
            }

            if (dgvDetails.Rows.Count == 0)
            {
                return;
            }
            //bds1.EndEdit();
            //dgvDetails.CurrentCell.RowIndex;行號           
            //Select a Cell Focus
            dgvDetails.CurrentCell = dgvDetails.Rows[0].Cells["type1"];
            //Selected a Row 
            dgvDetails.Rows[0].Selected = true;

            bool flag_datavalid = false;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                if (dgvDetails.Rows[i].Cells["type1"].Value.ToString() == "")
                {
                    flag_datavalid = true;
                    dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells["type1"];//選中當前空白的行                    
                    break;
                }
            }
            if (flag_datavalid)
            {
                MessageBox.Show("Data should not be empty!", mTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                bds1.EndEdit();
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.InsertCommand = SCB.GetInsertCommand();
                SDA.UpdateCommand = SCB.GetUpdateCommand();

                SDA.Update(dtDetail);
                MessageBox.Show("Save Successful！", mTitle);
                SCB = null;

                SetButtonSatus(true);
                SetObjValue.SetEditBackColor(panel1.Controls, false);
                mState = "";
                type.Properties.ReadOnly = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }


        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            dtDetail.RejectChanges();
            bds1.CancelEdit();
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(panel1.Controls, false);           
            mState = "";
            type.Properties.ReadOnly = true;
            //Load_Date();
        }
       

        private void sfm_1_Leave(object sender, EventArgs e)
        {
            clsGoodsCode.Check_Length(segment_length_1, sfm_1, mState,fixation_value_1);
        }

        private void sfm_2_Leave(object sender, EventArgs e)
        {
            clsGoodsCode.Check_Length(segment_length_2, sfm_2, mState, fixation_value_1);
        }

        private void sfm_3_Leave(object sender, EventArgs e)
        {
            clsGoodsCode.Check_Length(segment_length_3, sfm_3, mState, fixation_value_1);
        }

        private void sfm_4_Leave(object sender, EventArgs e)
        {
            clsGoodsCode.Check_Length(segment_length_4, sfm_4, mState, fixation_value_1);
        }

        private void sfm_5_Leave(object sender, EventArgs e)
        {
            clsGoodsCode.Check_Length(segment_length_5, sfm_5, mState, fixation_value_1);
        }

        private void sfm_6_Leave(object sender, EventArgs e)
        {
            clsGoodsCode.Check_Length(segment_length_6, sfm_6, mState, fixation_value_1);
        }

        private void sfm_7_Leave(object sender, EventArgs e)
        {
            clsGoodsCode.Check_Length(segment_length_7, sfm_7, mState, fixation_value_1);
        }

        private void sfm_8_Leave(object sender, EventArgs e)
        {
            clsGoodsCode.Check_Length(segment_length_8, sfm_8, mState, fixation_value_1);
        }

        private void sfm_9_Leave(object sender, EventArgs e)
        {
            clsGoodsCode.Check_Length(segment_length_9, sfm_9, mState, fixation_value_1);
        }

        private void sfm_10_Leave(object sender, EventArgs e)
        {
            clsGoodsCode.Check_Length(segment_length_10, sfm_10, mState, fixation_value_1);
        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {
            english_type.Focus();
        }

        private void goods_id_EditValueChanged(object sender, EventArgs e)
        {
            if (goods_id.Text != "")
            {
                goodscode_length.Text = goods_id.Text.Length.ToString();
            }
        }

        private void segment_length_1_EditValueChanged(object sender, EventArgs e)
        {
            if (mState!="")
            {
                Set_Goods_id_Format();
            }
        }

        private void segment_length_2_EditValueChanged(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void segment_length_3_EditValueChanged(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void segment_length_4_EditValueChanged(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void segment_length_5_EditValueChanged(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void segment_length_6_EditValueChanged(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void segment_length_7_EditValueChanged(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void segment_length_8_EditValueChanged(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void segment_length_9_EditValueChanged(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void segment_length_10_EditValueChanged(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void sfx_1_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void sfx_2_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void sfx_3_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void sfx_4_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void sfx_5_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void sfx_6_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void sfx_7_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void sfx_8_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void sfx_9_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void sfx_10_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void fixation_value_1_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void fixation_value_2_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void fixation_value_3_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void fixation_value_4_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void fixation_value_5_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void fixation_value_6_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void fixation_value_7_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void fixation_value_8_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void fixation_value_9_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }

        private void fixation_value_10_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Set_Goods_id_Format();
            }
        }    
        
    
    }
}
