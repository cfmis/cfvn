using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;
using cfvn.CLS;

namespace cfvn.Forms
{
    public partial class frmSysFuntionMenu : DockContent
    {
        DataTable dtTopMenu;
        DataTable dtAllMenu;                   
        public string mState = ""; //新增或編輯的狀態         
        string cur_node_name = "";
        string cur_node_typeid = "";

        TreeNode node_cur_selected;//當前選中節點
        readonly string lang_id = DBUtility._language;
        public clsPublicOfVN clsApp = new clsPublicOfVN();


        public frmSysFuntionMenu()
        {
            InitializeComponent();
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();
        }

        private void frmSysFuntionMenu_Load(object sender, EventArgs e)
        {
            //頂層菜單
            string strsql =string.Format(
            @"SELECT A.menu_id,A.menu_parent_id,A.window_id,A.relatively_station,A.pkey,B.[col_name] 
            FROM sys_menu_window A INNER JOIN sys_dictionary B ON A.menu_id=B.col_code 
            WHERE A.co_id='' and A.[language_id]='2' and A.user_id='{0}' and Isnull(A.menu_parent_id,'')='' and A.visible='1' and B.[language_id]='{1}' and Isnull(status,'0')='0'
            ORDER BY A.relatively_station", DBUtility._user_id, lang_id);
            dtTopMenu = clsApp.GetDataTable(strsql);
           
            //全部菜單
            strsql =string.Format(
            @"SELECT A.co_id, A.menu_id,Isnull(A.menu_parent_id,'') as menu_parent_id,Isnull(A.window_id,'') as window_id,A.relatively_station,Isnull(A.visible,0) as visible,
            A.remark,A.createby,A.createdate,A.modifyby,A.modifydate,A.pkey,B.[col_name],A.menu_id+' ['+Isnull(B.col_name,'')+']' AS menu_id_name
            FROM sys_menu_window A INNER JOIN sys_dictionary B ON A.menu_id=B.col_code   
            WHERE A.co_id='' and A.[language_id]='2' and A.user_id='{0}' and A.visible='1' and B.[language_id]='{1}' and Isnull(status,'0')='0'
            ORDER by A.relatively_station", DBUtility._user_id,lang_id);
            dtAllMenu = clsApp.GetDataTable(strsql);
            try
            {
                if (dtTopMenu.Rows.Count > 0)
                {
                    InitMenu();
                    //myTree1.ExpandAll();//展開
                    myTree.Nodes[0].Expand();//只展開頂層節點
                    //myTree.SelectedNode = myTree.Nodes[0];//選中第上個節點
                }
                else
                {
                    MessageBox.Show("请先添加超级管理用户[ADMIN],并设置程序菜单!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    myTree.Nodes.Clear();
                }
            }
            catch
            {
                myTree.Nodes.Clear();
            }
            DataTable dtPrent_menu = dtAllMenu.Clone();
            DataRow[] arydtr = dtAllMenu.Select("window_id=''");
            foreach (DataRow dr in arydtr)
            {               
                dtPrent_menu.ImportRow(dr);
            }
            arydtr = null;
            dtPrent_menu.DefaultView.Sort="menu_id ASC";
            txtPrent_menu_id.Properties.DataSource = dtPrent_menu;
            txtPrent_menu_id.Properties.ValueMember = "menu_id";
            txtPrent_menu_id.Properties.DisplayMember = "menu_id_name";

        }

        private void frmSysFuntionMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtTopMenu = null;
            dtAllMenu = null;                          
            node_cur_selected = null;
            clsApp = null;
        }

        protected void InitMenu()
        {            
            //添加主菜单          
            TreeNode TopNode0 = new TreeNode() { Text = "Menu Management" };
            myTree.Nodes.Add(TopNode0);
            TopNode0.Tag = "MENU_MANAGE;[G]";
            myTree.ItemHeight = 20;            
            if (TopNode0.Tag.ToString().Contains("MENU_MANAGE"))
                TopNode0.ImageIndex = TopNode0.SelectedImageIndex = 2;//設置最頂層節點的文件夾圖標
            else
                TopNode0.ImageIndex = TopNode0.SelectedImageIndex = 0;

            //取頂層菜單
            DataRow[] drArr = dtTopMenu.Select();

            //添加主菜单
            TreeNode TopNode;
            foreach (DataRow dr in drArr)
            {
                //主菜单的条件menu_parent_id =""
                if (dr["menu_parent_id"].ToString() == "")
                {                    
                    TopNode = new TreeNode();
                    TopNode.Text = dr["col_name"].ToString();
                    TopNode.Tag = dr["menu_id"] + ";[G]";//菜單名
                    TopNode0.Nodes.Add(TopNode);                    
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
                if(subNode.Tag.ToString().Contains("[G]"))                
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
                    isGroup = "G";//是父層節點
                else
                    isGroup = "U";//窗體節點
                subNode1.Tag = String.Format("{0};[{1}]", dr["menu_id"], isGroup);     
                subNode.Nodes.Add(subNode1);
                AddChildNode(subNode1, dr["menu_id"].ToString());//递归调用的方法
            }            
        }

       
        private void myTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string node_name, is_group_id = "";
            node_name = e.Node.Tag.ToString();
            int iLocation = node_name.IndexOf(";");
            node_name = node_name.Substring(0, iLocation);

            if (e.Node.Tag.ToString().Contains("[U]"))
                is_group_id = "U";//用戶節點
            else
                is_group_id = "G";//組節點
            cur_node_name = node_name;
            cur_node_typeid = is_group_id;
            node_cur_selected = e.Node;


            if (is_group_id == "G" && node_name == "MENU_MANAGE")
            {
                //最頂層節點
                Clear_obj_text();
            }
            if ((is_group_id == "G" || is_group_id == "U") && node_name != "MENU_MANAGE")
            {
                Set_obj_text();
            }
        }

        private void Set_obj_text()
        {
            DataRow[] dtrw = dtAllMenu.Select(string.Format("menu_id='{0}'", cur_node_name));
            txtCo_id.Text = dtrw[0]["co_id"].ToString();
            txtRelatively_station.Text = dtrw[0]["relatively_station"].ToString();
            if (dtrw[0]["visible"].ToString() == "1")
                chkVisible.Checked = true;
            else
                chkVisible.Checked = false;
            txtMenu_id.Text = dtrw[0]["menu_id"].ToString();
            Set_Menu_id_name(txtMenu_id.Text);
            txtPrent_menu_id.EditValue = dtrw[0]["menu_parent_id"].ToString();
            txtWindow_id.Text = dtrw[0]["window_id"].ToString();
            txtWindow_id_name.Text = node_cur_selected.Text;
            txtRemark.Text = dtrw[0]["remark"].ToString();
            txtCreateby.Text = dtrw[0]["createby"].ToString();
            txtCreatedate.Text = dtrw[0]["createdate"].ToString();
            txtModifyby.Text = dtrw[0]["modifyby"].ToString();
            txtModifydate.Text = dtrw[0]["modifydate"].ToString();
            txtpkey.Text = dtrw[0]["pkey"].ToString();
        }        

        private void Clear_obj_text()
        {
            txtCo_id.Text = "";
            txtRelatively_station.Text = "";
            txtMenu_id.Text = "";
            txtPrent_menu_id.EditValue = "";
            txtWindow_id.Text = "";
            txtWindow_id_name.Text = "";
            txtRemark.Text = "";
            txtCreateby.Text = "";
            txtCreatedate.Text = "";
            txtModifyby.Text = "";
            txtModifydate.Text = "";
            txtpkey.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }
               
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mState == "")
            {
                return;
            }

            const string ls_within_code = "";
            string sql_i,sql_u,sql_insert, sql_insert1, sql_insert2;
            string strFld_id, strFld_state;
            bool save_flag = false;

            if (!Valite_Data())
            {
                return;
            }
            if (txtMenu_id.Text != "" && txtPrent_menu_id.Text != "")
            {
                //檢查節點是否存在循環,如是則不允許保存
                if (IsExists_Loop(txtPrent_menu_id.EditValue.ToString(), txtMenu_id.Text))
                {
                    return;
                }
            }
            //默認英文菜單
            sql_i = string.Format(
               @"Insert Into sys_menu_window(co_id,language_id,relatively_station,user_id,menu_id,menu_name,menu_parent_id,window_id,remark,visible) Values ('{0}',{1},{2},'{3}','{4}','{5}','{6}','{7}','{8}',{9})",
               ls_within_code, 2, int.Parse(txtRelatively_station.Text),DBUtility._user_id, txtMenu_id.Text,txtMenu_id_name.Text , txtPrent_menu_id.EditValue, txtWindow_id.Text, txtRemark.Text, chkVisible.Checked ? 1 : 0);
            //sql_u = string.Format(@"UPDATE sys_menu_window SET relatively_station= {0},menu_id='{1}',menu_name='{2}',menu_parent_id='{3}',window_id='{4}',remark='{5}',visible={6} where pkey={7}",
            //int.Parse(txtRelatively_station.Text), txtMenu_id.Text, txtMenu_id_name.Text, txtPrent_menu_id.EditValue.ToString(), txtWindow_id.Text, txtRemark.Text, chkVisible.Checked ? 1 : 0,int.Parse(txtpkey.Text));

            if (txtWindow_id.Text != "")
            {
                string window_id_path = txtWindow_id.Text;// formname;
                //formname = window_id_path.Substring(window_id_path.LastIndexOf(".") + 1, (window_id_path.Length - (window_id_path.LastIndexOf(".") + 1)));
                string sql_f = String.Format("Select tool_bar_obj_id From dbo.sys_window_toolbar Where window_id='{0}' Order by seqence_id", window_id_path);
                DataTable dtToolbar = clsApp.GetDataTable(sql_f);
                if (dtToolbar.Rows.Count > 0)
                {
                    sql_insert1 = @"INSERT INTO dbo.sys_user_popedom(within_code,usr_no,window_id,C0_STATE";
                    sql_insert2 = string.Format("VALUES('{0}','{1}','{2}',1", ls_within_code, DBUtility._user_id, txtWindow_id.Text);
                    for (int i = 0; i < dtToolbar.Rows.Count; i++)
                    {
                        strFld_id = String.Format("C{0}_ID", i + 1);
                        strFld_state = String.Format("C{0}_STATE", i + 1);
                        sql_insert1 += String.Format(",{0},{1}", strFld_id, strFld_state);
                        sql_insert2 += string.Format(",'{0}',1", dtToolbar.Rows[i]["tool_bar_obj_id"]);
                    }
                    sql_insert1 += ")";
                    sql_insert2 += ")";
                    sql_insert = sql_insert1 + sql_insert2;
                }
                else 
                {
                    //Forms.frmSysPopedom为用户权限设置窗体
                    //权限菜单没有工具栏按钮，无需改新sys_user_popedom表
                    //除权限表单外,其它没有工具栏的窗体不允许添加功能菜单调用
                    sql_insert = "";
                    if (window_id_path != "Forms.frmSysPopedom")
                    {
                        MessageBox.Show("请首先设置好窗体对应的工具栏按钮!", "提示信息");
                        return;
                    }
                }

                
            }
            else
                sql_insert = "";


            SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);
            myCon.Open();
            SqlTransaction myTrans = myCon.BeginTransaction();
            using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
            {
                try
                {
                    if (mState == "NEW")
                    {
                        myCommand.CommandText = sql_i;
                        myCommand.ExecuteNonQuery();
                        if (sql_insert != "")
                        {
                            myCommand.CommandText = sql_insert;
                            myCommand.ExecuteNonQuery();
                        }                                   
                    }
                    else
                    {
                        sql_u = string.Format(@"UPDATE sys_menu_window SET relatively_station= {0},menu_id='{1}',menu_name='{2}',menu_parent_id='{3}',window_id='{4}',remark='{5}',visible={6} where pkey={7}",
                        int.Parse(txtRelatively_station.Text), txtMenu_id.Text, txtMenu_id_name.Text, txtPrent_menu_id.EditValue, txtWindow_id.Text, txtRemark.Text, chkVisible.Checked ? 1 : 0, int.Parse(txtpkey.Text));
                        myCommand.CommandText = sql_u;
                        myCommand.ExecuteNonQuery();
                    }
                    myTrans.Commit(); //數據提交
                    save_flag = true;
                    SetButtonSatus(true);
                    SetObjValue.SetEditBackColor(panel1.Controls, false);
                    mState = "";
                }
                catch (Exception E)
                {
                    myTrans.Rollback(); //數據回滾
                    save_flag = false;
                    throw new Exception(E.Message);
                }
                finally
                {
                    myCon.Close();
                    myCon.Dispose();
                    myTrans.Dispose();
                }
            }//using()語句結束

