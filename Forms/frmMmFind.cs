using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cfvn.ModuleClass;
using cfvn.CLS;
using cfvn.MDL;

namespace cfvn.Forms
{
    public partial class frmMmFind : Form
    { 
        private string m_goods_type;
        public mdlMM_Find m_mm = new mdlMM_Find();
        private clsPublicOfVN clsApp = new clsPublicOfVN();
        
   

        public frmMmFind(string _type)
        {            
            InitializeComponent();   
            //窗體對象標簽翻譯                   
            clsTranslate obj_ctl = new clsTranslate(this.Controls, DBUtility._language);
            obj_ctl.Translate();

            //bs_mat_master中的字段modality用于區分物料的類型:
            //0 自制
            //1 委外
            //2 採購
            //3 成品(F0...)

            //參數_type = "0",允許選擇自制(0),委外(1)的貨品          --(即自制與委外,不包含採購件)
            //參數_type = "1",允許選擇自制(0),委外(1),採購(2)的貨品  --(即全部,包含採購件)
            m_goods_type = _type;
            if (_type == "1")
            {
                chkPur.Enabled = true;
                chkPur.Visible = true;
            }
            else
            {
                chkPur.Enabled = false;
                chkPur.Visible = false;
            }            
            
            NextControl oNext = new NextControl(this, "1");
            oNext.EnterToTab();
            
            //加載按鈕圖片
            clsSetButtonImage objBtns = new clsSetButtonImage();
            objBtns.Set_Button_Image(toolStrip1);
            

        }

        private void frmMmFind_Load(object sender, EventArgs e)
        {
            //DataTable dtDept = clsCommon.GetDepartment();                
            //DataRow dr1 = dtDept.NewRow(); //插一空行
            //dr1["id"] = "";
            //dtDept.Rows.InsertAt(dr1, 0);
            //txtDetp_id.Properties.DataSource = dtDept;
            //txtDetp_id.Properties.ValueMember = "id";
            //txtDetp_id.Properties.DisplayMember = "english_name";

            //管制類型
            DataTable dtModality = new DataTable();
            if (DBUtility._language == "2")
                dtModality = clsApp.GetDataTable(@"SELECT id,english_name as name FROM dbo.cd_goodscode_modality Order by id");
            else
                dtModality = clsApp.GetDataTable(@"SELECT id,name FROM dbo.cd_goodscode_modality Order by id");            
            cl_modality.DataSource = dtModality;
            cl_modality.ValueMember = "id";
            cl_modality.DisplayMember = "name";
        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTNFIND_Click(object sender, EventArgs e)
        {
            if (txtgoods_id1.Text =="" && txtgoods_id2.Text =="" && txtMat_code.Text == "" && txtPrd_code.Text == "" 
                && txtArt_code.Text == "" && txtSize_code.Text == "" && txtClr_code.Text == "" && txtname.Text == "")
            {                
                MessageBox.Show(clsCommon.GetTitle("t_msg_search_condition"), "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);              
                return;
            }
            StringBuilder sb = new StringBuilder(@"SELECT id as goods_id,name,english_name,color,do_color,unit_code,sec_unit,modality FROM dbo.it_goods with(nolock) WHERE 1>0 ");
            if (txtgoods_id1.Text != "")
            {                
                sb.Append(String.Format(" AND id >= '{0}'", txtgoods_id1.Text));
            }
            if (txtgoods_id2.Text != "")
            {                
                sb.Append(String.Format(" AND id <= '{0}'", txtgoods_id2.Text));//貨品編號
            }            
            if (txtMat_code.Text != "")
            {
                sb.Append(String.Format(" AND datum ='{0}'", txtMat_code.Text));//材質
            }
            if (txtPrd_code.Text != "")
            {
                sb.Append(String.Format(" AND base_class ='{0}'", txtPrd_code.Text));//產品類型
            }
            if (txtArt_code.Text != "")
            {
                sb.Append(String.Format(" AND blueprint_id ='{0}'", txtArt_code.Text));
            }
            if (txtSize_code.Text != "")
            {
                sb.Append(String.Format(" AND size_id ='{0}'", txtSize_code.Text));
            }
            if (txtClr_code.Text != "")
            {
                sb.Append(String.Format(" AND color ='{0}'", txtClr_code.Text));
            }
            if (txtname.Text != "")
            {
                sb.Append(String.Format(" AND name LIKE '%{0}%'", txtname.Text));//中文                
            }
            if (txtenglish_name.Text != "")
            {
                sb.Append(String.Format(" AND english_name LIKE '%{0}%'", txtenglish_name.Text));//英文
            }
            if (m_goods_type == "0")
            {
                sb.Append(" AND modality < '2'"); //採購和成品除外[即只可選自制(0),委外(1)的貨品]
            }
            if (m_goods_type == "1")
            {
                if (chkPur.Enabled && chkPur.Checked)                
                    sb.Append(" AND modality = '2'"); //採購(2)                
                else                
                    sb.Append(" AND modality < '3'"); //成品除外[即只可選自制(0),委外(1),採購(2)的貨品]                
            }

            DataTable dtMmFind = clsApp.GetDataTable(sb.ToString());
            gridControl1.DataSource = dtMmFind;
            if (dgvMmFind.RowCount == 0)
            {                
                MessageBox.Show(clsCommon.GetTitle("t_msg_no_data"), "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);               
            }
        }

        private void BTNOK_Click(object sender, EventArgs e)
        {
            if (dgvMmFind.RowCount == 0)
            {               
                m_mm.goods_id = "";
            }                          
            if(m_mm.goods_id =="")
            {
                MessageBox.Show(clsCommon.GetTitle("t_msg_select_goods_id"), "System Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }            
            this.Close();
        }
      
        private void txtgoods_id1_Leave(object sender, EventArgs e)
        {
            txtgoods_id2.Text = txtgoods_id1.Text;
        }       

        private void dgvMmFind_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {            
            if (dgvMmFind.RowCount > 0)
            {
                m_mm.goods_id = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "goods_id");
                m_mm.name = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "name");
                m_mm.english_name = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "english_name");
                m_mm.color = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "color");
                m_mm.do_color = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "do_color");
                m_mm.unit_code = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "unit_code");
                m_mm.sec_unit = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "sec_unit");
                m_mm.modality = dgvMmFind.GetRowCellDisplayText(dgvMmFind.FocusedRowHandle, "modality");
            }
            else
            {
                m_mm.goods_id = "";
                m_mm.name = "";
                m_mm.english_name = "";
                m_mm.color = "";
                m_mm.do_color = "";
                m_mm.unit_code = "";
                m_mm.sec_unit = "";
                m_mm.modality = "";
            }
        }
    }
}
