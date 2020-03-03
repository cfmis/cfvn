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
    public partial class frmBsGroup : DockContent
    {
        DataTable dtDetail = new DataTable();
        public SqlDataAdapter SDA;
        public string mState = "";
        SqlConnection conn;
        MsgInfo myMsg = new MsgInfo();//實例化Messagegox用到的提示
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        private clsToolBar objToolbar;

        public frmBsGroup()
        {
            InitializeComponent();

            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();
            
            //權限
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.SetToolBar();
            objToolbar.Set_Button_Image(toolStrip1);
        }

        private void frmBsGroup_Load(object sender, EventArgs e)
        {  
            Load_Date();
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);
            
            //數據綁定           
            txtid.DataBindings.Add("Text", bds1, "id");            
            txtname.DataBindings.Add("Text", bds1, "name");
            txtenglish_name.DataBindings.Add("Text", bds1, "english_name");
            txtmo_group.DataBindings.Add("Text", bds1, "mo_group");
            txtremark.DataBindings.Add("Text", bds1, "remark");           
            luestate.DataBindings.Add("EditValue", bds1, "state");
            txtcreate_by.DataBindings.Add("Text", bds1, "create_by");
            txtcreate_date.DataBindings.Add("Text", bds1, "create_date");
            txtupdate_by.DataBindings.Add("Text", bds1, "update_by");
            txtupdate_date.DataBindings.Add("Text", bds1, "Update_date");

        }

      

        private void Load_Date()
        {
            dtDetail.Clear();           
            const string sql = @"SELECT * From bs_group with(nolock) Where state='0'";
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
            btnFind.Enabled = _flag;

            btnSave.Enabled = !_flag;
            btnUndo.Enabled = !_flag;

            if (objToolbar != null)
            {
                objToolbar.SetToolBar();
            }
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
            txtcreate_by.Text = DBUtility._user_id;
            txtcreate_date.Text = DateTime.Now.Date.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvDetails.Rows.Count == 0)
            {
                return;
            }            
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
                MessageBox.Show("Area id cannot be empty !", myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                bds1.EndEdit();
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.InsertCommand = SCB.GetInsertCommand();
                SDA.UpdateCommand = SCB.GetUpdateCommand();

                SDA.Update(dtDetail);
                //MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle);
                DBUtility.myMessageBox(myMsg.msgSave_ok, myMsg.msgTitle);
                SCB = null;

                SetButtonSatus(true);
                SetObjValue.SetEditBackColor(panel1.Controls, false);
                mState = "";
                txtid.Properties.ReadOnly = true;
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

            if (MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    luestate.EditValue = "2";
                    bds1.EndEdit();
                    //dgvDetails.Rows.RemoveAt(dgvDetails.CurrentCell.RowIndex);
                    //数据库中进行删除
                    SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                    SDA.UpdateCommand = SCB.GetUpdateCommand();
                    //SDA.DeleteCommand = SCB.GetDeleteCommand();
                    SDA.Update(dtDetail);
                    dgvDetails.Rows.RemoveAt(dgvDetails.CurrentCell.RowIndex);
                    MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle);
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

        private void frmBsGroup_FormClosed(object sender, FormClosedEventArgs e)
        {
           dtDetail=null ;
           SDA = null;
           conn.Close();
           conn.Dispose();
           clsApp = null; 
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                return;
            }
            mState = "Edit";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            txtupdate_by.Text = DBUtility._user_id;
            txtupdate_date.Text = DateTime.Now.Date.ToString();
            txtid.Properties.ReadOnly = true;
            txtid.BackColor = Color.White;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            bds1.CancelEdit();
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(panel1.Controls, false);           
            mState = "";
            txtid.Properties.ReadOnly = true;
            Load_Date();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Load_Date();
        }
    }
}
