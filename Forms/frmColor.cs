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
    public partial class frmColor : DockContent
    {
        public string mID = "";    //臨時的主鍵值
        public string mState = ""; //新增或編號的狀態
        public static string str_language = "0";
        public string msgCustom;
        public int row_delete;
        DataTable dtDetails = new DataTable();
        MsgInfo myMsg = new MsgInfo();
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        private clsToolBar objToolbar;

        public frmColor()
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

        private void frmColor_Load(object sender, EventArgs e)
        {
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);

            string sql_working, sql_group, sql_plate_effect, sql_color_effect,sql_outer_layer;
            if (str_language == "2")
            {
                sql_working = @"SELECT id,english_name as name FROM dbo.bs_working Where kind='C'";
                sql_group = @"SELECT id,english_name as name FROM dbo.bs_group";
                sql_plate_effect = @"SELECT id,english_name as name FROM dbo.bs_plate_effect";
                sql_color_effect = @"Select '' as id,'' as name Union SELECT id,english_name FROM dbo.bs_color_effect";
                sql_outer_layer = @"Select '' as id,'' as name Union SELECT id,english_name FROM dbo.bs_outer";
            }
            else
            {
                sql_working = @"SELECT id,name FROM dbo.bs_working Where kind='C'";
                sql_group = @"SELECT id,name FROM dbo.bs_group";
                sql_plate_effect = @"SELECT id,name FROM dbo.bs_plate_effect";
                sql_color_effect = @"Select '' as id,'' as name Union SELECT id,name FROM dbo.bs_color_effect";
                sql_outer_layer = @"Select '' as id,'' as name Union SELECT id,name FROM dbo.bs_outer";
            }

            //工序代碼  
            DataTable dtWorking = clsApp.GetDataTable(sql_working);
            DataRow row1 = dtWorking.NewRow();//插一空行
            dtWorking.Rows.Add(row1);
            dtWorking.DefaultView.Sort = "id ASC";//排序
            dtWorking = dtWorking.DefaultView.ToTable();//排序後重新賦值
            luework_id.Properties.DataSource = dtWorking;
            luework_id.Properties.ValueMember = "id";
            luework_id.Properties.DisplayMember = "name";


            //組別 
            DataTable dtGroup = clsApp.GetDataTable(sql_group);
            DataRow row2 = dtGroup.NewRow();
            dtGroup.Rows.Add(row2);
            dtGroup.DefaultView.Sort = "id ASC";
            dtGroup = dtGroup.DefaultView.ToTable();
            luecolor_sale_group.Properties.DataSource = dtGroup;
            luecolor_sale_group.Properties.ValueMember = "id";
            luecolor_sale_group.Properties.DisplayMember = "name";

            //電鍍效果
            DataTable dtPlate = clsApp.GetDataTable(sql_plate_effect);
            DataRow row3 = dtPlate.NewRow();
            dtPlate.Rows.Add(row3);
            dtPlate.DefaultView.Sort = "id ASC";
            dtPlate = dtPlate.DefaultView.ToTable();
            lueple_code.Properties.DataSource = dtPlate;
            lueple_code.Properties.ValueMember = "id";
            lueple_code.Properties.DisplayMember = "name";

            //做色效果
            DataTable dtColor = clsApp.GetDataTable(sql_color_effect);           
            dtColor.DefaultView.Sort = "id ASC";
            dtColor = dtColor.DefaultView.ToTable();
            luecolor_code.Properties.DataSource = dtColor;
            luecolor_code.Properties.ValueMember = "id";
            luecolor_code.Properties.DisplayMember = "name";

            //外層
            DataTable dtOuter = clsApp.GetDataTable(sql_outer_layer);
            dtOuter.DefaultView.Sort = "id ASC";
            dtOuter = dtOuter.DefaultView.ToTable();
            lueouter_layer.Properties.DataSource = dtOuter;
            lueouter_layer.Properties.ValueMember = "id";
            lueouter_layer.Properties.DisplayMember = "name";
        }

        private void frmColor_FormClosed(object sender, FormClosedEventArgs e)
        {
            //dtWorking.Dispose();
            //dtGroup.Dispose();
            //dtPlate.Dispose();
            //dtColor.Dispose();
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
            Find("");
        }

        private void BTNPRINT_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void BTNEXCEL_Click(object sender, EventArgs e)
        {
            Excel();
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
            dgvDetails.Enabled = _flag;
            if (objToolbar != null)
            {
                objToolbar.SetToolBar();
            }
        }      

        private bool Valid_Doc() //主建是否已存在
        {
            bool flag;
            string doc = txtID.Text.Trim();
            string strSql = String.Format("Select '1' FROM bs_color WHERE id='{0}'", doc);
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


        private void Find(string ls_id) //查詢出所有數據
        {
            dgvDetails.Focus();
            string strSql= strSql =
                @"SELECT id,old_id,name,english_name,work_id,color_sale_group,do_color,ple_code,color_code,remark,outer_layer,create_by,create_date,update_by,update_date,state                
                FROM dbo.bs_color with(nolock)               
                WHERE ";
            if (ls_id == "")
            {                
               strSql +=" state<>'2'";
            }
            else
            {
                strSql += string.Format(" id='{0}' and state<>'2'", ls_id);
            }
            dtDetails = clsApp.GetDataTable(strSql);
            dgvDetails.DataSource = dtDetails;            
        }

        private bool Save_Before_Valid() //保存前檢查
        {
            if (txtID.Text == "" || txtname.Text == "")
            {
                if (str_language == "2")
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
              
        
        private void Set_Row_Position(string ls_id) //定位到當前行 
        {
            Find("");
            for (int i = 0; i < dgvDetails.RowCount; i++)
            {
                if (ls_id == dgvDetails.Rows[i].Cells["id"].Value.ToString())
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
            SetObjValue.SetEditBackColor(this.Controls,true);                                
            SetObjValue.ClearObjValue(this.Controls, "1");
        }

        private void Edit()  //編號
        {
            if (dgvDetails.RowCount == 0)
            {
                return;
            }
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(this.Controls, true);
            mState = "EDIT";

            txtID.Properties.ReadOnly = true;
            txtID.BackColor = System.Drawing.Color.White;
        }

        private void Cancel() //取消
        {
            mState = "";
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(this.Controls, false);
            dtDetails.RejectChanges();
            dgvDetails.Focus(); 
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
                const string sql_new = @"INSERT INTO bs_color(id,old_id,name,english_name,work_id,color_sale_group,do_color,ple_code,color_code,remark,outer_layer,create_by,create_date)" +
                                    " VALUES(@id,@old_id,@name,@english_name,@work_id,@color_sale_group,@do_color,@ple_code,@color_code,@remark,@outer_layer,@user_id,GETDATE())";
                const string sql_update = "UPDATE bs_color SET old_id=@old_id,name=@name,english_name=@english_name,work_id=@work_id,color_sale_group=@color_sale_group," +
                            "do_color=@do_color,ple_code=@ple_code,color_code=@color_code,remark=@remark,outer_layer=@outer_layer,update_by=@user_id,update_date=GETDATE() WHERE id=@id";
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
                        myCommand.Parameters.AddWithValue("@old_id", txtold_id.Text.Trim());
                        myCommand.Parameters.AddWithValue("@work_id", luework_id.EditValue);
                        myCommand.Parameters.AddWithValue("@color_sale_group", luecolor_sale_group.EditValue);
                        myCommand.Parameters.AddWithValue("@do_color", txtdo_color.Text.Trim());
                        myCommand.Parameters.AddWithValue("@ple_code", lueple_code.EditValue);
                        myCommand.Parameters.AddWithValue("@color_code", luecolor_code.EditValue);
                        myCommand.Parameters.AddWithValue("@remark", txtRemark.Text.Trim());
                        myCommand.Parameters.AddWithValue("@outer_layer", lueouter_layer.EditValue.ToString());                       
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
            SetObjValue.SetEditBackColor(this.Controls, false);
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
     
        private void Delete() //刪除當前行
        {
            if (dgvDetails.RowCount == 0)
            {
                return;
            }

            DialogResult result = MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                if (clsArtwork.Is_Used_in_mm_master(txtID.Text, "color"))
                {
                    MessageBox.Show("Please note this color id is used in goods master", "System info");
                    return;
                }                
                const string sql_del = "UPDATE dbo.bs_color set state='2' WHERE id=@id";
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
     
        private void dgvDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount > 0)
            {
                txtID.Text = dgvDetails.CurrentRow.Cells["id"].Value.ToString();
                txtname.Text = dgvDetails.CurrentRow.Cells["name"].Value.ToString();
                txtenglish_name.Text = dgvDetails.CurrentRow.Cells["english_name"].Value.ToString();
                txtold_id.Text = dgvDetails.CurrentRow.Cells["old_id"].Value.ToString();
                luework_id.EditValue = dgvDetails.CurrentRow.Cells["work_id"].Value.ToString();
                luecolor_sale_group.EditValue = dgvDetails.CurrentRow.Cells["color_sale_group"].Value.ToString();
                txtdo_color.Text = dgvDetails.CurrentRow.Cells["do_color"].Value.ToString();
                lueple_code.EditValue = dgvDetails.CurrentRow.Cells["ple_code"].Value.ToString();
                luecolor_code.EditValue = dgvDetails.CurrentRow.Cells["color_code"].Value.ToString();
                lueouter_layer.EditValue = dgvDetails.CurrentRow.Cells["outer_layer"].Value.ToString();

                txtRemark.Text = dgvDetails.CurrentRow.Cells["remark"].Value.ToString();
                txtcreate_by.Text = dgvDetails.CurrentRow.Cells["create_by"].Value.ToString();
                txtcreate_date.Text = dgvDetails.CurrentRow.Cells["create_date"].Value.ToString();
                txtupdate_by.Text = dgvDetails.CurrentRow.Cells["update_by"].Value.ToString();
                txtupdate_date.Text = dgvDetails.CurrentRow.Cells["update_date"].Value.ToString();

                //txtWk_desc.Text = dgvDetails.CurrentRow.Cells["wk_desc"].Value.ToString();
                //txtGrp_desc.Text = dgvDetails.CurrentRow.Cells["group_desc"].Value.ToString();
                //txtPle_desc.Text = dgvDetails.CurrentRow.Cells["ple_desc"].Value.ToString();
                //txtClr_desc.Text = dgvDetails.CurrentRow.Cells["clr_effect_desc"].Value.ToString();
                luestate.EditValue = dgvDetails.CurrentRow.Cells["state"].Value.ToString();
                mID = txtID.Text;
            }
            else
            {
                mID = "";
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
