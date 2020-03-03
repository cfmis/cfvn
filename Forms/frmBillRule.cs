using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using cfvn.CLS;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;

namespace cfvn.Forms
{
    public partial class frmBillRule : DockContent
    {
        DataTable dtDetail=new DataTable();
        public SqlDataAdapter SDA;
        public string mState = "";
        SqlConnection conn;
        public clsPublicOfVN clsApp = new clsPublicOfVN();

        public frmBillRule()
        {
            InitializeComponent();
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();
        }

        private void frmBillRule_Load(object sender, EventArgs e)
        {  
            Load_Date();
            //數據綁定
            txtBill_id.DataBindings.Add("Text", bds1, "bill_id");
            txtBill_desc.DataBindings.Add("Text", bds1, "bill_desc");          
            txtRemark.DataBindings.Add("Text", bds1, "remark");
            txtCreateby.DataBindings.Add("Text", bds1, "Create_by");
            txtCreate_date.DataBindings.Add("Text", bds1, "create_date");
            txtUpdateby.DataBindings.Add("Text", bds1, "update_by");
            txtUpdate_date.DataBindings.Add("Text", bds1, "Update_date");
        }

        private void Load_Date()
        {
            dtDetail.Clear();
            const string sql = @"SELECT * From sys_bill_rule with(nolock) order by bill_id ";
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
            txtCreateby.Text = DBUtility._user_id;
            txtCreate_date.Text = DateTime.Now.Date.ToString();
            //txtCreate_date.Text = DateTime.Now.Date.ToString("yyyy-MM-dd").Substring(0, 10);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvDetails.Rows.Count == 0)
                return;
            //dgvDetails.CurrentCell.RowIndex;行號           
            //Select a Cell Focus
            dgvDetails.CurrentCell = dgvDetails.Rows[0].Cells["bill_id"];
            //Selected a Row 
            dgvDetails.Rows[0].Selected = true;

            bool flag_datavalid = false;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                if (dgvDetails.Rows[i].Cells["bill_id"].Value.ToString() == "" )
                {
                    flag_datavalid = true;
                    dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells["bill_id"];//選中當前空白的行                    
                    break;
                }
            }
            if (flag_datavalid)
            {
                MessageBox.Show("单据代码不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtBill_id.ReadOnly = true;
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
                return;
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

        private void frmBillRule_FormClosed(object sender, FormClosedEventArgs e)
        {
           dtDetail=null ;
           SDA = null;
           conn.Close();
           conn.Dispose();
           clsApp = null; 
        }
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtBill_id.Text == "")
                return;
            mState = "Edit";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            txtUpdateby.Text = DBUtility._user_id;
            txtUpdate_date.Text = DateTime.Now.Date.ToString();
            txtBill_id.ReadOnly = true;
            txtBill_id.BackColor = Color.White;
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {            
            //if (mState == "NEW")
            //{
            //    //移走空白行
            //    if (dgvDetails.Rows.Count > 0)
            //    {
            //        for (int i = dgvDetails.Rows.Count - 1; i >= 0; i--)
            //        {
            //            if (dgvDetails.Rows[i].Cells["bill_id"].Value.ToString() == "")
            //            {
            //                dgvDetails.Rows.RemoveAt(i);
            //            }
            //        }
            //    }
            //}
            bds1.CancelEdit();
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(panel1.Controls, false);           
            mState = "";
            txtBill_id.ReadOnly = true;
            Load_Date();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_Date();
        }
    }
}
