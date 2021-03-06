﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using cfvn.CLS;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;

namespace cfvn.Forms
{
    public partial class frmBsType : DockContent
    {
        public string mID = "";    //臨時的主鍵值
        public string mGroup = "";
        public string mState = ""; //新增或編號的狀態
        public string mLanguage ;
        public string msgCustom;
        public int row_delete;
        MsgInfo myMsg = new MsgInfo();
        DataTable dtGroup ;
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        private clsToolBar objToolbar;

        public frmBsType()
        {
            InitializeComponent();
            mLanguage = DBUtility._language;            
            //翻譯 
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();

            //權限
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.SetToolBar();
            objToolbar.Set_Button_Image(toolStrip1);

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

        private void frmBsType_Load(object sender, EventArgs e)
        {
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);

            string sql_group;
            if(mLanguage=="2")
                sql_group = @"SELECT id,english_name as name FROM dbo.bs_type_group order by id";
            else
                sql_group = @"SELECT id,name FROM dbo.bs_type_group order by id";           

            //組別 
            dtGroup = clsApp.GetDataTable(sql_group);
            DataRow row2 = dtGroup.NewRow();
            dtGroup.Rows.Add(row2);
            dtGroup.DefaultView.Sort = "id ASC";
            dtGroup = dtGroup.DefaultView.ToTable();
            txtgroup_id.Properties.DataSource = dtGroup;            
            txtgroup_id.Properties.ValueMember = "id";
            txtgroup_id.Properties.DisplayMember = "name";

        }

        private void frmBsType_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGroup.Dispose();
        }

        // ===============以下爲自定義義方法=======================

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
            bool flag;
            string doc = txtid.Text.Trim();
            string type_group = txtgroup_id.EditValue.ToString();
            string strSql = String.Format("Select '1' FROM dbo.bs_type WHERE group_id='{0}' AND id='{1}'", type_group, doc);
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

