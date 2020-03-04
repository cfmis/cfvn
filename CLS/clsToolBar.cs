using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;

namespace cfvn.CLS
{
    public class clsToolBar
    {
        private DataTable dt_toobar = new DataTable();
        private Control.ControlCollection objControls;
        private string strFormNameFullpath;
        clsPublicOfVN clsPub = new clsPublicOfVN();
        public clsToolBar(string FormNameFullpath, Control.ControlCollection cts)
        {            
            strFormNameFullpath = FormNameFullpath;
            objControls = cts;            
        }
        
        /// <summary>
        /// Check button is enable by current user
        /// </summary>
        public void SetToolBar()
        {
            //表單工具欄按鈕權限            
            string sqlstr = string.Format(@"Select id,state From dbo.v_user_popedom Where usr_no='{0}' And window_id='{1}'", DBUtility._user_id, strFormNameFullpath);                       
            dt_toobar = clsPub.GetDataTable(sqlstr);
           
            //如果权限只设置到组别，所以查出组别权限
            if (dt_toobar.Rows.Count == 0)
            {
                sqlstr = string.Format(@"select group_id from sys_user where user_id='{0}'", DBUtility._user_id);
                string user_group = clsPub.ExecuteSqlReturnObject(sqlstr);
                if (user_group != "")
                {
                    sqlstr = string.Format(@"Select id,state From dbo.v_user_popedom Where usr_no='{0}' And window_id='{1}'", user_group, strFormNameFullpath);
                    dt_toobar = clsPub.GetDataTable(sqlstr);
                }
            }
            setValue(objControls);
        }


