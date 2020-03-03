using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cfvn.CLS;
using DevExpress.XtraGrid.Views.Base;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;
using System.IO;

namespace cfvn.Forms
{
    public partial class frmBsArtWork : DockContent
    {
        public string mID = "";    //臨時的主鍵值
        public string mState = ""; //新增或編號的狀態
        public static string str_language = "0";
        public string msgCustom;
        public int row_delete;
        DataTable dtMostly = new DataTable();
        DataTable dtDetails = new DataTable();
        DataTable dtTempDel = new DataTable();
        MsgInfo myMsg = new MsgInfo();
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        public clsAppPublic clsPub = new clsAppPublic();
        private clsToolBar objToolbar;
        private string mArtWorkPath;

        public frmBsArtWork()
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
            mArtWorkPath = clsPub.GetArtWorkPath();
           
        }

        private void frmBsArtWork_Load(object sender, EventArgs e)
        {
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);
            dtMostly = clsApp.GetDataTable("Select * From dbo.cd_pattern Where 1=0");
            dtDetails = clsApp.GetDataTable("Select * From dbo.cd_pattern_details Where 1=0");
            dtTempDel = dtDetails.Clone();
            bds_h.DataSource = dtMostly;
            bds_d.DataSource = dtDetails;
            gridControl1.DataSource = bds_d;
            Set_DataBindings();

            DataTable dtMat = clsArtwork.Return_mat_type();           
            clMat_id.DataSource = dtMat;
            clMat_id.DisplayMember = "name";
            clMat_id.ValueMember = "id";
            //回樣類型
            DataTable dtAcus = clsArtwork.Return_cd_acus();
            clPoduct_type_id.DataSource = dtAcus;
            clPoduct_type_id.DisplayMember = "name";
            clPoduct_type_id.ValueMember = "id";

            DataTable dtSizeRange = clsArtwork.Return_size_range();
            clSize_range.DataSource = dtSizeRange;
            clSize_range.DisplayMember = "name";
            clSize_range.ValueMember = "id";
            
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

        private void BTNITEMADD_Click(object sender, EventArgs e)
        {
            AddNew_Item();
        }

        private void BTNITEMDEL_Click(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount == 1)
            {
                MessageBox.Show("Please delete it at the master location !", "System info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtid.Focus();
                return;
            }

            DialogResult result = MessageBox.Show("是否刪除當前明細資料?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int curRow = dgvDetails.FocusedRowHandle;
                //將當前行刪除幷加到臨時表中
                DataRow newRow = dtTempDel.NewRow();
                newRow["id"] = txtid.Text;
                newRow["sequence_id"] = dgvDetails.GetRowCellDisplayText(curRow, "sequence_id");               
                dtTempDel.Rows.Add(newRow);
                dgvDetails.DeleteRow(curRow);//移走當前行
            }
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {
            bds_h.CancelEdit();
            bds_d.CancelEdit();

            mState = "";
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(panel1.Controls, false);
            Set_Grid_Status(false);
            dtDetails.RejectChanges();
            dgvDetails.Focus(); 
        }

        private void BTNPRINT_Click(object sender, EventArgs e)
        {

        }

        private void Set_DataBindings()
        {
            txtid.DataBindings.Add("Text", bds_h, "id");
            txtname.DataBindings.Add("Text", bds_h, "name");
            txtenglish_name.DataBindings.Add("Text", bds_h, "english_name");
            txtremark.DataBindings.Add("Text", bds_h, "remark");
            luestate.DataBindings.Add("EditValue", bds_h, "state");
            txtcreate_by.DataBindings.Add("Text", bds_h, "create_by");
            txtcreate_date.DataBindings.Add("Text", bds_h, "create_date");
            txtupdate_by.DataBindings.Add("Text", bds_h, "update_by");
            txtupdate_date.DataBindings.Add("Text", bds_h, "Update_date");
        }
            

        public void AddNew()  //新增
        {           
            mState = "NEW";
            txtid.Focus();
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            SetObjValue.ClearObjValue(panel1.Controls, "1");
            luestate.EditValue = "0";
            Set_Grid_Status(true);
            dtDetails.Clear();
            bds_d.DataSource = dtDetails;
            gridControl1.DataSource = bds_d;

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
            BTNITEMADD.Enabled = !_flag;
            BTNITEMDEL.Enabled = !_flag;

            if (objToolbar != null)
            {
                objToolbar.SetToolBar();
            }
        }

        private void Set_Grid_Status(bool _flag) // 表格是否可編輯
        {
            //false--不可編輯;true--可以編輯
            dgvDetails.OptionsBehavior.Editable = _flag;
            //gridView2.OptionsBehavior.Editable = _flag; 
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
            Set_Grid_Status(true);
            mState = "EDIT";

            txtid.Properties.ReadOnly = true;
            txtid.BackColor = System.Drawing.Color.White;
           
        }

        /// <summary>
        /// 添加明細表新行
        /// </summary>
        private void AddNew_Item()
        {
            if (!String.IsNullOrEmpty(txtid.Text.Trim())) // 有內容
            {
                if (Check_Details_Valid())
                {
                    return;
                }
                Set_Grid_Status(true);
                dgvDetails.AddNewRow();//新增
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "id", txtid.Text);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "sequence_id", (dgvDetails.RowCount).ToString("000"));                 

                ColumnView view = (ColumnView)dgvDetails;//初始單元格焦點
                view.FocusedColumn = view.Columns["mat_id"];
                view.Focus();
            }
            else
            {
                MessageBox.Show("Master data cannot be empty!", "System info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtid.Focus();
            }
        }

