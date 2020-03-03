using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;
using cfvn.CLS;
using System.Reflection;
using System.Data.SqlClient;

namespace cfvn.Forms
{

    public partial class frmMain_Left : DockContent
    {
        readonly frmMain frm_main;
        private DockPanel dp;


        //--------------------------
        DataTable dtTopMenu;
        DataTable dtAllMenu;       
        DataTable dtNotExists = new DataTable();       
        TreeNode cur_node_selected ;//當前選中節點
        string str_cur_node_selected = "";
        string lang_id =DBUtility._language;
        public clsPublicOfVN clsApp = new clsPublicOfVN();
        //--------------------------

        public frmMain_Left(frmMain objForm)
        {
            InitializeComponent();
            frm_main = objForm;
            dp = (DockPanel)frm_main.Controls["dockPanel1"];//最關鍵的代碼 
            
        }


        private void frmMain_Left_Load(object sender, EventArgs e)
        {           
            string _user_id = DBUtility._user_id;
            string strsql,within_code;
            if (_user_id.ToUpper() == "ADMIN")
            {
                //最高管理權限
                within_code = "";
                strsql = string.Format(
               @"SELECT A.menu_id,A.menu_parent_id,A.window_id,A.relatively_station,B.[col_name] 
                FROM sys_menu_window A INNER JOIN sys_dictionary B ON A.menu_id=B.col_code   
                WHERE A.co_id='' and A.[language_id]=2 and A.user_id='{0}' and Isnull(A.menu_parent_id,'')='' and A.visible='1' and B.[language_id]='{1}'
                ORDER BY A.relatively_station", _user_id, lang_id);
                dtTopMenu = clsApp.GetDataTable(strsql);
            }
            else
            {
                //普通用戶此字段為非空
                within_code = "0000"; 
                SqlParameter[] paras=new SqlParameter[]{
                    new SqlParameter("@within_code",within_code),                   
                    new SqlParameter("@user_id",_user_id),
                    new SqlParameter("@language_id",lang_id)
                };
                dtTopMenu = clsApp.ExecuteProcedureReturnTable("usp_get_user_menu", paras);                
            }
            
            //取出ADMIN用戶（最高管理權限用戶）的菜單模板
            strsql = string.Format(
            @"SELECT A.menu_id,A.menu_parent_id,A.window_id,A.relatively_station,B.[col_name] 
            FROM sys_menu_window A INNER JOIN sys_dictionary B ON A.menu_id=B.col_code   
            WHERE A.co_id='' and A.[language_id]=2 and A.user_id='ADMIN' and A.visible='1' and B.[language_id]='{0}'
            ORDER by A.relatively_station", lang_id);
            dtAllMenu = clsApp.GetDataTable(strsql);
            try
            {
                if (dtTopMenu.Rows.Count > 0)
                {
                    InitMenu();
                    myTree.ExpandAll();//展開
                    myTree.SelectedNode = myTree.Nodes[0];//選中第上個節點
                }
                else
                {
                    MessageBox.Show("请首先添加好超级管理用户[ADMIN],并设置程序菜单!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myTree.Nodes.Clear();
                }
            }
            catch
            {
                myTree.Nodes.Clear();
            }
        }

        private void frmSysPopedomEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtTopMenu = null;
            dtAllMenu = null;            
            dtNotExists = null;
            cur_node_selected = null;
            clsApp = null;
        }

        private void chkExpand_CheckedChanged(object sender, EventArgs e)
        {
            if (chkExpand.Checked)
            {
                myTree.ExpandAll();
                myTree.SelectedNode = myTree.Nodes[0];
            }
            else
            {
                myTree.CollapseAll();
            }
        }

        protected void InitMenu()
        {
            //提取頂層菜單
            DataRow[] drArr = dtTopMenu.Select();
            //添加主菜单
            TreeNode TopNode;
            foreach (DataRow dr in drArr)
            {
                //主菜单的条件menu_parent_id =""
                if (dr["menu_parent_id"].ToString() == "")
                {
                    TopNode = new TreeNode();
                    TopNode.Text = dr["col_name"].ToString();//SetCaption(dr["Gname"].ToString());
                    TopNode.Tag = dr["menu_id"] + ";[G]";//菜單名 
                    myTree.ItemHeight = 20;
                    myTree.Nodes.Add(TopNode);
                    AddChildNode(TopNode, dr["menu_id"].ToString());//递归调用                                      
                }
            }
        }

        /// <summary>
        /// 递归调用方法，添加菜单的子菜单
        /// </summary>
        /// <param name="tsi"></param>
        public void AddChildNode(TreeNode subNode, string groupid)
        {
            DataRow[] drArr = dtAllMenu.Select(String.Format("menu_parent_id='{0}'", groupid));//查出这个菜单的所有的子菜单            
            if (drArr.Length == 0)
            {
                subNode.ImageIndex = subNode.SelectedImageIndex = 1;
                if (subNode.Tag.ToString().Contains("[G]"))
                    subNode.ImageIndex = subNode.SelectedImageIndex = 0;
                else
                    subNode.ImageIndex = subNode.SelectedImageIndex = 1;
            }

            string isGroup;
            TreeNode subNode1;
            foreach (DataRow dr in drArr)
            {
                subNode1 = new TreeNode();
                subNode1.Text = dr["col_name"].ToString();
                if (string.IsNullOrEmpty(dr["window_id"].ToString()))
                    isGroup = "[G]";//是父層節點
                else
                    isGroup = String.Format("[U]@{0}", dr["window_id"]);//窗體節點
                subNode1.Tag = String.Format("{0};{1}", dr["menu_id"], isGroup);
                subNode.Nodes.Add(subNode1);
                AddChildNode(subNode1, dr["menu_id"].ToString());//递归调用的方法
            }
        }

        private void OpenForm(DockContent objForm)
        {
            objForm.MdiParent = frm_main;           
            objForm.Show(dp);            
        }


        private bool checkChildFrmExist(string childFrmName)
        {
            bool isExist_flag = false;
            foreach (Form childFrm in frm_main.MdiChildren)
            {
                if (childFrm.Name == childFrmName)
                {                   
                    childFrm.Activate();
                    isExist_flag = true;
                    break;
                }
            }
            return isExist_flag;
        }

        //private void Open_Form(DockContent objForm)
        //{
        //    foreach (Form frm in frm_main.MdiChildren)
        //    {                
        //        if (objForm.Name == frm.Name) //if (frm is frmDept)
        //        {
        //            frm.Activate();
        //            return;
        //        }
        //    }
        //    objForm.MdiParent = frm_main;
        //    objForm.Show(dp);
        //    //frmB.Show(dp, DockState.DockTop);
        //}

        private void myTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            Call_Window(e.Node); 
        }

        private void Call_Window(TreeNode pNode)
        {
            string is_group_id;
            string window_id_path = "";
            if (pNode.Tag.ToString().Contains("[U]"))
                is_group_id = "U";//用戶節點
            else
                is_group_id = "G";//組節點            
            cur_node_selected = pNode;

            if (pNode != null)
                str_cur_node_selected = pNode.Tag.ToString();
            else
                str_cur_node_selected = "";
            if (is_group_id == "U")
            {
                string formname = "";
                int location = str_cur_node_selected.IndexOf("@") + 1;
                window_id_path = str_cur_node_selected.Substring(location, str_cur_node_selected.Length - location);
                //获取实际的窗体名
                formname = window_id_path.Substring(window_id_path.LastIndexOf(".") + 1, (window_id_path.Length - (window_id_path.LastIndexOf(".") + 1)));

                if (!checkChildFrmExist(formname))
                {
                    Assembly asb = Assembly.GetExecutingAssembly();//得到当前的程序集                    
                    DockContent frm = (DockContent)asb.CreateInstance("cfvn." + window_id_path);//利用反射，根据数据库中的字段值创建窗体对象            
                    frm.Text = cur_node_selected.Text;                    
                    OpenForm(frm);
                }
            }
        }

        

        
    }

  

   
      
}
