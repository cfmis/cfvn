using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using cfvn.CLS;
using WeifenLuo.WinFormsUI.Docking;

namespace cfvn.Forms
{
    public partial class frmSysPopedom : DockContent
    {
        DataTable dtGroup;
        DataTable dt;
        DataTable dtUser;
        string cur_node_user_id = "";
        string cur_node_typeid = "";
        TreeNode cur_node_selected;//當前選中節點
        string str_cur_node_selected = "";
        public clsPublicOfVN clsApp = new clsPublicOfVN();

        public frmSysPopedom()
        {
            InitializeComponent();            
        }

        private void frmSysPopedom_Load(object sender, EventArgs e)
        {
            const string strsql = @"SELECT user_id as group_id,user_name,typeid From sys_user WHERE user_id='ADMIN' AND typeid='U'";
            dtGroup = clsApp.GetDataTable(strsql);
            dt = clsApp.GetDataTable("select * from sys_user");
            try
            {
                if (dtGroup.Rows.Count > 0)
                {
                    InitMenu();
                    myTree.Nodes[0].Expand();//只展開頂層節點
                    //myTree.SelectedNode = myTree.Nodes[0];//選中第上個節點
                }
                else
                {
                    MessageBox.Show("请首先添加超级管理用户[ADMIN]!", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myTree.Nodes.Clear();
                }
            }
            catch
            {
                myTree.Nodes.Clear();
            }
        }

        protected void InitMenu()
        {
            //取出这个用户所在的角色的所有的权限
            //添加主菜单          
            TreeNode TopNode = new TreeNode() { Text = String.Format("{0} [{1}]", dtGroup.Rows[0]["group_id"], dtGroup.Rows[0]["user_name"]) };
            myTree.Nodes.Add(TopNode);
            TopNode.Tag = String.Format("{0};[G]", dtGroup.Rows[0]["group_id"]);       
            myTree.ItemHeight = 20;
            AddChildNode(TopNode, "ADMIN");//递归调用
            if(TopNode.Tag.ToString().Contains("ADMIN;"))
                TopNode.ImageIndex = TopNode.SelectedImageIndex = 2;//設置最頂層節點的文件夾圖標
            else
                TopNode.ImageIndex = TopNode.SelectedImageIndex = 0;
        }

        /// <summary>
        /// 递归调用方法，添加菜单的子菜单
        /// </summary>
        /// <param name="tsi"></param>
        public void AddChildNode(TreeNode subNode, string groupid)
        {
            DataRow[] drArr = dt.Select(String.Format("group_id='{0}'", groupid));//查出这个菜单的所有的子菜单            
            if (drArr.Length == 0)
            {
                subNode.ImageIndex = subNode.SelectedImageIndex = 1;
                if(subNode.Tag.ToString().Contains("[G]"))
                    subNode.ImageIndex = subNode.SelectedImageIndex = 0;                
                else
                    subNode.ImageIndex = subNode.SelectedImageIndex = 1;
            } 
            

            TreeNode subNode1;
            foreach (DataRow dr in drArr)
            {
                subNode1 = new TreeNode();
                subNode1.Text = String.Format("{0} [{1}]", dr["user_id"], dr["user_name"]);
                subNode1.Tag = String.Format("{0};[{1}]", dr["user_id"], dr["typeid"]);
                subNode.Nodes.Add(subNode1);
                AddChildNode(subNode1, dr["user_id"].ToString());//递归调用的方法
            }            
        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 255;
        }

        private void myTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string userid, typeid="";
            userid = e.Node.Tag.ToString();
            int iLocation = userid.IndexOf(";");
            userid = userid.Substring(0, iLocation );

            if (e.Node.Tag.ToString().Contains("[U]"))
                typeid = "U";//用戶節點
            else
                typeid = "G";//組節點
            cur_node_user_id = userid;
            cur_node_typeid = typeid;
            cur_node_selected = e.Node;
           
            
            if (e.Node != null)
            {
                str_cur_node_selected = e.Node.Tag.ToString();
                str_cur_node_selected = str_cur_node_selected.Substring(0, str_cur_node_selected.IndexOf(";"));
            }
            else
                str_cur_node_selected = "";

            //超級用戶
            if (userid=="ADMIN")
            {
                myTree.ContextMenuStrip = contextMenuStrip_admin;
                Get_User_Data("ADMIN","U","");
            }

            //修改或新增用戶
            if (userid != "ADMIN" && typeid == "U")
            {
                myTree.ContextMenuStrip = contextMenuStrip_user;
                string strPrentNode = e.Node.Parent.Tag.ToString();
                int location = strPrentNode.IndexOf(";");
                strPrentNode = strPrentNode.Substring(0, location);
                Get_User_Data(userid, typeid, strPrentNode);
            }
            
            //修改或新增用戶組別
            //if (!e.Node.Tag.ToString().Contains("ADMIN;") && e.Node.Tag.ToString().Contains("[G]"))
            if (userid != "ADMIN" && typeid == "G")
            {
                //cur_node_selected_prent = e.Node.Tag.ToString();
                //cur_node_selected_prent = cur_node_selected_prent.Substring(0, cur_node_selected_prent.IndexOf(";"));
                myTree.ContextMenuStrip = contextMenuStrip_group;
                Get_User_Data(userid, typeid,"");
            }
         
            //if (e.Node.Parent != null)
            //{
            //    TreeNode ss=e.Node.Parent;
            //    string name = e.Node.Parent.Name;//节点名称，看不到的
            //    string text = e.Node.Parent.Text;//节点文本，就是看到的                
            //}
        }

