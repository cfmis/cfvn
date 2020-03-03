using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using cfvn.CLS;

namespace cfvn.Forms
{
    public partial class frmLogin : Form
    {
        private clsUser clsUser = new clsUser();
        private clsPublicOfVN clsApp = new clsPublicOfVN();
        public frmLogin()
        {
            InitializeComponent();
        }

        //自定義屬性
        public bool isPass { get; set; }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            this.isPass = false;
            //===============2016-12-23添加以下代碼
            string strUser_info, userid, usser_name;
            strUser_info = clsUser.GetMachineName();
            if (strUser_info == "")
            {
                userid = "";
                usser_name = "";
            }
            else
            {
                userid = strUser_info.Substring(0, strUser_info.IndexOf("&"));
                usser_name = strUser_info.Substring(strUser_info.IndexOf("&") + 1);
            }
            txtUserid.Text = userid;
            txtUserName.Text = usser_name;
            //==============

            string ilang = DBUtility.GetAppConfig("language");//獲取默認的語言
            int i =int.Parse(ilang);
            cmbLanguage.Text = cmbLanguage.Items[i-1].ToString();


            //設置默認的獲得焦點的控件
            this.ActiveControl = txtPassword;  //設置獲得點的控件必須與txtPassword.Focus()一起使用否則不起作用
            txtPassword.Focus();
            this.AcceptButton = btn_ok;//設置btn_ok按鈕響應Enter鍵 
        }

        private void frmLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            clsUser = null;
            clsApp = null;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            string userid = txtUserid.Text.Trim();
            string pwd = txtPassword.Text.Trim();

            if (userid != "")
            {
                if (this.isPass != true)  //用戶直接按確定鈕
                {
                    txtUserName.Text = clsUser.IsExistUser(userid);
                    if (txtUserName.Text != "")
                    {
                        this.isPass = true;
                    }
                }

                if (this.isPass) //用戶帳號正確
                {
                    if (clsUser.GetUserInfo(userid, pwd)) //傳兩個參數,以判斷當前用戶密碼是否正確
                    {
                        frmMain.isRunMain = true; //設置調用主窗體的條件
                        frmMain.user_id = txtUserid.Text.Trim();    
                        frmMain.user_name = txtUserName.Text.Trim();
                        frmMain.user_pwd = txtPassword.Text;
                        
                        //保存用戶登入信息
                        clsUser.Save_LoginInfo(txtUserid.Text.Trim(), txtUserName.Text.Trim());
                        DBUtility._user_id = userid;  //因取消SaveLoginInfo()而增加此行代碼
                        DBUtility._language = (int.Parse(cmbLanguage.SelectedIndex.ToString())+1).ToString(); //設置用戶登入語言臨時公共變量
                        
                        //關閉Login窗體
                        this.Close();
                    }
                    else
                    {
                        txtPassword.Focus();
                        txtPassword.SelectAll();
                    }
                }
                else
                {
                    txtUserName.Text = "";
                    txtUserid.Focus();
                    txtUserid.SelectAll();
                }
            }
            else
            {
                MessageBox.Show("Accounts not allowed empty！", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtUserid.Focus();
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUserid_Validated(object sender, EventArgs e)
        {
            string strUserid = txtUserid.Text.Trim();
            if (strUserid != "")  //輸入的帳號是否為空
            {
                string UserName = clsUser.IsExistUser(strUserid);
                if (UserName != "")  //返回的用戶名不為空，說明用戶存在
                {
                    txtUserName.Text = UserName;
                    this.isPass = true;
                }
                else
                {
                    txtUserName.Text = "";
                    txtUserid.Text = "";
                    txtUserid.Focus();
                    this.isPass = false;
                }
            }
            else
            {
                txtUserName.Text = "";
                this.isPass = false;
            }
        }

       


    }
}
