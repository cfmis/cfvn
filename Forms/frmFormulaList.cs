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
using WeifenLuo.WinFormsUI.Docking;
using cfvn.CLS;
//using cf01.Reports;


namespace cfvn.Forms
{
	public partial class frmFormulaList : DockContent
	{
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        public clsAppPublic clsPub = new clsAppPublic();
        
		public string mID = "";    //臨時的主鍵值
		public string mState = ""; //新增或編輯的狀態
		public static string str_language = "0";		
		public bool save_flag;

        DataTable dtMostly = new DataTable();	    
        DataTable dtFind_Date = new DataTable();
        

        public static BindingSource myBds = new BindingSource();
       
        public frmFormulaList()
		{
			InitializeComponent();
            
            //權限
            //clsToolBar obj = new clsToolBar(this.Name, this.Controls);
            //obj.SetToolBar();

            //str_language = DBUtility._language;
            //NextControl oNext = new NextControl(this, "2");
            //oNext.EnterToTab();
		}

		private void frmFormulaList_Load(object sender, EventArgs e)
		{
            const string sql_h = @"SELECT * From dbo.formula Where 1=0 ";
            dtMostly = clsApp.GetDataTable(sql_h);
            myBds.DataSource = dtMostly;                       
            try
            {
                //數據綁定主档
                txtPkey.DataBindings.Add("Text", myBds, "pkey");
                txtID.DataBindings.Add("EditValue", myBds, "id");
                txtName.DataBindings.Add("Text", myBds, "name");
                txtserial_no.DataBindings.Add("EditValue", myBds, "serial_no");
                chkIs_large.DataBindings.Add("Checked", myBds, "is_large");
                txtName.DataBindings.Add("Text", myBds, "serial_name");
                txtminimum_weight.DataBindings.Add("Text", myBds, "minimum_weight");
                txtminimum_amt.DataBindings.Add("Text", myBds, "minimum_amt");
                txtover_weight_amt.DataBindings.Add("Text", myBds, "over_weight_amt");
                txtamt_other.DataBindings.Add("Text", myBds, "amt_other");                
                txtbegin_qty1.DataBindings.Add("Text", myBds, "begin_qty1");
                txtend_qty1.DataBindings.Add("Text", myBds, "end_qty1");
                txtamt_rang1.DataBindings.Add("Text", myBds, "amt_rang1");
                txtbegin_qty2.DataBindings.Add("Text", myBds, "begin_qty2");
                txtend_qty2.DataBindings.Add("Text", myBds, "end_qty2");
                txtamt_rang2.DataBindings.Add("Text", myBds, "amt_rang2");
                txtbegin_qty3.DataBindings.Add("Text", myBds, "begin_qty3");
                txtend_qty3.DataBindings.Add("Text", myBds, "end_qty3");
                txtamt_rang3.DataBindings.Add("Text", myBds, "amt_rang3");
                txtbegin_qty4.DataBindings.Add("Text", myBds, "begin_qty4");
                txtend_qty4.DataBindings.Add("Text", myBds, "end_qty4");
                txtamt_rang4.DataBindings.Add("Text", myBds, "amt_rang4");
                txtbegin_qty5.DataBindings.Add("Text", myBds, "begin_qty5");
                txtend_qty5.DataBindings.Add("Text", myBds, "end_qty5");
                txtamt_rang5.DataBindings.Add("Text", myBds, "amt_rang5");
                txtbegin_qty6.DataBindings.Add("Text", myBds, "begin_qty6");
                txtend_qty6.DataBindings.Add("Text", myBds, "end_qty6");
                txtamt_rang6.DataBindings.Add("Text", myBds, "amt_rang6");
                txtremark.DataBindings.Add("Text", myBds, "remark");
                txtCreate_by.DataBindings.Add("Text", myBds, "create_by");
                txtCreate_date.DataBindings.Add("Text", myBds, "create_date");
                txtupdate_by.DataBindings.Add("Text", myBds, "update_by");
                txtupdate_date.DataBindings.Add("Text", myBds, "update_date");
                txtState.DataBindings.Add("Text", myBds, "state");
            }
            catch (Exception E)
            {                
                throw new Exception(E.Message);                
            }
            gridControl1.DataSource = myBds;

            //公司资料
            DataTable dtCompany = clsApp.GetDataTable(@"Select '' as id,'' as name UNION SELECT id,name From dbo.cd_company Order By id");
            txtID.Properties.DataSource = dtCompany;
            txtID.Properties.ValueMember = "id";
            txtID.Properties.DisplayMember = "id";

            
            //欄位表頭居中
            for (int i = 0; i < dgvDetails.Columns.Count; i++)
            {
                dgvDetails.Columns[i].AppearanceHeader.TextOptions.HAlignment=DevExpress.Utils.HorzAlignment.Center;
            }           
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
            myBds.AddNew();
			txtID.Focus();
			SetButtonSatus(false);
            Set_Grid_Status(true);

            SetObjValue.SetEditBackColor(panel1.Controls, true);
            SetObjValue.ClearObjValue(panel1.Controls, "1"); 
            
            txtremark.Text = "";
            txtState.Text = "0";             
            tabControl1.SelectTab(0);//跳至第一頁
		}

