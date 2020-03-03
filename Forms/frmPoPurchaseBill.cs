using cfvn.CLS;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using DevExpress.XtraEditors;
using cfvn.MDL;
using System.Collections.Generic;
using cfvn.Reports;
using DevExpress.XtraReports.UI;



namespace cfvn.Forms
{
    public partial class frmPoPurchaseBill : DockContent
    {
        public string m_id = "";    //臨時的主鍵值
        public string m_ver = "0";
        public string m_state = ""; //新增或編號的狀態        
        public static string str_language = "0";        
        public bool save_flag;
        private bool is_open_flag ;       
        public static string m_got_focus_gridview = "dgvDetails";
        public BindingSource bds_h = new BindingSource();
        public static BindingSource bds_d = new BindingSource();
        public static BindingSource bds_fare = new BindingSource();

        DataTable dtMostly = new DataTable();
        DataTable dtDetail = new DataTable();
        DataTable dtFare = new DataTable();
        DataTable dtMoneyRate = new DataTable();
        DataTable dtTempDel = new DataTable();
        public DataTable dtTempDel_Fare = new DataTable();
        public DataTable dtUnitAll = new DataTable();
        public DataTable dtSec_Unit = new DataTable();
        public DataTable dtFareid = new DataTable();

        readonly MsgInfo myMsg = new MsgInfo();//實例化Messagegox用到的提示
        string strFileImag = "";
        readonly string strImgPath = AppDomain.CurrentDomain.BaseDirectory;
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        public clsAppPublic objApp = new clsAppPublic();

        clsToolBar objToolbar;

        public frmPoPurchaseBill()
        {
            InitializeComponent();

            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();

            //權限
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.SetToolBar();
            objToolbar.Set_Button_Image(toolStrip1);

            //NextControl oNext = new NextControl(this, "2");
            //oNext.EnterToTab();
        }

        private void frmPoPurchaseBill_Load(object sender, EventArgs e)
        {
            //系統狀態
            clsGoodsCode.Set_DropBox_For_State(luestate, DBUtility._language);
            //Vendor
            DataTable dtVendor = clsCommon.GetVendor();
            luevendor_id.Properties.DataSource = dtVendor;
            luevendor_id.Properties.ValueMember = "id";
            luevendor_id.Properties.DisplayMember = "id";
            //Bill_Origin
            DataTable dtBbill_Origin = clsCommon.Get_Bill_Origin("PO02");
            lueorigin_id.Properties.DataSource = dtBbill_Origin;
            lueorigin_id.Properties.ValueMember = "id";
            lueorigin_id.Properties.DisplayMember = "name";
            //Bill type
            DataTable dtBbill_Type = clsCommon.Get_Bill_Type("PO02");
            luetype.Properties.DataSource = dtBbill_Type;
            luetype.Properties.ValueMember = "id";
            luetype.Properties.DisplayMember = "name";
            //Money           
            DataTable dtMoney = clsCommon.Get_Money();
            luem_id.Properties.DataSource = dtMoney;
            luem_id.Properties.ValueMember = "id";
            luem_id.Properties.DisplayMember = "name";

            //money rate
            dtMoneyRate = clsCommon.Get_Money_Rate();
            lueExchange_rate.Properties.DataSource = dtMoneyRate;
            lueExchange_rate.Properties.ValueMember = "id";
            lueExchange_rate.Properties.DisplayMember = "exchange_rate";

            //Customer
            clsCommon.Set_Customer(lueit_customer, DBUtility._language);
            //Vendor
            clsCommon.Set_Vendor(luevendor_id, DBUtility._language);

            //部門
            clsCommon.Set_Drop_Box_Value(luedepartment_id, DBUtility._language, "bs_department");
            //區域
            clsCommon.Set_Drop_Box_Value(luearea, DBUtility._language, "bs_zone");
            //稅種
            clsCommon.Set_Drop_Box_Value(luetax_ticket, DBUtility._language, "bs_tax_kind");
            //裝運方式
            clsCommon.Set_Drop_Box_Value(luesm_id, DBUtility._language, "bs_shipping_mode");
            //附款方式
            clsCommon.Set_Drop_Box_Value(luep_id, DBUtility._language, "bs_payment");
            //價格條件
            clsCommon.Set_Drop_Box_Value(luepc_id, DBUtility._language, "bs_payment_condition");
            //銷售員
            clsCommon.Set_Drop_Box_Value(luesales_person, DBUtility._language, "bs_sales");

            //單位
            dtUnitAll = clsCommon.GetUnitAll();
            col_unit_code.DataSource = dtUnitAll;
            col_unit_code.ValueMember = "id";
            col_unit_code.DisplayMember = "id";
            //單價單位
            col_p_unit.DataSource = dtUnitAll;
            col_p_unit.ValueMember = "id";
            col_p_unit.DisplayMember = "id";

            //重量單位
            dtSec_Unit = clsCommon.GetSecUnit();
            col_unit_code_sec.DataSource = dtSec_Unit;
            col_unit_code_sec.ValueMember = "id";
            col_unit_code_sec.DisplayMember = "id";


            //***附加費
            //附加費用編號
            DataTable dtFare = clsCommon.Get_Fare_id();
            col_fare_id.DataSource = dtFare;
            col_fare_id.ValueMember = "id";
            col_fare_id.DisplayMember = "id";
            //附加費數量單位
            col_fare_unit_code.DataSource = dtUnitAll;
            col_fare_unit_code.ValueMember = "id";
            col_fare_unit_code.DisplayMember = "id";

            //DataTable dtEmp = clsPoPurchase.Get_Employer();
            //btebuyer_id.Properties.DataSource = dtEmp;
            //btebuyer_id.Properties.ValueMember = "id";
            //btebuyer_id.Properties.DisplayMember = "id";

            //主表結構                  
            const string ls_mostly = @"SELECT A.*,B.name as vendor_name,C.name as customer_name
			FROM dbo.po_buy_manage A With(nolock) 
			INNER JOIN dbo.bs_vendor B ON A.vendor_id = B.id
            LEFT JOIN dbo.bs_customer C ON A.it_customer = C.id
			WHERE 1=0";
            dtMostly = clsApp.GetDataTable(ls_mostly);
            bds_h.DataSource = dtMostly;


            //生成明細結構            
            const string ls_details = @"SELECT * FROM dbo.po_buy_details WHERE 1=0";
            dtDetail = clsApp.GetDataTable(ls_details);
            bds_d.DataSource = dtDetail;
            gridControl1.DataSource = bds_d;

            //生成附加費結構            
            const string ls_fare_sum = @"SELECT *,fare_id as org_fare_id FROM dbo.po_other_fare WHERE 1=0";
            dtFare = clsApp.GetDataTable(ls_fare_sum);
            bds_fare.DataSource = dtFare;
            gridControl2.DataSource = bds_fare;

            //生成臨時項目刪除表結構
            dtTempDel = dtDetail.Clone();
            dtTempDel_Fare = dtFare.Clone();

            //主表數據綁定
            Set_DataBindings();
        }

        private void Set_DataBindings()
        {
            txtID.DataBindings.Add("Text", bds_h, "id");
            txtVer.DataBindings.Add("Text", bds_h, "ver");
            detOrder_date.DataBindings.Add("EditValue", bds_h, "order_date");
            luevendor_id.DataBindings.Add("EditValue", bds_h, "vendor_id");
            txtVendor_name.DataBindings.Add("Text", bds_h, "vendor_name");
            txtvendor_address.DataBindings.Add("Text", bds_h, "vendor_address");
            btebuyer_id.DataBindings.Add("Text", bds_h, "buyer_id");
            txtcd_buyer.DataBindings.Add("Text", bds_h, "cd_buyer");
            lueit_customer.DataBindings.Add("EditValue", bds_h, "it_customer");
            txtCustomer_name.DataBindings.Add("Text", bds_h, "customer_name");
            txts_address.DataBindings.Add("Text", bds_h, "s_address");
            luesm_id.DataBindings.Add("EditValue", bds_h, "sm_id");
            luep_id.DataBindings.Add("EditValue", bds_h, "p_id");
            txtcd_shipment.DataBindings.Add("Text", bds_h, "cd_shipment");
            luesales_person.DataBindings.Add("EditValue", bds_h, "sales_person");
            txtpacking.DataBindings.Add("Text", bds_h, "packing");
            memside_mark.DataBindings.Add("Text", bds_h, "side_mark");
            txtremark.DataBindings.Add("Text", bds_h, "remark");
            memship_mark.DataBindings.Add("Text", bds_h, "ship_mark");

            lueorigin_id.DataBindings.Add("EditValue", bds_h, "origin_id");
            luestate.DataBindings.Add("EditValue", bds_h, "state");
            txtlinkman.DataBindings.Add("Text", bds_h, "linkman");
            luetype.DataBindings.Add("EditValue", bds_h, "type");
            txtl_phone.DataBindings.Add("Text", bds_h, "l_phone");
            txtfax.DataBindings.Add("Text", bds_h, "fax");
            luem_id.DataBindings.Add("EditValue", bds_h, "m_id");
            lueExchange_rate.DataBindings.Add("EditValue", bds_h, "exchange_rate");
            luefinally_buyer.DataBindings.Add("EditValue", bds_h, "finally_buyer");
            luedepartment_id.DataBindings.Add("EditValue", bds_h, "department_id");
            luearea.DataBindings.Add("EditValue", bds_h, "area");
            luetax_ticket.DataBindings.Add("EditValue", bds_h, "tax_ticket");
            luepc_id.DataBindings.Add("EditValue", bds_h, "pc_id");
            txttax_sum.DataBindings.Add("Text", bds_h, "tax_sum");//稅款總額
            txtpg_sum.DataBindings.Add("Text", bds_h, "pg_sum");//貨款金額
            txtdisc_spare.DataBindings.Add("Text", bds_h, "disc_spare");//折扣後金額
            txttack_fare.DataBindings.Add("Text", bds_h, "tack_fare");//附加費用合計
            txttotal_sum.DataBindings.Add("Text", bds_h, "total_sum");//總金額
            txtm_rate.DataBindings.Add("Text", bds_h, "m_rate");//匯率           

            txtcreate_by.DataBindings.Add("Text", bds_h, "create_by");
            txtcreate_date.DataBindings.Add("Text", bds_h, "create_date");
            txtupdate_by.DataBindings.Add("Text", bds_h, "update_by");
            txtupdate_date.DataBindings.Add("Text", bds_h, "Update_date");
            txtsanction_by.DataBindings.Add("Text", bds_h, "sanction_by");
            txtsanction_date.DataBindings.Add("Text", bds_h, "sanction_date");
        }

