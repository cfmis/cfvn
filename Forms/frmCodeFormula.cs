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
using cfvn.CLS;
using WeifenLuo.WinFormsUI.Docking;
using cfvn.MDL;
//using cf01.Reports;


namespace cfvn.Forms
{
	public partial class frmCodeFormula : DockContent
	{
        private clsPublicOfVN clsApp = new clsPublicOfVN();
        public clsAppPublic clspub = new clsAppPublic();
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
        
        public frmCodeFormula()
		{
			InitializeComponent();            
            //權限
            if (this.Tag.ToString() != "")
            {
                objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
                objToolbar.SetToolBar();
            }
           
            //NextControl oNext = new NextControl(this, "2");
            //oNext.EnterToTab();
		}

		private void frmCodeFormula_Load(object sender, EventArgs e)
		{
            const string sql_h = @"SELECT * From dbo.formula_mostly Where 1=0 ";
            dtMostly=clsApp.GetDataTable(sql_h);            
            myBDS1.DataSource = dtMostly;
            try
            {
                //數據綁定主档
                txtID.DataBindings.Add("EditValue", myBDS1, "id");
                //txtName.DataBindings.Add("Text", myBDS1, "name");
                txtremark.DataBindings.Add("Text", myBDS1, "remark");
                txtCreate_by.DataBindings.Add("Text", myBDS1, "create_by");
                txtCreate_date.DataBindings.Add("Text", myBDS1, "create_date");
                txtupdate_by.DataBindings.Add("Text", myBDS1, "update_by");
                txtupdate_date.DataBindings.Add("Text", myBDS1, "update_date");
                txtState.DataBindings.Add("Text", myBDS1, "state");

                //生成明細表結構
                const string sql_d = @"Select *,serial_no as org_serial_no From dbo.formula_details Where 1=0";
                dtDetails = clsApp.GetDataTable(sql_d);
                myBDS2.DataSource = dtDetails;
                gridControl1.DataSource = myBDS2;
            }
            catch (Exception E)
            {                
                throw new Exception(E.Message);
            }

            //公司资料
            clsState.Set_DropBox_For_Company(txtID);           
            clsState.Set_DropBox_For_Company(lkevendor_id1);
            clsState.Set_DropBox_For_Company(lkevendor_id2);
            
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
				newRow["id"] = txtID.EditValue.ToString();
                newRow["serial_no"] = dgvDetails.GetRowCellDisplayText(curRow, "serial_no");
                bool is_large;
                if (dgvDetails.GetRowCellValue(curRow, "is_large").ToString() == "True")
                {
                    is_large = true;
                }
                else
                {
                    is_large = false;
                }
                newRow["is_large"] = is_large;                
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
            txtID.Enabled = true;
            txtID.Properties.ReadOnly =false;
            
            txtremark.Text = "";
            txtState.Text = "0";
                       
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
            SetButtonSatus(false);			
			//SetObjValue.SetEditBackColor(this.Controls, true);
            SetObjValue.SetEditBackColor(tabPage1.Controls, true);
			Set_Grid_Status(true);
			mState = "EDIT";
			txtID.Properties.ReadOnly = true;
			txtID.BackColor = Color.White;                        
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
            BTNEXCEL.Enabled = _flag;
            BTNNEWCOPY.Enabled = _flag;

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
			DialogResult result = MessageBox.Show("此操作将刪除当前速递公司主表及明细中的全部资料,请谨慎操作!", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
			if (result == DialogResult.Yes)
			{
                const string sql_del = @"Update dbo.formula_mostly Set state='2' WHERE id=@id";
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);//改回直接操作GEO
				myCon.Open();
				SqlTransaction myTrans = myCon.BeginTransaction();
				using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
				{
					try
					{
						myCommand.CommandText = sql_del;//刪除主檔
						myCommand.Parameters.Clear();
                        myCommand.Parameters.AddWithValue("@id", txtID.EditValue.ToString());
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
            if (!String.IsNullOrEmpty(txtID.EditValue.ToString())) // 有內容
			{
                if (!Check_Details_Valid())
                {
                    return;
                }
				Set_Grid_Status(true);
                SetObjValue.SetEditBackColor(tabPage1.Controls, true);
                myBDS2.AddNew();
                //dgvDetails.AddNewRow();//新增
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "id", txtID.EditValue.ToString());
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "is_large", false);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "province", "");
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "minimum_weight", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "minimum_amt", 0.00);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "over_weight_amt", 0.00);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty1", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty1", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang1", 0.00);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty2", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty2", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang2", 0.00);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty3", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty3", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang3", 0.00);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty4", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty4", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang4", 0.00);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty5", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty5", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang5", 0.00);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty6", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty6", 0);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang6", 0.00);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_other", 0.00);    
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "remark", "");
				ColumnView view = (ColumnView)dgvDetails;//初始單元格焦點
                view.FocusedColumn = view.Columns["serial_no"];
				view.Focus();
                view.ShowEditor();
			}
			else
			{
				MessageBox.Show("公司代码不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtID.Focus();
			}
		}

		private bool Check_Details_Valid() //檢查明細資料的有效性
		{
			//測試項目必須有輸入
			bool _flag = true;
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
                    if (String.IsNullOrEmpty(dgvDetails.GetRowCellDisplayText(curRow, "serial_no")))
					{
						_flag = false;
                        dgvDetails.FocusedRowHandle = curRow;
						MessageBox.Show("目的地代码不可以为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
						//ColumnView view1 = (ColumnView)dgvDetails;
                        view = (ColumnView)dgvDetails;
                        view.FocusedColumn = view.Columns["serial_no"]; //設置單元格焦點   
                        view.Focus();
                        view.ShowEditor();
						break;
					}
                    if (clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "minimum_weight").ToString()) <=0)
                    {
                        _flag = false;                           
                        dgvDetails.FocusedRowHandle = curRow;                        
                        MessageBox.Show("最低起重必须是大于零的值!", "提示信息");                       
                        view = (ColumnView)dgvDetails;
                        view.FocusedColumn = view.Columns["minimum_weight"]; //設置單元格焦點   
                        view.Focus();
                        view.ShowEditor();
                        break;
                    }
                    if (clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "minimum_amt").ToString()) <= 0
                       )
                    {
                        _flag = false;
                        dgvDetails.FocusedRowHandle = curRow;
                        MessageBox.Show("最低运费必须是大于零的值!", "提示信息");
                        view = (ColumnView)dgvDetails;
                        view.FocusedColumn = view.Columns["minimum_amt"]; //設置單元格焦點   
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
			//SetObjValue.SetEditBackColor(this.Controls, false);
            SetObjValue.SetEditBackColor(tabPage1.Controls, false);
            SetObjValue.ClearObjValue(tabPage1.Controls, "2");
            //txtID.Enabled = false;
			Set_Grid_Status(false);

			//dtTempDel.Clear();
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
                string sql_h = String.Format(@"Select * FROM dbo.formula_mostly with(nolock) Where id ='{0}' AND state <>'2'", temp_id);
                dtMostly = clsApp.GetDataTable(sql_h);
                string sql_d = String.Format(
                @"Select B.*,B.serial_no as org_serial_no
                From dbo.formula_mostly A with(nolock),dbo.formula_details B with(nolock) 
                Where A.id=B.id and A.id='{0}' and A.state<>'2' ", temp_id);
                dtDetails = clsApp.GetDataTable(sql_d);
                if (dtMostly.Rows.Count > 0)
                {
                    myBDS1.DataSource = dtMostly;
                    //dtdate.EditValue = clspub.Return_String_Date(dtdate.EditValue.ToString());
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
                dtDetails = clsApp.GetDataTable(sql_d);                             
                myBDS2.DataSource = dtDetails;
                gridControl1.DataSource = myBDS2;
                //设置时间格式
                //txtlicence_valid_date.EditValue = clspub.Return_String_Date(txtlicence_valid_date.EditValue.ToString());
                //txtlicence_no_valid_date.EditValue = clspub.Return_String_Date(txtlicence_no_valid_date.EditValue.ToString());                  
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
                MessageBox.Show("明细资料不可为空!", "提示信息"); 
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
                if (mState == "NEW")
                {
                    string strSql = String.Format("Select '1' FROM dbo.formula_mostly WHERE id='{0}'", txtID.EditValue);
                    if (clsApp.ExecuteSqlReturnObject(strSql) != "")
                    {
                        MessageBox.Show(string.Format("已存在此速递公司数据[{0}]已存在!", txtID.EditValue));
                        return;
                        //GetID_No();//如已存在編號則重取最大單據編號
                    }            
                }
                const string sql_i =
                @"INSERT INTO dbo.formula_mostly(id,name,remark,state,create_by,create_date) VALUES (@id,@name,@remark,@state,@user_id,getdate())";
                const string sql_u = 
                @"Update dbo.formula_mostly SET remark=@remark,update_by=@user_id,update_date=getdate() WHERE id=@id";   
                
                SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString); //改爲CF01
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
						myCommand.Parameters.AddWithValue("@id", txtID.EditValue.ToString());
                        myCommand.Parameters.AddWithValue("@name", txtID.Text);                        
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
                            if (dtTempDel.Rows[i]["is_large"].ToString() == "True")
                            {
                                is_large = true;
                            }
                            else
                            {
                                is_large = false;
                            }
                            sql_item_d = @"DELETE FROM dbo.formula_details WHERE id=@id and serial_no=@serial_no and is_large=@is_large";
                            myCommand.CommandText = sql_item_d;
                            myCommand.Parameters.Clear();
                            myCommand.Parameters.AddWithValue("@id", txtID.EditValue.ToString());
                            myCommand.Parameters.AddWithValue("@serial_no", dtTempDel.Rows[i]["serial_no"].ToString());
                            myCommand.Parameters.AddWithValue("@is_large", is_large); 
                            myCommand.ExecuteNonQuery();
                        }
                        
                        //保存明細
                        int curRow;
                        string rowStatus;
						if (dgvDetails.RowCount > 0)
						{							
                            const string sql_item_i =
                                @"INSERT INTO dbo.formula_details
                                (id,serial_no,is_large,name,province,minimum_weight,minimum_amt,over_weight_amt,begin_qty1,end_qty1,amt_rang1,
                                begin_qty2,end_qty2,amt_rang2,begin_qty3,end_qty3,amt_rang3,begin_qty4,end_qty4,amt_rang4,begin_qty5,end_qty5,amt_rang5,
                                begin_qty6,end_qty6,amt_rang6,amt_other,remark) VALUES
                                (@id,@serial_no,@is_large,@name,@province,@minimum_weight,@minimum_amt,@over_weight_amt,@begin_qty1,@end_qty1,@amt_rang1,
                                @begin_qty2,@end_qty2,@amt_rang2,@begin_qty3,@end_qty3,@amt_rang3,@begin_qty4,@end_qty4,@amt_rang4,@begin_qty5,@end_qty5,@amt_rang5,
                                @begin_qty6,@end_qty6,@amt_rang6,@amt_other,@remark)";
                            const string sql_item_u =
                                @"Update dbo.formula_details 
                                SET minimum_weight=@minimum_weight,minimum_amt=@minimum_amt,over_weight_amt=@over_weight_amt,
                                begin_qty1=@begin_qty1,end_qty1=@end_qty1,amt_rang1=@amt_rang1,begin_qty2=@begin_qty2,end_qty2=@end_qty2,amt_rang2=@amt_rang2,
                                begin_qty3=@begin_qty3,end_qty3=@end_qty3,amt_rang3=@amt_rang3,begin_qty4=@begin_qty4,end_qty4=@end_qty4,amt_rang4=@amt_rang4,
                                begin_qty5=@begin_qty5,end_qty5=@end_qty5,amt_rang5=@amt_rang5,begin_qty6=@begin_qty6,end_qty6=@end_qty6,amt_rang6=@amt_rang6,
                                amt_other=@amt_other,remark=@remark 
                                Where id=@id AND serial_no=@serial_no AND is_large=@is_large";
                            string sql_item_f = "";
                            int intIs_large = 0;
                            for (int i = 0; i < dgvDetails.RowCount; i++)
							{
                                curRow = dgvDetails.GetRowHandle(i);
                                //dgvDetails.AddNewRow();//新增必須初始貨當前單元格焦點
                                //否則rowStatus取不到狀態值
                                rowStatus = dgvDetails.GetDataRow(curRow).RowState.ToString();
                                if (rowStatus == "Added" || rowStatus == "Modified")
                                {
                                    if (dgvDetails.GetRowCellValue(curRow, "is_large").ToString() == "False")
                                    {
                                        intIs_large = 0;
                                    }
                                    else
                                    {
                                        intIs_large = 1;
                                    }
                                    if (rowStatus == "Added")
                                    {

                                        myCommand.CommandText = sql_item_i;
                                        //检查是否已存在主键
                                        sql_item_f = string.Format(@"Select '1' From dbo.formula_details where id='{0}' and serial_no='{1}' and is_large={2}", txtID.EditValue, dgvDetails.GetRowCellValue(curRow, "serial_no"), intIs_large);
                                        if (!string.IsNullOrEmpty(clsApp.ExecuteSqlReturnObject(sql_item_f)))
                                        {
                                            save_flag = false;
                                            break;
                                        }
                                    }
                                    else
                                        myCommand.CommandText = sql_item_u;
                                    myCommand.Parameters.Clear();
                                    myCommand.Parameters.AddWithValue("@id", txtID.EditValue.ToString());
                                    myCommand.Parameters.AddWithValue("@serial_no", dgvDetails.GetRowCellValue(curRow, "serial_no").ToString());
                                    if (dgvDetails.GetRowCellValue(curRow, "is_large").ToString() == "True")
                                    {
                                        is_large = true;
                                    }
                                    else
                                    {
                                        is_large = false;
                                    }
                                    myCommand.Parameters.AddWithValue("@is_large", is_large);
                                    myCommand.Parameters.AddWithValue("@name", dgvDetails.GetRowCellValue(curRow, "name").ToString());
                                    myCommand.Parameters.AddWithValue("@province", dgvDetails.GetRowCellValue(curRow, "province").ToString());
                                    myCommand.Parameters.AddWithValue("@minimum_weight", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "minimum_weight").ToString()));
                                    myCommand.Parameters.AddWithValue("@minimum_amt", clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "minimum_amt").ToString()));
                                    myCommand.Parameters.AddWithValue("@over_weight_amt", clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "over_weight_amt").ToString()));
                                    myCommand.Parameters.AddWithValue("@amt_other", clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_other").ToString()));

                                    myCommand.Parameters.AddWithValue("@begin_qty1", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty1").ToString()));
                                    myCommand.Parameters.AddWithValue("@end_qty1", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "end_qty1").ToString()));
                                    myCommand.Parameters.AddWithValue("@amt_rang1", clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang1").ToString()));
                                    myCommand.Parameters.AddWithValue("@begin_qty2", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty2").ToString()));
                                    myCommand.Parameters.AddWithValue("@end_qty2", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "end_qty2").ToString()));
                                    myCommand.Parameters.AddWithValue("@amt_rang2", clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang2").ToString()));
                                    myCommand.Parameters.AddWithValue("@begin_qty3", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty3").ToString()));
                                    myCommand.Parameters.AddWithValue("@end_qty3", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "end_qty3").ToString()));
                                    myCommand.Parameters.AddWithValue("@amt_rang3", clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang3").ToString()));
                                    myCommand.Parameters.AddWithValue("@begin_qty4", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty4").ToString()));
                                    myCommand.Parameters.AddWithValue("@end_qty4", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "end_qty4").ToString()));
                                    myCommand.Parameters.AddWithValue("@amt_rang4", clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang4").ToString()));
                                    myCommand.Parameters.AddWithValue("@begin_qty5", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty5").ToString()));
                                    myCommand.Parameters.AddWithValue("@end_qty5", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "end_qty5").ToString()));
                                    myCommand.Parameters.AddWithValue("@amt_rang5", clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang5").ToString()));
                                    myCommand.Parameters.AddWithValue("@begin_qty6", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty6").ToString()));
                                    myCommand.Parameters.AddWithValue("@end_qty6", clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "end_qty6").ToString()));
                                    myCommand.Parameters.AddWithValue("@amt_rang6", clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang6").ToString()));
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
			SetObjValue.SetEditBackColor(tabPage1.Controls, false);
			Set_Grid_Status(false);
            //txtID.Enabled = false;
			mState = "";			
			dtTempDel.Clear();
           
			if (save_flag)
			{
				Find_doc(txtID.EditValue.ToString());                
				MessageBox.Show("当前数据保存成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
                MessageBox.Show("当前数据保存失败!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
			}
		}      
 

		private bool Save_Before_Valid() //保存前檢查主檔資料有效性
		{
            if (txtID.EditValue.ToString() == "")
            {
                MessageBox.Show("速递公司编号不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return false;
            }
            else
            {
                return true;
            }
		}

        //private bool Valid_Doc() //主建是否已存在
        //{
        //    //bool flag;
        //    //string doc = txtID.EditValue.ToString();
        //    //string strSql = String.Format("Select '1' FROM dbo.custom_delivery_mostly WHERE id='{0}' and state='0'", doc);
        //    //DataTable dt = cls.GetDataTable(strSql);
        //    //if (dt.Rows.Count > 0)
        //    //{
        //    //    MessageBox.Show("當前送貨單編號已存在" + String.Format("【{0}】.", doc), "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        //    //    flag = true;
        //    //}
        //    //else			
        //    //    flag = false;			
        //    //dt.Dispose();
        //    //return flag;
        //}

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

        //private void Set_Master_Data(DataTable dt) //綁定主檔資料
        //{
        //    txtID.EditValue.ToString() = dt.Rows[0]["id"].ToString();

        //    if (string.IsNullOrEmpty(dt.Rows[0]["issues_date"].ToString()))
        //        dtdate.EditValue = "";
        //    else
        //        dtdate.EditValue = Convert.ToDateTime(dt.Rows[0]["issues_date"].ToString()).ToString("yyyy-MM-dd");
        //    lketype_id.EditValue = dt.Rows[0]["it_customer"].ToString();
        //    txtremark.Text = dt.Rows[0]["customer_name"].ToString();
        //    txtprocess_by.Text = dt.Rows[0]["contact_info"].ToString();
        //    //txtCustomer_address.Text = dt.Rows[0]["customer_address"].ToString();
        //    //txtS_address.Text = dt.Rows[0]["s_address"].ToString();
        //    //txtRemark.Text =dt.Rows[0]["remark"].ToString();
        //    //txtPost_info.Text = dt.Rows[0]["post_info"].ToString();
        //    txtCreate_by.Text = dt.Rows[0]["create_by"].ToString();
        //    txtCreate_date.Text = dt.Rows[0]["create_date"].ToString();
        //    txtupdate_by.Text = dt.Rows[0]["update_by"].ToString();
        //    txtupdate_date.Text = dt.Rows[0]["update_date"].ToString();
        //}

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

        private void frmCodeFormula_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtMostly.Dispose();
            dtDetails.Dispose();
            dtTempDel.Dispose();
            dtFind_Date.Dispose();
            myBDS1.Dispose();
            myBDS2.Dispose();
            objToolbar = null;
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
            @"Select A.id,A.name as name,B.serial_no,B.name as name_serial_no,B.is_large,B.province
            FROM dbo.formula_mostly A with(nolock),dbo.formula_details B with(nolock)
            WHERE A.id=B.id ";
            if (lkevendor_id1.Text != "")
            {
                sql += string.Format(" AND A.id>='{0}'", lkevendor_id1.EditValue);
            }
            if (lkevendor_id2.Text != "")
            {
                sql += string.Format(" AND A.id<='{0}'", lkevendor_id2.EditValue);
            }
            sql += " and A.state<>'2' ";
            sql += " ORDER BY A.id,B.serial_no";
         
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

        private void lkevendor_id1_Leave(object sender, EventArgs e)
        {
            lkevendor_id2.EditValue = lkevendor_id1.EditValue;
        }
               

        private void Print()
        {
            //
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
                        dgvDetails.SetRowCellValue(rowHandle, "province", ofrmCode.strProvince);  
                    }
                }
            }
        }

        private void clCodeCity_Leave(object sender, EventArgs e)
        {
            //dgvDetails.CloseEditor();
            //string strSerial_no,strCityName;
            //strSerial_no = dgvDetails.GetRowCellValue(dgvDetails.FocusedRowHandle, "serial_no").ToString();
            //if (string.IsNullOrEmpty(strSerial_no))
            //{
            //    return;
            //}
            //if (mState != "" && strSerial_no != "")
            //{
            //    clsCityCode obj = new clsCityCode();
            //    strCityName = obj.Get_City_Name(strSerial_no);
            //    if (strSerial_no != "")
            //    {
            //        dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "serial_no", strSerial_no);
            //        dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "name", strCityName);
            //    }
            //    else
            //    {
            //        MessageBox.Show("区域代码不存在！", "提示信息");
            //        ColumnView view = (ColumnView)dgvDetails;//初始單元格焦點
            //        view.FocusedColumn = view.Columns["serial_no"];
            //        view.Focus();
            //        view.ShowEditor();
            //    }
            //}            
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

        private void dgvDetails_MouseDown(object sender, MouseEventArgs e)
        {
            //if (e.Button == MouseButtons.Left && e.Clicks == 2) // 判断是否是用鼠标双击    
            //{
            //    if (mState != "") //瀏覽狀態禁止打开编辑窗体
            //    {
            //        DevExpress.XtraGrid.Views.Grid.ViewInfo.GridHitInfo ghi = dgvDetails.CalcHitInfo(new Point(e.X, e.Y));
            //        if (ghi.InRow)  // 判断光标是否在行内    
            //        {
            //            string strSerial_no = dgvDetails.GetRowCellDisplayText(dgvDetails.FocusedRowHandle, "org_serial_no");
            //            bool isModify;
            //            if (string.IsNullOrEmpty(strSerial_no))
            //            {
            //                isModify = true;
            //            }
            //            else
            //            {
            //                isModify = false;
            //            }

            //            bool isReadOnly;
            //            if (mState != "")
            //            {
            //                isReadOnly = false;
            //            }
            //            else
            //            {
            //                isReadOnly = true;
            //            }

            //            using (frmCodeEdit ofrmCode = new frmCodeEdit(isModify, isReadOnly))
            //            {
            //                ofrmCode.ShowDialog();
            //                frmCodeFormula.myBDS2.EndEdit();
            //            }
            //        }
            //    }
            //}
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
                using (frmCodeEdit ofrmCodeEdit = new frmCodeEdit(isCanModifyKeyValue, isNewOrEdit))
                {
                    ofrmCodeEdit.ShowDialog();                    
                    myBDS2.EndEdit();
                    dgvDetails.CloseEditor();
                }
            }
        }

        private void BTNEXCEL_Click(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount > 0)
            {
                SaveFileDialog fileDialog = new SaveFileDialog() { Title = "导出Excel", Filter = "Excel文件(*.xls)|*.xls" };
                DialogResult dialogResult = fileDialog.ShowDialog(this);
                if (dialogResult == DialogResult.OK)
                {
                    gridControl1.ExportToXls(fileDialog.FileName);  
                    
                    DevExpress.XtraEditors.XtraMessageBox.Show("导出成功！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请首先查出数据！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTNNEWCOPY_Click(object sender, EventArgs e)
        {
            if (dgvDetails.RowCount > 0 && mState =="")
            {
                bool is_large;
                int curRow = dgvDetails.FocusedRowHandle;
                mdlFormula mdFormula = new mdlFormula();
                mdFormula.id = txtID.EditValue.ToString();                 
                if (dgvDetails.GetRowCellValue(curRow, "is_large").ToString() == "True")
                {
                     is_large = true;
                }
                else
                {
                     is_large = false;
                }
                mdFormula.is_large=is_large ;              
                mdFormula.minimum_weight = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "minimum_weight").ToString());
                mdFormula.minimum_amt = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "minimum_amt").ToString());
                mdFormula.over_weight_amt = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "over_weight_amt").ToString());
                mdFormula.amt_other = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_other").ToString());
                mdFormula.begin_qty1 = clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty1").ToString());
                mdFormula.end_qty1 = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "end_qty1").ToString());
                mdFormula.amt_rang1 = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang1").ToString());
                mdFormula.begin_qty2 = clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty2").ToString());
                mdFormula.end_qty2 = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "end_qty2").ToString());
                mdFormula.amt_rang2 = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang2").ToString());
                mdFormula.begin_qty3 = clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty3").ToString());
                mdFormula.end_qty3 = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "end_qty3").ToString());
                mdFormula.amt_rang3 = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang3").ToString());
                mdFormula.begin_qty4 = clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty4").ToString());
                mdFormula.end_qty4= clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "end_qty4").ToString());
                mdFormula.amt_rang4 = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang4").ToString());
                mdFormula.begin_qty5 = clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty5").ToString());
                mdFormula.end_qty5 = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "end_qty5").ToString());
                mdFormula.amt_rang5 = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang5").ToString());
                mdFormula.begin_qty6 = clspub.Return_Int_Value(dgvDetails.GetRowCellValue(curRow, "begin_qty6").ToString());
                mdFormula.end_qty6 = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "end_qty6").ToString());
                mdFormula.amt_rang6 = clspub.Return_Float_Value(dgvDetails.GetRowCellValue(curRow, "amt_rang6").ToString());
                mdFormula.remark = dgvDetails.GetRowCellValue(curRow, "remark").ToString();             
                Edit();
                AddNew_Item();

                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "id", mdFormula.id);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "is_large", mdFormula.is_large);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "province", "");
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "minimum_weight", mdFormula.minimum_weight);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "minimum_amt", mdFormula.minimum_amt);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "over_weight_amt", mdFormula.over_weight_amt);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty1", mdFormula.begin_qty1);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty1", mdFormula.end_qty1);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang1",mdFormula.amt_rang1);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty2", mdFormula.begin_qty2);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty2", mdFormula.end_qty2);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang2", mdFormula.amt_rang2);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty3", mdFormula.begin_qty3);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty3", mdFormula.end_qty3);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang3", mdFormula.amt_rang3);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty4", mdFormula.begin_qty4);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty4", mdFormula.end_qty4);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang4", mdFormula.amt_rang4);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty5", mdFormula.begin_qty5);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty5", mdFormula.end_qty5);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang5", mdFormula.amt_rang5);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "begin_qty6", mdFormula.begin_qty6);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "end_qty6", mdFormula.end_qty6);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_rang6", mdFormula.amt_rang6);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "amt_other", mdFormula.amt_other);
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "remark", mdFormula.remark);

                ColumnView view = (ColumnView)dgvDetails;//初始單元格焦點
                view.FocusedColumn = view.Columns["serial_no"];
                view.Focus();
                view.ShowEditor();

             
            }
            else
            {
                MessageBox.Show("注意:当前明细数据为空,或者请首先将当前光标定位到将要复的行!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

	}
}
