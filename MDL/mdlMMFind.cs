using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cfvn.MDL
{
    public class mdlMM_Find
    {
        public string goods_id;
        public string name;
        public string english_name;
        public string color;
        public string do_color;
        public string size;
        public string unit_code;
        public string sec_unit;    
        public string modality;//管制類型
    }

    public class mdlPO_Find
    {
        public string id;
        public string order_date;
        public string vendor_id;
        public string department_id;
        public string m_id;
        public float exchange_rate;
        public string vendor_name;
        public string vendor_name_en;
        public string sequence_id;
        public string goods_id;
        public string goods_name;
        public float order_qty;
        public string unit_code;
        public float order_sec_qty;
        public string sec_unit;
        public string fact_date;
        public string sell_order;
        public string mo_id;
        public string ver;
        public float price;
        public string p_unit;
        public float aready_receipt_qty;
        public string color;
        public string basic_unit;
        
    }
}
