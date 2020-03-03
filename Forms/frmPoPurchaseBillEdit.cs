using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cfvn.CLS;
using DevExpress.XtraEditors;

namespace cfvn.Forms
{
    public partial class frmPoPurchaseBillEdit : Form
    {
        string m_state = "",m_id="",m_ver="";
        frmPoPurchaseBill myParentForm;
        DataTable dtMM = new DataTable();
        public frmPoPurchaseBillEdit(frmPoPurchaseBill frmParent, string edit_status,string id,string ver)
        {
            InitializeComponent();
            myParentForm = frmParent;
            m_state = edit_status;
            m_id = id;
            m_ver = ver;
            
            if (m_state != "")
                SetObjValue.SetEditBackColor(this.Controls, true);
            else
            {
                SetObjValue.SetEditBackColor(this.Controls, false);
                btnItemAdd.Enabled = false;
                btnItemDel.Enabled = false;
            }
            bdnav.BindingSource = frmPoPurchaseBill.bds_d;            
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();
        }

        private void frmPoPurchaseBillEdit_Load(object sender, EventArgs e)
        {
            //數量單位
            DataTable dtUnitAll = myParentForm.dtUnitAll;
            unit_code.Properties.DataSource = dtUnitAll;
            unit_code.Properties.ValueMember = "id";
            unit_code.Properties.DisplayMember = "id";
            //單價單位
            p_unit.Properties.DataSource = dtUnitAll;
            p_unit.Properties.ValueMember = "id";
            p_unit.Properties.DisplayMember = "id";
            //重量單位
            DataTable dtSec_Unit = myParentForm.dtSec_Unit;
            sec_unit.Properties.DataSource = dtSec_Unit;
            sec_unit.Properties.ValueMember = "id";
            sec_unit.Properties.DisplayMember = "id";

            Set_DataBindings();
        }

