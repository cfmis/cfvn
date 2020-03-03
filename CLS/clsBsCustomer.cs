using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using DevExpress.XtraEditors;

namespace cfvn.CLS
{
    public static class clsBsCustomer
    {
        private static clsPublicOfVN clsApp = new clsPublicOfVN();
        public static void SetCustomerGroup(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT id,english_name as name FROM dbo.bs_customer_group order by id";
            }
            else
            {
                strsql = @"SELECT id,name FROM dbo.bs_customer_group order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";            
        }

        public static void SetCustomerType(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT id,english_name as name FROM dbo.bs_customer_type order by id";
            }
            else
            {
                strsql = @"SELECT id,name FROM dbo.bs_customer_type order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// Set Area
        /// </summary>
        /// <param name="obj"></param>
        public static void SetCustomerArea(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT id,english_name as name FROM dbo.bs_zone Where state='0' order by id";
            }
            else
            {
                strsql = @"SELECT id,name FROM dbo.bs_zone Where state='0' order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        public static void SetPort(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT id,english_name as name FROM dbo.bs_port order by id";
            }
            else
            {
                strsql = @"SELECT id,name FROM dbo.bs_port order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        public static void SetCountry(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT id,english_name as name FROM dbo.bs_country order by id";
            }
            else
            {
                strsql = @"SELECT id,name FROM dbo.bs_country order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        public static void SetTransportMode(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,english_name FROM dbo.bs_shipping_mode order by id";
            }
            else
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,name FROM dbo.bs_shipping_mode order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        //dbo.bs_sales
        public static void SetSales(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,english_name FROM dbo.bs_sales order by id";
            }
            else
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,name FROM dbo.bs_sales order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        public static void SetMoney(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT id,english_name FROM dbo.bs_money order by id";
            }
            else
            {
                strsql = @"SELECT id,name FROM dbo.bs_money order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }        

        /// <summary>
        /// Cancel reseaon
        /// </summary>
        /// <param name="obj"></param>
        public static void SetCancelState(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,english_name FROM dbo.bs_type Where group_id='6' order by id";
            }
            else
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,name FROM dbo.bs_type Where group_id='6' order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// Customer status
        /// </summary>
        /// <param name="obj"></param>
        public static void SetCustomerState(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,english_name FROM dbo.bs_type Where group_id='Y' order by id";
            }
            else
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,name FROM dbo.bs_type Where group_id='Y' order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        

        //*****************
        //**VENDOR** 
        //*****************  
        /// <summary>
        /// Vendor group
        /// </summary>
        /// <param name="obj"></param>
        public static void SetVendorGroup(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT id,english_name as name FROM dbo.bs_vendor_group WHERE state='0' order by id";
            }
            else
            {
                strsql = @"SELECT id,name FROM dbo.bs_vendor_group WHERE state='0' order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// Vendor type
        /// </summary>
        /// <param name="obj"></param>
        public static void SetVendorType(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT id,english_name as name FROM dbo.bs_vendor_type WHERE state='0' order by id";
            }
            else
            {
                strsql = @"SELECT id,name FROM dbo.bs_vendor_type WHERE state='0' order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// payment mode
        /// </summary>
        /// <param name="obj"></param>
        public static void SetPayment(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,english_name FROM dbo.bs_payment Where state='0' order by id";
            }
            else
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,name FROM dbo.bs_payment Where state='0' order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// payment method
        /// </summary>
        /// <param name="obj"></param>
        public static void SetPaymentMothod(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,english_name FROM dbo.bs_payment_method Where state='0' order by id";
            }
            else
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,name FROM dbo.bs_payment_method Where state='0' order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

        /// <summary>
        /// price condition
        /// </summary>
        /// <param name="obj"></param>
        public static void SetPriceCondition(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,english_name FROM dbo.bs_payment_condition Where state='0' order by id";
            }
            else
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,name FROM dbo.bs_payment_condition Where state='0' order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }
       
        /// <summary>
        /// tax
        /// </summary>
        /// <param name="obj"></param>
        public static void SetTax(LookUpEdit obj)
        {
            string strsql;
            if (DBUtility._language == "2")
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,english_name FROM dbo.bs_tax_kind Where state='0' order by id";
            }
            else
            {
                strsql = @"SELECT '' as id,'' as name UNION SELECT id,name FROM dbo.bs_tax_kind Where state='0' order by id";
            }
            DataTable dt = clsApp.GetDataTable(strsql);
            obj.Properties.DataSource = dt;
            obj.Properties.ValueMember = "id";
            obj.Properties.DisplayMember = "name";
        }

    }
}
