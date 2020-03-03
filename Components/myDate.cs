using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cfvn.Components
{
    public partial class myDate : UserControl
    {
        public myDate()
        {
            InitializeComponent();
        }

        public static bool CheckDateFormat(string StrSource)
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

        private void mskText_Leave(object sender, EventArgs e)
        {
            if (mskText.Text != "    /  /")
            {
                if (!CheckDateFormat(mskText.Text))
                {
                    MessageBox.Show("日期输入有误!","提示信息");
                    mskText.Focus();
                    mskText.SelectAll();
                }
            }
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
