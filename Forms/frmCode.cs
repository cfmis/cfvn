using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using cfvn.CLS;
using System.Data.SqlClient;

namespace cfvn.Forms
{
    public partial class frmCode : DevExpress.XtraEditors.XtraForm
    {
        private clsPublicOfVN clsApp = new clsPublicOfVN();
        DataTable dtBom2 = new DataTable();
        public string strCityCode = "";
        public string strCityName = "";
        public string strProvince = "";
        public frmCode()
        {
            InitializeComponent();
        }

        private void frmCode_Load(object sender, EventArgs e)
        {
            //1级资料            
            DataTable dtLeave1 = clsApp.GetDataTable(@"Select serial_no,name,parent_id From dbo.level1 Order By serial_no");
            lueLevel1.Properties.DataSource = dtLeave1;
            lueLevel1.Properties.ValueMember = "serial_no";
            lueLevel1.Properties.DisplayMember = "name";
            lueLevel1.EditValue = "44";//默认省份为广东

            //2级资料
            string strSql = @"Select '' as serial_no,'' as name,'' as parent_id,'' as name_parent 
             Union Select A.serial_no,A.name,A.parent_id ,B.name as name_parent
             From dbo.levelall A Inner join dbo.levelall B ON A.parent_id=B.serial_no
             Where A.levels='2'";
            DataTable dtLeave2 = clsApp.GetDataTable(strSql);
            //DataTable dtLeave2 = clsApp.GetDataTable(@"Select serial_no,name,parent_id From dbo.level2 Order By serial_no");
            lueLevel2.Properties.DataSource = dtLeave2;
            lueLevel2.Properties.ValueMember = "serial_no";
            lueLevel2.Properties.DisplayMember = "name";

            //3级资料
            strSql = @"Select '' as serial_no,'' as name,'' as parent_id,'' as name_parent 
             Union Select A.serial_no,A.name,A.parent_id ,B.name as name_parent
             From dbo.levelall A Inner join dbo.levelall B ON A.parent_id=B.serial_no
             Where A.levels='3'";
            DataTable dtLeave3 = clsApp.GetDataTable(strSql);
            //DataTable dtLeave3 = clsApp.GetDataTable(@"Select serial_no,name,parent_id From dbo.level3 Order By serial_no");
            lueLevel3.Properties.DataSource = dtLeave3;
            lueLevel3.Properties.ValueMember = "serial_no";
            lueLevel3.Properties.DisplayMember = "name";
        }

