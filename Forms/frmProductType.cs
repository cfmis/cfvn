using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cfvn.CLS;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;

namespace cfvn.Forms
{
    public partial class frmProductType : DockContent
    {      
        
        public string mState = "";       
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        private clsToolBar objToolbar;
        string str_language;
        DataTable dtDetail = new DataTable();
        MsgInfo myMsg = new MsgInfo();

        public frmProductType()
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

        private void frmProductType_Load(object sender, EventArgs e)
        {
            dgvDetails.AutoGenerateColumns = false;
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);
            //種類
            DataTable dtCategory = clsApp.GetDataTable("SELECT id,name FROM bs_type WHERE group_id='M'");
            lueCategory.Properties.DataSource = dtCategory;
            lueCategory.Properties.ValueMember = "id";
            lueCategory.Properties.DisplayMember = "name";

            dtDetail = clsApp.GetDataTable("Select * From dbo.bs_product_type Where 1=0");
            bds1.DataSource = dtDetail; 
            dgvDetails.DataSource = bds1;
            Set_DataBindings();

            Find_Data();
        }
    

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNNEW_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void BTNEDIT_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            Delete();
        }     

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            bds1.CancelEdit();        

            mState = "";
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(panel1.Controls, false);
            dtDetail.RejectChanges();            
            dgvDetails.Enabled = true;
            dgvDetails.Focus(); 
        }

        private void BTNPRINT_Click(object sender, EventArgs e)
        {
            clsGeneralDataConvert.GridView_To_Print(dgvDetails);
        }

        private void Set_DataBindings()
        {
            txtid.DataBindings.Add("Text", bds1, "id");
            txtname.DataBindings.Add("Text", bds1, "name");
            txtenglishname.DataBindings.Add("Text", bds1, "english_name");
            txtremark.DataBindings.Add("Text", bds1, "remark");
            lueCategory.DataBindings.Add("EditValue", bds1, "category");
            luestate.DataBindings.Add("EditValue", bds1, "state");
            txtcreate_by.DataBindings.Add("Text", bds1, "create_by");
            txtcreate_date.DataBindings.Add("Text", bds1, "create_date");
            txtupdate_by.DataBindings.Add("Text", bds1, "update_by");
            txtupdate_date.DataBindings.Add("Text", bds1, "Update_date");
        }            

        public void AddNew()  //新增
        {
            bds1.AddNew();
            mState = "NEW";
            txtid.Focus();
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            SetObjValue.ClearObjValue(panel1.Controls, "1");
            luestate.EditValue = "0";
            Set_Grid_Status(false);           
            bds1.DataSource = dtDetail;           
            dgvDetails.DataSource = bds1;

        }

        private void SetButtonSatus(bool _flag) //設置工具欄
        {
            BTNNEW.Enabled = _flag;
            BTNEDIT.Enabled = _flag;
            BTNPRINT.Enabled = _flag;
            BTNDELETE.Enabled = _flag;
            grpbFind.Enabled = _flag;
           
            BTNSAVE.Enabled = !_flag;
            BTNCANCEL.Enabled = !_flag;
          
            if (objToolbar != null)
            {
                objToolbar.SetToolBar();
            }
        }

        private void Set_Grid_Status(bool _flag) // 表格是否可編輯
        {
            //false--不可編輯;true--可以編輯
            dgvDetails.Enabled = _flag;            
        }

        private void Edit()  //編輯
        {
            if (txtid.Text == "")
            {
                return;
            }
            if (dgvDetails.RowCount == 0)
            {
                return;
            }            
            SetButtonSatus(false);

            SetObjValue.SetEditBackColor(panel1.Controls, true);
            //Set_Grid_Status(true);
            dgvDetails.Enabled = false;
            mState = "EDIT";

            txtid.Properties.ReadOnly = true;
            txtid.BackColor = System.Drawing.Color.White;           
        }
      
        private void Delete() //刪除當前行
        {
            if (String.IsNullOrEmpty(txtid.Text))
            {
                return;
            }

            if (clsArtwork.Is_Used_in_mm_master(txtid.Text, "base_class"))
            {
                MessageBox.Show("Please note this Product type code is used in goods master","System info");
                return;
            }

            DialogResult dlg_result = MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlg_result == DialogResult.Yes)
            {
                string sql_u = string.Format(@"UPDATE dbo.cd_pattern SET state='2' WHERE id='{0}'",txtid.Text);
                int li_result = clsApp.ExecuteSqlUpdate(sql_u);
                if (li_result > 0)
                {
                    MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(myMsg.msgSave_error, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }               
            }
        }

        private void Save()  //保存
        {           
            if (txtid.Text == "")
            {
                MessageBox.Show("Product code cannot be empty!", "提示信息");
                txtid.Focus();
                return;
            }

            if (txtname.Text == "")
            {
                MessageBox.Show("Product Name cannot be empty!", "提示信息");
                return;
            }

            bool save_flag = false;

            #region  保存新增或編輯
            if (mState == "NEW" || mState == "EDIT")
            {
                
                if (mState == "EDIT"&& dgvDetails.RowCount == 0)
                {
                    MessageBox.Show(string.Format("Please note details data cannot be empty.", txtid.Text), "提示信息");
                    return;
                }

                if (txtid.Text.Length !=2)
                {
                    MessageBox.Show(string.Format("Please note the product type【{0}】error!", txtid.Text), "提示信息");
                    return;
                }

                if (mState == "NEW")
                {
                    //新增時檢查是否已存在主鍵值
                    string strSql = String.Format("Select '1' FROM dbo.bs_product_type WHERE id='{0}'", txtid.Text.Trim());
                    if (clsApp.ExecuteSqlReturnObject(strSql) != "")
                    {
                        MessageBox.Show(string.Format("Please note the Product Type【{0}】has been exists!", txtid.Text), "提示信息");
                        return;
                    }                  
                }
                const string sql_i =
                @"INSERT INTO dbo.bs_product_type(id,english_name,name,remark,category,state,create_by,create_date) 
                VALUES(@id,@english_name,@name,@remark,@category,'0', @user_id,getdate())";


                const string sql_u = @"Update dbo.bs_product_type SET english_name=@english_name,name=@name,remark=@remark,category=@category WHERE id=@id";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString); 
                myCon.Open();
                SqlTransaction myTrans = myCon.BeginTransaction();
                using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
                {
                    try
                    {
                        if (mState == "NEW")
                        {
                            myCommand.CommandText = sql_i;
                        }
                        else
                        {
                            myCommand.CommandText = sql_u;
                        }
                        myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@id", txtid.Text.Trim());
                        myCommand.Parameters.AddWithValue("@name", txtname.Text);
                        myCommand.Parameters.AddWithValue("@english_name", txtenglishname.Text);
                        myCommand.Parameters.AddWithValue("@remark", txtremark.Text);
                        myCommand.Parameters.AddWithValue("@category", lueCategory.EditValue);                        
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
            #endregion

            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(panel1.Controls, false);
            Set_Grid_Status(true);
            mState = "";
           
            if (save_flag)
            {               
                DBUtility.myMessageBox(myMsg.msgSave_ok, myMsg.msgTitle);
            }
            else
            {
                MessageBox.Show(myMsg.msgSave_error, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            Find_Data();
        }

        private void Find_Data()
        {
            string ls_sql;
            if (txtid1.Text == "")
                ls_sql = @"Select * From dbo.bs_product_type with(nolock) where state<>'2'";
            else
            {
                if (txtid1.Text.Length == 2)
                {
                    ls_sql = string.Format(@"Select * From dbo.bs_product_type with(nolock) where id ='{0}' and state<>'2'", txtid1.Text);
                }
                else
                {
                    ls_sql = string.Format(@"Select * From dbo.bs_product_type with(nolock) where id like '%{0}%' and state<>'2'", txtid1.Text);
                }
            }
            dtDetail = clsApp.GetDataTable(ls_sql);
            bds1.DataSource = dtDetail;
        }
    }
}
