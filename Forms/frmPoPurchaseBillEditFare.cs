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
    public partial class frmPoPurchaseBillEditFare : Form
    {
        string m_state = "",m_id="",m_ver="";
        frmPoPurchaseBill myParentForm;       
        public frmPoPurchaseBillEditFare(frmPoPurchaseBill frmParent, string edit_status,string id,string ver)
        {
            InitializeComponent();
            myParentForm = frmParent;
            m_state = edit_status;
            m_id = id;
            m_ver = ver;

            if (m_state != "")
            {
                if (frmPoPurchaseBill.bds_fare.Count > 0)
                {
                    SetObjValue.SetEditBackColor(this.Controls, true);
                }
            }
            else
            {
                SetObjValue.SetEditBackColor(this.Controls, false);
                btnItemAdd.Enabled = false;
                btnItemDel.Enabled = false;
            }
            bdnav.BindingSource = frmPoPurchaseBill.bds_fare;
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();
        }

        private void frmPoPurchaseBillEditFare_Load(object sender, EventArgs e)
        {     
            //數量單位
            DataTable dtUnitAll = myParentForm.dtUnitAll;
            unit_code.Properties.DataSource = dtUnitAll;
            unit_code.Properties.ValueMember = "id";
            unit_code.Properties.DisplayMember = "id";
            //**********附加費用ID
            //附加費用編號
            DataTable dtFare = clsCommon.Get_Fare_id();
            luefare_id.Properties.DataSource = dtFare;
            luefare_id.Properties.ValueMember = "id";
            luefare_id.Properties.DisplayMember = "id";
            Set_DataBindings();
        }

        private void Set_DataBindings()
        {
            txtid.DataBindings.Add("Text", frmPoPurchaseBill.bds_fare, "id");
            txtver.DataBindings.Add("Text", frmPoPurchaseBill.bds_fare, "ver");
            luefare_id.DataBindings.Add("EditValue", frmPoPurchaseBill.bds_fare, "fare_id");
            txtname.DataBindings.Add("Text", frmPoPurchaseBill.bds_fare, "name");
            qty.DataBindings.Add("Text", frmPoPurchaseBill.bds_fare, "qty");
            unit_code.DataBindings.Add("EditValue", frmPoPurchaseBill.bds_fare, "unit_code");
            price.DataBindings.Add("Text", frmPoPurchaseBill.bds_fare, "price");
            txtfare_sum.DataBindings.Add("Text", frmPoPurchaseBill.bds_fare, "fare_sum");
            txtgoods_id.DataBindings.Add("Text", frmPoPurchaseBill.bds_fare, "goods_id");
            txtorg_fare_id.DataBindings.Add("Text", frmPoPurchaseBill.bds_fare, "org_fare_id");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {            
            this.Close();
        }

        private void btnItemAdd_Click(object sender, EventArgs e)
        {
            //取當前附加費對應的物料編號
            DataRow myEditDataRow = ((DataRowView)frmPoPurchaseBill.bds_d.Current).Row;
            string ls_goods_id = myEditDataRow["goods_id"].ToString();
            if (string.IsNullOrEmpty(ls_goods_id))
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_goods_cannot_empty"));
                return ;
            }
            
            frmPoPurchaseBill.bds_fare.AddNew();
            if (!luefare_id.Enabled)
            {
                SetObjValue.SetEditBackColor(this.Controls, true);
            }
            txtid.Text = m_id;
            txtver.Text = m_ver;
            unit_code.EditValue = "PCS";
            //取明細的貨品編號            
            txtgoods_id.Text = ls_goods_id;    
        }

        private void btnItemDel_Click(object sender, EventArgs e)
        {
            frmPoPurchaseBill.bds_fare.EndEdit();
            myParentForm.Del_Item_Fare();
            if (frmPoPurchaseBill.bds_fare.Count == 0)
            {
                SetObjValue.SetEditBackColor(this.Controls, false);
            }
        }
     
        private void qty_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                Check_Is_Update_Amt_Fare(qty); 
            }
        }

        private void price_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                Check_Is_Update_Amt_Fare(price);
            }
        }

        /// <summary>
        /// 計算明細當前行金額
        /// </summary>
        /// <param name="column_name"></param>
        private void Check_Is_Update_Amt_Fare(TextEdit obj)
        {
            if (m_state!="")
            {
                string ls_column_name = "";
                switch (obj.Name)
                {
                    case "qty":
                        ls_column_name = "qty";
                        break;
                    case "price":
                        ls_column_name = "price";
                        break;
                    default:
                        break;
                }               
                decimal ldc_value, ldc_original_value = 0;
                ldc_value = decimal.Parse(obj.Text);
                
                //取得修改前的原始值
                DataRow myEditDataRow = ((DataRowView)frmPoPurchaseBill.bds_fare.Current).Row;               
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
                    Count_Row_Amount_Fare();
                }
            }
        }


        /// <summary>
        /// 計算明細當前行金額公式
        /// </summary>
        public void Count_Row_Amount_Fare()
        {           
            decimal ldc_qty = 0, ldc_price, ldc_fare_sum = 0;           
            if (!string.IsNullOrEmpty(qty.Text))
                ldc_qty = decimal.Parse(qty.Text);
            else
                ldc_qty = 0;           
            if (!string.IsNullOrEmpty(price.Text))
                ldc_price = decimal.Parse(price.Text);
            else
                ldc_price = 0;
            ldc_fare_sum = decimal.Parse(Math.Round(ldc_qty * ldc_price, 2).ToString());
            txtfare_sum.Text = ldc_fare_sum.ToString();
            frmPoPurchaseBill.bds_fare.EndEdit();//更新父表中的明細
            myParentForm.Count_Amount();//重新計算主檔總金額
        }

        private void frmPoPurchaseBillEditFare_FormClosed(object sender, FormClosedEventArgs e)
        {
            txtname.Focus();
            frmPoPurchaseBill.bds_fare.EndEdit();
        }
        
        private void luefare_id_Leave(object sender, EventArgs e)
        {
            if (m_state != "")
            {
                txtname.Text = luefare_id.GetColumnValue("name").ToString();
            }
        }

        private void bdnav_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            txtname.Focus();
        }



    }
}