        private void frmCode_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsApp = null;
            dtBom2.Dispose();
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (txtSearch.Text != "")
            {
                switch (e.KeyCode)
                {
                    case Keys.Enter:
                        /*string strSql = string.Format(
                        @"SELECT A.serial_no,A.name,A.parent_id,A.levels,B.name as name_parent,B.levels as level_parent
                        FROM level_all A INNER JOIN level_all B ON A.parent_id=B.serial_no  
                        Where A.name like '%{0}%'
                        ORDER BY A.levels,A.serial_no",txtSearch.Text.Trim());*/
                        string strSql = string.Format(
                        @"SELECT A.serial_no,A.name,A.parent_id,A.levels,B.name as name_parent,B.levels as level_parent
                        FROM levelall A INNER JOIN levelall B ON A.parent_id=B.serial_no  
                        Where CONTAINS(A.name,'{0}')
                        ORDER BY A.levels,A.serial_no", txtSearch.Text.Trim());
                        DataTable dtSearch = clsApp.GetDataTable(strSql);
                        if (dtSearch.Rows.Count > 0)
                        {
                            txtTotal.Text = dtSearch.Rows.Count.ToString();
                        }
                        else
                        {
                            txtTotal.Text = "0";
                        }
                        dgvList.DataSource = dtSearch;
                        txtSearch.Focus();
                        break;
                }
            }
        }

        
        private void dgvList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvList.Rows.Count > 0)
            {
                SqlParameter[] paras=new SqlParameter[]{
                    new SqlParameter("@serial_no",dgvList.CurrentRow.Cells["serial_no"].Value.ToString())
                };

                DataTable dtBom = clsApp.ExecuteProcedureReturnTable("usp_bom_for_city", paras);
                dtBom2.Clear();
                dtBom2= dtBom.Copy();
                if (dtBom.Rows.Count > 0)
                {
                    lueLevel1.EditValue = "";
                    lueLevel2.EditValue = "";
                    lueLevel2.Properties.DataSource = null;
                    lueLevel3.EditValue = "";
                    lueLevel3.Properties.DataSource = null;
                    lueLevel4.EditValue = "";
                    lueLevel4.Properties.DataSource = null;
                    lueLevel5.EditValue = "";
                    lueLevel5.Properties.DataSource = null;
                    string strLevel="",strSerial_no = "";
                    //for (int i = 0; i < dtBom.Rows.Count; i++)
                    for (int i = dtBom.Rows.Count-1; i >=0; i--)
                    {
                        strLevel = dtBom.Rows[i]["levels"].ToString();
                        strSerial_no = dtBom.Rows[i]["serial_no"].ToString();
                        switch (strLevel)
                        {
                            case "5":
                                //SetLevel5(strSerial_no, dtBom.Rows[i]["name"].ToString(), dtBom.Rows[i]["parent_id"].ToString());
                                lueLevel5.EditValue = strSerial_no;
                                break;
                            case "4":
                                lueLevel4.EditValue = strSerial_no;
                                SetLevels_By_Search(strSerial_no, lueLevel5);
                                //SetLevel4(strSerial_no);
                                break;
                            case "3":
                                lueLevel3.EditValue = strSerial_no;
                                SetLevels_By_Search(strSerial_no, lueLevel4);
                                break;
                            case "2":
                                lueLevel2.EditValue = strSerial_no;
                                SetLevels_By_Search(strSerial_no, lueLevel3);
                                break;
                            case "1":
                                lueLevel1.EditValue = strSerial_no;
                                SetLevels_By_Search(strSerial_no, lueLevel2);
                                break;
                            default:                                
                                break;
                        }
                    }                    
                }
                else
                {
                    lueLevel1.EditValue = "";
                    lueLevel2.EditValue = "";
                    lueLevel2.Properties.DataSource = null;
                    lueLevel3.EditValue = "";
                    lueLevel3.Properties.DataSource = null;
                    lueLevel4.EditValue = "";
                    lueLevel4.Properties.DataSource = null;
                    lueLevel5.EditValue = "";
                    lueLevel5.Properties.DataSource = null;
                }
            }       
        }

        private void SetLevels_By_Search(string strSerial_no,LookUpEdit objCombox )
        {
            string strSql = string.Format(
            @"Select '' as serial_no,'' as name,'' as parent_id,'' as name_parent 
             Union Select A.serial_no,A.name,A.parent_id ,B.name as name_parent
             From dbo.levelall A Inner join dbo.levelall B ON A.parent_id=B.serial_no
             Where A.parent_id='{0}'", strSerial_no);
            DataTable dt = clsApp.GetDataTable(strSql);
            objCombox.Properties.DataSource = dt;
            objCombox.Properties.ValueMember = "serial_no";
            objCombox.Properties.DisplayMember = "name";
        }
       
        private void lueLevel2_Enter(object sender, EventArgs e)
        {
            SetLevels_By_DropCompbox(lueLevel1, lueLevel2);
        }

        private void lueLevel3_Enter(object sender, EventArgs e)
        {
            SetLevels_By_DropCompbox(lueLevel2, lueLevel3);
        }

        private void lueLevel4_Enter(object sender, EventArgs e)
        {
            SetLevels_By_DropCompbox(lueLevel3, lueLevel4);
        }

        private void lueLevel5_Enter(object sender, EventArgs e)
        {
            SetLevels_By_DropCompbox(lueLevel4, lueLevel5);
        }

        private void lueLevel2_EditValueChanged(object sender, EventArgs e)
        {
            if (lueLevel2.Text == "")
            {
                Clear_DropBox(lueLevel2);
            }
        }

        private void lueLevel3_EditValueChanged(object sender, EventArgs e)
        {
            if (lueLevel3.Text == "")
            {
                Clear_DropBox(lueLevel3);
            }
        }

        private void lueLevel4_EditValueChanged(object sender, EventArgs e)
        {
            if (lueLevel4.Text == "")
            {
                Clear_DropBox(lueLevel4);
            }
        }

        private void SetLevels_By_DropCompbox(LookUpEdit prev_objCombox, LookUpEdit cur_objCombox)
        {
            string strSerial_no = prev_objCombox.EditValue.ToString();
            if (!string.IsNullOrEmpty(strSerial_no))
            {
                string strSql = string.Format(
                @"Select '' as serial_no,'' as name,'' as parent_id,'' as name_parent 
                 Union Select A.serial_no,A.name,A.parent_id ,B.name as name_parent
                 From dbo.levelall A Inner join dbo.levelall B ON A.parent_id=B.serial_no
                 Where A.parent_id='{0}'", strSerial_no);
                DataTable dt = clsApp.GetDataTable(strSql);
                cur_objCombox.Properties.DataSource = dt;
                cur_objCombox.Properties.ValueMember = "serial_no";
                cur_objCombox.Properties.DisplayMember = "name";

                //如果当前控键值为空，则之后的控件值清空
                if (cur_objCombox.Text == "")
                {
                    Clear_DropBox(cur_objCombox);
                }
            }
            else
            {
                cur_objCombox.Properties.DataSource = null;
                cur_objCombox.EditValue = "";
                Clear_DropBox(cur_objCombox);
            }
        }

        private void Clear_DropBox(LookUpEdit cur_objCombox)
        {
            switch (cur_objCombox.Name)
            {
                case "lueLevel2":
                    lueLevel3.Properties.DataSource = null;
                    lueLevel3.EditValue = "";
                    lueLevel4.Properties.DataSource = null;
                    lueLevel4.EditValue = "";
                    lueLevel5.Properties.DataSource = null;
                    lueLevel5.EditValue = "";
                    break;
                case "lueLevel3":
                    lueLevel4.Properties.DataSource = null;
                    lueLevel4.EditValue = "";
                    lueLevel5.Properties.DataSource = null;
                    lueLevel5.EditValue = "";
                    break;
                case "lueLevel4":
                    lueLevel5.Properties.DataSource = null;
                    lueLevel5.EditValue = "";
                    break;
            }
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {                    
            for (int i = 5; i - 1 >= 0; i--)
            {
                    if (lueLevel5.Text != "")
                    {
                        strCityCode = lueLevel5.EditValue.ToString();
                        strCityName = lueLevel5.Text;
                        break;
                    }
                    if (lueLevel4.Text != "")
                    {
                        strCityCode = lueLevel4.EditValue.ToString();
                        strCityName = lueLevel4.Text;
                        break;
                    }
                    if (lueLevel3.Text != "")
                    {
                        strCityCode = lueLevel3.EditValue.ToString();
                        strCityName = lueLevel3.Text;
                        break;
                    }
                    if (lueLevel2.Text != "")
                    {
                        strCityCode = lueLevel2.EditValue.ToString();
                        strCityName = lueLevel2.Text;
                        break;
                    }
                    if (lueLevel1.Text != "")
                    {
                        strCityCode = lueLevel1.EditValue.ToString();
                        strCityName = lueLevel1.Text;
                        break;
                    }
            }
            strProvince = lueLevel1.Text;
            Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            strCityCode = "";
            strCityName = "";
            strProvince = "";
            Close();
        }

        
    
    }
}