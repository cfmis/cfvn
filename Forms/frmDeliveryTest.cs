//***********************************
//设计Allen Leung(梁家相)
//2018-08-03
//区域代码查
//模糊查询或者从下拉列表中逐级查询
//***********************************
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraGrid.Views.Base;
using cftest.CLS;
using WeifenLuo.WinFormsUI.Docking;
using DevExpress.XtraEditors;
using SysDaan.CLS;
using SysDaan.Forms;
using cf01.CLS;
using SysDaan.Reports;
//using cf01.Reports;


namespace cftest.Forms
{
	public partial class frmDeliveryTest : DockContent
	{
        private clsPublicOfPad clsConPad = new clsPublicOfPad();
        public clsAppPublic clsPub = new clsAppPublic();
        clsToolBar objToolbar;
		public string mID = "";    //臨時的主鍵值
		public string mState = ""; //新增或編輯的狀態
		public static string str_language = "0";		
		public bool save_flag;       

		DataTable dtMostly = new DataTable();
		DataTable dtDetails = new DataTable();       
		DataTable dtTempDel = new DataTable();
        DataTable dtFind_Date = new DataTable();

        public BindingSource myBDS1 = new BindingSource();
        public static BindingSource myBDS2 = new BindingSource();

        //private List<custom_delivry_details> lsModel = new List<custom_delivry_details>();

        public frmDeliveryTest()
		{
			InitializeComponent();
            
            //權限
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.SetToolBar();

            //str_language = DBUtility._language;
            //NextControl oNext = new NextControl(this, "2");
            //oNext.EnterToTab();
		}

