using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;
using cfvn.CLS;


namespace cfvn.Forms
{
    public partial class frmCdGoodsCodeA : DockContent
    {
        DataTable dtDetail = new DataTable();
        public SqlDataAdapter SDA;
        public string mState = "";
        SqlConnection conn;
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        //clsToolBar objToolbar;     

        public frmCdGoodsCodeA()
        {
            InitializeComponent();

            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();


            //create_by.Tag="1";
            //create_by.Enabled = false;
            //create_date.Tag = "1";
            //create_date.Enabled = false;
            //update_by.Tag="1";
            //update_by.Enabled = false;
            //update_date.Tag="1";
            //update_date.Enabled = false;

            //權限
            //objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            //objToolbar.SetToolBar();
        }

        private void frmCdGoodsCodeA_Load(object sender, EventArgs e)
        {  
            Load_Date();
            //數據綁定
            Set_DataBindings();
            
            
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(state, DBUtility._language);
            //管制類型
            string sql = @"SELECT id,english_name+'('+ name +')' as name FROM cd_goodscode_modality";
            DataTable dtModality = new DataTable();
            dtModality = clsApp.GetDataTable(sql);
            modality.Properties.DataSource = dtModality;
            modality.Properties.ValueMember = "id";
            modality.Properties.DisplayMember = "name";

            //log_no.MaxLength = 10;
            //txtName.textBox.DataBindings.Add("Text", bds1, "name");
            //txtTel.textBox.DataBindings.Add("Text", bds1, "tel");
            //txtFax.textBox.DataBindings.Add("Text", bds1, "fax");
            //txtContact.textBox.DataBindings.Add("Text", bds1, "contact");
            //txtContact_tel.textBox.DataBindings.Add("Text", bds1, "contact_tel");
            //txtRemark.textBox.DataBindings.Add("Text", bds1, "remark");           

            //txtCreate_by.textBox.DataBindings.Add("Text", bds1, "create_by");
            //txtCreate_date.textBox.DataBindings.Add("Text", bds1, "create_date");
            //txtUpdate_by.textBox.DataBindings.Add("Text", bds1, "update_by");
            //txtUpdate_date.textBox.DataBindings.Add("Text", bds1, "Update_date");
        }

        private void Load_Date()
        {
            dtDetail.Clear();
            //SELECT company,trade,fax_no,bank_name,bank_account,tel,address,contact FROM cd_company;
            const string sql = @"SELECT * From cd_goodscode with(nolock)";
            //dtDetail = clsPublicOfVN.GetDataTable(sql);
            conn = new SqlConnection(DBUtility.ConnectionString);
            SDA = new SqlDataAdapter(sql, conn);
            SDA.Fill(dtDetail);
           
            bds1.DataSource = dtDetail;
            dgvDetails.DataSource = bds1;
        }

        private void SetButtonSatus(bool _flag)
        {
            btnNew.Enabled = _flag;
            btnEdit.Enabled = _flag;
            btnDelete.Enabled = _flag;
            btnRefresh.Enabled = _flag;

            btnSave.Enabled = !_flag;
            btnUndo.Enabled = !_flag;

            //if (objToolbar != null)
            //{
            //    objToolbar.SetToolBar();
            //}
        }
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {            
            bds1.AddNew();
            mState = "NEW";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);           
            create_by.Text = DBUtility._user_id;
            create_date.Text = DateTime.Now.Date.ToString();
            //txtCreate_date.Text = DateTime.Now.Date.ToString("yyyy-MM-dd").Substring(0, 10);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvDetails.Rows.Count == 0)
                return;
            //bds1.EndEdit();
            //dgvDetails.CurrentCell.RowIndex;行號           
            //Select a Cell Focus
            dgvDetails.CurrentCell = dgvDetails.Rows[0].Cells["id"];
            //Selected a Row 
            dgvDetails.Rows[0].Selected = true;

            bool flag_datavalid = false;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                if (dgvDetails.Rows[i].Cells["id"].Value.ToString() == "")
                {
                    flag_datavalid = true;
                    dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells["id"];//選中當前空白的行                    
                    break;
                }
            }
            if (flag_datavalid)
            {
                MessageBox.Show("公司资料不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                bds1.EndEdit();
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.InsertCommand = SCB.GetInsertCommand();
                SDA.UpdateCommand = SCB.GetUpdateCommand();

                SDA.Update(dtDetail);
                MessageBox.Show("更新成功！", "提示信息");
                SCB = null;

                SetButtonSatus(true);
                SetObjValue.SetEditBackColor(panel1.Controls, false);
                mState = "";
                log_no.Properties.ReadOnly = true;
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

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDetails.Rows.Count == 0)
            {
                return;
            }
            //string strId = dgvDetails.Rows[dgvDetails.CurrentCell.RowIndex].Cells["id"].Value.ToString();
            //string strSql = string.Format(@"Select '1' FROM formula_mostly where id='{0}'", strId);
            //if (clsApp.ExecuteSqlReturnObject(strSql) != "")
            //{
            //    MessageBox.Show("注意：当前公司代码已经被物流价格对照表所引用！不可以删除！", "提示信息");
            //    return;
            //}

            if (MessageBox.Show("确定要刪除当前行？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {                   
                    dgvDetails.Rows.RemoveAt(dgvDetails.CurrentCell.RowIndex);
                    //数据库中进行删除
                    SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                    SDA.DeleteCommand = SCB.GetDeleteCommand();
                    SDA.Update(dtDetail);
                    MessageBox.Show("删除成功！", "提示信息");
                    SCB = null;
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

        private void frmCdGoodsCodeA_FormClosed(object sender, FormClosedEventArgs e)
        {
           dtDetail=null ;
           SDA = null;
           conn.Close();
           conn.Dispose();
           clsApp = null; 
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (log_no.Text == "")
                return;
            mState = "Edit";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            update_by.Text = DBUtility._user_id;
            update_date.Text = DateTime.Now.Date.ToString();
            log_no.Properties.ReadOnly = true;
            log_no.BackColor = Color.White;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            bds1.CancelEdit();
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(panel1.Controls, false);           
            mState = "";
            log_no.Properties.ReadOnly = true;
            Load_Date();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_Date();
        }

        private void Set_DataBindings()
        {
            log_no.DataBindings.Add("Text", bds1, "log_no");
            type.DataBindings.Add("Text", bds1, "type");
            modality.DataBindings.Add("EditValue", bds1, "modality");            
            english_type.DataBindings.Add("Text", bds1, "english_type");

            //segment_length_1.DataBindings.Add("Value", bds1, "segment_length_1");
            //segment_length_2.DataBindings.Add("Value", bds1, "segment_length_2");
            //segment_length_3.DataBindings.Add("Value", bds1, "segment_length_3");
            //segment_length_4.DataBindings.Add("Value", bds1, "segment_length_4");
            //segment_length_5.DataBindings.Add("Value", bds1, "segment_length_5");
            //segment_length_6.DataBindings.Add("Value", bds1, "segment_length_6");
            //segment_length_7.DataBindings.Add("Value", bds1, "segment_length_7");
            //segment_length_8.DataBindings.Add("Value", bds1, "segment_length_8");
            //segment_length_9.DataBindings.Add("Value", bds1, "segment_length_9");
            //segment_length_10.DataBindings.Add("Value", bds1, "segment_length_10");

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
    }
}
