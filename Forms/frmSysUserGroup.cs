using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using cfvn.CLS;
using System.Data.SqlClient;

namespace cfvn.Forms
{
    public partial class frmSysUserGroup : Form
    {       
        private string prent_node = "";
        private string form_type = "";
        public TreeNode subNode = new TreeNode();
        public clsPublicOfVN clsApp = new clsPublicOfVN();
    
               
        public frmSysUserGroup(string pUser_id,string pType,string pPrent_node)
        {
            InitializeComponent();
            form_type = pType;
            prent_node = pPrent_node;
            txtUser_id.Text = pUser_id;

            subNode.Text ="";
            subNode.Tag ="";
        }

        private void frmSysUserGroup_Load(object sender, EventArgs e)
        {           
            if (form_type == "E")
            {
                txtUser_id.ReadOnly = true;
                string sql =
                String.Format(@"SELECT user_id,user_name,remark,createby,createdate,modifyby,modifydate FROM dbo.sys_user WHERE user_id ='{0}'", txtUser_id.Text);
                DataTable dt = clsApp.GetDataTable(sql);
                if (dt.Rows.Count > 0)
                {
                    txtUser_name.Text = dt.Rows[0]["user_name"].ToString();
                    txtRemark.Text = dt.Rows[0]["remark"].ToString();     
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
                txtRemark.Text = "";              
                txtCreateby.Text = DBUtility._user_id;
                txtCreatedate.Text =DateTime.Now.Date.ToString("yyyy/MM/dd");
                txtModifyby.Text = DBUtility._user_id; 
                txtModifydate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd");
            }           
        }

        private void frmSysUserGroup_FormClosed(object sender, FormClosedEventArgs e)
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
                MessageBox.Show("用户組別编号不可以为空格!");
                return;
            }
            if (Check_User_Exists())
                return;
            
            const string sql_new = @"INSERT INTO sys_user(user_id,user_name,group_id,remark,createby,createdate,modifyby,modifydate,status,typeid)
             VALUES(@user_id,@user_name,@group_id,@remark,@userid,getdate(),@userid,getdate(),'0',@typeid)";           
                
            SqlParameter[] spras = new SqlParameter[]
            {                
                new SqlParameter("@user_id",txtUser_id.Text ),
                new SqlParameter("@user_name",txtUser_name.Text ),
                new SqlParameter("@group_id",prent_node),
                new SqlParameter("@remark",txtRemark.Text ),                
                new SqlParameter("@typeid","G"),
                new SqlParameter("@userid",DBUtility._user_id),
            };
            if (clsApp.ExecuteNonQuery(sql_new, spras, false) > 0)
            {
                MessageBox.Show("新增用户组别成功!");                
            }
            Set_cur_user_node();
        }

        private void Save_Edit()
        {
           const string sql_u = 
            @"Update dbo.sys_user SET user_name=@user_name,modifyby=@userid,modifydate=getdate(),remark=@remark WHERE user_id =@user_id";           
            SqlParameter[] spras = new SqlParameter[]
            {                
                new SqlParameter("@user_name",txtUser_name.Text ),                     
                new SqlParameter("@remark",txtRemark.Text ),
                new SqlParameter("@user_id",txtUser_id.Text ),
                new SqlParameter("@userid",DBUtility._user_id )
            };
            if (clsApp.ExecuteNonQuery(sql_u, spras, false) > 0)
            {
                MessageBox.Show("修改当前用户组别成功!");
            }
            Set_cur_user_node();
        }

        private void Set_cur_user_node()
        {
            subNode.Text = String.Format("{0} [{1}]", txtUser_id.Text, txtUser_name.Text);
            subNode.Tag = String.Format("{0};[G]", txtUser_id.Text);
        }

        private void txtUser_id_Leave(object sender, EventArgs e)
        {
            if (form_type != "E" && txtUser_id.Text !="")
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
                MessageBox.Show(string.Format("该用户组别[{0}]已存在!", txtUser_name.Text));
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
