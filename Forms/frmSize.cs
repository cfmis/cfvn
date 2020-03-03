using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using cfvn.CLS;
using WeifenLuo.WinFormsUI.Docking;


namespace cfvn.Forms
{
    public partial class frmSize : DockContent
    {
        public string mID = "";    //臨時的主鍵值
        public string mState = ""; //新增或編號的狀態
        public static string str_language = "0";
        public string msgCustom ;
        public int row_delete;
        MsgInfo myMsg = new MsgInfo();//實例化Messagegox用到的提示
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        private clsToolBar objToolbar;

        public frmSize()
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

        private void frmSize_Load(object sender, EventArgs e)
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

        private void BTNDELETE_Click(object sender, EventArgs e)
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
            BTNDELETE.Enabled = _flag;
            BTNFIND.Enabled = _flag;
            BTNSAVE.Enabled = !_flag;
            BTNCANCEL.Enabled = !_flag;

            if (objToolbar != null)
            {
                objToolbar.SetToolBar();
            }
        }    

        private bool Valid_Doc()
        {
            bool flag;
            string doc = txtID.Text.Trim();
            string strSql = String.Format("Select '1' FROM bs_size WHERE id='{0}' and state<>'2'", doc);
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

        private void Find_doc(string temp_id)
        {
            if (!String.IsNullOrEmpty(temp_id))
            {
                string strsql = String.Format("SELECT * FROM dbo.bs_size WHERE id='{0}' and state<>'2'", temp_id);
                DataTable dt = clsApp.GetDataTable(strsql);
                dgvSize.DataSource = dt;
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
                    SetObjValue.ClearObjValue(this.Controls, "2");
                    return;
                }
                else
                {
                    mID = txtID.Text;//保存臨時的ID號
                }
                Set_Master_Data(dt);
            }
        }

        private bool Save_Before_Valid()
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

        private void Set_Master_Data(DataTable dtName)
        {
            txtID.Text = dtName.Rows[0]["id"].ToString();
            txtenglish_name.Text = dtName.Rows[0]["english_name"].ToString();
            txtname.Text = dtName.Rows[0]["name"].ToString();
            txtremark.Text = dtName.Rows[0]["remark"].ToString();
            txtclassify.Text = dtName.Rows[0]["classify"].ToString();
            luestate.EditValue = dtName.Rows[0]["state"].ToString();
            txtcreate_by.Text = dtName.Rows[0]["create_by"].ToString();
            txtcreate_date.Text = dtName.Rows[0]["create_date"].ToString();
            txtupdate_by.Text = dtName.Rows[0]["update_by"].ToString();
            txtupdate_date.Text = dtName.Rows[0]["update_date"].ToString();
        }

        private void Set_Row_Position(string _doc)
        {
            //定位到當前行           
            Find();
            for (int i = 0; i < dgvSize.RowCount; i++)
            {
                if (_doc == dgvSize.Rows[i].Cells["id"].Value.ToString())
                {                    
                    dgvSize.CurrentCell = dgvSize.Rows[i].Cells["id"]; //設置光標定位到當前選中的行
                    dgvSize.Rows[i].Selected = true;
                    break;
                }
            }
        }
    
        private void AddNew()
        {
            mState = "NEW";
            txtID.Focus();
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(this.panel1.Controls, true);
            SetObjValue.ClearObjValue(this.panel1.Controls, "1");
        }

        private void Edit()
        {
            if (dgvSize.RowCount == 0)
            {
                return;
            }

            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(this.panel1.Controls, true);
            mState = "EDIT";

            txtID.Properties.ReadOnly = true;
            txtID.BackColor = System.Drawing.Color.White;
        }

        private void Save()
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

