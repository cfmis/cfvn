using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using cfvn.CLS;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;

namespace cfvn.Forms
{
    public partial class frmSysDictionary : DockContent
    {
        DataTable dtDetail;
        public SqlDataAdapter SDA;
        SqlConnection conn;
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        clsAppPublic clsPub = new clsAppPublic();
        MsgInfo myMsg = new MsgInfo();
        clsToolBar objToolbar;

        public frmSysDictionary()
        {
            InitializeComponent();
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();

            //設置按鈕圖片
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.Set_Button_Image(toolStrip1);
        }

        private void frmSysDictionary_Load(object sender, EventArgs e)
        {
            dtDetail = new DataTable();
            const string sql = @"SELECT col_code,language_id,col_name,remark,update_by,update_date From sys_dictionary with(nolock) WHERE 1=0 ";
            //dtDetail = clsPublicOfVN.GetDataTable(sql);
            conn = new SqlConnection(DBUtility.ConnectionString);
            SDA = new SqlDataAdapter(sql,conn);
            SDA.Fill(dtDetail);

            bds1.DataSource = dtDetail;
            dgvDetails.DataSource = bds1;

            //數據綁定
            txtCol_code.DataBindings.Add("Text", bds1, "col_code");
            txtLanguage_id.DataBindings.Add("Text", bds1, "language_id");           
            
            txtCol_name.DataBindings.Add("Text", bds1, "col_name");           
            txtRemark.DataBindings.Add("Text", bds1, "remark");
            txtUpdateby.DataBindings.Add("Text", bds1, "update_by");
            txtUpdate_date.DataBindings.Add("Text", bds1, "Update_date");            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtCol_code1.Text != "")
            {
                sql = String.Format(@"SELECT col_code,language_id,col_name,remark,update_by,update_date 
                                      From sys_dictionary with(nolock) WHERE col_code like '{0}%' ", txtCol_code1.Text);
                if (txtLanguage_id1.Text != "")
                {
                    sql += String.Format(" And language_id='{0}'", txtLanguage_id1.Text);
                }
            }
            else
            {
                sql = @"SELECT col_code,language_id,col_name,remark,update_by,update_date From sys_dictionary with(nolock) ";
                if (txtLanguage_id1.Text != "")
                {
                    sql += String.Format(" Where language_id='{0}'", txtLanguage_id1.Text);
                }
            }
            sql += "Order By col_code,language_id ";
            //dtDetail = clsPublicOfVN.GetDataTable(sql);
            dtDetail.Clear();
            SDA = new SqlDataAdapter(sql, conn);
            SDA.Fill(dtDetail);

            bds1.DataSource = dtDetail;
            dgvDetails.DataSource = bds1;           
            if (dtDetail.Rows.Count == 0 )
            {
                MessageBox.Show("沒有满足查询条件的数据!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {            
            bds1.AddNew();         
            //txtID.Focus();
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(this.panel1.Controls, true);
            SetObjValue.ClearObjValue(this.panel1.Controls, "1");
            txtUpdateby.Text = DBUtility._user_id;
            txtUpdate_date.Text = clsPub.GetCurrentDatetime();
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount == 0)
            {
                return;
            }
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(this.panel1.Controls, true);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvDetails.Rows.Count == 0)
                return;
            if (txtCol_code.Text == "" && txtCol_name.Text == "" && txtLanguage_id.Text == "")
            {
                MessageBox.Show("对象名、语言或者內容不可为空!", "提示信息");
                return;
            }
            const string lang_id = "1,2,3";
            if (!lang_id.Contains(txtLanguage_id.Text))
            {
                MessageBox.Show("语言代码不正确!", "提示信息");
                txtLanguage_id.Focus();
                return;
            }

           
            //Select a Cell Focus
            dgvDetails.CurrentCell = dgvDetails.Rows[0].Cells["col_code"];
            //Selected a Row 
            dgvDetails.Rows[0].Selected = true;


            bool flag_datavalid = false;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                if (dgvDetails.Rows[i].Cells["col_code"].Value.ToString() == "" &&
                    dgvDetails.Rows[i].Cells["language_id"].Value.ToString() == "" && 
                    dgvDetails.Rows[i].Cells["col_name"].Value.ToString() == "")
                {
                    flag_datavalid = true;
                    break;
                }
            }
            if (flag_datavalid)
            {
                MessageBox.Show("窗体代码或按钮对象代码不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                bds1.EndEdit();//結束所做的更改
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.InsertCommand = SCB.GetInsertCommand();
                SDA.UpdateCommand = SCB.GetUpdateCommand();

                SDA.Update(dtDetail);
                MessageBox.Show("数据更新成功!");
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

            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(this.panel1.Controls, false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvDetails.Rows.Count == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return;
            }

            try
            {
                dgvDetails.Rows.RemoveAt(dgvDetails.CurrentCell.RowIndex);
                //数据库中进行删除
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.DeleteCommand = SCB.GetDeleteCommand();                
                SDA.Update(dtDetail);
                MessageBox.Show("数据删除成功!");
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

        private void frmSysDictionary_FormClosed(object sender, FormClosedEventArgs e)
        {
           dtDetail=null ;
           SDA = null;
           conn.Close();
           conn.Dispose();
           clsApp = null; 
        }

        private void txtLanguage_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;//經過判斷爲數字可以輸入
            }
        }

        private void SetButtonSatus(bool _flag)
        {
            btnNew.Enabled = _flag;
            BTNEDIT.Enabled = _flag;
            btnDelete.Enabled = _flag;   
            btnSave.Enabled = !_flag;
            BTNCANCEL.Enabled = !_flag;

            dgvDetails.Enabled = _flag; 
            //BTNCANCEL.Enabled = !_flag;

            //if (objToolbar != null)
            //{
            //    objToolbar.SetToolBar();
            //}
        }

        private void Cancel() //取消
        {
            dtDetail.RejectChanges();
            bds1.CancelEdit();
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(this.panel1.Controls, false);           
            
            //if (!String.IsNullOrEmpty(mID))
            //{
            //    Find_doc(mID);
            //}
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        
        
    }
}
