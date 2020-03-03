using System;
using DevExpress.XtraReports.UI;
//using cfvn.CLS;

namespace cfvn.Reports
{
    public partial class xrPoPurchaseBill : DevExpress.XtraReports.UI.XtraReport
    {
        public xrPoPurchaseBill()
        {
            InitializeComponent();
        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //分組
            GroupHeader1.GroupFields.AddRange(new GroupField[] { new GroupField("id", XRColumnSortOrder.Ascending) });
        }

        private void txtprice_TextChanged(object sender, EventArgs e)
        {
            if (txtprice.Text == "0.00")
            {
                txtprice.Visible = false;
                txtp_unit.Visible = false;
            }
            else
            {
                txtprice.Visible = true;
                txtp_unit.Visible = true;
            }
        }

        private void txtsec_qty_TextChanged(object sender, EventArgs e)
        {
            if (txtsec_qty.Text == "0.00")
            {
                txtsec_qty.Visible = false;
                txtsec_unit.Visible = false;
            }
            else
            {
                txtsec_qty.Visible = true;
                txtsec_unit.Visible = true;
            }
        }

        private void txtorder_qty_TextChanged(object sender, EventArgs e)
        {
            if (txtorder_qty.Text == "0.00")
            {
                txtorder_qty.Visible = false;
                txtunit_code.Visible = false;
            }
            else
            {
                txtorder_qty.Visible = true;
                txtunit_code.Visible = true;
            }
        }

        


     
       
    }
}