        /// <summary>
        /// 表單控件翻譯及工具欄按鈕權限
        /// </summary>
        /// <param name="objectname">控件集</param> 
        /// <param name="strControl">需要控制按鈕名字串</param>   
        private void setValue(Control.ControlCollection objcts)//, string strControl)
        {
            bool flag = false;//退出循環標志
            foreach (Control ct in objcts)
            {
                switch (ct.GetType().Name)
                {
                    case "ToolStrip":
                        ToolStrip ts = (ToolStrip)ct;
                        if (dt_toobar.Rows.Count == 0)
                        {
                            for (int i = 0; i < ts.Items.Count; i++)
                            {
                                ts.Items[i].Enabled = false; //如沒有設置權限全禁用
                            }
                            return;
                        }
                        string objName, strContains;
                        //檢查工作欄按鈕權限字串2017/12/13改為從數據庫表中查找      
                        string strSql = string.Format(@"SELECT stuff((Select ','+ltrim(tool_bar_obj_id) From dbo.sys_window_toolbar WHERE window_id='{0}' FOR XML path('')),1,1,'')", strFormNameFullpath);
                        strContains = clsPub.ExecuteSqlReturnObject(strSql);
                        flag = true;
                        for (int i = 0; i < ts.Items.Count; i++)
                        {
                            objName = ts.Items[i].Name.ToUpper();
                            if (objName.Substring(0, 3) == "BTN")
                            {
                                if (ts.Items[i].Enabled) //當按鈕可用狀態時再次檢查對應權限，重新校正
                                {
                                    objName = objName.Trim();
                                    DataRow[] dr = dt_toobar.Select(String.Format("id = '{0}'", objName));
                                    if (dr.Length > 0)
                                    {
                                        if (strContains.Contains(objName))
                                        {
                                            ts.Items[i].Enabled = (Boolean)dr[0][1]; //設置工具欄按鈕可否操作
                                        }
                                    }
                                    else
                                    {
                                        ts.Items[i].Enabled = false;
                                    }
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
                if (ct.HasChildren) //容器對象時繼續遞規查找
                {
                    if (!flag)
                    {
                        setValue(ct.Controls);
                    }
                }
                if (flag)
                {
                    break;
                }
            }
        }


        /// <summary>
        /// set button image
        /// </summary>
        /// <param name="tlstp"></param>
        public void Set_Button_Image(ToolStrip tlstp)
        {
            string ls_button_name = "", ls_file_image = "" ;            
            foreach (ToolStripItem tsp in tlstp.Items)
            {
                ls_button_name = tsp.Name.ToUpper();
                switch (ls_button_name)
                {
                    case "BTNEXIT":
                        ls_file_image = "Image\\exit.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNNEW":
                        ls_file_image = "Image\\24_Add.ico";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNEDIT":
                        ls_file_image = "Image\\edit.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNDELETE":
                        ls_file_image = "Image\\delete.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNITEMADD":
                        ls_file_image = "Image\\p_add_Item.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNITEMDEL":
                        ls_file_image = "Image\\DeleteMR.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNSAVE":
                        ls_file_image = "Image\\SAVE.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNCANCEL":
                        ls_file_image = "Image\\cancel.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNAPPROVE":
                        ls_file_image = "Image\\p_ok.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNPRINT":
                        ls_file_image = "Image\\print.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNFIND":
                        ls_file_image = "Image\\find.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNUNDO":
                        ls_file_image = "Image\\cancel.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNCOPY":
                        ls_file_image = "Image\\copy.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNEXCEL":
                        ls_file_image = "Image\\Excel.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNREFRESH":
                        ls_file_image = "Image\\refresh.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNIMPORT":
                        ls_file_image = "Image\\p_input.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNNEWVER":
                        ls_file_image = "Image\\p_batch_additem.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNOK":
                        ls_file_image = "Image\\p_ok.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;
                    case "BTNSAVESET":
                        ls_file_image = "Image\\w_set.png";
                        Load_Image_File(tsp, ls_file_image);
                        break;                   
                    default:
                        break;
                }
            }
        }

        private void Load_Image_File(ToolStripItem tsp, string ls_file_image)
        {
            string ls_image_path = AppDomain.CurrentDomain.BaseDirectory;
            ls_file_image = ls_image_path + ls_file_image;
            if (System.IO.File.Exists(ls_file_image))
            {
                tsp.Image = System.Drawing.Image.FromFile(ls_file_image);
            }
        }

        /// <summary>
        /// Set button is enable
        /// </summary>
        /// <param name="tlstp"></param>
        /// <param name="is_enable"></param>
        public void Set_Button_Enable_Status(ToolStrip tlstp,bool is_enable)
        {
            string ls_button_name = "";           
            foreach (ToolStripItem tsp in tlstp.Items)
            {
                ls_button_name = tsp.Name.ToUpper();
                switch (ls_button_name)
                {
                    case "BTNEXIT":
                        tsp.Enabled = true;                        
                        break;
                    case "BTNNEW":
                        tsp.Enabled = is_enable;                       
                        break;
                    case "BTNEDIT":
                        tsp.Enabled = is_enable;
                        break;
                    case "BTNDELETE":
                        tsp.Enabled = is_enable;
                        break;
                    case "BTNITEMADD":
                        tsp.Enabled = !is_enable;
                        break;
                    case "BTNITEMDEL":
                        tsp.Enabled = !is_enable;
                        break;
                    case "BTNSAVE":
                        tsp.Enabled = !is_enable;
                        break;
                    case "BTNCANCEL":
                        tsp.Enabled = !is_enable;
                        break;
                    case "BTNUNDO":
                        tsp.Enabled = !is_enable;
                        break;
                    case "BTNAPPROVE":
                        tsp.Enabled = is_enable;
                        break;
                    case "BTNPRINT":
                        tsp.Enabled = is_enable;
                        break;
                    case "BTNFIND":
                        tsp.Enabled = is_enable;
                        break;                    
                    case "BTNCOPY":
                        tsp.Enabled = !is_enable;
                        break;
                    case "BTNEXCEL":
                        tsp.Enabled = !is_enable;
                        break;
                    case "BTNREFRESH":
                        tsp.Enabled = !is_enable;
                        break;
                    case "BTNIMPORT":
                        tsp.Enabled = !is_enable;
                        break;
                    case "BTNNEWVER":
                        tsp.Enabled = !is_enable;
                        break;

                    default:
                        break;
                }
            }           

        }

    }
}
