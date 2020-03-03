using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace cfvn.Forms
{
    public partial class frmCodeEdit : Form
    {
        public bool is_CanEditKeyValue, is_new_or_edit;      
        public frmCodeEdit(bool CanModifyKey,bool new_or_edit)
        {            
            InitializeComponent();
            is_CanEditKeyValue = CanModifyKey;
            is_new_or_edit = new_or_edit;
        }        

        private void frmCodeEdit_Load(object sender, EventArgs e)
        {
            bindingNavigator1.BindingSource = frmCodeFormula.myBDS2;
            //數據綁定明细
            try
            {
                txtserial_no.DataBindings.Add("EditValue", frmCodeFormula.myBDS2, "serial_no");
                txtName.DataBindings.Add("Text", frmCodeFormula.myBDS2, "name");
                txtProvince.DataBindings.Add("Text", frmCodeFormula.myBDS2, "province");
                txtminimum_weight.DataBindings.Add("Text", frmCodeFormula.myBDS2, "minimum_weight");
                txtminimum_amt.DataBindings.Add("Text", frmCodeFormula.myBDS2, "minimum_amt");
                txtover_weight_amt.DataBindings.Add("Text", frmCodeFormula.myBDS2, "over_weight_amt");
                txtamt_other.DataBindings.Add("Text", frmCodeFormula.myBDS2, "amt_other");
                chkIs_large.DataBindings.Add("Checked", frmCodeFormula.myBDS2, "is_large");
                txtbegin_qty1.DataBindings.Add("Text", frmCodeFormula.myBDS2, "begin_qty1");
                txtend_qty1.DataBindings.Add("Text", frmCodeFormula.myBDS2, "end_qty1");
                txtamt_rang1.DataBindings.Add("Text", frmCodeFormula.myBDS2, "amt_rang1");
                txtbegin_qty2.DataBindings.Add("Text", frmCodeFormula.myBDS2, "begin_qty2");
                txtend_qty2.DataBindings.Add("Text", frmCodeFormula.myBDS2, "end_qty2");
                txtamt_rang2.DataBindings.Add("Text", frmCodeFormula.myBDS2, "amt_rang2");
                txtbegin_qty3.DataBindings.Add("Text", frmCodeFormula.myBDS2, "begin_qty3");
                txtend_qty3.DataBindings.Add("Text", frmCodeFormula.myBDS2, "end_qty3");
                txtamt_rang3.DataBindings.Add("Text", frmCodeFormula.myBDS2, "amt_rang3");
                txtbegin_qty4.DataBindings.Add("Text", frmCodeFormula.myBDS2, "begin_qty4");
                txtend_qty4.DataBindings.Add("Text", frmCodeFormula.myBDS2, "end_qty4");
                txtamt_rang4.DataBindings.Add("Text", frmCodeFormula.myBDS2, "amt_rang4");
                txtbegin_qty5.DataBindings.Add("Text", frmCodeFormula.myBDS2, "begin_qty5");
                txtend_qty5.DataBindings.Add("Text", frmCodeFormula.myBDS2, "end_qty5");
                txtamt_rang5.DataBindings.Add("Text", frmCodeFormula.myBDS2, "amt_rang5");
                txtbegin_qty6.DataBindings.Add("Text", frmCodeFormula.myBDS2, "begin_qty6");
                txtend_qty6.DataBindings.Add("Text", frmCodeFormula.myBDS2, "end_qty6");
                txtamt_rang6.DataBindings.Add("Text", frmCodeFormula.myBDS2, "amt_rang6");
                txtRemark1.DataBindings.Add("Text", frmCodeFormula.myBDS2, "remark");
            }
            catch (Exception E)
            {
                throw new Exception(E.Message);
            }        
    
            
            Set_Key_Enable(is_CanEditKeyValue);

            if (is_new_or_edit)
            {
                txtminimum_weight.Properties.ReadOnly = !is_new_or_edit;
                txtminimum_amt.Properties.ReadOnly = !is_new_or_edit;
                txtover_weight_amt.Properties.ReadOnly = !is_new_or_edit;
                txtamt_other.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty1.Properties.ReadOnly = !is_new_or_edit;
                txtend_qty1.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang1.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty2.Properties.ReadOnly = !is_new_or_edit;
                txtend_qty2.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang2.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty3.Properties.ReadOnly = !is_new_or_edit;
                txtend_qty3.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang3.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty4.Properties.ReadOnly = !is_new_or_edit;
                txtend_qty4.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang4.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty5.Properties.ReadOnly = !is_new_or_edit;
                txtend_qty5.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang5.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty6.Properties.ReadOnly = !is_new_or_edit;
                txtend_qty6.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang6.Properties.ReadOnly = !is_new_or_edit;
                txtRemark1.Properties.ReadOnly = !is_new_or_edit;
            }
            else
            {
                //非编辑状态将控年设为不可以修改数据
                txtserial_no.Properties.ReadOnly = is_new_or_edit;
                chkIs_large.Enabled = false;
                txtminimum_weight.Properties.ReadOnly = !is_new_or_edit;
                txtminimum_amt.Properties.ReadOnly = !is_new_or_edit;
                txtover_weight_amt.Properties.ReadOnly = !is_new_or_edit;
                txtamt_other.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty1.Properties.ReadOnly = !is_new_or_edit;
                txtend_qty1.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang1.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty2.Properties.ReadOnly = !is_new_or_edit;
                txtend_qty2.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang2.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty3.Properties.ReadOnly = is_new_or_edit;
                txtend_qty3.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang3.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty4.Properties.ReadOnly = !is_new_or_edit;
                txtend_qty4.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang4.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty5.Properties.ReadOnly = !is_new_or_edit;
                txtend_qty5.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang5.Properties.ReadOnly = !is_new_or_edit;
                txtbegin_qty6.Properties.ReadOnly = !is_new_or_edit;
                txtend_qty6.Properties.ReadOnly = !is_new_or_edit;
                txtamt_rang6.Properties.ReadOnly = !is_new_or_edit;
                txtRemark1.Properties.ReadOnly = !is_new_or_edit;
            }

        }

        private void Set_Key_Enable(bool is_can_modify_key)
        {
            if (is_can_modify_key)
            {
                txtserial_no.Enabled = true;
                chkIs_large.Enabled = true;
            }
            else
            {
                txtserial_no.Enabled = false;
                chkIs_large.Enabled = false;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
            frmCodeFormula.myBDS2.EndEdit();            
            //frmCodeFormula.myBDS2.ResetCurrentItem();
            //DataTable dt = new DataTable();
            //dt = (DataTable)frmCodeFormula.myBDS2.DataSource;
            Close();
        }

        private void txtserial_no_Properties_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            using (frmCode ofrmCode = new frmCode())
            {
                ofrmCode.ShowDialog();
                if (ofrmCode.strCityCode != "")
                {
                    txtserial_no.EditValue = ofrmCode.strCityCode;
                    txtName.Text = ofrmCode.strCityName;
                    txtProvince.Text = ofrmCode.strProvince;
                }
            }
        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            Set_Record_Location();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {
            Set_Record_Location();
        }

        private void bindingNavigatorMovePreviousItem_Click(object sender, EventArgs e)
        {
            Set_Record_Location();
        }

        private void bindingNavigatorMoveFirstItem_Click(object sender, EventArgs e)
        {
            Set_Record_Location();
        }

        private void Set_Record_Location()
        {
            DataRowView drv = frmCodeFormula.myBDS2.Current as DataRowView;
            string strOrg_serial_no = drv["org_serial_no"].ToString();
            bool is_CanEditKeyValue;
            if (string.IsNullOrEmpty(strOrg_serial_no))
            {
                is_CanEditKeyValue = true;
            }
            else
            {
                is_CanEditKeyValue = false;
            }
            if (is_new_or_edit)
            {
                Set_Key_Enable(is_CanEditKeyValue);
            }
        }

        private void frmCodeEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmCodeFormula.myBDS2.EndEdit();          
        }

        private static void Set_Number_Focus(DevExpress.XtraEditors.TextEdit objTextEdit)
        {
            if (objTextEdit.Text == "0.00")
            {
                objTextEdit.Select(1, 0);
            }
        }

        private void txtminimum_amt_EditValueChanged(object sender, EventArgs e)
        {
            Set_Number_Focus(txtminimum_amt);
        }

        private void txtover_weight_amt_Click(object sender, EventArgs e)
        {
            Set_Number_Focus(txtover_weight_amt);
        }

        private void txtamt_other_Click(object sender, EventArgs e)
        {
            Set_Number_Focus(txtamt_other);
        }

        private void txtamt_rang1_Click(object sender, EventArgs e)
        {
            Set_Number_Focus(txtamt_rang1);
        }

        private void txtamt_rang2_Click(object sender, EventArgs e)
        {
            Set_Number_Focus(txtamt_rang2);
        }

        private void txtamt_rang3_Click(object sender, EventArgs e)
        {
            Set_Number_Focus(txtamt_rang3);
        }

        private void txtamt_rang4_Click(object sender, EventArgs e)
        {
            Set_Number_Focus(txtamt_rang4);
        }

        private void txtamt_rang5_Click(object sender, EventArgs e)
        {
            Set_Number_Focus(txtamt_rang5);
        }

        private void txtamt_rang6_Click(object sender, EventArgs e)
        {
            Set_Number_Focus(txtamt_rang6);
        }
        

    }
}
