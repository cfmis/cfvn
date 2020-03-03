using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using cfvn.CLS;
using System.Data.SqlClient;

namespace cfvn.Forms
{
    public partial class frmSysPopedomEdit : Form
    {
        DataTable dtTopMenu;
        DataTable dtAllMenu;
        DataTable dtPopedom;
        DataTable dtMenuByGroup;
        DataTable dtNotExists = new DataTable();
        string user_group_id = "";
        string cur_node_name = "";
        string cur_node_typeid = "";
        TreeNode cur_node_selected = null;//當前選中節點
        string str_cur_node_selected = "";
        string lang_id =DBUtility._language;// "1";
        public clsPublicOfVN clsApp = new clsPublicOfVN();

        public frmSysPopedomEdit(string userGroup)
        {
            InitializeComponent();
            clsTranslate obj_ctl = new clsTranslate( this.Controls, DBUtility._language);
            obj_ctl.Translate();

            user_group_id = userGroup;
            txtUser_Group.Text = user_group_id;
        }

        private void frmSysPopedomEdit_Load(object sender, EventArgs e)
        {
            string strsql =string.Format(
            @"SELECT A.menu_id,A.menu_parent_id,A.window_id,A.relatively_station,B.[col_name] 
            FROM sys_menu_window A INNER JOIN sys_dictionary B ON A.menu_id=B.col_code   
            WHERE A.co_id='' and A.[language_id]=2 and A.user_id='admin' and Isnull(A.menu_parent_id,'')='' and A.visible='1' and B.[language_id]='{0}'
            ORDER BY A.relatively_station", lang_id);
            dtTopMenu = clsApp.GetDataTable(strsql);
            strsql =string.Format(
            @"SELECT A.menu_id,A.menu_parent_id,A.window_id,A.relatively_station,B.[col_name] 
            FROM sys_menu_window A INNER JOIN sys_dictionary B ON A.menu_id=B.col_code   
            WHERE A.co_id='' and A.[language_id]=2 and A.user_id='admin' and A.visible='1' and B.[language_id]='{0}'
            ORDER by A.relatively_station", lang_id);
            dtAllMenu = clsApp.GetDataTable(strsql);
            try
            {
                if (dtTopMenu.Rows.Count > 0)
                {
                    InitMenu();
                    //myTree1.ExpandAll();//展開
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
        }

        private void frmSysPopedomEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            dtTopMenu = null;
            dtAllMenu = null;
            dtPopedom = null;
            dtMenuByGroup = null;
            dtNotExists = null;
            cur_node_selected = null;
            clsApp = null;
        }

        protected void InitMenu()
        {
            //取頂層菜單
            DataRow[] drArr = dtTopMenu.Select();

            //添加主菜单
            TreeNode TopNode;
            foreach (DataRow dr in drArr)
            {
                //主菜单的条件menu_parent_id =""
                if (dr["menu_parent_id"].ToString()=="")
                {
                    TopNode = new TreeNode();
                    TopNode.Text = dr["col_name"].ToString();//SetCaption(dr["Gname"].ToString());
                    TopNode.Tag = dr["menu_id"]+";[G]";//菜單名 
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
            cur_node_selected = e.Node;
           
            
            if (e.Node != null)
            {
                str_cur_node_selected = e.Node.Tag.ToString();
                str_cur_node_selected = str_cur_node_selected.Substring(0, str_cur_node_selected.IndexOf(";"));
            }
            else
                str_cur_node_selected = "";
            
          
            if (is_group_id == "G")
            {  
                Get_User_Data(node_name, is_group_id, ""); 
            }

            if (is_group_id == "U")
            {               
                string strPrentNode = e.Node.Parent.Tag.ToString();
                int location = strPrentNode.IndexOf(";");
                strPrentNode = strPrentNode.Substring(0, location);
                //如果是不同的菜單組別重新查詢
                if (strPrentNode != dtPopedom.Rows[0]["menu_parent_id"].ToString())
                {
                    Get_User_Data(node_name, is_group_id, strPrentNode);
                }
              
                for (int i = 0; i < dgvDetails.RowCount; i++)
                {
                    if (dgvDetails.Rows[i].Cells["menu_id"].Value.ToString() == cur_node_name)
                    {
                        dgvDetails.Rows[i].Selected = true;//定位行
                        dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells[1];//設置當前焦點行
                        break;
                    }
                }
            }
        }

        private void Get_User_Data(string pNode_name, string pIs_group_id, string pPrent_node_id)
        {
            string cur_node_name = "";
            if (pIs_group_id == "U")
            {
                //如為窗體節點(pis_group_id="U"),則取該節點父層節點下的所有窗體權限,
                //如為父層節點(pis_group_id="G"),pnode_name本身已是父層節點,不需重新賦值,也是取該節點父層節點下的所有窗體權限
                cur_node_name = pPrent_node_id;
            }
            else
                cur_node_name = pNode_name;
            
            SqlParameter[] paras = new SqlParameter[]{
            new SqlParameter("@language_id",lang_id),
            new SqlParameter("@user_id",user_group_id),
            new SqlParameter("@menu_id",cur_node_name),
            };

            //找出父層菜單等于pPrent_node_id、且用戶名等于user_group_id的全部菜單出來
            dtPopedom = clsApp.ExecuteProcedureReturnTable("usp_get_user_popedom", paras);//已有設置權限的列表  
            dgvDetails.DataSource = dtPopedom;

            Get_User_Date_Not_Exists(cur_node_name);//未有設置權限的列表

            dtPopedom.DefaultView.Sort = "relatively_station ASC";//排序
            //dgvDetails.DataSource = dtPopedom;
               
            if (pIs_group_id == "U")
            {
                for (int i = 0; i < dgvDetails.RowCount; i++)
                {
                    if (dgvDetails.Rows[i].Cells["menu_id"].Value.ToString() == pNode_name)
                    {
                        dgvDetails.Rows[i].Selected = true;//定位行
                        dgvDetails.CurrentCell = dgvDetails.Rows[i].Cells[1];//設置當前焦點行
                        break;
                    }
                }
            }
        }

        private void Get_User_Date_Not_Exists(string pPrent_Node_id)
        { 
            string sql =string.Format(
            //@"SELECT window_id FROM sys_menu_window            
            @"SELECT menu_id,window_id FROM sys_menu_window            
            WHERE co_id='' AND menu_parent_id='{0}' AND ISNULL(window_id,'')<>'' AND visible=1
            ORDER BY relatively_station", pPrent_Node_id);
            dtMenuByGroup = clsApp.GetDataTable(sql);//取得菜單組別節點下的全部窗體
            DataRow[] drs2 = null;
            DataRow[] drs1 = null;
            string strmenu_id,strwindow_id;
            if (dtMenuByGroup.Rows.Count > 0)
            {
                for (int i = 0; i < dtMenuByGroup.Rows.Count; i++)
                {
                    strmenu_id = dtMenuByGroup.Rows[i]["menu_id"].ToString();
                    strwindow_id = dtMenuByGroup.Rows[i]["window_id"].ToString();
                    drs1 = dtPopedom.Select(string.Format("window_id='{0}'", strwindow_id));
                    if (drs1.Length == 0)
                    {
                        SqlParameter[] paras = new SqlParameter[]{
                            new SqlParameter("@language_id",lang_id),
                            new SqlParameter("@user_or_group_id",user_group_id), //用戶或組別節點
                            new SqlParameter("@menu_parent_id",pPrent_Node_id),//菜單組別節點
                            new SqlParameter("@menu_id",strmenu_id),//窗體對應菜單的ID
                            new SqlParameter("@window_id",strwindow_id),//窗體ID

                        };
                        //查找未在列表中的數據
                        //sys_window_toolbar表中的seqence_id（需是大于1的自然數）不可以是0，否則將拋出異常
                        dtNotExists = clsApp.ExecuteProcedureReturnTable("usp_get_no_exists_user_popedom", paras);
                        drs2 = dtNotExists.Select();
                        foreach (DataRow dr in drs2)
                        {
                            dtPopedom.ImportRow(dr);
                        }
                    }
                }
            }
        }
       

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        //全選行
        private void btnRowSelect_Click(object sender, EventArgs e)
        {
            if (dtPopedom.Rows.Count > 0)
            {
                Set_Row_State(true);
            }
        }

        //反選行
        private void btnRowUnSelect_Click(object sender, EventArgs e)
        {
            if (dtPopedom.Rows.Count > 0)
            {
                Set_Row_State(false);
            }
        }

        private void Set_Row_State(bool pflag_select)
        {
            string strFld_id, strFld_state;
            int cur_row_index = dgvDetails.CurrentRow.Index; //dgvDetails.CurrentCell.RowIndex;
            
            if (dgvDetails.CurrentCell.RowIndex < 0)
            {
                return;
            }            
            dgvDetails.Rows[cur_row_index].Cells["C0_STATE"].Value = pflag_select;
            for (int i = 1; i < 21; i++)
            {
                strFld_id = String.Format("C{0}_ID", i);
                strFld_state = String.Format("C{0}_STATE", i);
                if (dgvDetails.Rows[cur_row_index].Cells[strFld_id].Value.ToString() != "")
                {
                    dgvDetails.Rows[cur_row_index].Cells[strFld_state].Value = pflag_select;
                }
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            Set_SelectAll_State(true);//全選
        }

        private void btnUnSelectAll_Click(object sender, EventArgs e)
        {
            Set_SelectAll_State(false);//反選
        }      

        /// <summary>
        /// pflag_select=true is Select all
        /// pflag_select=false is UNSelect all
        /// </summary>
        /// <param name="pflag_select"></param>
        private void Set_SelectAll_State(bool pflag_select)
        {
            string strFld_id, strFld_state;
            for (int i = 0; i < dtPopedom.Rows.Count; i++)
            {
                dtPopedom.Rows[i]["C0_STATE"] = pflag_select;
                for (int j = 1; j < 21; j++)
                {
                    strFld_id = String.Format("C{0}_ID", j);
                    strFld_state = String.Format("C{0}_STATE", j);
                    if (dtPopedom.Rows[i][strFld_id].ToString() != "")
                    {
                        dtPopedom.Rows[i][strFld_state] = pflag_select;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            txtUser_Group.Focus();
            const string language_id = "2";
            const string within_code = "0000";
            string row_state = "", result="";
            string sql_insert, sql_insert1, sql_insert2, sql_menu_i, sql_menu_i1, sql_menu_i2, sql_u, sql_del, sql_del2, sql_f;
            string strFld_id, strFld_state,strFld_text;
            bool save_flag = false;
            int li_counter = 0;
            SqlConnection myCon = new SqlConnection(DBUtility.ConnectionString);
            myCon.Open();
            SqlTransaction myTrans = myCon.BeginTransaction();
            using (SqlCommand myCommand = new SqlCommand() { Connection = myCon, Transaction = myTrans })
            {
                try
                {
                    for (int i = 0; i < dtPopedom.Rows.Count; i++)
                    {
                        row_state = dtPopedom.Rows[i].RowState.ToString();                       
                        if (row_state == "Modified" || row_state == "Added")
                        {
                            li_counter += 1;
                            if (li_counter > 1)
                            {
                                //需重新初連接及事務
                                myCommand.Connection = myCon;
                                myTrans = myCon.BeginTransaction();//重新開啟事務為手動提交，因多次提交不進行此設置將出錯
                                myCommand.Transaction = myTrans;
                            }

                            sql_f=string.Format("select '1' from sys_user_popedom Where within_code='{0}' and usr_no='{1}' and window_id='{2}'", within_code, txtUser_Group.Text, dtPopedom.Rows[i]["window_id"]);
                            result = clsApp.ExecuteSqlReturnObject(sql_f);
                            if (result == "1")
                            {
                                row_state = "Modified";
                            }
                            else
                            {
                                row_state = "Added";
                            }
                            if (row_state == "Modified")
                            {
                                if (dtPopedom.Rows[i]["C0_STATE"].ToString() == "True")
                                {
                                    sql_u = @"Update dbo.sys_user_popedom SET ";
                                    for (int j = 1; j < 21; j++)
                                    {
                                        strFld_id = String.Format("C{0}_ID", j);
                                        strFld_state = String.Format("C{0}_STATE", j);                                        
                                        if (dtPopedom.Rows[i][strFld_id].ToString() != "")
                                        {
                                            if (dtPopedom.Rows[i][strFld_state].ToString() == "True")
                                                sql_u += strFld_state + "=1,";
                                            else
                                                sql_u += strFld_state + "=0,";
                                        }
                                    }
                                    sql_u = sql_u.Substring(0, sql_u.Length - 1);//去除末尾的“,”號
                                    sql_u += String.Format(" Where within_code='{0}' and usr_no='{1}' and window_id='{2}'", within_code, txtUser_Group.Text, dtPopedom.Rows[i]["window_id"]);
                                    
                                    myCommand.CommandText = sql_u;
                                    myCommand.ExecuteNonQuery();
                                }
                                else
                                {
                                    sql_del = String.Format(
                                       @"DELETE FROM dbo.sys_user_popedom WHERE within_code='{0}' and usr_no='{1}' and window_id='{2}'", 
                                        within_code, txtUser_Group.Text, dtPopedom.Rows[i]["window_id"]);
                                    sql_del2 = String.Format(
                                       @"DELETE FROM dbo.sys_menu_window WHERE co_id='{0}' and language_id='{1}' and menu_id='{2}' and user_id='{3}' and menu_parent_id='{4}'",
                                        within_code, language_id, dtPopedom.Rows[i]["window_id"], dtPopedom.Rows[i]["USR_NO"], dtPopedom.Rows[i]["menu_parent_id"]);
                                    
                                    myCommand.CommandText = sql_del;
                                    myCommand.ExecuteNonQuery();
                                    myCommand.CommandText = sql_del2;
                                    myCommand.ExecuteNonQuery();
                                }
                                myTrans.Commit(); //數據提交
                                save_flag = true;
                            }
                            else  //add new
                            {
                                if (dtPopedom.Rows[i]["C0_STATE"].ToString() == "True")
                                {
                                    sql_insert1 = @"INSERT INTO dbo.sys_user_popedom(within_code,usr_no,window_id,C0_STATE,";
                                    sql_insert2 = string.Format("VALUES('0000','{0}','{1}',1,",dtPopedom.Rows[i]["USR_NO"],dtPopedom.Rows[i]["window_id"]);
                                    for (int j = 1; j < 21; j++)
                                    {
                                        strFld_id = String.Format("C{0}_ID", j);
                                        strFld_state = String.Format("C{0}_STATE", j);
                                        strFld_text = String.Format("C{0}_TEXT", j);                                       
                                        if (dtPopedom.Rows[i][strFld_id].ToString() != "")
                                        {
                                            sql_insert1 += String.Format("{0},{1},{2},", strFld_state, strFld_id, strFld_text);
                                            if (dtPopedom.Rows[i][strFld_state].ToString() == "True")
                                                sql_insert2 += String.Format("1,'{0}','{1}',", dtPopedom.Rows[i][strFld_id], dtPopedom.Rows[i][strFld_text]);
                                            else
                                                sql_insert2 += String.Format("0,'{0}','{1}',", dtPopedom.Rows[i][strFld_id], dtPopedom.Rows[i][strFld_text]); 
                                        }
                                    }
                                    sql_insert1 = sql_insert1.Substring(0, sql_insert1.Length - 1) + ")";
                                    sql_insert2 = sql_insert2.Substring(0, sql_insert2.Length - 1) + ")";
                                    sql_insert = sql_insert1 + sql_insert2;
                                    
                                    sql_menu_i1 = @"INSERT INTO dbo.sys_menu_window(co_id,language_id,menu_id,menu_name,user_id,menu_parent_id,window_id,relatively_station,visible)";
                                    sql_menu_i2 =
                                    string.Format(@"VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}',{7},{8})", within_code, language_id, dtPopedom.Rows[i]["menu_id"],dtPopedom.Rows[i]["window_name"],
                                       dtPopedom.Rows[i]["USR_NO"], dtPopedom.Rows[i]["menu_parent_id"], dtPopedom.Rows[i]["window_id"],int.Parse(dtPopedom.Rows[i]["relatively_station"].ToString()), 1);
                                    sql_menu_i = sql_menu_i1 + sql_menu_i2;
                                    
                                    myCommand.CommandText = sql_insert;
                                    myCommand.ExecuteNonQuery();
                                    myCommand.CommandText = sql_menu_i;
                                    myCommand.ExecuteNonQuery();
                                    myTrans.Commit(); //數據提交
                                    save_flag = true;
                                }
                            }
                        }
                    }//---FOR循環結束
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
               MessageBox.Show("用户权限数据设置成功！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);            
            else            
               MessageBox.Show("用戶权限数据设置失败！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Stop);            
        }      

        private void dgvDetails_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvDetails.Columns[e.ColumnIndex].Name == "C0_STATE")
            {           
                if (dgvDetails.Rows[e.RowIndex].Cells[e.ColumnIndex].EditedFormattedValue.ToString() == "True")
                    Set_Row_State(true);                
                else
                    Set_Row_State(false);
            } 
        }
        


        
    }
}