            if (save_flag)
                MessageBox.Show("菜单设置成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            else
                MessageBox.Show("菜单设置失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);            
        }      
               
        private void txtRelatively_station_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;//經過判斷爲數字可以輸入
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (txtMenu_id.Text != "" && txtWindow_id.Text != "")
            {
                MessageBox.Show("当前节点菜单项已是最末级別菜单,不可再建立它的下一层子菜单!", "提示信息");
                return;
            }

            mState = "NEW";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
            Clear_obj_text();
            if(cur_node_name!="")
            {
                if (cur_node_name == "MENU_MANAGE")                
                    txtPrent_menu_id.EditValue = "";
                else                
                    txtPrent_menu_id.EditValue = cur_node_name;                
                txtRelatively_station.Text = Get_Seq(cur_node_name);
            }
            txtCreateby.Text = DBUtility._user_id;
            txtCreatedate.Text = DateTime.Now.Date.ToString("yyyy/MM/dd hh:ss");
            chkVisible.Checked = true;
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (txtMenu_id.Text == "")
            {
                return;
            }
            mState = "EDIT";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(panel1.Controls, true);
        }

        private void SetButtonSatus(bool _flag)
        {
            btnNew.Enabled = _flag;
            btnEdit.Enabled = _flag;
            
            btnSave.Enabled = !_flag;
            btnUndo.Enabled = !_flag;
            btnCancel.Enabled = !_flag;
        }
        
