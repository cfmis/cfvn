using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using cfvn.CLS;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;

using FastReport;

namespace cfvn.Forms
{
    public partial class frmCountry : DockContent
    {
        public string mID = "";    //臨時的主鍵值
        public string mState = ""; //新增或編號的狀態
        public static string str_language = "0";
        public string msgCustom;
        public int row_delete;
        MsgInfo myMsg = new MsgInfo();//實例化Messagegox用到的提示
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        private clsToolBar objToolbar;

        public frmCountry()
        {
            InitializeComponent();
            str_language = DBUtility._language;
            //翻譯 
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();

            //權限
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.SetToolBar();
            objToolbar.Set_Button_Image(toolStrip1);

        }

        private void frmCountry_Load(object sender, EventArgs e)
        {
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);
            Find();
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

        private void BTNDEL_Click(object sender, EventArgs e)
        {
            Delete();            
        }

        private void BTNFIND_Click(object sender, EventArgs e)
        {
            Find();
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
            BTNDEL.Enabled = _flag;
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
            bool flag;
            string doc = txtID.Text.Trim();
            string strSql = String.Format("Select '1' FROM dbo.bs_country WHERE id='{0}' and state<>'2'", doc);
            DataTable dt = clsApp.GetDataTable(strSql);
            if (dt.Rows.Count > 0)
            {               
                MessageBox.Show(myMsg.msgIsExists + String.Format("【{0}】", doc), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                flag = true;
            }
            else
            {
                flag = false;
            }
            dt.Dispose();
            return flag;
        }

        private bool Save_Before_Valid() //保存前檢查
        {
            if (txtID.Text == "" || txtname.Text == "" || txtenglish_name.Text == "")
            {
                if (str_language == "2")
                {
                    msgCustom = "Data cannot be empty.";
                }
                else
                {
                    msgCustom = "編號或描述資料不可爲空！";
                }
                MessageBox.Show(msgCustom, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Find_doc(string temp_id) //非新增或編號狀態下帶出的資料
        {
            if (!String.IsNullOrEmpty(temp_id))
            {
                string strsql = String.Format("SELECT id,name,english_name,remark,state,create_by,create_date,update_by,update_date FROM dbo.bs_country WHERE id='{0}' and state='0'", temp_id);
                DataTable dt = clsApp.GetDataTable(strsql);
                dgvDetails.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    if (str_language == "2")
                    {
                        msgCustom = "The NO. of the data does not exist.";
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
                    mID = txtID.Text;//保存臨時的ID號
                }
                Set_Master_Data(dt);
            }
        }

        private void Set_Master_Data(DataTable dtName)
        {
            txtID.Text = dtName.Rows[0]["id"].ToString();
            txtenglish_name.Text = dtName.Rows[0]["name"].ToString();
            txtname.Text = dtName.Rows[0]["english_name"].ToString();
            txtRemark.Text = dtName.Rows[0]["remark"].ToString();
            luestate.EditValue = dtName.Rows[0]["state"].ToString();
            txtcreate_by.Text = dtName.Rows[0]["create_by"].ToString();
            txtcreate_date.Text = dtName.Rows[0]["create_date"].ToString();
            txtupdate_by.Text = dtName.Rows[0]["update_by"].ToString();
            txtupdate_date.Text = dtName.Rows[0]["update_date"].ToString();
        }

        private void Set_Row_Position(string _doc) //定位到當前行 
        {
            Find();
            for (int i = 0; i < dgvDetails.RowCount; i++)
            {
                if (_doc == dgvDetails.Rows[i].Cells["id"].Value.ToString())
                {                    
                    dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells["id"]; //設置光標定位到當前選中的行
                    dgvDetails.Rows[i].Selected = true;
                    break;
                }
            }
        }

        private void AddNew()  //新增
        {
            mState = "NEW";
            txtID.Focus();
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(this.Controls, true);
            SetObjValue.ClearObjValue(this.Controls, "1");

            dgvDetails.Enabled = false;
        }

        private void Edit()  //編號
        {
            if (dgvDetails.RowCount == 0)
            {
               return ;
            }

            if (txtID.Text == "")
            {
                return;
            }
            
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(this.Controls, true);
            mState = "EDIT";

            txtID.Properties.ReadOnly = true;
            txtID.BackColor = System.Drawing.Color.White;
            dgvDetails.Enabled = false;
        }

        private void Cancel() //取消
        {
           
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(this.Controls, false);
            mState = "";
            dgvDetails.Enabled = true;
            if (!String.IsNullOrEmpty(mID))
            {
                Find_doc(mID);
            }
        }     

        private void Save()  //保存新增或修改的資料
        {
            if (!Save_Before_Valid())
            {
                return;
            }
            bool save_flag = false;

            if (mState == "NEW" || mState == "EDIT")
            {
                if (mState == "NEW")
                {
                    if (Valid_Doc())
                    {
                        return;
                    }
                }

                const string sql_new = "INSERT INTO bs_country(id,name,english_name,remark,state,crusr,crtim) values(@id,@name,@english_name,@remark,'0',@user_id,getdate())";
                const string sql_update = "UPDATE dbo.bs_country SET english_name=@english_name,name=@name,remark=@remark,update_by=@update_by,update_date=getdate() WHERE id=@id";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);
                myCon.Open();
                SqlTransaction myTrans = myCon.BeginTransaction();
                using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
                {
                    try
                    {
                        if (mState == "NEW")
                            myCommand.CommandText = sql_new;
                        else
                            myCommand.CommandText = sql_update;
                        myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@id", txtID.Text.Trim());
                        myCommand.Parameters.AddWithValue("@english_name", txtenglish_name.Text.Trim());
                        myCommand.Parameters.AddWithValue("@name", txtname.Text.Trim());
                        myCommand.Parameters.AddWithValue("@remark", txtRemark.Text.Trim());
                        myCommand.Parameters.AddWithValue("@user_id", DBUtility._user_id);
                        
                        myCommand.ExecuteNonQuery();
                        myTrans.Commit(); //數據提交
                        save_flag = true;
                    }
                    catch (Exception E)
                    {
                        myTrans.Rollback(); //數據回滾
                        save_flag = false;
                        throw new Exception(E.Message);
                    }
                    finally
                    {
                        myCon.Close();
                        myCon.Dispose();
                        myTrans.Dispose();
                    }
                }
            }

            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(this.Controls,false);
            mState = "";
            dgvDetails.Enabled = true;

            Set_Row_Position(txtID.Text.Trim());
            if (save_flag)
            {
                //MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                DBUtility.myMessageBox(myMsg.msgSave_ok, myMsg.msgTitle);
            }
            else
            {
                MessageBox.Show(myMsg.msgSave_error, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }     

        private void Delete() //刪除當前行
        {
            if (dgvDetails.RowCount == 0 && String.IsNullOrEmpty(txtID.Text))
            {
                return;
            }
            DialogResult result = MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                const string sql_del = "UPDATE dbo.bs_country Set state='2' WHERE id=@id";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);
                myCon.Open();
                SqlTransaction myTrans = myCon.BeginTransaction();
                using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
                {
                    try
                    {
                        myCommand.CommandText = sql_del;
                        myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@id", txtID.Text.Trim());
                        myCommand.ExecuteNonQuery();
                        myTrans.Commit(); //數據提交
                        dgvDetails.Rows.Remove(dgvDetails.CurrentRow);//移走當前行
                        MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception E)
                    {
                        myTrans.Rollback(); //數據回滾
                        throw new Exception(E.Message);
                    }
                    finally
                    {
                        myCon.Close();
                        myCon.Dispose();
                        myTrans.Dispose();
                    }
                }

            }
        }

        private void Find() //查詢出所有數據
        {
            dgvDetails.Focus();
            DataTable dt = clsApp.GetDataTable("SELECT id ,name,english_name,remark,state,create_by,create_date,update_by,update_date FROM dbo.bs_country Where state='0'");
            dgvDetails.DataSource = dt;
        }

        private void Print() //通用的打印方法
        {
            //if (dgvDetails.RowCount > 0)
            //{
            //    PrintDGV.Print_DataGridView(this.dgvDetails);
            //}
            
            
            using (Report report = new Report())
            {
                string file = System.Windows.Forms.Application.StartupPath;
                file += "\\Reports\\frxCountry.frx";
                if (!System.IO.File.Exists(file))
                {
                    MessageBox.Show(string.Format("The Report file [{0}] does not exists.",file), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                //file="C:\\CFVN\\CFVN\\Reports\\frxCountry.frx";
                report.Load(file);
                //传递数据
                report.RegisterData((DataTable)dgvDetails.DataSource, "myCountry"); 
                report.Show();
                ////静默打印
                //report.PrintSettings.ShowDialog = false;
                //report.Print();

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

        }

        private void dgvDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount > 0)
            {
                txtID.Text = dgvDetails.CurrentRow.Cells["id"].Value.ToString();
                txtname.Text = dgvDetails.CurrentRow.Cells["name"].Value.ToString();
                txtenglish_name.Text = dgvDetails.CurrentRow.Cells["english_name"].Value.ToString();
                txtRemark.Text = dgvDetails.CurrentRow.Cells["remark"].Value.ToString();
                luestate.EditValue = dgvDetails.CurrentRow.Cells["state"].Value.ToString();
                txtcreate_by.Text = dgvDetails.CurrentRow.Cells["create_by"].Value.ToString();
                txtcreate_date.Text = dgvDetails.CurrentRow.Cells["create_date"].Value.ToString();
                txtupdate_by.Text = dgvDetails.CurrentRow.Cells["update_by"].Value.ToString();
                txtupdate_date.Text = dgvDetails.CurrentRow.Cells["update_date"].Value.ToString();
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

   

     

    }
}
