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
    public partial class frmPoPurchaseBillEmp : Form
    {
        public string mEmp_id = "";         
        public frmPoPurchaseBillEmp(string emp_id)
        {
            InitializeComponent();
            mEmp_id = emp_id;
        }

        private void frmPoPurchaseBillEmp_Load(object sender, EventArgs e)
        {
            DataTable dt = clsPoPurchase.Get_Employer();
            schEmp.Properties.DataSource = dt;
            schEmp.Properties.ValueMember = "id";
            schEmp.Properties.DisplayMember = "id";
            schEmp.EditValue = mEmp_id;
        }

        private void schEmp_EditValueChanged(object sender, EventArgs e)
        {
            mEmp_id = schEmp.Text;
        }
    }
}
