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
    public partial class frmBsCustomer : DockContent

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
        DataTable dtCountry = new DataTable();     
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        public clsAppPublic clsPub = new clsAppPublic();
        private clsToolBar objToolbar;
        
        
        public frmBsCustomer()
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

        private void frmBsCustomer_Load(object sender, EventArgs e)
        {
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);
            //Initialize customer group
            clsBsCustomer.SetCustomerGroup(luecustomer_group);
            //Initialize customer type
            clsBsCustomer.SetCustomerType(luetype);            
            //Initialize Customer area
            clsBsCustomer.SetCustomerArea(luearea);
            //Initialize port
            clsBsCustomer.SetPort(luep_code);
            //Initialize country
            clsBsCustomer.SetCountry(luec_code);
            //Initialize transport_mode
            clsBsCustomer.SetTransportMode(luetransport_mode);
            //Initialize sales1
            clsBsCustomer.SetSales(lueseller_id_1);
            //Initialize sales2
            clsBsCustomer.SetSales(lueseller_id_2);
            //Initialize sales3
            clsBsCustomer.SetSales(lueseller_id_3);           
            //Initialize SetMoney
            clsBsCustomer.SetMoney(luemoney_id);
            //Initialize Cancel state
            clsBsCustomer.SetCancelState(luecancel_reason_type_id);
            //Initialize customer state
            clsBsCustomer.SetCustomerState(lueaction_state);

            

           
            ////倉庫位置
            //dtCountry = clsApp.GetDataTable(sql_country);
            //DataRow row1 = dtCountry.NewRow();//插一空行
            //dtCountry.Rows.Add(row1);
            //dtCountry.DefaultView.Sort = "id ASC";//排序
            //dtCountry = dtCountry.DefaultView.ToTable();//排序後重新賦值
           
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
            luecustomer_group.DataBindings.Add("EditValue", bds1, "customer_group");
            luetype.DataBindings.Add("EditValue", bds1, "type");            
            luestate.DataBindings.Add("EditValue", bds1, "state");
            txtparent_id.DataBindings.Add("Text", bds1, "parent_id");
            txtlogogram.DataBindings.Add("Text", bds1, "logogram");
            txtenglish_logogram.DataBindings.Add("Text", bds1, "english_logogram");
            txtsort_id.DataBindings.Add("Text", bds1, "sort_id");
            luearea.DataBindings.Add("EditValue", bds1, "area");
            txtpostalcode.DataBindings.Add("Text", bds1, "postalcode");
            luec_code.DataBindings.Add("EditValue", bds1, "c_code");
            luep_code.DataBindings.Add("EditValue", bds1, "p_code");
            luetransport_mode.DataBindings.Add("EditValue", bds1, "transport_mode");
            txthomepage.DataBindings.Add("Text", bds1, "homepage");

            txtphone.DataBindings.Add("Text", bds1, "phone");
            txta_linkman.DataBindings.Add("Text", bds1, "a_linkman");
            txta_phone.DataBindings.Add("Text", bds1, "a_phone");
            txtfax.DataBindings.Add("Text", bds1, "fax");
            txtemail.DataBindings.Add("Text", bds1, "email");
            lueseller_id_1.DataBindings.Add("EditValue", bds1, "seller_id_1");
            lueseller_id_2.DataBindings.Add("EditValue", bds1, "seller_id_2");
            lueseller_id_3.DataBindings.Add("EditValue", bds1, "seller_id_3");
            luemoney_id.DataBindings.Add("EditValue", bds1, "money_id");

            luecancel_reason_type_id.DataBindings.Add("EditValue", bds1, "cancel_reason_type_id");
            txtcancel_reason_type_name.DataBindings.Add("Text", bds1, "cancel_reason_type_name");
            txtcharacter.DataBindings.Add("Text", bds1, "character");
            lueaction_state.DataBindings.Add("EditValue", bds1, "action_state");
            txtcheckup_hint.DataBindings.Add("Text", bds1, "checkup_hint");
            txtRemark.DataBindings.Add("Text", bds1, "remark");

            txtshipment_linkman.DataBindings.Add("Text", bds1, "shipment_linkman");
            txtshipment_phone.DataBindings.Add("Text", bds1, "shipment_phone");
            txtshipment_fax.DataBindings.Add("Text", bds1, "shipment_fax");
            txtshipment_comments.DataBindings.Add("Text", bds1, "shipment_comments");
            txtshipment_email.DataBindings.Add("Text", bds1, "shipment_email");
            txtshipment_s_address.DataBindings.Add("Text", bds1, "shipment_s_address");
            txtshipment_e_address.DataBindings.Add("Text", bds1, "shipment_e_address");

            txtcreate_by.DataBindings.Add("Text", bds1, "create_by");
            txtcreate_date.DataBindings.Add("Text", bds1, "create_date");
            txtupdate_by.DataBindings.Add("Text", bds1, "update_by");
            txtupdate_date.DataBindings.Add("Text", bds1, "Update_date");
        }

        private void frmBsCustomer_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtCountry.Dispose();
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
            tabControl1.SelectedIndex = 1;
            Load_Date();
        }

        private void BTNPRINT_Click(object sender, EventArgs e)
        {
            Print();
        }

        private void BTNCONFIRM_Click(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount == 0)
            {
                return;
            }
            
            try
            {
                if (luestate.EditValue.ToString() == "0")
                {
                    luestate.EditValue = "1";//批準
                }
                else
                {
                    luestate.EditValue = "0";//反批準
                }
                txtupdate_by.Text = DBUtility._user_id;
                txtupdate_date.Text = clsPub.GetCurrentDatetime();
                bds1.EndEdit();
                //dgvDetails.Rows.RemoveAt(dgvDetails.CurrentCell.RowIndex);
                //数据库中进行删除
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.UpdateCommand = SCB.GetUpdateCommand();
                //SDA.DeleteCommand = SCB.GetDeleteCommand();
                SDA.Update(dtDetail);
                DBUtility.myMessageBox(myMsg.msgApprove, myMsg.msgTitle);
                SCB = null;
                //批準,反批準的顯示
                clsCommon.ConfirmSatus(BTNCONFIRM, luestate);
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

        // ===============以下爲自定義方法=======================
        private void SetButtonSatus(bool _flag)
        {
            BTNNEW.Enabled = _flag;
            BTNEDIT.Enabled = _flag;
            BTNPRINT.Enabled = _flag;
            BTNDELETE.Enabled = _flag;
            BTNFIND.Enabled = _flag;
            BTNCONFIRM.Enabled = _flag;
            BTNACTION.Enabled = _flag;

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
            string strSql = String.Format("Select '1' FROM bs_customer WHERE id='{0}'", txtid.Text.Trim());
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
                @"SELECT * FROM dbo.bs_customer Where state='0' order by id ", temp_id);
                DataTable dt = clsApp.GetDataTable(strsql);
                dgvDetails.DataSource = dt;
                if (dt.Rows.Count == 0)
                {
                    if (mLanguage == "2")
                    {
                        msgCustom = "Customer ID does not exist.";
                    }
                    else
                    {
                        msgCustom = "客戶編號資料不存在！";
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
            tabControl1.SelectedIndex = 0;
            bds1.AddNew();
            mState = "NEW";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            luecustomer_group.EditValue = "1";
            lueaction_state.EditValue = "0";
            luetype.EditValue = "L";
            luestate.EditValue = "0";
            txtcreate_by.Text = DBUtility._user_id;
            txtcreate_date.Text = clsPub.GetCurrentDatetime();
        }

        private void Edit()  //編號
        {
            if (txtid.Text == "")
            {
                return;
            }
            if (!clsCommon.CheckCurrentOperation(luestate.EditValue.ToString()))
            {
                return;
            }

            mState = "Edit";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            txtupdate_by.Text = DBUtility._user_id;
            txtupdate_date.Text = clsPub.GetCurrentDatetime();
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
            string sql = "";
            if (txtcust1.Text == "" && txtcust2.Text=="" && txtcust_name.Text=="")
            {
                sql = @"SELECT * From bs_customer with(nolock)";
            }
            else
            {
                sql = @"SELECT * From bs_customer with(nolock) Where 1>0 ";
                if (txtcust1.Text != "")
                {
                    sql+=string.Format(" and id>='{0}'",txtcust1.Text);
                }
                if (txtcust2.Text != "")
                {
                    sql += string.Format("and id<='{0}'", txtcust2.Text);
                }
                if (txtcust_name.Text != "")
                {
                    sql += string.Format("and name like '%{0}%'", txtcust_name.Text);
                }

                sql += "and state <> '2'";
            }
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
                if (dgvDetails.Rows[i].Cells["id"].Value.ToString() == "" || dgvDetails.Rows[i].Cells["name"].Value.ToString() == "" || dgvDetails.Rows[i].Cells["customer_group"].Value.ToString() == "")
                {
                    flag_datavalid = true;
                    dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells["id"];//選中當前空白的行                    
                    break;
                }
            }
            if (flag_datavalid)
            {
                MessageBox.Show("Customer id,name or cust. group id cannot be empty !", myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            if (!clsCommon.CheckCurrentOperation(luestate.EditValue.ToString()))
            {
                return;
            }
            
            if (MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    luestate.EditValue = "2";
                    //dgvDetails.Rows.RemoveAt(dgvDetails.CurrentCell.RowIndex);
                    txtupdate_by.Text = DBUtility._user_id;
                    txtupdate_date.Text = clsPub.GetCurrentDatetime();
                    bds1.EndEdit();
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Load_Date();
            tabControl1.SelectedIndex=0;
        }

        private void txtcust1_Leave(object sender, EventArgs e)
        {
            txtcust2.Text = txtcust1.Text;
        }

        private void BTNACTION_Click(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount == 0)
            {
                return;
            }
            
            try
            {
                if (lueaction_state.EditValue.ToString() != "3")
                {
                    lueaction_state.EditValue = "3";
                }
                else
                {
                    lueaction_state.EditValue = "0";
                }
                txtupdate_by.Text = DBUtility._user_id;
                txtupdate_date.Text = clsPub.GetCurrentDatetime();
                bds1.EndEdit();
                //dgvDetails.Rows.RemoveAt(dgvDetails.CurrentCell.RowIndex);
                //数据库中进行删除
                SqlCommandBuilder SCB = new SqlCommandBuilder(SDA);
                SDA.UpdateCommand = SCB.GetUpdateCommand();
                //SDA.DeleteCommand = SCB.GetDeleteCommand();
                SDA.Update(dtDetail);
                DBUtility.myMessageBox(myMsg.msgSetup, myMsg.msgTitle);
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

        private void dgvDetails_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount > 0)
            {
                clsCommon.ConfirmSatus(BTNCONFIRM, luestate);
                int cur_row = dgvDetails.CurrentCell.RowIndex;
                if (dgvDetails.Rows[cur_row].Cells["is_print_logo"].Value.ToString() == "True")
                {
                    chkis_print_logo.Checked = true;
                }
                else
                {
                    chkis_print_logo.Checked = false;
                }
            }
        }
                  
     
    }
}
