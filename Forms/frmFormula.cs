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
using DevExpress.XtraEditors;

//using cf01.Reports;


namespace cfvn.Forms
{
	public partial class frmFormula : DockContent
	{
        private clsPublicOfVN clsApp = new clsPublicOfVN();
        public clsAppPublic clspub = new clsAppPublic();
        
		public string mID = "";    //臨時的主鍵值
		public string mState = ""; //新增或編輯的狀態
		public static string str_language = "0";		
		public bool save_flag;       

		DataTable dtMostly = new DataTable();
		DataTable dtDetails = new DataTable();       
		DataTable dtTempDel = new DataTable();       
        DataTable dtFind_Date = new DataTable();

        //private List<custom_delivry_details> lsModel = new List<custom_delivry_details>();

        public frmFormula()
		{
			InitializeComponent();
            
            //權限
            //clsToolBar obj = new clsToolBar(this.Name, this.Controls);
            //obj.SetToolBar();

            //str_language = DBUtility._language;
            //NextControl oNext = new NextControl(this, "2");
            //oNext.EnterToTab();
		}

		private void frmFormula_Load(object sender, EventArgs e)
		{
            const string sql_h = @"SELECT * From dbo.formula_mostly Where 1=0 ";
            dtMostly=clsApp.GetDataTable(sql_h);            
            bds1.DataSource = dtMostly;
            try
            {
                //數據綁定主档
                txtID.DataBindings.Add("EditValue", bds1, "id");
                txtName.DataBindings.Add("Text", bds1, "name");
                txtremark.DataBindings.Add("Text", bds1, "remark");
                txtCreate_by.DataBindings.Add("Text", bds1, "create_by");
                txtCreate_date.DataBindings.Add("Text", bds1, "create_date");
                txtupdate_by.DataBindings.Add("Text", bds1, "update_by");
                txtupdate_date.DataBindings.Add("Text", bds1, "update_date");
                txtState.DataBindings.Add("Text", bds1, "state");

                const string sql_d = @"Select * from dbo.formula_details Where 1=0";
                dtDetails = clsApp.GetDataTable(sql_d);
                bds2.DataSource = dtDetails;                
                gridControl1.DataSource = bds2;
                //數據綁定明细
                txtserial_no.DataBindings.Add("EditValue", bds2, "serial_no");
                txtname_d.DataBindings.Add("Text", bds2, "name");
                txtminimum_weight.DataBindings.Add("Text", bds2, "minimum_weight");
                txtminimum_amt.DataBindings.Add("Text", bds2, "minimum_amt");
                txtover_weight_amt.DataBindings.Add("Text", bds2, "over_weight_amt");
                txtamt_other.DataBindings.Add("Text", bds2, "amt_other");
                chkIs_large.DataBindings.Add("Checked", bds2, "is_large");
                txtbegin_qty1.DataBindings.Add("Text", bds2, "begin_qty1");
                txtend_qty1.DataBindings.Add("Text", bds2, "end_qty1");
                txtamt_rang1.DataBindings.Add("Text", bds2, "amt_rang1");
                txtbegin_qty2.DataBindings.Add("Text", bds2, "begin_qty2");
                txtend_qty2.DataBindings.Add("Text", bds2, "end_qty2");
                txtamt_rang2.DataBindings.Add("Text", bds2, "amt_rang2");
                txtbegin_qty3.DataBindings.Add("Text", bds2, "begin_qty3");
                txtend_qty3.DataBindings.Add("Text", bds2, "end_qty3");
                txtamt_rang3.DataBindings.Add("Text", bds2, "amt_rang3");
                txtbegin_qty4.DataBindings.Add("Text", bds2, "begin_qty4");
                txtend_qty4.DataBindings.Add("Text", bds2, "end_qty4");
                txtamt_rang4.DataBindings.Add("Text", bds2, "amt_rang4");
                txtbegin_qty5.DataBindings.Add("Text", bds2, "begin_qty5");
                txtend_qty5.DataBindings.Add("Text", bds2, "end_qty5");
                txtamt_rang5.DataBindings.Add("Text", bds2, "amt_rang5");
                txtbegin_qty6.DataBindings.Add("Text", bds2, "begin_qty6");
                txtend_qty6.DataBindings.Add("Text", bds2, "end_qty6");
                txtamt_rang6.DataBindings.Add("Text", bds2, "amt_rang6");
                txtRemark1.DataBindings.Add("Text", bds2, "remark");
            }
            catch (Exception E)
            {                
                throw new Exception(E.Message);
            }

            //公司资料
            DataTable dtCompany = clsApp.GetDataTable(@"Select '' as id,'' as name UNION SELECT id,name From dbo.cd_company Order By id");
            txtID.Properties.DataSource = dtCompany;
            txtID.Properties.ValueMember = "id";
            txtID.Properties.DisplayMember = "id";
            
			//生成明細表,附加費表結構
            //dtDetails = clsPublicOfCF01.GetDataTable("Select * From dbo.custom_delivery_details Where 1=0");           
			//gridControl1.DataSource = dtDetails;            

			//臨時項目刪除表結構
			dtTempDel = dtDetails.Clone();
 
            //欄位表頭居中
            for (int i = 0; i < dgvDetails.Columns.Count; i++)
            {
                dgvDetails.Columns[i].AppearanceHeader.TextOptions.HAlignment=DevExpress.Utils.HorzAlignment.Center;
            }
            txtDat1.EditValue = DateTime.Now.ToString("yyyy-MM-dd");
            txtDat2.EditValue = DateTime.Now.ToString("yyyy-MM-dd");

            splitContainer1.Panel1Collapsed = true;
           
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
                newRow["is_large"] = dgvDetails.GetRowCellDisplayText(curRow, "is_large");
                
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

		private void BTNFIND_Click(object sender, EventArgs e)
		{
            tabControl1.SelectTab(1);//跳至第三頁
		}

		private void AddNew()  //新增
		{
			mState = "NEW";
            bds1.AddNew();
			txtID.Focus();
			SetButtonSatus(false);
            Set_Grid_Status(true);

            SetObjValue.SetEditBackColor(panel1.Controls, true);
            SetObjValue.ClearObjValue(panel1.Controls, "1"); 
            //DataRow dr = dtMostly.NewRow(); //插一空行
            //dtMostly.Rows.InsertAt(dr, 0);

            //lketype_id.EditValue = "";
            txtremark.Text = "";
            txtState.Text = "0";
              
            //GetID_No();                

			dtDetails.Clear();
			gridControl1.DataSource = bds2;
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
			BTNFIND.Enabled = _flag;
			BTNSAVE.Enabled = !_flag;
			BTNCANCEL.Enabled = !_flag;
			BTNITEMADD.Enabled = !_flag;
			BTNITEMDEL.Enabled = !_flag;
         
            //clsToolBar obj = new clsToolBar(this.Name, this.Controls);
            //obj.SetToolBar();
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
                //if (Check_Details_Valid())
                //{
                //    return;
                //}
				Set_Grid_Status(true);
                SetObjValue.SetEditBackColor(tabPage1.Controls, true);
                bds2.AddNew();
                //dgvDetails.AddNewRow();//新增
                dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "id", txtID.EditValue.ToString());               
				//dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "sequence_id", (dgvDetails.RowCount + 1).ToString("0000")+"h");
                //dgvDetails.SetRowCellValue(dgvDetails.FocusedRowHandle, "sec_unit", "KG");
				ColumnView view = (ColumnView)dgvDetails;//初始單元格焦點
                view.FocusedColumn = view.Columns["serial_no"];
				view.Focus();
                txtserial_no.Focus();
                splitContainer1.Panel1Collapsed = false;
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
			bool _flag = false;
			if (dgvDetails.RowCount > 0)
			{
				//txtRemark.Focus();
				//因toolStrip控件焦點問題
				//設置焦點行某單元格獲得焦點，加此代碼目的使輸入的值生效，防止取到的值爲空
                ColumnView view = (ColumnView)dgvDetails;
                view.FocusedColumn = view.Columns["serial_no"];    
				int curRow = 0;
				for (int i = 0; i < dgvDetails.RowCount; i++)
				{
					curRow = dgvDetails.GetRowHandle(i);
                    if (String.IsNullOrEmpty(dgvDetails.GetRowCellDisplayText(curRow, "serial_no")))
					{
						_flag = true;
						MessageBox.Show("目的地代码不可以为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
						ColumnView view1 = (ColumnView)dgvDetails;
                        view1.FocusedColumn = view1.Columns["serial_no"]; //設置單元格焦點                        
						break;
					}
				}
			}
			return _flag;
		}

		private void Cancel() //取消
		{
            bds1.CancelEdit();
            bds2.CancelEdit();
            SetButtonSatus(true);
			//SetObjValue.SetEditBackColor(this.Controls, false);
            SetObjValue.SetEditBackColor(tabPage1.Controls, false);
            SetObjValue.ClearObjValue(tabPage1.Controls, "2");
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
                string sql_h = String.Format(@"SELECT * FROM dbo.formula_mostly WITH(nolock) Where id ='{0}' AND state <>'2'", temp_id);
                dtMostly = clsApp.GetDataTable(sql_h);
                string sql_d = String.Format(@"Select * From dbo.formula_details with(nolock) Where id='{0}'", temp_id);                
                dtDetails = clsApp.GetDataTable(sql_d);
                if (dtMostly.Rows.Count > 0)
                {
                    bds1.DataSource = dtMostly;
                    //dtdate.EditValue = clspub.Return_String_Date(dtdate.EditValue.ToString());
                }
                else
                {
                    //清空数据
                    dtDetails.Clear();
                    bds2.DataSource = dtDetails;
                    SetObjValue.ClearObjValue(tabPage1.Controls, "2");
                    return;
                }
				dtDetails.Clear();
                dtDetails = clsApp.GetDataTable(sql_d);                             
                bds2.DataSource = dtDetails;
                gridControl1.DataSource = bds2;
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
			if (Check_Details_Valid())//检查明细资料的有效性
			{
				return;
			}
			save_flag = false;
            bds1.EndEdit();
            bds2.EndEdit();
			#region  保存新增或編輯
            if (mState == "NEW" || mState == "EDIT")
			{
                if (mState == "NEW")
                {
                    string strSql = String.Format("Select '1' FROM dbo.formula_mostly WHERE id='{0}'", txtID.EditValue.ToString());
                    if (clsApp.ExecuteSqlReturnObject(strSql) != "")
                    {
                        MessageBox.Show(string.Format("此公司数据[{0}]已存在!", txtID.EditValue.ToString()));
                        return;
                        //GetID_No();//如已存在編號則重取最大單據編號
                    }            
                }
                const string sql_i =
                @"INSERT INTO dbo.formula_mostly(id,name,remark,state,create_by,create_date) VALUES (@id,@name,@remark,@state,@user_id,getdate())";
                const string sql_u = @"Update formula_mostly SET remark=@remark,update_by=@user_id,update_date=getdate() WHERE id=@id ";   
                
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
                        myCommand.Parameters.AddWithValue("@name", txtName.Text);                        
                        myCommand.Parameters.AddWithValue("@remark", txtremark.Text);
                        myCommand.Parameters.AddWithValue("@state", "0");                       
                        myCommand.Parameters.AddWithValue("@user_id", DBUtility._user_id);                                       
						myCommand.ExecuteNonQuery();                 

                        //處理【項目刪除】刪除明細資料
                        string sql_item_d;
                        for (int i = 0; i < dtTempDel.Rows.Count; i++)
                        {
                            //刪除明細
                            sql_item_d = @"DELETE FROM dbo.formula_details WHERE id=@id and serial_no=@serial_no and is_large=@is_large";
                            myCommand.CommandText = sql_item_d;
                            myCommand.Parameters.Clear();
                            myCommand.Parameters.AddWithValue("@id", txtID.EditValue.ToString());
                            myCommand.Parameters.AddWithValue("@serial_no", dtTempDel.Rows[i]["serial_no"].ToString());
                            myCommand.Parameters.AddWithValue("@is_large", dtTempDel.Rows[i]["is_large"].ToString()); 
                            myCommand.ExecuteNonQuery();
                        }
                        
                        //保存明細
                        int curRow;
                        string rowStatus;
						if (dgvDetails.RowCount > 0)
						{							
                            const string sql_item_i =
                                @"INSERT INTO dbo.formula_details
                                (id,serial_no,is_large,name,minimum_weight,minimum_amt,over_weight_amt,begin_qty1,end_qty1,amt_rang1,
                                begin_qty2,end_qty2,amt_rang2,begin_qty3,end_qty3,amt_rang3,begin_qty4,end_qty4,amt_rang4,begin_qty5,end_qty5,amt_rang5,
                                begin_qty6,end_qty6,amt_rang6,amt_other,remark) VALUES
                                (@id,@serial_no,@is_large,@name,@minimum_weight,@minimum_amt,@over_weight_amt,@begin_qty1,@end_qty1,@amt_rang1,
                                @begin_qty2,@end_qty2,@amt_rang2,@begin_qty3,@end_qty3,@amt_rang3,@begin_qty4,@end_qty4,@amt_rang4,@begin_qty5,@end_qty5,@amt_rang5,
                                @begin_qty6,@end_qty6,@amt_rang6,@amt_other,@remark)";
                            const string sql_item_u =
                                @"Update dbo.formula_details 
                                SET minimum_weight=@minimum_weight,minimum_amt=@minimum_amt,over_weight_amt=@over_weight_amt,
                                begin_qty1=@begin_qty1,end_qty1=@end_qty1,amt_rang1=@amt_rang1,begin_qty2=@begin_qty2,end_qty2=@end_qty2,amt_rang2=@amt_rang2,
                                begin_qty3=@begin_qty3,end_qty3=@end_qty3,amt_rang3=@amt_rang3,begin_qty4=@begin_qty4,end_qty4=@end_qty4,amt_rang4=@amt_rang4,
                                begin_qty5=@begin_qty5,end_qty5=@end_qty5,amt_rang5=@amt_rang5,begin_qty6=@begin_qty6,end_qty6=@end_qty6,amt_rang6=@amt_rang6,
                                amt_other=@amt_other,remark=@remark Where id=@id AND serial_no=@serial_no AND is_large=@is_large";
                            
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
                                    myCommand.Parameters.AddWithValue("@id", txtID.EditValue.ToString());
                                    myCommand.Parameters.AddWithValue("@serial_no", dgvDetails.GetRowCellValue(curRow, "serial_no").ToString());
                                    myCommand.Parameters.AddWithValue("@name", dgvDetails.GetRowCellValue(curRow, "name").ToString());
                                    myCommand.Parameters.AddWithValue("@minimum_weight", int.Parse(dgvDetails.GetRowCellValue(curRow, "minimum_weight").ToString()));
                                    myCommand.Parameters.AddWithValue("@minimum_amt", float.Parse(dgvDetails.GetRowCellValue(curRow, "minimum_amt").ToString()));
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
                MessageBox.Show("公司编号不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        private void frmFormula_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtMostly.Dispose();
            dtDetails.Dispose();
            dtTempDel.Dispose();
            dtFind_Date.Dispose();
            System.GC.Collect();
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
       
        ///// <summary>
        ///// 取單據序號
        ///// </summary>
        //private void GetID_No()
        //{
        //    if (mState != "")
        //    {                
        //        const string strBill_type = "VD";                
        //        const string sql = @"Select CAST(substring(max(id),3,10) as int) + 1 as bill_code From gsp_vendor_h with(nolock)";
        //        DataTable dt = clsPub.GetDataTable(sql);
        //        if (!string.IsNullOrEmpty(dt.Rows[0]["bill_code"].ToString()))
        //        {                        
        //            txtID.Text = strBill_type + (int.Parse(dt.Rows[0]["bill_code"].ToString())).ToString("0000000000");
        //        }
        //        else
        //        {
        //            txtID.Text = strBill_type + "0000000001";
        //        } 
        //    } 
        //}
          
       
        //東莞D送貨單查詢 ==============BEGIN==============
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (mState != "")
                return;
            Find_Date();
        }

        private void Find_Date()
        {
            if (BTNCANCEL.Enabled)
            {
                Cancel();
                tabControl1.SelectTab(1);
            }
            if (txtDat1.Text == "" && txtDat2.Text == "" &&txtDgid1.Text=="" &&txtDgid2.Text=="" &&txtvendor_id1.Text =="" &&txtvendor_id2.Text=="")
            {
                MessageBox.Show("查询条件不可以为空!", "提示信息");
                return;
            }            
            string sql =
            @"Select A.id,A.name as company_name,B.serial_no,B.name
            FROM dbo.formula_mostly A with(nolock),dbo.formula_details B with(nolock)
            WHERE A.id=B.id ";
            if (txtDgid1.Text != "")
                sql += string.Format(" AND A.id>='{0}'", txtDgid1.Text);
            if (txtDgid2.Text != "")
                sql += string.Format(" AND A.id<='{0}'", txtDgid2.Text);
            //if (txtDat1.Text != "")
            //    sql += string.Format(" AND A.date>='{0}'", txtDat1.Text);
            //if (txtDat2.Text != "")
            //    sql += string.Format(" AND A.date<='{0}'", txtDat2.Text);
            sql += " and A.state<>'2'";
            if (txtvendor_id1.Text != "")
                sql += string.Format(" AND B.serial_no>='{0}'", txtvendor_id1.Text);
            if (txtvendor_id2.Text != "")
                sql += string.Format(" AND B.serial_no<='{0}'", txtvendor_id2.Text); 
            sql += " ORDER BY A.id";
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
                if (txtID.Text != dgvFind.Rows[dgvFind.CurrentCell.RowIndex].Cells["id1"].Value.ToString())
                {
                    txtID.Text = dgvFind.Rows[dgvFind.CurrentCell.RowIndex].Cells["id1"].Value.ToString();
                    //txtVer.Text = dgvFind.Rows[dgvFind.CurrentCell.RowIndex].Cells["ver1"].Value.ToString();
                    Find_doc(txtID.EditValue.ToString());
                }
            }
        }

        private void dgvFind_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string strName = dgvFind.Columns[e.ColumnIndex].Name;
            if (strName == "id1")
            {                
                tabControl1.SelectTab(0);
            }
        }

        private void txtDat1_Leave(object sender, EventArgs e)
        {
            txtDat2.EditValue = txtDat1.EditValue;
        }     

        private void txtDgid1_Leave(object sender, EventArgs e)
        {
            txtDgid2.Text = txtDgid1.Text;
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

        private void BTNCARD_Click(object sender, EventArgs e)
        {
            if (splitContainer1.Panel1Collapsed == false)
                splitContainer1.Panel1Collapsed = true;
            else
                splitContainer1.Panel1Collapsed = false; 
        }
     

        private void clType_id_EditValueChanged(object sender, EventArgs e)
        {
            if (mState != "")
            {
                LookUpEdit objItem = (LookUpEdit)sender;
                string strtype_id = objItem.EditValue.ToString();
                //int indexSelect = clType_id.GetDataSourceRowIndex("id", strtype_id);
                //string strname = clType_id.GetDataSourceValue("name", indexSelect).ToString();
               // gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "type_id_desc", strname);                
            }
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

        private void txtserial_no_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if ((txtID.Text != "") && (mState == "NEW" || mState == "EDIT"))
            {
                using (frmCode ofrmFind = new frmCode())
                {
                    ofrmFind.ShowDialog();
                    if (ofrmFind.strCityCode != "")
                    {
                        txtserial_no.Text = ofrmFind.strCityCode;
                        txtname_d.Text = ofrmFind.strCityName;
                    }
                }
            }
        }

        private void txtserial_no_Leave(object sender, EventArgs e)
        {
            if ((txtID.Text != "") && (mState == "NEW" || mState == "EDIT") && txtserial_no.Text != "")
            {
                clsCityCode obj = new clsCityCode();                
                string strSerial_no = obj.Get_City_Name(txtserial_no.Text);
                if (strSerial_no != "")
                {
                    txtname_d.Text = strSerial_no;
                }
                else
                {
                    txtname_d.Text = "";
                    MessageBox.Show("区域代码不存在！", "提示信息");
                    txtID.Focus();
                }
                
            }
        }

        private void dgvDetails_RowCellClick(object sender, DevExpress.XtraGrid.Views.Grid.RowCellClickEventArgs e)
        {
           // MessageBox.Show("test"); 
        }

       

        private void dgvDetails_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //bds2.EndEdit(); 
        }

        private void dgvDetails_RowClick_1(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
           // MessageBox.Show("test");
        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("test");
        }

        private void dgvDetails_MouseDown(object sender, MouseEventArgs e)
        {
            bds2.EndEdit(); //MessageBox.Show("test");
        }

        private void dgvDetails_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

	}
}
