using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using DevExpress.XtraGrid.Views.Base;
using System.Data.OleDb;



namespace SysDaan.Forms
{
    public partial class Form3 : Form //DockContent
    {
        public string mState = ""; //新增或編輯的狀態
        public static string str_language = "0";
        public string msgCustom;
        public bool save_flag;
        DataTable dtDepartment = new DataTable();
        DataTable dtTempDel = new DataTable();
        AccessHelper objAcess = new AccessHelper();
        public Form3()
        {
            InitializeComponent();
            mState = "EDIT";
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            dtDepartment = objAcess.GetDataTable(@"SELECT * FROM department WHERE pkey>0");
            gridControl1.DataSource = dtDepartment;
            dtTempDel = dtDepartment.Clone();
            gridView1.OptionsBehavior.Editable = true ;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtPkey.Focus();
            gridView1.CloseEditor();
            Save();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
           // Load_Data();
        }


        private void SetButtonSatus(bool _flag)
        {
            btnNew.Enabled = _flag;
            btnEdit.Enabled = _flag;
            btnPrint.Enabled = _flag;
            btnDeleted.Enabled = _flag;
            btnExcel.Enabled = _flag;
            btnSave.Enabled = !_flag;
            btnCancel.Enabled = !_flag;
        }



        private void btnEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void Edit()  //編號
        {
            if (gridView1.RowCount == 0)
            {
                return;
            }
            //tabControl1.SelectTab(0);
            SetButtonSatus(false);
            Set_Grid_Status(true);
            //SetObjValue.SetEditBackColor(tabControl1.TabPages[0].Controls, true);

            //txtBrand_id.Properties.ReadOnly = true;
            //txtBrand_id.BackColor = System.Drawing.Color.White;

            //dgvDetails.Enabled = false;
            //mState = "EDIT";

            //txtBrand_id.Properties.ReadOnly = true;
        }

        private void Set_Grid_Status(bool _flag) // 表格是否可編輯
        {
            //false--不可編輯;true--可以編輯
            gridView1.OptionsBehavior.Editable = _flag;
            //gridView2.OptionsBehavior.Editable = _flag;                       
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void btnNew_Click(object sender, EventArgs e)
        {
            AddNew();
        }
     

        public void AddNew()  //新增
        {
            mState = "EDIT";
            Set_Grid_Status(true);
            gridView1.AddNewRow();//新增
            gridView1.SetRowCellValue(gridView1.FocusedRowHandle, "seq_id", 0);
            ColumnView view = (ColumnView)gridView1;//初始單元格焦點
            view.FocusedColumn = view.Columns["dept_id"];
            view.Focus();
        }

        private void Save()  //保存
        {            
            if (!Check_Details_Valid())//檢查明細資料的有效性
            {
                return;
            }
            save_flag = false;
            #region 保存編輯
            if (mState == "EDIT")
            {
                string rowStatus = "";
               // string strSeq_id = "";
                const string sql_item_i =
                    @"INSERT INTO department(dept_id,remark,crusr,crtim)
					VALUES(@dept_id,@remark,@user_id,now())";
                const string sql_item_u =
                    @"UPDATE department 
					SET dept_id=@dept_id,remark=@remark,amusr=@user_id,amtim=now()                        
					WHERE pkey=@pkey";
                string conn_str = DBUtility.conn_str;
                OleDbConnection myCon = new OleDbConnection(conn_str);
                myCon.Open();
                OleDbTransaction myTrans = myCon.BeginTransaction();
                using (OleDbCommand myCommand = new OleDbCommand() { Connection = myCon, Transaction = myTrans })
                {
                    try
                    {
                        //刪除明細資料
                        for (int i = 0; i < dtTempDel.Rows.Count; i++)
                        {
                            const string sql_item_d = @"DELETE FROM department WHERE pkey=@pkey";
                            myCommand.CommandText = sql_item_d;
                            myCommand.Parameters.Clear();                           
                            myCommand.Parameters.AddWithValue("@pkey", dtTempDel.Rows[i]["pkey"].ToString());                            
                            myCommand.ExecuteNonQuery();
                        }
                        //保存明細資料                        
                        
                        if (gridView1.RowCount > 0)
                        {
                            for (int i = 0; i < dtDepartment.Rows.Count; i++)
                            {
                                rowStatus = dtDepartment.Rows[i].RowState.ToString();
                                if (rowStatus == "Added" || rowStatus == "Modified")
                                {
                                    myCommand.Parameters.Clear();
                                    myCommand.Parameters.AddWithValue("@dept_id", dtDepartment.Rows[i]["dept_id"].ToString());
                                    myCommand.Parameters.AddWithValue("@remark", dtDepartment.Rows[i]["remark"].ToString());
                                    myCommand.Parameters.AddWithValue("@user_id", DBUtility._user_id);
                                    //myCommand.Parameters.AddWithValue("@create_date", DateTime.Now.ToShortDateString());
                                    
                                    if (rowStatus == "Added")
                                    {
                                        myCommand.CommandText = sql_item_i;
                                        //strSeq_id = gridView1.GetRowCellValue(i, "seq_id").ToString();
                                        //if (Valid_Doc(txtTemp_code.Text, strSeq_id))
                                        //{
                                        //    //如存主鍵已存在重取取最大序號
                                        //    strSeq_id = Get_Details_Seq(txtTemp_code.Text);
                                        //    gridView1.SetRowCellValue(i, "seq_id", strSeq_id);//重設置表格中的序號
                                        //}
                                    }
                                    if (rowStatus == "Modified")
                                    {
                                        myCommand.CommandText = sql_item_u;
                                        myCommand.Parameters.AddWithValue("@pkey", dtDepartment.Rows[i]["pkey"].ToString());
                                        //strSeq_id = dtDepartment.Rows[i]["seq_id"].ToString();//編輯狀態原序號保持不變
                                    }
                                    //myCommand.Parameters.AddWithValue("@seq_id", strSeq_id);
                                    //myCommand.Parameters.AddWithValue("@user_id", DBUtility._user_id);
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
                        myTrans.Dispose();
                    }
                }
            }
            #endregion
            if (save_flag)
            {
                //dtSub.AcceptChanges();//需加此語句，刷新dtSub的新增個修改的狀態
                MessageBox.Show("數據保存成功!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("數據保存失敗!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private bool Check_Details_Valid() //保存前檢查主檔資料有效性
        {
            string str_value = "";
            bool _flag = true;
            for (int i = 0; i < gridView1.RowCount; i++)
            {
                str_value = gridView1.GetRowCellDisplayText(i, "dept_id");
                if (string.IsNullOrEmpty(str_value.Trim()))
                {
                    _flag = false;
                    break ;
                }
            }

            if (!_flag )
            {
                MessageBox.Show("部门资料不可以为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);               
            }
            return _flag;
            
        }

        private void btnDeleted_Click(object sender, EventArgs e)
        {
            if (gridView1.RowCount == 0)
            {
                return;
            }
            DialogResult result = MessageBox.Show("是否要刪除當前行?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                int curRow = gridView1.FocusedRowHandle;
                //將當前行刪除幷加到臨時表中
                DataRow newRow = dtTempDel.NewRow();
                newRow["dept_id"] = gridView1.GetRowCellDisplayText(curRow, "dept_id");
                newRow["pkey"] = gridView1.GetRowCellDisplayText(curRow, "pkey");
                
                dtTempDel.Rows.Add(newRow);
                gridView1.DeleteRow(curRow);//移走當前行
                Save();
            }
        }

     
    }
}
