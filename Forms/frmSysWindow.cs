using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;
using cfvn.CLS;

namespace cfvn.Forms
{
    public partial class frmSysWindow : DockContent
    {
        DataTable dtDetail;
        public SqlDataAdapter SDA;
        public string mState = "";
        SqlConnection conn;
        public clsPublicOfVN clsApp = new clsPublicOfVN();

        public frmSysWindow()
        {
            InitializeComponent();
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();
        }

        private void frmSysWindow_Load(object sender, EventArgs e)
        {
            dtDetail = new DataTable();
            const string sql = @"SELECT * From sys_window_toolbar with(nolock) WHERE 1=0 ";
            //dtDetail = clsPublicOfVN.GetDataTable(sql);
            conn = new SqlConnection(DBUtility.ConnectionString);
            SDA = new SqlDataAdapter(sql,conn);
            SDA.Fill(dtDetail);

            bds1.DataSource = dtDetail;
            dgvDetails.DataSource = bds1;

            //數據綁定
            txtWindow_id.DataBindings.Add("Text", bds1, "window_id");
            txtWindow_id_desc.DataBindings.Add("Text", bds1, "window_id_desc");
            txtTool_bar_obj_id.DataBindings.Add("Text", bds1, "tool_bar_obj_id");
            txtTool_bar_obj_id_desc.DataBindings.Add("Text", bds1, "tool_bar_obj_id_desc");
            txtSeqence_id.DataBindings.Add("Text", bds1, "seqence_id");           
            txtRemark.DataBindings.Add("Text", bds1, "remark");
            txtCreateby.DataBindings.Add("Text", bds1, "Createby");
            txtCreate_date.DataBindings.Add("Text", bds1, "create_date");
            txtUpdateby.DataBindings.Add("Text", bds1, "updateby");
            txtUpdate_date.DataBindings.Add("Text", bds1, "Update_date");            
        }

