namespace cfvn.Forms
{
    partial class frmTempReceiptQuery
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
            this.m_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.department_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgvMmFind = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ir_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.goods_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.goods_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendor_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendor_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.po_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.po_ver = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unit_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.order_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.temp_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aready_receipt_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.notaudit_deliver_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sec_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sec_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mo_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.location_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qualified_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unqualified_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qc_result = new DevExpress.XtraGrid.Columns.GridColumn();
            this.qc_state = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sell_order = new DevExpress.XtraGrid.Columns.GridColumn();
            this.exchange_rate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNEXIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNFIND = new System.Windows.Forms.ToolStripButton();
            this.BTNOK = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label16 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.dteir_date2 = new DevExpress.XtraEditors.DateEdit();
            this.label31 = new System.Windows.Forms.Label();
            this.dteir_date1 = new DevExpress.XtraEditors.DateEdit();
            this.label15 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.txtvendor_id2 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtvendor_id1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtid2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgoods_id2 = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgoods_id1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtid1 = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNSAVESET = new System.Windows.Forms.ToolStripButton();
            this.cmbBoxStatus = new System.Windows.Forms.ComboBox();
            this.grpBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMmFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date1.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.grpBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // m_id
            // 
            this.m_id.Caption = "貨幣";
            this.m_id.FieldName = "m_id";
            this.m_id.Name = "m_id";
            this.m_id.Tag = "t_m_id";
            // 
            // department_id
            // 
            this.department_id.Caption = "部門";
            this.department_id.FieldName = "department_id";
            this.department_id.Name = "department_id";
            this.department_id.Tag = "t_dept_id";
            this.department_id.Visible = true;
            this.department_id.VisibleIndex = 23;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(2, 134);
            this.gridControl1.MainView = this.dgvMmFind;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1161, 585);
            this.gridControl1.TabIndex = 288;
            this.gridControl1.Tag = "2";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMmFind});
            // 
            // dgvMmFind
            // 
            this.dgvMmFind.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMmFind.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgvMmFind.ColumnPanelRowHeight = 30;
            this.dgvMmFind.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.ir_date,
            this.goods_id,
            this.goods_name,
            this.vendor_id,
            this.vendor_name,
            this.po_id,
            this.po_ver,
            this.unit_code,
            this.order_qty,
            this.temp_qty,
            this.aready_receipt_qty,
            this.notaudit_deliver_qty,
            this.price,
            this.sec_qty,
            this.sec_unit,
            this.mo_id,
            this.location_id,
            this.qualified_qty,
            this.unqualified_qty,
            this.qc_result,
            this.qc_state,
            this.sell_order,
            this.department_id,
            this.m_id,
            this.exchange_rate});
            this.dgvMmFind.GridControl = this.gridControl1;
            this.dgvMmFind.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.dgvMmFind.Name = "dgvMmFind";
            this.dgvMmFind.OptionsBehavior.Editable = false;
            this.dgvMmFind.OptionsView.ColumnAutoWidth = false;
            this.dgvMmFind.OptionsView.ShowGroupPanel = false;
            this.dgvMmFind.PaintStyleName = "Style3D";
            this.dgvMmFind.RowHeight = 25;
            this.dgvMmFind.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // id
            // 
            this.id.Caption = "編號";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowMove = false;
            this.id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.id.OptionsFilter.AllowAutoFilter = false;
            this.id.OptionsFilter.AllowFilter = false;
            this.id.Tag = "t_id";
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            this.id.Width = 84;
            // 
            // ir_date
            // 
            this.ir_date.Caption = "暫入庫日期";
            this.ir_date.FieldName = "order_date";
            this.ir_date.Name = "ir_date";
            this.ir_date.OptionsColumn.AllowMove = false;
            this.ir_date.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.ir_date.OptionsFilter.AllowAutoFilter = false;
            this.ir_date.OptionsFilter.AllowFilter = false;
            this.ir_date.Tag = "t_ir_date";
            this.ir_date.Visible = true;
            this.ir_date.VisibleIndex = 1;
            this.ir_date.Width = 72;
            // 
            // goods_id
            // 
            this.goods_id.Caption = "貨品編號";
            this.goods_id.FieldName = "goods_id";
            this.goods_id.Name = "goods_id";
            this.goods_id.OptionsColumn.AllowMove = false;
            this.goods_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.goods_id.OptionsFilter.AllowAutoFilter = false;
            this.goods_id.OptionsFilter.AllowFilter = false;
            this.goods_id.Tag = "t_goods_id";
            this.goods_id.Visible = true;
            this.goods_id.VisibleIndex = 7;
            this.goods_id.Width = 178;
            // 
            // goods_name
            // 
            this.goods_name.Caption = "貨品名稱(中文)";
            this.goods_name.FieldName = "goods_name";
            this.goods_name.Name = "goods_name";
            this.goods_name.OptionsColumn.AllowMove = false;
            this.goods_name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.goods_name.OptionsFilter.AllowAutoFilter = false;
            this.goods_name.OptionsFilter.AllowFilter = false;
            this.goods_name.Tag = "t_goods_name_cn";
            this.goods_name.Visible = true;
            this.goods_name.VisibleIndex = 8;
            this.goods_name.Width = 221;
            // 
            // vendor_id
            // 
            this.vendor_id.Caption = "供應商編號";
            this.vendor_id.FieldName = "vendor_id";
            this.vendor_id.Name = "vendor_id";
            this.vendor_id.OptionsColumn.AllowMove = false;
            this.vendor_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.vendor_id.OptionsFilter.AllowAutoFilter = false;
            this.vendor_id.OptionsFilter.AllowFilter = false;
            this.vendor_id.Tag = "t_vendor_id";
            this.vendor_id.Visible = true;
            this.vendor_id.VisibleIndex = 2;
            // 
            // vendor_name
            // 
            this.vendor_name.Caption = "供應商名稱(中文)";
            this.vendor_name.FieldName = "vendor_name";
            this.vendor_name.Name = "vendor_name";
            this.vendor_name.OptionsColumn.AllowMove = false;
            this.vendor_name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.vendor_name.OptionsFilter.AllowAutoFilter = false;
            this.vendor_name.OptionsFilter.AllowFilter = false;
            this.vendor_name.Tag = "t_vendor_name";
            this.vendor_name.Visible = true;
            this.vendor_name.VisibleIndex = 3;
            this.vendor_name.Width = 131;
            // 
            // po_id
            // 
            this.po_id.Caption = "訂單編號";
            this.po_id.FieldName = "po_id";
            this.po_id.Name = "po_id";
            this.po_id.OptionsColumn.AllowMove = false;
            this.po_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.po_id.OptionsFilter.AllowAutoFilter = false;
            this.po_id.OptionsFilter.AllowFilter = false;
            this.po_id.Tag = "t_po_id";
            this.po_id.Visible = true;
            this.po_id.VisibleIndex = 4;
            this.po_id.Width = 120;
            // 
            // po_ver
            // 
            this.po_ver.Caption = "版本號";
            this.po_ver.FieldName = "po_ver";
            this.po_ver.Name = "po_ver";
            this.po_ver.OptionsColumn.AllowMove = false;
            this.po_ver.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.po_ver.OptionsFilter.AllowAutoFilter = false;
            this.po_ver.OptionsFilter.AllowFilter = false;
            this.po_ver.Tag = "t_version";
            this.po_ver.Visible = true;
            this.po_ver.VisibleIndex = 6;
            this.po_ver.Width = 47;
            // 
            // unit_code
            // 
            this.unit_code.Caption = "單位";
            this.unit_code.FieldName = "unit_code";
            this.unit_code.Name = "unit_code";
            this.unit_code.OptionsColumn.AllowMove = false;
            this.unit_code.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.unit_code.OptionsFilter.AllowAutoFilter = false;
            this.unit_code.OptionsFilter.AllowFilter = false;
            this.unit_code.Tag = "t_unit";
            this.unit_code.Visible = true;
            this.unit_code.VisibleIndex = 10;
            this.unit_code.Width = 55;
            // 
            // order_qty
            // 
            this.order_qty.Caption = "訂單數量";
            this.order_qty.DisplayFormat.FormatString = "n2";
            this.order_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.order_qty.FieldName = "order_qty";
            this.order_qty.Name = "order_qty";
            this.order_qty.OptionsColumn.AllowMove = false;
            this.order_qty.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.order_qty.OptionsFilter.AllowAutoFilter = false;
            this.order_qty.OptionsFilter.AllowFilter = false;
            this.order_qty.Tag = "t_order_qty";
            this.order_qty.Visible = true;
            this.order_qty.VisibleIndex = 9;
            // 
            // temp_qty
            // 
            this.temp_qty.Caption = "暫收數量";
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
            this.temp_qty.VisibleIndex = 11;
            // 
            // aready_receipt_qty
            // 
            this.aready_receipt_qty.Caption = "已收貨數量";
            this.aready_receipt_qty.DisplayFormat.FormatString = "n2";
            this.aready_receipt_qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.aready_receipt_qty.FieldName = "aready_receipt_qty";
            this.aready_receipt_qty.MaxWidth = 250;
            this.aready_receipt_qty.Name = "aready_receipt_qty";
            this.aready_receipt_qty.OptionsColumn.AllowMove = false;
            this.aready_receipt_qty.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.aready_receipt_qty.OptionsColumn.ReadOnly = true;
            this.aready_receipt_qty.OptionsFilter.AllowAutoFilter = false;
            this.aready_receipt_qty.OptionsFilter.AllowFilter = false;
            this.aready_receipt_qty.Tag = "t_do_color";
            this.aready_receipt_qty.Visible = true;
            this.aready_receipt_qty.VisibleIndex = 17;
            this.aready_receipt_qty.Width = 133;
            // 
            // notaudit_deliver_qty
            // 
            this.notaudit_deliver_qty.Caption = "未審核收貨數量";
            this.notaudit_deliver_qty.FieldName = "notaudit_deliver_qty";
            this.notaudit_deliver_qty.Name = "notaudit_deliver_qty";
            this.notaudit_deliver_qty.Tag = "t_notaudit_deliver_qty";
            this.notaudit_deliver_qty.Visible = true;
            this.notaudit_deliver_qty.VisibleIndex = 13;
            // 
            // price
            // 
            this.price.Caption = "價格";
            this.price.FieldName = "price";
            this.price.Name = "price";
            this.price.Tag = "t_price";
            this.price.Visible = true;
            this.price.VisibleIndex = 20;
            // 
            // sec_qty
            // 
            this.sec_qty.Caption = "重量";
            this.sec_qty.FieldName = "sec_qty";
            this.sec_qty.Name = "sec_qty";
            this.sec_qty.OptionsColumn.AllowMove = false;
            this.sec_qty.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.sec_qty.OptionsFilter.AllowAutoFilter = false;
            this.sec_qty.OptionsFilter.AllowFilter = false;
            this.sec_qty.Tag = "t_weight";
            this.sec_qty.Visible = true;
            this.sec_qty.VisibleIndex = 12;
            this.sec_qty.Width = 205;
            // 
            // sec_unit
            // 
            this.sec_unit.Caption = "重量單位";
            this.sec_unit.FieldName = "sec_unit";
            this.sec_unit.Name = "sec_unit";
            this.sec_unit.OptionsColumn.AllowMove = false;
            this.sec_unit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.sec_unit.OptionsFilter.AllowAutoFilter = false;
            this.sec_unit.OptionsFilter.AllowFilter = false;
            this.sec_unit.Tag = "t_sec_unit";
            this.sec_unit.Visible = true;
            this.sec_unit.VisibleIndex = 15;
            this.sec_unit.Width = 57;
            // 
            // mo_id
            // 
            this.mo_id.Caption = "頁數";
            this.mo_id.FieldName = "mo_id";
            this.mo_id.Name = "mo_id";
            this.mo_id.OptionsColumn.AllowMove = false;
            this.mo_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.mo_id.OptionsFilter.AllowAutoFilter = false;
            this.mo_id.OptionsFilter.AllowFilter = false;
            this.mo_id.Tag = "t_mo_id";
            this.mo_id.Visible = true;
            this.mo_id.VisibleIndex = 5;
            this.mo_id.Width = 92;
            // 
            // location_id
            // 
            this.location_id.Caption = "倉庫";
            this.location_id.FieldName = "location_id";
            this.location_id.Name = "location_id";
            this.location_id.OptionsColumn.AllowMerge = DevExpress.Utils.DefaultBoolean.False;
            this.location_id.OptionsColumn.AllowMove = false;
            this.location_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.location_id.OptionsFilter.AllowAutoFilter = false;
            this.location_id.OptionsFilter.AllowFilter = false;
            this.location_id.Tag = "t_location";
            this.location_id.Visible = true;
            this.location_id.VisibleIndex = 16;
            // 
            // qualified_qty
            // 
            this.qualified_qty.Caption = "合格數量";
            this.qualified_qty.FieldName = "qualified_qty";
            this.qualified_qty.Name = "qualified_qty";
            this.qualified_qty.Tag = "t_qualified_qty";
            this.qualified_qty.Visible = true;
            this.qualified_qty.VisibleIndex = 18;
            // 
            // unqualified_qty
            // 
            this.unqualified_qty.Caption = "不合格數量";
            this.unqualified_qty.FieldName = "unqualified_qty";
            this.unqualified_qty.Name = "unqualified_qty";
            this.unqualified_qty.Tag = "t_unqualified_qty";
            this.unqualified_qty.Visible = true;
            this.unqualified_qty.VisibleIndex = 19;
            // 
            // qc_result
            // 
            this.qc_result.Caption = "QC結果";
            this.qc_result.FieldName = "qc_result";
            this.qc_result.MaxWidth = 180;
            this.qc_result.Name = "qc_result";
            this.qc_result.OptionsColumn.AllowMove = false;
            this.qc_result.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.qc_result.OptionsFilter.AllowAutoFilter = false;
            this.qc_result.OptionsFilter.AllowFilter = false;
            this.qc_result.Tag = "t_qc_result";
            this.qc_result.Visible = true;
            this.qc_result.VisibleIndex = 14;
            this.qc_result.Width = 65;
            // 
            // qc_state
            // 
            this.qc_state.Caption = "QC狀態";
            this.qc_state.FieldName = "qc_state";
            this.qc_state.Name = "qc_state";
            this.qc_state.Tag = "t_qc_status";
            this.qc_state.Visible = true;
            this.qc_state.VisibleIndex = 21;
            // 
            // sell_order
            // 
            this.sell_order.Caption = "銷售訂單號";
            this.sell_order.FieldName = "sell_order";
            this.sell_order.Name = "sell_order";
            this.sell_order.Tag = "t_sell_order";
            this.sell_order.Visible = true;
            this.sell_order.VisibleIndex = 22;
            // 
            // exchange_rate
            // 
            this.exchange_rate.Caption = "貨幣匯率";
            this.exchange_rate.FieldName = "exchange_rate";
            this.exchange_rate.Name = "exchange_rate";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "goods_id";
            this.dataGridViewTextBoxColumn2.FillWeight = 170F;
            this.dataGridViewTextBoxColumn2.HeaderText = "貨品編號";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(52, 22);
            this.BTNEXIT.Text = "退出(&X)";
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNFIND
            // 
            this.BTNFIND.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNFIND.Name = "BTNFIND";
            this.BTNFIND.Size = new System.Drawing.Size(51, 22);
            this.BTNFIND.Text = "查詢(&F)";
            // 
            // BTNOK
            // 
            this.BTNOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNOK.Name = "BTNOK";
            this.BTNOK.Size = new System.Drawing.Size(54, 22);
            this.BTNOK.Text = "確認(&O)";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn1.FillWeight = 180F;
            this.dataGridViewTextBoxColumn1.HeaderText = "Bom ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 180;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(313, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(11, 12);
            this.label16.TabIndex = 293;
            this.label16.Tag = "";
            this.label16.Text = "~";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(785, 21);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(11, 12);
            this.label36.TabIndex = 292;
            this.label36.Tag = "";
            this.label36.Text = "~";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dteir_date2
            // 
            this.dteir_date2.EditValue = "";
            this.dteir_date2.EnterMoveNextControl = true;
            this.dteir_date2.Location = new System.Drawing.Point(799, 17);
            this.dteir_date2.Name = "dteir_date2";
            this.dteir_date2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
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
            this.dteir_date2.Size = new System.Drawing.Size(178, 22);
            this.dteir_date2.TabIndex = 3;
            this.dteir_date2.Tag = "2";
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(481, 18);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(115, 20);
            this.label31.TabIndex = 291;
            this.label31.Tag = "t_ir_date";
            this.label31.Text = "來料暫入庫日期";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dteir_date1
            // 
            this.dteir_date1.EditValue = "";
            this.dteir_date1.EnterMoveNextControl = true;
            this.dteir_date1.Location = new System.Drawing.Point(601, 17);
            this.dteir_date1.Name = "dteir_date1";
            this.dteir_date1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
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
            this.dteir_date1.Size = new System.Drawing.Size(178, 22);
            this.dteir_date1.TabIndex = 2;
            this.dteir_date1.Tag = "2";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(313, 21);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(11, 12);
            this.label15.TabIndex = 290;
            this.label15.Text = "~";
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(52, 68);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 24);
            this.label18.TabIndex = 294;
            this.label18.Tag = "t_ir_state";
            this.label18.Text = "收貨狀態";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtvendor_id2
            // 
            this.txtvendor_id2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvendor_id2.Location = new System.Drawing.Point(331, 43);
            this.txtvendor_id2.MaxLength = 10;
            this.txtvendor_id2.Name = "txtvendor_id2";
            this.txtvendor_id2.Size = new System.Drawing.Size(135, 22);
            this.txtvendor_id2.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dept_id";
            this.dataGridViewTextBoxColumn4.FillWeight = 60F;
            this.dataGridViewTextBoxColumn4.HeaderText = "部門";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
            // 
            // txtvendor_id1
            // 
            this.txtvendor_id1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvendor_id1.Location = new System.Drawing.Point(172, 43);
            this.txtvendor_id1.MaxLength = 10;
            this.txtvendor_id1.Name = "txtvendor_id1";
            this.txtvendor_id1.Size = new System.Drawing.Size(135, 22);
            this.txtvendor_id1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(52, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 285;
            this.label2.Tag = "t_vendor_id";
            this.label2.Text = "供應商編碼";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtid2
            // 
            this.txtid2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid2.Location = new System.Drawing.Point(331, 17);
            this.txtid2.MaxLength = 12;
            this.txtid2.Name = "txtid2";
            this.txtid2.Size = new System.Drawing.Size(135, 22);
            this.txtid2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(785, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(11, 12);
            this.label3.TabIndex = 284;
            this.label3.Text = "~";
            // 
            // txtgoods_id2
            // 
            this.txtgoods_id2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgoods_id2.Location = new System.Drawing.Point(799, 43);
            this.txtgoods_id2.MaxLength = 18;
            this.txtgoods_id2.Name = "txtgoods_id2";
            this.txtgoods_id2.Size = new System.Drawing.Size(178, 22);
            this.txtgoods_id2.TabIndex = 7;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "check_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "批準日期";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Create_date";
            this.dataGridViewTextBoxColumn6.FillWeight = 55F;
            this.dataGridViewTextBoxColumn6.HeaderText = "建檔日期";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dept_name";
            this.dataGridViewTextBoxColumn5.FillWeight = 130F;
            this.dataGridViewTextBoxColumn5.HeaderText = "部門名稱";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn3.FillWeight = 200F;
            this.dataGridViewTextBoxColumn3.HeaderText = "貨品名稱";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(474, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 283;
            this.label4.Tag = "t_goods_id";
            this.label4.Text = "貨品編號";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtgoods_id1
            // 
            this.txtgoods_id1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgoods_id1.Location = new System.Drawing.Point(601, 43);
            this.txtgoods_id1.MaxLength = 18;
            this.txtgoods_id1.Name = "txtgoods_id1";
            this.txtgoods_id1.Size = new System.Drawing.Size(178, 22);
            this.txtgoods_id1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(52, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 282;
            this.label1.Tag = "t_id";
            this.label1.Text = "編號";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtid1
            // 
            this.txtid1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid1.Location = new System.Drawing.Point(172, 17);
            this.txtid1.MaxLength = 12;
            this.txtid1.Name = "txtid1";
            this.txtid1.Size = new System.Drawing.Size(135, 22);
            this.txtid1.TabIndex = 0;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNEXIT,
            this.toolStripSeparator1,
            this.BTNFIND,
            this.toolStripSeparator2,
            this.BTNOK,
            this.BTNSAVESET});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1165, 25);
            this.toolStrip1.TabIndex = 281;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNSAVESET
            // 
            this.BTNSAVESET.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNSAVESET.Name = "BTNSAVESET";
            this.BTNSAVESET.Size = new System.Drawing.Size(83, 22);
            this.BTNSAVESET.Text = "保存查找條件";
            this.BTNSAVESET.Click += new System.EventHandler(this.BTNSAVESET_Click);
            // 
            // cmbBoxStatus
            // 
            this.cmbBoxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBoxStatus.FormattingEnabled = true;
            this.cmbBoxStatus.Items.AddRange(new object[] {
            "All                (全部 )",
            "Received      (已收貨)",
            "Not received (未收貨)"});
            this.cmbBoxStatus.Location = new System.Drawing.Point(172, 69);
            this.cmbBoxStatus.Name = "cmbBoxStatus";
            this.cmbBoxStatus.Size = new System.Drawing.Size(135, 20);
            this.cmbBoxStatus.TabIndex = 8;
            // 
            // grpBox1
            // 
            this.grpBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpBox1.Controls.Add(this.label31);
            this.grpBox1.Controls.Add(this.cmbBoxStatus);
            this.grpBox1.Controls.Add(this.txtid1);
            this.grpBox1.Controls.Add(this.label1);
            this.grpBox1.Controls.Add(this.label16);
            this.grpBox1.Controls.Add(this.txtgoods_id1);
            this.grpBox1.Controls.Add(this.label36);
            this.grpBox1.Controls.Add(this.label4);
            this.grpBox1.Controls.Add(this.dteir_date2);
            this.grpBox1.Controls.Add(this.txtgoods_id2);
            this.grpBox1.Controls.Add(this.label3);
            this.grpBox1.Controls.Add(this.dteir_date1);
            this.grpBox1.Controls.Add(this.txtid2);
            this.grpBox1.Controls.Add(this.label15);
            this.grpBox1.Controls.Add(this.label2);
            this.grpBox1.Controls.Add(this.label18);
            this.grpBox1.Controls.Add(this.txtvendor_id1);
            this.grpBox1.Controls.Add(this.txtvendor_id2);
            this.grpBox1.Location = new System.Drawing.Point(4, 29);
            this.grpBox1.Name = "grpBox1";
            this.grpBox1.Size = new System.Drawing.Size(1157, 99);
            this.grpBox1.TabIndex = 295;
            this.grpBox1.TabStop = false;
            this.grpBox1.Tag = "t_search_condition";
            this.grpBox1.Text = "查詢條件";
            // 
            // frmTempReceiptQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 724);
            this.Controls.Add(this.grpBox1);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.KeyPreview = true;
            this.Name = "frmTempReceiptQuery";
            this.Tag = "Forms.frmTempReceiptQuery";
            this.Text = "frmTempReceiptQuery";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMmFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteir_date1.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.grpBox1.ResumeLayout(false);
            this.grpBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn m_id;
        private DevExpress.XtraGrid.Columns.GridColumn department_id;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMmFind;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn ir_date;
        private DevExpress.XtraGrid.Columns.GridColumn vendor_id;
        private DevExpress.XtraGrid.Columns.GridColumn vendor_name;
        private DevExpress.XtraGrid.Columns.GridColumn po_id;
        private DevExpress.XtraGrid.Columns.GridColumn mo_id;
        private DevExpress.XtraGrid.Columns.GridColumn po_ver;
        private DevExpress.XtraGrid.Columns.GridColumn goods_id;
        private DevExpress.XtraGrid.Columns.GridColumn goods_name;
        private DevExpress.XtraGrid.Columns.GridColumn order_qty;
        private DevExpress.XtraGrid.Columns.GridColumn unit_code;
        private DevExpress.XtraGrid.Columns.GridColumn sec_qty;
        private DevExpress.XtraGrid.Columns.GridColumn sec_unit;
        private DevExpress.XtraGrid.Columns.GridColumn qc_result;
        private DevExpress.XtraGrid.Columns.GridColumn aready_receipt_qty;
        private DevExpress.XtraGrid.Columns.GridColumn sell_order;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private DevExpress.XtraGrid.Columns.GridColumn exchange_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTNEXIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTNFIND;
        private System.Windows.Forms.ToolStripButton BTNOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label36;
        private DevExpress.XtraEditors.DateEdit dteir_date2;
        private System.Windows.Forms.Label label31;
        private DevExpress.XtraEditors.DateEdit dteir_date1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtvendor_id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.TextBox txtvendor_id1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtid2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgoods_id2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgoods_id1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtid1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ComboBox cmbBoxStatus;
        private System.Windows.Forms.GroupBox grpBox1;
        private System.Windows.Forms.ToolStripButton BTNSAVESET;
        private DevExpress.XtraGrid.Columns.GridColumn temp_qty;
        private DevExpress.XtraGrid.Columns.GridColumn notaudit_deliver_qty;
        private DevExpress.XtraGrid.Columns.GridColumn location_id;
        private DevExpress.XtraGrid.Columns.GridColumn qualified_qty;
        private DevExpress.XtraGrid.Columns.GridColumn unqualified_qty;
        private DevExpress.XtraGrid.Columns.GridColumn qc_state;
    }
}