        private void Find_doc(string temp_id) //非新增或編號狀態下帶出的資料
        {
            if (!String.IsNullOrEmpty(temp_id))
            {
                string strsql =string.Format(
                    @"SELECT group_id, id,isnull(name,'') as name,isnull(english_name,'') as english_name,
                    remark,create_by,create_date,update_by,update_date,state
                    FROM dbo.bs_type  with(nolock)                   
                    WHERE group_id='{0}' AND id='{1}'", txtgroup_id.EditValue,temp_id);
                DataTable dt = clsApp.GetDataTable(strsql);
                dgvDetails.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    if (mLanguage == "2")
                    {
                        msgCustom = "The Code of the data does not exist.";
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
                    mID = txtid.Text;//保存臨時的ID號                    
                }
                Set_Master_Data(dt);
            }
        }

        private void Find() //查詢出所有數據
        {
            mGroup = txtgroup_id.EditValue.ToString();

            dgvDetails.Focus();
            const string strSql =
                    @"SELECT A.group_id, A.id,isnull(A.name,'') as name,isnull(A.english_name,'') as english_name,
                    A.remark,A.create_by,A.create_date,A.update_by,A.update_date,state
                    FROM dbo.bs_type A with(nolock) Order by A.group_id,A.id";
            DataTable dt = clsApp.GetDataTable(strSql);
            dgvDetails.DataSource = dt;
            mID = "";            
        }

        private bool Save_Before_Valid() //保存前檢查
        {
            if (txtgroup_id.Text =="" || txtid.Text == "" || txtname.Text == "")
            {
                if (mLanguage == "2")
                {
                    msgCustom = "Code or Description Data cannot be empty.";
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
            txtid.Text = dtName.Rows[0]["id"].ToString();
            txtenglish_name.Text = dtName.Rows[0]["english_name"].ToString();
            txtname.Text = dtName.Rows[0]["name"].ToString();            

            txtRemark.Text = dtName.Rows[0]["remark"].ToString();
            txtcreate_by.Text = dtName.Rows[0]["create_by"].ToString();
            txtcreate_date.Text = dtName.Rows[0]["create_date"].ToString();
            txtupdate_by.Text = dtName.Rows[0]["update_by"].ToString();
            txtupdate_date.Text = dtName.Rows[0]["update_date"].ToString();

            txtgroup_id.EditValue = dtName.Rows[0]["group_id"].ToString();
            luestate.EditValue = dtName.Rows[0]["state"].ToString();
           
        }

        private void Set_Row_Position(string _doc) //定位到當前行 
        {            
            Find();            
            for (int i = 0; i < dgvDetails.RowCount; i++)
            {
                if (_doc == dgvDetails.Rows[i].Cells["id"].Value.ToString() &&
                    mGroup == dgvDetails.Rows[i].Cells["group_id"].Value.ToString())
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
            txtid.Focus();
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(this.Controls, true);
            SetObjValue.ClearObjValue(this.Controls, "1");
        }

        private void Edit()  //編號
        {
            if (dgvDetails.RowCount == 0)
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

            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(this.Controls, true);
            mState = "EDIT";

            txtid.Properties.ReadOnly = true;
            txtid.BackColor = System.Drawing.Color.White;

            txtgroup_id.Properties.ReadOnly = true;
            txtgroup_id.BackColor = System.Drawing.Color.White;           
        }

        private void Cancel() //取消
        {
            mState = "";
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(this.Controls, false);
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

            if (mState == "NEW")
            {
                if (Valid_Doc())
                {
                    return;
                }
                const string sql_new = @"INSERT INTO bs_type(group_id,id,name,english_name,remark,state,create_by,create_date)" +
                                    " VALUES(@group_id,@id,@name,@english_name,@remark,'0',@user_id,GETDATE())";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);
                myCon.Open();
                SqlTransaction myTrans = myCon.BeginTransaction();
                using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
                {
                    try
                    {
                        myCommand.CommandText = sql_new;
                        myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@group_id", txtgroup_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@id", txtid.Text.Trim());
                        myCommand.Parameters.AddWithValue("@name", txtname.Text.Trim());
                        myCommand.Parameters.AddWithValue("@english_name", txtenglish_name.Text.Trim());
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
                    }
                }
            }

            if (mState == "EDIT")
            {
                const string sql_update = "UPDATE bs_type SET name=@name,english_name=@english_name,remark=@remark,update_by=@user_id,update_date=GETDATE() WHERE group_id =@group_id AND id=@id";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);
                myCon.Open();
                SqlTransaction myTrans = myCon.BeginTransaction();
                using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
                {
                    try
                    {
                        myCommand.CommandText = sql_update;
                        myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@group_id", txtgroup_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@id", txtid.Text.Trim());
                        myCommand.Parameters.AddWithValue("@name", txtname.Text.Trim());
                        myCommand.Parameters.AddWithValue("@english_name", txtenglish_name.Text.Trim());
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
                    }
                }
            }

            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(this.Controls, false);
            mState = "";

            Set_Row_Position(txtid.Text.Trim());
            if (save_flag)
            {
                MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show(myMsg.msgSave_error, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Delete() //刪除當前行
        {
            if (dgvDetails.RowCount == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                const string sql_del = "Update bs_type Set state='2' WHERE group_id= @group_id AND id=@id";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);
                myCon.Open();
                SqlTransaction myTrans = myCon.BeginTransaction();
                using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
                {
                    try
                    {
                        myCommand.CommandText = sql_del;
                        myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@group_id", txtgroup_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@id", txtid.Text.Trim());
                        myCommand.ExecuteNonQuery();
                        myTrans.Commit(); //數據提交
                        dgvDetails.Rows.Remove(dgvDetails.CurrentRow);//移除當前行
                        //MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DBUtility.myMessageBox(myMsg.msgSave_ok, myMsg.msgTitle);
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

        private void Print() //通用的列印方法
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
                    Find_doc(txtid.Text);
                }
            }
        }

        private void dgvDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount > 0)
            {                
                txtgroup_id.EditValue = dgvDetails.CurrentRow.Cells["group_id"].Value.ToString();
                txtid.Text = dgvDetails.CurrentRow.Cells["id"].Value.ToString();
                txtname.Text = dgvDetails.CurrentRow.Cells["name"].Value.ToString();
                txtenglish_name.Text = dgvDetails.CurrentRow.Cells["english_name"].Value.ToString();
                txtRemark.Text = dgvDetails.CurrentRow.Cells["remark"].Value.ToString();
                txtcreate_by.Text = dgvDetails.CurrentRow.Cells["create_by"].Value.ToString();
                txtcreate_date.Text = dgvDetails.CurrentRow.Cells["create_date"].Value.ToString();
                txtupdate_by.Text = dgvDetails.CurrentRow.Cells["update_by"].Value.ToString();
                txtupdate_date.Text = dgvDetails.CurrentRow.Cells["update_date"].Value.ToString();
                luestate.EditValue = dgvDetails.CurrentRow.Cells["state"].Value.ToString();        
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