		private void frmDeliveryTest_Load(object sender, EventArgs e)
		{
            const string sql_h = @"SELECT * From dbo.delivery_mostly Where 1=0 ";
            dtMostly=clsConPad.GetDataTable(sql_h);            
            myBDS1.DataSource = dtMostly;
            try
            {
                //數據綁定主档
                txtID.DataBindings.Add("Text", myBDS1, "id");
                dtDelivery_date.DataBindings.Add("EditValue", myBDS1, "delivery_date");
                txtcustomer_name.DataBindings.Add("Text", myBDS1, "customer_name");
                txtcustomer_address.DataBindings.Add("Text", myBDS1, "customer_address");
                txtcompany_id.DataBindings.Add("EditValue", myBDS1, "company_id"); // 绑定需是EditValue，否则将显示长日期格式
                txtserial_no.DataBindings.Add("Text", myBDS1, "serial_no");
                txtserial_name.DataBindings.Add("Text", myBDS1, "serial_name");
                txtamt_sum.DataBindings.Add("Text", myBDS1, "amt_sum");
                txtcontact.DataBindings.Add("Text", myBDS1, "contact");
                txtcustomer_tel.DataBindings.Add("Text", myBDS1, "customer_tel");
                txtcustomer_fax.DataBindings.Add("Text", myBDS1, "customer_fax");

                txtState.DataBindings.Add("Text", myBDS1, "state");
                txtremark.DataBindings.Add("Text", myBDS1, "remark");
                txtCreate_by.DataBindings.Add("Text", myBDS1, "create_by");
                txtCreate_date.DataBindings.Add("Text", myBDS1, "create_date");
                txtupdate_by.DataBindings.Add("Text", myBDS1, "update_by");
                txtupdate_date.DataBindings.Add("Text", myBDS1, "update_date");
               

                //生成明細表結構
                const string sql_d = @"Select * From dbo.delivery_details Where 1=0";
                dtDetails = clsConPad.GetDataTable(sql_d);
                myBDS2.DataSource = dtDetails;
                gridControl1.DataSource = myBDS2;
            }
            catch (Exception E)
            {                
                throw new Exception(E.Message);
            }

            //公司资料
            DataTable dtCompany = clsConPad.GetDataTable(@"Select '' as id,'' as name UNION SELECT id,id+'('+name+')' as name From dbo.cd_company Order By id");
            txtcompany_id.Properties.DataSource = dtCompany;
            txtcompany_id.Properties.ValueMember = "id";
            txtcompany_id.Properties.DisplayMember = "name";

            lkecompany_id1.Properties.DataSource = dtCompany;
            lkecompany_id1.Properties.ValueMember = "id";
            lkecompany_id1.Properties.DisplayMember = "name";

            lkecompany_id2.Properties.DataSource = dtCompany;
            lkecompany_id2.Properties.ValueMember = "id";
            lkecompany_id2.Properties.DisplayMember = "name";  

			           
			//臨時項目刪除表結構
			dtTempDel = dtDetails.Clone();
 
            //欄位表頭居中
            for (int i = 0; i < dgvDetails.Columns.Count; i++)
            {
                dgvDetails.Columns[i].AppearanceHeader.TextOptions.HAlignment=DevExpress.Utils.HorzAlignment.Center;
            }
            //txtDat1.EditValue = DateTime.Now.ToString("yyyy-MM-dd");
            //txtDat2.EditValue = DateTime.Now.ToString("yyyy-MM-dd");

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

		private void BTNDELETE_Click(object sender, EventArgs e)
		{
			Delete();//刪除主檔資料
		}

		private void BTNITEMADD_Click(object sender, EventArgs e)
		{
			AddNew_Item();
		}

		private void BTNITEMDEL_Click(object sender, EventArgs e)
		{
			if (dgvDetails.RowCount == 0)
			{
				return;
			}
			DialogResult result = MessageBox.Show("是否刪除当前明细资料?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
				int curRow = dgvDetails.FocusedRowHandle;
				//將當前行刪除幷加到臨時表中
				DataRow newRow = dtTempDel.NewRow();
				newRow["id"] = txtID.Text;
                newRow["sequence_id"] = dgvDetails.GetRowCellDisplayText(curRow, "sequence_id");
				dtTempDel.Rows.Add(newRow);
				dgvDetails.DeleteRow(curRow);//移走當前行
			}
		}

		private void BTNSAVE_Click(object sender, EventArgs e)
		{
			//txtRemark.Focus();//Toolscript焦點問題
			Save();
		}

		private void BTNCANCEL_Click(object sender, EventArgs e)
		{
			Cancel();
		}

		private void BTNPRINT_Click(object sender, EventArgs e)
		{
            Print();
		}	

		private void AddNew()  //新增
		{
			mState = "NEW";
            myBDS1.AddNew();
           
			txtID.Focus();
			SetButtonSatus(false);
            Set_Grid_Status(true);

            SetObjValue.SetEditBackColor(panel1.Controls, true);
            SetObjValue.ClearObjValue(panel1.Controls, "1"); 
            //DataRow dr = dtMostly.NewRow(); //插一空行
            //dtMostly.Rows.InsertAt(dr, 0);              
            txtID.Text = clsConPad.ExecuteSqlReturnObject(@"Select dbo.fn_get_max_no('T') AS max_no");
            //GetID_No();           
            txtID.Properties.ReadOnly = true;
            txtID.BackColor = Color.White;

            txtremark.Text = "";
            txtState.Text = "0";
            dtDelivery_date.EditValue = DateTime.Now.Date.ToString("yyyy-MM-dd").Substring(0, 10);                    

			dtDetails.Clear();
			gridControl1.DataSource = myBDS2;
            tabControl1.SelectTab(0);//跳至第一頁             
		}

		private void Edit()  //編輯
		{
			if (txtID.Text == "")
			{
				return;
			}
            if (!clsCommon.Is_Allow_Edit_Data("T", dtDelivery_date.Text))
            {
                MessageBox.Show("已超过修改数据的期限！","提示信息");
                return;
            }

            SetButtonSatus(false);			
			//SetObjValue.SetEditBackColor(this.Controls, true);
            SetObjValue.SetEditBackColor(tabPage1.Controls, true);
			Set_Grid_Status(true);
			mState = "EDIT";

			//txtID.Properties.ReadOnly = true;
            txtID.Properties.ReadOnly = true;
			txtID.BackColor = Color.White;
            //txtserial_no.Properties.ReadOnly = true;
            //txtserial_no.BackColor = Color.White;
            //chkIs_large.Properties.ReadOnly = true;
            //chkIs_large.BackColor = Color.White;
            
            tabControl1.SelectTab(0);//跳至第一頁
		}
    
		private void SetButtonSatus(bool _flag) //設置工具欄
		{
			BTNNEW.Enabled = _flag;
			BTNEDIT.Enabled = _flag;
			BTNPRINT.Enabled = _flag;
			BTNDELETE.Enabled = _flag;
			BTNSAVE.Enabled = !_flag;
			BTNCANCEL.Enabled = !_flag;
			BTNITEMADD.Enabled = !_flag;
			BTNITEMDEL.Enabled = !_flag;

            if (objToolbar != null)
            {
                objToolbar.SetToolBar();
            }
		}

		private void Set_Grid_Status(bool _flag) // 表格可編號否
		{
			//false--不可編輯;true--可以編輯
			dgvDetails.OptionsBehavior.Editable = _flag;			                   
		}

		private void Delete() //刪除當前行
		{
			if (String.IsNullOrEmpty(txtID.EditValue.ToString()))
			{
				return;
			}           
			DialogResult result = MessageBox.Show("此操作将刪除主表及明细中的资料,请谨慎操作!", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
                const string sql_del = @"Update dbo.delivery_mostly Set state='2' WHERE id=@id";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);//改回直接操作GEO
				myCon.Open();
				SqlTransaction myTrans = myCon.BeginTransaction();
				using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
				{
					try
					{
						myCommand.CommandText = sql_del;//刪除主檔
						myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@id", txtID.Text);
						myCommand.ExecuteNonQuery();

						myTrans.Commit(); //數據提交                        
						MessageBox.Show("数据刪除成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
						SetObjValue.ClearObjValue(tabPage1.Controls, "1");
						dtDetails.Clear();
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

        /// <summary>
        /// 添加明細表新行
        /// </summary>
		private void AddNew_Item()
		{
            if (!String.IsNullOrEmpty(txtID.Text)) // 有內容
			{
                if (txtID.Text == "" || txtserial_no.Text == "")
                {
                    MessageBox.Show("物流公司代码或者目的地区域代码不可为空!", "提示信息"); 
                    txtID.Focus();
                    return;
                }                
                if (!Check_Details_Valid())
                {
                    return;
                }
				Set_Grid_Status(true);
                //SetObjValue.SetEditBackColor(tabPage1.Controls, true);
                myBDS2.AddNew();
                //dgvDetails.AddNewRow();//新增
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "id", txtID.Text);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "sequence_id", (dgvDetails.RowCount).ToString("000"));
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "is_large", false);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "goods_id","");
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "sec_qty", 0.00);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_total",0.00);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_other", 0.00);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "remark","");

