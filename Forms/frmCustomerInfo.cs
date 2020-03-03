using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using cfvn.CLS;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;
using System.Data.OleDb;

namespace cfvn.Forms
{
    public partial class frmCustomerInfo : DockContent
    {
        DataTable dtDetail = new DataTable();
        public SqlDataAdapter SDA;
        public string mState = "";
        SqlConnection conn;
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        public bool flag_inport;

        public frmCustomerInfo()
        {
            InitializeComponent();
        }

        private void frmCdUnit_Load(object sender, EventArgs e)
        {  
            Load_Date();
            //數據綁定
            txtCustomer_name.DataBindings.Add("Text", bds1, "customer_name");
            txtCustomer_address.DataBindings.Add("Text", bds1, "customer_address");
            lkeProvince.DataBindings.Add("EditValue", bds1, "province");
            txtContact.DataBindings.Add("Text", bds1, "contact");
            txtCustomer_tel.DataBindings.Add("Text", bds1, "customer_tel");
            txtCustomer_fax.DataBindings.Add("Text", bds1, "customer_fax");
            txtCustomer_email.DataBindings.Add("Text", bds1, "customer_email");
            txtRemark.DataBindings.Add("Text", bds1, "remark");
            txtCreateby.DataBindings.Add("Text", bds1, "Create_by");
            txtCreate_date.DataBindings.Add("Text", bds1, "create_date");
            txtUpdateby.DataBindings.Add("Text", bds1, "update_by");
            txtUpdate_date.DataBindings.Add("Text", bds1, "update_date");

            clsState.Set_Province(lkeProvince);           
        }

        private void Load_Date()
        {
            dtDetail.Clear();
            const string sql = @"SELECT * From customer_info with(nolock) order by customer_name";           
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
            BTNINPORT.Enabled = _flag;

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
            txtCreate_date.Text = DateTime.Now.Date.ToString("yyyy-MM-dd");

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
            txtRemark.Focus();
            dgvDetails.CurrentCell = dgvDetails.Rows[0].Cells["customer_name"];
            //Selected a Row 
            dgvDetails.Rows[0].Selected = true;
            //bds1.EndEdit();
            bool flag_datavalid = false;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                if (dgvDetails.Rows[i].Cells["customer_name"].Value.ToString() == "" )
                {
                    flag_datavalid = true;
                    dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells["customer_name"];//選中當前空白的行                    
                    break;
                }
                if (dgvDetails.Rows[i].Cells["province"].Value.ToString() == "")
                {
                    flag_datavalid = true;
                    dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells["province"];//選中當前空白的行                    
                    break;
                }
            }
            if (flag_datavalid)
            {
                MessageBox.Show("客户名称或者省份/城市不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                bds1.EndEdit();
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.InsertCommand = SCB.GetInsertCommand();
                SDA.UpdateCommand = SCB.GetUpdateCommand();

                SDA.Update(dtDetail);
                MessageBox.Show("数据更新成功！", "提示信息");
                SCB = null;

                SetButtonSatus(true);
                SetObjValue.SetEditBackColor(panel1.Controls, false);
                mState = "";
                txtCustomer_name.ReadOnly = true;
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
            if (MessageBox.Show("确定要刪除当前行？", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {                   
                    dgvDetails.Rows.RemoveAt(dgvDetails.CurrentCell.RowIndex);
                    //数据库中进行删除
                    SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                    SDA.DeleteCommand = SCB.GetDeleteCommand();
                    SDA.Update(dtDetail);
                    MessageBox.Show("数据删除成功！", "提示信息");
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
            if (txtCustomer_name.Text == "")
            {
                return;
            }
            mState = "Edit";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            txtUpdateby.Text = DBUtility._user_id;
            txtUpdate_date.Text = DateTime.Now.Date.ToString();
            txtCustomer_name.ReadOnly = true;
            txtCustomer_name.BackColor = Color.White;
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
            txtCustomer_name.ReadOnly = true;
            Load_Date();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Load_Date();
        }

        private void Load_Excel()
        {
            OpenFileDialog openFileDialog1 = new OpenFileDialog { Filter = "Execl files (*.xls)|*.xls", FilterIndex = 0, RestoreDirectory = true, Title = "导入客户信息文件路径", FileName = null };
            openFileDialog1.ShowDialog();
            string FileName = openFileDialog1.FileName;
            Refresh();           
            if (FileName != "")
            {
                //導入EXCEL頁數
                const String strsql_g = "SELECT 客户名称,客户送货地址,联系人,联系电话,传真,电邮,省份或城市 FROM [Sheet1$]";               
                try
                {
                    Inport_excel(FileName, strsql_g);
                    MessageBox.Show("数据汇入成功！", "提示信息"); 
                }
                catch (SqlException E)
                {
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
                DataTable dtExcel = ds.Tables[0];
                SqlConnection sqlconn = new SqlConnection(DBUtility.ConnectionString);
                sqlconn.Open();
               
                string strSql_u;
                progressBar1.Enabled = true;
                progressBar1.Visible = true;
                progressBar1.Value = 0;
                progressBar1.Step = 1;
                progressBar1.Maximum = dtExcel.Rows.Count;
                int intFlag = 0;
                for (int i = 0; i < dtExcel.Rows.Count; i++)
                {
                    progressBar1.Value += progressBar1.Step;
                    if (progressBar1.Value == progressBar1.Maximum)
                    {
                        progressBar1.Enabled = false;
                        progressBar1.Visible = false;
                    }
                    strSql_u = string.Format(
                        @"EXECUTE usp_update_cust_info '{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}'",
                        dtExcel.Rows[i]["客户名称"].ToString().Trim(),
                        dtExcel.Rows[i]["客户送货地址"].ToString().Trim(),
                        dtExcel.Rows[i]["联系人"].ToString().Trim(),
                        dtExcel.Rows[i]["联系电话"].ToString().Trim(),
                        dtExcel.Rows[i]["传真"].ToString().Trim(),
                        dtExcel.Rows[i]["电邮"].ToString().Trim(),
                        dtExcel.Rows[i]["省份或城市"].ToString().Trim(), 
                        strUser_id);
                    intFlag = clsApp.ExecuteSqlUpdate(strSql_u);
                    if (intFlag < 0)
                    {
                        MessageBox.Show(string.Format("更新客户名称：【{0}】出错！", dtExcel.Rows[i]["客户名称"].ToString().Trim()));
                        break;
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
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            dtDetail.Clear();
            string sql;
            if (txtCustomerName.Text != "")
            {
                sql = string.Format(@"SELECT * From customer_info with(nolock) Where customer_name like '%{0}%' ORDER BY customer_name", txtCustomerName.Text);
            }
            else
            {
                sql = @"SELECT * From customer_info with(nolock) ORDER BY customer_name";
            }
            conn = new SqlConnection(DBUtility.ConnectionString);
            SDA = new SqlDataAdapter(sql, conn);
            SDA.Fill(dtDetail);

            bds1.DataSource = dtDetail;
            dgvDetails.DataSource = bds1;
        }
      
    }
}
