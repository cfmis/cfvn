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
    public partial class frmCdCompany : DockContent
    {
        DataTable dtDetail = new DataTable();
        public SqlDataAdapter SDA;
        public string mState = "";
        SqlConnection conn;
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        private clsToolBar objToolbar;

        public frmCdCompany()
        {
            InitializeComponent();

            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();


            txtCreate_by.textBox.Tag="1";
            txtCreate_by.textBox.Enabled = false;
            txtCreate_date.textBox.Tag = "1";
            txtCreate_date.textBox.Enabled = false;
            txtUpdate_by.textBox.Tag="1";
            txtUpdate_by.textBox.Enabled = false;
            txtUpdate_date.textBox.Tag="1";
            txtUpdate_date.textBox.Enabled = false;

            //權限
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.SetToolBar();
            objToolbar.Set_Button_Image(toolStrip1);
        }

        private void frmCdCompany_Load(object sender, EventArgs e)
        {  
            Load_Date();
            //數據綁定
            //txtId.DataBindings.Add("Text", bds1, "id");
            txtId.textBox.DataBindings.Add("Text", bds1, "id");
            txtId.textBox.MaxLength = 10;
            txtname.DataBindings.Add("Text", bds1, "name");
            txtenglish_name.DataBindings.Add("Text", bds1, "english_name");
            txtTel.DataBindings.Add("Text", bds1, "tel");
            txtFax.DataBindings.Add("Text", bds1, "fax");
            txtaddress.DataBindings.Add("Text", bds1, "address");
            txte_address.DataBindings.Add("Text", bds1, "e_address");
            txtpicture_path.DataBindings.Add("Text", bds1, "picture_path");           

            txtCreate_by.textBox.DataBindings.Add("Text", bds1, "create_by");
            txtCreate_date.textBox.DataBindings.Add("Text", bds1, "create_date");
            txtUpdate_by.textBox.DataBindings.Add("Text", bds1, "update_by");
            txtUpdate_date.textBox.DataBindings.Add("Text", bds1, "Update_date");
        }

        private void Load_Date()
        {
            dtDetail.Clear();
            //SELECT company,trade,fax_no,bank_name,bank_account,tel,address,contact FROM cd_company;
            const string sql = @"SELECT * From cd_company with(nolock)";
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
            txtCreate_by.textBox.Text = DBUtility._user_id;
            txtCreate_date.textBox.Text = DateTime.Now.Date.ToString();
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
                txtId.textBox.ReadOnly = true;
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

        private void frmCdCompany_FormClosed(object sender, FormClosedEventArgs e)
        {
           dtDetail=null ;
           SDA = null;
           conn.Close();
           conn.Dispose();
           clsApp = null; 
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.textBox.Text == "")
                return;
            mState = "Edit";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            txtUpdate_by.textBox.Text = DBUtility._user_id;
            txtUpdate_date.textBox.Text = DateTime.Now.Date.ToString();
            txtId.textBox.ReadOnly = true;
            txtId.textBox.BackColor = Color.White;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            bds1.CancelEdit();
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(panel1.Controls, false);           
            mState = "";
            txtId.textBox.ReadOnly = true;
            Load_Date();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_Date();
        }
    }
}