				ColumnView view = (ColumnView)dgvDetails;//初始單元格焦點
                view.FocusedColumn = view.Columns["goods_id"];
				view.Focus();
                view.ShowEditor();
			}
			else
			{
				MessageBox.Show("单据编号不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
			}
		}

		private bool Check_Details_Valid() //檢查明細資料的有效性
		{
			//測試項目必須有輸入
			bool _flag = true ;
            if (dgvDetails.RowCount > 0)
            {
                //txtRemark.Focus();
                //因toolStrip控件焦點問題
                //設置焦點行某單元格獲得焦點，加此代碼目的使輸入的值生效，防止取到的值爲空
                ColumnView view = (ColumnView)dgvDetails;
                int curRow = 0;
                for (int i = 0; i < dgvDetails.RowCount; i++)
                {
                    curRow = dgvDetails.GetRowHandle(i);
                    if (String.IsNullOrEmpty(dgvDetails.GetRowCellDisplayText(curRow, "goods_id")))
                    {
                        _flag = false;
                        dgvDetails.FocusedRowHandle = curRow;//定位到当前行
                        MessageBox.Show("寄件货物名称不可以为空!", "提示信息");                        
                        view = (ColumnView)dgvDetails;
                        view.FocusedColumn = view.Columns["goods_id"]; //設置單元格焦點
                        view.Focus();
                        view.ShowEditor();
                        break;
                    }
                    if (clsPub.Return_Float_Value(dgvDetails.GetRowCellDisplayText(curRow, "sec_qty")) <= 0)
                    {
                        _flag = false;
                        dgvDetails.FocusedRowHandle = curRow;
                        MessageBox.Show("货品重量必须是大于0的值 !", "提示信息");
                        view = (ColumnView)dgvDetails;
                        view.FocusedColumn = view.Columns["sec_qty"]; //設置單元格焦點
                        view.Focus();
                        view.ShowEditor();
                        break;
                    }
                }
            }           
			return _flag;
		}

