using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using cftest.CLS;
using SysDaan.Forms;
using System.Data.SqlClient;
using WeifenLuo.WinFormsUI.Docking;
using SysDaan.CLS;

namespace cftest.Forms
{
    public partial class frmSysFuntionMenu : DockContent
    {
        DataTable dtTopMenu;
        DataTable dtAllMenu;                   
        public string mState = ""; //新增或編輯的狀態         
        string cur_node_name = "";
        string cur_node_typeid = "";
        
        TreeNode node_cur_selected = null;//當前選中節點
        string lang_id = "3";
        public clsPublicOfPad clsApp = new clsPublicOfPad();


        public frmSysFuntionMenu()
        {
            InitializeComponent(); 
            
        }

        private void frmSysFuntionMenu_Load(object sender, EventArgs e)
        {
            //頂層菜單
            string strsql =string.Format(
            @"SELECT A.menu_id,A.menu_parent_id,A.window_id,A.relatively_station,A.pkey,B.[col_name] 
            FROM sys_menu_window A INNER JOIN sys_dictionary B ON A.menu_id=B.col_code 
            WHERE A.co_id='' and A.[language_id]=1 and A.user_id='admin' and Isnull(A.menu_parent_id,'')='' and A.visible='1' and B.[language_id]='{0}' and isnull(status,'0')='0'
            ORDER BY A.relatively_station", lang_id);
            dtTopMenu = clsApp.GetDataTable(strsql);
           
            //全部菜單
            strsql =string.Format(
            @"SELECT A.co_id, A.menu_id,Isnull(A.menu_parent_id,'') as menu_parent_id,Isnull(A.window_id,'') as window_id,A.relatively_station,Isnull(A.visible,0) as visible,
            A.remark,A.createby,A.createdate,A.modifyby,A.modifydate,A.pkey,B.[col_name],A.menu_id+' ['+Isnull(B.col_name,'')+']' AS menu_id_name
            FROM sys_menu_window A INNER JOIN sys_dictionary B ON A.menu_id=B.col_code   
            WHERE A.co_id='' and A.[language_id]=1 and A.user_id='admin' and A.visible='1' and B.[language_id]='{0}' and isnull(status,'0')='0'
            ORDER by A.relatively_station", lang_id);
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
                    MessageBox.Show("請先添加超級管理用戶[ADMIN],并設置程序菜單!", "系統提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            TreeNode TopNode0;
            TopNode0 = new TreeNode();
            TopNode0.Text = "菜單管理";
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
                    TopNode.Tag = dr["menu_id"].ToString() + ";[G]";//菜單名
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
                subNode1.Tag = dr["menu_id"].ToString() + ";" + "[" + isGroup + "]";     
                subNode.Nodes.Add(subNode1);
                AddChildNode(subNode1, dr["menu_id"].ToString());//递归调用的方法
            }            
        }

        private void splitContainer1_Resize(object sender, EventArgs e)
        {
            splitContainer1.SplitterDistance = 255;
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
            this.Close();
        }
               
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (mState == "")
                return;

            string within_code="";
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

            sql_i = string.Format(
               @"Insert Into sys_menu_window(co_id,language_id,relatively_station,user_id,menu_id,menu_name,menu_parent_id,window_id,remark,visible) Values ('{0}',{1},{2},'{3}','{4}','{5}','{6}','{7}','{8}',{9})",
               within_code, 1, int.Parse(txtRelatively_station.Text),DBUtility._user_id, txtMenu_id.Text,txtMenu_id_name, txtPrent_menu_id.EditValue.ToString(), txtWindow_id.Text, txtRemark.Text, chkVisible.Checked ? 1 : 0);
            sql_u = string.Format(@"UPDATE sys_menu_window SET relatively_station= {0},menu_id='{1}',menu_name='{2}',menu_parent_id='{3}',window_id='{4}',remark='{5}',visible={6} where pkey={7}",
                int.Parse(txtRelatively_station.Text), txtMenu_id.Text, txtMenu_id_name.Text, txtPrent_menu_id.EditValue.ToString(), txtWindow_id.Text, txtRemark.Text, chkVisible.Checked ? 1 : 0,int.Parse(txtpkey.Text));

            if (txtWindow_id.Text != "")
            {
                string window_id_path, formname;
                window_id_path = txtWindow_id.Text;
                formname = window_id_path.Substring(window_id_path.LastIndexOf(".") + 1, (window_id_path.Length - (window_id_path.LastIndexOf(".") + 1)));
                string sql_f = "Select tool_bar_obj_id From dbo.sys_window_toolbar Where window_id='" + formname + "' Order by seqence_id";
                DataTable dtToolbar = clsApp.GetDataTable(sql_f);
                if (dtToolbar.Rows.Count == 0)
                {
                    MessageBox.Show("請首先設置好窗體對應的工具欄按鈕!", "提示信息");
                    return;
                }

                sql_insert1 = @"INSERT INTO dbo.sys_user_popedom(within_code,usr_no,window_id,C0_STATE";
                sql_insert2 = string.Format("VALUES('{0}','{1}','{2}',1", within_code, DBUtility._user_id, txtWindow_id.Text);
                for (int i = 0; i < dtToolbar.Rows.Count; i++)
                {
                    strFld_id = "C" + i + 1.ToString() + "_ID";
                    strFld_state = "C" + i + 1.ToString() + "_STATE";
                    sql_insert1 += "," + strFld_id + "," + strFld_state;
                    sql_insert2 += string.Format(",'{0}',1", dtToolbar.Rows[i]["tool_bar_obj_id"].ToString());
                }
                sql_insert1 += ")";
                sql_insert2 += ")";
                sql_insert = sql_insert1 + sql_insert2;
            }
            else
                sql_insert = "";


            SqlConnection myCon = new SqlConnection(DBUtility.connectionString);
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
                        myCommand.CommandText = sql_u;
                        myCommand.ExecuteNonQuery();
                    }
                    myTrans.Commit(); //數據提交
                    save_flag = true;
                    SetButtonSatus(true);
                    SetObjValue.SetEditBackColor(splitContainer1.Panel2.Controls, false);
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
               MessageBox.Show("用戶權限數據設置成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            else            
               MessageBox.Show("用戶權限數據設置失敗！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);            
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
                MessageBox.Show("當前節點菜單項已最末級別菜單,不可再建立它的下一層子菜單!", "提示信息");
                return;
            }

            mState = "NEW";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(splitContainer1.Panel2.Controls, true);
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
            mState = "EDIT";
            SetButtonSatus(false);
            SetObjValue.SetEditBackColor(splitContainer1.Panel2.Controls, true);
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
            if(pCur_node_name == "MENU_MANAGE")
            {
                //頂層菜單
                strsql =string.Format(
                @"SELECT Convert(varchar(10),Max(relatively_station)+10) as seq_no FROM sys_menu_window  
                WHERE co_id='' and [language_id]=1 and user_id='admin' and Isnull(menu_parent_id,'')='' and visible='1' and Isnull(status,'0')='0'");                
            }
            else
            {                 
                strsql =string.Format(
                @"SELECT Convert(varchar(10),Max(relatively_station)+10) as seq_no FROM sys_menu_window    
                WHERE co_id='' and [language_id]=1 and menu_parent_id='{0}' and user_id='admin' and visible='1' and isnull(status,'0')='0'", pCur_node_name);                
            }
            result = clsApp.ExecuteSqlReturnObject(strsql);
            if (result == "")
                result = "10";
            return result ;
        }

        private bool Valite_Data()
        {
            bool result=false;
            if (txtMenu_id.Text != "" || txtPrent_menu_id.Text != "")
            {
                if (txtMenu_id.Text == txtPrent_menu_id.Text)
                {
                    MessageBox.Show("當前菜單與上級菜單不可以相同！", "提示信息");
                    result = false;
                }
                else
                    result = true;
            }
            else
            {
                MessageBox.Show("當前菜單與上級菜單不可以同時為空！", "提示信息");
                result = false;
            }
            if (txtMenu_id.Text == "" || txtPrent_menu_id.Text != "")
            {
                MessageBox.Show("當前菜單不可以為空！", "提示信息");
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
                    string msgCustom = String.Format("設置的上級菜單節點有問題,將出現無限循環!\n\n 因已存在節點【{0}】-->子節點【{1}】.", dtBom.Rows[records - 1]["parent_id"], dtBom.Rows[records - 1]["id"]);
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
                string sql_f = string.Format(@"SELECT col_name FROM sys_dictionary Where col_code='{0}' and language_id='3'", pMenu_id);
                txtMenu_id_name.Text = clsApp.ExecuteSqlReturnObject(sql_f);
                if (txtMenu_id_name.Text == "")
                {
                    MessageBox.Show("請先添加菜單對應的翻譯!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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
                MessageBox.Show("組節點不可注銷!", "提示信息");
                return;
            }
            
            string sql_u = string.Format(@"UPDATE sys_menu_window SET status='2' Where pkey={0}",int.Parse(txtpkey.Text));
            if (MessageBox.Show("註銷后菜單將不會出在系統菜單界面,是否要注銷此菜單?", "提示信息", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                int result=0;
                result = clsApp.ExecuteSqlUpdate(sql_u);
                if (result > 0)
                {                   
                    node_cur_selected.Remove();
                    MessageBox.Show("當前菜單項注銷成功!", "提示信息");
                }
                else
                    MessageBox.Show("當前菜單項注銷失敗!", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            SetButtonSatus(true);
            SetObjValue.SetEditBackColor(splitContainer1.Panel2.Controls, false);
        }

        

        
    }
}
