using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
namespace cfvn.Components
{
    public partial class myNumText : UserControl
    {
        public myNumText()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.')
            {
                e.Handled = true;   //不能輸入小数点
                return;
            }
            //控制TextBox只能输入整数
            if (char.IsNumber(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (textBox.Text[0] == '0')
            {
                textBox.Text = textBox.Text.Replace("0", "");
            }
           
        }


    }
}