		private void Cancel() //取消
		{
            myBDS1.CancelEdit();
            myBDS2.CancelEdit();
            SetButtonSatus(true);			
            SetObjValue.SetEditBackColor(tabPage1.Controls, false);
            SetObjValue.ClearObjValue(tabPage1.Controls, "2");
			Set_Grid_Status(false);
            txtID.Properties.ReadOnly = true;
			dtTempDel.Clear();
			dtDetails.Clear();
			gridControl1.DataSource = dtDetails;
           
			mState = "";			
			if (!String.IsNullOrEmpty(mID))
			{
				Find_doc(mID);
			}
		}

		private void Find_doc(string temp_id) //主檔非新增的情況下，保存或取消時重新查出資料
		{
			if (!String.IsNullOrEmpty(temp_id))
			{
                string sql_h = String.Format(@"Select * FROM dbo.delivery_mostly with(nolock) Where id ='{0}' AND state <>'2'", temp_id);
                dtMostly = clsConPad.GetDataTable(sql_h);
                string sql_d = String.Format(@"Select * From dbo.delivery_details with(nolock) Where id='{0}'", temp_id);                
                dtDetails = clsConPad.GetDataTable(sql_d);
                if (dtMostly.Rows.Count > 0)
                {
                    myBDS1.DataSource = dtMostly;                    
                }
                else
                {
                    //清空数据
                    dtDetails.Clear();
                    myBDS2.DataSource = dtDetails;
                    SetObjValue.ClearObjValue(tabPage1.Controls, "2");
                    return;
                }
				dtDetails.Clear();
                dtDetails = clsConPad.GetDataTable(sql_d);                             
                myBDS2.DataSource = dtDetails;
                gridControl1.DataSource = myBDS2;                
                //设置时间格式
                //txtlicence_valid_date.EditValue = clsPub.Return_String_Date(txtlicence_valid_date.EditValue.ToString());              
				mID = txtID.EditValue.ToString();//保存臨時的ID號                
			}
		}

		private void Save()  //保存
		{
            txtremark.Focus();
            if (!Save_Before_Valid())
			{
				return;
			}
            if (dgvDetails.RowCount == 0)
            {
                MessageBox.Show("表格明细资料不可为空 !", "提示信息");
                return;
            }
			if (!Check_Details_Valid())//检查明细资料的有效性
			{
				return;
			}

			save_flag = false;
            myBDS1.EndEdit();
            myBDS2.EndEdit();
            dgvDetails.CloseEditor();

			#region  保存新增或編輯
            if (mState == "NEW" || mState == "EDIT")
			{
                string strSql;
                if (mState == "NEW")
                {
                    strSql = String.Format("Select '1' FROM dbo.delivery_mostly WHERE id='{0}'", txtID.Text);
                    if (clsConPad.ExecuteSqlReturnObject(strSql) != "")
                    {
                        //MessageBox.Show(string.Format("此公司数据[{0}]已存在!", txtID.EditValue));
                        //return;
                        //如已存在編號則重取最大單據編號
                        //GetID_No();
                        txtID.Text = clsConPad.ExecuteSqlReturnObject(@"Select dbo.fn_get_max_no('T') AS max_no");
                    }                    
                    clsConPad.ExecuteSqlUpdate(@"EXECUTE usp_set_max_no 'T'"); //更新最大单据号加1                                      
                }
                if (txtcustomer_address.Text != "")
                {
                    strSql = string.Format(@"EXECUTE usp_update_address_history '{0}','{1}','{2}','{3}'", txtcompany_id.EditValue, txtcustomer_address.Text, txtserial_no.Text, txtserial_name.Text);
                    clsConPad.ExecuteSqlUpdate(strSql); //更新客户地址区域对照表  
                }

                const string sql_i =
                @"INSERT INTO dbo.delivery_mostly(id,delivery_date,customer_name,customer_address,contact,customer_tel,
                 customer_fax,company_id,serial_no,serial_name,amt_sum,remark,state,create_by,create_date) VALUES 
                 (@id,@delivery_date,@customer_name,@customer_address,@contact,@customer_tel,@customer_fax,
                  @company_id,@serial_no,@serial_name,@amt_sum,@remark,@state,@user_id,getdate())";
                const string sql_u =
                @"Update dbo.delivery_mostly SET delivery_date=@delivery_date,customer_name=@customer_name,customer_address=@customer_address,
                  contact=@contact,customer_tel=@customer_tel,customer_fax=@customer_fax,company_id=@company_id,serial_no=@serial_no,
                  serial_name=@serial_name,amt_sum=@amt_sum,remark=@remark,state=@state,update_by=@user_id,update_date=getdate() 
                  WHERE id=@id";
                
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString); //改爲CF01
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
						myCommand.Parameters.AddWithValue("@id", txtID.Text);                        
                        myCommand.Parameters.AddWithValue("@delivery_date", clsPub.Return_String_Date(dtDelivery_date.Text));
                        myCommand.Parameters.AddWithValue("@customer_name", txtcustomer_name.Text);
                        myCommand.Parameters.AddWithValue("@customer_address", txtcustomer_address.Text);
                        myCommand.Parameters.AddWithValue("@contact", txtcontact.Text);
                        myCommand.Parameters.AddWithValue("@customer_tel", txtcustomer_tel.Text);
                        myCommand.Parameters.AddWithValue("@customer_fax", txtcustomer_fax.Text);
                        myCommand.Parameters.AddWithValue("@company_id", txtcompany_id.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@serial_no", txtserial_no.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@serial_name", txtserial_name.Text);
                        myCommand.Parameters.AddWithValue("@amt_sum", clsPub.Return_Float_Value(txtamt_sum.Text));                                             
                        myCommand.Parameters.AddWithValue("@remark", txtremark.Text);
                        myCommand.Parameters.AddWithValue("@state", "0");                  
                        myCommand.Parameters.AddWithValue("@user_id", DBUtility._user_id);                                       
						myCommand.ExecuteNonQuery();                 

