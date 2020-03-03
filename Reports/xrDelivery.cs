using System;
using DevExpress.XtraReports.UI;

namespace cfvn.Reports
{
    public partial class xrDelivery : DevExpress.XtraReports.UI.XtraReport
    {
        public xrDelivery()
        {
            InitializeComponent();

            /*
            txtAmt_contract.DataBindings.Add("Text", DataSource, "amt_contract");//小計欄位需這樣綁定
            txtAmt_tax.DataBindings.Add("Text", DataSource, "amt_tax");
            txtAmt_rental.DataBindings.Add("Text", DataSource, "amt_rental");
            txtAmt_business.DataBindings.Add("Text", DataSource, "amt_business");           
            txtAmt_actual.DataBindings.Add("Text", DataSource, "amt_actual");
            txtAmt_real.DataBindings.Add("Text", DataSource, "amt_real");

            txtAmt_contract_sum.DataBindings.Add("Text", DataSource, "amt_contract");//小計欄位需這樣綁定
            txtAmt_tax_sum.DataBindings.Add("Text", DataSource, "amt_tax");
            txtAmt_rental_sum.DataBindings.Add("Text", DataSource, "amt_rental");
            txtAmt_business_sum.DataBindings.Add("Text", DataSource, "amt_business");
            txtAmt_actual_sum.DataBindings.Add("Text", DataSource, "amt_actual");
            txtAmt_real_sum.DataBindings.Add("Text", DataSource, "amt_real");*/

        }

        private void ReportHeader_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            //分組
            GroupHeader1.GroupFields.AddRange(new GroupField[] { new GroupField("id", XRColumnSortOrder.Ascending) });
        }

    }
}
