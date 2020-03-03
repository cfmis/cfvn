using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cfvn.Components
{
    public partial class myTextBox : UserControl
    {
        public myTextBox()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