                        //處理【項目刪除】刪除明細資料
                        bool is_large;                      
                        string sql_item_d;
                        for (int i = 0; i < dtTempDel.Rows.Count; i++)
                        {
                            //刪除明細                           
                            sql_item_d = @"DELETE FROM dbo.delivery_details WHERE id=@id and sequence_id=@sequence_id";
                            myCommand.CommandText = sql_item_d;
                            myCommand.Parameters.Clear();
                            myCommand.Parameters.AddWithValue("@id", txtID.Text );
                            myCommand.Parameters.AddWithValue("@sequence_id", dtTempDel.Rows[i]["sequence_id"].ToString());
                        
                            myCommand.ExecuteNonQuery();
                        }
                        
                        //保存明細
                        int curRow;
                        string rowStatus;
						if (dgvDetails.RowCount > 0)
						{							
                            const string sql_item_i =
                                @"INSERT INTO dbo.delivery_details
                                (id,sequence_id,is_large,goods_id,sec_qty,amt_total,amt_other,rmk) values(@id,@sequence_id,@is_large,@goods_id,@sec_qty,@amt_total,@amt_other,@rmk)";
                            const string sql_item_u =
                                @"Update dbo.delivery_details 
                                SET is_large=@is_large,goods_id=@goods_id,sec_qty=@sec_qty,amt_total=@amt_total,amt_other=@amt_other,rmk=@rmk 
                                Where id=@id AND sequence_id=@sequence_id";                          
                            
                            for (int i = 0; i < dgvDetails.RowCount; i++)
							{
                                curRow = dgvDetails.GetRowHandle(i);
                                //dgvDetails.AddNewRow();//新增必須初始貨當前單元格焦點
                                //否則rowStatus取不到狀態值
                                rowStatus = dgvDetails.GetDataRow(curRow).RowState.ToString();
                                if (rowStatus == "Added" || rowStatus == "Modified")
                                {
                                    myCommand.Parameters.Clear();
                                    if (rowStatus == "Added")
                                    {
                                        myCommand.CommandText = sql_item_i;                                    
                                    }
                                    else
                                    {
                                        myCommand.CommandText = sql_item_u;                              
                                    }
                                    myCommand.Parameters.AddWithValue("@id", txtID.Text);                                    
                                    myCommand.Parameters.AddWithValue("@sequence_id", dgvDetails.GetRowCellValue(curRow, "sequence_id").ToString());                                                                      
                                    if (dgvDetails.GetRowCellValue(curRow, "is_large").ToString() == "True")
                                    {
                                        is_large = true;
                                    }
                                    else
                                    {
                                        is_large = false;
                                    }
                                    myCommand.Parameters.AddWithValue("@is_large", is_large);
                                    myCommand.Parameters.AddWithValue("@goods_id", dgvDetails.GetRowCellValue(curRow, "goods_id").ToString());
                                    myCommand.Parameters.AddWithValue("@sec_qty", clsPub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "sec_qty").ToString()));
                                    myCommand.Parameters.AddWithValue("@amt_total", clsPub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_total").ToString()));
                                    myCommand.Parameters.AddWithValue("@amt_other", clsPub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_other").ToString()));
                                    myCommand.Parameters.AddWithValue("@rmk", dgvDetails.GetRowCellValue(curRow, "rmk").ToString());                                   
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
			SetObjValue.SetEditBackColor(tabPage1.Controls, false);
			Set_Grid_Status(false);
            txtID.Properties.ReadOnly = true;
			mState = "";			
			dtTempDel.Clear();
           
			if (save_flag)
			{
				Find_doc(txtID.Text);                
				MessageBox.Show("当前数据保存成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
                MessageBox.Show("当前数据保存失败!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}  

		private bool Save_Before_Valid() //保存前檢查主檔資料有效性
		{
            if (txtID.Text == "" || txtcompany_id.Text=="" || txtserial_no.Text =="")
            {
                MessageBox.Show("单据编号、公司编号、目的地代码区域不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                if (txtID.Text == "")
                {
                    txtID.Focus();                    
                }
                if (txtcompany_id.Text == "")
                {
                    txtcompany_id.Focus();
                }
                if (txtserial_no.Text == "")
                {
                    txtserial_no.Focus();
                }
                return false;
            }
            else
            {
                return true;
            }
		}

        //public static string Get_Details_Seq(string _id) //取明細最大序號
        //{
        //    DataTable dtMaxseq = new DataTable();
        //    //dtMaxseq = clsPublicOfCF01.GetDataTable(String.Format("SELECT MAX(sequence_id) as seq_id FROM dbo.custom_delivery_details with(nolock) WHERE id ='{0}'", _id));

        //    string strSeq;
        //    if (String.IsNullOrEmpty(dtMaxseq.Rows[0]["seq_id"].ToString()))
        //    {
        //        strSeq = "0001h";
        //    }
        //    else
        //    {
        //        strSeq = dtMaxseq.Rows[0]["seq_id"].ToString();
        //        strSeq = strSeq.Substring(0, 4);
        //        strSeq = (Convert.ToInt32(strSeq) + 1).ToString("0000")+"h";
        //    }
        //    dtMaxseq.Dispose();
        //    return strSeq;
        //}
   

		private void txtID_Leave(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txtID.Text))
			{
				if (mState == "") //流覽模式
				{
                    Find_doc(txtID.Text);
				}
			}
		}

        private void frmDeliveryTest_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtMostly.Dispose();
            dtDetails.Dispose();
            dtTempDel.Dispose();
            dtFind_Date.Dispose();
            myBDS1.Dispose();
            myBDS2.Dispose();
            //System.GC.Collect();
        }

        private void dgvDetails_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
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

        private void dgvDetails_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator && e.RowHandle >= 0)
            {
                e.Info.DisplayText = (e.RowHandle + 1).ToString();
            }
        }
       
       
        //東莞D送貨單查詢 ==============BEGIN==============
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (mState != "")
            {
                return;
            }
            Find_Date(); 
        }

        private void Find_Date()
        {
            if (BTNCANCEL.Enabled)
            {
                Cancel();
                tabControl1.SelectTab(1);
            }
            //if (txtvendor_id1.Text =="" &&txtvendor_id2.Text=="")
            //{
            //    MessageBox.Show("查询条件不可以为空!", "提示信息");
            //    return;
            //}
            string sql =
            @"Select A.id,A.delivery_date,A.customer_name,A.customer_address,A.company_id,C.name as company_name,A.serial_no,A.serial_name,A.amt_sum,
            A.contact,A.customer_tel,A.remark,B.sequence_id,B.is_large,B.goods_id,B.sec_qty,B.amt_total,B.amt_other,B.rmk
            FROM dbo.delivery_mostly A with(nolock) 
            INNER JOIN dbo.delivery_details B with(nolock) ON A.id = B.id
            INNER JOIN cd_company C ON A.company_id = C.id
            WHERE 1=1 ";
            if (lkecompany_id1.Text != "")
            {
                sql += string.Format(" AND A.company_id>='{0}'", lkecompany_id1.EditValue);
            }
            if (lkecompany_id2.Text != "")
            {
                sql += string.Format(" AND A.company_id<='{0}'", lkecompany_id2.EditValue);
            }
            if (dtDate1.Text != "")
            {
                sql += string.Format(" AND A.delivery_date>='{0}'", clsPub.Return_String_Date(dtDate1.Text));
            }
            if (dtDate2.Text != "")
            {
                sql += string.Format(" AND A.delivery_date<='{0}'", clsPub.Return_String_Date(dtDate2.Text));
            }

            sql += " and A.state<>'2' ";
            sql += " ORDER BY A.id,A.serial_no";
         
            dtFind_Date = clsConPad.GetDataTable(sql);
            dgvFind.DataSource = dtFind_Date;
            if (dtFind_Date.Rows.Count == 0)
            {
                MessageBox.Show("沒有满足查询条件的数据!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dgvFind_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvFind.RowCount > 0)
            {                
                if (txtID.Text != dgvFind.Rows[dgvFind.CurrentCell.RowIndex].Cells["id"].Value.ToString())
                {
                    txtID.Text = dgvFind.Rows[dgvFind.CurrentCell.RowIndex].Cells["id"].Value.ToString();
                    Find_doc(txtID.Text);
                }
            }
        }

        private void dgvFind_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strName = dgvFind.Columns[e.ColumnIndex].Name;
            if (strName == "id")
            {                
                tabControl1.SelectTab(0);
            }
        }

        private void lkecompany_id1_Leave(object sender, EventArgs e)
        {
            lkecompany_id2.EditValue = lkecompany_id1.EditValue;
        }
               

        private void Print()
        {
            if (dgvDetails.RowCount == 0)
            {
                MessageBox.Show("沒有要列印的數據!", "提示信息");
                return;
            }
            string strSql =
            @"Select A.id,convert(varchar(10),A.delivery_date,120) as delivery_date,A.customer_name,A.customer_address,
            A.contact,A.customer_tel,A.remark,B.sequence_id,B.goods_id,B.sec_qty,B.rmk
            From dbo.delivery_mostly A with(nolock),dbo.delivery_details B with(nolock)
            WHERE A.id=B.id ";
            strSql += String.Format(" And A.id='{0}' Order by A.id,B.sequence_id", txtID.Text);
            DataTable dtReprot = clsConPad.GetDataTable(strSql);
            using (xrDelivery objRpt = new xrDelivery() { DataSource = dtReprot })
            {
                objRpt.CreateDocument();
                objRpt.PrintingSystem.ShowMarginsWarning = false;
                objRpt.ShowPreviewDialog();
            }
        }        
     
        private void dgvDetails_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }    

        private void txtserial_no_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (mState == "NEW" || mState == "EDIT")
            {
                using (frmCode ofrmFind = new frmCode())
                {
                    ofrmFind.ShowDialog();
                    if (ofrmFind.strCityCode != "")
                    {
                        txtserial_no.Text = ofrmFind.strCityCode;
                        txtserial_name.Text = ofrmFind.strCityName;
                    }
                }
            }
        }

