using cfvn.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using cfvn.MDL;

namespace cfvn.Forms
{
    public partial class frmPOFind : Form
    {
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        DataTable dtPurchase = new DataTable();
        public mdlPO_Find m_po_info = new mdlPO_Find();
        public clsAppPublic m_clsPub = new clsAppPublic();       

        public frmPOFind()
        {
            InitializeComponent();
            //加載按鈕圖片
            clsSetButtonImage objBtns = new clsSetButtonImage();
            objBtns.Set_Button_Image(toolStrip1);           
        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNFIND_Click(object sender, EventArgs e)
        {
            if ( txtpo_id1.Text == "" && txtpo_id2.Text == "" && dteorder_date1.Text == "" && dteorder_date2.Text == "" &&
                 txtvendor_id1.Text == "" && txtvendor_id2.Text == "" && txtdept_id1.Text =="" && txtdept_id2.Text == "" &&
                 txtgoods_id1.Text == "" && txtgoods_id2.Text == "" && txtgoods_name.Text =="" && txtvendor_name.Text ==""&&
                 txtmo_id.Text =="" )
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_search_condition"), "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            SqlParameter[] paras = new SqlParameter[]{
                new SqlParameter("@po_id1",txtpo_id1.Text),
                new SqlParameter("@po_id2",txtpo_id2.Text),
                new SqlParameter("@vendor_id1",txtvendor_id1.Text),
                new SqlParameter("@vendor_id2",txtvendor_id2.Text),
                new SqlParameter("@vendor_name",txtvendor_name.Text),
                new SqlParameter("@order_date1",dteorder_date1.Text),
                new SqlParameter("@order_date2",dteorder_date2.Text),
                new SqlParameter("@goods_id1",txtgoods_id1.Text),
                new SqlParameter("@goods_id2",txtgoods_id2.Text),
                new SqlParameter("@goods_name",txtgoods_name.Text),
                new SqlParameter("@dept_id1",txtdept_id1.Text),
                new SqlParameter("@dept_id2",txtdept_id2.Text),
                new SqlParameter("@mo_id",txtmo_id.Text)
            };
            dtPurchase = clsApp.ExecuteProcedureReturnTable("usp_temp_receipt_from_po", paras);
            gridControl1.DataSource = dtPurchase;
        }

        private void BTNOK_Click(object sender, EventArgs e)
        {
            if(dgvMmFind.RowCount==0)
            {                
                m_po_info.goods_id="";                
            }
            if (m_po_info.goods_id == "")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_select_goods_id"), "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Close();
        }

        private void dgvMmFind_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            if (dgvMmFind.RowCount > 0)
            {
                m_po_info.id = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "id");
                m_po_info.order_date = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "order_date") ;
                m_po_info.vendor_id = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "vendor_id"); 
                m_po_info.department_id = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "department_id"); 
                m_po_info.m_id = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "m_id");
                m_po_info.exchange_rate = m_clsPub.Return_Float_Value(dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "exchange_rate"));
                m_po_info.vendor_name = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "vendor_name");
                m_po_info.vendor_name_en = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "vendor_name_en");
                m_po_info.sequence_id = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "sequence_id");
                m_po_info.goods_id = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "goods_id");
                m_po_info.goods_name = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "goods_name");
                m_po_info.order_qty = m_clsPub.Return_Float_Value(dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "order_qty"));
                m_po_info.unit_code = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "unit_code");
                m_po_info.order_sec_qty = m_clsPub.Return_Float_Value(dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "order_sec_qty"));
                m_po_info.sec_unit = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "sec_unit"); 
                m_po_info.fact_date = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "fact_date");
                m_po_info.sell_order = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "sell_order");
                m_po_info.mo_id = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "mo_id");
                m_po_info.ver = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "ver");
                m_po_info.price = m_clsPub.Return_Float_Value(dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "price"));
                m_po_info.p_unit = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "p_unit");
                m_po_info.aready_receipt_qty = m_clsPub.Return_Float_Value(dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "aready_receipt_qty"));
                m_po_info.color = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "color");
                m_po_info.basic_unit = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "basic_unit");

            }
            else
            {
                m_po_info.id = "";
                m_po_info.order_date = "";
                m_po_info.vendor_id = "";
                m_po_info.department_id = "";
                m_po_info.m_id = "";
                m_po_info.exchange_rate = 0;
                m_po_info.vendor_name = "";
                m_po_info.vendor_name_en = "";
                m_po_info.sequence_id = "";
                m_po_info.goods_id = "";
                m_po_info.goods_name = "";
                m_po_info.order_qty = 0;
                m_po_info.unit_code = "";
                m_po_info.order_sec_qty = 0;
                m_po_info.sec_unit = "";
                m_po_info.fact_date = "";
                m_po_info.sell_order = "";
                m_po_info.mo_id = "";
                m_po_info.ver = "";
                m_po_info.price = 0;
                m_po_info.p_unit = "";
                m_po_info.aready_receipt_qty = 0;
                m_po_info.color = "";
                m_po_info.basic_unit = "";
            }
        }

        private void frmPOFind_FormClosed(object sender, FormClosedEventArgs e)
        {
            frmTempReceipt.bds_d.EndEdit();
        }

        private void txtpo_id1_Leave(object sender, EventArgs e)
        {
            txtpo_id2.Text = txtpo_id1.Text;
        }

        private void dteorder_date1_Leave(object sender, EventArgs e)
        {
            dteorder_date2.EditValue = dteorder_date1.EditValue;
        }

        private void txtvendor_id1_Leave(object sender, EventArgs e)
        {
            txtvendor_id2.Text = txtvendor_id1.Text;
        }

        private void txtdept_id1_Leave(object sender, EventArgs e)
        {
            txtdept_id2.Text = txtdept_id1.Text;
        }

        private void txtgoods_id1_Leave(object sender, EventArgs e)
        {
            txtgoods_id2.Text = txtgoods_id1.Text;
        }
    }
}
