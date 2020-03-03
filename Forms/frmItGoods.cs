using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cfvn.CLS;
using System.Data.SqlClient;
using System.IO;
using WeifenLuo.WinFormsUI.Docking;

namespace cfvn.Forms
{
    public partial class frmItGoods : DockContent
    {
        DataTable dtDetail = new DataTable();
        public SqlDataAdapter SDA;
        public string mState = "";
        private const string mTitle = "Operation Information";
        SqlConnection conn;
        private clsPublicOfVN clsApp = new clsPublicOfVN();
        clsAppPublic clsPub = new clsAppPublic();
        clsToolBar objToolbar;        

        public frmItGoods()
        {
            InitializeComponent();
            
            //翻譯 
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();

            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.Set_Button_Image(toolStrip1);
        }

        private void frmItGoods_Load(object sender, EventArgs e)
        {
            //Load_Date();
            dgvDetails.AutoGenerateColumns = false;
            const string sql = @"SELECT * From it_goods with(nolock) Where 1=0 and state<>'2'";
            conn = new SqlConnection(DBUtility.ConnectionString);
            SDA = new SqlDataAdapter(sql, conn);
            SDA.Fill(dtDetail);
            bds1.DataSource = dtDetail;
            dgvDetails.DataSource = bds1;

            Set_DataBindings();
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);
            //Coding type
            clsGoodsCode.Set_DropBox_For_CodingType(luetype, DBUtility._language);           
            //Unit
            clsGoodsCode.Set_DropBox_For_Unit(lueunit_code);
            //Weight Unit
            clsGoodsCode.Set_DropBox_For_WeightUnit(luesec_unit);
            //中类
            clsGoodsCode.Set_DropBox_For_BassClass(luebase_class, DBUtility._language);
            //大类
            clsGoodsCode.Set_DropBox_For_BassClass(luebig_class, DBUtility._language);
            //Material
            clsGoodsCode.Set_DropBox_For_Material(luedatum, DBUtility._language);
            //Color
            clsGoodsCode.Set_DropBox_For_Color(luecolor, DBUtility._language);
            //Size
            clsGoodsCode.Set_DropBox_For_Size(luesize_id, DBUtility._language);
            //Customer
            clsGoodsCode.Set_DropBox_For_Customer(luecustomer_id, DBUtility._language);
            //Modality
            clsGoodsCode.Set_DropBox_For_Modality(luemodality, DBUtility._language);
            //Attribute
            clsGoodsCode.Set_DropBox_For_Attribute(lueattribute, DBUtility._language);
            
            if (dtDetail.Rows.Count > 0)
            {
                Check_Artwork(txtblueprint_id.Text);
            }
        }

        private void frmItGoods_FormClosed(object sender, FormClosedEventArgs e)
        {          
            conn = null;
            SDA.Dispose();
            objToolbar = null;
            dtDetail.Dispose();
        }

        //private void Load_Date()
        //{
        //    dtDetail.Clear();
        //    const string sql = @"SELECT * From it_goods with(nolock) Where 1=0 and state<>'2'";
        //    conn = new SqlConnection(DBUtility.ConnectionString);
        //    SDA = new SqlDataAdapter(sql, conn);
        //    SDA.Fill(dtDetail);
        //    bds1.DataSource = dtDetail;
        //    dgvDetails.DataSource = bds1;
            
        //}