		private void Edit()  //編輯
		{
			if (txtID.Text == "")
			{
				return;
			}            
            SetButtonSatus(false);			
			//SetObjValue.SetEditBackColor(this.Controls, true);
            SetObjValue.SetEditBackColor(tabPage1.Controls, true);
			Set_Grid_Status(true);
			mState = "EDIT";

			txtID.Properties.ReadOnly = true;
			txtID.BackColor = Color.White;
            txtserial_no.Properties.ReadOnly = true;
            txtserial_no.BackColor = Color.White;
            chkIs_large.Properties.ReadOnly = true;
            chkIs_large.BackColor = Color.White;
            
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
         
            //clsToolBar obj = new clsToolBar(this.Name, this.Controls);
            //obj.SetToolBar();
		}

		private void Set_Grid_Status(bool _flag) // 表格可編號否
		{
			//false--不可編輯;true--可以編輯
			//dgvDetails.OptionsBehavior.Editable = _flag;			                   
		}

		private void Delete() //刪除當前行
		{
			if (String.IsNullOrEmpty(txtPkey.Text))
			{
				return;
			}    
            if (dgvDetails.RowCount == 0)
			{
				return;
			}
			DialogResult result = MessageBox.Show("此操作将刪除当前记奶的资料,请谨慎操作!", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
                const string sql_del = @"Update dbo.formula Set state='2' WHERE pkey=@pkey";
                SqlParameter[] paras=new SqlParameter[]{
                    new SqlParameter("@pkey",int.Parse(txtPkey.Text))
                };
                if(clsApp.ExecuteNonQuery(sql_del,paras,false)>0)
                {
                    int curRow = dgvDetails.FocusedRowHandle;
                    dgvDetails.DeleteRow(curRow);//移走當前行
                }
            }
		}