                const string sql_new = "INSERT INTO bs_size(id,name,english_name,remark,classify,state,create_by,create_date) values(@id,@name,@english_name,@remark,@classify,'0',@user_id,getdate())";
                const string sql_update = "UPDATE bs_size SET name=@name,english_name=@english_name,remark=@remark,classify=@classify,update_by=@user_id,update_date=getdate() WHERE id=@id";
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
                        myCommand.Parameters.AddWithValue("@name", txtname.Text.Trim());
                        myCommand.Parameters.AddWithValue("@english_name", txtenglish_name.Text.Trim());                        
                        myCommand.Parameters.AddWithValue("@remark", txtremark.Text.Trim());
                        myCommand.Parameters.AddWithValue("@classify", txtclassify.Text.Trim());
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
                    }
                }
            }

            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(this.panel1.Controls, false);
            mState = "";

            Set_Row_Position(txtID.Text.Trim());
            if (save_flag)
            {
                MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(myMsg.msgSave_error, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Cancel()
        {
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(this.panel1.Controls, false);
            mState = "";
            if (!String.IsNullOrEmpty(mID))
            {
                Find_doc(mID);
            }
        }

        private void Delete()
        {
            if (dgvSize.RowCount == 0 && String.IsNullOrEmpty(txtID.Text))
            {
                return;
            }

            DialogResult result = MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (clsArtwork.Is_Used_in_mm_master(txtID.Text, "size_id"))
                {
                    MessageBox.Show("Please note this size id is used in goods master", "System info");
                    return;
                }                
                //const string sql_del = "DELETE FROM bs_size WHERE size_id=@size_id";
                const string sql_del = "UPDATE bs_size SET state='2' WHERE id=@id";
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
                        dgvSize.Rows.Remove(dgvSize.CurrentRow);//移走當前行
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
                    }
                }

            }
        }

        private void Find()
        {
            string ls_sql;
            if (txtid1.Text == "" && txtid2.Text == "")
                ls_sql = @"Select * From dbo.bs_size with(nolock) where state<>'2'";
            else
            {
                ls_sql = string.Format(@"Select * From dbo.bs_size with(nolock) where id >='{0}' and id<='{1}' and state<>'2'", txtid1.Text, txtid2.Text);
            }
            DataTable dt = clsApp.GetDataTable(ls_sql);
            dgvSize.DataSource = dt;
        }

        private void Print()
        {
            if (dgvSize.RowCount > 0)
            {
                PrintDGV.Print_DataGridView(this.dgvSize);
            }
        }

        private void Excel() //匯出EXCEL
        {
            if (dgvSize.RowCount > 0)
            {
                ExpToExcel.DataGridViewToExcel(dgvSize);
            }
        }


        //===========以下爲控件中的方法================   

        private void txtID_Leave(object sender, EventArgs e)
        {
            //if (!String.IsNullOrEmpty(txtID.Text))
            //{
            //    if (mState == "")
            //    {
            //        Find_doc(txtID.Text);
            //    }
            //}
        }

        private void dgvSize_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSize.RowCount > 0)
            {                
                txtID.Text = dgvSize.CurrentRow.Cells["id"].Value.ToString();
                txtname.Text = dgvSize.CurrentRow.Cells["name"].Value.ToString();
                txtenglish_name.Text = dgvSize.CurrentRow.Cells["english_name"].Value.ToString();
                txtremark.Text = dgvSize.CurrentRow.Cells["remark"].Value.ToString();
                txtclassify.Text = dgvSize.CurrentRow.Cells["classify"].Value.ToString();
                luestate.EditValue = dgvSize.CurrentRow.Cells["state"].Value.ToString();
                txtcreate_by.Text = dgvSize.CurrentRow.Cells["create_by"].Value.ToString();
                txtcreate_date.Text = dgvSize.CurrentRow.Cells["create_date"].Value.ToString();
                txtupdate_by.Text = dgvSize.CurrentRow.Cells["update_by"].Value.ToString();
                txtupdate_date.Text = dgvSize.CurrentRow.Cells["update_date"].Value.ToString();
            }
        }      

        private void dgvSize_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //產生行號
            System.Drawing.Rectangle rectangle = new System.Drawing.Rectangle(e.RowBounds.Location.X,
                e.RowBounds.Location.Y,
                dgvSize.RowHeadersWidth - 4,
                e.RowBounds.Height);

            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(),
                dgvSize.RowHeadersDefaultCellStyle.Font,
                rectangle,
                dgvSize.RowHeadersDefaultCellStyle.ForeColor,
                TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }

        private void txtid1_Leave(object sender, EventArgs e)
        {
            txtid2.Text = txtid1.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Find();           
        }

     
    }   
    
}
