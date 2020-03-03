using System;
using System.Collections.Generic;
using System.Linq;
using System.Data;

namespace cfvn.CLS
{
    public static class clsGoodsCode
    {
        private static clsPublicOfVN clsApp = new clsPublicOfVN();
        public static void Set_DropBox_For_State(DevExpress.XtraEditors.LookUpEdit obj,string lang_id)
        {
            DataTable dtState = new DataTable();
            dtState = clsApp.GetDataTable(
                string.Format(@"SELECT id,matter as name FROM dbo.sy_bill_state WHERE language_id='{0}'",lang_id));
            obj.Properties.DataSource = dtState;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        public static void Set_Genno(DevExpress.XtraEditors.LookUpEdit obj)
        {            
            DataTable dtGenno = clsApp.GetDataTable(@"SELECT id,english_name+'('+name+')' AS name FROM dbo.cd_goodscode_genno");
            obj.Properties.DataSource = dtGenno;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }


        /// <summary>
        /// 取值方式
        /// </summary>
        /// <param name="obj"></param>
        public static void SetValue(string strType,DevExpress.XtraEditors.LookUpEdit other, DevExpress.XtraEditors.TextEdit segment_start,
            DevExpress.XtraEditors.TextEdit fixation_value,DevExpress.XtraEditors.LookUpEdit column,string state)
        {
            fixation_value.BackColor = System.Drawing.Color.WhiteSmoke;
            segment_start.BackColor = System.Drawing.Color.WhiteSmoke;
            column.Properties.ReadOnly = true;//編號規則這主檔及固定值時方可用此欄的下拉列表框            
            
            if (strType == "3")//主檔
            {
                //設置取值方式
                //other.Enabled =true;
                DataTable dtTables = clsApp.GetDataTable(@"SELECT id,remark AS name FROM dbo.cd_goodscode_tables order by id");
                other.Properties.DataSource = dtTables;                
                other.Properties.ValueMember = "id";
                other.Properties.DisplayMember = "name";
                other.Enabled = false ;
                segment_start.Enabled = true;   //起止值                
                if (state != "")
                {
                    segment_start.BackColor = System.Drawing.Color.LemonChiffon;
                }

                fixation_value.Enabled = false; //固定值
                fixation_value.EditValue = "" ; //固定值
            }
            else
            {
                //貨品類型
                if (strType == "4")
                {                   
                    DataTable dtProduct = clsApp.GetDataTable(@"Select log_no as id,type as name FROM dbo.cd_goodscode Where log_no in('0001','0003') Order By log_no");
                    other.Properties.DataSource = dtProduct;
                    other.Properties.ValueMember = "id";
                    other.Properties.DisplayMember = "name";
                    fixation_value.Enabled = false; //固定值
                    fixation_value.EditValue = ""; //固定值
                    segment_start.Enabled = true;                    
                    if (state != "")
                    {
                        segment_start.BackColor = System.Drawing.Color.LemonChiffon;
                    }
                }
                else
                {
                    if (strType == "0")//流水號
                    {
                        segment_start.Enabled = false;
                        segment_start.EditValue = null;
                        fixation_value.Enabled = false; 
                        fixation_value.EditValue = ""; 
                        column.Enabled = false;
                        column.EditValue = "";
                    }
                    if (strType == "1")//固定值
                    {
                        //起止位置
                        segment_start.Enabled = false;
                        segment_start.EditValue = null ;
                        //對應欄位
                        column.Enabled = false;
                        column.EditValue = null;
                        //固定值
                        fixation_value.Enabled = true;                       
                        //fixation_value.EditValue = "";
                        if (state != "")
                        {
                            fixation_value.BackColor = System.Drawing.Color.LemonChiffon;
                        }
                    }                    
                    other.Enabled = false;
                    other.EditValue = null;
                }
            }


           //設置對應字段
            if (strType == "2" || strType == "3")
            {
                //取值範圍是2--手動輸入;3--主檔                
                DataTable dtFieldList = clsApp.GetDataTable(@"Select column_name as id,remark as name FROM dbo.cd_goodscode_column Order By id");
                column.Properties.DataSource = dtFieldList;
                column.Properties.ValueMember = "id";
                column.Properties.DisplayMember = "name";
                column.Enabled = true ;
                column.Properties.ReadOnly = false;
                if(state !="")
                    column.BackColor = System.Drawing.Color.LemonChiffon;
                else
                    column.BackColor = System.Drawing.Color.WhiteSmoke;                
            }
            else
            {
                column.Enabled = false;
                column.EditValue = null;
                column.BackColor = System.Drawing.Color.WhiteSmoke;
            }

            if (strType == "")
            {
                other.Enabled = false;
                other.EditValue = null;

                segment_start.Enabled = false;
                segment_start.EditValue = null;

                fixation_value.Enabled = false;
                fixation_value.EditValue = null;

                column.Enabled = false;
                column.EditValue = null;
            }            
        }

        public static void Set_lenth(DevExpress.XtraEditors.SpinEdit segment_length, DevExpress.XtraEditors.TextEdit segment_start,DevExpress.XtraEditors.TextEdit segment_end )
        {
            segment_end.Text = segment_start.Text == "0" || string.IsNullOrEmpty(segment_start.Text) ? "0" : (int.Parse(segment_start.Text) + int.Parse(segment_length.Text) - 1).ToString();
        }


        public static string Set_Goods_id(DevExpress.XtraEditors.SpinEdit segment_length, DevExpress.XtraEditors.LookUpEdit sfm, DevExpress.XtraEditors.TextEdit sfx, DevExpress.XtraEditors.TextEdit fixation_value)
        {            
            //貨品格式
            string ls_goods_id, ls_goods_id_temp;
            string strValue, ls_sfx = "";
            if ((segment_length.Text==""?0:int.Parse(segment_length.Text)) > 0)
            {
                //固定前綴
                strValue = "";
                ls_sfx = string.IsNullOrEmpty(sfx.Text) ? "" : sfx.Text;
                if (sfm.EditValue.ToString() == "0")//流水號
                {
                    ls_goods_id = strValue.PadLeft(int.Parse(segment_length.Text) - 1, '0') + "1";
                }
                else
                {
                    //判斷是否存在指定的固定值
                    if (string.IsNullOrEmpty(fixation_value.Text))
                    {
                        ls_goods_id = strValue.PadLeft(int.Parse(segment_length.Text), '@');
                    }
                    else
                    {
                        ls_goods_id = fixation_value.Text;
                    }
                }
                ls_goods_id = ls_sfx + ls_goods_id;
            }
            else
            {
                ls_goods_id = "";
            }
            ls_goods_id_temp = ls_goods_id;
            return ls_goods_id_temp; 
        }

        public static void Check_Length(DevExpress.XtraEditors.SpinEdit segment_length, DevExpress.XtraEditors.LookUpEdit sfm, string state, DevExpress.XtraEditors.TextEdit fixation_value)
        {
            if (state != "")
            {               
                if (sfm.Text != "" && segment_length.Text == "0")
                {
                    System.Windows.Forms.MessageBox.Show("Please enter the length", "System Information.");
                    if (sfm.EditValue.ToString() == "1")//固定值
                    {
                        fixation_value.BackColor = System.Drawing.Color.White;//將顏色還原回非編號狀態
                        fixation_value.Enabled = false;  
                    }
                    sfm.EditValue = "";
                }
            }
        }

        public static string Get_Picture_Name(string artwork)
        {
            string ls_result="";
            if (artwork != "")
            {               
                string strSql = string.Format(
                @"SELECT TOP 1 C.picture_path+'\'+ISNULL(B.picture_name,'') AS picture_name
                FROM dbo.cd_pattern A with(nolock)
                INNER JOIN dbo.cd_pattern_details B with(nolock) ON A.id=B.id,
                dbo.cd_company C with(nolock)
                WHERE A.id='{0}' And A.state<>'2'", artwork);
                ls_result = clsApp.ExecuteSqlReturnObject(strSql);
            }
            return ls_result;
        }


        /// <summary>
        /// Coding Type
        /// </summary>
        /// <param name="obj"></param>
        public static void Set_DropBox_For_CodingType(DevExpress.XtraEditors.LookUpEdit obj, string lang)
        {
            DataTable dtType = new DataTable();
            if (lang == "2")
                dtType = clsApp.GetDataTable(@"Select log_no as id,english_type as name From dbo.cd_goodscode Where state<>'2' order by log_no");
            else
                dtType = clsApp.GetDataTable(@"Select log_no as id,type as name From dbo.cd_goodscode Where state<>'2' order by log_no");
            obj.Properties.DataSource = dtType;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// Modality
        /// </summary>
        /// <param name="obj"></param>
        public static void Set_DropBox_For_Modality(DevExpress.XtraEditors.LookUpEdit obj,string lang)
        {
            DataTable dtModality = new DataTable();
            if(lang =="2")
                dtModality = clsApp.GetDataTable(@"SELECT id,english_name as name FROM dbo.cd_goodscode_modality Order by id");
            else
                dtModality = clsApp.GetDataTable(@"SELECT id,name FROM dbo.cd_goodscode_modality Order by id");
            obj.Properties.DataSource = dtModality;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// quantity Unit
        /// </summary>
        /// <param name="obj"></param>
        public static void Set_DropBox_For_Unit(DevExpress.XtraEditors.LookUpEdit obj)
        {
            DataTable dtUnit = new DataTable();
            dtUnit = clsApp.GetDataTable(@"SELECT id,name FROM dbo.bs_unit WHERE kind='05' order by id");
            obj.Properties.DataSource = dtUnit;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// Weight Unit
        /// </summary>
        /// <param name="obj"></param>
        public static void Set_DropBox_For_WeightUnit(DevExpress.XtraEditors.LookUpEdit obj)
        {
            DataTable dtWgtUnit = new DataTable();
            dtWgtUnit = clsApp.GetDataTable(@"Select S.* FROM (SELECT '' as id ,'' as name Union All Select id, name FROM dbo.bs_unit WHERE kind='03') S ORDER BY S.id");
            obj.Properties.DataSource = dtWgtUnit;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// big class(大类),base class(中类)
        /// </summary>
        /// <param name="obj"></param>
        public static void Set_DropBox_For_BassClass(DevExpress.XtraEditors.LookUpEdit obj,string lang)
        {
            DataTable dtClass = new DataTable();
            if(lang =="2")
                dtClass = clsApp.GetDataTable(@"SELECT S.* FROM (SELECT '' AS id,'' as name,'' as parent_id UNION ALL SELECT id,english_name as name,parent_id From dbo.bs_product_type with(nolock)  WHERE state<>'2') S Order By S.id");
            else
                dtClass = clsApp.GetDataTable(@"SELECT S.* FROM (SELECT '' AS id,'' as name,'' as parent_id UNION ALL SELECT id,name,parent_id From dbo.bs_product_type with(nolock) WHERE state<>'2') S Order By S.id");
            obj.Properties.DataSource = dtClass;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// Material
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="lang"></param>
        public static void Set_DropBox_For_Material(DevExpress.XtraEditors.LookUpEdit obj, string lang)
        {
            string ls_sql = "";
            if (lang == "2")
            {
                //英文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,english_name FROM dbo.bs_mat_type with(nolock) WHERE state<>'2') S order by S.id";
            }
            else
            {
                //中文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,name FROM dbo.bs_mat_type with(nolock) WHERE state<>'2') S order by S.id";
            }             
            DataTable dtMat = new DataTable();
            dtMat = clsApp.GetDataTable(ls_sql);
            obj.Properties.DataSource = dtMat;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// Color
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="lang"></param>
        public static void Set_DropBox_For_Color(DevExpress.XtraEditors.LookUpEdit obj, string lang)
        {
            string ls_sql = "";
            if (lang == "2")
            {
                //英文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,english_name FROM dbo.bs_color with(nolock) WHERE state<>'2') S order by S.id";
            }
            else
            {
                //中文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,name FROM dbo.bs_color with(nolock) WHERE state<>'2') S order by S.id";
            }
            DataTable dtColor = new DataTable();
            dtColor = clsApp.GetDataTable(ls_sql);
            obj.Properties.DataSource = dtColor;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// Size
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="lang"></param>
        public static void Set_DropBox_For_Size(DevExpress.XtraEditors.LookUpEdit obj, string lang)
        {
            string ls_sql = "";
            if (lang == "2")
            {
                //英文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,english_name FROM dbo.bs_size with(nolock) WHERE state<>'2') S order by S.id";
            }
            else
            {
                //中文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,name FROM dbo.bs_size with(nolock) WHERE state<>'2') S order by S.id";
            }
            DataTable dtSize = new DataTable();
            dtSize = clsApp.GetDataTable(ls_sql);
            obj.Properties.DataSource = dtSize;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }
        
        /// <summary>
        /// Customer
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="lang"></param>
        public static void Set_DropBox_For_Customer(DevExpress.XtraEditors.LookUpEdit obj, string lang)
        {
            string ls_sql = "";
            if (lang == "2")
            {
                //英文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,english_name FROM dbo.bs_customer with(nolock) WHERE state<>'2') S order by S.id";
            }
            else
            {
                //中文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,name FROM dbo.bs_customer with(nolock) WHERE state<>'2') S order by S.id";
            }
            DataTable dtCust = new DataTable();
            dtCust = clsApp.GetDataTable(ls_sql);
            obj.Properties.DataSource = dtCust;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// 产品特性(光身或有LOGO)
        /// </summary>
        /// <param name="obj"></param>
        /// <param name="lang"></param>
        public static void Set_DropBox_For_Attribute(DevExpress.XtraEditors.LookUpEdit obj, string lang)
        {
            string ls_sql = "";
            if (lang == "2")
            {
                //英文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,english_name FROM dbo.cd_production) S order by S.id";
            }
            else
            {
                //中文描述
                ls_sql = @"SELECT S.* FROM (Select '' as id,'' as name Union ALL SELECT id,name FROM dbo.cd_production) S order by S.id";
            }
            DataTable dtLogo = new DataTable();
            dtLogo = clsApp.GetDataTable(ls_sql);
            obj.Properties.DataSource = dtLogo;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }


        public static bool Check_IsExists_ArtWork(string artwork)
        {
            bool result = false ;
            if(!string.IsNullOrEmpty(clsApp.ExecuteSqlReturnObject(string.Format("select '1' from cd_pattern with(nolock) where id='{0}'",artwork))))
                result = true ;
            else
                result = false ;
            return result;
        }

        /// <summary>
        /// 取貨品描述
        /// </summary>
        /// <param name="mat"></param>
        /// <param name="product_type"></param>
        /// <param name="artwork"></param>
        /// <param name="size"></param>
        /// <param name="color"></param>
        /// <param name="type">1--中文，2--英文</param>
        /// <returns></returns>
        public static string Get_Goods_Desc(string mat, string product_type, string artwork, string size, string color, string type)
        {
            string ls_result = "",ls_desc_or_edesc="";           
            if (mat != "")
            {
                ls_desc_or_edesc = type == "1" ? "name" : "english_name";
                ls_result += clsApp.ExecuteSqlReturnObject(string.Format("select {0} from bs_mat_type with(nolock) where id='{1}'", ls_desc_or_edesc, mat));
            }
            else
            {
                ls_result += "";
            }
            if (product_type != "")
            {
                ls_desc_or_edesc = type == "1" ? "name" : "english_name";
                ls_result += "," + clsApp.ExecuteSqlReturnObject(string.Format("select {0} from bs_product_type with(nolock) where id='{1}'", ls_desc_or_edesc, product_type));
            }
            else
            {
                ls_result += "," + "";
            }
            ls_result += "," + artwork;
            if (size != "")
            {
                ls_desc_or_edesc = type == "1" ? "name" : "english_name";
                ls_result += "," + clsApp.ExecuteSqlReturnObject(string.Format("select {0} from bs_size with(nolock) where id='{1}'", ls_desc_or_edesc, size));
            }
            else
            {
                ls_result += "," + "";
            }
            if (color != "")
            {
                ls_desc_or_edesc = type == "1" ? "name" : "english_name";
                ls_result += "," + clsApp.ExecuteSqlReturnObject(string.Format("select {0} from bs_color with(nolock) where id='{1}'", ls_desc_or_edesc, color));
            }
            else
            {
                ls_result += "," + "";
            }
            
            return ls_result;
        }
        

    }
}
