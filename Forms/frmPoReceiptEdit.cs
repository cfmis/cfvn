using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cfvn.CLS;

namespace cfvn.Forms
{
    public partial class frmPoReceiptEdit : Form
    {
        string m_state = "", m_id = "", m_bill_origin_id;
        frmPoReceipt myParentForm;
        public clsAppPublic objPub = new clsAppPublic();

        DataTable dtMM = new DataTable();
        public frmPoReceiptEdit(frmPoReceipt frmParent, string edit_status, string id,string bill_type )
        {
            InitializeComponent();
            myParentForm = frmParent;
            m_state = edit_status;
            m_id = id;
            m_bill_origin_id = bill_type;

            if (m_state != "")
                SetObjValue.SetEditBackColor(this.Controls, true);
            else
            {
                SetObjValue.SetEditBackColor(this.Controls, false);
                btnItemAdd.Enabled = false;
                btnItemDel.Enabled = false;
            }
            bdnav.BindingSource = frmPoReceipt.bds_d;
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();
        }

        private void frmPoReceiptEdit_Load(object sender, EventArgs e)
        {
            //數量單位
            DataTable dtUnitAll = clsCommon.GetUnitAll();
            lueunit_code.Properties.DataSource = dtUnitAll;
            lueunit_code.Properties.ValueMember = "id";
            lueunit_code.Properties.DisplayMember = "id";
            //單價單位
            lueunit_code.Properties.DataSource = dtUnitAll;
            lueunit_code.Properties.ValueMember = "id";
            lueunit_code.Properties.DisplayMember = "id";
            //重量單位
            DataTable dtSec_Unit = myParentForm.dtSec_Unit;
            luesec_unit.Properties.DataSource =clsCommon.GetSecUnit();
            luesec_unit.Properties.ValueMember = "id";
            luesec_unit.Properties.DisplayMember = "id";

            luelocation_id.Properties.DataSource = clsCommon.GetDepartment();
            luelocation_id.Properties.ValueMember = "id";
            luelocation_id.Properties.DisplayMember = "name";

            //QC狀態
            lueqc_state.Properties.DataSource = clsCommon.Get_Iqc_State();
            lueqc_state.Properties.ValueMember = "id";
            lueqc_state.Properties.DisplayMember = "name";

            //QC結果
            lueqc_result.Properties.DataSource = clsCommon.Get_Iqc_Result();
            lueqc_result.Properties.ValueMember = "id";
            lueqc_result.Properties.DisplayMember = "name";

            Set_DataBindings();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            myParentForm.AddNew_Item();
            bindingNavigatorMoveLastItem.PerformClick();
            txtid.Text = m_id;
            txtsequence_id.Text = "0";
            txtmo_id.Text = "Z99999999";
            lueunit_code.EditValue = "PCS";
            luesec_unit.EditValue = "KG";          
        }

        private void btnItemDel_Click(object sender, EventArgs e)
        {
            myParentForm.Del_Item();
        }

        private void frmPoReceiptEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmPoReceipt.bds_d.EndEdit();
        }