        private void txtserial_no_Leave(object sender, EventArgs e)
        {
            if (txtserial_no.Text == "")
            {
                txtserial_name.Text = "";
                return;
            }
            if (mState == "NEW" || mState == "EDIT")
            {
                clsCityCode obj = new clsCityCode();
                string strSerial_name = obj.Get_City_Name(txtserial_no.Text);                
                if (strSerial_name != "")
                {
                    txtserial_name.Text = strSerial_name;
                    if (dgvDetails.RowCount > 0)
                    {
                        Set_cost_price();
                        Count_Head_Cost();
                    }
                }
                else
                {
                    txtserial_name.Text = "";
                    txtamt_sum.Text = "";
                    MessageBox.Show("区域代码不存在！", "提示信息");
                    txtserial_no.Focus();
                }

            }
        }

        private void dtDate1_Leave(object sender, EventArgs e)
        {
            dtDate2.EditValue = dtDate1.EditValue;
        }
       
        private void clChkIsBig_CheckedChanged(object sender, EventArgs e)
        {
            if (mState == "")
            {
                return;
            }
            Set_cost_price();
            Count_Head_Cost();
        }

        private void clSec_qty_Leave(object sender, EventArgs e)
        {
            if (mState == "")
            {
                return;
            }
            Set_cost_price();
            Count_Head_Cost(); 
        }