        private void Get_User_Data(string pStr,string type,string pNode)
        {
            string strsql= 
            @"Select user_id,user_name,password,group_id,ava_date,mis_date,remark,createby,createdate,modifyby,modifydate,typeid
                From sys_user Where ";
            if(type == "U")
            {
                if (pStr == "ADMIN")
                {
                    strsql += string.Format(@" user_id='{0}'", pStr);
                }
                else
                {                   
                    strsql += string.Format(@" group_id='{0}'", pNode);
                }
            }
            else
            {               
                strsql += string.Format(@" group_id='{0}'", pStr);                
            }
            dtUser = clsApp.GetDataTable(strsql);
            dataGridView1.DataSource = dtUser;
            if (type == "U")
            {
                for (int i = 0; i < dataGridView1.RowCount; i++)
                {                   
                    if (dataGridView1.Rows[i].Cells["user_id"].Value.ToString() == pStr)
                    {
                        dataGridView1.Rows[i].Selected = true;//定位行
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];//設置當前焦點行
                        break;
                    }
                }
            }
        }

        //刪除用戶
        private void contextMenuStrip_user_del_user_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("真的要刪除此条记录?","提示信息",MessageBoxButtons.YesNo,MessageBoxIcon.Information)==DialogResult.Yes)            
            {                
                string sql_del =string.Format(@"DELETE FROM sys_user WHERE user_id='{0}'",cur_node_user_id);
                if (clsApp.ExecuteSqlUpdate(sql_del) > 0)
                {
                    cur_node_selected.Remove(); //移除當前用戶節點
                    MessageBox.Show("刪除当前记录成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("刪除当前记录失败", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        //修改用戶
        private void contextMenuStrip_user_amd_user_Click(object sender, EventArgs e)
        {
            frmSysUserEdit frm = new frmSysUserEdit(cur_node_user_id, "E", "");
            frm.ShowDialog();
            if (frm.user_id_and_name != "")
            {
                cur_node_selected.Text = frm.user_id_and_name ;
                cur_node_selected.Tag = frm.user_id_and_typeid;
            }            
            frm.Dispose();
        }

        //修改用戶密碼
        private void contextMenuStrip_user_amd_pwd_Click(object sender, EventArgs e)
        {

            if (cur_node_typeid != "G")
            {
                frmSysPassword frm = new frmSysPassword(cur_node_user_id);
                frm.ShowDialog();
                frm.Dispose();
            }
        }

        //新增用戶
        private void contextMenuStrip_group_add_user_Click(object sender, EventArgs e)
        {
            frmSysUserEdit frm = new frmSysUserEdit("", "NEW", str_cur_node_selected);
            frm.ShowDialog();           
            if(frm.user_id_and_name !="")
            {                
                TreeNode cur_edit_node = new TreeNode();
                cur_edit_node.Text = frm.user_id_and_name;
                cur_edit_node.Tag = frm.user_id_and_typeid;
                cur_edit_node.ImageIndex = cur_edit_node.SelectedImageIndex = 1;
                cur_node_selected.Nodes.Add(cur_edit_node);                
            }            
            frm.Dispose();
        }

        //新增用戶組別
        private void contextMenuStrip_group_add_group_Click(object sender, EventArgs e)
        {
            Add_User_Group();
        }

        //修改用戶組別
        private void contextMenuStrip_group_amd_group_Click(object sender, EventArgs e)
        {
            Edit_User_Group();
        }

        //刪除用戶組別
        private void contextMenuStrip_group_del_group_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                MessageBox.Show("当前组别下存在其他用户,不可以直接刪除!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            
            if (MessageBox.Show("真的要刪除此条记录码?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
            {
                string sql_del = string.Format(@"DELETE FROM sys_user WHERE user_id='{0}'", cur_node_user_id);
                if (clsApp.ExecuteSqlUpdate(sql_del) > 0)
                {
                    cur_node_selected.Remove(); //移除當前用戶節點
                    MessageBox.Show("刪除当前记录成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                    MessageBox.Show("刪除当前记录失败", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        void Add_User_Group()
        {
            frmSysUserGroup frm = new frmSysUserGroup("", "NEW", str_cur_node_selected);
            frm.ShowDialog();
            if (frm.subNode.Text != "")
            {
                TreeNode cur_edit_node = new TreeNode() { Text = frm.subNode.Text, Tag = frm.subNode.Tag };
                cur_node_selected.Nodes.Add(cur_edit_node);
            }
            frm.Dispose();
        }

        void Edit_User_Group()
        {
            frmSysUserGroup frm = new frmSysUserGroup(cur_node_user_id, "E", "");
            frm.ShowDialog();
            if (frm.subNode.Text != "")
            {
                cur_node_selected.Text = frm.subNode.Text;
                cur_node_selected.Tag = frm.subNode.Tag;
            }
            frm.Dispose();
        }

        //新增用戶組別
        private void ctxMenu_admin_add_group_Click(object sender, EventArgs e)
        {
            Add_User_Group();
        }

        //修改用戶組別
        private void ctxMenu_admin_amd_user_Click(object sender, EventArgs e)
        {
            Edit_User_Group();
        }

        private void contextMenuStrip_group_setting_Click(object sender, EventArgs e)
        {
            frmSysPopedomEdit frm = new frmSysPopedomEdit(cur_node_user_id);            
            frm.ShowDialog();
            frm.Dispose();
        }

        private void contextMenuStrip_user_setting_Click(object sender, EventArgs e)
        {
            frmSysPopedomEdit frm = new frmSysPopedomEdit(cur_node_user_id);
            frm.ShowDialog();
            frm.Dispose();
        }

        private void frmSysPopedom_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtGroup.Dispose();
            dt.Dispose();
            dtUser.Dispose();
            cur_node_selected = null;       
            clsApp=null;
        }


        
    }
}
