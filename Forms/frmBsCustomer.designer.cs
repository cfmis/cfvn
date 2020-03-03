namespace cfvn.Forms
{
    partial class frmBsCustomer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logogram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english_logogram = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sort_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.area = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postalcode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p_code = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transport_mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.homepage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_linkman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.a_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seller_id_1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seller_id_2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seller_id_3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel_reason_type_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cancel_reason_type_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.character = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.action_state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkup_hint = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_print_logo = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.shipment_linkman = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_comments = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_s_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shipment_e_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblshipment_email = new System.Windows.Forms.Label();
            this.lblshipment_e_address = new System.Windows.Forms.Label();
            this.txtshipment_e_address = new DevExpress.XtraEditors.MemoEdit();
            this.txtshipment_s_address = new DevExpress.XtraEditors.MemoEdit();
            this.txtshipment_email = new DevExpress.XtraEditors.TextEdit();
            this.lblshipment_s_address = new System.Windows.Forms.Label();
            this.txtshipment_comments = new DevExpress.XtraEditors.TextEdit();
            this.lblshipment_comments = new System.Windows.Forms.Label();
            this.txtshipment_fax = new DevExpress.XtraEditors.TextEdit();
            this.lbltxtshipment_fax = new System.Windows.Forms.Label();
            this.txtshipment_phone = new DevExpress.XtraEditors.TextEdit();
            this.lblshipment_phone = new System.Windows.Forms.Label();
            this.txtshipment_linkman = new DevExpress.XtraEditors.TextEdit();
            this.lblshipment_linkman = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lineX1 = new cfvn.ModuleClass.LineX();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblcheckup_hint = new System.Windows.Forms.Label();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.lblmoney_id = new System.Windows.Forms.Label();
            this.txtcheckup_hint = new DevExpress.XtraEditors.TextEdit();
            this.lblaction_state = new System.Windows.Forms.Label();
            this.luemoney_id = new DevExpress.XtraEditors.LookUpEdit();
            this.lueaction_state = new DevExpress.XtraEditors.LookUpEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.chkis_print_logo = new DevExpress.XtraEditors.CheckEdit();
            this.txtcharacter = new DevExpress.XtraEditors.TextEdit();
            this.lblis_print_logo = new System.Windows.Forms.Label();
            this.lueseller_id_3 = new DevExpress.XtraEditors.LookUpEdit();
            this.lblcharacter = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcancel_reason_type_name = new DevExpress.XtraEditors.TextEdit();
            this.lueseller_id_2 = new DevExpress.XtraEditors.LookUpEdit();
            this.lblcancel_reason_type_id = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lueseller_id_1 = new DevExpress.XtraEditors.LookUpEdit();
            this.luecancel_reason_type_id = new DevExpress.XtraEditors.LookUpEdit();
            this.txtemail = new DevExpress.XtraEditors.TextEdit();
            this.lblemail = new System.Windows.Forms.Label();
            this.txta_phone = new DevExpress.XtraEditors.TextEdit();
            this.lbla_phone = new System.Windows.Forms.Label();
            this.txta_linkman = new DevExpress.XtraEditors.TextEdit();
            this.lbltxta_linkman = new System.Windows.Forms.Label();
            this.txtfax = new DevExpress.XtraEditors.TextEdit();
            this.lblfax = new System.Windows.Forms.Label();
            this.txtphone = new DevExpress.XtraEditors.TextEdit();
            this.lblphone = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lbltransport_mode = new System.Windows.Forms.Label();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.luetransport_mode = new DevExpress.XtraEditors.LookUpEdit();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.lblp_code = new System.Windows.Forms.Label();
            this.lblCdesc = new System.Windows.Forms.Label();
            this.luep_code = new DevExpress.XtraEditors.LookUpEdit();
            this.txtenglish_name = new DevExpress.XtraEditors.TextEdit();
            this.lblhomepage = new System.Windows.Forms.Label();
            this.lblEdesc = new System.Windows.Forms.Label();
            this.txthomepage = new DevExpress.XtraEditors.TextEdit();
            this.luecustomer_group = new DevExpress.XtraEditors.LookUpEdit();
            this.lblt_postalcode = new System.Windows.Forms.Label();
            this.lblcustomer_group = new System.Windows.Forms.Label();
            this.txtpostalcode = new DevExpress.XtraEditors.TextEdit();
            this.t_state = new System.Windows.Forms.Label();
            this.lblc_code = new System.Windows.Forms.Label();
            this.luestate = new DevExpress.XtraEditors.LookUpEdit();
            this.luec_code = new DevExpress.XtraEditors.LookUpEdit();
            this.luetype = new DevExpress.XtraEditors.LookUpEdit();
            this.lbltxtenglish_logogram = new System.Windows.Forms.Label();
            this.lbltype = new System.Windows.Forms.Label();
            this.txtenglish_logogram = new DevExpress.XtraEditors.TextEdit();
            this.txtparent_id = new DevExpress.XtraEditors.TextEdit();
            this.lblarea = new System.Windows.Forms.Label();
            this.lblparent_id = new System.Windows.Forms.Label();
            this.luearea = new DevExpress.XtraEditors.LookUpEdit();
            this.txtsort_id = new DevExpress.XtraEditors.TextEdit();
            this.lbllogogram = new System.Windows.Forms.Label();
            this.lblsort_id = new System.Windows.Forms.Label();
            this.txtlogogram = new DevExpress.XtraEditors.TextEdit();
            this.txtcreate_by = new DevExpress.XtraEditors.TextEdit();
            this.lblAmtim = new System.Windows.Forms.Label();
            this.lblCrusr = new System.Windows.Forms.Label();
            this.txtcreate_date = new DevExpress.XtraEditors.TextEdit();
            this.lblAmusr = new System.Windows.Forms.Label();
            this.txtupdate_date = new DevExpress.XtraEditors.TextEdit();
            this.txtupdate_by = new DevExpress.XtraEditors.TextEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNEXIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNNEW = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNEDIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNSAVE = new System.Windows.Forms.ToolStripButton();
            this.BTNCANCEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNCONFIRM = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNACTION = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNDELETE = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNFIND = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNPRINT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.bds1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcust_name = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.txtcust2 = new DevExpress.XtraEditors.TextEdit();
            this.txtcust1 = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_e_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_s_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_email.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_comments.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_fax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_linkman.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcheckup_hint.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luemoney_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueaction_state.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkis_print_logo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcharacter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueseller_id_3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcancel_reason_type_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueseller_id_2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueseller_id_1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luecancel_reason_type_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txta_phone.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txta_linkman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphone.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetransport_mode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luep_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthomepage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luecustomer_group.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpostalcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luec_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_logogram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtparent_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luearea.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsort_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlogogram.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtcust_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcust2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcust1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetails.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetails.ColumnHeadersHeight = 40;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.english_name,
            this.customer_group,
            this.type,
            this.parent_id,
            this.logogram,
            this.english_logogram,
            this.sort_id,
            this.area,
            this.postalcode,
            this.c_code,
            this.p_code,
            this.transport_mode,
            this.homepage,
            this.phone,
            this.fax,
            this.a_linkman,
            this.a_phone,
            this.email,
            this.seller_id_1,
            this.seller_id_2,
            this.seller_id_3,
            this.money_id,
            this.cancel_reason_type_id,
            this.cancel_reason_type_name,
            this.character,
            this.action_state,
            this.checkup_hint,
            this.remark,
            this.is_print_logo,
            this.shipment_linkman,
            this.shipment_phone,
            this.shipment_fax,
            this.shipment_email,
            this.shipment_comments,
            this.shipment_s_address,
            this.shipment_e_address,
            this.state,
            this.create_by,
            this.create_date,
            this.update_by,
            this.update_date});
            this.dgvDetails.Location = new System.Drawing.Point(3, 531);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.ShowCellToolTips = false;
            this.dgvDetails.Size = new System.Drawing.Size(998, 150);
            this.dgvDetails.TabIndex = 9;
            this.dgvDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDetails_RowPostPaint);
            this.dgvDetails.SelectionChanged += new System.EventHandler(this.dgvDetails_SelectionChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "編號";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ToolTipText = "t_id";
            this.id.Width = 60;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "中文名稱";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.ToolTipText = "t_name";
            this.name.Width = 130;
            // 
            // english_name
            // 
            this.english_name.DataPropertyName = "english_name";
            this.english_name.HeaderText = "英文名稱";
            this.english_name.Name = "english_name";
            this.english_name.ReadOnly = true;
            this.english_name.ToolTipText = "t_english_name";
            this.english_name.Width = 130;
            // 
            // customer_group
            // 
            this.customer_group.DataPropertyName = "customer_group";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.customer_group.DefaultCellStyle = dataGridViewCellStyle1;
            this.customer_group.HeaderText = "客戶組別";
            this.customer_group.Name = "customer_group";
            this.customer_group.ReadOnly = true;
            this.customer_group.ToolTipText = "t_customer_group";
            this.customer_group.Width = 60;
            // 
            // type
            // 
            this.type.DataPropertyName = "type";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.type.DefaultCellStyle = dataGridViewCellStyle2;
            this.type.HeaderText = "客戶類型";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.ToolTipText = "t_cust_type";
            this.type.Width = 60;
            // 
            // parent_id
            // 
            this.parent_id.DataPropertyName = "parent_id";
            this.parent_id.HeaderText = "上級客戶";
            this.parent_id.Name = "parent_id";
            this.parent_id.ReadOnly = true;
            this.parent_id.ToolTipText = "t_parent_cust";
            // 
            // logogram
            // 
            this.logogram.DataPropertyName = "logogram";
            this.logogram.HeaderText = "簡稱";
            this.logogram.Name = "logogram";
            this.logogram.ReadOnly = true;
            this.logogram.ToolTipText = "t_logogram";
            // 
            // english_logogram
            // 
            this.english_logogram.DataPropertyName = "english_logogram";
            this.english_logogram.HeaderText = "簡稱(英文)";
            this.english_logogram.Name = "english_logogram";
            this.english_logogram.ReadOnly = true;
            this.english_logogram.ToolTipText = "t_english_logogram";
            // 
            // sort_id
            // 
            this.sort_id.DataPropertyName = "sort_id";
            this.sort_id.HeaderText = "最終客戶";
            this.sort_id.Name = "sort_id";
            this.sort_id.ReadOnly = true;
            this.sort_id.ToolTipText = "t_sort_id";
            this.sort_id.Width = 80;
            // 
            // area
            // 
            this.area.DataPropertyName = "area";
            this.area.HeaderText = "區域";
            this.area.Name = "area";
            this.area.ReadOnly = true;
            this.area.ToolTipText = "t_area";
            this.area.Width = 80;
            // 
            // postalcode
            // 
            this.postalcode.DataPropertyName = "postalcode";
            this.postalcode.HeaderText = "郵政編號";
            this.postalcode.Name = "postalcode";
            this.postalcode.ReadOnly = true;
            this.postalcode.ToolTipText = "t_postalcode";
            // 
            // c_code
            // 
            this.c_code.DataPropertyName = "c_code";
            this.c_code.HeaderText = "國家編碼";
            this.c_code.Name = "c_code";
            this.c_code.ReadOnly = true;
            this.c_code.ToolTipText = "t_country_id";
            // 
            // p_code
            // 
            this.p_code.DataPropertyName = "p_code";
            this.p_code.HeaderText = "港口";
            this.p_code.Name = "p_code";
            this.p_code.ReadOnly = true;
            this.p_code.ToolTipText = "t_port";
            // 
            // transport_mode
            // 
            this.transport_mode.DataPropertyName = "transport_mode";
            this.transport_mode.HeaderText = "船運方式";
            this.transport_mode.Name = "transport_mode";
            this.transport_mode.ReadOnly = true;
            this.transport_mode.ToolTipText = "t_transport_mode";
            // 
            // homepage
            // 
            this.homepage.DataPropertyName = "homepage";
            this.homepage.HeaderText = "網址";
            this.homepage.Name = "homepage";
            this.homepage.ReadOnly = true;
            this.homepage.ToolTipText = "t_homepage";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "電話";
            this.phone.Name = "phone";
            this.phone.ReadOnly = true;
            this.phone.ToolTipText = "t_tel";
            // 
            // fax
            // 
            this.fax.DataPropertyName = "fax";
            this.fax.HeaderText = "傳真";
            this.fax.Name = "fax";
            this.fax.ReadOnly = true;
            this.fax.ToolTipText = "t_fax";
            // 
            // a_linkman
            // 
            this.a_linkman.DataPropertyName = "a_linkman";
            this.a_linkman.HeaderText = "會計聯系人";
            this.a_linkman.Name = "a_linkman";
            this.a_linkman.ReadOnly = true;
            this.a_linkman.ToolTipText = "t_ac_linkman";
            // 
            // a_phone
            // 
            this.a_phone.DataPropertyName = "a_phone";
            this.a_phone.HeaderText = "會計電話";
            this.a_phone.Name = "a_phone";
            this.a_phone.ReadOnly = true;
            this.a_phone.ToolTipText = "t_a_phone";
            // 
            // email
            // 
            this.email.DataPropertyName = "email";
            this.email.HeaderText = "電郵";
            this.email.Name = "email";
            this.email.ReadOnly = true;
            this.email.ToolTipText = "t_email";
            // 
            // seller_id_1
            // 
            this.seller_id_1.DataPropertyName = "seller_id_1";
            this.seller_id_1.HeaderText = "銷售員";
            this.seller_id_1.Name = "seller_id_1";
            this.seller_id_1.ReadOnly = true;
            this.seller_id_1.ToolTipText = "t_seller_id";
            // 
            // seller_id_2
            // 
            this.seller_id_2.DataPropertyName = "seller_id_2";
            this.seller_id_2.HeaderText = "銷售員(二)";
            this.seller_id_2.Name = "seller_id_2";
            this.seller_id_2.ReadOnly = true;
            this.seller_id_2.ToolTipText = "t_seller_id2";
            // 
            // seller_id_3
            // 
            this.seller_id_3.DataPropertyName = "seller_id_3";
            this.seller_id_3.HeaderText = "銷售員(三)";
            this.seller_id_3.Name = "seller_id_3";
            this.seller_id_3.ReadOnly = true;
            this.seller_id_3.ToolTipText = "t_seller_id3";
            // 
            // money_id
            // 
            this.money_id.DataPropertyName = "money_id";
            this.money_id.HeaderText = "貨幣編號";
            this.money_id.Name = "money_id";
            this.money_id.ReadOnly = true;
            this.money_id.ToolTipText = "t_money_id";
            // 
            // cancel_reason_type_id
            // 
            this.cancel_reason_type_id.DataPropertyName = "cancel_reason_type_id";
            this.cancel_reason_type_id.HeaderText = "取消原因分類";
            this.cancel_reason_type_id.Name = "cancel_reason_type_id";
            this.cancel_reason_type_id.ReadOnly = true;
            this.cancel_reason_type_id.ToolTipText = "t_cancel_reason_type_id";
            // 
            // cancel_reason_type_name
            // 
            this.cancel_reason_type_name.DataPropertyName = "cancel_reason_type_name";
            this.cancel_reason_type_name.HeaderText = "原因分類描述";
            this.cancel_reason_type_name.Name = "cancel_reason_type_name";
            this.cancel_reason_type_name.ReadOnly = true;
            this.cancel_reason_type_name.ToolTipText = "t_cancel_reason_type_name";
            // 
            // character
            // 
            this.character.DataPropertyName = "character";
            this.character.HeaderText = "物懲資料";
            this.character.Name = "character";
            this.character.ReadOnly = true;
            this.character.ToolTipText = "t_character";
            // 
            // action_state
            // 
            this.action_state.DataPropertyName = "action_state";
            this.action_state.HeaderText = "客戶狀態";
            this.action_state.Name = "action_state";
            this.action_state.ReadOnly = true;
            this.action_state.ToolTipText = "t_action_state";
            // 
            // checkup_hint
            // 
            this.checkup_hint.DataPropertyName = "checkup_hint";
            this.checkup_hint.HeaderText = "客戶審核提示";
            this.checkup_hint.Name = "checkup_hint";
            this.checkup_hint.ReadOnly = true;
            this.checkup_hint.ToolTipText = "t_checkup_hint";
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "客戶備註";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.ToolTipText = "t_cust_remark";
            // 
            // is_print_logo
            // 
            this.is_print_logo.DataPropertyName = "is_print_logo";
            this.is_print_logo.HeaderText = "列印公司LOGO";
            this.is_print_logo.Name = "is_print_logo";
            this.is_print_logo.ReadOnly = true;
            this.is_print_logo.ToolTipText = "t_is_print_logo";
            this.is_print_logo.Width = 110;
            // 
            // shipment_linkman
            // 
            this.shipment_linkman.DataPropertyName = "shipment_linkman";
            this.shipment_linkman.HeaderText = "聯系人";
            this.shipment_linkman.Name = "shipment_linkman";
            this.shipment_linkman.ReadOnly = true;
            this.shipment_linkman.ToolTipText = "t_contact";
            // 
            // shipment_phone
            // 
            this.shipment_phone.DataPropertyName = "shipment_phone";
            this.shipment_phone.HeaderText = "電話";
            this.shipment_phone.Name = "shipment_phone";
            this.shipment_phone.ReadOnly = true;
            this.shipment_phone.ToolTipText = "t_tel";
            // 
            // shipment_fax
            // 
            this.shipment_fax.DataPropertyName = "shipment_fax";
            this.shipment_fax.HeaderText = "傳真";
            this.shipment_fax.Name = "shipment_fax";
            this.shipment_fax.ReadOnly = true;
            this.shipment_fax.ToolTipText = "t_fax";
            // 
            // shipment_email
            // 
            this.shipment_email.DataPropertyName = "shipment_email";
            this.shipment_email.HeaderText = "電郵地址";
            this.shipment_email.Name = "shipment_email";
            this.shipment_email.ReadOnly = true;
            this.shipment_email.ToolTipText = "t_email";
            // 
            // shipment_comments
            // 
            this.shipment_comments.DataPropertyName = "shipment_comments";
            this.shipment_comments.HeaderText = "公司名稱";
            this.shipment_comments.Name = "shipment_comments";
            this.shipment_comments.ReadOnly = true;
            this.shipment_comments.ToolTipText = "t_company";
            // 
            // shipment_s_address
            // 
            this.shipment_s_address.DataPropertyName = "shipment_s_address";
            this.shipment_s_address.HeaderText = "送貨地址";
            this.shipment_s_address.Name = "shipment_s_address";
            this.shipment_s_address.ReadOnly = true;
            this.shipment_s_address.ToolTipText = "t_shipment_s_address";
            // 
            // shipment_e_address
            // 
            this.shipment_e_address.DataPropertyName = "shipment_e_address";
            this.shipment_e_address.HeaderText = "送貨地址(英文)";
            this.shipment_e_address.Name = "shipment_e_address";
            this.shipment_e_address.ReadOnly = true;
            this.shipment_e_address.ToolTipText = "t_shipment_e_address";
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "state";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Visible = false;
            // 
            // create_by
            // 
            this.create_by.DataPropertyName = "create_by";
            this.create_by.HeaderText = "create_by";
            this.create_by.Name = "create_by";
            this.create_by.ReadOnly = true;
            this.create_by.Visible = false;
            // 
            // create_date
            // 
            this.create_date.DataPropertyName = "create_date";
            this.create_date.HeaderText = "create_date";
            this.create_date.Name = "create_date";
            this.create_date.ReadOnly = true;
            this.create_date.Visible = false;
            // 
            // update_by
            // 
            this.update_by.DataPropertyName = "update_by";
            this.update_by.HeaderText = "update_by";
            this.update_by.Name = "update_by";
            this.update_by.ReadOnly = true;
            this.update_by.Visible = false;
            // 
            // update_date
            // 
            this.update_date.DataPropertyName = "update_date";
            this.update_date.HeaderText = "update_date";
            this.update_date.Name = "update_date";
            this.update_date.ReadOnly = true;
            this.update_date.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.txtcreate_by);
            this.panel1.Controls.Add(this.lblAmtim);
            this.panel1.Controls.Add(this.lblCrusr);
            this.panel1.Controls.Add(this.txtcreate_date);
            this.panel1.Controls.Add(this.lblAmusr);
            this.panel1.Controls.Add(this.txtupdate_date);
            this.panel1.Controls.Add(this.txtupdate_by);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1001, 527);
            this.panel1.TabIndex = 11;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblshipment_email);
            this.groupBox4.Controls.Add(this.lblshipment_e_address);
            this.groupBox4.Controls.Add(this.txtshipment_e_address);
            this.groupBox4.Controls.Add(this.txtshipment_s_address);
            this.groupBox4.Controls.Add(this.txtshipment_email);
            this.groupBox4.Controls.Add(this.lblshipment_s_address);
            this.groupBox4.Controls.Add(this.txtshipment_comments);
            this.groupBox4.Controls.Add(this.lblshipment_comments);
            this.groupBox4.Controls.Add(this.txtshipment_fax);
            this.groupBox4.Controls.Add(this.lbltxtshipment_fax);
            this.groupBox4.Controls.Add(this.txtshipment_phone);
            this.groupBox4.Controls.Add(this.lblshipment_phone);
            this.groupBox4.Controls.Add(this.txtshipment_linkman);
            this.groupBox4.Controls.Add(this.lblshipment_linkman);
            this.groupBox4.Location = new System.Drawing.Point(3, 351);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(994, 145);
            this.groupBox4.TabIndex = 226;
            this.groupBox4.TabStop = false;
            this.groupBox4.Tag = "t_delivery_address";
            this.groupBox4.Text = "送貨地址";
            // 
            // lblshipment_email
            // 
            this.lblshipment_email.Location = new System.Drawing.Point(588, 42);
            this.lblshipment_email.Name = "lblshipment_email";
            this.lblshipment_email.Size = new System.Drawing.Size(81, 14);
            this.lblshipment_email.TabIndex = 224;
            this.lblshipment_email.Tag = "t_email";
            this.lblshipment_email.Text = "電郵地址";
            this.lblshipment_email.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblshipment_e_address
            // 
            this.lblshipment_e_address.Location = new System.Drawing.Point(6, 104);
            this.lblshipment_e_address.Name = "lblshipment_e_address";
            this.lblshipment_e_address.Size = new System.Drawing.Size(81, 13);
            this.lblshipment_e_address.TabIndex = 223;
            this.lblshipment_e_address.Tag = "t_shipment_e_address";
            this.lblshipment_e_address.Text = "英文地址";
            this.lblshipment_e_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtshipment_e_address
            // 
            this.txtshipment_e_address.EnterMoveNextControl = true;
            this.txtshipment_e_address.Location = new System.Drawing.Point(89, 101);
            this.txtshipment_e_address.Name = "txtshipment_e_address";
            this.txtshipment_e_address.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtshipment_e_address.Properties.MaxLength = 255;
            this.txtshipment_e_address.Properties.ReadOnly = true;
            this.txtshipment_e_address.Size = new System.Drawing.Size(898, 37);
            this.txtshipment_e_address.TabIndex = 6;
            this.txtshipment_e_address.Tag = "2";
            // 
            // txtshipment_s_address
            // 
            this.txtshipment_s_address.EnterMoveNextControl = true;
            this.txtshipment_s_address.Location = new System.Drawing.Point(89, 62);
            this.txtshipment_s_address.Name = "txtshipment_s_address";
            this.txtshipment_s_address.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtshipment_s_address.Properties.MaxLength = 255;
            this.txtshipment_s_address.Properties.ReadOnly = true;
            this.txtshipment_s_address.Size = new System.Drawing.Size(898, 37);
            this.txtshipment_s_address.TabIndex = 5;
            this.txtshipment_s_address.Tag = "2";
            // 
            // txtshipment_email
            // 
            this.txtshipment_email.EnterMoveNextControl = true;
            this.txtshipment_email.Location = new System.Drawing.Point(670, 38);
            this.txtshipment_email.Name = "txtshipment_email";
            this.txtshipment_email.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtshipment_email.Properties.ReadOnly = true;
            this.txtshipment_email.Size = new System.Drawing.Size(318, 22);
            this.txtshipment_email.TabIndex = 4;
            this.txtshipment_email.Tag = "2";
            // 
            // lblshipment_s_address
            // 
            this.lblshipment_s_address.Location = new System.Drawing.Point(7, 65);
            this.lblshipment_s_address.Name = "lblshipment_s_address";
            this.lblshipment_s_address.Size = new System.Drawing.Size(81, 13);
            this.lblshipment_s_address.TabIndex = 220;
            this.lblshipment_s_address.Tag = "t_shipment_s_address";
            this.lblshipment_s_address.Text = "送貨地址";
            this.lblshipment_s_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtshipment_comments
            // 
            this.txtshipment_comments.EnterMoveNextControl = true;
            this.txtshipment_comments.Location = new System.Drawing.Point(89, 38);
            this.txtshipment_comments.Name = "txtshipment_comments";
            this.txtshipment_comments.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtshipment_comments.Properties.ReadOnly = true;
            this.txtshipment_comments.Size = new System.Drawing.Size(436, 22);
            this.txtshipment_comments.TabIndex = 3;
            this.txtshipment_comments.Tag = "2";
            // 
            // lblshipment_comments
            // 
            this.lblshipment_comments.Location = new System.Drawing.Point(7, 40);
            this.lblshipment_comments.Name = "lblshipment_comments";
            this.lblshipment_comments.Size = new System.Drawing.Size(81, 13);
            this.lblshipment_comments.TabIndex = 218;
            this.lblshipment_comments.Tag = "t_company";
            this.lblshipment_comments.Text = "公司名稱";
            this.lblshipment_comments.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtshipment_fax
            // 
            this.txtshipment_fax.EnterMoveNextControl = true;
            this.txtshipment_fax.Location = new System.Drawing.Point(670, 13);
            this.txtshipment_fax.Name = "txtshipment_fax";
            this.txtshipment_fax.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtshipment_fax.Properties.ReadOnly = true;
            this.txtshipment_fax.Size = new System.Drawing.Size(317, 22);
            this.txtshipment_fax.TabIndex = 2;
            this.txtshipment_fax.Tag = "2";
            // 
            // lbltxtshipment_fax
            // 
            this.lbltxtshipment_fax.Location = new System.Drawing.Point(588, 17);
            this.lbltxtshipment_fax.Name = "lbltxtshipment_fax";
            this.lbltxtshipment_fax.Size = new System.Drawing.Size(81, 14);
            this.lbltxtshipment_fax.TabIndex = 216;
            this.lbltxtshipment_fax.Tag = "t_fax";
            this.lbltxtshipment_fax.Text = "傳真";
            this.lbltxtshipment_fax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtshipment_phone
            // 
            this.txtshipment_phone.EnterMoveNextControl = true;
            this.txtshipment_phone.Location = new System.Drawing.Point(300, 13);
            this.txtshipment_phone.Name = "txtshipment_phone";
            this.txtshipment_phone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtshipment_phone.Properties.ReadOnly = true;
            this.txtshipment_phone.Size = new System.Drawing.Size(225, 22);
            this.txtshipment_phone.TabIndex = 1;
            this.txtshipment_phone.Tag = "2";
            // 
            // lblshipment_phone
            // 
            this.lblshipment_phone.Location = new System.Drawing.Point(218, 17);
            this.lblshipment_phone.Name = "lblshipment_phone";
            this.lblshipment_phone.Size = new System.Drawing.Size(81, 14);
            this.lblshipment_phone.TabIndex = 214;
            this.lblshipment_phone.Tag = "t_tel";
            this.lblshipment_phone.Text = "電話";
            this.lblshipment_phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtshipment_linkman
            // 
            this.txtshipment_linkman.EnterMoveNextControl = true;
            this.txtshipment_linkman.Location = new System.Drawing.Point(89, 13);
            this.txtshipment_linkman.Name = "txtshipment_linkman";
            this.txtshipment_linkman.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtshipment_linkman.Properties.ReadOnly = true;
            this.txtshipment_linkman.Size = new System.Drawing.Size(124, 22);
            this.txtshipment_linkman.TabIndex = 0;
            this.txtshipment_linkman.Tag = "2";
            // 
            // lblshipment_linkman
            // 
            this.lblshipment_linkman.Location = new System.Drawing.Point(3, 17);
            this.lblshipment_linkman.Name = "lblshipment_linkman";
            this.lblshipment_linkman.Size = new System.Drawing.Size(83, 14);
            this.lblshipment_linkman.TabIndex = 212;
            this.lblshipment_linkman.Tag = "t_contact";
            this.lblshipment_linkman.Text = "聯系人";
            this.lblshipment_linkman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lineX1);
            this.groupBox2.Controls.Add(this.lblRemark);
            this.groupBox2.Controls.Add(this.lblcheckup_hint);
            this.groupBox2.Controls.Add(this.txtRemark);
            this.groupBox2.Controls.Add(this.lblmoney_id);
            this.groupBox2.Controls.Add(this.txtcheckup_hint);
            this.groupBox2.Controls.Add(this.lblaction_state);
            this.groupBox2.Controls.Add(this.luemoney_id);
            this.groupBox2.Controls.Add(this.lueaction_state);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkis_print_logo);
            this.groupBox2.Controls.Add(this.txtcharacter);
            this.groupBox2.Controls.Add(this.lblis_print_logo);
            this.groupBox2.Controls.Add(this.lueseller_id_3);
            this.groupBox2.Controls.Add(this.lblcharacter);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtcancel_reason_type_name);
            this.groupBox2.Controls.Add(this.lueseller_id_2);
            this.groupBox2.Controls.Add(this.lblcancel_reason_type_id);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.lueseller_id_1);
            this.groupBox2.Controls.Add(this.luecancel_reason_type_id);
            this.groupBox2.Controls.Add(this.txtemail);
            this.groupBox2.Controls.Add(this.lblemail);
            this.groupBox2.Controls.Add(this.txta_phone);
            this.groupBox2.Controls.Add(this.lbla_phone);
            this.groupBox2.Controls.Add(this.txta_linkman);
            this.groupBox2.Controls.Add(this.lbltxta_linkman);
            this.groupBox2.Controls.Add(this.txtfax);
            this.groupBox2.Controls.Add(this.lblfax);
            this.groupBox2.Controls.Add(this.txtphone);
            this.groupBox2.Controls.Add(this.lblphone);
            this.groupBox2.Location = new System.Drawing.Point(3, 162);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(994, 189);
            this.groupBox2.TabIndex = 224;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "AC";
            // 
            // lineX1
            // 
            this.lineX1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lineX1.LineColor = System.Drawing.Color.White;
            this.lineX1.LineWidth = 1;
            this.lineX1.Location = new System.Drawing.Point(5, 95);
            this.lineX1.Name = "lineX1";
            this.lineX1.Size = new System.Drawing.Size(982, 1);
            this.lineX1.TabIndex = 236;
            // 
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(4, 155);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(84, 13);
            this.lblRemark.TabIndex = 7;
            this.lblRemark.Tag = "t_cust_remark";
            this.lblRemark.Text = "客戶備注";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcheckup_hint
            // 
            this.lblcheckup_hint.Location = new System.Drawing.Point(5, 132);
            this.lblcheckup_hint.Name = "lblcheckup_hint";
            this.lblcheckup_hint.Size = new System.Drawing.Size(81, 14);
            this.lblcheckup_hint.TabIndex = 235;
            this.lblcheckup_hint.Tag = "t_checkup_hint";
            this.lblcheckup_hint.Text = "客戶審核提示";
            this.lblcheckup_hint.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemark
            // 
            this.txtRemark.EnterMoveNextControl = true;
            this.txtRemark.Location = new System.Drawing.Point(89, 153);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtRemark.Properties.MaxLength = 255;
            this.txtRemark.Properties.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(898, 29);
            this.txtRemark.TabIndex = 6;
            this.txtRemark.Tag = "2";
            // 
            // lblmoney_id
            // 
            this.lblmoney_id.Location = new System.Drawing.Point(704, 67);
            this.lblmoney_id.Name = "lblmoney_id";
            this.lblmoney_id.Size = new System.Drawing.Size(81, 14);
            this.lblmoney_id.TabIndex = 228;
            this.lblmoney_id.Tag = "t_money_id";
            this.lblmoney_id.Text = "貨幣編號";
            this.lblmoney_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcheckup_hint
            // 
            this.txtcheckup_hint.EnterMoveNextControl = true;
            this.txtcheckup_hint.Location = new System.Drawing.Point(89, 129);
            this.txtcheckup_hint.Name = "txtcheckup_hint";
            this.txtcheckup_hint.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcheckup_hint.Properties.ReadOnly = true;
            this.txtcheckup_hint.Size = new System.Drawing.Size(344, 22);
            this.txtcheckup_hint.TabIndex = 3;
            this.txtcheckup_hint.Tag = "2";
            // 
            // lblaction_state
            // 
            this.lblaction_state.Location = new System.Drawing.Point(707, 132);
            this.lblaction_state.Name = "lblaction_state";
            this.lblaction_state.Size = new System.Drawing.Size(81, 14);
            this.lblaction_state.TabIndex = 230;
            this.lblaction_state.Tag = "t_action_state";
            this.lblaction_state.Text = "客戶狀態";
            this.lblaction_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // luemoney_id
            // 
            this.luemoney_id.EditValue = "";
            this.luemoney_id.Enabled = false;
            this.luemoney_id.EnterMoveNextControl = true;
            this.luemoney_id.Location = new System.Drawing.Point(788, 64);
            this.luemoney_id.Name = "luemoney_id";
            this.luemoney_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.luemoney_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luemoney_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luemoney_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luemoney_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luemoney_id.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.luemoney_id.Properties.DropDownRows = 15;
            this.luemoney_id.Properties.MaxLength = 2;
            this.luemoney_id.Properties.NullText = "";
            this.luemoney_id.Properties.PopupWidth = 130;
            this.luemoney_id.Properties.ShowHeader = false;
            this.luemoney_id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luemoney_id.Size = new System.Drawing.Size(199, 22);
            this.luemoney_id.TabIndex = 8;
            this.luemoney_id.Tag = "2";
            // 
            // lueaction_state
            // 
            this.lueaction_state.EditValue = "";
            this.lueaction_state.Enabled = false;
            this.lueaction_state.EnterMoveNextControl = true;
            this.lueaction_state.Location = new System.Drawing.Point(789, 129);
            this.lueaction_state.Name = "lueaction_state";
            this.lueaction_state.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lueaction_state.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.lueaction_state.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lueaction_state.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueaction_state.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueaction_state.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.lueaction_state.Properties.DropDownRows = 15;
            this.lueaction_state.Properties.MaxLength = 2;
            this.lueaction_state.Properties.NullText = "";
            this.lueaction_state.Properties.PopupWidth = 130;
            this.lueaction_state.Properties.ShowHeader = false;
            this.lueaction_state.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueaction_state.Size = new System.Drawing.Size(198, 22);
            this.lueaction_state.TabIndex = 2;
            this.lueaction_state.Tag = "2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(439, 67);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 14);
            this.label4.TabIndex = 226;
            this.label4.Tag = "t_seller_id3";
            this.label4.Text = "銷售員(三)";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chkis_print_logo
            // 
            this.chkis_print_logo.Enabled = false;
            this.chkis_print_logo.Location = new System.Drawing.Point(596, 131);
            this.chkis_print_logo.Name = "chkis_print_logo";
            this.chkis_print_logo.Properties.Caption = "";
            this.chkis_print_logo.Properties.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked;
            this.chkis_print_logo.Size = new System.Drawing.Size(46, 19);
            this.chkis_print_logo.TabIndex = 4;
            this.chkis_print_logo.Tag = "2";
            // 
            // txtcharacter
            // 
            this.txtcharacter.EnterMoveNextControl = true;
            this.txtcharacter.Location = new System.Drawing.Point(788, 104);
            this.txtcharacter.Name = "txtcharacter";
            this.txtcharacter.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcharacter.Properties.ReadOnly = true;
            this.txtcharacter.Size = new System.Drawing.Size(199, 22);
            this.txtcharacter.TabIndex = 5;
            this.txtcharacter.Tag = "2";
            // 
            // lblis_print_logo
            // 
            this.lblis_print_logo.Location = new System.Drawing.Point(435, 134);
            this.lblis_print_logo.Name = "lblis_print_logo";
            this.lblis_print_logo.Size = new System.Drawing.Size(149, 13);
            this.lblis_print_logo.TabIndex = 194;
            this.lblis_print_logo.Tag = "t_is_print_logo";
            this.lblis_print_logo.Text = "是否印公司LOGO";
            this.lblis_print_logo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lueseller_id_3
            // 
            this.lueseller_id_3.EditValue = "";
            this.lueseller_id_3.Enabled = false;
            this.lueseller_id_3.EnterMoveNextControl = true;
            this.lueseller_id_3.Location = new System.Drawing.Point(525, 64);
            this.lueseller_id_3.Name = "lueseller_id_3";
            this.lueseller_id_3.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lueseller_id_3.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.lueseller_id_3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lueseller_id_3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueseller_id_3.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueseller_id_3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.lueseller_id_3.Properties.DropDownRows = 15;
            this.lueseller_id_3.Properties.MaxLength = 2;
            this.lueseller_id_3.Properties.NullText = "";
            this.lueseller_id_3.Properties.PopupWidth = 130;
            this.lueseller_id_3.Properties.ShowHeader = false;
            this.lueseller_id_3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueseller_id_3.Size = new System.Drawing.Size(148, 22);
            this.lueseller_id_3.TabIndex = 7;
            this.lueseller_id_3.Tag = "2";
            // 
            // lblcharacter
            // 
            this.lblcharacter.Location = new System.Drawing.Point(698, 108);
            this.lblcharacter.Name = "lblcharacter";
            this.lblcharacter.Size = new System.Drawing.Size(87, 14);
            this.lblcharacter.TabIndex = 233;
            this.lblcharacter.Tag = "t_character";
            this.lblcharacter.Text = "特徵資料";
            this.lblcharacter.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(218, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 14);
            this.label3.TabIndex = 224;
            this.label3.Tag = "t_seller_id2";
            this.label3.Text = "銷售員(二)";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcancel_reason_type_name
            // 
            this.txtcancel_reason_type_name.EnterMoveNextControl = true;
            this.txtcancel_reason_type_name.Location = new System.Drawing.Point(300, 104);
            this.txtcancel_reason_type_name.Name = "txtcancel_reason_type_name";
            this.txtcancel_reason_type_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcancel_reason_type_name.Properties.ReadOnly = true;
            this.txtcancel_reason_type_name.Size = new System.Drawing.Size(373, 22);
            this.txtcancel_reason_type_name.TabIndex = 1;
            this.txtcancel_reason_type_name.Tag = "2";
            // 
            // lueseller_id_2
            // 
            this.lueseller_id_2.EditValue = "";
            this.lueseller_id_2.Enabled = false;
            this.lueseller_id_2.EnterMoveNextControl = true;
            this.lueseller_id_2.Location = new System.Drawing.Point(300, 64);
            this.lueseller_id_2.Name = "lueseller_id_2";
            this.lueseller_id_2.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lueseller_id_2.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.lueseller_id_2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lueseller_id_2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueseller_id_2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueseller_id_2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.lueseller_id_2.Properties.DropDownRows = 15;
            this.lueseller_id_2.Properties.MaxLength = 2;
            this.lueseller_id_2.Properties.NullText = "";
            this.lueseller_id_2.Properties.PopupWidth = 130;
            this.lueseller_id_2.Properties.ShowHeader = false;
            this.lueseller_id_2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueseller_id_2.Size = new System.Drawing.Size(133, 22);
            this.lueseller_id_2.TabIndex = 6;
            this.lueseller_id_2.Tag = "2";
            // 
            // lblcancel_reason_type_id
            // 
            this.lblcancel_reason_type_id.Location = new System.Drawing.Point(7, 107);
            this.lblcancel_reason_type_id.Name = "lblcancel_reason_type_id";
            this.lblcancel_reason_type_id.Size = new System.Drawing.Size(81, 14);
            this.lblcancel_reason_type_id.TabIndex = 230;
            this.lblcancel_reason_type_id.Tag = "t_cancel_reason_type_id";
            this.lblcancel_reason_type_id.Text = "取消原因分類";
            this.lblcancel_reason_type_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(7, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 14);
            this.label1.TabIndex = 222;
            this.label1.Tag = "t_seller_id";
            this.label1.Text = "銷售員";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lueseller_id_1
            // 
            this.lueseller_id_1.EditValue = "";
            this.lueseller_id_1.Enabled = false;
            this.lueseller_id_1.EnterMoveNextControl = true;
            this.lueseller_id_1.Location = new System.Drawing.Point(89, 64);
            this.lueseller_id_1.Name = "lueseller_id_1";
            this.lueseller_id_1.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lueseller_id_1.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.lueseller_id_1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lueseller_id_1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueseller_id_1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueseller_id_1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.lueseller_id_1.Properties.DropDownRows = 15;
            this.lueseller_id_1.Properties.MaxLength = 2;
            this.lueseller_id_1.Properties.NullText = "";
            this.lueseller_id_1.Properties.PopupWidth = 130;
            this.lueseller_id_1.Properties.ShowHeader = false;
            this.lueseller_id_1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueseller_id_1.Size = new System.Drawing.Size(124, 22);
            this.lueseller_id_1.TabIndex = 5;
            this.lueseller_id_1.Tag = "2";
            // 
            // luecancel_reason_type_id
            // 
            this.luecancel_reason_type_id.EditValue = "";
            this.luecancel_reason_type_id.Enabled = false;
            this.luecancel_reason_type_id.EnterMoveNextControl = true;
            this.luecancel_reason_type_id.Location = new System.Drawing.Point(89, 104);
            this.luecancel_reason_type_id.Name = "luecancel_reason_type_id";
            this.luecancel_reason_type_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.luecancel_reason_type_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luecancel_reason_type_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luecancel_reason_type_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luecancel_reason_type_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luecancel_reason_type_id.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.luecancel_reason_type_id.Properties.DropDownRows = 15;
            this.luecancel_reason_type_id.Properties.MaxLength = 2;
            this.luecancel_reason_type_id.Properties.NullText = "";
            this.luecancel_reason_type_id.Properties.PopupWidth = 130;
            this.luecancel_reason_type_id.Properties.ShowHeader = false;
            this.luecancel_reason_type_id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luecancel_reason_type_id.Size = new System.Drawing.Size(210, 22);
            this.luecancel_reason_type_id.TabIndex = 0;
            this.luecancel_reason_type_id.Tag = "2";
            // 
            // txtemail
            // 
            this.txtemail.EnterMoveNextControl = true;
            this.txtemail.Location = new System.Drawing.Point(525, 38);
            this.txtemail.Name = "txtemail";
            this.txtemail.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtemail.Properties.ReadOnly = true;
            this.txtemail.Size = new System.Drawing.Size(462, 22);
            this.txtemail.TabIndex = 4;
            this.txtemail.Tag = "2";
            // 
            // lblemail
            // 
            this.lblemail.Location = new System.Drawing.Point(439, 42);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(83, 14);
            this.lblemail.TabIndex = 214;
            this.lblemail.Tag = "t_email";
            this.lblemail.Text = "電郵";
            this.lblemail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txta_phone
            // 
            this.txta_phone.EnterMoveNextControl = true;
            this.txta_phone.Location = new System.Drawing.Point(788, 13);
            this.txta_phone.Name = "txta_phone";
            this.txta_phone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txta_phone.Properties.ReadOnly = true;
            this.txta_phone.Size = new System.Drawing.Size(199, 22);
            this.txta_phone.TabIndex = 2;
            this.txta_phone.Tag = "2";
            // 
            // lbla_phone
            // 
            this.lbla_phone.Location = new System.Drawing.Point(704, 17);
            this.lbla_phone.Name = "lbla_phone";
            this.lbla_phone.Size = new System.Drawing.Size(81, 14);
            this.lbla_phone.TabIndex = 212;
            this.lbla_phone.Tag = "t_a_phone";
            this.lbla_phone.Text = "會計電話";
            this.lbla_phone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txta_linkman
            // 
            this.txta_linkman.EnterMoveNextControl = true;
            this.txta_linkman.Location = new System.Drawing.Point(525, 13);
            this.txta_linkman.Name = "txta_linkman";
            this.txta_linkman.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txta_linkman.Properties.ReadOnly = true;
            this.txta_linkman.Size = new System.Drawing.Size(148, 22);
            this.txta_linkman.TabIndex = 1;
            this.txta_linkman.Tag = "2";
            // 
            // lbltxta_linkman
            // 
            this.lbltxta_linkman.Location = new System.Drawing.Point(439, 17);
            this.lbltxta_linkman.Name = "lbltxta_linkman";
            this.lbltxta_linkman.Size = new System.Drawing.Size(83, 14);
            this.lbltxta_linkman.TabIndex = 210;
            this.lbltxta_linkman.Tag = "t_ac_linkman";
            this.lbltxta_linkman.Text = "會計聯系人";
            this.lbltxta_linkman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtfax
            // 
            this.txtfax.EnterMoveNextControl = true;
            this.txtfax.Location = new System.Drawing.Point(89, 38);
            this.txtfax.Name = "txtfax";
            this.txtfax.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtfax.Properties.ReadOnly = true;
            this.txtfax.Size = new System.Drawing.Size(344, 22);
            this.txtfax.TabIndex = 3;
            this.txtfax.Tag = "2";
            // 
            // lblfax
            // 
            this.lblfax.Location = new System.Drawing.Point(7, 42);
            this.lblfax.Name = "lblfax";
            this.lblfax.Size = new System.Drawing.Size(81, 14);
            this.lblfax.TabIndex = 208;
            this.lblfax.Tag = "t_fax";
            this.lblfax.Text = "傳真";
            this.lblfax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtphone
            // 
            this.txtphone.EnterMoveNextControl = true;
            this.txtphone.Location = new System.Drawing.Point(89, 13);
            this.txtphone.Name = "txtphone";
            this.txtphone.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtphone.Properties.ReadOnly = true;
            this.txtphone.Size = new System.Drawing.Size(344, 22);
            this.txtphone.TabIndex = 0;
            this.txtphone.Tag = "2";
            // 
            // lblphone
            // 
            this.lblphone.Location = new System.Drawing.Point(7, 17);
            this.lblphone.Name = "lblphone";
            this.lblphone.Size = new System.Drawing.Size(81, 14);
            this.lblphone.TabIndex = 206;
            this.lblphone.Tag = "t_tel";
            this.lblphone.Text = "電話";
            this.lblphone.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(216, 501);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 200;
            this.label2.Tag = "t_create_date";
            this.label2.Text = "建檔日期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblID);
            this.groupBox1.Controls.Add(this.lbltransport_mode);
            this.groupBox1.Controls.Add(this.txtid);
            this.groupBox1.Controls.Add(this.luetransport_mode);
            this.groupBox1.Controls.Add(this.txtname);
            this.groupBox1.Controls.Add(this.lblp_code);
            this.groupBox1.Controls.Add(this.lblCdesc);
            this.groupBox1.Controls.Add(this.luep_code);
            this.groupBox1.Controls.Add(this.txtenglish_name);
            this.groupBox1.Controls.Add(this.lblhomepage);
            this.groupBox1.Controls.Add(this.lblEdesc);
            this.groupBox1.Controls.Add(this.txthomepage);
            this.groupBox1.Controls.Add(this.luecustomer_group);
            this.groupBox1.Controls.Add(this.lblt_postalcode);
            this.groupBox1.Controls.Add(this.lblcustomer_group);
            this.groupBox1.Controls.Add(this.txtpostalcode);
            this.groupBox1.Controls.Add(this.t_state);
            this.groupBox1.Controls.Add(this.lblc_code);
            this.groupBox1.Controls.Add(this.luestate);
            this.groupBox1.Controls.Add(this.luec_code);
            this.groupBox1.Controls.Add(this.luetype);
            this.groupBox1.Controls.Add(this.lbltxtenglish_logogram);
            this.groupBox1.Controls.Add(this.lbltype);
            this.groupBox1.Controls.Add(this.txtenglish_logogram);
            this.groupBox1.Controls.Add(this.txtparent_id);
            this.groupBox1.Controls.Add(this.lblarea);
            this.groupBox1.Controls.Add(this.lblparent_id);
            this.groupBox1.Controls.Add(this.luearea);
            this.groupBox1.Controls.Add(this.txtsort_id);
            this.groupBox1.Controls.Add(this.lbllogogram);
            this.groupBox1.Controls.Add(this.lblsort_id);
            this.groupBox1.Controls.Add(this.txtlogogram);
            this.groupBox1.Location = new System.Drawing.Point(3, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(994, 166);
            this.groupBox1.TabIndex = 223;
            this.groupBox1.TabStop = false;
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(7, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(81, 14);
            this.lblID.TabIndex = 1;
            this.lblID.Tag = "t_id";
            this.lblID.Text = "編號";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltransport_mode
            // 
            this.lbltransport_mode.Location = new System.Drawing.Point(220, 142);
            this.lbltransport_mode.Name = "lbltransport_mode";
            this.lbltransport_mode.Size = new System.Drawing.Size(77, 14);
            this.lbltransport_mode.TabIndex = 222;
            this.lbltransport_mode.Tag = "t_transport_mode";
            this.lbltransport_mode.Text = "船運方式";
            this.lbltransport_mode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtid
            // 
            this.txtid.EnterMoveNextControl = true;
            this.txtid.Location = new System.Drawing.Point(89, 12);
            this.txtid.Name = "txtid";
            this.txtid.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Properties.MaxLength = 10;
            this.txtid.Properties.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(124, 22);
            this.txtid.TabIndex = 0;
            this.txtid.Tag = "2";
            this.txtid.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // luetransport_mode
            // 
            this.luetransport_mode.EditValue = "";
            this.luetransport_mode.Enabled = false;
            this.luetransport_mode.EnterMoveNextControl = true;
            this.luetransport_mode.Location = new System.Drawing.Point(300, 138);
            this.luetransport_mode.Name = "luetransport_mode";
            this.luetransport_mode.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.luetransport_mode.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luetransport_mode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luetransport_mode.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luetransport_mode.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luetransport_mode.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.luetransport_mode.Properties.DropDownRows = 15;
            this.luetransport_mode.Properties.MaxLength = 2;
            this.luetransport_mode.Properties.NullText = "";
            this.luetransport_mode.Properties.PopupWidth = 130;
            this.luetransport_mode.Properties.ShowHeader = false;
            this.luetransport_mode.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luetransport_mode.Size = new System.Drawing.Size(133, 22);
            this.luetransport_mode.TabIndex = 13;
            this.luetransport_mode.Tag = "2";
            // 
            // txtname
            // 
            this.txtname.EnterMoveNextControl = true;
            this.txtname.Location = new System.Drawing.Point(89, 37);
            this.txtname.Name = "txtname";
            this.txtname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtname.Properties.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(898, 22);
            this.txtname.TabIndex = 3;
            this.txtname.Tag = "2";
            // 
            // lblp_code
            // 
            this.lblp_code.Location = new System.Drawing.Point(7, 142);
            this.lblp_code.Name = "lblp_code";
            this.lblp_code.Size = new System.Drawing.Size(81, 14);
            this.lblp_code.TabIndex = 220;
            this.lblp_code.Tag = "t_port";
            this.lblp_code.Text = "港口";
            this.lblp_code.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCdesc
            // 
            this.lblCdesc.ForeColor = System.Drawing.Color.Blue;
            this.lblCdesc.Location = new System.Drawing.Point(7, 41);
            this.lblCdesc.Name = "lblCdesc";
            this.lblCdesc.Size = new System.Drawing.Size(81, 13);
            this.lblCdesc.TabIndex = 3;
            this.lblCdesc.Tag = "t_name";
            this.lblCdesc.Text = "中文名稱";
            this.lblCdesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // luep_code
            // 
            this.luep_code.EditValue = "";
            this.luep_code.Enabled = false;
            this.luep_code.EnterMoveNextControl = true;
            this.luep_code.Location = new System.Drawing.Point(89, 138);
            this.luep_code.Name = "luep_code";
            this.luep_code.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.luep_code.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luep_code.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luep_code.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luep_code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luep_code.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.luep_code.Properties.DropDownRows = 15;
            this.luep_code.Properties.MaxLength = 2;
            this.luep_code.Properties.NullText = "";
            this.luep_code.Properties.PopupWidth = 130;
            this.luep_code.Properties.ShowHeader = false;
            this.luep_code.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luep_code.Size = new System.Drawing.Size(124, 22);
            this.luep_code.TabIndex = 12;
            this.luep_code.Tag = "2";
            // 
            // txtenglish_name
            // 
            this.txtenglish_name.EnterMoveNextControl = true;
            this.txtenglish_name.Location = new System.Drawing.Point(89, 62);
            this.txtenglish_name.Name = "txtenglish_name";
            this.txtenglish_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtenglish_name.Properties.ReadOnly = true;
            this.txtenglish_name.Size = new System.Drawing.Size(898, 22);
            this.txtenglish_name.TabIndex = 4;
            this.txtenglish_name.Tag = "2";
            // 
            // lblhomepage
            // 
            this.lblhomepage.Location = new System.Drawing.Point(439, 142);
            this.lblhomepage.Name = "lblhomepage";
            this.lblhomepage.Size = new System.Drawing.Size(83, 14);
            this.lblhomepage.TabIndex = 218;
            this.lblhomepage.Tag = "t_homepage";
            this.lblhomepage.Text = "網址";
            this.lblhomepage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEdesc
            // 
            this.lblEdesc.Location = new System.Drawing.Point(7, 66);
            this.lblEdesc.Name = "lblEdesc";
            this.lblEdesc.Size = new System.Drawing.Size(81, 13);
            this.lblEdesc.TabIndex = 5;
            this.lblEdesc.Tag = "t_english_name";
            this.lblEdesc.Text = "英文名稱";
            this.lblEdesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txthomepage
            // 
            this.txthomepage.EnterMoveNextControl = true;
            this.txthomepage.Location = new System.Drawing.Point(525, 138);
            this.txthomepage.Name = "txthomepage";
            this.txthomepage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txthomepage.Properties.ReadOnly = true;
            this.txthomepage.Size = new System.Drawing.Size(462, 22);
            this.txthomepage.TabIndex = 14;
            this.txthomepage.Tag = "2";
            // 
            // luecustomer_group
            // 
            this.luecustomer_group.EditValue = "";
            this.luecustomer_group.Enabled = false;
            this.luecustomer_group.EnterMoveNextControl = true;
            this.luecustomer_group.Location = new System.Drawing.Point(300, 12);
            this.luecustomer_group.Name = "luecustomer_group";
            this.luecustomer_group.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.luecustomer_group.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luecustomer_group.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luecustomer_group.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luecustomer_group.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luecustomer_group.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.luecustomer_group.Properties.DropDownRows = 15;
            this.luecustomer_group.Properties.MaxLength = 2;
            this.luecustomer_group.Properties.NullText = "";
            this.luecustomer_group.Properties.PopupWidth = 130;
            this.luecustomer_group.Properties.ShowHeader = false;
            this.luecustomer_group.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luecustomer_group.Size = new System.Drawing.Size(133, 22);
            this.luecustomer_group.TabIndex = 1;
            this.luecustomer_group.Tag = "2";
            // 
            // lblt_postalcode
            // 
            this.lblt_postalcode.Location = new System.Drawing.Point(439, 117);
            this.lblt_postalcode.Name = "lblt_postalcode";
            this.lblt_postalcode.Size = new System.Drawing.Size(83, 13);
            this.lblt_postalcode.TabIndex = 216;
            this.lblt_postalcode.Tag = "t_postalcode";
            this.lblt_postalcode.Text = "郵政編碼";
            this.lblt_postalcode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcustomer_group
            // 
            this.lblcustomer_group.ForeColor = System.Drawing.Color.Blue;
            this.lblcustomer_group.Location = new System.Drawing.Point(220, 14);
            this.lblcustomer_group.Name = "lblcustomer_group";
            this.lblcustomer_group.Size = new System.Drawing.Size(77, 14);
            this.lblcustomer_group.TabIndex = 22;
            this.lblcustomer_group.Tag = "t_customer_group";
            this.lblcustomer_group.Text = "客戶組別";
            this.lblcustomer_group.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtpostalcode
            // 
            this.txtpostalcode.EnterMoveNextControl = true;
            this.txtpostalcode.Location = new System.Drawing.Point(525, 113);
            this.txtpostalcode.Name = "txtpostalcode";
            this.txtpostalcode.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtpostalcode.Properties.ReadOnly = true;
            this.txtpostalcode.Size = new System.Drawing.Size(148, 22);
            this.txtpostalcode.TabIndex = 10;
            this.txtpostalcode.Tag = "2";
            // 
            // t_state
            // 
            this.t_state.Location = new System.Drawing.Point(705, 14);
            this.t_state.Name = "t_state";
            this.t_state.Size = new System.Drawing.Size(80, 14);
            this.t_state.TabIndex = 192;
            this.t_state.Tag = "t_state";
            this.t_state.Text = "狀態";
            this.t_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblc_code
            // 
            this.lblc_code.Location = new System.Drawing.Point(701, 117);
            this.lblc_code.Name = "lblc_code";
            this.lblc_code.Size = new System.Drawing.Size(84, 13);
            this.lblc_code.TabIndex = 214;
            this.lblc_code.Tag = "t_country_id";
            this.lblc_code.Text = "國家編碼";
            this.lblc_code.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // luestate
            // 
            this.luestate.EditValue = "";
            this.luestate.Enabled = false;
            this.luestate.Location = new System.Drawing.Point(788, 12);
            this.luestate.Name = "luestate";
            this.luestate.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.luestate.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luestate.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luestate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luestate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.luestate.Properties.ImmediatePopup = true;
            this.luestate.Properties.NullText = "";
            this.luestate.Properties.PopupWidth = 130;
            this.luestate.Properties.ReadOnly = true;
            this.luestate.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.luestate.Properties.ShowHeader = false;
            this.luestate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luestate.Size = new System.Drawing.Size(199, 22);
            this.luestate.TabIndex = 191;
            this.luestate.Tag = "2";
            // 
            // luec_code
            // 
            this.luec_code.EditValue = "";
            this.luec_code.Enabled = false;
            this.luec_code.EnterMoveNextControl = true;
            this.luec_code.Location = new System.Drawing.Point(788, 113);
            this.luec_code.Name = "luec_code";
            this.luec_code.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.luec_code.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luec_code.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luec_code.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luec_code.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luec_code.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.luec_code.Properties.DropDownRows = 15;
            this.luec_code.Properties.MaxLength = 2;
            this.luec_code.Properties.NullText = "";
            this.luec_code.Properties.PopupWidth = 130;
            this.luec_code.Properties.ShowHeader = false;
            this.luec_code.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luec_code.Size = new System.Drawing.Size(199, 22);
            this.luec_code.TabIndex = 11;
            this.luec_code.Tag = "2";
            // 
            // luetype
            // 
            this.luetype.EditValue = "";
            this.luetype.Enabled = false;
            this.luetype.EnterMoveNextControl = true;
            this.luetype.Location = new System.Drawing.Point(525, 12);
            this.luetype.Name = "luetype";
            this.luetype.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.luetype.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luetype.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luetype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luetype.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luetype.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.luetype.Properties.DropDownRows = 15;
            this.luetype.Properties.MaxLength = 2;
            this.luetype.Properties.NullText = "";
            this.luetype.Properties.PopupWidth = 130;
            this.luetype.Properties.ShowHeader = false;
            this.luetype.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luetype.Size = new System.Drawing.Size(148, 22);
            this.luetype.TabIndex = 2;
            this.luetype.Tag = "2";
            // 
            // lbltxtenglish_logogram
            // 
            this.lbltxtenglish_logogram.Location = new System.Drawing.Point(701, 92);
            this.lbltxtenglish_logogram.Name = "lbltxtenglish_logogram";
            this.lbltxtenglish_logogram.Size = new System.Drawing.Size(84, 14);
            this.lbltxtenglish_logogram.TabIndex = 212;
            this.lbltxtenglish_logogram.Tag = "t_english_logogram";
            this.lbltxtenglish_logogram.Text = "簡稱(英文)";
            this.lbltxtenglish_logogram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbltype
            // 
            this.lbltype.Location = new System.Drawing.Point(439, 14);
            this.lbltype.Name = "lbltype";
            this.lbltype.Size = new System.Drawing.Size(83, 14);
            this.lbltype.TabIndex = 202;
            this.lbltype.Tag = "t_cust_type";
            this.lbltype.Text = "客戶類型";
            this.lbltype.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtenglish_logogram
            // 
            this.txtenglish_logogram.EnterMoveNextControl = true;
            this.txtenglish_logogram.Location = new System.Drawing.Point(788, 88);
            this.txtenglish_logogram.Name = "txtenglish_logogram";
            this.txtenglish_logogram.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtenglish_logogram.Properties.ReadOnly = true;
            this.txtenglish_logogram.Size = new System.Drawing.Size(199, 22);
            this.txtenglish_logogram.TabIndex = 7;
            this.txtenglish_logogram.Tag = "2";
            // 
            // txtparent_id
            // 
            this.txtparent_id.EnterMoveNextControl = true;
            this.txtparent_id.Location = new System.Drawing.Point(89, 88);
            this.txtparent_id.Name = "txtparent_id";
            this.txtparent_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtparent_id.Properties.ReadOnly = true;
            this.txtparent_id.Size = new System.Drawing.Size(124, 22);
            this.txtparent_id.TabIndex = 5;
            this.txtparent_id.Tag = "2";
            // 
            // lblarea
            // 
            this.lblarea.Location = new System.Drawing.Point(220, 117);
            this.lblarea.Name = "lblarea";
            this.lblarea.Size = new System.Drawing.Size(77, 13);
            this.lblarea.TabIndex = 210;
            this.lblarea.Tag = "t_area";
            this.lblarea.Text = "區域";
            this.lblarea.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblparent_id
            // 
            this.lblparent_id.Location = new System.Drawing.Point(7, 92);
            this.lblparent_id.Name = "lblparent_id";
            this.lblparent_id.Size = new System.Drawing.Size(81, 14);
            this.lblparent_id.TabIndex = 204;
            this.lblparent_id.Tag = "t_parent_cust";
            this.lblparent_id.Text = "上級客戶";
            this.lblparent_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // luearea
            // 
            this.luearea.EditValue = "";
            this.luearea.Enabled = false;
            this.luearea.EnterMoveNextControl = true;
            this.luearea.Location = new System.Drawing.Point(300, 113);
            this.luearea.Name = "luearea";
            this.luearea.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.luearea.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luearea.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luearea.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luearea.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luearea.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.luearea.Properties.DropDownRows = 15;
            this.luearea.Properties.MaxLength = 2;
            this.luearea.Properties.NullText = "";
            this.luearea.Properties.PopupWidth = 130;
            this.luearea.Properties.ShowHeader = false;
            this.luearea.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luearea.Size = new System.Drawing.Size(133, 22);
            this.luearea.TabIndex = 9;
            this.luearea.Tag = "2";
            // 
            // txtsort_id
            // 
            this.txtsort_id.EnterMoveNextControl = true;
            this.txtsort_id.Location = new System.Drawing.Point(89, 113);
            this.txtsort_id.Name = "txtsort_id";
            this.txtsort_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtsort_id.Properties.ReadOnly = true;
            this.txtsort_id.Size = new System.Drawing.Size(124, 22);
            this.txtsort_id.TabIndex = 8;
            this.txtsort_id.Tag = "2";
            // 
            // lbllogogram
            // 
            this.lbllogogram.Location = new System.Drawing.Point(220, 92);
            this.lbllogogram.Name = "lbllogogram";
            this.lbllogogram.Size = new System.Drawing.Size(77, 14);
            this.lbllogogram.TabIndex = 208;
            this.lbllogogram.Tag = "t_logogram";
            this.lbllogogram.Text = "簡稱";
            this.lbllogogram.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblsort_id
            // 
            this.lblsort_id.Location = new System.Drawing.Point(7, 117);
            this.lblsort_id.Name = "lblsort_id";
            this.lblsort_id.Size = new System.Drawing.Size(81, 13);
            this.lblsort_id.TabIndex = 206;
            this.lblsort_id.Tag = "t_sort_id";
            this.lblsort_id.Text = "最終客戶";
            this.lblsort_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtlogogram
            // 
            this.txtlogogram.EnterMoveNextControl = true;
            this.txtlogogram.Location = new System.Drawing.Point(300, 88);
            this.txtlogogram.Name = "txtlogogram";
            this.txtlogogram.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtlogogram.Properties.ReadOnly = true;
            this.txtlogogram.Size = new System.Drawing.Size(373, 22);
            this.txtlogogram.TabIndex = 6;
            this.txtlogogram.Tag = "2";
            // 
            // txtcreate_by
            // 
            this.txtcreate_by.Enabled = false;
            this.txtcreate_by.Location = new System.Drawing.Point(92, 499);
            this.txtcreate_by.Name = "txtcreate_by";
            this.txtcreate_by.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcreate_by.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtcreate_by.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcreate_by.Properties.ReadOnly = true;
            this.txtcreate_by.Size = new System.Drawing.Size(124, 22);
            this.txtcreate_by.TabIndex = 0;
            this.txtcreate_by.Tag = "2";
            // 
            // lblAmtim
            // 
            this.lblAmtim.Location = new System.Drawing.Point(708, 501);
            this.lblAmtim.Name = "lblAmtim";
            this.lblAmtim.Size = new System.Drawing.Size(80, 13);
            this.lblAmtim.TabIndex = 15;
            this.lblAmtim.Tag = "t_update_date";
            this.lblAmtim.Text = "修改日期";
            this.lblAmtim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCrusr
            // 
            this.lblCrusr.Location = new System.Drawing.Point(7, 501);
            this.lblCrusr.Name = "lblCrusr";
            this.lblCrusr.Size = new System.Drawing.Size(85, 13);
            this.lblCrusr.TabIndex = 12;
            this.lblCrusr.Tag = "t_create_by";
            this.lblCrusr.Text = "建檔人";
            this.lblCrusr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcreate_date
            // 
            this.txtcreate_date.Enabled = false;
            this.txtcreate_date.Location = new System.Drawing.Point(303, 499);
            this.txtcreate_date.Name = "txtcreate_date";
            this.txtcreate_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcreate_date.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtcreate_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcreate_date.Properties.ReadOnly = true;
            this.txtcreate_date.Size = new System.Drawing.Size(225, 22);
            this.txtcreate_date.TabIndex = 1;
            this.txtcreate_date.Tag = "2";
            // 
            // lblAmusr
            // 
            this.lblAmusr.Location = new System.Drawing.Point(532, 501);
            this.lblAmusr.Name = "lblAmusr";
            this.lblAmusr.Size = new System.Drawing.Size(68, 13);
            this.lblAmusr.TabIndex = 14;
            this.lblAmusr.Tag = "t_update_by";
            this.lblAmusr.Text = "修改人";
            this.lblAmusr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtupdate_date
            // 
            this.txtupdate_date.Enabled = false;
            this.txtupdate_date.Location = new System.Drawing.Point(792, 499);
            this.txtupdate_date.Name = "txtupdate_date";
            this.txtupdate_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtupdate_date.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtupdate_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtupdate_date.Properties.ReadOnly = true;
            this.txtupdate_date.Size = new System.Drawing.Size(198, 22);
            this.txtupdate_date.TabIndex = 3;
            this.txtupdate_date.Tag = "2";
            // 
            // txtupdate_by
            // 
            this.txtupdate_by.Enabled = false;
            this.txtupdate_by.Location = new System.Drawing.Point(603, 499);
            this.txtupdate_by.Name = "txtupdate_by";
            this.txtupdate_by.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtupdate_by.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtupdate_by.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtupdate_by.Properties.ReadOnly = true;
            this.txtupdate_by.Size = new System.Drawing.Size(101, 22);
            this.txtupdate_by.TabIndex = 2;
            this.txtupdate_by.Tag = "2";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNEXIT,
            this.toolStripSeparator1,
            this.BTNNEW,
            this.toolStripSeparator5,
            this.BTNEDIT,
            this.toolStripSeparator2,
            this.BTNSAVE,
            this.BTNCANCEL,
            this.toolStripSeparator3,
            this.BTNCONFIRM,
            this.toolStripSeparator10,
            this.toolStripSeparator6,
            this.BTNACTION,
            this.toolStripSeparator9,
            this.toolStripSeparator11,
            this.BTNDELETE,
            this.toolStripSeparator4,
            this.BTNFIND,
            this.toolStripSeparator7,
            this.BTNPRINT,
            this.toolStripSeparator8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1016, 25);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(49, 22);
            this.BTNEXIT.Text = "退出(&X)";
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNNEW
            // 
            this.BTNNEW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNNEW.Name = "BTNNEW";
            this.BTNNEW.Size = new System.Drawing.Size(49, 22);
            this.BTNNEW.Text = "新增(&A)";
            this.BTNNEW.Click += new System.EventHandler(this.BTNNEW_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNEDIT
            // 
            this.BTNEDIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(48, 22);
            this.BTNEDIT.Text = "編輯(&E)";
            this.BTNEDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.Enabled = false;
            this.BTNSAVE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(47, 22);
            this.BTNSAVE.Text = "保存(&S)";
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.Enabled = false;
            this.BTNCANCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(49, 22);
            this.BTNCANCEL.Text = "取消(&C)";
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNCONFIRM
            // 
            this.BTNCONFIRM.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNCONFIRM.Name = "BTNCONFIRM";
            this.BTNCONFIRM.Size = new System.Drawing.Size(33, 22);
            this.BTNCONFIRM.Text = "批準";
            this.BTNCONFIRM.Click += new System.EventHandler(this.BTNCONFIRM_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNACTION
            // 
            this.BTNACTION.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNACTION.Name = "BTNACTION";
            this.BTNACTION.Size = new System.Drawing.Size(40, 22);
            this.BTNACTION.Text = "Action";
            this.BTNACTION.ToolTipText = "Set Customer State";
            this.BTNACTION.Click += new System.EventHandler(this.BTNACTION_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(49, 22);
            this.BTNDELETE.Text = "刪除(&D)";
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNFIND
            // 
            this.BTNFIND.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNFIND.Name = "BTNFIND";
            this.BTNFIND.Size = new System.Drawing.Size(47, 22);
            this.BTNFIND.Text = "查詢(&F)";
            this.BTNFIND.Click += new System.EventHandler(this.BTNFIND_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNPRINT
            // 
            this.BTNPRINT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNPRINT.Name = "BTNPRINT";
            this.BTNPRINT.Size = new System.Drawing.Size(47, 22);
            this.BTNPRINT.Text = "列印(&P)";
            this.BTNPRINT.Click += new System.EventHandler(this.BTNPRINT_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(1, 28);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1015, 711);
            this.tabControl1.TabIndex = 12;
            this.tabControl1.Tag = "t_cust_base_info";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.dgvDetails);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1007, 685);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "t_cust_base_info";
            this.tabPage1.Text = "客戶基本資料";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.btnSearch);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.txtcust_name);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.txtcust2);
            this.tabPage2.Controls.Add(this.txtcust1);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1007, 685);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "t_search";
            this.tabPage2.Text = "數據查找";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnSearch
            // 
            this.btnSearch.Image = global::cfvn.Properties.Resources.find;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(456, 23);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(88, 40);
            this.btnSearch.TabIndex = 10;
            this.btnSearch.Text = "Find";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("PMingLiU", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(278, 23);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(21, 13);
            this.label7.TabIndex = 9;
            this.label7.Tag = "";
            this.label7.Text = "~";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(53, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 8;
            this.label6.Tag = "t_customer_id";
            this.label6.Text = "客戶編號";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcust_name
            // 
            this.txtcust_name.EnterMoveNextControl = true;
            this.txtcust_name.Location = new System.Drawing.Point(140, 49);
            this.txtcust_name.Name = "txtcust_name";
            this.txtcust_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcust_name.Size = new System.Drawing.Size(293, 22);
            this.txtcust_name.TabIndex = 6;
            this.txtcust_name.Tag = "2";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(58, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 7;
            this.label5.Tag = "t_name";
            this.label5.Text = "客戶名稱";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcust2
            // 
            this.txtcust2.EditValue = "";
            this.txtcust2.EnterMoveNextControl = true;
            this.txtcust2.Location = new System.Drawing.Point(301, 21);
            this.txtcust2.Name = "txtcust2";
            this.txtcust2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcust2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcust2.Properties.MaxLength = 8;
            this.txtcust2.Size = new System.Drawing.Size(132, 22);
            this.txtcust2.TabIndex = 2;
            this.txtcust2.Tag = "";
            // 
            // txtcust1
            // 
            this.txtcust1.EditValue = "";
            this.txtcust1.EnterMoveNextControl = true;
            this.txtcust1.Location = new System.Drawing.Point(140, 21);
            this.txtcust1.Name = "txtcust1";
            this.txtcust1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcust1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtcust1.Properties.MaxLength = 8;
            this.txtcust1.Size = new System.Drawing.Size(132, 22);
            this.txtcust1.TabIndex = 1;
            this.txtcust1.Tag = "";
            this.txtcust1.Leave += new System.EventHandler(this.txtcust1_Leave);
            // 
            // frmBsCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmBsCustomer";
            this.Tag = "Forms.frmBsCustomer";
            this.Text = "frmBsCustomer";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBsCustomer_FormClosed);
            this.Load += new System.EventHandler(this.frmBsCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_e_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_s_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_email.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_comments.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_fax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtshipment_linkman.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcheckup_hint.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luemoney_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueaction_state.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chkis_print_logo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcharacter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueseller_id_3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcancel_reason_type_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueseller_id_2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueseller_id_1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luecancel_reason_type_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtemail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txta_phone.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txta_linkman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtfax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtphone.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetransport_mode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luep_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txthomepage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luecustomer_group.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpostalcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luec_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luetype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_logogram.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtparent_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luearea.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtsort_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtlogogram.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtcust_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcust2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcust1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblcustomer_group;
        private DevExpress.XtraEditors.LookUpEdit luecustomer_group;
        private System.Windows.Forms.Label lblAmtim;
        private System.Windows.Forms.Label lblAmusr;
        private System.Windows.Forms.Label lblCrusr;
        private DevExpress.XtraEditors.TextEdit txtupdate_date;
        private DevExpress.XtraEditors.TextEdit txtupdate_by;
        private DevExpress.XtraEditors.TextEdit txtcreate_date;
        private DevExpress.XtraEditors.TextEdit txtcreate_by;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblEdesc;
        private DevExpress.XtraEditors.TextEdit txtenglish_name;
        private System.Windows.Forms.Label lblCdesc;
        private DevExpress.XtraEditors.TextEdit txtname;
        private System.Windows.Forms.Label lblID;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTNEXIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTNNEW;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BTNEDIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTNSAVE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BTNCANCEL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BTNDELETE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BTNFIND;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton BTNPRINT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton BTNCONFIRM;
        private DevExpress.XtraEditors.LookUpEdit luestate;
        private System.Windows.Forms.Label t_state;
        private System.Windows.Forms.BindingSource bds1;
        private System.Windows.Forms.Label lblis_print_logo;
        private DevExpress.XtraEditors.CheckEdit chkis_print_logo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbltype;
        private DevExpress.XtraEditors.LookUpEdit luetype;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbllogogram;
        private DevExpress.XtraEditors.TextEdit txtlogogram;
        private System.Windows.Forms.Label lblsort_id;
        private DevExpress.XtraEditors.TextEdit txtsort_id;
        private System.Windows.Forms.Label lblparent_id;
        private DevExpress.XtraEditors.TextEdit txtparent_id;
        private System.Windows.Forms.Label lblarea;
        private DevExpress.XtraEditors.LookUpEdit luearea;
        private System.Windows.Forms.Label lblhomepage;
        private DevExpress.XtraEditors.TextEdit txthomepage;
        private System.Windows.Forms.Label lblt_postalcode;
        private DevExpress.XtraEditors.TextEdit txtpostalcode;
        private System.Windows.Forms.Label lblc_code;
        private DevExpress.XtraEditors.LookUpEdit luec_code;
        private System.Windows.Forms.Label lbltxtenglish_logogram;
        private DevExpress.XtraEditors.TextEdit txtenglish_logogram;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbltransport_mode;
        private DevExpress.XtraEditors.LookUpEdit luetransport_mode;
        private System.Windows.Forms.Label lblp_code;
        private DevExpress.XtraEditors.LookUpEdit luep_code;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblmoney_id;
        private DevExpress.XtraEditors.LookUpEdit luemoney_id;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit lueseller_id_3;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.LookUpEdit lueseller_id_2;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit lueseller_id_1;
        private DevExpress.XtraEditors.TextEdit txtemail;
        private System.Windows.Forms.Label lblemail;
        private DevExpress.XtraEditors.TextEdit txta_phone;
        private System.Windows.Forms.Label lbla_phone;
        private DevExpress.XtraEditors.TextEdit txta_linkman;
        private System.Windows.Forms.Label lbltxta_linkman;
        private DevExpress.XtraEditors.TextEdit txtfax;
        private System.Windows.Forms.Label lblfax;
        private DevExpress.XtraEditors.TextEdit txtphone;
        private System.Windows.Forms.Label lblphone;
        private DevExpress.XtraEditors.TextEdit txtcancel_reason_type_name;
        private System.Windows.Forms.Label lblcancel_reason_type_id;
        private DevExpress.XtraEditors.LookUpEdit luecancel_reason_type_id;
        private DevExpress.XtraEditors.TextEdit txtcharacter;
        private System.Windows.Forms.Label lblcharacter;
        private System.Windows.Forms.Label lblcheckup_hint;
        private DevExpress.XtraEditors.TextEdit txtcheckup_hint;
        private System.Windows.Forms.Label lblaction_state;
        private DevExpress.XtraEditors.LookUpEdit lueaction_state;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblshipment_email;
        private System.Windows.Forms.Label lblshipment_e_address;
        private DevExpress.XtraEditors.MemoEdit txtshipment_e_address;
        private DevExpress.XtraEditors.MemoEdit txtshipment_s_address;
        private DevExpress.XtraEditors.TextEdit txtshipment_email;
        private System.Windows.Forms.Label lblshipment_s_address;
        private DevExpress.XtraEditors.TextEdit txtshipment_comments;
        private System.Windows.Forms.Label lblshipment_comments;
        private DevExpress.XtraEditors.TextEdit txtshipment_fax;
        private System.Windows.Forms.Label lbltxtshipment_fax;
        private DevExpress.XtraEditors.TextEdit txtshipment_phone;
        private System.Windows.Forms.Label lblshipment_phone;
        private DevExpress.XtraEditors.TextEdit txtshipment_linkman;
        private System.Windows.Forms.Label lblshipment_linkman;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton BTNACTION;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit txtcust_name;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.TextEdit txtcust2;
        private DevExpress.XtraEditors.TextEdit txtcust1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn english_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn logogram;
        private System.Windows.Forms.DataGridViewTextBoxColumn english_logogram;
        private System.Windows.Forms.DataGridViewTextBoxColumn sort_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn area;
        private System.Windows.Forms.DataGridViewTextBoxColumn postalcode;
        private System.Windows.Forms.DataGridViewTextBoxColumn c_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn p_code;
        private System.Windows.Forms.DataGridViewTextBoxColumn transport_mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn homepage;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_linkman;
        private System.Windows.Forms.DataGridViewTextBoxColumn a_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn email;
        private System.Windows.Forms.DataGridViewTextBoxColumn seller_id_1;
        private System.Windows.Forms.DataGridViewTextBoxColumn seller_id_2;
        private System.Windows.Forms.DataGridViewTextBoxColumn seller_id_3;
        private System.Windows.Forms.DataGridViewTextBoxColumn money_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancel_reason_type_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn cancel_reason_type_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn character;
        private System.Windows.Forms.DataGridViewTextBoxColumn action_state;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkup_hint;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_print_logo;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_linkman;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_phone;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_comments;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_s_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn shipment_e_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_date;
        private ModuleClass.LineX lineX1;
    }
}