		private void Cancel() //取消
		{
            myBds.CancelEdit();      
            SetButtonSatus(true);			
            SetObjValue.SetEditBackColor(tabPage1.Controls, false);
            SetObjValue.ClearObjValue(tabPage1.Controls, "2");
			Set_Grid_Status(false);
            mState = "";
		}

	
		private void Save()  //保存
		{
            txtremark.Focus();
            if (!Save_Before_Valid())
			{
				return;
			}
			save_flag = true ;
            myBds.EndEdit();         
            dgvDetails.CloseEditor();
			#region  保存新增或編輯
            if (mState == "NEW" || mState == "EDIT")
			{               
                const string sql_i =             
                @"INSERT INTO dbo.formula
                (id,name,serial_no,serial_name,is_large,minimum_weight,minimum_amt,over_weight_amt,begin_qty1,end_qty1,amt_rang1,
                begin_qty2,end_qty2,amt_rang2,begin_qty3,end_qty3,amt_rang3,begin_qty4,end_qty4,amt_rang4,begin_qty5,end_qty5,amt_rang5,
                begin_qty6,end_qty6,amt_rang6,amt_other,remark,state,create_by,create_date) VALUES
                (@id,@name,@serial_no,@serial_name,@is_large,@minimum_weight,@minimum_amt,@over_weight_amt,@begin_qty1,@end_qty1,@amt_rang1,
                @begin_qty2,@end_qty2,@amt_rang2,@begin_qty3,@end_qty3,@amt_rang3,@begin_qty4,@end_qty4,@amt_rang4,@begin_qty5,@end_qty5,@amt_rang5,
                @begin_qty6,@end_qty6,@amt_rang6,@amt_other,@remark,@state,@user_id,getdate())";
                const string sql_u =
               @"Update dbo.formula SET minimum_weight=@minimum_weight,minimum_amt=@minimum_amt,over_weight_amt=@over_weight_amt,
                begin_qty1=@begin_qty1,end_qty1=@end_qty1,amt_rang1=@amt_rang1,begin_qty2=@begin_qty2,end_qty2=@end_qty2,amt_rang2=@amt_rang2,
                begin_qty3=@begin_qty3,end_qty3=@end_qty3,amt_rang3=@amt_rang3,begin_qty4=@begin_qty4,end_qty4=@end_qty4,amt_rang4=@amt_rang4,
                begin_qty5=@begin_qty5,end_qty5=@end_qty5,amt_rang5=@amt_rang5,begin_qty6=@begin_qty6,end_qty6=@end_qty6,amt_rang6=@amt_rang6,
                amt_other=@amt_other,remark=@remark,state=@state,remark=@remark,update_by=@user_id,update_date=getdate() WHERE pkey=@pkey";
                
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString); //改爲CF01
				myCon.Open();
				SqlTransaction myTrans = myCon.BeginTransaction();
				using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
				{
					try
					{                       
						myCommand.Parameters.Clear();                        
						myCommand.Parameters.AddWithValue("@id", txtID.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@name", txtName.Text);                       
                        myCommand.Parameters.AddWithValue("@serial_no", txtserial_no.EditValue.ToString());                       
                        myCommand.Parameters.AddWithValue("@is_large", chkIs_large.Checked);
                        myCommand.Parameters.AddWithValue("@serial_name", txtSerial_name.Text);                       
                        myCommand.Parameters.AddWithValue("@minimum_weight", clsPub.Return_Int_Value(txtminimum_weight.Text));
                        myCommand.Parameters.AddWithValue("@minimum_amt", float.Parse(txtminimum_amt.Text));
                        myCommand.Parameters.AddWithValue("@over_weight_amt", clsPub.Return_Float_Value(txtover_weight_amt.Text));
                        myCommand.Parameters.AddWithValue("@amt_other", clsPub.Return_Float_Value(txtamt_other.Text));
                        myCommand.Parameters.AddWithValue("@begin_qty1", clsPub.Return_Int_Value(txtbegin_qty1.Text));
                        myCommand.Parameters.AddWithValue("@end_qty1", clsPub.Return_Int_Value(txtend_qty1.Text));
                        myCommand.Parameters.AddWithValue("@amt_rang1", clsPub.Return_Float_Value(txtamt_rang1.Text));
                        myCommand.Parameters.AddWithValue("@begin_qty2", clsPub.Return_Int_Value(txtbegin_qty2.Text));
                        myCommand.Parameters.AddWithValue("@end_qty2", clsPub.Return_Int_Value(txtend_qty2.Text));
                        myCommand.Parameters.AddWithValue("@amt_rang2", clsPub.Return_Float_Value(txtamt_rang2.Text));
                        myCommand.Parameters.AddWithValue("@begin_qty3", clsPub.Return_Int_Value(txtbegin_qty3.Text));
                        myCommand.Parameters.AddWithValue("@end_qty3", clsPub.Return_Int_Value(txtend_qty3.Text));
                        myCommand.Parameters.AddWithValue("@amt_rang3", clsPub.Return_Float_Value(txtamt_rang3.Text));
                        myCommand.Parameters.AddWithValue("@begin_qty4", clsPub.Return_Int_Value(txtbegin_qty4.Text));
                        myCommand.Parameters.AddWithValue("@end_qty4", clsPub.Return_Int_Value(txtend_qty4.Text));
                        myCommand.Parameters.AddWithValue("@amt_rang4", clsPub.Return_Float_Value(txtamt_rang4.Text));
                        myCommand.Parameters.AddWithValue("@begin_qty5", clsPub.Return_Int_Value(txtbegin_qty5.Text));
                        myCommand.Parameters.AddWithValue("@end_qty5", clsPub.Return_Int_Value(txtend_qty5.Text));
                        myCommand.Parameters.AddWithValue("@amt_rang5", clsPub.Return_Float_Value(txtamt_rang5.Text));
                        myCommand.Parameters.AddWithValue("@begin_qty6", clsPub.Return_Int_Value(txtbegin_qty6.Text));
                        myCommand.Parameters.AddWithValue("@end_qty6", clsPub.Return_Int_Value(txtend_qty6.Text));
                        myCommand.Parameters.AddWithValue("@amt_rang6", clsPub.Return_Float_Value(txtamt_rang6.Text));
                        myCommand.Parameters.AddWithValue("@remark", txtremark.Text);
                        myCommand.Parameters.AddWithValue("@state", "0");                       
                        myCommand.Parameters.AddWithValue("@user_id", DBUtility._user_id);
                       
                        if (mState == "NEW")
                        {
                            myCommand.CommandText = sql_i;
                            string sql_f = string.Format(@"Select '1' From dbo.formula where id='{0}' and serial_no='{1}' and is_large=0", txtID.EditValue, txtserial_no.EditValue);
                            if (!string.IsNullOrEmpty(clsApp.ExecuteSqlReturnObject(sql_f)))
                            {
                                MessageBox.Show(string.Format("公司编号、区域代码、是否大件【{0},{1},{2}】]已存在!", txtID.EditValue, txtserial_no.EditValue, chkIs_large.Checked));                                
                                save_flag = false;
                            }
                        }
                        else
                        {
                            myCommand.CommandText = sql_u;
                        }
                        if (save_flag)
                        {
                            myCommand.ExecuteNonQuery();
                            myTrans.Commit(); //數據提交
                            save_flag = true;
                        }
                        else
                        {
                            myTrans.Rollback();
                        }
						
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
			mState = "";
           
			if (save_flag)
			{				              
				MessageBox.Show("当前数据保存成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
                MessageBox.Show("当前数据保存失败!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}

		private bool Save_Before_Valid() //保存前檢查主檔資料有效性
		{
            if (txtID.EditValue.ToString() == "" && txtserial_no.Text == "")
            {
                MessageBox.Show("公司编号、区域代码不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
		}

		private void txtID_Leave(object sender, EventArgs e)
		{
			if (!String.IsNullOrEmpty(txtID.EditValue.ToString()))
			{
				if (mState == "") //流覽模式
				{
					Find_doc(txtID.EditValue.ToString());
				}
			}
		}

        private void Find_doc(string temp_id) //主檔非新增的情況下，保存或取消時重新查出資料
        {
            if (!String.IsNullOrEmpty(temp_id))
            {
                string sql_h = String.Format(@"Select * FROM dbo.formula with(nolock) Where id ='{0}' AND state <>'2'", temp_id);
                dtMostly = clsApp.GetDataTable(sql_h);               
                if (dtMostly.Rows.Count > 0)
                {
                    myBds.DataSource = dtMostly;                   
                }
                else
                {
                    //清空数据
                    dtMostly.Clear();
                    myBds.DataSource = dtMostly;
                    SetObjValue.ClearObjValue(tabPage1.Controls, "2");
                    return;
                }                            
                mID = txtID.EditValue.ToString();//保存臨時的ID號   
            }
        }

        private void frmFormulaList_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtMostly.Dispose(); 
            //dtTempDel.Dispose();
            dtFind_Date.Dispose();
            myBds.Dispose();            
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
            @"Select id,name,serial_no,serial_name,is_large FROM dbo.formula with(nolock) WHERE pkey>0 ";
            if (txtvendor_id1.Text != "")
            {
                sql += string.Format(" AND id>='{0}'", txtvendor_id1.Text);
            }
            if (txtvendor_id2.Text != "")
            {
                sql += string.Format(" AND id<='{0}'", txtvendor_id2.Text);
            }
            sql += " and state<>'2' ";
            sql += " ORDER BY id,serial_no";
         
            dtFind_Date = clsApp.GetDataTable(sql);
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
                    txtID.EditValue = dgvFind.Rows[dgvFind.CurrentCell.RowIndex].Cells["id"].Value.ToString();                    
                    Find_doc(txtID.EditValue.ToString());
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

        private void txtvendor_id1_Leave(object sender, EventArgs e)
        {
            txtvendor_id2.Text = txtvendor_id2.Text;
        }
               

        private void Print()
        {
//            if (dgvDetails.RowCount == 0)
//            {
//                MessageBox.Show("沒有要列印的數據!","提示信息");
//                return;
//            }
//            string strSql =
//            @"Select A.id,A.issues_date,A.it_customer,A.customer_name,A.customer_address,A.s_address,A.contact_info,A.post_info,A.remark,
//            B.sequence_id,B.mo_id,B.goods_id,B.goods_name,B.table_head,B.customer_goods,B.customer_color_id,B.customer_size,B.issues_qty,B.issues_unit,B.remark
//            From dbo.custom_delivery_mostly A with(nolock),dbo.custom_delivery_details B with(nolock)
//            WHERE A.id=B.id ";
//            strSql += " And A.id='" + txtID.Text + "'"+ " Order by A.id,B.sequence_id";
//            DataTable dtReprot = clsPublicOfCF01.GetDataTable(strSql);
//            using (xrCustomDelivery myReport1 = new xrCustomDelivery() { DataSource = dtReprot })
//            {
//                myReport1.CreateDocument();
//                myReport1.PrintingSystem.ShowMarginsWarning = false;
//                myReport1.ShowPreviewDialog();
//            }
        }        

        private void dgvDetails_SelectionChanged(object sender, DevExpress.Data.SelectionChangedEventArgs e)
        {
            if (dgvDetails.RowCount > 0)
            {
                //设置YYYY-MM-DD日期格式
                //txtlicence_valid_date.EditValue = clspub.Return_String_Date(txtlicence_valid_date.EditValue.ToString());
                //txtlicence_no_valid_date.EditValue = clspub.Return_String_Date(txtlicence_no_valid_date.EditValue.ToString());
                //dtgspgmp_valid_date.EditValue = clspub.Return_String_Date(dtgspgmp_valid_date.EditValue.ToString());
                //dtentrust_date.EditValue = clspub.Return_String_Date(dtentrust_date.EditValue.ToString());   
            }
        }   

        private void txtID_EditValueChanged(object sender, EventArgs e)
        {
            if (mState == "NEW")
            {
                if (txtID.Text != "")
                {
                    txtName.Text = txtID.GetColumnValue("name").ToString();
                }
            }
        }
     
        private void dgvDetails_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void clCodeCity_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if (mState == "NEW" || mState == "EDIT")
            {
                int rowHandle = dgvDetails.FocusedRowHandle;               
                if (!string.IsNullOrEmpty(dgvDetails.GetRowCellValue(rowHandle, "org_serial_no").ToString()))
                {
                    //编辑状态禁止改动此栏内容
                    return;
                }
                using (frmCode ofrmCode = new frmCode())
                {
                    ofrmCode.ShowDialog();
                    if (ofrmCode.strCityCode != "")
                    {
                        dgvDetails.SetRowCellValue(rowHandle, "serial_no", ofrmCode.strCityCode);
                        dgvDetails.SetRowCellValue(rowHandle, "name", ofrmCode.strCityName);                        
                    }
                }
            }
        }

   

        private void clChkIsBig_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (mState == "NEW" || mState == "EDIT")
            {
                int rowHandle = dgvDetails.FocusedRowHandle;
                string strIs_large = dgvDetails.GetRowCellValue(rowHandle, "is_large").ToString();
                if (!string.IsNullOrEmpty(dgvDetails.GetRowCellValue(rowHandle, "org_serial_no").ToString()))
                {
                    //已保存的记录编辑状态禁止改动主键
                    if (strIs_large == "False")
                    {
                        dgvDetails.SetRowCellValue(rowHandle, "is_large", false);
                    }
                    else
                    {
                        dgvDetails.SetRowCellValue(rowHandle, "is_large", true);
                    }
                    dgvDetails.CloseEditor();
                }               
            }
        }


        private void BTNCARD_Click(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount > 0)
            {
                string strSerial_no = dgvDetails.GetRowCellDisplayText(dgvDetails.FocusedRowHandle, "org_serial_no");
                bool isCanModifyKeyValue;
                if (string.IsNullOrEmpty(strSerial_no))
                {
                    isCanModifyKeyValue = true;
                }
                else
                {
                    isCanModifyKeyValue = false;
                }

                bool isNewOrEdit;
                if (mState !="")
                {
                    isNewOrEdit = true;
                }
                else
                {
                    isNewOrEdit = false;
                }
                using (frmCodeEdit ofrmCode = new frmCodeEdit(isCanModifyKeyValue, isNewOrEdit))
                {
                    ofrmCode.ShowDialog();
                    myBds.EndEdit();
                    dgvDetails.CloseEditor();
                }
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
                        txtSerial_name.Text = ofrmFind.strCityName;
                    }
                }
            }
        }

        private void txtserial_no_Leave(object sender, EventArgs e)
        {
            if (txtserial_no.Text != "" && (mState == "NEW" || mState == "EDIT"))
            {
                clsCityCode obj = new clsCityCode();
                string strSerial_name = obj.Get_City_Name(txtserial_no.Text);
                if (strSerial_name != "")
                {
                    txtSerial_name.Text = strSerial_name;
                }
                else
                {
                    txtSerial_name.Text = "";
                    MessageBox.Show("区域代码不存在！", "提示信息");
                    txtserial_no.Focus();
                }

            }
        }

	}
}