        private void SetButtonSatus(bool _flag)
        {
            btnNew.Enabled = _flag;
            btnEdit.Enabled = _flag;
            btnDelete.Enabled = _flag;

            btnSave.Enabled = !_flag;
            btnUndo.Enabled = !_flag;
            
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string sql;
            if (txtWindow_id1.Text != "")
                sql = String.Format(@"SELECT * From sys_window_toolbar with(nolock) WHERE window_id LIKE '%{0}%' order by window_id,seqence_id", txtWindow_id1.Text);            
            else
                sql = @"SELECT * From sys_window_toolbar with(nolock) order by window_id,seqence_id ";
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
            mState = "NEW";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            btnAutoGen.Enabled = true;
            txtSeqence_id.Text = "1";
            txtCreateby.Text = DBUtility._user_id;
            txtCreate_date.Text = DateTime.Now.Date.ToString();
            //txtCreate_date.Text = DateTime.Now.Date.ToString("yyyy-MM-dd").Substring(0, 10);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (dgvDetails.Rows.Count == 0)
            {
                return;
            }

            //dgvDetails.CurrentCell.RowIndex;行號           
            //Select a Cell Focus
            dgvDetails.CurrentCell = dgvDetails.Rows[0].Cells["window_id"];
            //Selected a Row 
            dgvDetails.Rows[0].Selected = true;
            
            //移除空白行
            for (int i = dgvDetails.Rows.Count - 1; i >= 0; i--)
            {
                if (dgvDetails.Rows[i].Cells["tool_bar_obj_id"].Value.ToString() == "")
                {                    
                    //dgvDetails.Rows.RemoveAt(dgvDetails.CurrentCell.RowIndex);
                    dgvDetails.Rows.RemoveAt(i);
                }
            }

            if (dgvDetails.Rows.Count == 0)
            {
                return;
            }

            bool flag_datavalid = false;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {                
                if (dgvDetails.Rows[i].Cells["window_id"].Value.ToString() == "" && dgvDetails.Rows[i].Cells["tool_bar_obj_id"].Value.ToString() == "")
                {
                    flag_datavalid = true;
                    dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells["window_id"];//選中當前空白的行                    
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
                bds1.EndEdit();
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.InsertCommand = SCB.GetInsertCommand();
                SDA.UpdateCommand = SCB.GetUpdateCommand();

                SDA.Update(dtDetail);
                MessageBox.Show("更新成功");
                SCB = null;

                SetButtonSatus(true);
                SetObjValue.SetEditBackColor(panel1.Controls, false);
                mState = "";
                btnAutoGen.Enabled = false;
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
                    MessageBox.Show("删除成功");
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

        private void frmSysWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
           dtDetail=null ;           
           SDA = null;
           conn.Close();
           conn.Dispose();
           clsApp = null; 
        }    

        private string Set_Menu_id_name(string pMenu_id)
        {
            string result="";
            if (pMenu_id != "")
            {
                string sql_f = string.Format(@"SELECT col_name FROM sys_dictionary Where col_code='{0}' and language_id='3'", pMenu_id);
                result = clsApp.ExecuteSqlReturnObject(sql_f);
                if (result == "")
                {
                    MessageBox.Show("请先添加按钮对应的翻译!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);                   
                }
            }
            return result;
        }

        private void txtTool_bar_obj_id_Leave(object sender, EventArgs e)
        {
            txtTool_bar_obj_id_desc.Text = Set_Menu_id_name(txtTool_bar_obj_id.Text);
        }

        private void btnAutoGen_Click(object sender, EventArgs e)
        {
            string path_formname, window_id_desc;
            path_formname = txtWindow_id.Text;
            if (path_formname != "")
            {
                window_id_desc = txtWindow_id_desc.Text;                
                List<string> list_btn = new List<string>();
                try
                {
                    System.Reflection.Assembly asb = System.Reflection.Assembly.GetExecutingAssembly();//得到当前的程序集                  
                    Form frm = (Form)asb.CreateInstance("cfvn." + path_formname);//利用反射，根据数据库中的字段值创建窗体对象
                    foreach (Control ct in frm.Controls)
                    {                        
                        if(ct.GetType().Name=="ToolStrip")
                        {
                            string objName;
                            ToolStrip ts = (ToolStrip)ct;
                            for (int i = 0; i < ts.Items.Count; i++)
                            {
                                objName = ts.Items[i].Name.ToUpper();
                                if (objName.Substring(0, 3) == "BTN")
                                {
                                    list_btn.Add(objName.ToUpper());
                                }
                            }
                            break;
                        }
                    }
                    frm = null;
                    if (list_btn.Count > 0)
                    {
                        //工具欄按鈕對照表如果之前已保存有就忽略掉,新增的按鈕將繼續添加進來
                        string btn_name;
                        for (int i = 0; i < list_btn.Count; i++)
                        {
                            btn_name = list_btn[i];
                            bool flag_add = false;
                            for (int j = 0; j < dgvDetails.RowCount; j++)
                            {
                                if (dgvDetails.Rows[j].Cells["tool_bar_obj_id"].Value.ToString() == btn_name)
                                {
                                    flag_add = true;
                                    break;
                                }
                            }
                            if (!flag_add)
                            {
                                bds1.AddNew();
                                int cur_row_index=dgvDetails.CurrentRow.Index ;                             
                                dgvDetails.Rows[cur_row_index].Cells["window_id"].Value = path_formname;
                                dgvDetails.Rows[cur_row_index].Cells["window_id_desc"].Value = window_id_desc;
                                dgvDetails.Rows[cur_row_index].Cells["tool_bar_obj_id"].Value = btn_name;
                                dgvDetails.Rows[cur_row_index].Cells["seqence_id"].Value = cur_row_index.ToString();
                            }
                        }
                        //移除空白行
                        for (int i = dgvDetails.Rows.Count - 1; i >= 0; i--)
                        {
                            if (dgvDetails.Rows[i].Cells["tool_bar_obj_id"].Value.ToString() == "")
                            {
                                dgvDetails.Rows.RemoveAt(i);
                            }
                        }
                    }
                }
                catch (Exception E)
                {
                    MessageBox.Show(E.ToString());
                }
                list_btn = null;
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtWindow_id.Text == "")
                return;
            mState = "Edit";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            txtUpdateby.Text = DBUtility._user_id;
            txtUpdate_date.Text = DateTime.Now.Date.ToString();
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
            //            if (dgvDetails.Rows[i].Cells["window_id"].Value.ToString() == "")
            //            {
            //                dgvDetails.Rows.RemoveAt(i);
            //            }
            //        }
            //    }
            //}
            bds1.CancelEdit();
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(panel1.Controls, false);
            btnAutoGen.Enabled = false;
            mState = "";
        }

        private void txtWindow_id_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                string strwindow_id = txtWindow_id.Text;
                string sql =string.Format( 
                @"Select B.col_name as window_name From dbo.sys_menu_window A,sys_dictionary B
                Where A.menu_id=B.col_code and A.language_id=B.language_id and A.co_id='' and 
                A.language_id='{0}' and A.user_id='ADMIN' and A.window_id='{1}'",DBUtility._language,strwindow_id);
                txtWindow_id_desc.Text = clsApp.ExecuteSqlReturnObject(sql);
                if (dgvDetails.RowCount > 0)
                {
                    dgvDetails.Rows[dgvDetails.CurrentRow.Index].Cells["window_id_desc"].Value = txtWindow_id_desc.Text;
                }
            }
        }

        private void toolStrip1_Click(object sender, EventArgs e)
        {
            if (btnSave.Selected)
            {
                txtRemark.Focus();
            }
        }
    }
}
