using cfvn.CLS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace cfvn.Forms
{
    public partial class frmTempReceiptQuery : DockContent
    {
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        public clsAppPublic objPub = new clsAppPublic();
        clsToolBar objToolbar;
        public frmTempReceiptQuery()
        {
            InitializeComponent();
            NextControl obj = new NextControl(this, "1");
            obj.EnterToTab();

            clsTranslate obj_ctl = new clsTranslate(this.Controls, DBUtility._language);
            obj_ctl.Translate();

            //權限
            objToolbar = new clsToolBar(this.Tag.ToString(), this.Controls);
            objToolbar.SetToolBar();
            objToolbar.Set_Button_Image(toolStrip1);
            //初始化查找條件
            objPub.Initialize_find_value(this.Name, this.Controls);
        }

        private void BTNEXIT_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BTNSAVESET_Click(object sender, EventArgs e)
        {
            if (objPub.set_find_Value("frmTempReceiptQuery", this.Controls) > 0)
                MessageBox.Show(clsCommon.GetTitle("t_msg_save_find_condition"),"System Info");            
            else
                MessageBox.Show(clsCommon.GetTitle("t_msg_save_find_condition_error"),"System Info");
               
        }
    }
}
