using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cfvn.Components
{
    public partial class myDateText : UserControl
    {
        public myDateText()
        {
            InitializeComponent();
        }

        private void mskText_Leave(object sender, EventArgs e)
        {
            bool flag=false;

            if (mskText.Text != "    /  /")
            {
                if (!CheckDateFormat(mskText.Text))
                {
                    MessageBox.Show("日期输入有误!", "提示信息");
                    mskText.Focus();
                    mskText.SelectAll();
                    flag = true; ;
                }
                if(!flag)
                   dateTimePicker1.Value = new DateTime(int.Parse(mskText.Text.Substring(0, 4)), int.Parse(mskText.Text.Substring(5, 2)), int.Parse(mskText.Text.Substring(8, 2)));
            }
        }

        private static bool CheckDateFormat(string StrSource)
        {
            bool result_flag = true;
            if (StrSource != "" && StrSource.Length == 10)
            {
                string StrDat = String.Format("{0}-{1}-{2}", StrSource.Substring(0, 4), StrSource.Substring(5, 2), StrSource.Substring(8, 2));
                result_flag = System.Text.RegularExpressions.Regex.IsMatch(StrDat,
                    @"^((((1[6-9]|[2-9]\d)\d{2})-(0?[13578]|1[02])-(0?[1-9]" +
                    @"|[12]\d|3[01]))|(((1[6-9]|[2-9]\d)\d{2})-(0?[13456789]|" +
                    @"1[012])-(0?[1-9]|[12]\d|30))|(((1[6-9]|[2-9]\d)\d{2})-0?" +
                    @"2-(0?[1-9]|1\d|2[0-9]))|(((1[6-9]|[2-9]\d)(0[48]|[2468]" +
                    @"[048]|[13579][26])|((16|[2468][048]|[3579][26])00))-0?2-29-))$");
            }
            else
                result_flag = false;
            return result_flag;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            mskText.Text = DateTime.Parse(dateTimePicker1.Text).Date.ToString("yyyy/MM/dd");
        }

        private void mskText_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

    }
}