        private void Set_DataBindings()
        {
            txtid.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "id");
            txtver.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "ver");
            txtsequence_id.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "sequence_id");
            txtmo_id.DataBindings.Add("Text",frmPoPurchaseBill.bds_d, "mo_id");
            txtgoods_id.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "goods_id");
            txtgoods_name.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "goods_name");
            txtspec.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "spec");
            txtcolor.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "color");
            txtdo_color.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "do_color");
            order_qty.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "order_qty");
            unit_code.DataBindings.Add("EditValue", frmPoPurchaseBill.bds_d, "unit_code");
            sec_qty.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "sec_qty");
            sec_unit.DataBindings.Add("EditValue", frmPoPurchaseBill.bds_d, "sec_unit");
            price.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "price");
            p_unit.DataBindings.Add("EditValue", frmPoPurchaseBill.bds_d, "p_unit");
            disc_rate.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "disc_rate");
            txtdisc_amt.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "disc_amt");
            txtcess.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "cess");
            txttotal_sum.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "total_sum");
            txtbill_origin.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "bill_origin");
            txtdept_id.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "dept_id");
            txtsell_order.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "sell_order");
            txtvendor_goods.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "vendor_goods");
            txtadd_remark.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "add_remark");
            chkso_mark.DataBindings.Add("Checked", frmPoPurchaseBill.bds_d, "so_mark");
            memremark.DataBindings.Add("Text", frmPoPurchaseBill.bds_d, "remark");
            
        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {            
            //frmPoPurchaseBill.bds_d.AddNew();
            myParentForm.AddNew_Item();
            bindingNavigatorMoveLastItem.PerformClick();
            txtid.Text = m_id;
            txtver.Text = m_ver;
            txtsequence_id.Text = m_ver;
            txtmo_id.Text = "Z99999999";
            unit_code.EditValue = "PCS";
            sec_unit.EditValue = "KG";
            p_unit.EditValue = "PCS";
            chkso_mark.Checked = true;            
        }

        private void btnItemDel_Click(object sender, EventArgs e)
        {
            myParentForm.Del_Item();
        }
     
        private void order_qty_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                Check_Is_Update_Amt(order_qty); 
            }
        }

        private void sec_qty_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                Check_Is_Update_Amt(sec_qty);
            }
        }

        private void price_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                Check_Is_Update_Amt(price);
            }
        }

        private void disc_rate_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                Check_Is_Update_Amt(disc_rate);
            }
        }



        private void unit_code_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                Check_Is_Update_Amt_Unit(unit_code);
            }
        }

        private void sec_unit_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                Check_Is_Update_Amt_Unit(sec_unit);
            }
        }

        private void p_unit_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                Check_Is_Update_Amt_Unit(p_unit);
            }
        }


        /// <summary>
        /// 計算明細當前行金額
        /// </summary>
        /// <param name="column_name"></param>
        private void Check_Is_Update_Amt(TextEdit obj)
        {
            if (m_state!="")
            {
                string ls_column_name = "";
                switch (obj.Name)
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
                //dgvDetails.CloseEditor();
                //int cur_row = dgvDetails.FocusedRowHandle;
                decimal ldc_value, ldc_original_value = 0;
                ldc_value = decimal.Parse(obj.Text);
                if (ldc_value == 0)
                {
                    return;
                }
                //取得修改前的原始值               
                //DataRow myEditDataRow = dgvDetails.GetDataRow(cur_row);
                DataRow myEditDataRow = ((DataRowView)frmPoPurchaseBill.bds_d.Current).Row;               
                try
                {
                    ldc_original_value = decimal.Parse(myEditDataRow[ls_column_name, DataRowVersion.Original].ToString());
                }
                catch
                {
                    ldc_original_value = 0;
                }
                
                if (ldc_value != ldc_original_value)
                {
                    Count_Row_Amount_Details();
                }
            }
        }

        /// <summary>
        /// 計算明細當前行金額(更改數量單位,重量單位,單價單位)
        /// </summary>
        /// <param name="column_name"></param>
        private void Check_Is_Update_Amt_Unit(LookUpEdit obj)
        {
            if (m_state!="")
            {
                string ls_column_name = "";
                switch (obj.Name)
                {
                    case "unit_code":
                        ls_column_name = "unit_code";
                        break;
                    case "sec_unit":
                        ls_column_name = "sec_unit";
                        break;
                    case "p_unit":
                        ls_column_name = "p_unit";
                        break;
                    default:
                        break;
                }
                string ls_value, ls_original_value = "";
                ls_value = obj.EditValue.ToString();
                if (ls_value == "")
                {
                    return;
                }
                //取得修改前的原始值               
                DataRow myEditDataRow = ((DataRowView)frmPoPurchaseBill.bds_d.Current).Row;              
                try
                {
                    ls_original_value = myEditDataRow[ls_column_name, DataRowVersion.Original].ToString();
                }
                catch
                {
                    ls_original_value = "";
                }

                if (ls_value != ls_original_value)
                {
                    Count_Row_Amount_Details();
                }
            }
        }

        /// <summary>
        /// 計算明細當前行金額公式
        /// </summary>
        public void Count_Row_Amount_Details()
        {           
            decimal ldc_order_qty = 0, ldc_sec_qty, ldc_price, ldc_disc_rate, ldc_disc_amt = 0, ldc_total_sum = 0;
            string ls_unit_code, ls_sec_unit, ls_p_unit;
            ls_unit_code = unit_code.Text ;//數量單位
            ls_sec_unit = sec_unit.Text;//單價單位
            ls_p_unit = p_unit.Text;

            if (!string.IsNullOrEmpty(order_qty.Text))
            {
                ldc_order_qty = decimal.Parse(order_qty.Text);
            }
            else
                ldc_order_qty = 0;
            if (!string.IsNullOrEmpty(sec_qty.Text))
                ldc_sec_qty = decimal.Parse(sec_qty.Text);
            else
                ldc_sec_qty = 0;
            if (!string.IsNullOrEmpty(price.Text))
                ldc_price = decimal.Parse(price.Text);
            else
                ldc_price = 0;
            if (!string.IsNullOrEmpty(disc_rate.Text))
                ldc_disc_rate = decimal.Parse(disc_rate.Text);
            else
                ldc_disc_rate = 0;

            //貨品金額是以數量計算或者重量計算是以單價單位為基準,誰的單位與單價單位相等,就用誰乘以單價
            //如果單價單位與訂單數量單位相同,貨品金額=單價x訂單數量
            if (ls_p_unit == ls_unit_code)
                ldc_total_sum = decimal.Parse(Math.Round(ldc_order_qty * ldc_price, 2).ToString());
            else
                ldc_total_sum = 0;
            //如果單價單位與重量單位相同,貨品金額=單價x重量
            if (ls_p_unit == ls_sec_unit)
            {
                ldc_total_sum = ldc_sec_qty * ldc_price;
            }
            if (ls_p_unit != ls_unit_code && ls_p_unit != ls_sec_unit)
            {
                ldc_total_sum = 0;
            }
            ldc_disc_amt = decimal.Parse(Math.Round(ldc_total_sum * (ldc_disc_rate / 100), 2).ToString());
            ldc_total_sum = ldc_total_sum - ldc_disc_amt;
            txtdisc_amt.Text = ldc_disc_amt.ToString();
            txttotal_sum.Text = ldc_total_sum.ToString();
            frmPoPurchaseBill.bds_d.EndEdit();//更新父表中的明細
            myParentForm.Count_Amount();//重新計算主檔總金額
        }

        private void frmPoPurchaseBillEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPoPurchaseBill.bds_d.EndEdit();
        }

        private void txtgoods_id_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void txtgoods_id_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (m_state != "")
            //{
            //    string s = e.KeyChar.ToString();
            //    if (txtgoods_id.Text != "")
            //    {
            //        dtMM = clsPoPurchase.Get_MM(txtgoods_id.Text);
            //        lueGoods_id.Properties.DataSource = dtMM;
            //        lueGoods_id.Properties.ValueMember = "id";
            //        lueGoods_id.Properties.DisplayMember = "id";
            //        lueGoods_id.Text = txtgoods_id.Text;
            //    }
            //}
        }

        private void lueGoods_id_EditValueChanged(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                txtgoods_id.Text = lueGoods_id.Text;
                txtgoods_name.Text = lueGoods_id.GetColumnValue("name").ToString();
            }
        }

        private void txtgoods_id_KeyUp(object sender, KeyEventArgs e)
        {
            if (m_state != "")
            {                
                if (txtgoods_id.Text != "")
                {
                    dtMM = clsPoPurchase.Get_MM(txtgoods_id.Text);
                    lueGoods_id.Properties.DataSource = dtMM;
                    lueGoods_id.Properties.ValueMember = "id";
                    lueGoods_id.Properties.DisplayMember = "id";
                    lueGoods_id.Text = txtgoods_id.Text;                    
                }
               
            }
        }



    }
}
