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
    public partial class frmBsDepartment : DockContent

    {
        public string mID = "";    //臨時的主鍵值
        public string mState = ""; //新增或編號的狀態
        public string mLanguage ;
        public string msgCustom;
        public int row_delete;
        DataTable dtDetail = new DataTable();
        public SqlDataAdapter SDA;
       
        SqlConnection conn;
        readonly MsgInfo myMsg = new MsgInfo();//實例化Messagegox用到的提示     
        DataTable dtDeptpartment = new DataTable();     
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        private clsToolBar objToolbar;
        
        public frmBsDepartment()
        {
            InitializeComponent();
            mLanguage = DBUtility._language;

            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();
            //權限
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.SetToolBar();
            objToolbar.Set_Button_Image(toolStrip1);

        }

        private void frmBsDepartment_Load(object sender, EventArgs e)
        {
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);
            string strDept;
            if (DBUtility._language == "2")
            {
                strDept = @"SELECT id,english_name as name FROM dbo.bs_productline where state='0'";
            }
            else
            {
                strDept = @"SELECT id,name FROM dbo.bs_productline where state='0'";
            }
            //倉庫位置
            dtDeptpartment = clsApp.GetDataTable(strDept);
            DataRow row1 = dtDeptpartment.NewRow();//插一空行
            dtDeptpartment.Rows.Add(row1);
            dtDeptpartment.DefaultView.Sort = "id ASC";//排序
            dtDeptpartment = dtDeptpartment.DefaultView.ToTable();//排序後重新賦值
            luelocation.Properties.DataSource = dtDeptpartment;
            luelocation.Properties.ValueMember = "id";
            luelocation.Properties.DisplayMember = "name";
            dgvDetails.AutoGenerateColumns = false;
            Load_Date();
            Bingding_Data();

        }

        private void Bingding_Data()
        {
            //數據綁定           
            txtid.DataBindings.Add("Text", bds1, "id");
            txtname.DataBindings.Add("Text", bds1, "name");
            txtenglish_name.DataBindings.Add("Text", bds1, "english_name");
            //chkmostly_dept.DataBindings.Add("Checked", bds1, "mostly_dept");
            luelocation.DataBindings.Add("EditValue", bds1, "location");
            luestate.DataBindings.Add("EditValue", bds1, "state");           
            txtRemark.DataBindings.Add("Text", bds1, "remark");

            txtcreate_by.DataBindings.Add("Text", bds1, "create_by");
            txtcreate_date.DataBindings.Add("Text", bds1, "create_date");
            txtupdate_by.DataBindings.Add("Text", bds1, "update_by");
            txtupdate_date.DataBindings.Add("Text", bds1, "Update_date");
        }

        private void frmBsDepartment_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtDeptpartment.Dispose();
        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNNEW_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void BTNFIND_Click(object sender, EventArgs e)
        {
            Load_Date();
        }

        private void BTNPRINT_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void BTNEXCEL_Click(object sender, EventArgs e)
        {
            Excel();
        }

        // ===============以下爲自定義方法=======================
        private void SetButtonSatus(bool _flag)
        {
            BTNNEW.Enabled = _flag;
            BTNEDIT.Enabled = _flag;
            BTNPRINT.Enabled = _flag;
            BTNDELETE.Enabled = _flag;
            BTNFIND.Enabled = _flag;
            BTNSAVE.Enabled = !_flag;
            BTNCANCEL.Enabled = !_flag;

            if (objToolbar != null)
            {
                objToolbar.SetToolBar();
            }
        }    

        private bool Valid_Doc() //主建是否已存在
        {
            bool flag = false;
            string strSql = String.Format("Select '1' FROM bs_department WHERE id='{0}'", txtid.Text.Trim());
            if (clsApp.ExecuteSqlReturnObject(strSql) != "")
            {
                MessageBox.Show(myMsg.msgIsExists + String.Format("【{0}】", txtid.Text), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            return flag;
        }

        private void Find_Doc(string temp_id) //非新增或編號狀態下帶出的資料
        {
            if (!String.IsNullOrEmpty(temp_id))
            {
                string strsql = String.Format(
                @"SELECT * FROM dbo.bs_department Where state='0' order by id ", temp_id);
                DataTable dt = clsApp.GetDataTable(strsql);
                dgvDetails.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    if (mLanguage == "2")
                    {
                        msgCustom = "The No. of the data does not exist.";
                    }
                    else
                    {
                        msgCustom = "編號資料不存在！";
                    }
                    MessageBox.Show(msgCustom, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    SetObjValue.ClearObjValue(this.Controls,"2");                       
                    return;
                }
                else
                {
                    mID = txtid.Text;//保存臨時的ID號
                }               
            }
        }


        //private void Set_Row_Position(string _doc) //定位到當前行 
        //{           
        //    for (int i = 0; i < dgvDetails.RowCount; i++)
        //    {
        //        if (_doc == dgvDetails.Rows[i].Cells["id"].Value.ToString())
        //        {                    
        //            dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells["id"]; //設置光標定位到當前選中的行
        //            dgvDetails.Rows[i].Selected = true;
        //            break;
        //        }
        //    }
        //}

        private void AddNew()  //新增
        {           
            bds1.AddNew();
            mState = "NEW";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            txtcreate_by.Text = DBUtility._user_id;
            txtcreate_date.Text = DateTime.Now.Date.ToString();
        }

        private void Edit()  //編號
        {
            if (txtid.Text == "")
            {
                return;
            }
            if (luestate.EditValue.ToString() == "2")
            {
                string msg;
                if (mLanguage == "2")
                    msg = "Cannot be edited because the current status is cancel.";
                else
                    msg = "當前記錄為註銷狀態為，不可以進行編輯！";
                MessageBox.Show(msg, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            mState = "Edit";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            txtupdate_by.Text = DBUtility._user_id;
            txtupdate_date.Text = DateTime.Now.Date.ToString();
            txtid.Properties.ReadOnly = true;
            txtid.BackColor = System.Drawing.Color.White;
        }

        private void Cancel() //取消
        {
            bds1.CancelEdit();
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(panel1.Controls, false);
            mState = "";
            txtid.Properties.ReadOnly = true;
            Load_Date();
        }

        private void Load_Date()
        {
            dtDetail.Clear();
            const string sql = @"SELECT * From bs_department with(nolock)";           
            conn = new SqlConnection(DBUtility.ConnectionString);
            SDA = new SqlDataAdapter(sql, conn);
            SDA.Fill(dtDetail);

            bds1.DataSource = dtDetail;
            dgvDetails.DataSource = bds1;
        }

        private void Save()  //保存新增或修改的資料
        {
            if (dgvDetails.Rows.Count == 0)
            {
                return;
            }       
            if (mState == "NEW")
            {
                if (Valid_Doc())
                {
                    return;
                }
            }

            //dgvDetails.CurrentCell.RowIndex;行號           
            //Select a Cell Focus
            dgvDetails.CurrentCell = dgvDetails.Rows[0].Cells["id"];
            //Selected a Row 
            dgvDetails.Rows[0].Selected = true;

            bool flag_datavalid = false;
            for (int i = 0; i < dgvDetails.Rows.Count; i++)
            {
                if (dgvDetails.Rows[i].Cells["id"].Value.ToString() == "" || dgvDetails.Rows[i].Cells["name"].Value.ToString() == "" || dgvDetails.Rows[i].Cells["country_id"].Value.ToString() == "")
                {
                    flag_datavalid = true;
                    dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells["id"];//選中當前空白的行                    
                    break;
                }
            }
            if (flag_datavalid)
            {
                MessageBox.Show("Department cannot be empty !", myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            try
            {
                bds1.EndEdit();
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.InsertCommand = SCB.GetInsertCommand();
                SDA.UpdateCommand = SCB.GetUpdateCommand();

                SDA.Update(dtDetail);
                DBUtility.myMessageBox(myMsg.msgSave_ok, myMsg.msgTitle);
                //MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle);
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

        private void Delete() //刪除當前行
        {
            if (dgvDetails.RowCount == 0 && String.IsNullOrEmpty(txtid.Text))
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
                    //MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle);
                    DBUtility.myMessageBox(myMsg.msgSave_ok, myMsg.msgTitle);
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

        private void Print() //通用的打印方法
        {
            if (dgvDetails.RowCount > 0)
            {
                PrintDGV.Print_DataGridView(this.dgvDetails);
            }
        }

        private void Excel() //匯出EXCEL
        {
            if (dgvDetails.RowCount > 0)
            {
                ExpToExcel.DataGridViewToExcel(dgvDetails);
            }
        }

        //===========以下爲控件中的方法================
        private void txtID_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtid.Text))
            {
                if (mState == "")
                {
                    Find_Doc(txtid.Text);
                }
            }
        } 

        private void dgvDetails_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //產生行號
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dgvDetails.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvDetails.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvDetails.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void dgvDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetails.Rows.Count == 0)
            {
                return;
            }
            int cur_row = dgvDetails.CurrentCell.RowIndex;
            if (dgvDetails.Rows[cur_row].Cells["mostly_dept"].Value.ToString() == "True")
            {
                chkmostly_dept.Checked = true;
            }
            else
            {
                chkmostly_dept.Checked = false;
            }
            if (dgvDetails.Rows[cur_row].Cells["wh_dept"].Value.ToString() == "True")
            {
                chkwh_dept.Checked = true;
            }
            else
            {
                chkwh_dept.Checked = false;
            }
            if (dgvDetails.Rows[cur_row].Cells["op_dept"].Value.ToString() == "True")
            {
                chkop_dept.Checked = true;
            }
            else
            {
                chkop_dept.Checked = false;
            }
        }
                  
     
    }
}