        private void Set_DataBindings()
        {
            luetype.DataBindings.Add("EditValue", bds1, "type");
            bteId.DataBindings.Add("Text", bds1, "id");
            // chkis_temp.DataBindings.Add("CheckState", bds1, "is_temp");
             //Binding binding = new Binding("CheckState", bds1, "is_temp");
             //binding.FormattingEnabled = true;
             //binding.NullValue = CheckState.Indeterminate;
             //chkis_temp.DataBindings.Add(binding);

            txtname.DataBindings.Add("Text", bds1, "name");
            txtenglish_name.DataBindings.Add("Text", bds1, "english_name");
            txtspec.DataBindings.Add("Text", bds1, "spec");
            txtenglish_spec.DataBindings.Add("Text", bds1, "english_spec");
            txtdescription_2.DataBindings.Add("Text", bds1, "description_2");
            luestate.DataBindings.Add("EditValue", bds1, "state");
            txtlogogram.DataBindings.Add("Text", bds1, "logogram");
            txtenglish_logogram.DataBindings.Add("Text", bds1, "english_logogram");
            txtbarcode.DataBindings.Add("Text", bds1, "barcode");
            lueunit_code.DataBindings.Add("EditValue", bds1, "unit_code");
            luesec_unit.DataBindings.Add("EditValue", bds1, "sec_unit");
            luemodality.DataBindings.Add("EditValue", bds1, "modality");
            luebig_class.DataBindings.Add("EditValue", bds1, "big_class");
            luebase_class.DataBindings.Add("EditValue", bds1, "base_class");

            //chkkeyno.DataBindings.Add("Checked", bds1, "keyno");
            //chkis_qc.DataBindings.Add("Checked", bds1, "is_qc");
            luedatum.DataBindings.Add("EditValue", bds1, "datum");
            luecolor.DataBindings.Add("EditValue", bds1, "color");
            luesize_id.DataBindings.Add("EditValue", bds1, "size_id");
            luecustomer_id.DataBindings.Add("EditValue", bds1, "customer_id");
            txtdo_color.DataBindings.Add("Text", bds1, "do_color");
            //chkanalysis_codes_6.DataBindings.Add("Checked", bds1, "analysis_codes_6");
            txtscrap_goods_id.DataBindings.Add("Text", bds1, "scrap_goods_id");
            txtscrap_sec_qty.DataBindings.Add("Text", bds1, "scrap_sec_qty");
            lueattribute.DataBindings.Add("EditValue", bds1, "attribute");
            txtblueprint_id.DataBindings.Add("Text", bds1, "blueprint_id");
            cmbgoods_sort.DataBindings.Add("Text", bds1, "goods_sort");

            txtcreate_by.DataBindings.Add("Text", bds1, "create_by");
            txtcreate_date.DataBindings.Add("Text", bds1, "create_date");
            txtupdate_by.DataBindings.Add("Text", bds1, "update_by");
            txtupdate_date.DataBindings.Add("Text", bds1, "update_date");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }

        private void SetButtonSatus(bool _flag)
        {
            btnNew.Enabled = _flag;
            btnEdit.Enabled = _flag;
            btnDelete.Enabled = _flag;
            BTNPRINT.Enabled = _flag;
            BTNIMPORT.Enabled = _flag;
            BTNNEWCOPY.Enabled = _flag;
            
            btnSave.Enabled = !_flag;
            btnUndo.Enabled = !_flag;

            if (objToolbar != null)
            {
                objToolbar.SetToolBar();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void AddNew()
        {
            bds1.AddNew();
            mState = "NEW";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(tabPage1.Controls, true);
            bteId.Properties.ReadOnly = false;
            luestate.EditValue = "0";
            luetype.EditValue = "0001";
            luemodality.EditValue = "0";//管制類型自制
            lueunit_code.EditValue = "PCS";
            luesec_unit.EditValue = "KG";
            chkis_qc.Checked = true;
            txtcreate_by.Text = DBUtility._user_id;
            txtcreate_date.Text = DateTime.Now.Date.ToString();
        }

        private void Edit()
        {
            if (bteId.Text == "")
            {
                return;
            }
            mState = "Edit";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(tabPage1.Controls, true);
            txtupdate_by.Text = DBUtility._user_id;
            txtupdate_date.Text = DateTime.Now.Date.ToString();
            luetype.Properties.ReadOnly = true;
            luetype.BackColor = Color.White;
            bteId.Properties.ReadOnly = true;
            bteId.BackColor = Color.White;
        }

        private void Delete()
        {
            if(bds1.Count==0)            
            {
                return;
            }
            //string strId = dgvDetails.Rows[dgvDetails.CurrentCell.RowIndex].Cells["id"].Value.ToString();
            //string strSql = string.Format(@"Select '1' FROM formula_mostly where id='{0}'", strId);
            //if (clsApp.ExecuteSqlReturnObject(strSql) != "")
            //{
            //    MessageBox.Show("注意：当前公司代码已经被物流价格对照表所引用！不可以删除！", "提示信息");
            //    return;
            //}

            if (MessageBox.Show("Verify that you want to delete the current recor？", mTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    //modify Current row state to Cancel
                    luestate.EditValue = "2";
                    txtupdate_by.Text = DBUtility._user_id;
                    txtupdate_date.Text = clsPub.GetCurrentDatetime();
                    bds1.EndEdit();
                   
                    //数据库中进行删除
                    SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                    SDA.UpdateCommand = SCB.GetUpdateCommand();
                    SDA.Update(dtDetail);
                    //MessageBox.Show("Successful deletion！", mTitle);
                    DBUtility.myMessageBox("Successful deletion！", mTitle);
                    SCB = null;
                    //bds1.RemoveAt()
                    bds1.RemoveCurrent();
                   // Load_Date();
                    //dgvDetails.Rows.RemoveAt(dgvDetails.CurrentCell.RowIndex);//remove Current Row 
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

        private void Save()
        {
            if (bds1.Count == 0)
            {
                return;
            }
            //bds1.EndEdit();
            const string ls_msg_empty = "Data should not be empty!";
            if (luetype.Text == "")
            {                
                MessageBox.Show(ls_msg_empty, mTitle);
                luetype.Focus();
                return;
            }
            if (bteId.Text == "")
            {
                MessageBox.Show(ls_msg_empty, mTitle);
                bteId.Focus();
                return;
            }
            if (txtname.Text == "")
            {
                MessageBox.Show(ls_msg_empty, mTitle);
                txtname.Focus();
                return;
            }
            if (lueunit_code.Text == "")
            {
                MessageBox.Show(ls_msg_empty, mTitle);
                lueunit_code.Focus();
                return;
            }
            if (luesec_unit.Text == "")
            {
                MessageBox.Show(ls_msg_empty, mTitle);
                luesec_unit.Focus();
                return;
            }
            if (luebase_class.Text == "")
            {
                MessageBox.Show(ls_msg_empty, mTitle);
                luebase_class.Focus();
                return;
            }
            if (luecolor.Text == "")
            {
                MessageBox.Show(ls_msg_empty, mTitle);
                luecolor.Focus();
                return;
            }
            if (luesize_id.Text == "")
            {
                MessageBox.Show(ls_msg_empty, mTitle);
                luesize_id.Focus();
                return;
            }
            if (luedatum.Text == "")
            {
                MessageBox.Show(ls_msg_empty, mTitle);
                luedatum.Focus();
                return;
            }
            if (txtblueprint_id.Text == "")
            {
                MessageBox.Show(ls_msg_empty, mTitle);
                txtblueprint_id.Focus();
                return;
            }

            int cur_row = dgvDetails.CurrentCell.RowIndex;
            if (chkis_temp.Checked)                          
                dgvDetails.Rows[cur_row].Cells["is_temp"].Value = true;
            else            
                dgvDetails.Rows[cur_row].Cells["is_temp"].Value = false;
            if (chkkeyno.Checked)            
                dgvDetails.Rows[cur_row].Cells["keyno"].Value = true;
            else            
                dgvDetails.Rows[cur_row].Cells["keyno"].Value = false;
            if (chkis_qc.Checked)            
                dgvDetails.Rows[cur_row].Cells["is_qc"].Value = true;
            else            
                dgvDetails.Rows[cur_row].Cells["is_qc"].Value = false;
            if (chkanalysis_codes_6.Checked)            
                dgvDetails.Rows[cur_row].Cells["analysis_codes_6"].Value = true;
            else            
                dgvDetails.Rows[cur_row].Cells["analysis_codes_6"].Value = false;
            
            try
            {
                bds1.EndEdit();
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.InsertCommand = SCB.GetInsertCommand();
                SDA.UpdateCommand = SCB.GetUpdateCommand();

                SDA.Update(dtDetail);
                //MessageBox.Show("Save successful！",mTitle);
                DBUtility.myMessageBox("Save successful！", mTitle);
                SCB = null;

                SetButtonSatus(true);
                SetObjValue.SetEditBackColor(tabPage1.Controls, false);
                mState = "";
                bteId.Properties.ReadOnly = true;
                luetype.Properties.ReadOnly = false;                
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

        private void Cancel()
        {
            dtDetail.RejectChanges();
            bds1.CancelEdit();
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(tabPage1.Controls, false);
            mState = "";
            bteId.Properties.ReadOnly = true ;
            luetype.Properties.ReadOnly = false;
            //luetype.BackColor = Color.White;
            if (bteId.Text == "")
            {
                pic_artwork.Image = null;
            }
            //Load_Date();
        }

        private void bteId_Leave(object sender, EventArgs e)
        {
            if (bteId.Text != "" && mState !="")
            {
                Set_Item();
            }
        }

        private void Set_Item()
        {
            if (luetype.Text == "")
            {
                MessageBox.Show("Coding type should not be empty！", mTitle);
                luetype.Focus();
                return;
            }
            
            if (bteId.Text != "" && bteId.Text.Length > 10)
            {
                string ls_goods_id = bteId.Text;
                string ls_artwork = "";
                //产品规则
                if (luetype.EditValue.ToString() == "0001")
                {
                    if (bteId.Text.Length < 18)
                    {
                        MessageBox.Show("Gooods id insufficient length!", mTitle);
                        bteId.Focus();
                        return;
                    }

                    string ls_sql = string.Format(@"select '1' from it_goods with(nolock) where id='0' and type='0001'",bteId.Text);
                    if (clsApp.ExecuteSqlReturnObject(ls_sql) != "")
                    {
                        MessageBox.Show("This goods already exists！", mTitle);
                        bteId.Text = "";
                        bteId.Focus();
                        return;
                    }
                    //中类
                    luebase_class.EditValue = ls_goods_id.Substring(2, 2);
                    if (luebase_class.Text != "")
                    {
                        //不为空,说明已存在此中类信息，再由中类带出大类
                        luebig_class.EditValue = luebase_class.GetColumnValue("parent_id");
                    }
                    else
                    {
                        MessageBox.Show("This base class id does not exist！", mTitle);                       
                    }
                    //圖樣
                    ls_artwork=ls_goods_id.Substring(4, 7);
                    Check_Artwork(ls_artwork);                   
                    //尺碼
                    luesize_id.EditValue = ls_goods_id.Substring(11, 3);
                    if (luesize_id.Text == "")
                    {
                        MessageBox.Show("This Size id does not exist！", mTitle);                        
                    }
                    //顏色
                    luecolor.EditValue = ls_goods_id.Substring(14, 4);
                    if (luecolor.Text == "")
                    {
                        txtdo_color.Text = "";
                        MessageBox.Show("This Color id does not exist！", mTitle);
                    }
                    else
                    {
                        txtdo_color.Text = clsApp.ExecuteSqlReturnObject(string.Format("Select clr_make from bs_color with(nolock) where clr_code='{0}'",luecolor.EditValue));
                    }
                    //材質
                    luedatum.EditValue = ls_goods_id.Substring(0, 2);
                    if (luedatum.Text == "")
                    {
                        MessageBox.Show("This material id does not exist！", mTitle);                        
                    }
                    //中文描述
                    txtname.Text = clsGoodsCode.Get_Goods_Desc(luedatum.EditValue.ToString(),luebase_class.EditValue.ToString(),txtblueprint_id.Text,luesize_id.EditValue.ToString(),luecolor.EditValue.ToString(),"1");
                    //英文描述
                    txtenglish_name.Text = clsGoodsCode.Get_Goods_Desc(luedatum.EditValue.ToString(), luebase_class.EditValue.ToString(), txtblueprint_id.Text, luesize_id.EditValue.ToString(), luecolor.EditValue.ToString(), "2");
                }

                //F0规则
                if (luetype.EditValue.ToString() == "0002")
                {
                    if (bteId.Text.Length < 14)
                    {
                        MessageBox.Show("Gooods id insufficient length!", mTitle);
                        bteId.Focus();
                        return;
                    }
                    
                    string ls_sql = string.Format(@"select '1' from it_goods with(nolock) where id='0' and type='0002'", bteId.Text);
                    if (clsApp.ExecuteSqlReturnObject(ls_sql) != "")
                    {
                        MessageBox.Show("This goods already exists！", mTitle);
                        bteId.Text = "";
                        bteId.Focus();
                    }
                    luemodality.EditValue = "3";
                    //圖樣
                    ls_artwork = ls_goods_id.Substring(3, 7);
                    Check_Artwork(ls_artwork);
                }
                
            }
        }

        private void Check_Artwork(string artwork)
        {
            if (clsGoodsCode.Check_IsExists_ArtWork(artwork))
            {
                txtblueprint_id.Text = artwork;
                string ls_artowrk_path = "";
                ls_artowrk_path = clsGoodsCode.Get_Picture_Name(artwork);
                if (!string.IsNullOrEmpty(ls_artowrk_path))
                {
                    if (File.Exists(ls_artowrk_path))
                        pic_artwork.Image = Image.FromFile(ls_artowrk_path);
                    else
                        pic_artwork.Image = null;
                }
                else
                {
                    pic_artwork.Image = null;
                }
            }
            else
            {
                MessageBox.Show("This ArtWork does not exist！", mTitle);
                txtblueprint_id.Text = "";
                pic_artwork.Image = null;
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            string ls_sql ;
            if (goods_id.Text == "" && goods_name.Text == "" && goods_name_eng.Text == "")
            {
                ls_sql = @"Select TOP 1000 * FROM dbo.it_goods with(nolock) Where state='0'";
            }
            else
            {
                ls_sql = @"Select * FROM dbo.it_goods with(nolock) ";
                if (goods_id.Text != "")
                {
                    if(!ls_sql.Contains("Where"))
                        ls_sql += string.Format(" Where id like '%{0}%'", goods_id.Text);
                    else
                        ls_sql += string.Format(" and id like '%{0}%'", goods_id.Text);
                }
                if (goods_name.Text != "")
                {
                    if (ls_sql.Contains("Where"))
                        ls_sql += string.Format(" and name like '%{0}%'", goods_name.Text);
                    else
                        ls_sql += string.Format(" Where name like '%{0}%'", goods_name.Text);
                }
                if (goods_name.Text != "")
                {
                    if (ls_sql.Contains("Where"))
                        ls_sql += string.Format(" and english_name like '%{0}%'", goods_name_eng.Text);
                    else
                        ls_sql += string.Format(" Where english_name like '%{0}%'", goods_name_eng.Text);
                }
                ls_sql += " and state='0'";
            }
            dtDetail=clsApp.GetDataTable(ls_sql);
            bds1.DataSource = dtDetail;
            dgvDetails.DataSource = bds1;
            if (dtDetail.Rows.Count == 0)
            {
                DBUtility.myMessageBox("No data matching the search condition！", mTitle);
            }
            tabControl1.SelectedIndex = 0;
            
        }

        private void dgvDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetails.Rows.Count == 0)
            {
                return;
            }
            int cur_row = dgvDetails.CurrentCell.RowIndex;
            if (dgvDetails.Rows[cur_row].Cells["is_temp"].Value.ToString() == "True")
            {
                chkis_temp.Checked = true;
            }
            else
            {
                chkis_temp.Checked = false;
            }
            if (dgvDetails.Rows[cur_row].Cells["keyno"].Value.ToString() == "True")
            {
                chkkeyno.Checked = true;
            }
            else
            {
                chkkeyno.Checked = false;
            }
            if (dgvDetails.Rows[cur_row].Cells["is_qc"].Value.ToString() == "True")
            {
                chkis_qc.Checked = true;
            }
            else
            {
                chkis_qc.Checked = false;
            }
            if (dgvDetails.Rows[cur_row].Cells["analysis_codes_6"].Value.ToString() == "True")
            {
                chkanalysis_codes_6.Checked = true;
            }
            else
            {
                chkanalysis_codes_6.Checked = false;
            }
            if (txtblueprint_id.Text != "")
            {
                Check_Artwork(txtblueprint_id.Text);
            }
        }

        private void chkis_temp_MouseUp(object sender, MouseEventArgs e)
        {
            Set_Checkbox_State(chkis_temp, "is_temp");
        }
        private void chkkeyno_MouseUp(object sender, MouseEventArgs e)
        {
            Set_Checkbox_State(chkkeyno, "keyno");
        }
        private void chkis_qc_MouseUp(object sender, MouseEventArgs e)
        {
            Set_Checkbox_State(chkis_qc, "is_qc");
        }
        private void chkanalysis_codes_6_MouseUp(object sender, MouseEventArgs e)
        {
            Set_Checkbox_State(chkanalysis_codes_6, "analysis_codes_6");
        }

        private void Set_Checkbox_State(DevExpress.XtraEditors.CheckEdit objchk, string objchk_name)
        {
            bool lb_result = false;
            if (objchk.Checked)
            {
                lb_result = true;
            }
            else
            {
                lb_result = false;
            }
            dgvDetails.Rows[dgvDetails.CurrentCell.RowIndex].Cells[objchk_name].Value = lb_result;
        }


      
    }
}