        private void Set_DataBindings()
        {
            txtid.DataBindings.Add("Text", frmTempReceipt.bds_d, "id");
            txtsequence_id.DataBindings.Add("Text", frmTempReceipt.bds_d, "sequence_id");
            txtmo_id.DataBindings.Add("Text", frmTempReceipt.bds_d, "mo_id");
            txtgoods_id.DataBindings.Add("Text", frmTempReceipt.bds_d, "goods_id");
            txtgoods_name.DataBindings.Add("Text", frmTempReceipt.bds_d, "goods_name");
            txtcolor.DataBindings.Add("Text", frmTempReceipt.bds_d, "color");
            txttemp_qty.DataBindings.Add("Text", frmTempReceipt.bds_d, "temp_qty");
            lueunit_code.DataBindings.Add("EditValue", frmTempReceipt.bds_d, "unit_code");
            txtm_receipt_qty.DataBindings.Add("Text", frmTempReceipt.bds_d, "m_receipt_qty");
            txtfact_qty.DataBindings.Add("Text", frmTempReceipt.bds_d, "fact_qty");
            txtsec_qty.DataBindings.Add("Text", frmTempReceipt.bds_d, "sec_qty");
            luesec_unit.DataBindings.Add("EditValue", frmTempReceipt.bds_d, "sec_unit");
            luelocation_id.DataBindings.Add("EditValue", frmTempReceipt.bds_d, "location_id");            
            txtsell_order.DataBindings.Add("Text", frmTempReceipt.bds_d, "sell_order");
            txtpo_id.DataBindings.Add("Text", frmTempReceipt.bds_d, "po_id");
            lueqc_state.DataBindings.Add("EditValue", frmTempReceipt.bds_d, "qc_state");
            lueqc_result.DataBindings.Add("EditValue", frmTempReceipt.bds_d, "qc_result");
            memremark.DataBindings.Add("Text", frmTempReceipt.bds_d, "remark");
            
            //隱藏的字段
            txtpo_sequence_id.DataBindings.Add("Text", frmTempReceipt.bds_d, "po_sequence_id");
            txtbasic_unit.DataBindings.Add("Text", frmTempReceipt.bds_d, "basic_unit");
            txtlocation.DataBindings.Add("Text", frmTempReceipt.bds_d, "location");
            txtcarton_code.DataBindings.Add("Text", frmTempReceipt.bds_d, "carton_code");
            txtprice.DataBindings.Add("Text", frmTempReceipt.bds_d, "price");
            txttotal_sum.DataBindings.Add("Text", frmTempReceipt.bds_d, "total_sum");
            txtcurrency.DataBindings.Add("Text", frmTempReceipt.bds_d, "currency");
            txtexchange_rate.DataBindings.Add("Text", frmTempReceipt.bds_d, "exchange_rate");
            txtm_rate.DataBindings.Add("Text", frmTempReceipt.bds_d, "m_rate");
            dets_date.DataBindings.Add("EditValue", frmTempReceipt.bds_d, "s_date");
        }

        private void txttemp_qty_Leave(object sender, EventArgs e)
        {
            Input_qty();
        }

        private void txtm_receipt_qty_Leave(object sender, EventArgs e)
        {
            Input_qty();
        }

        private void btnFind1_Click(object sender, EventArgs e)
        {
            if(m_state =="")
            {
                return;
            }
            if (m_bill_origin_id == "2")
            {
                //根據採購訂單
                //參數1為顯示自制,委外,採購件
                using (frmPOFind frm = new frmPOFind())
                {
                    frm.ShowDialog();
                    string ls_mm = frm.m_po_info.goods_id ;
                    if (ls_mm != "")
                    {
                        myParentForm.luedepartment_id.EditValue = frm.m_po_info.department_id;//對應部門的採購單
                        myParentForm.luevendor_id.EditValue = frm.m_po_info.vendor_id;//是哪一個供應商的采購單
                        myParentForm.txtvendor.Text = frm.m_po_info.vendor_name;
                        txtgoods_id.Text = ls_mm;
                        txtgoods_name.Text = frm.m_po_info.goods_name;
                        txtcolor.Text = frm.m_po_info.color;
                        txtpo_sequence_id.Text = frm.m_po_info.sequence_id;//訂單序號
                        txtbasic_unit.Text = frm.m_po_info.basic_unit ;
                        txtprice.Text = frm.m_po_info.price.ToString() ;
                        txttotal_sum.Text = "0";
                        txtcurrency.Text = frm.m_po_info.m_id;
                        txtexchange_rate.Text = frm.m_po_info.exchange_rate.ToString();
                        txtm_rate.Text = frm.m_po_info.exchange_rate.ToString();
                        dets_date.EditValue = frm.m_po_info.order_date;
                        lueunit_code.EditValue = frm.m_po_info.unit_code;
                        luesec_unit.EditValue = frm.m_po_info.sec_unit;
                    }
                }
            }
            else
            {
                //手工錄入               
                //參數1為顯示自制,委外,採購件
                using (frmMmFind frm = new frmMmFind("1"))
                {
                    frm.ShowDialog();                    
                    if (!string.IsNullOrEmpty(frm.m_mm.goods_id))
                    {
                        txtgoods_id.Text = frm.m_mm.goods_id;
                        txtgoods_name.Text = DBUtility._language == "2" ? frm.m_mm.english_name : frm.m_mm.name;
                        txtcolor.Text = frm.m_mm.color;
                        lueunit_code.EditValue = frm.m_mm.unit_code;
                        luesec_unit.EditValue = frm.m_mm.sec_unit ;
                        txtbasic_unit.Text = frm.m_mm.unit_code;
                        txtexchange_rate.Text = "0.00";
                        txtm_rate.Text = "0.00";
                        txttotal_sum.Text = "0";
                    }
                }
            }
        }