        private void frmPoPurchaseBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtDetail.Dispose();
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

        private void BTNITEMADD_Click(object sender, EventArgs e)
        {
            AddNew_Item();          
        }

        private void BTNITEMDEL_Click(object sender, EventArgs e)
        {
            Del_Item();
        }

        private void BTNDELETE_Click(object sender, EventArgs e)
        {
            Delete();
        }

        private void BTNSAVE_Click(object sender, EventArgs e)
        {
            txtremark.Focus();//Toolscript焦點問題
            Save();
        }

        private void BTNCANCEL_Click(object sender, EventArgs e)
        {            
            objToolbar.Set_Button_Enable_Status(toolStrip1, true);
            objToolbar.SetToolBar();

            SetObjValue.SetEditBackColor(Controls, false);
            Set_Grid_Status(false);
            m_state = "";
            bds_h.CancelEdit();
            bds_d.CancelEdit();
            bds_fare.CancelEdit();
            dtMostly.RejectChanges();
            dtDetail.RejectChanges();
            dtFare.RejectChanges();
            dtTempDel.Clear();
            dtTempDel_Fare.Clear();
            if (!String.IsNullOrEmpty(m_id))
            {
                Find_Doc(m_id, int.Parse(m_ver));
            }
        }

        private void BTNAPPROVE_Click(object sender, EventArgs e)  //批準與反批準
        {
            if (luestate.EditValue.ToString() == "0")
            {
                ApproveState("1"); //批準
                //luestate.EditValue = "1";
                return;
            }

            if (luestate.EditValue.ToString() == "1")
            {
                ApproveState("0");//反批準
                //luestate.EditValue = "0";
            }
        }   

        

