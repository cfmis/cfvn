/*
 * Create Date:2019-05-05
 * Create by Allen Leung
 * �{�ǳƵ��G
 * ����½Ķ
 * 
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace cfvn.CLS
{
    public class clsTranslate
    {
        //private string m_strFrmName;
        private Control.ControlCollection m_controlCollectin;
        private string m_language;
        DataTable dtControlInfo = new DataTable();
        clsPublicOfVN clsApp = new clsPublicOfVN();
        public clsTranslate(Control.ControlCollection controlCollection, string lang)
        {
            //m_strFrmName = frmName;
            m_controlCollectin = controlCollection;
            m_language = lang;
        }

        public void Translate()
        {
            try
            {
                string strSQL = String.Format(@"SELECT col_code,col_name FROM dbo.sys_dictionary WHERE language_id='{0}'", m_language);
                dtControlInfo = clsApp.GetDataTable(strSQL);
                //�ЫإD��
                DataColumn[] keys = new DataColumn[1];
                keys[0] = dtControlInfo.Columns["col_code"];
                dtControlInfo.PrimaryKey = keys;                
                if (dtControlInfo.Rows.Count > 0)
                {
                    setValue(m_controlCollectin);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// ��汱��½Ķ
        /// </summary>
        /// <param name="objectname">����</param>
        /// <param name="cts">��汱���H</param>
        private void setValue(Control.ControlCollection cts)
        {
            string objName;
            DataRow dr;
            foreach (Control ct in cts)
            {
                switch (ct.GetType().Name)
                {
                    case "ToolStrip": //�u������s                        
                        ToolStrip ts = (ToolStrip)ct; 
                        {                               
                            for (int j = 0; j < ts.Items.Count; j++)
                            {
                                objName = ts.Items[j].Name.ToUpper();                                    
                                dr = dtControlInfo.Rows.Find(objName);
                                if (dr != null)
                                {
                                    if (dr.ItemArray.Length > 0)
                                    {
                                        ts.Items[j].Text = dr["col_name"].ToString();
                                    }
                                }                                   
                            }
                        }                        
                        break;
                    case "BindingNavigator": //�u������s                        
                        BindingNavigator ts0 = (BindingNavigator)ct;
                        {
                            for (int j = 0; j < ts0.Items.Count; j++)
                            {
                                objName = ts0.Items[j].Name.ToUpper();
                                dr = dtControlInfo.Rows.Find(objName);
                                if (dr != null)
                                {
                                    if (dr.ItemArray.Length > 0)
                                    {
                                        ts0.Items[j].Text = dr["col_name"].ToString();
                                    }
                                }
                            }
                        }
                        break;
                    case "Label":  //�奻��ñ                        
                        Label lab = (Label)ct;
                        if (lab.Tag != null)
                        {
                            dr = dtControlInfo.Rows.Find(lab.Tag);
                            if (dr != null)
                            {
                                if (dr.ItemArray.Length > 0)
                                {
                                    lab.Text = dr["col_name"].ToString();
                                }
                            }
                        }                        
                        break;
                    case "DataGridView": //DataGridView�C��                        
                        DataGridView dgv = (DataGridView)ct;
                        for (int i = 0; i < dgv.ColumnCount; i++)
                        {
                            //dgv.Columns[i].ToolTipText �s��C���D½Ķ��������H                           
                            if (dgv.Columns[i].ToolTipText != "")
                            {
                                dr = dtControlInfo.Rows.Find(dgv.Columns[i].ToolTipText);
                                if (dr != null)
                                {
                                    if (dr.ItemArray.Length > 0)
                                    {
                                        dgv.Columns[i].HeaderText = dr["col_name"].ToString();
                                    }
                                }
                            }
                        }
                        break;
                    case "GridControl":   //DEV��汱��              
                        DevExpress.XtraGrid.GridControl grd = (DevExpress.XtraGrid.GridControl)ct;
                        DevExpress.XtraGrid.Views.Grid.GridView grdview = (DevExpress.XtraGrid.Views.Grid.GridView)grd.FocusedView;
                        for (int i = 0; i < grdview.Columns.Count; i++)
                        {
                            if (grdview.Columns[i].Tag != null)
                            {
                                dr = dtControlInfo.Rows.Find(grdview.Columns[i].Tag);
                                if (dr != null)
                                {
                                    if (dr.ItemArray.Length > 0)
                                    {
                                        grdview.Columns[i].Caption = dr["col_name"].ToString();
                                    }
                                }    
                            }
                        }
                        break;
                    case "TabPage":  //�������D                        
                        TabPage page = (TabPage)ct;
                        if (page.Tag != null)
                        {
                            dr = dtControlInfo.Rows.Find(page.Tag);
                            if (dr != null)
                            {
                                if (dr.ItemArray.Length > 0)
                                {
                                    page.Text = dr["col_name"].ToString();
                                }
                            }         
                        }
                        break;
                    case "Button":
                        {
                            Button btn = (Button)ct;
                            dr = dtControlInfo.Rows.Find(btn.Name);
                            if (dr != null)
                            {
                                if (dr.ItemArray.Length > 0)
                                {
                                    btn.Text = dr["col_name"].ToString();
                                }
                            }
                        }
                        break;
                    case "SimpleButton":
                        {
                            DevExpress.XtraEditors.SimpleButton btn = (DevExpress.XtraEditors.SimpleButton)ct;
                            dr = dtControlInfo.Rows.Find(btn.Name);
                            if (dr != null)
                            {
                                if (dr.ItemArray.Length > 0)
                                {
                                    btn.Text = dr["col_name"].ToString();
                                }
                            }                           
                        }
                        break;
                    case "CheckEdit":
                        {
                            DevExpress.XtraEditors.CheckEdit btn = (DevExpress.XtraEditors.CheckEdit)ct;
                            dr = dtControlInfo.Rows.Find(btn.Name);
                            if (dr != null)
                            {
                                if (dr.ItemArray.Length > 0)
                                {
                                    btn.Text = dr["col_name"].ToString();
                                }
                            }
                        }
                        break;
                    case "GroupBox":
                        {
                            GroupBox box = (GroupBox)ct;
                            dr = dtControlInfo.Rows.Find(box.Tag);
                            if (dr != null)
                            {
                                if (dr.ItemArray.Length > 0)
                                {
                                    box.Text = dr["col_name"].ToString();
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
                if (ct.HasChildren) //�e����H���~�򻼳W�d��
                {
                    setValue(ct.Controls);
                }
            }
        }


    }
}
