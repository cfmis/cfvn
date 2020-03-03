using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using cfttest;

namespace cftest.Forms
{
    public partial class frmLogin : Form
    {
        AccessHelper objAcess = new AccessHelper();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {            
            DataTable dtUser = new DataTable();
            string sql = @"SELECT userid,userid+'('+username+')' as username FROM login ";            
            dtUser = objAcess.GetDataTable(sql);            
            cboUserid.DataSource = dtUser;
            cboUserid.ValueMember = "userid";
            cboUserid.DisplayMember = "username";
            cboUserid.SelectedIndex=0;
            
            //設置默認的獲得焦點的控件
            this.ActiveControl = txtPassword;  //設置獲得點的控件必須與txtPassword.Focus()一起使用否則不起作用
            txtPassword.Focus();
            this.AcceptButton = btnOk;//設置btn_ok按鈕響應Enter鍵      
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(cboUserid.Text))
            {
                string user = cboUserid.SelectedValue.ToString();
                if (!string.IsNullOrEmpty(txtPassword.Text))
                {
                    string pwd = txtPassword.Text;
                    DataTable dt = objAcess.GetDataTable(string.Format(@"SELECT password FROM login WHERE userid='{0}' and password='{1}'",user, pwd));
                    if (dt.Rows.Count > 0)
                    {
                        frmMain.isRunMain = true;
                        DBUtility._user_id = user;
                        this.Close();
                    }                  
                    else
                    {
                        MessageBox.Show("密码不正确!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        txtPassword.Focus();
                    }
                }
                else
                {
                    MessageBox.Show("密码不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtPassword.Focus();
                }
            }
            else
            {
                MessageBox.Show("用户不可为空!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                cboUserid.Focus();
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            frmMain.isRunMain = false;
            this.Close();
        }
    }
}