        private void clAmtother_Leave(object sender, EventArgs e)
        {
            if (mState != "")
            {
                Count_Head_Cost();
            }
        }

        /// <summary>
        /// 计算当前行的成本单价
        /// </summary>
        void Set_cost_price()
        {
            dgvDetails.CloseEditor();
            int cur_row = dgvDetails.FocusedRowHandle;
            float fltSec_qty = clsPub.Return_Float_Value(dgvDetails.GetRowCellDisplayText(cur_row, "sec_qty"));
            string is_large;
            if (dgvDetails.GetRowCellValue(cur_row, "is_large").ToString() == "True")
            {
                is_large = "1";
            }
            else
            {
                is_large = "0";
            }

            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@company_id",txtcompany_id.EditValue.ToString()),
                new SqlParameter("@serial_no",txtserial_no.Text),
                new SqlParameter("@is_large",is_large),
                new SqlParameter("@sec_qty",fltSec_qty)
            };            
            DataTable dt = new DataTable();
            dt = clsConPad.ExecuteProcedureReturnTable("usp_get_cost_price", paras);

            float fltResult;
            if (dt.Rows.Count > 0)
            {
                fltResult = clsPub.Return_Float_Value(dt.Rows[0]["cost_price"].ToString());
            }
            else
            {
                fltResult = 0.00f;
            }
            dgvDetails.SetRowCellValue(cur_row, "amt_total", fltResult);
        }

        /// <summary>
        /// 计算主档总金额
        /// </summary>
        void Count_Head_Cost()
        {
            dgvDetails.CloseEditor();
            float amt_total = 0.00f,temp_amt_total = 0.00f, temp_amt_other=0.00f;
            for (int i = 0; i < dgvDetails.RowCount; i++)
            {                
                if (string.IsNullOrEmpty(dgvDetails.GetRowCellDisplayText(i, "amt_total")))
                    temp_amt_total = 0;
                else
                    temp_amt_total = clsPub.Return_Float_Value(dgvDetails.GetRowCellValue(i, "amt_total").ToString());
                if (string.IsNullOrEmpty(dgvDetails.GetRowCellDisplayText(i, "amt_other")))
                    temp_amt_other = 0;
                else
                    temp_amt_other = clsPub.Return_Float_Value(dgvDetails.GetRowCellValue(i, "amt_other").ToString());
                amt_total += temp_amt_total + temp_amt_other;
            }
            txtamt_sum.Text = amt_total.ToString();
        }

        private void txtcompany_id_Leave(object sender, EventArgs e)
        {
            if (mState != "" && txtcompany_id.Text !="")
            {
                if(dgvDetails.RowCount>0)
                {
                    Set_cost_price();
                    Count_Head_Cost();
                }
            }
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            if (dgvFind.RowCount > 0)
            {
                ExpToExcel oxls = new ExpToExcel();
                oxls.ExportExcel(dgvFind);
            }
            else
            {
                MessageBox.Show("没要要汇出的数据！", "提示信息");
            }
        }

        private void txtcustomer_address_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            
            if (mState == "NEW" && txtcustomer_address.Text != "")
            {
                if (txtserial_no.Text == "")
                {
                    string sql=string.Format(@"select serial_no,serial_name from dbo.delivery_address_histroy where company_id='{0}' and address='{1}'",txtcompany_id.EditValue,txtcustomer_address.Text);
                    DataTable dt = new DataTable();                    
                    dt = clsConPad.GetDataTable(sql);
                    if (dt.Rows.Count > 0)
                    {
                        txtserial_no.Text = dt.Rows[0]["serial_no"].ToString();
                        txtserial_name.Text = dt.Rows[0]["serial_name"].ToString();
                    }
                    dt.Dispose();
                }
            }
        }
     


	}
}