        //===============以下爲自定義方法======================  
        private void Delete()
        {
            if (BTNSAVE.Enabled || txtID.Text == "")
            {
                return;
            }
            if (luestate.EditValue.ToString() == "1")
            {
                //已批準狀態,不可以刪除!
                MessageBox.Show(clsCommon.GetTitle("t_ check_is_can_delete"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            DialogResult dialogResult = MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {

                if (clsPoPurchase.Delete_Mostly(txtID.Text, txtVer.Text) > 0)
                {
                    MessageBox.Show(myMsg.msgSave_ok, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(myMsg.msgSave_error, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Edit()
        {
            if (!(txtID.Text == ""))
            {
                if (BTNAPPROVE.Tag.ToString() == "1")
                {
                    //已批準狀態,不可以編輯!
                    MessageBox.Show(clsCommon.GetTitle("t_ check_is_can_edit"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                if (BTNAPPROVE.Tag.ToString() == "2")
                {
                    //注銷狀態,不可以編輯!
                    MessageBox.Show(clsCommon.GetTitle("t_ check_is_can_cancel"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                                  
               objToolbar.Set_Button_Enable_Status(toolStrip1, false);
               objToolbar.SetToolBar();
               SetObjValue.SetEditBackColor(tabPoPurchase.TabPages[0].Controls, true);
               Set_Grid_Status(true);
               m_state = "EDIT";
               txtID.Properties.ReadOnly = true;
               txtID.BackColor = System.Drawing.Color.White;
               tabPoPurchase.SelectedIndex = 0;                
            }
        }

        public void AddNew_Item()
        {
            m_got_focus_gridview = "dgvDetails";
            if (Valid_Data_H())
            {
                Set_Grid_Status(true);
                dgvDetails.AddNewRow();
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "id", txtID.Text);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "ver", txtVer.Text);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "mo_id", "Z99999999");
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "unit_code", "PCS");
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "sec_unit", "KG");
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "so_mark", true);
                Set_gridView_Focus();
                //using (frmPoPurchaseBillEdit ofrm = new frmPoPurchaseBillEdit(this, m_state, txtID.Text, txtVer.Text))
                //{
                //    ofrm.ShowDialog();
                //}
            }            
        }

        public void Del_Item()
        {
            m_got_focus_gridview = "dgvDetails";
            if (dgvDetails.RowCount != 0)
            {
                DialogResult dialogResult = MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int row = dgvDetails.FocusedRowHandle;
                    DataRow dr = dtTempDel.NewRow();
                    dr["id"] = txtID.Text;
                    dr["ver"] = dgvDetails.GetRowCellDisplayText(row, "ver");
                    dr["sequence_id"] = dgvDetails.GetRowCellDisplayText(row, "sequence_id");
                    dtTempDel.Rows.Add(dr);
                    dgvDetails.DeleteRow(row);
                }
            }
            Count_Amount();//移除記錄后需重計算金額
        }

        public void Del_Item_Fare()
        {
            m_got_focus_gridview = "dgvFare";
            if (dgvFare.RowCount != 0)
            {
                DialogResult dialogResult = MessageBox.Show(myMsg.msgIsDelete, myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dialogResult == DialogResult.Yes)
                {
                    int row = dgvFare.FocusedRowHandle;
                    DataRow dr = dtTempDel_Fare.NewRow();
                    dr["id"] = txtID.Text;                    
                    dr["ver"] =int.Parse(txtVer.Text);
                    string ss = dgvFare.GetRowCellDisplayText(row, "fare_id");
                    dr["fare_id"] = dgvFare.GetRowCellDisplayText(row, "fare_id");
                    dtTempDel_Fare.Rows.Add(dr);
                    dgvFare.DeleteRow(row);
                }
            }
            Count_Amount();//移除記錄后需重計算金額
        }

        private void AddNew() //新增
        {
            m_state = "NEW";
            //txtGoods_id.Focus();
            objToolbar.Set_Button_Enable_Status(toolStrip1, false);
            objToolbar.SetToolBar();
            
            SetObjValue.SetEditBackColor(tabPoPurchase.TabPages[0].Controls, true);
            SetObjValue.ClearObjValue(tabPoPurchase.TabPages[0].Controls, "2");//1 清空主檔，2全部            
            txtVer.Text = "0";
            lueorigin_id.EditValue = "1";
            luetype.EditValue = "1";
            luestate.EditValue = "0";
            BTNAPPROVE.Tag = "0";
            detOrder_date.EditValue = DateTime.Now.Date.ToString("yyyy/MM/dd");
            txtID.Text = clsPoPurchase.GetMaxNo();
            //DataRow dr = dtArt_request.NewRow(); //插一空行
            //dtArt_request.Rows.InsertAt(dr, 0);
            dtDetail.Clear();
            bds_d.DataSource = dtDetail;
            dtFare.Clear();
            bds_fare.DataSource = dtFare;
            gridControl1.DataSource = bds_d;
            gridControl2.DataSource = bds_fare;
            tabPoPurchase.SelectedIndex = 0;
        }

        //private void SetButtonSatus(bool _flag) //設置工具欄
        //{
        //    BTNNEW.Enabled = _flag;
        //    BTNEDIT.Enabled = _flag;
        //    BTNPRINT.Enabled = _flag;
        //    BTNDELETE.Enabled = _flag;
        //    BTNFIND.Enabled = _flag;
        //    BTNAPPROVE.Enabled = _flag;
        //    BTNSAVE.Enabled = !_flag;
        //    BTNCANCEL.Enabled = !_flag;
        //    BTNITEMADD.Enabled = !_flag;
        //    BTNITEMDEL.Enabled = !_flag;
        //    BTNOTHERFARE.Enabled = !_flag;
        //}

        private void Set_Grid_Status(bool _flag) //表格可編號否
        {
            //false--不可編輯;true--可以編輯
            dgvDetails.OptionsBehavior.Editable = _flag;
            dgvFare.OptionsBehavior.Editable = _flag;
        }

        private void Set_gridView_Focus()  //項目新增時設置表格當前焦點
        {
            ColumnView columnView = dgvDetails;
            columnView.FocusedColumn = columnView.Columns["mo_id"];
            columnView.Focus();
            columnView.ShowEditor();
        }

        private void Set_gridView_Focus_Fare() // 設置附加費焦點
        {
            ColumnView columnView = dgvFare;
            columnView.FocusedColumn = columnView.Columns["fare_id"];
            //columnView.Focus();
            columnView.ShowEditor();
        }

        private void Save()//保存新增,編輯或刪除的資料
        {
            if (m_state == "")
            {
                return;
            }
            if (!Valid_Data_H())
            {
                return;
            }
            dgvDetails.CloseEditor();
            if (!Valid_Data_D())//檢查明細資料的有效性
            {
                return;
            }
            dgvFare.CloseEditor();
            if (!Valid_Fare_Data()) //檢查附加費資料的有效性
            {
                return;
            }
            if (IsRepeat()) //檢查明細是否有重覆物料
            {
                return;
            }
            if (IsRepeat_Fare())//檢查附加費是否有重覆物料
            {
                return;
            }
            save_flag = false;
            #region  保存新增
            if (m_state == "NEW" || m_state == "EDIT")
            {
                string ls_ver = txtVer.Text;
                if (m_state == "NEW")
                {
                    string ls_sql = String.Format("Select '1' FROM dbo.po_buy_manage WHERE id='{0}' And ver='{1}'", txtID.Text, ls_ver);
                    if (clsCommon.Valid_Doc(ls_sql)) //檢查主鍵是否存在
                    {
                        //重新取最大單據編號
                        txtID.Text = clsPoPurchase.GetMaxNo();
                    }
                }
                const string ls_sql_i =
                    @"INSERT dbo.po_buy_manage(id,ver,order_date,vendor_id,vendor_address,buyer_id,cd_buyer,it_customer, s_address, sm_id,p_id,cd_shipment,
                             sales_person, packing, side_mark, remark, origin_id, linkman, type,l_phone,fax, m_id,exchange_rate,m_rate,finally_buyer,
                             department_id, area, tax_ticket, pc_id, tax_sum, pg_sum, disc_spare, tack_fare, total_sum, ship_mark, create_by, create_date) 
					  VALUES(@id,@ver,@order_date,@vendor_id,@vendor_address,@buyer_id,@cd_buyer,@it_customer,@s_address,@sm_id,@p_id,@cd_shipment,
                             @sales_person,@packing,@side_mark,@remark,@origin_id,@linkman,@type,@l_phone,@fax,@m_id,@exchange_rate,@m_rate,@finally_buyer,
                             @department_id,@area,@tax_ticket,@pc_id,@tax_sum,@pg_sum,@disc_spare,@tack_fare,@total_sum,@ship_mark,@user_id,getdate())";
                const string ls_sql_u =
                    @"UPDATE dbo.po_buy_manage 
                     SET order_date=@order_date,vendor_id=@vendor_id,vendor_address=@vendor_address,buyer_id=@buyer_id,cd_buyer=@cd_buyer,it_customer=@it_customer,
                         s_address=@s_address,sm_id=@sm_id,p_id=@p_id,cd_shipment=@cd_shipment,sales_person=@sales_person,packing=@packing,side_mark=@side_mark,remark=@remark,
                         origin_id=@origin_id,linkman=@linkman,type=@type,l_phone=@l_phone,fax=@fax,m_id=@m_id,exchange_rate=@exchange_rate,m_rate=@m_rate,
                         finally_buyer=@finally_buyer,department_id=@department_id,area=@area,tax_ticket=@tax_ticket,pc_id=@pc_id,tax_sum=@tax_sum,pg_sum=@pg_sum,
                         disc_spare=@disc_spare,tack_fare=@tack_fare,total_sum=@total_sum,ship_mark=@ship_mark,update_by=@user_id,update_date=getdate()
                     WHERE id=@id and ver=@ver";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);
                myCon.Open();
                SqlTransaction myTrans = myCon.BeginTransaction();
                using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
                {
                    try
                    {
                        if (m_state == "NEW")
                            myCommand.CommandText = ls_sql_i;
                        else
                            myCommand.CommandText = ls_sql_u;
                        myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@id", txtID.Text.Trim());
                        myCommand.Parameters.AddWithValue("@ver", ls_ver); //版本
                        myCommand.Parameters.AddWithValue("@order_date", detOrder_date.Text);
                        myCommand.Parameters.AddWithValue("@vendor_id", luevendor_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@vendor_address", txtvendor_address.Text);
                        myCommand.Parameters.AddWithValue("@buyer_id", btebuyer_id.Text);
                        myCommand.Parameters.AddWithValue("@cd_buyer", txtcd_buyer.Text);
                        myCommand.Parameters.AddWithValue("@it_customer", lueit_customer.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@s_address", txts_address.Text);
                        myCommand.Parameters.AddWithValue("@sm_id", luesm_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@p_id", luep_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@cd_shipment", txtcd_shipment.Text);
                        myCommand.Parameters.AddWithValue("@sales_person", luesales_person.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@packing", txtpacking.Text);
                        myCommand.Parameters.AddWithValue("@side_mark", memside_mark.Text);
                        myCommand.Parameters.AddWithValue("@ship_mark", memship_mark.Text);
                        myCommand.Parameters.AddWithValue("@remark", txtremark.Text);
                        myCommand.Parameters.AddWithValue("@origin_id", lueorigin_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@linkman", txtlinkman.Text);
                        myCommand.Parameters.AddWithValue("@type", luetype.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@l_phone", txtl_phone.Text);
                        myCommand.Parameters.AddWithValue("@fax", txtfax.Text);
                        myCommand.Parameters.AddWithValue("@m_id", luem_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@exchange_rate", lueExchange_rate.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@m_rate", objApp.Return_Float_Value(txtm_rate.Text));
                        myCommand.Parameters.AddWithValue("@finally_buyer", luefinally_buyer.Text);
                        myCommand.Parameters.AddWithValue("@department_id", luedepartment_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@area", luearea.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@tax_ticket", luetax_ticket.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@pc_id", luepc_id.EditValue.ToString());

                        myCommand.Parameters.AddWithValue("@tax_sum", objApp.Return_Float_Value(txttax_sum.Text));
                        myCommand.Parameters.AddWithValue("@pg_sum", objApp.Return_Float_Value(txtpg_sum.Text));
                        myCommand.Parameters.AddWithValue("@disc_spare", objApp.Return_Float_Value(txtdisc_spare.Text));
                        myCommand.Parameters.AddWithValue("@tack_fare", objApp.Return_Float_Value(txttack_fare.Text));
                        myCommand.Parameters.AddWithValue("@total_sum", objApp.Return_Float_Value(txttotal_sum.Text));
                        myCommand.Parameters.AddWithValue("@user_id", DBUtility._user_id);
                        myCommand.ExecuteNonQuery();

                        //處理明細資料
                        string ls_row_status = "";
                        if (dgvDetails.RowCount > 0)
                        {
                            const string sql_item_i =
                                @"INSERT INTO dbo.po_buy_details(
                                  mo_id,goods_id,goods_name,spec,color,do_color,order_qty,unit_code,sec_qty,sec_unit,price,p_unit,
                                  disc_rate,disc_amt,total_sum,fact_date,cess,remark,so_mark,bill_origin,dept_id,sell_order,vendor_goods,add_remark,id,ver,sequence_id)
                                  VALUES(@mo_id,@goods_id,@goods_name,@spec,@color,@do_color,@order_qty,@unit_code,@sec_qty,@sec_unit,@price,@p_unit,
                                  @disc_rate,@disc_amt,@total_sum,CASE WHEN LEN(@fact_date)=0 THEN NULL ELSE @fact_date END,@cess,@remark,@so_mark,@bill_origin,
                                  @dept_id,@sell_order,@vendor_goods,@add_remark,@id,@ver,@sequence_id)";
                            const string sql_item_u =
                                @"UPDATE dbo.po_buy_details 
                                  SET mo_id=@mo_id,goods_id=@goods_id,goods_name=@goods_name,spec=@spec,color=@color,do_color=@do_color,order_qty=@order_qty,
                                      unit_code=@unit_code,sec_qty=@sec_qty,sec_unit=@sec_unit,price=@price,p_unit=@p_unit,disc_rate=@disc_rate,disc_amt=@disc_amt,
                                      total_sum=@total_sum,fact_date=CASE WHEN LEN(@fact_date)=0 THEN NULL ELSE @fact_date END,cess=@cess,remark=@remark,
                                      so_mark=@so_mark,bill_origin=@bill_origin,dept_id=@dept_id,sell_order=@sell_order,vendor_goods=@vendor_goods,add_remark=@add_remark
                                  WHERE id=@id and ver=@ver and sequence_id=@sequence_id";
                            const string sql_item_d = @"DELETE FROM dbo.po_buy_details WHERE id=@id and ver=@ver and sequence_id=@sequence_id";
                            //處進點擊[項目刪除]操作刪除的記錄
                            if (m_state == "EDIT")
                            {
                                if (dtTempDel.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dtTempDel.Rows.Count; i++)
                                    {
                                        myCommand.CommandText = sql_item_d;
                                        myCommand.Parameters.Clear();
                                        myCommand.Parameters.AddWithValue("@id", txtID.Text.Trim());
                                        myCommand.Parameters.AddWithValue("@ver", txtVer.Text.Trim());
                                        myCommand.Parameters.AddWithValue("@sequence_id", dtTempDel.Rows[i]["sequence_id"].ToString());
                                        myCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                            //保存明細
                            string ls_seq_id = "";
                            for (int i = 0; i < dtDetail.Rows.Count; i++)
                            {
                                if (m_state == "NEW")
                                {
                                    dgvDetails.SetRowCellValue(i, "id", txtID.Text);
                                }
                                ls_row_status = dtDetail.Rows[i].RowState.ToString();
                                if (ls_row_status == "Added" || ls_row_status == "Modified")
                                {
                                    if (ls_row_status == "Added")
                                    {
                                        myCommand.CommandText = sql_item_i;
                                        ls_seq_id = clsPoPurchase.Get_Details_Seq(txtID.Text.Trim(), ls_ver); //新增狀態重新取最大序號;                                        
                                        dgvDetails.SetRowCellValue(i, "sequence_id", ls_seq_id);
                                    }
                                    else
                                    {
                                        myCommand.CommandText = sql_item_u;
                                        ls_seq_id = dtDetail.Rows[i]["sequence_id"].ToString(); //編輯時序號;
                                    }
                                    myCommand.Parameters.Clear();
                                    myCommand.Parameters.AddWithValue("@id", txtID.Text.Trim());
                                    myCommand.Parameters.AddWithValue("@ver", ls_ver);
                                    myCommand.Parameters.AddWithValue("@sequence_id", ls_seq_id);
                                    myCommand.Parameters.AddWithValue("@mo_id", dtDetail.Rows[i]["mo_id"].ToString());
                                    myCommand.Parameters.AddWithValue("@goods_id", dtDetail.Rows[i]["goods_id"].ToString());
                                    myCommand.Parameters.AddWithValue("@goods_name", dtDetail.Rows[i]["goods_name"].ToString());
                                    myCommand.Parameters.AddWithValue("@spec", dtDetail.Rows[i]["spec"].ToString());
                                    myCommand.Parameters.AddWithValue("@color", dtDetail.Rows[i]["color"].ToString());
                                    myCommand.Parameters.AddWithValue("@do_color", dtDetail.Rows[i]["do_color"].ToString());
                                    myCommand.Parameters.AddWithValue("@order_qty", objApp.Return_Float_Value(dtDetail.Rows[i]["order_qty"].ToString()));//
                                    myCommand.Parameters.AddWithValue("@unit_code", dtDetail.Rows[i]["unit_code"].ToString());
                                    myCommand.Parameters.AddWithValue("@sec_qty", objApp.Return_Float_Value(dtDetail.Rows[i]["sec_qty"].ToString()));//
                                    myCommand.Parameters.AddWithValue("@sec_unit", dtDetail.Rows[i]["sec_unit"].ToString());
                                    myCommand.Parameters.AddWithValue("@price", objApp.Return_Float_Value(dtDetail.Rows[i]["price"].ToString()));//
                                    myCommand.Parameters.AddWithValue("@p_unit", dtDetail.Rows[i]["p_unit"].ToString());
                                    myCommand.Parameters.AddWithValue("@disc_rate", objApp.Return_Float_Value(dtDetail.Rows[i]["disc_rate"].ToString()));//
                                    myCommand.Parameters.AddWithValue("@disc_amt", objApp.Return_Float_Value(dtDetail.Rows[i]["disc_amt"].ToString()));//
                                    myCommand.Parameters.AddWithValue("@total_sum", objApp.Return_Float_Value(dtDetail.Rows[i]["total_sum"].ToString()));//
                                    myCommand.Parameters.AddWithValue("@fact_date", !string.IsNullOrEmpty(dtDetail.Rows[i]["fact_date"].ToString()) ? dtDetail.Rows[i]["fact_date"].ToString() : "");
                                    myCommand.Parameters.AddWithValue("@cess", objApp.Return_Float_Value(dtDetail.Rows[i]["cess"].ToString()));//
                                    myCommand.Parameters.AddWithValue("@remark", dtDetail.Rows[i]["remark"].ToString());
                                    myCommand.Parameters.AddWithValue("@so_mark", dtDetail.Rows[i]["so_mark"].ToString());
                                    myCommand.Parameters.AddWithValue("@bill_origin", dtDetail.Rows[i]["bill_origin"].ToString());
                                    myCommand.Parameters.AddWithValue("@dept_id", dtDetail.Rows[i]["dept_id"].ToString());
                                    myCommand.Parameters.AddWithValue("@sell_order", dtDetail.Rows[i]["sell_order"].ToString());
                                    myCommand.Parameters.AddWithValue("@vendor_goods", dtDetail.Rows[i]["vendor_goods"].ToString());
                                    myCommand.Parameters.AddWithValue("@add_remark", dtDetail.Rows[i]["add_remark"].ToString());
                                    
                                    myCommand.ExecuteNonQuery();
                                }
                            }
                        }

                        //處理附加費
                        if (dgvFare.RowCount > 0)
                        {
                            string sql_fare_i = "", sql_fare_u = "";
                            sql_fare_i =
                                @"INSERT INTO dbo.po_other_fare(fare_id,name,qty,unit_code,price,fare_sum,goods_id,id,ver)
                                       VALUES(@fare_id,@name,@qty,@unit_code,@price,@fare_sum,@goods_id,@id,@ver)";
                            sql_fare_u =
                                @"UPDATE dbo.po_other_fare
                                  SET fare_id=@fare_id,name=@name,qty=@qty,unit_code=@unit_code,price=@price,fare_sum=@fare_sum,goods_id=@goods_id
                                  WHERE id=@id and ver=@ver and fare_id=@org_fare_id";
                            const string sql_item_d_fare = @"DELETE FROM dbo.po_other_fare WHERE id=@id AND ver=@ver AND fare_id=@fare_id";
                            //處進點擊[項目刪除]操作刪除的記錄
                            if (m_state == "EDIT")
                            {
                                if (dtTempDel_Fare.Rows.Count > 0)
                                {
                                    for (int i = 0; i < dtTempDel_Fare.Rows.Count; i++)
                                    {
                                        myCommand.CommandText = sql_item_d_fare;
                                        myCommand.Parameters.Clear();
                                        myCommand.Parameters.AddWithValue("@id", txtID.Text.Trim());
                                        myCommand.Parameters.AddWithValue("@ver", txtVer.Text.Trim());
                                        myCommand.Parameters.AddWithValue("@fare_id", dtTempDel_Fare.Rows[i]["fare_id"].ToString());
                                        myCommand.ExecuteNonQuery();
                                    }
                                }
                            }
                            for (int i = 0; i < dtFare.Rows.Count; i++)
                            {
                                ls_row_status = dtFare.Rows[i].RowState.ToString();
                                if (ls_row_status == "Added" || ls_row_status == "Modified")
                                {
                                    if (ls_row_status == "Added")
                                        myCommand.CommandText = sql_fare_i;
                                    else
                                        myCommand.CommandText = sql_fare_u;
                                    myCommand.Parameters.Clear();
                                    myCommand.Parameters.AddWithValue("@id", dtFare.Rows[i]["id"].ToString());//**??
                                    myCommand.Parameters.AddWithValue("@ver", dtFare.Rows[i]["ver"].ToString());
                                    myCommand.Parameters.AddWithValue("@fare_id", dtFare.Rows[i]["fare_id"].ToString());
                                    myCommand.Parameters.AddWithValue("@name", dtFare.Rows[i]["name"].ToString());
                                    myCommand.Parameters.AddWithValue("@qty", objApp.Return_Float_Value(dtFare.Rows[i]["qty"].ToString()));//
                                    myCommand.Parameters.AddWithValue("@unit_code", dtFare.Rows[i]["unit_code"].ToString());
                                    myCommand.Parameters.AddWithValue("@price", objApp.Return_Float_Value(dtFare.Rows[i]["price"].ToString()));//
                                    myCommand.Parameters.AddWithValue("@fare_sum", objApp.Return_Float_Value(dtFare.Rows[i]["fare_sum"].ToString()));//
                                    myCommand.Parameters.AddWithValue("@goods_id", dtFare.Rows[i]["goods_id"].ToString());
                                    if (ls_row_status == "Modified")
                                    {
                                        myCommand.Parameters.AddWithValue("@org_fare_id", dtFare.Rows[i]["org_fare_id"].ToString());
                                    }
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
                        myCon.Dispose();
                        myTrans.Dispose();
                    }
                }
            }
            #endregion

            
            objToolbar.Set_Button_Enable_Status(toolStrip1, true);
            objToolbar.SetToolBar();
            SetObjValue.SetEditBackColor(this.Controls, false);
            Set_Grid_Status(false);
            m_state = "";
            dtTempDel.Clear();
            dtTempDel_Fare.Clear();
            if (save_flag)
            {
                Find_Doc(txtID.Text, int.Parse(txtVer.Text));
                DBUtility.myMessageBox(myMsg.msgSave_ok, myMsg.msgTitle);
                m_id = txtID.Text;
                m_ver = txtVer.Text;
            }
            else
            {
                MessageBox.Show(myMsg.msgSave_error, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Find_Doc(string id, int ver)
        {
            DataSet dts = clsPoPurchase.Get_PO_Data(id, ver);
            if (dts.Tables[0].Rows.Count > 0)
            {
                dtMostly = dts.Tables[0];
                bds_h.DataSource = dtMostly;
                dtDetail = dts.Tables[1];                
                dtFare = dts.Tables[2];
                bds_d.DataSource = dtDetail;
                bds_fare.DataSource = dtFare;                
                m_id = txtID.Text;
                m_ver = txtVer.Text;
            }
        }

        private void ApproveState(string state) //批準或反批準
        {
            if (txtID.Text == "")
            {
                return;
            }
            //批準
            const string str1 = @"Update dbo.po_buy_manage Set state=@state,sanction_by=@user_id,sanction_date = getdate() Where id=@id And ver=@ver";
            //反批準
            const string str2 = @"Update dbo.po_buy_manage Set state=@state,sanction_by=NULL,sanction_date=NULL,update_by=@user_id,update_date=getdate() 
						  Where id=@id And ver=@ver";
            SqlParameter[] paras = new SqlParameter[]
			{
				new SqlParameter("@state", state),
				new SqlParameter("@user_id", DBUtility._user_id),
				new SqlParameter("@id", txtID.Text),
				new SqlParameter("@ver", txtVer.Text)
			};
            string strSql;
            if (state == "0")
            {
                strSql = str2;
            }
            else
            {
                strSql = str1;
            }
            int num = clsApp.ExecuteNonQuery(strSql, paras, false);
            if (num > 0)
            {
                luestate.EditValue = state;
                //SetButton_ApproveSatus(state);
            }
        }

        private void SetButton_ApproveSatus(string state)
        {
            strFileImag = "";
            switch (state)
            {
                case "0":
                    luestate.EditValue = "0";//txtState.Text = "未批準";
                    if (DBUtility._language == "2")
                        BTNAPPROVE.Text = "Approve(&Y)";
                    else
                        BTNAPPROVE.Text = "批準(&Y)";
                    //BTNAPPROVE.Tag = "0";
                    strFileImag = strImgPath + "Images\\p_ok.png";
                    if (File.Exists(strFileImag))
                    {
                        BTNAPPROVE.Image = Image.FromFile(strFileImag);
                    }
                    break;
                case "1":
                    luestate.EditValue = "1"; // txtState.Text = "已批準";
                    if (DBUtility._language == "2")
                        BTNAPPROVE.Text = "Un Approve(&Y)";
                    else
                        BTNAPPROVE.Text = "反批準(&Y)";
                    //BTNAPPROVE.Tag = "1";
                    strFileImag = strImgPath + "Images\\p_unok.png";
                    if (File.Exists(strFileImag))
                    {
                        BTNAPPROVE.Image = Image.FromFile(strFileImag);
                    }
                    break;
                case "2":
                    luestate.EditValue = "2"; // txtState.Text = "已批準";
                    if (DBUtility._language == "2")
                        BTNAPPROVE.Text = "Approve(&Y)";
                    else
                        BTNAPPROVE.Text = "批準(&Y)";
                    //BTNAPPROVE.Tag = "2";
                    strFileImag = strImgPath + "Images\\p_ok.png";
                    if (File.Exists(strFileImag))
                    {
                        BTNAPPROVE.Image = Image.FromFile(strFileImag);
                    }
                    BTNAPPROVE.Enabled = false;
                    break;
                case "9":
                    luestate.EditValue = "9"; // "送貨完成";
                    if (DBUtility._language == "2")
                        BTNAPPROVE.Text = "Un Approve(&Y)";
                    else
                        BTNAPPROVE.Text = "反批準(&Y)";
                    //BTNAPPROVE.Tag = "9";
                    strFileImag = strImgPath + "Images\\p_unok.png";
                    if (File.Exists(strFileImag))
                    {
                        BTNAPPROVE.Image = Image.FromFile(strFileImag);
                    }
                    BTNAPPROVE.Enabled = false;
                    break;
            }
        }

        private bool Valid_Data_H() //保存前檢查主表的合法性
        {
            if (txtID.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_id_cannot_empty"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtID.Focus();
                return false;
            }
            if (luedepartment_id.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_dept_id_cannot_empty"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btebuyer_id.Focus();
                return false;
            }
            if (detOrder_date.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_order_date_cannot_emtpy"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                detOrder_date.Focus();
                return false;
            }
            if (lueorigin_id.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_bill_origin_id"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                lueorigin_id.Focus();
                return false;
            }
            if (luevendor_id.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_vendor_id_cannot_empty"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                luevendor_id.Focus();
                return false;
            }
            if (btebuyer_id.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_buyer_id_cannot_empty"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                btebuyer_id.Focus();
                return false;
            }
            if (luem_id.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_money_id_cannot_empty"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                luem_id.Focus();
                return false;
            }
            if (luetype.Text == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_type_id_cannot_empty"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                luetype.Focus();
                return false;
            }
            return true;
        }

        private bool Valid_Data_D() //保存前檢查明細資料的合法性
        {
            bool result = true;
            if (dgvDetails.RowCount > 0)
            {
                string ls_tips, ls_tips_goods;
                //string ls_tips_mo;
                if (DBUtility._language == "2")
                {
                    ls_tips = "mo、goods、order qty or unit cannot empty.";
                    //ls_tips_mo = "Invalid mo id ";
                    ls_tips_goods = "Invalid goods id";
                }
                else
                {
                    ls_tips = "頁數、貨品編號、訂單數量或單位不可爲空!";
                    //ls_tips_mo = "無效的頁數.";
                    ls_tips_goods = "無效的貨品編號";
                }

                ColumnView columnView = dgvDetails;
                string ls_rowStatus = "";
                for (int i = 0; i < dgvDetails.RowCount; i++)
                {
                    ls_rowStatus = dtDetail.Rows[i].RowState.ToString();
                    if (ls_rowStatus == "Added" || ls_rowStatus == "Modified")
                    {
                        int rowHandle = dgvDetails.GetRowHandle(i);
                        //string rowno = (rowHandle + 1).ToString();
                        string mo_id = dgvDetails.GetRowCellDisplayText(rowHandle, "mo_id");
                        string order_qty = dgvDetails.GetRowCellDisplayText(rowHandle, "order_qty");
                        if (string.IsNullOrEmpty(dgvDetails.GetRowCellDisplayText(rowHandle, "goods_id")) || mo_id == "" || order_qty == "0" ||
                            string.IsNullOrEmpty(dgvDetails.GetRowCellDisplayText(rowHandle, "unit_code")))
                        {
                            result = false;
                            MessageBox.Show(ls_tips, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            columnView.FocusedColumn = columnView.Columns["mo_id"];
                            columnView.ShowEditor();
                            break;
                        }
                        ////檢查頁數是否有效
                        //if (!clsCommon.Is_Exists_Mo(mo_id))
                        //{
                        //    MessageBox.Show(ls_tips_mo, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //    columnView.FocusedColumn = columnView.Columns["mo_id"];
                        //    result = false;
                        //    break;
                        //}
                        //檢查物料是否有效
                        string strGoods_id = dgvDetails.GetRowCellDisplayText(rowHandle, "goods_id");
                        if (!clsCommon.Is_Exists_Goods(strGoods_id))
                        {
                            MessageBox.Show(ls_tips_goods, myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            columnView.FocusedColumn = columnView.Columns["goods_id"];
                            columnView.ShowEditor();
                            result = false;
                            break;
                        }
                    }
                }
            }
            else
            {
                result = false;
            }
            return result;
        }

        //保存前檢查附加費資料的合法性
        private bool Valid_Fare_Data()
        {
            bool result = true;
            if (dgvFare.RowCount > 0)
            {
                ColumnView columnView = dgvFare;
                string ls_rowStatus = "";
                int rowHandle = 0;
                for (int i = 0; i < dgvFare.RowCount; i++)
                {
                    ls_rowStatus = dtFare.Rows[i].RowState.ToString();
                    if (ls_rowStatus == "Added" || ls_rowStatus == "Modified")
                    {
                        rowHandle = dgvFare.GetRowHandle(i);
                        if (string.IsNullOrEmpty(dgvFare.GetRowCellDisplayText(rowHandle, "fare_id")))
                        {
                            result = false;
                            MessageBox.Show(clsCommon.GetTitle("t_msg_fare_id"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            columnView.FocusedColumn = columnView.Columns["fare_id"];
                            columnView.ShowEditor();
                            break;
                        }
                        //檢查名稱是否為空
                        if (string.IsNullOrEmpty(dgvFare.GetRowCellDisplayText(rowHandle, "name")))
                        {
                            MessageBox.Show(clsCommon.GetTitle("t_msg_fare_id_name"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            columnView.FocusedColumn = columnView.Columns["name"];
                            columnView.ShowEditor();
                            result = false;
                            break;
                        }
                    }
                }
            }
            return result;
        }

        private bool IsRepeat() //明細資料不允許有重覆
        {
            if (dgvDetails.RowCount < 2)
            {
                return false;
            }
            bool result = false;
            string ls_tips;
            if (DBUtility._language == "2")            
                ls_tips = "The mo and the item number are not allowed to be repeated.\n\n";            
            else
                ls_tips = "頁數及貨品編號不允許有重覆!\n\n";
            string ls_mo_id = "", ls_goods_id = "";
            for (int i = 0; i < dgvDetails.RowCount - 1; i++)
            {
                ls_mo_id = dgvDetails.GetRowCellDisplayText(i, "mo_id");
                ls_goods_id = dgvDetails.GetRowCellDisplayText(i, "goods_id");
                for (int j = i + 1; j <= dgvDetails.RowCount - 1; j++)
                {
                    if (ls_mo_id == dgvDetails.GetRowCellDisplayText(j, "mo_id") && ls_goods_id == dgvDetails.GetRowCellDisplayText(j, "goods_id"))
                    {
                        MessageBox.Show(ls_tips + string.Format("「{0}」;「{1}」", ls_mo_id, ls_goods_id), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        private bool IsRepeat_Fare() //附加費ID資料不允許有重覆
        {
            if (dgvFare.RowCount < 2)
            {
                return false;
            }
            bool result = false;
            string ls_tips;
            if (DBUtility._language == "2")
            {
                ls_tips = "The Fare ID is not allowed to be repeated.\n\n";
            }
            else
                ls_tips = "附加費用編號不允許有重覆!\n\n";
            string ls_fare_id = "";
            for (int i = 0; i < dgvFare.RowCount - 1; i++)
            {
                ls_fare_id = dgvFare.GetRowCellDisplayText(i, "fare_id");
                for (int j = i + 1; j <= dgvFare.RowCount - 1; j++)
                {
                    if (ls_fare_id == dgvFare.GetRowCellDisplayText(j, "fare_id"))
                    {
                        MessageBox.Show(ls_tips + string.Format("「{0}」", ls_fare_id), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        result = true;
                        break;
                    }
                }
            }
            return result;
        }

        //        private string Get_Details_Seq(string _comp, string _id, string _ver) //取明細的序號
        //        {
        //            DataTable dtMaxseq = new DataTable();
        //            dtMaxseq = clsApp.GetDataTable(String.Format(@"SELECT MAX(log_no) as log_no 
        //															  FROM dbo.bs_bom with(nolock) 
        //															  WHERE within_code='{0}' AND id='{1}' AND exp_id='{2}'", _comp, _id, _ver));
        //            string strSeq; 
        //            if (String.IsNullOrEmpty(dtMaxseq.Rows[0]["log_no"].ToString()))
        //            {
        //                strSeq = "0001";
        //            }
        //            else
        //            {
        //                strSeq = dtMaxseq.Rows[0]["log_no"].ToString();
        //                strSeq = strSeq.Substring(0, 4);
        //                strSeq = (Convert.ToInt32(strSeq) + 1).ToString("0000");
        //            }
        //            dtMaxseq.Dispose();
        //            return strSeq;
        //        }

        private void dgvDetails_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e) //明細資料編輯時背景色 
        {
            if (dgvDetails.GetDataRow(e.RowHandle) == null)
            {
                return;
            }
            string rowStatus = dgvDetails.GetDataRow(e.RowHandle).RowState.ToString();
            if (rowStatus == "Added" || rowStatus == "Modified")
            {
                e.Appearance.ForeColor = Color.Black;
                e.Appearance.BackColor = Color.LemonChiffon;
            }
        }

        //**************************************************
        private void lueExchange_rate_EditValueChanged(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                if (lueExchange_rate.EditValue == null)
                {
                    txtm_rate.Text = "";
                    return;
                }
                txtm_rate.Text = lueExchange_rate.GetColumnValue("exchange_rate").ToString();
            }
        }

        private void luem_id_EditValueChanged(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                if (string.IsNullOrEmpty(luem_id.EditValue.ToString()))
                {
                    lueExchange_rate.EditValue = null;
                    return;
                }
                lueExchange_rate.EditValue = int.Parse(luem_id.GetColumnValue("sequence_id").ToString());
            }
        }

        private void luevendor_id_EditValueChanged(object sender, EventArgs e)
        {
            if (m_state != "" && luevendor_id.Text != "")
            {
                txtVendor_name.Text = luevendor_id.GetColumnValue("name").ToString();
                DataTable dt = clsPoPurchase.Get_Vendor_Info(luevendor_id.Text);
                if (dt.Rows.Count > 0)
                {
                    txtvendor_address.Text = dt.Rows[0]["add_address"].ToString();
                    txtlinkman.Text = dt.Rows[0]["linkman"].ToString();
                    txtl_phone.Text = dt.Rows[0]["l_phone"].ToString();
                    luem_id.EditValue = dt.Rows[0]["money_id"].ToString();
                    luep_id.EditValue = dt.Rows[0]["payment_mode"].ToString();
                    txtfax.Text = dt.Rows[0]["fax"].ToString();
                }
                else
                {
                    txtvendor_address.Text = "";
                    txtlinkman.Text = "";
                    txtl_phone.Text = "";
                    luem_id.EditValue = "";
                    luep_id.EditValue = "";
                    txtfax.Text = "";
                }
            }
        }

        private void lueit_customer_Leave(object sender, EventArgs e)
        {
            if (m_state != "" && lueit_customer.Text != "")
            {
                txtCustomer_name.Text = lueit_customer.GetColumnValue("name").ToString();
                DataTable dt = clsPoPurchase.Get_Customer_Send_Address(lueit_customer.Text);
                if (dt.Rows.Count > 0)
                {
                    txts_address.Text = dt.Rows[0]["shipment_s_address"].ToString();
                }
                else
                {
                    txts_address.Text = "";
                }
            }
        }

        private void btebuyer_id_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (m_state != "")
            {
                using (frmPoPurchaseBillEmp ofrm = new frmPoPurchaseBillEmp(btebuyer_id.Text) { Location = new Point(txtcd_buyer.Left + 8, txtcd_buyer.Top + 63) })
                {
                    var screenPoint = this.PointToScreen(ofrm.Location);
                    ofrm.Left = screenPoint.X;
                    ofrm.Top = screenPoint.Y;
                    ofrm.ShowDialog();
                    if (ofrm.mEmp_id != "")
                    {
                        btebuyer_id.Text = ofrm.mEmp_id;
                    }
                }
            }
        }

        private void btebuyer_id_Leave(object sender, EventArgs e)
        {
            if (m_state != "" && btebuyer_id.Text != "")
            {
                string emp_id = int.Parse(btebuyer_id.Text).ToString("0000000000");
                btebuyer_id.Text = emp_id;
                if (clsPoPurchase.Get_Employer(emp_id) != "")
                    txtcd_buyer.Text = clsPoPurchase.Get_Employer(emp_id);
                else
                {
                    DBUtility.myMessageBox(myMsg.msgResult_Find, myMsg.msgTitle);
                    btebuyer_id.Text = "";
                    txtcd_buyer.Text = "";
                }
            }
            else
            {
                txtcd_buyer.Text = "";
            }
        }


        private void col_goods_id_Leave(object sender, EventArgs e)
        {
            if (dgvDetails.OptionsBehavior.Editable)
            {
                dgvDetails.CloseEditor();
                int cur_row = dgvDetails.FocusedRowHandle;
                string ls_goods_id = dgvDetails.GetRowCellDisplayText(cur_row, "goods_id");
                if (ls_goods_id == "")
                {
                    return;
                }
                //取得修改前的原始值
                string ls_goods_id_original="";
                DataRow myEditDataRow = dgvDetails.GetDataRow(cur_row);
                if (cur_row >= 0)
                {
                    try
                    {
                        ls_goods_id_original = myEditDataRow["goods_id", DataRowVersion.Original].ToString();
                    }
                    catch(Exception )
                    {
                        //MessageBox.Show(ex.Message.ToString());
                        //新增的行因不存在原始值,重新取原始值會引發異常,故作此處理
                        ls_goods_id_original = "";
                    }
                }                
                if (ls_goods_id != ls_goods_id_original)
                {
                    DataTable dt = clsPoPurchase.Get_MM_Info(ls_goods_id);
                    if (dt.Rows.Count > 0)
                    {
                        dgvDetails.SetRowCellValue(cur_row, "goods_name", dt.Rows[0]["name"].ToString());
                        dgvDetails.SetRowCellValue(cur_row, "color", dt.Rows[0]["color"].ToString());
                        dgvDetails.SetRowCellValue(cur_row, "do_color", dt.Rows[0]["do_color"].ToString());
                    }
                    else
                    {
                        MessageBox.Show(clsCommon.GetTitle("t_msg_goods_not_exists"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        dgvDetails.SetRowCellValue(cur_row, "goods_id", "");
                        dgvDetails.SetRowCellValue(cur_row, "goods_name", "");
                    }
                }               
            }
        }

        private void col_mo_id_Leave(object sender, EventArgs e)
        {
            if (dgvDetails.OptionsBehavior.Editable)
            {
                dgvDetails.CloseEditor();
                string ls_mo_id = dgvDetails.GetRowCellDisplayText(dgvDetails.FocusedRowHandle, "mo_id");
                if (ls_mo_id != "")
                {
                    if (ls_mo_id.Substring(0, 1) == "Z")
                    {
                        return;
                    }
                    //非Z開頭的頁數需檢查頁數oc資料是否存在
                    //需完善以下代碼
                    //檢查頁數是否有效
                    //if (!clsPoPurchase.Valid_MO(ls_mo_id))
                    //{
                    //    MessageBox.Show(clsCommon.GetTitle("t_msg_mo_id_not_exist"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    ColumnView columnView = dgvFare;
                    //    columnView.FocusedColumn = columnView.Columns["mo_id"];

                    //}
                }
            }
        }

        private void luestate_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(luestate.Text))
            {
                SetButton_ApproveSatus(luestate.EditValue.ToString());
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            if (e.ClickedItem.Name == "BTNSAVE")
            {
                txtremark.Focus();
            }
        }

        private void BTNOTHERFARE_Click(object sender, EventArgs e)
        {
            Add_Item_Fare();
        }

        private void Add_Item_Fare()
        {
            m_got_focus_gridview = "dgvFare";
            if (Valid_Data_H())
            {
                if (dgvDetails.RowCount == 0)
                {
                    MessageBox.Show(clsCommon.GetTitle("t_msg_details_cannot_empty"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
                //if (dgvDetails.GetRowCellValue(dgvDetails.FocusedRowHandle, "goods_id").ToString() == "")
                //{
                //    MessageBox.Show(clsCommon.GetTitle("t_msg_goods_cannot_empty"));
                //    return;
                //}                
                //Set_Grid_Status(true);
                //dgvFare.AddNewRow();
                //dgvFare.SetRowCellValue(dgvFare.FocusedRowHandle, "id", txtID.Text);
                //dgvFare.SetRowCellValue(dgvFare.FocusedRowHandle, "ver", txtVer.Text);
                //dgvFare.SetRowCellValue(dgvFare.FocusedRowHandle, "unit_code", "PCS");
                //dgvFare.SetRowCellValue(dgvFare.FocusedRowHandle, "goods_id", dgvDetails.GetRowCellValue(dgvDetails.FocusedRowHandle, "goods_id").ToString());
                //Set_gridView_Focus_Fare();

                using (frmPoPurchaseBillEditFare ofrm = new frmPoPurchaseBillEditFare(this, m_state, txtID.Text, txtVer.Text))
                {
                    ofrm.ShowDialog();
                }
            }
        }


        private void col_order_qty_Leave(object sender, EventArgs e)
        {
            Check_Is_Update_Amt("order_qty");//明細
        }

        private void col_weight_Leave(object sender, EventArgs e)
        {
            Check_Is_Update_Amt("sec_qty");//明細
        }

        private void clPrice_Leave(object sender, EventArgs e)
        {
            Check_Is_Update_Amt("price");//明細
        }

        private void clDisc_rate_Leave(object sender, EventArgs e)
        {
            Check_Is_Update_Amt("disc_rate");//明細
        }

        private void col_unit_code_Leave(object sender, EventArgs e)
        {
            Check_Is_Update_Amt_Unit("unit_code");//明細
        }

        private void col_p_unit_Leave(object sender, EventArgs e)
        {
            Check_Is_Update_Amt_Unit("p_unit");//明細
        }

        private void col_unit_code_sec_Leave(object sender, EventArgs e)
        {
            Check_Is_Update_Amt_Unit("sec_unit");//明細
        }

        

        private void col_fare_qty_Leave(object sender, EventArgs e)
        {
            Check_Is_Update_Amt_Fare("qty");//附加費
        }

        private void col_fare_price_Leave(object sender, EventArgs e)
        {
            Check_Is_Update_Amt_Fare("price");//附加費
        }

        /// <summary>
        /// 是否計算明細當前行金額
        /// </summary>
        /// <param name="column_name"></param>
        private void Check_Is_Update_Amt(string column_name)
        {            
            if (dgvDetails.OptionsBehavior.Editable)
            {
                string ls_column_name = "";
                switch (column_name)
                {
                    case "order_qty":
                        ls_column_name = "order_qty";
                        break;
                    case "sec_qty":
                        ls_column_name = "sec_qty";
                        break;
                    case "price":
                        ls_column_name = "price";
                        break;
                    case "disc_rate":
                        ls_column_name = "disc_rate";
                        break;                   
                    default:
                        break;
                }
                dgvDetails.CloseEditor();
                int cur_row = dgvDetails.FocusedRowHandle;
                decimal ldc_value,ldc_original_value = 0;
                ldc_value = decimal.Parse(dgvDetails.GetRowCellDisplayText(cur_row, ls_column_name));
                if (ldc_value == 0)
                {
                    return;
                }
                
                //取得修改前的原始值               
                DataRow myEditDataRow = dgvDetails.GetDataRow(cur_row);
                if (cur_row >= 0)
                {
                    try
                    {
                        ldc_original_value = decimal.Parse(myEditDataRow[ls_column_name, DataRowVersion.Original].ToString());
                    }
                    catch
                    {
                        ldc_original_value = 0;
                    }
                }
                if (ldc_value != ldc_original_value)
                {
                    Count_Row_Amount_Details();
                }
            }
        }

        /// <summary>
        /// 是否計算明細當前行金額(更改數量單位,重量單位,單價單位)
        /// </summary>
        /// <param name="column_name"></param>
        private void Check_Is_Update_Amt_Unit(string column_name)
        {
            if (dgvDetails.OptionsBehavior.Editable)
            {
                string ls_column_name = "";
                switch (column_name)
                {
                    case "unit_code":
                        ls_column_name = "unit_code";
                        break;
                    case "p_unit":
                        ls_column_name = "p_unit";
                        break;
                    case "sec_unit":
                        ls_column_name = "sec_unit";
                        break;
                    default:
                        break;
                }
                dgvDetails.CloseEditor();
                int cur_row = dgvDetails.FocusedRowHandle;
                string ls_value, ls_original_value = "";
                ls_value = dgvDetails.GetRowCellDisplayText(cur_row, ls_column_name);
                if (ls_value == "")
                {
                    return;
                }
                //取得修改前的原始值
                DataRow myEditDataRow = dgvDetails.GetDataRow(cur_row);
                if (cur_row >= 0)
                {
                    try
                    {
                        ls_original_value = myEditDataRow[ls_column_name, DataRowVersion.Original].ToString();
                    }
                    catch
                    {
                        ls_original_value = "";
                    }
                }
                if (ls_value != ls_original_value)
                {
                    Count_Row_Amount_Details();
                }
            }
        }

        /// <summary>
        /// 是否計算附加費當前行金額
        /// </summary>
        /// <param name="column_name"></param>
        private void Check_Is_Update_Amt_Fare(string column_name)
        {
            if (dgvFare.OptionsBehavior.Editable)
            {
                string ls_column_name = "";
                switch (column_name)
                {
                    case "qty":
                        ls_column_name = "qty";
                        break;
                    case "price":
                        ls_column_name = "price";
                        break;
                    default :
                        break;
                }
                dgvFare.CloseEditor();
                int cur_row = dgvFare.FocusedRowHandle;
                decimal ldc_value, ldc_original_value = 0;
                ldc_value = decimal.Parse(dgvFare.GetRowCellDisplayText(cur_row, ls_column_name));
                if (ldc_value == 0)
                {
                    return;
                }                
                //取得修改前的原始值
                DataRow myEditDataRow = dgvFare.GetDataRow(cur_row);
                if (cur_row >= 0)
                {
                    try
                    {
                        ldc_original_value = decimal.Parse(myEditDataRow[ls_column_name, DataRowVersion.Original].ToString());
                    }
                    catch
                    {
                        ldc_original_value = 0;
                    }
                }
                if (ldc_value != ldc_original_value)
                {
                    Count_Row_Amount_Fare();
                }
            }
        }                     


        /// <summary>
        /// 計算明細當前行金額公式
        /// </summary>
        public void Count_Row_Amount_Details()
        {
            dgvDetails.CloseEditor();//此行重要
            int li_cur_row = dgvDetails.FocusedRowHandle;
            decimal ldc_order_qty = 0, ldc_sec_qty, ldc_price, ldc_disc_rate, ldc_disc_amt = 0, ldc_total_sum = 0;
            string unit_code, sec_unit, p_unit;
            unit_code = dgvDetails.GetRowCellValue(li_cur_row, "unit_code").ToString();
            sec_unit = dgvDetails.GetRowCellValue(li_cur_row, "sec_unit").ToString();
            p_unit = dgvDetails.GetRowCellValue(li_cur_row, "p_unit").ToString();

            if (!string.IsNullOrEmpty(dgvDetails.GetRowCellValue(li_cur_row, "order_qty").ToString()))
            {
                ldc_order_qty = decimal.Parse(dgvDetails.GetRowCellValue(li_cur_row, "order_qty").ToString());
            }
            else
                ldc_order_qty = 0;
            if (!string.IsNullOrEmpty(dgvDetails.GetRowCellValue(li_cur_row, "sec_qty").ToString()))
                ldc_sec_qty = decimal.Parse(dgvDetails.GetRowCellValue(li_cur_row, "sec_qty").ToString());
            else
                ldc_sec_qty = 0;
            if (!string.IsNullOrEmpty(dgvDetails.GetRowCellValue(li_cur_row, "price").ToString()))
                ldc_price = decimal.Parse(dgvDetails.GetRowCellValue(li_cur_row, "price").ToString());
            else
                ldc_price = 0;
            if (!string.IsNullOrEmpty(dgvDetails.GetRowCellValue(li_cur_row, "disc_rate").ToString()))
                ldc_disc_rate = decimal.Parse(dgvDetails.GetRowCellValue(li_cur_row, "disc_rate").ToString());
            else
                ldc_disc_rate = 0;

            //貨品金額是以數量計算或者重量計算是以單價單位為基準,誰的單位與單價單位相等,就用誰乘以單價
            //貨品金額以訂單數量計算
            if (p_unit == unit_code)
                ldc_total_sum = decimal.Parse(Math.Round(ldc_order_qty * ldc_price, 2).ToString());
            else
                ldc_total_sum = 0;
            //貨品金額以重量計算
            if (p_unit == sec_unit)
            {
                ldc_total_sum = ldc_sec_qty * ldc_price;
            }
            if (p_unit != unit_code && p_unit != sec_unit)
            {
                ldc_total_sum = 0;
            }
            ldc_disc_amt = decimal.Parse(Math.Round(ldc_total_sum * (ldc_disc_rate / 100), 2).ToString());
            ldc_total_sum = ldc_total_sum - ldc_disc_amt;
            dgvDetails.SetRowCellValue(li_cur_row, "disc_amt", ldc_disc_amt);
            dgvDetails.SetRowCellValue(li_cur_row, "total_sum", ldc_total_sum);
            Count_Amount();
        }


        /// <summary>
        /// 計算附加費當前行金額公式
        /// </summary>
        public void Count_Row_Amount_Fare()
        {
            dgvFare.CloseEditor();//此行重要
            int li_cur_row = dgvFare.FocusedRowHandle;
            decimal ldc_qty = 0, ldc_price = 0, ldc_fare_sum = 0;
            if (!string.IsNullOrEmpty(dgvFare.GetRowCellValue(li_cur_row, "qty").ToString()))
                ldc_qty = decimal.Parse(dgvFare.GetRowCellValue(li_cur_row, "qty").ToString());
            else
                ldc_qty = 0;
            if (!string.IsNullOrEmpty(dgvFare.GetRowCellValue(li_cur_row, "price").ToString()))
                ldc_price = decimal.Parse(dgvFare.GetRowCellValue(li_cur_row, "price").ToString());
            else
                ldc_price = 0;
            ldc_fare_sum = ldc_qty * ldc_price;
            dgvFare.SetRowCellValue(li_cur_row, "fare_sum", ldc_fare_sum);
            Count_Amount();
        }

        /// <summary>
        /// 計算主檔總金額
        /// </summary>
        public void Count_Amount()
        {
            decimal ldc_total_amount, ldc_goods_amount = 0, ldc_fare_amount = 0, ldc_cur_row_amount, ldc_disc_spare_amount;           
            dgvDetails.CloseEditor();//此行很重要,輸入值立即有較
            dgvFare.CloseEditor();
            int li_currow = 0;
            //貨品金額
            for (int i = 0; i < dgvDetails.RowCount; i++)
            {
                li_currow = dgvDetails.GetRowHandle(i);
                if (!string.IsNullOrEmpty(dgvDetails.GetRowCellValue(li_currow, "total_sum").ToString()))
                    ldc_cur_row_amount = decimal.Parse(dgvDetails.GetRowCellValue(li_currow, "total_sum").ToString());
                else
                    ldc_cur_row_amount = 0;
                ldc_goods_amount = decimal.Parse(Math.Round(ldc_goods_amount + ldc_cur_row_amount, 2).ToString());
            }
            //附加費
            for (int i = 0; i < dgvFare.RowCount; i++)
            {
                li_currow = dgvFare.GetRowHandle(i);
                if (!string.IsNullOrEmpty(dgvFare.GetRowCellValue(li_currow, "fare_sum").ToString()))
                    ldc_cur_row_amount = decimal.Parse(dgvFare.GetRowCellValue(li_currow, "fare_sum").ToString());
                else
                    ldc_cur_row_amount = 0;
                ldc_fare_amount = decimal.Parse(Math.Round(ldc_fare_amount + ldc_cur_row_amount, 2).ToString());
            }
            //折扣后金額
            ldc_disc_spare_amount = ldc_goods_amount;
            ldc_total_amount = ldc_disc_spare_amount + ldc_fare_amount;
            txtpg_sum.Text = ldc_goods_amount.ToString();
            txtdisc_spare.Text = ldc_disc_spare_amount.ToString();
            txttack_fare.Text = ldc_fare_amount.ToString();
            txttotal_sum.Text = ldc_total_amount.ToString();
        }

      

        private void BTNFIND_Click(object sender, EventArgs e)
        {
            mdlPoPurchase lst = new mdlPoPurchase() { 
                id1 = txtid2.Text ,
                id2=txtid2.Text ,
                order_date1 = dtedate1.Text ,
                order_date2 = dtedate2.Text,
                vendor_id1 = luevendor_id1.Text,
                vendor_id2 = luevendor_id2.Text,
                dept_id1 = luedept_id1.Text,
                dept_id2 = luedept_id2.Text,
                buyer_id1 = txtbuyer_id1.Text ,
                buyer_id2 = txtbuyer_id2.Text
            };
            DataTable dtFind = clsPoPurchase.Get_Pur_Data(lst);
            dgvFind.DataSource = dtFind;
            if (dtFind.Rows.Count == 0)
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_no_data"),"System Info");
            }
       }            
       
        private void col_fare_id_EditValueChanged(object sender, EventArgs e)
        {
            LookUpEdit objItem = (LookUpEdit)sender;
            string ls_fare_id = objItem.Text;
            int indexSelect = col_fare_id.GetDataSourceRowIndex("id", ls_fare_id);
            string ls_name = col_fare_id.GetDataSourceValue("name", indexSelect).ToString();
            dgvFare.SetRowCellValue(dgvFare.FocusedRowHandle, "name", ls_name);

        }

        /// <summary>
        /// 雙擊打開編輯窗體
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDetails_MouseDown(object sender, MouseEventArgs e)
        {           
            if (e.Button == MouseButtons.Left && e.Clicks == 2) // 判断是否是用鼠标双击    
            {
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo ghi = dgvDetails.CalcHitInfo(new Point(e.X, e.Y));
                if (ghi.InRow)  // 判断光标是否在行内    
                {
                    if (!is_open_flag)//避免重復打開
                    {
                        Open_Edit_Form(dgvDetails, "dgvDetails");
                        is_open_flag = false;
                    }                       
                }
            }
        }

        private void dgvDetails_DoubleClick(object sender, EventArgs e)
        {
            //is_open_flag = true;
            //gridControl1.Focus();            
            //Open_Edit_Form(dgvDetails, "dgvDetails");
        }

        private void Open_Edit_Form(DevExpress.XtraGrid.Views.Grid.GridView objView, string ls_type)
        {
            if (objView.RowCount > 0)
            {
                if (ls_type == "dgvDetails")
                {
                    using (frmPoPurchaseBillEdit ofrm = new frmPoPurchaseBillEdit(this,m_state,txtID.Text,txtVer.Text))
                    {
                        ofrm.ShowDialog();
                    }
                }
                else
                {
                    using (frmPoPurchaseBillEditFare ofrm = new frmPoPurchaseBillEditFare(this, m_state, txtID.Text, txtVer.Text))
                    {
                        ofrm.ShowDialog();
                    }
                }
            }
        }

        private void BTNCARD_Click(object sender, EventArgs e)
        {
            Display_Format();
        }

        private void Display_Format()
        {
            if (m_got_focus_gridview == "dgvDetails")
            {
                Open_Edit_Form(dgvDetails, "dgvDetails"); //明細
                return;
            }
            if (m_got_focus_gridview == "dgvFare")
            {
                Open_Edit_Form(dgvFare, "dgvFare");//附加費
            }
        }   

        private void gridControl2_Click(object sender, EventArgs e)
        {
            m_got_focus_gridview = "dgvFare";
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            m_got_focus_gridview = "dgvDetails";
        }

        private void dgvFare_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && e.Clicks == 2) // 判断是否是用鼠标双击    
            {
                DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo ghi = dgvFare.CalcHitInfo(new Point(e.X, e.Y));
                if (ghi.InRow)  // 判断光标是否在行内    
                {
                    if (!is_open_flag)//避免重復打開
                    {
                        Open_Edit_Form(dgvFare, "dgvFare");
                        is_open_flag = false;
                    }
                }
            }
        }
        
        private void dgvFind_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFind.Rows.Count > 0 && m_state=="")
            {
                int li_ver = int.Parse(dgvFind.CurrentRow.Cells["ver1"].Value.ToString());                
                Find_Doc( dgvFind.CurrentRow.Cells["id1"].Value.ToString(), li_ver);
            }
        }

        private void dgvFind_DoubleClick(object sender, EventArgs e)
        {
            tabPoPurchase.SelectedIndex = 0;
        }

        private void BTNPRINT_Click(object sender, EventArgs e)
        {
            Print();            
        }
     
        private void Print() //通用的打印方法
        {
            //if (dgvDetails.RowCount > 0)
            //{
            //    PrintDGV.Print_DataGridView(this.dgvDetails);
            //}            
            if (dgvDetails.RowCount== 0)
            {
                return;               
            }
            DataTable dt = clsPoPurchase.Get_Print_Data(txtID.Text);                 
            dt.Columns.Add("no", typeof(Int32));
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["no"] = i + 1;
            }
            
            xrPoPurchaseBill xr = new xrPoPurchaseBill() { DataSource = dt };
            xr.CreateDocument();
            xr.PrintingSystem.ShowMarginsWarning = false;
            xr.ShowPreviewDialog();

           

            /*
             //Fastreport.net           
            using (FastReport.Report report = new FastReport.Report())
            {
                string file = System.Windows.Forms.Application.StartupPath;
                file += "\\Reports\\PurchaseBill2.frx";
                if (!System.IO.File.Exists(file))
                {
                    MessageBox.Show(string.Format("The Report file [{0}] does not exists.",file), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                //file="C:\\CFVN\\CFVN\\Reports\\frxCountry.frx";
                report.Load(file);
                //传递数据
                //report.RegisterData((DataTable)dgvDetails.DataSource, "myCountry"); 
                report.RegisterData(dt, "myPurchaseBill"); 
                report.Show();
                ////静默打印
                //report.PrintSettings.ShowDialog = false;
                //report.Print();

            }
            */
        }

        private void BTNNEWVER_Click(object sender, EventArgs e)
        {
            NewVersion();
        }

        private void NewVersion()
        {
            if(dgvDetails.RowCount==0)
            {
                return ;
            }
            //未批準
            if (luestate.EditValue.ToString() == "0")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_can_be_make_new_version"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            //收貨完成
            if (luestate.EditValue.ToString() == "9")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_can_be_make_new_version"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            // 是否已有收貨,一但有收貨,不允許做新版本
            if (!clsPoPurchase.Check_Is_New_Version(txtID.Text, int.Parse(txtVer.Text)))
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_can_be_make_new_version"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            //是否產生新版本
            if (MessageBox.Show(clsCommon.GetTitle("t_msg_make_new_version"), myMsg.msgTitle, MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No)
            {
                return;
            }

            //做新版本
            SqlParameter[] paras = new SqlParameter[]
            {
                new SqlParameter("@id",txtID.Text),
                new SqlParameter("@ver",int.Parse(txtVer.Text)),
                new SqlParameter("@new_ver",int.Parse(txtVer.Text)+1),
                new SqlParameter("@user_id",DBUtility._user_id)
            };
            if (clsApp.ExecuteNonQuery("usp_po_buy_new_version", paras, true) > 0)
            {
                Find_Doc(txtID.Text, int.Parse(txtVer.Text) + 1);
                MessageBox.Show(clsCommon.GetTitle("t_msg_new_version_successful"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_new_version_failed"), myMsg.msgTitle, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dgvDetails_ShownEditor(object sender, EventArgs e)
        {
            m_got_focus_gridview = "dgvDetails";
            myDoubleClick(sender);           
        }

        private void dgvFare_ShownEditor(object sender, EventArgs e)
        {
            m_got_focus_gridview = "dgvFare";
            myDoubleClick(sender);            
        }

        private void myDoubleClick(object obj)
        {
            DevExpress.XtraGrid.Views.Grid.GridView view = obj as DevExpress.XtraGrid.Views.Grid.GridView;
            view.ActiveEditor.DoubleClick += new EventHandler(ActiveEditor_DoubleClick);
        }

        private void ActiveEditor_DoubleClick(object sender, System.EventArgs e)
        {            
            Display_Format();
        }
        
    }

    
}