        private bool Check_Details_Valid() //檢查明細資料的有效性
        {
            //測試項目必須有輸入
            bool _flag = false;
            if (dgvDetails.RowCount > 0)
            {
                txtremark.Focus();
                //因toolStrip控件焦點問題
                //設置焦點行某單元格獲得焦點，加此代碼目的使輸入的值生效，防止取到的值爲空 
                int curRow = 0;
                for (int i = 0; i < dgvDetails.RowCount; i++)
                {
                    curRow = dgvDetails.GetRowHandle(i);
                    if (String.IsNullOrEmpty(dgvDetails.GetRowCellDisplayText(curRow,"size_range")) || String.IsNullOrEmpty(dgvDetails.GetRowCellDisplayText(curRow, "products_type")))
                    {
                        _flag = true;
                        MessageBox.Show("Products type or size range data cannot be empty!", "System info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ColumnView view1 = (ColumnView)dgvDetails;
                        view1.FocusedColumn = view1.Columns["products_type"]; //設置單元格焦點
                        break;
                    }
                }
            }
            return _flag;
        }

        //private void GetDocNo() //取最大單據編號
        //{
        //    string strYear = clsPublicOfCF01.ExecuteSqlReturnObject("Select substring(convert(varchar(10),GETDATE(),120),1,4)");
        //    string strDoc = String.Format("{0}{1}", strArea, strYear);
        //    string strSeq;
        //    string strMaxSeq;
        //    DataTable dtMaxSeq = new DataTable();
        //    dtMaxSeq = clsPublicOfCF01.GetDataTable(String.Format("SELECT MAX(id) as id FROM dbo.quotation_mostly WHERE id LIKE '{0}%'", strDoc));
        //    if (String.IsNullOrEmpty(dtMaxSeq.Rows[0]["id"].ToString()))
        //    {
        //        strSeq = "000001";
        //    }
        //    else
        //    {
        //        strMaxSeq = dtMaxSeq.Rows[0]["id"].ToString();
        //        strSeq = strMaxSeq.Substring(strMaxSeq.Length - 6);
        //        strSeq = (Convert.ToInt32(strSeq) + 1).ToString("000000");
        //    }
        //    strMaxSeq = strDoc + strSeq;
        //    txtID.Text = strMaxSeq;
        //}

        private void Delete() //刪除當前行
        {
            if (String.IsNullOrEmpty(txtid.Text))
            {
                return;
            }

            if (clsArtwork.Is_Used_in_mm_master(txtid.Text, "blueprint_id"))
            {
                MessageBox.Show("Please note this artwork code is used in goods master","System info");
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
                MessageBox.Show("Art code cannot be empty!", "提示信息");
                txtid.Focus();
                return;
            }          

            if (Check_Details_Valid())//檢查明細資料的有效性
            {
                return;
            }

            bool save_flag = false;

            #region  保存新增或編輯
            if (mState == "NEW" || mState == "EDIT")
            {
                if (dgvDetails.RowCount == 0)
                {
                    MessageBox.Show(string.Format("Please note details data cannot be empty.", txtid.Text), "提示信息");
                    return;
                }

                if (txtid.Text.Length < 7)
                {
                    MessageBox.Show(string.Format("Please note the Artcode【{0}】not long enough!", txtid.Text), "提示信息");
                    return;
                }

                if (mState == "NEW")
                {
                    //新增時檢查是否已存在主鍵值
                    string strSql = String.Format("Select '1' FROM dbo.cd_pattern WHERE id='{0}'", txtid.Text.Trim());
                    if (clsApp.ExecuteSqlReturnObject(strSql) != "")
                    {
                        MessageBox.Show(string.Format("Please note the Artcode【{0}】has been exists!", txtid.Text), "提示信息");
                        return;
                    }                  
                }
                const string sql_i =
                @"INSERT INTO dbo.cd_pattern(id,name,english_name,remark,state,create_by,create_date) VALUES(@id,@name,@english_name,@remark,'0',@user_id,getdate())";
                //oi_date=CASE LEN(@oi_date) WHEN 0 THEN null ELSE @oi_date END
                const string sql_u = @"Update dbo.cd_pattern SET name=@name,english_name=@english_name,remark=@remark WHERE id=@id";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString); 
                myCon.Open();
                SqlTransaction myTrans = myCon.BeginTransaction();
                using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
                {
                    try
                    {
                        if (mState == "NEW")
                            myCommand.CommandText = sql_i;
                        else
                            myCommand.CommandText = sql_u;
                        myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@id", txtid.Text.Trim());
                        //myCommand.Parameters.AddWithValue("@report_date", clsApp.Return_String_Date(dtreport_date.EditValue.ToString()));
                        myCommand.Parameters.AddWithValue("@name", txtname.Text);
                        myCommand.Parameters.AddWithValue("@english_name", txtenglish_name.Text);
                        myCommand.Parameters.AddWithValue("@remark", txtremark.Text);                       
                        myCommand.Parameters.AddWithValue("@user_id", DBUtility._user_id);
                        myCommand.ExecuteNonQuery();
                        //處理【項目刪除】刪除明細資料
                        string sql_item_d;
                        for (int i = 0; i < dtTempDel.Rows.Count; i++)
                        {
                            //刪除明細
                            sql_item_d = @"DELETE FROM dbo.cd_pattern_details WHERE id=@id AND sequence_id=@sequence_id";
                            myCommand.CommandText = sql_item_d;
                            myCommand.Parameters.Clear();
                            myCommand.Parameters.AddWithValue("@id", txtid.Text.Trim());
                            myCommand.Parameters.AddWithValue("@sequence_id", dtTempDel.Rows[i]["sequence_id"].ToString());
                            myCommand.ExecuteNonQuery();
                        }
                        //保存明細
                        int curRow;
                        string rowStatus;
                        if (dgvDetails.RowCount > 0)
                        {
                            const string sql_item_i =
                                 @"INSERT INTO dbo.cd_pattern_details
                                (id,sequence_id,materiel_id,products_type,size_range,actual_size,draw_no,brand_no,customer_id,cust_name,develop_date,markcontent,picture_name,wrok_by,remark) VALUES
                                (@id,@sequence_id,@materiel_id,@products_type,@size_range,@actual_size,@draw_no,@brand_no,@customer_id,@cust_name,CASE LEN(@develop_date) WHEN 0 THEN null ELSE @develop_date END,@markcontent,@picture_name,@wrok_by,@remark)";
                            const string sql_item_u =
                                @"Update dbo.cd_pattern_details 
                                SET materiel_id=@materiel_id,products_type=@products_type,size_range=@size_range,actual_size=@actual_size,draw_no=@draw_no,brand_no=@brand_no,customer_id=@customer_id,cust_name=@cust_name,
                                develop_date=CASE LEN(@develop_date) WHEN 0 THEN null ELSE @develop_date END,markcontent=@markcontent,picture_name=@picture_name,wrok_by=@wrok_by,remark=@remark
                                Where id=@id And sequence_id=@sequence_id";

                            for (int i = 0; i < dgvDetails.RowCount; i++)
                            {
                                curRow = dgvDetails.GetRowHandle(i);
                                //dgvDetails.AddNewRow();//新增必須初始貨當前單元格焦點
                                //否則rowStatus取不到狀態值
                                rowStatus = dgvDetails.GetDataRow(curRow).RowState.ToString();
                                if (rowStatus == "Added" || rowStatus == "Modified")
                                {
                                    if (rowStatus == "Added")
                                        myCommand.CommandText = sql_item_i;
                                    else
                                        myCommand.CommandText = sql_item_u;
                                    myCommand.Parameters.Clear();
                                    myCommand.Parameters.AddWithValue("@id", txtid.Text.Trim());
                                    myCommand.Parameters.AddWithValue("@sequence_id", dgvDetails.GetRowCellValue(curRow, "sequence_id").ToString());
                                    myCommand.Parameters.AddWithValue("@materiel_id", dgvDetails.GetRowCellValue(curRow, "materiel_id").ToString());
                                    myCommand.Parameters.AddWithValue("@products_type", dgvDetails.GetRowCellValue(curRow, "products_type").ToString());
                                    myCommand.Parameters.AddWithValue("@size_range", dgvDetails.GetRowCellValue(curRow, "size_range").ToString());
                                    myCommand.Parameters.AddWithValue("@actual_size", dgvDetails.GetRowCellValue(curRow, "actual_size").ToString());
                                    myCommand.Parameters.AddWithValue("@draw_no", dgvDetails.GetRowCellValue(curRow, "draw_no").ToString());
                                    myCommand.Parameters.AddWithValue("@brand_no", dgvDetails.GetRowCellValue(curRow, "brand_no").ToString());
                                    myCommand.Parameters.AddWithValue("@customer_id", dgvDetails.GetRowCellValue(curRow, "customer_id").ToString());
                                    myCommand.Parameters.AddWithValue("@cust_name", dgvDetails.GetRowCellValue(curRow, "cust_name").ToString());
                                    myCommand.Parameters.AddWithValue("@develop_date", clsPub.Return_String_Date(dgvDetails.GetRowCellValue(curRow, "develop_date").ToString()));
                                    myCommand.Parameters.AddWithValue("@picture_name", dgvDetails.GetRowCellValue(curRow, "picture_name").ToString());
                                    myCommand.Parameters.AddWithValue("@markcontent", dgvDetails.GetRowCellValue(curRow, "markcontent").ToString());
                                    myCommand.Parameters.AddWithValue("@wrok_by", dgvDetails.GetRowCellValue(curRow, "wrok_by").ToString());
                                    myCommand.Parameters.AddWithValue("@remark", dgvDetails.GetRowCellValue(curRow, "remark").ToString());                                    
                                    myCommand.ExecuteNonQuery();
                                }
                            }
                        }
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
            Set_Grid_Status(false);
            mState = "";
            dtTempDel.Clear();
            if (save_flag)
            {
                //Find_doc(txtid.Text);
                DBUtility.myMessageBox(myMsg.msgSave_ok, myMsg.msgTitle);
            }
            else
            {
                MessageBox.Show(myMsg.msgSave_error, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string ls_sql;
            if (txtid1.Text == "")
                ls_sql = @"Select id,name,english_name From dbo.cd_pattern with(nolock) where state='0'";
            else
            {
                if (txtid1.Text.Length == 7)
                {
                    ls_sql = string.Format(@"Select id,name,english_name From dbo.cd_pattern with(nolock) where id ='{0}' and state='0'", txtid1.Text);
                }
                else
                {
                    ls_sql = string.Format(@"Select id,name,english_name From dbo.cd_pattern with(nolock) where id like '%{0}%' and state='0'", txtid1.Text);
                }
            }
            DataTable dtFind = clsApp.GetDataTable(ls_sql);
            dgvFind.DataSource = dtFind;
        }

        private void Find_Doc(string id)
        {
            string ls_sql = string.Format(@"Select * From dbo.cd_pattern with(nolock) where id='{0}' and state='0'", id);
            dtMostly = clsApp.GetDataTable(ls_sql);
            bds_h.DataSource = dtMostly;
            ls_sql = string.Format(@"Select b.* From dbo.cd_pattern a with(nolock),dbo.cd_pattern_details b with(nolock) Where a.id=b.id and a.id='{0}' and a.state='0'", id);
            dtDetails = clsApp.GetDataTable(ls_sql);
            bds_d.DataSource = dtDetails;
            gridControl1.DataSource = bds_d;
        }

        private void dgvFind_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFind.Rows.Count == 0)
            {
                return;
            }
            int cur_row =dgvFind.CurrentCell.RowIndex;
            string ls_id = dgvFind.Rows[cur_row].Cells["id1"].Value.ToString();
            Find_Doc(ls_id);
            string ls_artwork = String.Format("{0}\\{1}", mArtWorkPath, dgvDetails.GetRowCellDisplayText(dgvDetails.FocusedRowHandle, "picture_name"));
            if (!string.IsNullOrEmpty(ls_artwork))
            {
                if (File.Exists(ls_artwork))
                    pic_artwork.Image = Image.FromFile(ls_artwork);
                else
                    pic_artwork.Image = null;
            }
            else
                pic_artwork.Image = null;
        }
    }
}
