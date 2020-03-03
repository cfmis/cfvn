using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace cfvn.Components
{
    public partial class myNum2Text : UserControl
    {
        public myNum2Text()
        {
            InitializeComponent();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {            
            //控制TextBox只能输入小数（只能输入一个小数点,小数点后只能输入两位，第一位不能是小数点）
            if (char.IsNumber(e.KeyChar) || e.KeyChar == '.' || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Delete)
            {
                e.Handled = false;          //让操作生效     
                int j = 0;                  //记录小数点个数  
                int k = 0;                  //记录小数位数  
                int dotloc = -1;            //记录小数点位置  
                bool flag = false;          //如果有小数点就让flag值为true  
                
                if ((int)e.KeyChar == 46)//小数点
                {
                    if (textBox.Text.Length <= 0)
                    {
                        e.Handled = true;   //小数点不能在第一位
                        return;
                    }
                }

                for (int i = 0; i < textBox.Text.Length; i++)
                {
                    if (textBox.Text[i] == '.')
                    {
                        j++;
                        flag = true;
                        dotloc = i;
                    }

                    if (flag)
                    {
                        if (char.IsNumber(textBox.Text[i]) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Delete)
                        {
                            k++;
                        }
                    }
                    if (j >= 1)
                    {
                        if (e.KeyChar == '.')
                        {
                            if (textBox.SelectedText.IndexOf('.') == -1)
                                e.Handled = true;             //输入“.”，选取部分没有“.”操作失效  
                        }
                    }
                    if (!flag)                  //此处控制没有小数点时添加小数点是否满足两位小数的情况  
                    {
                        if (e.KeyChar == '.')
                        {
                            if (textBox.Text.Length - textBox.SelectionStart - textBox.SelectedText.Length > 2) //the condition also can be instead of "textBox1.Text.Substring(textBox1.SelectionStart).Length-textBox1.SelectionLength>2"   
                                e.Handled = true;
                        }
                    }
                    if (k == 2)
                    {
                        if (textBox.SelectionStart > textBox.Text.IndexOf('.') &&
                            textBox.SelectedText.Length == 0 && e.KeyChar != (char)Keys.Delete && e.KeyChar != (char)Keys.Back) //如果已经有两位小数，光标在小数点右边，  
                            e.Handled = true;
                    }
                }
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
            if (textBox.Text[0] == '.')
            {
                textBox.Text = textBox.Text.Replace(".", "");
            }
            //不存在小數點
            if (textBox.Text.IndexOf('.') < 0)
            {
                if (textBox.Text[0] == '0')
                {
                    textBox.Text = textBox.Text.Substring(1);
                }
            }
        }
    }
}
