using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using cfvn.CLS;
using System.Data.SqlClient;

namespace cfvn.Forms
{
    public partial class frmSysUserEdit : Form
    {       
        string prent_node = "";
        string form_type = "";        
        public string user_id_and_name { get; set; }
        public string user_id_and_typeid { get; set; }
        public clsPublicOfVN clsApp = new clsPublicOfVN();
               
        public frmSysUserEdit(string pUser_id,string pType,string pPrent_node)
        {
            InitializeComponent();
            //clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            //obj_ctl.Translate();

            form_type = pType;
            prent_node = pPrent_node;
            txtUser_id.Text = pUser_id;
            user_id_and_typeid = "";
            user_id_and_name = "";
        }

        private void frmSysUserEdit_Load(object sender, EventArgs e)
        {
            cmbInherit_type.Text = "Y";
            if (form_type == "E")
            {
                txtUser_id.ReadOnly = true;
                string sql =
                String.Format(@"SELECT user_id,user_name,password,ava_date,mis_date,createby,createdate,modifyby,modifydate,inherit_type
                                FROM dbo.sys_user WHERE user_id ='{0}'", txtUser_id.Text);
                DataTable dt = clsApp.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    txtUser_name.Text = dt.Rows[0]["user_name"].ToString();
                    txtPassword.Text = dt.Rows[0]["password"].ToString();
                    cmbInherit_type.Text = dt.Rows[0]["inherit_type"].ToString();
                    mskAva_date.Text = dt.Rows[0]["ava_date"].ToString();
                    mskMis_date.Text = dt.Rows[0]["mis_date"].ToString();
                    txtCreateby.Text = dt.Rows[0]["createby"].ToString();
                    txtCreatedate.Text = dt.Rows[0]["createdate"].ToString();
                    txtModifyby.Text = dt.Rows[0]["modifyby"].ToString();
                    txtModifydate.Text = dt.Rows[0]["modifydate"].ToString();
                }
            }
            else
            {
                txtUser_id.ReadOnly = false;
                txtUser_name.Text = "";
                txtPassword.Text = "";
                cmbInherit_type.Text = "Y";
                mskAva_date.Text = DateTime.Now.Date.ToString("yyyy/MM/dd");
                mskMis_date.Text = "";
                txtCreateby.Text = DBUtility._user_id; ;
                txtCreatedate.Text =DateTime.Now.Date.ToString("yyyy/MM/dd");
                txtModifyby.Text = DBUtility._user_id; ;
                txtModifydate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd");
            }           
        }

        private void frmSysUserEdit_FormClosed(object sender, FormClosedEventArgs e)
        {           
            clsApp = null;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(form_type=="E")
                Save_Edit();
            else
                Save_Add_New();
        }
        private void Save_Add_New()
        {
            if (txtUser_id.Text == "")
            {
                MessageBox.Show("用户不可以为空格!");
                return;
            }
            if (Check_User_Exists())
                return;
            
            const string sql_new = 
             @"INSERT INTO sys_user(user_id,user_name,group_id,ava_date,mis_date,createby,createdate,modifyby,modifydate,status,typeid,inherit_type)
             VALUES(@user_id,@user_name,@group_id,@ava_date,case LEN(@mis_date) when 0 then null else @mis_date end,@userid,getdate(),@userid,getdate(),'0','U','Y')";
           
            string misdate;
            if (mskMis_date.Text == "    /  /")
                misdate = "";
            else
                misdate = mskMis_date.Text;
            SqlParameter[] spras = new SqlParameter[]
            {                
                new SqlParameter("@user_id",txtUser_id.Text ),
                new SqlParameter("@user_name",txtUser_name.Text ),
                new SqlParameter("@group_id",prent_node),
                new SqlParameter("@ava_date",mskAva_date.Text ),
                new SqlParameter("@mis_date",misdate ),
                new SqlParameter("@userid",DBUtility._user_id )
            };
            if (clsApp.ExecuteNonQuery(sql_new, spras, false) > 0)
            {
                MessageBox.Show("新增用户成功!");                
            }
            Set_cur_user_node();
        }

        private void Save_Edit()
        {
           const string sql_u = 
            @"Update dbo.sys_user SET user_name=@user_name,ava_date=@ava_date,mis_date=CASE LEN(@mis_date) When 0 THEN null ELSE @mis_date END,
            modifyby=@modifyby,modifydate=getdate(),inherit_type=@inherit_type WHERE user_id =@user_id";
            string misdate;
            if (mskMis_date.Text == "    /  /")
                misdate = "";
            else
                misdate = mskMis_date.Text;
            SqlParameter[] spras = new SqlParameter[]
            {                
                new SqlParameter("@user_name",txtUser_name.Text ),
                new SqlParameter("@ava_date",mskAva_date.Text ),
                new SqlParameter("@mis_date",misdate ),
                new SqlParameter("@modifyby",DBUtility._user_id ),               
                new SqlParameter("@inherit_type",cmbInherit_type.Text ),
                new SqlParameter("@user_id",txtUser_id.Text ),
            };
            if (clsApp.ExecuteNonQuery(sql_u, spras, false) > 0)
            {
                MessageBox.Show("修改当前用户成功!");
            }
            Set_cur_user_node();
        }

        private void Set_cur_user_node()
        {
            user_id_and_name = String.Format("{0} [{1}]", txtUser_id.Text, txtUser_name.Text);
            user_id_and_typeid = String.Format("{0};[U]", txtUser_id.Text);
        }

        private void mskAva_date_Leave(object sender, EventArgs e)
        {
            if (mskAva_date.Text != "    /  /")
            {
                if (!clsValidRule.CheckDateFormat(mskAva_date.Text))
                {
                    MessageBox.Show("日期格式有误!");
                    mskAva_date.Focus();
                }
            }
        }

        private void mskMis_date_Leave(object sender, EventArgs e)
        {
            if (mskMis_date.Text != "    /  /")
            {
                if (!clsValidRule.CheckDateFormat(mskMis_date.Text))
                {
                    MessageBox.Show("日期格式有误!");
                    mskMis_date.Focus();
                }
            }
        }

        private void txtUser_id_Leave(object sender, EventArgs e)
        {
            if (form_type != "E"&&txtUser_id.Text !="")
            {
                Check_User_Exists();
            }
        }
        
        private bool Check_User_Exists()
        {
            bool result=false ;
            string strSql = String.Format(@"Select user_id,user_name From sys_user Where user_id='{0}'", txtUser_id.Text);
            DataTable dtUser = clsApp.GetDataTable(strSql);
            if (dtUser.Rows.Count > 0)
            {                    
                txtUser_name.Text = dtUser.Rows[0]["user_name"].ToString();
                MessageBox.Show(string.Format("该用户[{0}]已存在!",txtUser_name.Text));
                txtUser_id.Text = "";
                txtUser_name.Text = "";
                txtUser_id.Focus();
                result = true;
            }
            else
            {
                result = false;
            }
            return result; 
        }       
 
        
    }
}
