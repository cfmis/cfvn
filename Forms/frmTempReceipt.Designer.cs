namespace cfvn.Forms
{
    partial class frmTempReceipt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTempReceipt));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNEXIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNNEW = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNEDIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNDELETE = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNITEMADD = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNITEMDEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNSAVE = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNCANCEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNAPPROVE = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNPRINT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tabPoPurchase = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label20 = new System.Windows.Forms.Label();
            this.luedepartment_id = new DevExpress.XtraEditors.LookUpEdit();
            this.txtdeliveryman = new DevExpress.XtraEditors.TextEdit();
            this.lbllinkman = new System.Windows.Forms.Label();
            this.lueseparate = new DevExpress.XtraEditors.LookUpEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.luevendor_id = new DevExpress.XtraEditors.LookUpEdit();
            this.label11 = new System.Windows.Forms.Label();
            this.detir_date = new DevExpress.XtraEditors.DateEdit();
            this.luestate = new DevExpress.XtraEditors.LookUpEdit();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgvDetails = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.po_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mo_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_mo_id = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.goods_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_goods_id = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.goods_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.color = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unit_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_unit_code = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.s_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_order_qty = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.temp_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_temp_qty = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.m_receipt_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_m_receipt_qty = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.fact_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_fact_qty = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sec_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_weight = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.sec_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_unit_code_sec = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.location_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_location_id = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.qc_result = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_qc_result = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.qc_state = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_qc_state = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sell_order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sequence_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.po_ver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.po_sequence_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.basic_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.location = new DevExpress.XtraGrid.Columns.GridColumn();
            this.carton_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.total_sum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.currency = new DevExpress.XtraGrid.Columns.GridColumn();
            this.exchange_rate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_rate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.s_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblAmtim = new System.Windows.Forms.Label();
            this.lblAmusr = new System.Windows.Forms.Label();
            this.lblCrtim = new System.Windows.Forms.Label();
            this.lblCrusr = new System.Windows.Forms.Label();
            this.txtupdate_date = new DevExpress.XtraEditors.TextEdit();
            this.txtupdate_by = new DevExpress.XtraEditors.TextEdit();
            this.txtcreate_date = new DevExpress.XtraEditors.TextEdit();
            this.txtcreate_by = new DevExpress.XtraEditors.TextEdit();
            this.label9 = new System.Windows.Forms.Label();
            this.txtremark = new DevExpress.XtraEditors.MemoEdit();
            this.lbldeliver_id = new System.Windows.Forms.Label();
            this.txtdeliver_id = new DevExpress.XtraEditors.TextEdit();
            this.label4 = new System.Windows.Forms.Label();
            this.txtconsignee = new DevExpress.XtraEditors.TextEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtvendor = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dgvFind = new System.Windows.Forms.DataGridView();
            this.id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ir_date1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendor_id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vendor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department_id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mo_id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_id1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goods_name1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.s_qty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit_code1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receipt_qty1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label39 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.txtmo_id2 = new DevExpress.XtraEditors.TextEdit();
            this.luedept_id2 = new DevExpress.XtraEditors.LookUpEdit();
            this.luevendor_id2 = new DevExpress.XtraEditors.LookUpEdit();
            this.dteir_date2 = new DevExpress.XtraEditors.DateEdit();
            this.txtid2 = new DevExpress.XtraEditors.TextEdit();
            this.txtmo_id1 = new DevExpress.XtraEditors.TextEdit();
            this.label34 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.luedept_id1 = new DevExpress.XtraEditors.LookUpEdit();
            this.luevendor_id1 = new DevExpress.XtraEditors.LookUpEdit();
            this.label32 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.dteir_date1 = new DevExpress.XtraEditors.DateEdit();
            this.label30 = new System.Windows.Forms.Label();
            this.txtid1 = new DevExpress.XtraEditors.TextEdit();
            this.BTNFIND = new System.Windows.Forms.Button();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.toolStrip1.SuspendLayout();
            this.tabPoPurchase.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luedepartment_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdeliveryman.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueseparate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luevendor_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detir_date.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detir_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_mo_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_goods_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_unit_code)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_order_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_temp_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_m_receipt_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_fact_qty)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_weight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_unit_code_sec)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_location_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_qc_result)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_qc_state)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtremark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdeliver_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtconsignee.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvendor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmo_id2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luedept_id2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luevendor_id2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmo_id1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luedept_id1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luevendor_id1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNEXIT,
            this.toolStripSeparator1,
            this.BTNNEW,
            this.toolStripSeparator5,
            this.BTNEDIT,
            this.toolStripSeparator10,
            this.BTNDELETE,
            this.toolStripSeparator9,
            this.BTNITEMADD,
            this.toolStripSeparator2,
            this.BTNITEMDEL,
            this.toolStripSeparator6,
            this.BTNSAVE,
            this.toolStripSeparator3,
            this.BTNCANCEL,
            this.toolStripSeparator4,
            this.BTNAPPROVE,
            this.toolStripSeparator11,
            this.BTNPRINT,
            this.toolStripSeparator8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1009, 38);
            this.toolStrip1.TabIndex = 25;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.AutoSize = false;
            this.BTNEXIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(49, 35);
            this.BTNEXIT.Text = "退出(&X)";
            this.BTNEXIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // BTNNEW
            // 
            this.BTNNEW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNNEW.Name = "BTNNEW";
            this.BTNNEW.Size = new System.Drawing.Size(49, 35);
            this.BTNNEW.Text = "新增(&N)";
            this.BTNNEW.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.BTNNEW.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNNEW.Click += new System.EventHandler(this.BTNNEW_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // BTNEDIT
            // 
            this.BTNEDIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(48, 35);
            this.BTNEDIT.Text = "編輯(&E)";
            this.BTNEDIT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNEDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 38);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(49, 35);
            this.BTNDELETE.Text = "刪除(&D)";
            this.BTNDELETE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 38);
            // 
            // BTNITEMADD
            // 
            this.BTNITEMADD.Enabled = false;
            this.BTNITEMADD.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNITEMADD.Name = "BTNITEMADD";
            this.BTNITEMADD.Size = new System.Drawing.Size(73, 35);
            this.BTNITEMADD.Text = "項目增加(&A)";
            this.BTNITEMADD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNITEMADD.Click += new System.EventHandler(this.BTNITEMADD_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // BTNITEMDEL
            // 
            this.BTNITEMDEL.Enabled = false;
            this.BTNITEMDEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNITEMDEL.Name = "BTNITEMDEL";
            this.BTNITEMDEL.Size = new System.Drawing.Size(72, 35);
            this.BTNITEMDEL.Text = "項目刪除(&L)";
            this.BTNITEMDEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNITEMDEL.Click += new System.EventHandler(this.BTNITEMDEL_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.Enabled = false;
            this.BTNSAVE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(47, 35);
            this.BTNSAVE.Text = "保存(&S)";
            this.BTNSAVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.Enabled = false;
            this.BTNCANCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(49, 35);
            this.BTNCANCEL.Text = "取消(&U)";
            this.BTNCANCEL.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // BTNAPPROVE
            // 
            this.BTNAPPROVE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNAPPROVE.Name = "BTNAPPROVE";
            this.BTNAPPROVE.Size = new System.Drawing.Size(49, 35);
            this.BTNAPPROVE.Tag = "\"0\"";
            this.BTNAPPROVE.Text = "批準(&C)";
            this.BTNAPPROVE.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNAPPROVE.Click += new System.EventHandler(this.BTNAPPROVE_Click);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(6, 38);
            // 
            // BTNPRINT
            // 
            this.BTNPRINT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNPRINT.Name = "BTNPRINT";
            this.BTNPRINT.Size = new System.Drawing.Size(47, 35);
            this.BTNPRINT.Text = "列印(&P)";
            this.BTNPRINT.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.BTNPRINT.Click += new System.EventHandler(this.BTNPRINT_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.AutoSize = false;
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(20, 38);
            // 
            // tabPoPurchase
            // 
            this.tabPoPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabPoPurchase.Controls.Add(this.tabPage1);
            this.tabPoPurchase.Controls.Add(this.tabPage2);
            this.tabPoPurchase.Font = new System.Drawing.Font("PMingLiU", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabPoPurchase.ImageList = this.myImageList;
            this.tabPoPurchase.Location = new System.Drawing.Point(0, 41);
            this.tabPoPurchase.Name = "tabPoPurchase";
            this.tabPoPurchase.SelectedIndex = 0;
            this.tabPoPurchase.Size = new System.Drawing.Size(1009, 700);
            this.tabPoPurchase.TabIndex = 27;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage1.Controls.Add(this.label20);
            this.tabPage1.Controls.Add(this.luedepartment_id);
            this.tabPage1.Controls.Add(this.txtdeliveryman);
            this.tabPage1.Controls.Add(this.lbllinkman);
            this.tabPage1.Controls.Add(this.lueseparate);
            this.tabPage1.Controls.Add(this.label16);
            this.tabPage1.Controls.Add(this.luevendor_id);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.detir_date);
            this.tabPage1.Controls.Add(this.luestate);
            this.tabPage1.Controls.Add(this.gridControl1);
            this.tabPage1.Controls.Add(this.lblAmtim);
            this.tabPage1.Controls.Add(this.lblAmusr);
            this.tabPage1.Controls.Add(this.lblCrtim);
            this.tabPage1.Controls.Add(this.lblCrusr);
            this.tabPage1.Controls.Add(this.txtupdate_date);
            this.tabPage1.Controls.Add(this.txtupdate_by);
            this.tabPage1.Controls.Add(this.txtcreate_date);
            this.tabPage1.Controls.Add(this.txtcreate_by);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.txtremark);
            this.tabPage1.Controls.Add(this.lbldeliver_id);
            this.tabPage1.Controls.Add(this.txtdeliver_id);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.txtconsignee);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtvendor);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.lblID);
            this.tabPage1.Controls.Add(this.txtID);
            this.tabPage1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tabPage1.Location = new System.Drawing.Point(4, 26);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1001, 670);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Tag = "t_data_edit";
            this.tabPage1.Text = "數據編輯";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(215, 49);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(150, 17);
            this.label20.TabIndex = 247;
            this.label20.Tag = "t_dept_id";
            this.label20.Text = "部門";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // luedepartment_id
            // 
            this.luedepartment_id.EditValue = "";
            this.luedepartment_id.Enabled = false;
            this.luedepartment_id.EnterMoveNextControl = true;
            this.luedepartment_id.Location = new System.Drawing.Point(367, 49);
            this.luedepartment_id.Name = "luedepartment_id";
            this.luedepartment_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.luedepartment_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luedepartment_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luedepartment_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luedepartment_id.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 80, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 150, "name")});
            this.luedepartment_id.Properties.DropDownRows = 15;
            this.luedepartment_id.Properties.ImmediatePopup = true;
            this.luedepartment_id.Properties.NullText = "";
            this.luedepartment_id.Properties.PopupFormMinSize = new System.Drawing.Size(230, 0);
            this.luedepartment_id.Properties.PopupWidth = 230;
            this.luedepartment_id.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.luedepartment_id.Properties.ShowHeader = false;
            this.luedepartment_id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luedepartment_id.Size = new System.Drawing.Size(134, 20);
            this.luedepartment_id.TabIndex = 23;
            this.luedepartment_id.Tag = "2";
            // 
            // txtdeliveryman
            // 
            this.txtdeliveryman.EnterMoveNextControl = true;
            this.txtdeliveryman.Location = new System.Drawing.Point(850, 26);
            this.txtdeliveryman.Name = "txtdeliveryman";
            this.txtdeliveryman.Properties.MaxLength = 100;
            this.txtdeliveryman.Properties.ReadOnly = true;
            this.txtdeliveryman.Size = new System.Drawing.Size(139, 20);
            this.txtdeliveryman.TabIndex = 18;
            this.txtdeliveryman.Tag = "2";
            // 
            // lbllinkman
            // 
            this.lbllinkman.Location = new System.Drawing.Point(742, 27);
            this.lbllinkman.Name = "lbllinkman";
            this.lbllinkman.Size = new System.Drawing.Size(105, 17);
            this.lbllinkman.TabIndex = 241;
            this.lbllinkman.Tag = "t_contact_tel";
            this.lbllinkman.Text = "送貨人";
            this.lbllinkman.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lueseparate
            // 
            this.lueseparate.EditValue = "";
            this.lueseparate.Enabled = false;
            this.lueseparate.EnterMoveNextControl = true;
            this.lueseparate.Location = new System.Drawing.Point(612, 4);
            this.lueseparate.Name = "lueseparate";
            this.lueseparate.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.lueseparate.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.lueseparate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueseparate.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lueseparate.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.lueseparate.Properties.ImmediatePopup = true;
            this.lueseparate.Properties.NullText = "";
            this.lueseparate.Properties.PopupFormMinSize = new System.Drawing.Size(230, 0);
            this.lueseparate.Properties.PopupWidth = 130;
            this.lueseparate.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.lueseparate.Properties.ShowHeader = false;
            this.lueseparate.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueseparate.Size = new System.Drawing.Size(123, 20);
            this.lueseparate.TabIndex = 15;
            this.lueseparate.Tag = "2";
            // 
            // label16
            // 
            this.label16.ForeColor = System.Drawing.Color.Blue;
            this.label16.Location = new System.Drawing.Point(504, 6);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(105, 17);
            this.label16.TabIndex = 233;
            this.label16.Tag = "t_origin_id";
            this.label16.Text = "訂單來源";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // luevendor_id
            // 
            this.luevendor_id.EditValue = "";
            this.luevendor_id.Enabled = false;
            this.luevendor_id.EnterMoveNextControl = true;
            this.luevendor_id.Location = new System.Drawing.Point(94, 26);
            this.luevendor_id.Name = "luevendor_id";
            this.luevendor_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.luevendor_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luevendor_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luevendor_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luevendor_id.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 80, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 150, "name")});
            this.luevendor_id.Properties.DropDownRows = 15;
            this.luevendor_id.Properties.ImmediatePopup = true;
            this.luevendor_id.Properties.NullText = "";
            this.luevendor_id.Properties.PopupFormMinSize = new System.Drawing.Size(230, 0);
            this.luevendor_id.Properties.PopupWidth = 230;
            this.luevendor_id.Properties.ShowHeader = false;
            this.luevendor_id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luevendor_id.Size = new System.Drawing.Size(117, 20);
            this.luevendor_id.TabIndex = 2;
            this.luevendor_id.Tag = "2";
            this.luevendor_id.EditValueChanged += new System.EventHandler(this.luevendor_id_EditValueChanged);
            // 
            // label11
            // 
            this.label11.ForeColor = System.Drawing.Color.Blue;
            this.label11.Location = new System.Drawing.Point(218, 6);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(147, 17);
            this.label11.TabIndex = 98;
            this.label11.Tag = "t_order_date";
            this.label11.Text = "來料暫入庫日期";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // detir_date
            // 
            this.detir_date.EditValue = "";
            this.detir_date.Enabled = false;
            this.detir_date.EnterMoveNextControl = true;
            this.detir_date.Location = new System.Drawing.Point(367, 4);
            this.detir_date.Name = "detir_date";
            this.detir_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.detir_date.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.detir_date.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.detir_date.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.detir_date.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.detir_date.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detir_date.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.detir_date.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.detir_date.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.detir_date.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.detir_date.Properties.MaxLength = 10;
            this.detir_date.Size = new System.Drawing.Size(134, 20);
            this.detir_date.TabIndex = 1;
            this.detir_date.Tag = "2";
            // 
            // luestate
            // 
            this.luestate.EditValue = "";
            this.luestate.Enabled = false;
            this.luestate.EnterMoveNextControl = true;
            this.luestate.Location = new System.Drawing.Point(850, 4);
            this.luestate.Name = "luestate";
            this.luestate.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.luestate.Properties.AppearanceDisabled.Options.UseForeColor = true;
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
            this.luestate.Size = new System.Drawing.Size(139, 20);
            this.luestate.TabIndex = 43;
            this.luestate.Tag = "2";
            this.luestate.EditValueChanged += new System.EventHandler(this.luestate_EditValueChanged);
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(2, 122);
            this.gridControl1.MainView = this.dgvDetails;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cl_weight,
            this.cl_order_qty,
            this.cl_unit_code,
            this.cl_unit_code_sec,
            this.cl_goods_id,
            this.cl_mo_id,
            this.cl_qc_result,
            this.cl_qc_state,
            this.cl_location_id,
            this.cl_temp_qty,
            this.cl_m_receipt_qty,
            this.cl_fact_qty});
            this.gridControl1.Size = new System.Drawing.Size(994, 539);
            this.gridControl1.TabIndex = 41;
            this.gridControl1.Tag = "2";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvDetails});
            // 
            // dgvDetails
            // 
            this.dgvDetails.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDetails.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgvDetails.ColumnPanelRowHeight = 30;
            this.dgvDetails.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.po_id,
            this.mo_id,
            this.goods_id,
            this.goods_name,
            this.color,
            this.unit_code,
            this.s_qty,
            this.temp_qty,
            this.m_receipt_qty,
            this.fact_qty,
            this.sec_qty,
            this.sec_unit,
            this.location_id,
            this.qc_result,
            this.qc_state,
            this.remark,
            this.sell_order,
            this.id,
            this.sequence_id,
            this.po_ver,
            this.po_sequence_id,
            this.basic_unit,
            this.location,
            this.carton_code,
            this.price,
            this.total_sum,
            this.currency,
            this.exchange_rate,
            this.m_rate,
            this.s_date});
            this.dgvDetails.GridControl = this.gridControl1;
            this.dgvDetails.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.OptionsBehavior.Editable = false;
            this.dgvDetails.OptionsView.ColumnAutoWidth = false;
            this.dgvDetails.OptionsView.ShowGroupPanel = false;
            this.dgvDetails.PaintStyleName = "Style3D";
            this.dgvDetails.RowHeight = 25;
            this.dgvDetails.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.dgvDetails.ShownEditor += new System.EventHandler(this.dgvDetails_ShownEditor);
            this.dgvDetails.MouseDown += new System.Windows.Forms.MouseEventHandler(this.dgvDetails_MouseDown);
            this.dgvDetails.ValidatingEditor += new DevExpress.XtraEditors.Controls.BaseContainerValidateEditorEventHandler(this.dgvDetails_ValidatingEditor);
            // 
            // po_id
            // 
            this.po_id.Caption = "PO編號";
            this.po_id.FieldName = "po_id";
            this.po_id.Name = "po_id";
            this.po_id.OptionsColumn.AllowMove = false;
            this.po_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.po_id.OptionsColumn.ReadOnly = true;
            this.po_id.Tag = "t_po_id";
            this.po_id.Visible = true;
            this.po_id.VisibleIndex = 0;
            this.po_id.Width = 95;
            // 
            // mo_id
            // 
            this.mo_id.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.mo_id.AppearanceHeader.Options.UseForeColor = true;
            this.mo_id.Caption = "頁數";
            this.mo_id.ColumnEdit = this.cl_mo_id;
            this.mo_id.FieldName = "mo_id";
            this.mo_id.Name = "mo_id";
            this.mo_id.OptionsColumn.AllowMove = false;
            this.mo_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.mo_id.OptionsFilter.AllowAutoFilter = false;
            this.mo_id.OptionsFilter.AllowFilter = false;
            this.mo_id.Tag = "t_mo_id";
            this.mo_id.Visible = true;
            this.mo_id.VisibleIndex = 1;
            this.mo_id.Width = 91;
            // 
            // cl_mo_id
            // 
            this.cl_mo_id.AutoHeight = false;
            this.cl_mo_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cl_mo_id.MaxLength = 9;
            this.cl_mo_id.Name = "cl_mo_id";
            this.cl_mo_id.Leave += new System.EventHandler(this.cl_mo_id_Leave);
            // 
            // goods_id
            // 
            this.goods_id.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.goods_id.AppearanceHeader.Options.UseForeColor = true;
            this.goods_id.Caption = "貨品編號";
            this.goods_id.ColumnEdit = this.cl_goods_id;
            this.goods_id.FieldName = "goods_id";
            this.goods_id.MaxWidth = 180;
            this.goods_id.Name = "goods_id";
            this.goods_id.OptionsColumn.AllowMove = false;
            this.goods_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.goods_id.OptionsFilter.AllowAutoFilter = false;
            this.goods_id.OptionsFilter.AllowFilter = false;
            this.goods_id.Tag = "t_goods_id";
            this.goods_id.Visible = true;
            this.goods_id.VisibleIndex = 2;
            this.goods_id.Width = 173;
            // 
            // cl_goods_id
            // 
            this.cl_goods_id.AutoHeight = false;
            this.cl_goods_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cl_goods_id.MaxLength = 18;
            this.cl_goods_id.Name = "cl_goods_id";
            this.cl_goods_id.Leave += new System.EventHandler(this.cl_goods_id_Leave);
            // 
            // goods_name
            // 
            this.goods_name.Caption = "貨品名稱";
            this.goods_name.FieldName = "goods_name";
            this.goods_name.MaxWidth = 250;
            this.goods_name.Name = "goods_name";
            this.goods_name.OptionsColumn.AllowMove = false;
            this.goods_name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.goods_name.OptionsColumn.ReadOnly = true;
            this.goods_name.OptionsFilter.AllowAutoFilter = false;
            this.goods_name.OptionsFilter.AllowFilter = false;
            this.goods_name.Tag = "t_goods_name";
            this.goods_name.Visible = true;
            this.goods_name.VisibleIndex = 3;
            this.goods_name.Width = 189;
            // 
            // color
            // 
            this.color.Caption = "顏色";
            this.color.FieldName = "color";
            this.color.Name = "color";
            this.color.OptionsColumn.AllowMove = false;
            this.color.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.color.OptionsColumn.ReadOnly = true;
            this.color.OptionsFilter.AllowAutoFilter = false;
            this.color.OptionsFilter.AllowFilter = false;
            this.color.Tag = "t_color";
            this.color.Visible = true;
            this.color.VisibleIndex = 4;
            this.color.Width = 78;
            // 
            // unit_code
            // 
            this.unit_code.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.unit_code.AppearanceHeader.Options.UseForeColor = true;
            this.unit_code.Caption = "單位";
            this.unit_code.ColumnEdit = this.cl_unit_code;
            this.unit_code.FieldName = "unit_code";
            this.unit_code.Name = "unit_code";
            this.unit_code.OptionsColumn.AllowMove = false;
            this.unit_code.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.unit_code.OptionsFilter.AllowAutoFilter = false;
            this.unit_code.OptionsFilter.AllowFilter = false;
            this.unit_code.Tag = "t_unit";
            this.unit_code.Visible = true;
            this.unit_code.VisibleIndex = 5;
            this.unit_code.Width = 44;
            // 
            // cl_unit_code
            // 
            this.cl_unit_code.AutoHeight = false;
            this.cl_unit_code.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cl_unit_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cl_unit_code.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id")});
            this.cl_unit_code.DropDownRows = 10;
            this.cl_unit_code.Name = "cl_unit_code";
            this.cl_unit_code.NullText = "";
            this.cl_unit_code.PopupWidth = 30;
            this.cl_unit_code.ShowHeader = false;
            this.cl_unit_code.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // s_qty
            // 
            this.s_qty.Caption = "訂單數量";
            this.s_qty.ColumnEdit = this.cl_order_qty;
            this.s_qty.DisplayFormat.FormatString = "n2";
            this.s_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.s_qty.FieldName = "s_qty";
            this.s_qty.Name = "s_qty";
            this.s_qty.OptionsColumn.AllowMove = false;
            this.s_qty.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.s_qty.OptionsColumn.ReadOnly = true;
            this.s_qty.OptionsFilter.AllowAutoFilter = false;
            this.s_qty.OptionsFilter.AllowFilter = false;
            this.s_qty.Tag = "t_order_qty";
            this.s_qty.Visible = true;
            this.s_qty.VisibleIndex = 6;
            this.s_qty.Width = 86;
            // 
            // cl_order_qty
            // 
            this.cl_order_qty.AutoHeight = false;
            this.cl_order_qty.DisplayFormat.FormatString = "n0";
            this.cl_order_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_order_qty.EditFormat.FormatString = "n0";
            this.cl_order_qty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_order_qty.Mask.EditMask = "n0";
            this.cl_order_qty.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.cl_order_qty.Name = "cl_order_qty";
            this.cl_order_qty.NullText = "0";
            this.cl_order_qty.NullValuePrompt = "0";
            // 
            // temp_qty
            // 
            this.temp_qty.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.temp_qty.AppearanceHeader.Options.UseForeColor = true;
            this.temp_qty.Caption = "暫收數量";
            this.temp_qty.ColumnEdit = this.cl_temp_qty;
            this.temp_qty.DisplayFormat.FormatString = "n2";
            this.temp_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.temp_qty.FieldName = "temp_qty";
            this.temp_qty.Name = "temp_qty";
            this.temp_qty.OptionsColumn.AllowMove = false;
            this.temp_qty.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.temp_qty.OptionsFilter.AllowAutoFilter = false;
            this.temp_qty.OptionsFilter.AllowFilter = false;
            this.temp_qty.Tag = "t_receipt_qty";
            this.temp_qty.Visible = true;
            this.temp_qty.VisibleIndex = 7;
            this.temp_qty.Width = 81;
            // 
            // cl_temp_qty
            // 
            this.cl_temp_qty.AutoHeight = false;
            this.cl_temp_qty.DisplayFormat.FormatString = "n2";
            this.cl_temp_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_temp_qty.EditFormat.FormatString = "n2";
            this.cl_temp_qty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_temp_qty.Mask.EditMask = "n2";
            this.cl_temp_qty.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.cl_temp_qty.Name = "cl_temp_qty";
            this.cl_temp_qty.Leave += new System.EventHandler(this.cl_temp_qty_Leave);
            // 
            // m_receipt_qty
            // 
            this.m_receipt_qty.Caption = "多收貨數量";
            this.m_receipt_qty.ColumnEdit = this.cl_m_receipt_qty;
            this.m_receipt_qty.DisplayFormat.FormatString = "n2";
            this.m_receipt_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_receipt_qty.FieldName = "m_receipt_qty";
            this.m_receipt_qty.Name = "m_receipt_qty";
            this.m_receipt_qty.OptionsColumn.AllowMove = false;
            this.m_receipt_qty.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.m_receipt_qty.OptionsFilter.AllowAutoFilter = false;
            this.m_receipt_qty.OptionsFilter.AllowFilter = false;
            this.m_receipt_qty.Tag = "t_excess receipt_qty";
            this.m_receipt_qty.Visible = true;
            this.m_receipt_qty.VisibleIndex = 8;
            this.m_receipt_qty.Width = 71;
            // 
            // cl_m_receipt_qty
            // 
            this.cl_m_receipt_qty.AutoHeight = false;
            this.cl_m_receipt_qty.DisplayFormat.FormatString = "n2";
            this.cl_m_receipt_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_m_receipt_qty.EditFormat.FormatString = "n2";
            this.cl_m_receipt_qty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_m_receipt_qty.Mask.EditMask = "n";
            this.cl_m_receipt_qty.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.cl_m_receipt_qty.Name = "cl_m_receipt_qty";
            this.cl_m_receipt_qty.Leave += new System.EventHandler(this.cl_m_receipt_qty_Leave);
            // 
            // fact_qty
            // 
            this.fact_qty.Caption = "實際收貨數量";
            this.fact_qty.ColumnEdit = this.cl_fact_qty;
            this.fact_qty.DisplayFormat.FormatString = "n2";
            this.fact_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.fact_qty.FieldName = "fact_qty";
            this.fact_qty.Name = "fact_qty";
            this.fact_qty.OptionsColumn.AllowMove = false;
            this.fact_qty.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.fact_qty.OptionsColumn.ReadOnly = true;
            this.fact_qty.OptionsFilter.AllowAutoFilter = false;
            this.fact_qty.OptionsFilter.AllowFilter = false;
            this.fact_qty.Tag = "t_factor_receipt_qty";
            this.fact_qty.Visible = true;
            this.fact_qty.VisibleIndex = 9;
            this.fact_qty.Width = 80;
            // 
            // cl_fact_qty
            // 
            this.cl_fact_qty.AutoHeight = false;
            this.cl_fact_qty.DisplayFormat.FormatString = "n2";
            this.cl_fact_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_fact_qty.EditFormat.FormatString = "n2";
            this.cl_fact_qty.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_fact_qty.Name = "cl_fact_qty";
            // 
            // sec_qty
            // 
            this.sec_qty.Caption = "重量";
            this.sec_qty.ColumnEdit = this.cl_weight;
            this.sec_qty.DisplayFormat.FormatString = "n2";
            this.sec_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.sec_qty.FieldName = "sec_qty";
            this.sec_qty.Name = "sec_qty";
            this.sec_qty.OptionsColumn.AllowMove = false;
            this.sec_qty.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.sec_qty.OptionsFilter.AllowAutoFilter = false;
            this.sec_qty.OptionsFilter.AllowFilter = false;
            this.sec_qty.Tag = "t_weight";
            this.sec_qty.Visible = true;
            this.sec_qty.VisibleIndex = 10;
            this.sec_qty.Width = 68;
            // 
            // cl_weight
            // 
            this.cl_weight.AutoHeight = false;
            this.cl_weight.DisplayFormat.FormatString = "n2";
            this.cl_weight.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_weight.EditFormat.FormatString = "n2";
            this.cl_weight.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.cl_weight.Mask.EditMask = "n2";
            this.cl_weight.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.cl_weight.Name = "cl_weight";
            this.cl_weight.NullText = "0.00";
            // 
            // sec_unit
            // 
            this.sec_unit.Caption = "重量單位";
            this.sec_unit.ColumnEdit = this.cl_unit_code_sec;
            this.sec_unit.FieldName = "sec_unit";
            this.sec_unit.Name = "sec_unit";
            this.sec_unit.OptionsColumn.AllowMove = false;
            this.sec_unit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.sec_unit.OptionsFilter.AllowAutoFilter = false;
            this.sec_unit.OptionsFilter.AllowFilter = false;
            this.sec_unit.Tag = "t_sec_unit";
            this.sec_unit.Visible = true;
            this.sec_unit.VisibleIndex = 11;
            this.sec_unit.Width = 63;
            // 
            // cl_unit_code_sec
            // 
            this.cl_unit_code_sec.AutoHeight = false;
            this.cl_unit_code_sec.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cl_unit_code_sec.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cl_unit_code_sec.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id")});
            this.cl_unit_code_sec.MaxLength = 3;
            this.cl_unit_code_sec.Name = "cl_unit_code_sec";
            this.cl_unit_code_sec.NullText = "";
            this.cl_unit_code_sec.ShowHeader = false;
            this.cl_unit_code_sec.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // location_id
            // 
            this.location_id.AppearanceHeader.ForeColor = System.Drawing.Color.Blue;
            this.location_id.AppearanceHeader.Options.UseForeColor = true;
            this.location_id.Caption = "倉庫";
            this.location_id.ColumnEdit = this.cl_location_id;
            this.location_id.FieldName = "location_id";
            this.location_id.Name = "location_id";
            this.location_id.OptionsColumn.AllowMove = false;
            this.location_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.location_id.OptionsFilter.AllowAutoFilter = false;
            this.location_id.OptionsFilter.AllowFilter = false;
            this.location_id.Tag = "t_location";
            this.location_id.Visible = true;
            this.location_id.VisibleIndex = 12;
            this.location_id.Width = 60;
            // 
            // cl_location_id
            // 
            this.cl_location_id.AutoHeight = false;
            this.cl_location_id.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cl_location_id.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 70, "name")});
            this.cl_location_id.DropDownRows = 20;
            this.cl_location_id.ImmediatePopup = true;
            this.cl_location_id.MaxLength = 4;
            this.cl_location_id.Name = "cl_location_id";
            this.cl_location_id.NullText = "";
            this.cl_location_id.PopupWidth = 100;
            this.cl_location_id.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.cl_location_id.ShowHeader = false;
            this.cl_location_id.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.cl_location_id.EditValueChanged += new System.EventHandler(this.cl_location_id_EditValueChanged);
            // 
            // qc_result
            // 
            this.qc_result.Caption = "QC結果";
            this.qc_result.ColumnEdit = this.cl_qc_result;
            this.qc_result.FieldName = "qc_result";
            this.qc_result.Name = "qc_result";
            this.qc_result.OptionsColumn.AllowMove = false;
            this.qc_result.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.qc_result.OptionsColumn.ReadOnly = true;
            this.qc_result.OptionsFilter.AllowAutoFilter = false;
            this.qc_result.OptionsFilter.AllowFilter = false;
            this.qc_result.Tag = "t_qc_result";
            this.qc_result.Visible = true;
            this.qc_result.VisibleIndex = 13;
            // 
            // cl_qc_result
            // 
            this.cl_qc_result.AutoHeight = false;
            this.cl_qc_result.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cl_qc_result.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 70, "name")});
            this.cl_qc_result.Name = "cl_qc_result";
            this.cl_qc_result.NullText = "";
            this.cl_qc_result.PopupWidth = 100;
            this.cl_qc_result.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // qc_state
            // 
            this.qc_state.Caption = "QC狀態";
            this.qc_state.ColumnEdit = this.cl_qc_state;
            this.qc_state.FieldName = "qc_state";
            this.qc_state.Name = "qc_state";
            this.qc_state.OptionsColumn.AllowMove = false;
            this.qc_state.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.qc_state.OptionsColumn.ReadOnly = true;
            this.qc_state.OptionsFilter.AllowAutoFilter = false;
            this.qc_state.OptionsFilter.AllowFilter = false;
            this.qc_state.Tag = "t_qc_status";
            this.qc_state.Visible = true;
            this.qc_state.VisibleIndex = 14;
            // 
            // cl_qc_state
            // 
            this.cl_qc_state.AutoHeight = false;
            this.cl_qc_state.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cl_qc_state.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 70, "name")});
            this.cl_qc_state.Name = "cl_qc_state";
            this.cl_qc_state.NullText = "";
            this.cl_qc_state.PopupWidth = 100;
            this.cl_qc_state.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // remark
            // 
            this.remark.Caption = "備註";
            this.remark.FieldName = "remark";
            this.remark.Name = "remark";
            this.remark.OptionsColumn.AllowMove = false;
            this.remark.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.remark.OptionsFilter.AllowAutoFilter = false;
            this.remark.OptionsFilter.AllowFilter = false;
            this.remark.Tag = "t_remark";
            this.remark.Visible = true;
            this.remark.VisibleIndex = 15;
            this.remark.Width = 100;
            // 
            // sell_order
            // 
            this.sell_order.Caption = "銷售訂單編號";
            this.sell_order.FieldName = "sell_order";
            this.sell_order.Name = "sell_order";
            this.sell_order.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.sell_order.OptionsColumn.AllowMove = false;
            this.sell_order.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.sell_order.OptionsColumn.ReadOnly = true;
            this.sell_order.OptionsFilter.AllowAutoFilter = false;
            this.sell_order.OptionsFilter.AllowFilter = false;
            this.sell_order.Tag = "t_sell_order";
            this.sell_order.Visible = true;
            this.sell_order.VisibleIndex = 16;
            // 
            // id
            // 
            this.id.Caption = "單據編號";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.Tag = "t_id";
            // 
            // sequence_id
            // 
            this.sequence_id.Caption = "序號";
            this.sequence_id.FieldName = "sequence_id";
            this.sequence_id.Name = "sequence_id";
            this.sequence_id.Tag = "t_sequence_id";
            // 
            // po_ver
            // 
            this.po_ver.Caption = "po_ver";
            this.po_ver.FieldName = "po_ver";
            this.po_ver.Name = "po_ver";
            // 
            // po_sequence_id
            // 
            this.po_sequence_id.Caption = "po_sequence_id";
            this.po_sequence_id.FieldName = "po_sequence_id";
            this.po_sequence_id.Name = "po_sequence_id";
            // 
            // basic_unit
            // 
            this.basic_unit.Caption = "basic_unit";
            this.basic_unit.FieldName = "basic_unit";
            this.basic_unit.Name = "basic_unit";
            // 
            // location
            // 
            this.location.Caption = "location";
            this.location.FieldName = "location";
            this.location.Name = "location";
            // 
            // carton_code
            // 
            this.carton_code.Caption = "carton_code";
            this.carton_code.FieldName = "carton_code";
            this.carton_code.Name = "carton_code";
            // 
            // price
            // 
            this.price.Caption = "price";
            this.price.DisplayFormat.FormatString = "n2";
            this.price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.price.FieldName = "price";
            this.price.Name = "price";
            // 
            // total_sum
            // 
            this.total_sum.Caption = "total_sum";
            this.total_sum.DisplayFormat.FormatString = "n2";
            this.total_sum.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.total_sum.FieldName = "total_sum";
            this.total_sum.Name = "total_sum";
            // 
            // currency
            // 
            this.currency.Caption = "currency";
            this.currency.FieldName = "currency";
            this.currency.Name = "currency";
            // 
            // exchange_rate
            // 
            this.exchange_rate.Caption = "exchange_rate";
            this.exchange_rate.DisplayFormat.FormatString = "n2";
            this.exchange_rate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.exchange_rate.FieldName = "exchange_rate";
            this.exchange_rate.Name = "exchange_rate";
            // 
            // m_rate
            // 
            this.m_rate.Caption = "m_rate";
            this.m_rate.DisplayFormat.FormatString = "n2";
            this.m_rate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.m_rate.FieldName = "m_rate";
            this.m_rate.Name = "m_rate";
            // 
            // s_date
            // 
            this.s_date.Caption = "s_date";
            this.s_date.FieldName = "s_date";
            this.s_date.Name = "s_date";
            // 
            // lblAmtim
            // 
            this.lblAmtim.Location = new System.Drawing.Point(742, 97);
            this.lblAmtim.Name = "lblAmtim";
            this.lblAmtim.Size = new System.Drawing.Size(105, 17);
            this.lblAmtim.TabIndex = 40;
            this.lblAmtim.Tag = "t_update_date";
            this.lblAmtim.Text = "修改日期";
            this.lblAmtim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmusr
            // 
            this.lblAmusr.Location = new System.Drawing.Point(504, 96);
            this.lblAmusr.Name = "lblAmusr";
            this.lblAmusr.Size = new System.Drawing.Size(105, 17);
            this.lblAmusr.TabIndex = 39;
            this.lblAmusr.Tag = "t_update_by";
            this.lblAmusr.Text = "修改人";
            this.lblAmusr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCrtim
            // 
            this.lblCrtim.Location = new System.Drawing.Point(742, 75);
            this.lblCrtim.Name = "lblCrtim";
            this.lblCrtim.Size = new System.Drawing.Size(105, 17);
            this.lblCrtim.TabIndex = 38;
            this.lblCrtim.Tag = "t_create_date";
            this.lblCrtim.Text = "建檔日期";
            this.lblCrtim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCrusr
            // 
            this.lblCrusr.Location = new System.Drawing.Point(504, 75);
            this.lblCrusr.Name = "lblCrusr";
            this.lblCrusr.Size = new System.Drawing.Size(105, 17);
            this.lblCrusr.TabIndex = 37;
            this.lblCrusr.Tag = "t_create_by";
            this.lblCrusr.Text = "建檔人";
            this.lblCrusr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtupdate_date
            // 
            this.txtupdate_date.Enabled = false;
            this.txtupdate_date.Location = new System.Drawing.Point(850, 94);
            this.txtupdate_date.Name = "txtupdate_date";
            this.txtupdate_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtupdate_date.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtupdate_date.Properties.ReadOnly = true;
            this.txtupdate_date.Size = new System.Drawing.Size(139, 20);
            this.txtupdate_date.TabIndex = 39;
            this.txtupdate_date.Tag = "2";
            // 
            // txtupdate_by
            // 
            this.txtupdate_by.Enabled = false;
            this.txtupdate_by.Location = new System.Drawing.Point(612, 94);
            this.txtupdate_by.Name = "txtupdate_by";
            this.txtupdate_by.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtupdate_by.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtupdate_by.Properties.ReadOnly = true;
            this.txtupdate_by.Size = new System.Drawing.Size(123, 20);
            this.txtupdate_by.TabIndex = 37;
            this.txtupdate_by.Tag = "2";
            // 
            // txtcreate_date
            // 
            this.txtcreate_date.Enabled = false;
            this.txtcreate_date.Location = new System.Drawing.Point(850, 72);
            this.txtcreate_date.Name = "txtcreate_date";
            this.txtcreate_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtcreate_date.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtcreate_date.Properties.ReadOnly = true;
            this.txtcreate_date.Size = new System.Drawing.Size(139, 20);
            this.txtcreate_date.TabIndex = 36;
            this.txtcreate_date.Tag = "2";
            // 
            // txtcreate_by
            // 
            this.txtcreate_by.Enabled = false;
            this.txtcreate_by.Location = new System.Drawing.Point(612, 72);
            this.txtcreate_by.Name = "txtcreate_by";
            this.txtcreate_by.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtcreate_by.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtcreate_by.Properties.ReadOnly = true;
            this.txtcreate_by.Size = new System.Drawing.Size(123, 20);
            this.txtcreate_by.TabIndex = 35;
            this.txtcreate_by.Tag = "2";
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(3, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 17);
            this.label9.TabIndex = 32;
            this.label9.Tag = "t_remark";
            this.label9.Text = "備 註";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtremark
            // 
            this.txtremark.Location = new System.Drawing.Point(94, 72);
            this.txtremark.Name = "txtremark";
            this.txtremark.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtremark.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtremark.Properties.LinesCount = 3;
            this.txtremark.Properties.ReadOnly = true;
            this.txtremark.Size = new System.Drawing.Size(407, 42);
            this.txtremark.TabIndex = 34;
            this.txtremark.Tag = "2";
            // 
            // lbldeliver_id
            // 
            this.lbldeliver_id.Location = new System.Drawing.Point(3, 49);
            this.lbldeliver_id.Name = "lbldeliver_id";
            this.lbldeliver_id.Size = new System.Drawing.Size(88, 17);
            this.lbldeliver_id.TabIndex = 17;
            this.lbldeliver_id.Tag = "t_old_bill_id";
            this.lbldeliver_id.Text = "原送貨單號";
            this.lbldeliver_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtdeliver_id
            // 
            this.txtdeliver_id.EditValue = "";
            this.txtdeliver_id.EnterMoveNextControl = true;
            this.txtdeliver_id.Location = new System.Drawing.Point(94, 49);
            this.txtdeliver_id.Name = "txtdeliver_id";
            this.txtdeliver_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtdeliver_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtdeliver_id.Properties.MaxLength = 30;
            this.txtdeliver_id.Properties.ReadOnly = true;
            this.txtdeliver_id.Size = new System.Drawing.Size(117, 20);
            this.txtdeliver_id.TabIndex = 4;
            this.txtdeliver_id.Tag = "2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(504, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 17);
            this.label4.TabIndex = 15;
            this.label4.Tag = "t_contact_by";
            this.label4.Text = "收貨人";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtconsignee
            // 
            this.txtconsignee.EnterMoveNextControl = true;
            this.txtconsignee.Location = new System.Drawing.Point(612, 26);
            this.txtconsignee.Name = "txtconsignee";
            this.txtconsignee.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtconsignee.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtconsignee.Properties.ReadOnly = true;
            this.txtconsignee.Size = new System.Drawing.Size(123, 20);
            this.txtconsignee.TabIndex = 16;
            this.txtconsignee.Tag = "2";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(742, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 17);
            this.label3.TabIndex = 13;
            this.label3.Tag = "t_state";
            this.label3.Text = "狀態";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtvendor
            // 
            this.txtvendor.EditValue = "";
            this.txtvendor.Enabled = false;
            this.txtvendor.EnterMoveNextControl = true;
            this.txtvendor.Location = new System.Drawing.Point(211, 26);
            this.txtvendor.Name = "txtvendor";
            this.txtvendor.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtvendor.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtvendor.Properties.ReadOnly = true;
            this.txtvendor.Size = new System.Drawing.Size(290, 20);
            this.txtvendor.TabIndex = 3;
            this.txtvendor.Tag = "2";
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(3, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 7;
            this.label1.Tag = "t_vendor_id";
            this.label1.Text = "供應商編號";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(3, 6);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(88, 17);
            this.lblID.TabIndex = 5;
            this.lblID.Tag = "t_id";
            this.lblID.Text = "編號";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.EnterMoveNextControl = true;
            this.txtID.Location = new System.Drawing.Point(94, 4);
            this.txtID.Name = "txtID";
            this.txtID.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtID.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtID.Size = new System.Drawing.Size(117, 20);
            this.txtID.TabIndex = 0;
            this.txtID.Tag = "";
            // 
            // tabPage2
            // 
            this.tabPage2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabPage2.Controls.Add(this.dgvFind);
            this.tabPage2.Controls.Add(this.label39);
            this.tabPage2.Controls.Add(this.label38);
            this.tabPage2.Controls.Add(this.label37);
            this.tabPage2.Controls.Add(this.label36);
            this.tabPage2.Controls.Add(this.label35);
            this.tabPage2.Controls.Add(this.txtmo_id2);
            this.tabPage2.Controls.Add(this.luedept_id2);
            this.tabPage2.Controls.Add(this.luevendor_id2);
            this.tabPage2.Controls.Add(this.dteir_date2);
            this.tabPage2.Controls.Add(this.txtid2);
            this.tabPage2.Controls.Add(this.txtmo_id1);
            this.tabPage2.Controls.Add(this.label34);
            this.tabPage2.Controls.Add(this.label33);
            this.tabPage2.Controls.Add(this.luedept_id1);
            this.tabPage2.Controls.Add(this.luevendor_id1);
            this.tabPage2.Controls.Add(this.label32);
            this.tabPage2.Controls.Add(this.label31);
            this.tabPage2.Controls.Add(this.dteir_date1);
            this.tabPage2.Controls.Add(this.label30);
            this.tabPage2.Controls.Add(this.txtid1);
            this.tabPage2.Controls.Add(this.BTNFIND);
            this.tabPage2.Font = new System.Drawing.Font("Tahoma", 9F);
            this.tabPage2.ImageIndex = 0;
            this.tabPage2.Location = new System.Drawing.Point(4, 26);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1001, 670);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Tag = "t_search";
            this.tabPage2.Text = "查詢";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dgvFind
            // 
            this.dgvFind.AllowUserToAddRows = false;
            this.dgvFind.AllowUserToDeleteRows = false;
            this.dgvFind.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvFind.ColumnHeadersHeight = 35;
            this.dgvFind.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id1,
            this.ir_date1,
            this.vendor_id1,
            this.vendor1,
            this.department_id1,
            this.mo_id1,
            this.goods_id1,
            this.goods_name1,
            this.s_qty1,
            this.unit_code1,
            this.receipt_qty1,
            this.remark1});
            this.dgvFind.Location = new System.Drawing.Point(4, 153);
            this.dgvFind.Name = "dgvFind";
            this.dgvFind.ReadOnly = true;
            this.dgvFind.RowTemplate.Height = 24;
            this.dgvFind.ShowCellToolTips = false;
            this.dgvFind.Size = new System.Drawing.Size(991, 507);
            this.dgvFind.TabIndex = 262;
            this.dgvFind.SelectionChanged += new System.EventHandler(this.dgvFind_SelectionChanged);
            // 
            // id1
            // 
            this.id1.DataPropertyName = "id";
            this.id1.HeaderText = "編號";
            this.id1.Name = "id1";
            this.id1.ReadOnly = true;
            this.id1.ToolTipText = "t_id";
            // 
            // ir_date1
            // 
            this.ir_date1.DataPropertyName = "ir_date";
            this.ir_date1.HeaderText = "來料日期";
            this.ir_date1.Name = "ir_date1";
            this.ir_date1.ReadOnly = true;
            this.ir_date1.ToolTipText = "t_ir_date";
            this.ir_date1.Width = 90;
            // 
            // vendor_id1
            // 
            this.vendor_id1.DataPropertyName = "vendor_id";
            this.vendor_id1.HeaderText = "供應商編號";
            this.vendor_id1.Name = "vendor_id1";
            this.vendor_id1.ReadOnly = true;
            this.vendor_id1.ToolTipText = "t_vendor_id";
            this.vendor_id1.Width = 95;
            // 
            // vendor1
            // 
            this.vendor1.DataPropertyName = "vendor";
            this.vendor1.HeaderText = "供應商名稱";
            this.vendor1.Name = "vendor1";
            this.vendor1.ReadOnly = true;
            this.vendor1.ToolTipText = "t_vendor_name";
            this.vendor1.Width = 120;
            // 
            // department_id1
            // 
            this.department_id1.DataPropertyName = "department_id";
            this.department_id1.HeaderText = "部門";
            this.department_id1.Name = "department_id1";
            this.department_id1.ReadOnly = true;
            this.department_id1.ToolTipText = "t_dept_id";
            this.department_id1.Width = 80;
            // 
            // mo_id1
            // 
            this.mo_id1.DataPropertyName = "mo_id";
            this.mo_id1.HeaderText = "頁數";
            this.mo_id1.Name = "mo_id1";
            this.mo_id1.ReadOnly = true;
            this.mo_id1.ToolTipText = "t_mo_id";
            this.mo_id1.Width = 90;
            // 
            // goods_id1
            // 
            this.goods_id1.DataPropertyName = "goods_id";
            this.goods_id1.HeaderText = "物料編號";
            this.goods_id1.Name = "goods_id1";
            this.goods_id1.ReadOnly = true;
            this.goods_id1.ToolTipText = "t_goods_id";
            // 
            // goods_name1
            // 
            this.goods_name1.DataPropertyName = "goods_name";
            this.goods_name1.HeaderText = "物料名稱";
            this.goods_name1.Name = "goods_name1";
            this.goods_name1.ReadOnly = true;
            this.goods_name1.ToolTipText = "t_goods_name";
            this.goods_name1.Width = 80;
            // 
            // s_qty1
            // 
            this.s_qty1.DataPropertyName = "s_qty";
            dataGridViewCellStyle1.Format = "N2";
            dataGridViewCellStyle1.NullValue = null;
            this.s_qty1.DefaultCellStyle = dataGridViewCellStyle1;
            this.s_qty1.HeaderText = "訂單數量";
            this.s_qty1.Name = "s_qty1";
            this.s_qty1.ReadOnly = true;
            this.s_qty1.ToolTipText = "t_order_qty";
            // 
            // unit_code1
            // 
            this.unit_code1.DataPropertyName = "unit_code";
            this.unit_code1.HeaderText = "單位";
            this.unit_code1.Name = "unit_code1";
            this.unit_code1.ReadOnly = true;
            this.unit_code1.ToolTipText = "t_unit";
            this.unit_code1.Width = 60;
            // 
            // receipt_qty1
            // 
            this.receipt_qty1.DataPropertyName = "temp_qty";
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.receipt_qty1.DefaultCellStyle = dataGridViewCellStyle2;
            this.receipt_qty1.HeaderText = "收貨數量";
            this.receipt_qty1.Name = "receipt_qty1";
            this.receipt_qty1.ReadOnly = true;
            this.receipt_qty1.ToolTipText = "t_receipt_qty";
            this.receipt_qty1.Width = 90;
            // 
            // remark1
            // 
            this.remark1.DataPropertyName = "remark";
            this.remark1.HeaderText = "備註";
            this.remark1.Name = "remark1";
            this.remark1.ReadOnly = true;
            this.remark1.ToolTipText = "t_remark";
            this.remark1.Width = 150;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(272, 119);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(16, 14);
            this.label39.TabIndex = 261;
            this.label39.Tag = "";
            this.label39.Text = "~";
            this.label39.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(272, 90);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(16, 14);
            this.label38.TabIndex = 260;
            this.label38.Tag = "";
            this.label38.Text = "~";
            this.label38.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(272, 65);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(16, 14);
            this.label37.TabIndex = 259;
            this.label37.Tag = "";
            this.label37.Text = "~";
            this.label37.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(272, 41);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(16, 14);
            this.label36.TabIndex = 258;
            this.label36.Tag = "";
            this.label36.Text = "~";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Location = new System.Drawing.Point(272, 12);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(16, 14);
            this.label35.TabIndex = 257;
            this.label35.Tag = "";
            this.label35.Text = "~";
            this.label35.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtmo_id2
            // 
            this.txtmo_id2.EditValue = "";
            this.txtmo_id2.EnterMoveNextControl = true;
            this.txtmo_id2.Location = new System.Drawing.Point(299, 116);
            this.txtmo_id2.Name = "txtmo_id2";
            this.txtmo_id2.Properties.MaxLength = 9;
            this.txtmo_id2.Size = new System.Drawing.Size(139, 20);
            this.txtmo_id2.TabIndex = 256;
            this.txtmo_id2.Tag = "2";
            // 
            // luedept_id2
            // 
            this.luedept_id2.EditValue = "";
            this.luedept_id2.EnterMoveNextControl = true;
            this.luedept_id2.Location = new System.Drawing.Point(299, 89);
            this.luedept_id2.Name = "luedept_id2";
            this.luedept_id2.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.luedept_id2.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luedept_id2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luedept_id2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luedept_id2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 80, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 150, "name")});
            this.luedept_id2.Properties.DropDownRows = 15;
            this.luedept_id2.Properties.ImmediatePopup = true;
            this.luedept_id2.Properties.NullText = "";
            this.luedept_id2.Properties.PopupFormMinSize = new System.Drawing.Size(230, 0);
            this.luedept_id2.Properties.PopupWidth = 230;
            this.luedept_id2.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.luedept_id2.Properties.ShowHeader = false;
            this.luedept_id2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luedept_id2.Size = new System.Drawing.Size(139, 20);
            this.luedept_id2.TabIndex = 255;
            this.luedept_id2.Tag = "2";
            // 
            // luevendor_id2
            // 
            this.luevendor_id2.EditValue = "";
            this.luevendor_id2.EnterMoveNextControl = true;
            this.luevendor_id2.Location = new System.Drawing.Point(299, 62);
            this.luevendor_id2.Name = "luevendor_id2";
            this.luevendor_id2.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.luevendor_id2.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luevendor_id2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luevendor_id2.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luevendor_id2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 80, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 150, "name")});
            this.luevendor_id2.Properties.DropDownRows = 15;
            this.luevendor_id2.Properties.ImmediatePopup = true;
            this.luevendor_id2.Properties.NullText = "";
            this.luevendor_id2.Properties.PopupFormMinSize = new System.Drawing.Size(230, 0);
            this.luevendor_id2.Properties.PopupWidth = 230;
            this.luevendor_id2.Properties.ShowHeader = false;
            this.luevendor_id2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luevendor_id2.Size = new System.Drawing.Size(139, 20);
            this.luevendor_id2.TabIndex = 254;
            this.luevendor_id2.Tag = "2";
            // 
            // dteir_date2
            // 
            this.dteir_date2.EditValue = "";
            this.dteir_date2.EnterMoveNextControl = true;
            this.dteir_date2.Location = new System.Drawing.Point(299, 36);
            this.dteir_date2.Name = "dteir_date2";
            this.dteir_date2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteir_date2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteir_date2.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dteir_date2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteir_date2.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.dteir_date2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteir_date2.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.dteir_date2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteir_date2.Properties.MaxLength = 10;
            this.dteir_date2.Size = new System.Drawing.Size(139, 20);
            this.dteir_date2.TabIndex = 253;
            this.dteir_date2.Tag = "2";
            // 
            // txtid2
            // 
            this.txtid2.EnterMoveNextControl = true;
            this.txtid2.Location = new System.Drawing.Point(299, 10);
            this.txtid2.Name = "txtid2";
            this.txtid2.Properties.MaxLength = 20;
            this.txtid2.Size = new System.Drawing.Size(139, 20);
            this.txtid2.TabIndex = 252;
            this.txtid2.Tag = "2";
            // 
            // txtmo_id1
            // 
            this.txtmo_id1.EditValue = "";
            this.txtmo_id1.EnterMoveNextControl = true;
            this.txtmo_id1.Location = new System.Drawing.Point(121, 116);
            this.txtmo_id1.Name = "txtmo_id1";
            this.txtmo_id1.Properties.MaxLength = 9;
            this.txtmo_id1.Size = new System.Drawing.Size(139, 20);
            this.txtmo_id1.TabIndex = 251;
            this.txtmo_id1.Tag = "2";
            this.txtmo_id1.Leave += new System.EventHandler(this.txtmo_id1_Leave);
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(25, 116);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(94, 17);
            this.label34.TabIndex = 250;
            this.label34.Tag = "t_mo_id";
            this.label34.Text = "頁數";
            this.label34.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label33
            // 
            this.label33.Location = new System.Drawing.Point(25, 90);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(94, 17);
            this.label33.TabIndex = 249;
            this.label33.Tag = "t_dept_id";
            this.label33.Text = "部門";
            this.label33.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // luedept_id1
            // 
            this.luedept_id1.EditValue = "";
            this.luedept_id1.EnterMoveNextControl = true;
            this.luedept_id1.Location = new System.Drawing.Point(121, 89);
            this.luedept_id1.Name = "luedept_id1";
            this.luedept_id1.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.luedept_id1.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luedept_id1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luedept_id1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luedept_id1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 80, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 150, "name")});
            this.luedept_id1.Properties.DropDownRows = 15;
            this.luedept_id1.Properties.ImmediatePopup = true;
            this.luedept_id1.Properties.NullText = "";
            this.luedept_id1.Properties.PopupFormMinSize = new System.Drawing.Size(230, 0);
            this.luedept_id1.Properties.PopupWidth = 230;
            this.luedept_id1.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.luedept_id1.Properties.ShowHeader = false;
            this.luedept_id1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luedept_id1.Size = new System.Drawing.Size(139, 20);
            this.luedept_id1.TabIndex = 248;
            this.luedept_id1.Tag = "2";
            this.luedept_id1.Leave += new System.EventHandler(this.luedept_id1_Leave);
            // 
            // luevendor_id1
            // 
            this.luevendor_id1.EditValue = "";
            this.luevendor_id1.EnterMoveNextControl = true;
            this.luevendor_id1.Location = new System.Drawing.Point(121, 62);
            this.luevendor_id1.Name = "luevendor_id1";
            this.luevendor_id1.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.luevendor_id1.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luevendor_id1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luevendor_id1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luevendor_id1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 80, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 150, "name")});
            this.luevendor_id1.Properties.DropDownRows = 15;
            this.luevendor_id1.Properties.ImmediatePopup = true;
            this.luevendor_id1.Properties.NullText = "";
            this.luevendor_id1.Properties.PopupFormMinSize = new System.Drawing.Size(230, 0);
            this.luevendor_id1.Properties.PopupWidth = 230;
            this.luevendor_id1.Properties.ShowHeader = false;
            this.luevendor_id1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luevendor_id1.Size = new System.Drawing.Size(139, 20);
            this.luevendor_id1.TabIndex = 103;
            this.luevendor_id1.Tag = "2";
            this.luevendor_id1.Leave += new System.EventHandler(this.luevendor_id1_Leave);
            // 
            // label32
            // 
            this.label32.Location = new System.Drawing.Point(25, 63);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(94, 17);
            this.label32.TabIndex = 104;
            this.label32.Tag = "t_vendor_id";
            this.label32.Text = "供應商編號";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(25, 38);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(94, 17);
            this.label31.TabIndex = 102;
            this.label31.Tag = "t_order_date";
            this.label31.Text = "來料暫入庫日期";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dteir_date1
            // 
            this.dteir_date1.EditValue = "";
            this.dteir_date1.EnterMoveNextControl = true;
            this.dteir_date1.Location = new System.Drawing.Point(121, 36);
            this.dteir_date1.Name = "dteir_date1";
            this.dteir_date1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteir_date1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteir_date1.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dteir_date1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteir_date1.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.dteir_date1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteir_date1.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.dteir_date1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteir_date1.Properties.MaxLength = 10;
            this.dteir_date1.Size = new System.Drawing.Size(139, 20);
            this.dteir_date1.TabIndex = 101;
            this.dteir_date1.Tag = "2";
            this.dteir_date1.Leave += new System.EventHandler(this.dteir_date1_Leave);
            // 
            // label30
            // 
            this.label30.Location = new System.Drawing.Point(25, 11);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(94, 17);
            this.label30.TabIndex = 100;
            this.label30.Tag = "t_id";
            this.label30.Text = "編號";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtid1
            // 
            this.txtid1.EnterMoveNextControl = true;
            this.txtid1.Location = new System.Drawing.Point(121, 10);
            this.txtid1.Name = "txtid1";
            this.txtid1.Properties.MaxLength = 20;
            this.txtid1.Properties.Leave += new System.EventHandler(this.txtid1_Properties_Leave);
            this.txtid1.Size = new System.Drawing.Size(139, 20);
            this.txtid1.TabIndex = 99;
            this.txtid1.Tag = "2";
            // 
            // BTNFIND
            // 
            this.BTNFIND.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BTNFIND.ImageIndex = 0;
            this.BTNFIND.ImageList = this.myImageList;
            this.BTNFIND.Location = new System.Drawing.Point(486, 55);
            this.BTNFIND.Name = "BTNFIND";
            this.BTNFIND.Size = new System.Drawing.Size(83, 34);
            this.BTNFIND.TabIndex = 98;
            this.BTNFIND.Tag = "t_id";
            this.BTNFIND.Text = "Search";
            this.BTNFIND.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BTNFIND.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BTNFIND.UseVisualStyleBackColor = true;
            this.BTNFIND.Click += new System.EventHandler(this.BTNFIND_Click);
            // 
            // myImageList
            // 
            this.myImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImageList.ImageStream")));
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myImageList.Images.SetKeyName(0, "find.png");
            // 
            // frmTempReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 741);
            this.Controls.Add(this.tabPoPurchase);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmTempReceipt";
            this.Tag = "Forms.frmTempReceipt";
            this.Text = "frmTempReceipt";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmTempReceipt_FormClosed);
            this.Load += new System.EventHandler(this.frmTempReceipt_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabPoPurchase.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luedepartment_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdeliveryman.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueseparate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luevendor_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detir_date.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detir_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_mo_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_goods_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_unit_code)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_order_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_temp_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_m_receipt_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_fact_qty)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_weight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_unit_code_sec)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_location_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_qc_result)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_qc_state)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtremark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtdeliver_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtconsignee.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtvendor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmo_id2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luedept_id2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luevendor_id2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtmo_id1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luedept_id1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luevendor_id1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTNEXIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTNNEW;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BTNEDIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton BTNDELETE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton BTNITEMADD;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTNITEMDEL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BTNSAVE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton BTNCANCEL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BTNAPPROVE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator11;
        private System.Windows.Forms.ToolStripButton BTNPRINT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.TabControl tabPoPurchase;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label20;
        private DevExpress.XtraEditors.TextEdit txtdeliveryman;
        private System.Windows.Forms.Label lbllinkman;
        private DevExpress.XtraEditors.LookUpEdit lueseparate;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.DateEdit detir_date;
        private DevExpress.XtraEditors.LookUpEdit luestate;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvDetails;
        private DevExpress.XtraGrid.Columns.GridColumn mo_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit cl_mo_id;
        private DevExpress.XtraGrid.Columns.GridColumn goods_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit cl_goods_id;
        private DevExpress.XtraGrid.Columns.GridColumn goods_name;
        private DevExpress.XtraGrid.Columns.GridColumn temp_qty;
        private DevExpress.XtraGrid.Columns.GridColumn color;
        private DevExpress.XtraGrid.Columns.GridColumn m_receipt_qty;
        private DevExpress.XtraGrid.Columns.GridColumn s_qty;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit cl_order_qty;
        private DevExpress.XtraGrid.Columns.GridColumn unit_code;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cl_unit_code;
        private DevExpress.XtraGrid.Columns.GridColumn sec_qty;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit cl_weight;
        private DevExpress.XtraGrid.Columns.GridColumn sec_unit;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cl_unit_code_sec;
        private DevExpress.XtraGrid.Columns.GridColumn location_id;
        private DevExpress.XtraGrid.Columns.GridColumn fact_qty;
        private DevExpress.XtraGrid.Columns.GridColumn remark;
        private DevExpress.XtraGrid.Columns.GridColumn qc_result;
        private DevExpress.XtraGrid.Columns.GridColumn qc_state;
        private DevExpress.XtraGrid.Columns.GridColumn sell_order;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn sequence_id;
        private System.Windows.Forms.Label lblAmtim;
        private System.Windows.Forms.Label lblAmusr;
        private System.Windows.Forms.Label lblCrtim;
        private System.Windows.Forms.Label lblCrusr;
        private DevExpress.XtraEditors.TextEdit txtupdate_date;
        private DevExpress.XtraEditors.TextEdit txtupdate_by;
        private DevExpress.XtraEditors.TextEdit txtcreate_date;
        private DevExpress.XtraEditors.TextEdit txtcreate_by;
        private System.Windows.Forms.Label label9;
        private DevExpress.XtraEditors.MemoEdit txtremark;
        private System.Windows.Forms.Label lbldeliver_id;
        private DevExpress.XtraEditors.TextEdit txtdeliver_id;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit txtconsignee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblID;
        private DevExpress.XtraEditors.TextEdit txtID;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dgvFind;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.Label label35;
        private DevExpress.XtraEditors.TextEdit txtmo_id2;
        private DevExpress.XtraEditors.LookUpEdit luedept_id2;
        private DevExpress.XtraEditors.LookUpEdit luevendor_id2;
        private DevExpress.XtraEditors.DateEdit dteir_date2;
        private DevExpress.XtraEditors.TextEdit txtid2;
        private DevExpress.XtraEditors.TextEdit txtmo_id1;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label33;
        private DevExpress.XtraEditors.LookUpEdit luedept_id1;
        private DevExpress.XtraEditors.LookUpEdit luevendor_id1;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private DevExpress.XtraEditors.DateEdit dteir_date1;
        private System.Windows.Forms.Label label30;
        private DevExpress.XtraEditors.TextEdit txtid1;
        private System.Windows.Forms.Button BTNFIND;
        private DevExpress.XtraGrid.Columns.GridColumn po_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cl_location_id;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cl_qc_result;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cl_qc_state;
        private System.Windows.Forms.ImageList myImageList;
        private DevExpress.XtraGrid.Columns.GridColumn po_ver;
        private DevExpress.XtraGrid.Columns.GridColumn po_sequence_id;
        private DevExpress.XtraGrid.Columns.GridColumn basic_unit;
        private DevExpress.XtraGrid.Columns.GridColumn carton_code;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private DevExpress.XtraGrid.Columns.GridColumn total_sum;
        private DevExpress.XtraGrid.Columns.GridColumn currency;
        private DevExpress.XtraGrid.Columns.GridColumn m_rate;
        private DevExpress.XtraGrid.Columns.GridColumn s_date;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit cl_temp_qty;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit cl_m_receipt_qty;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit cl_fact_qty;
        private System.Windows.Forms.DataGridViewTextBoxColumn id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ir_date1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendor_id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn vendor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn department_id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn mo_id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_id1;
        private System.Windows.Forms.DataGridViewTextBoxColumn goods_name1;
        private System.Windows.Forms.DataGridViewTextBoxColumn s_qty1;
        private System.Windows.Forms.DataGridViewTextBoxColumn unit_code1;
        private System.Windows.Forms.DataGridViewTextBoxColumn receipt_qty1;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark1;
        private DevExpress.XtraGrid.Columns.GridColumn location;
        private DevExpress.XtraGrid.Columns.GridColumn exchange_rate;
        public DevExpress.XtraEditors.LookUpEdit luevendor_id;
        public DevExpress.XtraEditors.LookUpEdit luedepartment_id;
        public DevExpress.XtraEditors.TextEdit txtvendor;
    }
}