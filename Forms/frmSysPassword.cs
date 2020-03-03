using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using cfvn.CLS;

namespace cfvn.Forms
{
    public partial class frmSysPassword : Form
    {
        public clsPublicOfVN clsApp = new clsPublicOfVN();

        public frmSysPassword(string pUser_id)
        {
            InitializeComponent();
            txtUser_id.Text = pUser_id;
        }

        private void frmSysPassword_Load(object sender, EventArgs e)
        {            
            //string sql = @"SELECT user_id,user_name,password FROM dbo.sys_user WHERE user_id ='" + txtUser_id.Text + "'";
            string sql =string.Format(@"SELECT user_id,user_name,password FROM dbo.sys_user WHERE user_id ='{0}'",DBUtility._user_id);
            DataTable dt = clsApp.GetDataTable(sql);
            if (dt.Rows.Count > 0)
            {
                txtUser_name.Text = dt.Rows[0]["user_name"].ToString();
                txtPassword.Text = dt.Rows[0]["password"].ToString();                
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtNewpwd.Text == txtPwdconfirm.Text)
            {
                if (txtNewpwd.Text == "")
                {
                    MessageBox.Show("密码不可以为空!");
                    txtNewpwd.Focus();
                    return;
                }
               
                string strEncrypt = clsPublic.GeoEncrypt(txtNewpwd.Text);
                string sql_u = string.Format(@"Update dbo.sys_user SET password='{0}' WHERE user_id='{1}'", strEncrypt, txtUser_id.Text);
                if (clsApp.ExecuteSqlUpdate(sql_u) > 0)
                {
                    MessageBox.Show("密码修改成功!");
                }
            }
            else
            {
                MessageBox.Show("新密码输入不一致!");
                txtNewpwd.Focus();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmSysPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsApp = null;
        }
    }
}