        private void luelocation_id_EditValueChanged(object sender, EventArgs e)
        {
            if(m_state!=""&&luelocation_id.Text !="")
            {
                txtlocation.Text = luelocation_id.EditValue.ToString();
                txtcarton_code.Text = luelocation_id.EditValue.ToString();
            }
        }

        private void Input_qty()
        {
            if (m_state != "")
            {
                frmPoReceipt.bds_d.EndEdit();
                DataRow drw = ((DataRowView)frmPoReceipt.bds_d.Current).Row;
                if (m_bill_origin_id == "2")
                {                    
                    if (clsTempReceipt.Verify_recipt_qty(drw))//檢查數量是否超收
                    {
                        Calculation_fact_qty(true, drw);
                    }
                    else
                    {
                        Calculation_fact_qty(false, drw);
                    }
                }
                else
                {
                    Calculation_fact_qty(true, drw);
                }
            }
        }

        private void Calculation_fact_qty(bool is_recipt, DataRow cur_drw)
        {
            if (m_state != "")
            {
                float lf_fact_qty, lf_temp_qty, lf_temp_qty_original, lf_m_receipt_qty, lf_m_receipt_qty_original, lf_fact_qty_original;
                lf_temp_qty = objPub.Return_Float_Value(cur_drw["temp_qty"].ToString());
                lf_m_receipt_qty = objPub.Return_Float_Value(cur_drw["m_receipt_qty"].ToString());
               
                if (is_recipt)
                {
                    lf_fact_qty = lf_temp_qty + lf_m_receipt_qty;
                    txtfact_qty.Text = lf_fact_qty.ToString();
                }
                else
                {
                    //還原舊值
                    //獲取修改前的原始值
                    try
                    {
                        lf_temp_qty_original = objPub.Return_Float_Value(cur_drw["temp_qty", DataRowVersion.Original].ToString());
                    }
                    catch (Exception)
                    {
                        //新增的行因不存在原始值,重新取原始值會引發異常,故作此處理
                        lf_temp_qty_original = 0;
                    }

                    try
                    {
                        lf_m_receipt_qty_original = objPub.Return_Float_Value(cur_drw["m_receipt_qty", DataRowVersion.Original].ToString());
                    }
                    catch (Exception)
                    {
                        lf_m_receipt_qty_original = 0;
                    }

                    try
                    {
                        lf_fact_qty_original = objPub.Return_Float_Value(cur_drw["fact_qty", DataRowVersion.Original].ToString());
                    }
                    catch (Exception)
                    {
                        lf_fact_qty_original = 0;
                    }
                    txttemp_qty.Text = lf_temp_qty_original.ToString();
                    txtm_receipt_qty.Text = lf_m_receipt_qty_original.ToString();
                    txtfact_qty.Text = lf_fact_qty_original.ToString();                   
                }
                txttotal_sum.Text = (objPub.Return_Float_Value(txtfact_qty.Text) * objPub.Return_Float_Value(txtprice.Text)).ToString();
            }
        }
    }
}