        private string Get_Seq(string pCur_node_name)
        {
            string result="";
            string strsql;
            const int li_lang_id = 2;//sys_menu_window默認是英文語系添加
            if(pCur_node_name == "MENU_MANAGE")
            {
                //頂層菜單                
                strsql =string.Format(
                @"SELECT Convert(varchar(10),Max(relatively_station) + 5) as seq_no FROM sys_menu_window  
                WHERE co_id='' and [language_id]={0} and user_id='{1}' and Isnull(menu_parent_id,'')='' and visible='1' and Isnull(status,'0')='0'",li_lang_id,DBUtility._user_id);                
            }
            else
            {
                strsql =string.Format(
                @"SELECT Convert(varchar(10),Max(relatively_station) + 5) as seq_no FROM sys_menu_window    
                WHERE co_id='' and [language_id]={0} and menu_parent_id='{1}' and user_id='admin' and visible='1' and isnull(status,'0')='0'",li_lang_id , pCur_node_name);                
            }
            result = clsApp.ExecuteSqlReturnObject(strsql);
            if (result == "")
            {
                result = "5";
            }
            return result ;
        }

        private bool Valite_Data()
        {
            bool result=false;
            if (txtMenu_id.Text != "" || txtPrent_menu_id.Text != "")
            {
                if (txtMenu_id.Text == txtPrent_menu_id.Text)
                {
                    MessageBox.Show("当前菜单与上级菜单不可以相同！", "提示信息");
                    result = false;
                }
                else
                    result = true;
            }
            else
            {
                MessageBox.Show("当前菜单与上级菜单不可以同时为空！", "提示信息");
                result = false;
            }
            if (txtMenu_id.Text == "" && txtPrent_menu_id.Text != "")
            {
                MessageBox.Show("当前菜单不可以为空！", "提示信息");
                result = false;
            }
            return result;
        }       

        private bool IsExists_Loop(string _Parent_Node, string _id) // 是否存在死循環
        {
            SqlParameter[] paras = new SqlParameter[] {new SqlParameter("@Pid",_Parent_Node),new SqlParameter("@Sub_id",_id)};
            DataTable dtBom = clsApp.ExecuteProcedureReturnTable("usp_menu_isloop", paras);

            int records = dtBom.Rows.Count;
            if (records == 0)
            {
                return false;
            }
            else
            {
                //從第一條記錄中取當前子節點
                string id = dtBom.Rows[0]["id"].ToString();
                //從最後一條記錄中取父節點
                string parent_id = dtBom.Rows[records - 1]["parent_id"].ToString();
                if (parent_id != id)
                {
                    return false;
                }
                else
                {
                    string msgCustom = String.Format("设置的上级菜单节点有问题,将出现无限循环!\n\n 因已存在节点【{0}】-->子节点【{1}】.", dtBom.Rows[records - 1]["parent_id"], dtBom.Rows[records - 1]["id"]);
                    MessageBox.Show(msgCustom, "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return true;
                }
            }
        }

        private void txtMenu_id_Leave(object sender, EventArgs e)
        {
            if (txtMenu_id.Text != "")
            {
                Set_Menu_id_name(txtMenu_id.Text);
            }
        }

        private void Set_Menu_id_name(string pMenu_id)
        {
            if (pMenu_id != "")
            {
                string sql_f = string.Format(@"SELECT col_name FROM sys_dictionary Where col_code='{0}' and language_id='{1}'", pMenu_id, lang_id);
                txtMenu_id_name.Text = clsApp.ExecuteSqlReturnObject(sql_f);
                if (txtMenu_id_name.Text == "")
                {
                    MessageBox.Show("请先添加菜单对应的翻译!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    txtMenu_id.Focus();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (txtpkey.Text == "")
                return;
            if (cur_node_typeid == "G")
            {
                MessageBox.Show("组节点不可注销!", "提示信息");
                return;
            }
            
            string sql_u = string.Format(@"UPDATE sys_menu_window SET status='2' Where pkey={0}",int.Parse(txtpkey.Text));
            if (MessageBox.Show("注销后菜单将不会出现在系統菜单界面,是否要注销此菜单?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result = clsApp.ExecuteSqlUpdate(sql_u);
                if (result > 0)
                {                   
                    node_cur_selected.Remove();
                    MessageBox.Show("当前菜单项注销成功!", "提示信息");
                }
                else
                    MessageBox.Show("当前菜单项注销失败!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(panel1.Controls, false);
            mState = "";
        }

        

        
    }
}
