using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using cftest.CLS;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;
using SysDaan.CLS;
using System.Data.OleDb;

namespace cftest.Forms
{
    public partial class frmCdUnit : DockContent
    {
        DataTable dtDetail=new DataTable();
        public SqlDataAdapter SDA;
        public string mState = "";
        SqlConnection conn;
        public clsPublicOfPad clsApp = new clsPublicOfPad();
        public bool flag_inport;

        public frmCdUnit()
        {
            InitializeComponent();
        }

        private void frmCdUnit_Load(object sender, EventArgs e)
        {  
            Load_Date();
            //數據綁定
            txtId.DataBindings.Add("Text", bds1, "id");
            txtName.DataBindings.Add("Text", bds1, "name");          
            txtRemark.DataBindings.Add("Text", bds1, "remark");
            txtCreateby.DataBindings.Add("Text", bds1, "Create_by");
            txtCreate_date.DataBindings.Add("Text", bds1, "create_date");
            txtUpdateby.DataBindings.Add("Text", bds1, "update_by");
            txtUpdate_date.DataBindings.Add("Text", bds1, "Update_date");
        }

        private void Load_Date()
        {
            dtDetail.Clear();
            const string sql = @"SELECT * From cd_unit with(nolock) order by id ";
            //dtDetail = clsPublicOfPad.GetDataTable(sql);
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
            dgvDetails.CurrentCell = dgvDetails.Rows[0].Cells["id"];
            //Selected a Row 
            dgvDetails.Rows[0].Selected = true;

            bool flag_datavalid = false;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                if (dgvDetails.Rows[i].Cells["id"].Value.ToString() == "" )
                {
                    flag_datavalid = true;
                    dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells["id"];//選中當前空白的行                    
                    break;
                }
            }
            if (flag_datavalid)
            {
                MessageBox.Show("单位代码不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                txtId.ReadOnly = true;
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

        private void frmCdUnit_FormClosed(object sender, FormClosedEventArgs e)
        {
           dtDetail=null ;
           SDA = null;
           conn.Close();
           conn.Dispose();
           clsApp = null; 
        }

        
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
                return;
            mState = "Edit";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            txtUpdateby.Text = DBUtility._user_id;
            txtUpdate_date.Text = DateTime.Now.Date.ToString();
            txtId.ReadOnly = true;
            txtId.BackColor = Color.White;
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
            //            if (dgvDetails.Rows[i].Cells["id"].Value.ToString() == "")
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
            txtId.ReadOnly = true;
            Load_Date();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_Date();
        }


        private void Load_Excel()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog { Filter = "Execl files (*.xls)|*.xls", FilterIndex = 0, RestoreDirectory = true, Title = "導入匯總文件路徑", FileName = null };
            openFileDialog1.ShowDialog();
            string FileName = openFileDialog1.FileName;
            Refresh();
            if (FileName != "")
            {
                //導入EXCEL頁數
                const String strsql_g = "SELECT 未完成頁數,[急/特急狀態],當前部門 FROM [大貨單$]";               
                try
                {
                    Inport_excel(FileName, strsql_g);                    
                    //flag_inport = true;
                }
                catch (SqlException E)
                {
                    //flag_inport = false;
                    throw new Exception(E.Message);
                }
            }
        }


        private void Inport_excel(string _filename, string _strsql)
        {
            String connStr = String.Format("Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0}; Extended Properties=Excel 8.0;", _filename);
            using (OleDbDataAdapter da = new OleDbDataAdapter(_strsql, connStr))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                string strUser_id = DBUtility._user_id;
                string strmo_id;
                string strmo_type;
                string strwp_id;
                int mo_type_sort;

                System.Data.DataTable dtExcel = ds.Tables[0];
                SqlConnection sqlconn = new SqlConnection(DBUtility.ConnectionString);
                sqlconn.Open();

                const string strSql_f = "Select 1 from dbo.z_rpt_plate Where user_id=@user_id and mo_id=@mo_id and rpt_type=@rpt_type";
                const string strSql_i = "Insert into z_rpt_plate (user_id,mo_id,rpt_type,mo_type,wp_id,mo_type_sort) values (@user_id,@mo_id,@rpt_type,@mo_type,@wp_id,@mo_type_sort)";
                progressBar1.Enabled = true;
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                progressBar1.Step = 1;
                progressBar1.Maximum = dtExcel.Rows.Count;

                for (int i = 0; i < dtExcel.Rows.Count; i++)
                {
                    progressBar1.Value += progressBar1.Step;
                    if (progressBar1.Value == progressBar1.Maximum)
                    {
                        progressBar1.Enabled = false;
                        progressBar1.Visible = false;
                    }

                    strmo_id = dtExcel.Rows[i]["未完成頁數"].ToString().Trim();
                    if (String.IsNullOrEmpty(strmo_id))
                    {
                        continue;
                    }
                    strmo_type = dtExcel.Rows[i]["急/特急狀態"].ToString().Trim();
                    strwp_id = dtExcel.Rows[i]["當前部門"].ToString().Trim();
                    mo_type_sort = strmo_type.Length;

                    SqlCommand cmd = new SqlCommand(strSql_f, sqlconn);
                    cmd.Parameters.AddWithValue("@user_id", strUser_id);
                    cmd.Parameters.AddWithValue("@mo_id", strmo_id);
                    cmd.Parameters.AddWithValue("@rpt_type", "");
                    SqlDataReader dr = cmd.ExecuteReader();
                    if (!dr.Read())
                    {
                        cmd.Dispose();
                        dr.Close();
                        dr.Dispose();
                        SqlCommand sqlcmd = new SqlCommand(strSql_i, sqlconn);
                        sqlcmd.Parameters.AddWithValue("@user_id", strUser_id);
                        sqlcmd.Parameters.AddWithValue("@mo_id", strmo_id);
                        sqlcmd.Parameters.AddWithValue("@rpt_type", "");
                        sqlcmd.Parameters.AddWithValue("@mo_type", strmo_type);
                        sqlcmd.Parameters.AddWithValue("@wp_id", strwp_id);
                        sqlcmd.Parameters.AddWithValue("@mo_type_sort", mo_type_sort);
                        sqlcmd.ExecuteNonQuery();
                        sqlcmd.Dispose();
                    }
                    else
                    {
                        cmd.Dispose();
                        dr.Close();
                        dr.Dispose();
                    }
                }

                progressBar1.Enabled = false;
                progressBar1.Visible = false;
                sqlconn.Close();
                sqlconn.Dispose();
            }

        }

        private void BTNINPORT_Click(object sender, EventArgs e)
        {
            Load_Excel();

            if (flag_inport)  //導入EXCEL成功
            {
                //顯示進度
                frmProgress wForm = new frmProgress();
                new Thread((ThreadStart)delegate
                {
                    wForm.TopMost = true;
                    wForm.ShowDialog();
                }).Start();

                //************************
                Load_Data(); //数据处理
                //************************
                wForm.Invoke((EventHandler)delegate { wForm.Close(); });
            }
        }
    }
}
