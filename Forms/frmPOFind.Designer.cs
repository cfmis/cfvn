namespace cfvn.Forms
{
    partial class frmPOFind
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
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMmFind = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.order_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendor_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendor_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.vendor_name_en = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mo_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sequence_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.goods_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.goods_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.order_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unit_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.order_sec_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sec_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.color = new DevExpress.XtraGrid.Columns.GridColumn();
            this.aready_receipt_qty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.basic_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.m_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.exchange_rate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.department_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.txtmo_id = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.label12 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtgoods_name = new System.Windows.Forms.TextBox();
            this.txtvendor_name = new System.Windows.Forms.TextBox();
            this.txtvendor_id2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtvendor_id1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtpo_id2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgoods_id2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgoods_id1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtpo_id1 = new System.Windows.Forms.TextBox();
            this.BTNEXIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNFIND = new System.Windows.Forms.ToolStripButton();
            this.BTNOK = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.dteorder_date2 = new DevExpress.XtraEditors.DateEdit();
            this.label31 = new System.Windows.Forms.Label();
            this.dteorder_date1 = new DevExpress.XtraEditors.DateEdit();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtdept_id2 = new System.Windows.Forms.TextBox();
            this.txtdept_id1 = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMmFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteorder_date2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteorder_date2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteorder_date1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteorder_date1.Properties)).BeginInit();
            this.SuspendLayout();
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
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dept_name";
            this.dataGridViewTextBoxColumn5.FillWeight = 130F;
            this.dataGridViewTextBoxColumn5.HeaderText = "部門名稱";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
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
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "check_date";
            this.dataGridViewTextBoxColumn7.HeaderText = "批準日期";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 120;
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
            // dgvMmFind
            // 
            this.dgvMmFind.Appearance.GroupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvMmFind.Appearance.GroupPanel.Options.UseBackColor = true;
            this.dgvMmFind.ColumnPanelRowHeight = 30;
            this.dgvMmFind.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.id,
            this.order_date,
            this.vendor_id,
            this.vendor_name,
            this.vendor_name_en,
            this.mo_id,
            this.sequence_id,
            this.goods_id,
            this.goods_name,
            this.order_qty,
            this.unit_code,
            this.order_sec_qty,
            this.sec_unit,
            this.color,
            this.aready_receipt_qty,
            this.basic_unit,
            this.price,
            this.m_id,
            this.exchange_rate,
            this.department_id});
            this.dgvMmFind.GridControl = this.gridControl1;
            this.dgvMmFind.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.dgvMmFind.Name = "dgvMmFind";
            this.dgvMmFind.OptionsBehavior.Editable = false;
            this.dgvMmFind.OptionsView.ColumnAutoWidth = false;
            this.dgvMmFind.OptionsView.ShowGroupPanel = false;
            this.dgvMmFind.PaintStyleName = "Style3D";
            this.dgvMmFind.RowHeight = 25;
            this.dgvMmFind.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.dgvMmFind.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.dgvMmFind_FocusedRowChanged);
            // 
            // id
            // 
            this.id.Caption = "採購單號";
            this.id.FieldName = "id";
            this.id.Name = "id";
            this.id.OptionsColumn.AllowMove = false;
            this.id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.id.OptionsFilter.AllowAutoFilter = false;
            this.id.OptionsFilter.AllowFilter = false;
            this.id.Visible = true;
            this.id.VisibleIndex = 0;
            this.id.Width = 84;
            // 
            // order_date
            // 
            this.order_date.Caption = "訂單日期";
            this.order_date.FieldName = "order_date";
            this.order_date.Name = "order_date";
            this.order_date.OptionsColumn.AllowMove = false;
            this.order_date.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.order_date.OptionsFilter.AllowAutoFilter = false;
            this.order_date.OptionsFilter.AllowFilter = false;
            this.order_date.Visible = true;
            this.order_date.VisibleIndex = 1;
            this.order_date.Width = 72;
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
            this.vendor_name.Visible = true;
            this.vendor_name.VisibleIndex = 3;
            this.vendor_name.Width = 131;
            // 
            // vendor_name_en
            // 
            this.vendor_name_en.Caption = "供應商名稱(英文)";
            this.vendor_name_en.FieldName = "vendor_name_en";
            this.vendor_name_en.Name = "vendor_name_en";
            this.vendor_name_en.OptionsColumn.AllowMove = false;
            this.vendor_name_en.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.vendor_name_en.OptionsFilter.AllowAutoFilter = false;
            this.vendor_name_en.OptionsFilter.AllowFilter = false;
            this.vendor_name_en.Visible = true;
            this.vendor_name_en.VisibleIndex = 4;
            this.vendor_name_en.Width = 120;
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
            this.mo_id.Visible = true;
            this.mo_id.VisibleIndex = 5;
            this.mo_id.Width = 92;
            // 
            // sequence_id
            // 
            this.sequence_id.Caption = "序號";
            this.sequence_id.FieldName = "sequence_id";
            this.sequence_id.Name = "sequence_id";
            this.sequence_id.OptionsColumn.AllowMove = false;
            this.sequence_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.sequence_id.OptionsFilter.AllowAutoFilter = false;
            this.sequence_id.OptionsFilter.AllowFilter = false;
            this.sequence_id.Visible = true;
            this.sequence_id.VisibleIndex = 6;
            this.sequence_id.Width = 47;
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
            this.order_qty.Visible = true;
            this.order_qty.VisibleIndex = 9;
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
            // order_sec_qty
            // 
            this.order_sec_qty.Caption = "訂單重量";
            this.order_sec_qty.FieldName = "order_sec_qty";
            this.order_sec_qty.Name = "order_sec_qty";
            this.order_sec_qty.OptionsColumn.AllowMove = false;
            this.order_sec_qty.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.order_sec_qty.OptionsFilter.AllowAutoFilter = false;
            this.order_sec_qty.OptionsFilter.AllowFilter = false;
            this.order_sec_qty.Tag = "t_goods_name_en";
            this.order_sec_qty.Visible = true;
            this.order_sec_qty.VisibleIndex = 11;
            this.order_sec_qty.Width = 205;
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
            this.sec_unit.VisibleIndex = 13;
            this.sec_unit.Width = 57;
            // 
            // color
            // 
            this.color.Caption = "顏色";
            this.color.FieldName = "color";
            this.color.MaxWidth = 180;
            this.color.Name = "color";
            this.color.OptionsColumn.AllowMove = false;
            this.color.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.color.OptionsFilter.AllowAutoFilter = false;
            this.color.OptionsFilter.AllowFilter = false;
            this.color.Tag = "t_color";
            this.color.Visible = true;
            this.color.VisibleIndex = 12;
            this.color.Width = 65;
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
            this.aready_receipt_qty.VisibleIndex = 14;
            this.aready_receipt_qty.Width = 133;
            // 
            // basic_unit
            // 
            this.basic_unit.Caption = "gridColumn1";
            this.basic_unit.FieldName = "basic_unit";
            this.basic_unit.Name = "basic_unit";
            // 
            // price
            // 
            this.price.Caption = "價格";
            this.price.FieldName = "price";
            this.price.Name = "price";
            this.price.Tag = "t_price";
            // 
            // m_id
            // 
            this.m_id.Caption = "貨幣";
            this.m_id.FieldName = "m_id";
            this.m_id.Name = "m_id";
            this.m_id.Tag = "t_m_id";
            // 
            // exchange_rate
            // 
            this.exchange_rate.Caption = "貨幣匯率";
            this.exchange_rate.FieldName = "exchange_rate";
            this.exchange_rate.Name = "exchange_rate";
            // 
            // department_id
            // 
            this.department_id.Caption = "部門";
            this.department_id.FieldName = "department_id";
            this.department_id.Name = "department_id";
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(3, 163);
            this.gridControl1.MainView = this.dgvMmFind;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1178, 561);
            this.gridControl1.TabIndex = 96;
            this.gridControl1.Tag = "2";
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.dgvMmFind});
            // 
            // txtmo_id
            // 
            this.txtmo_id.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmo_id.Location = new System.Drawing.Point(570, 131);
            this.txtmo_id.MaxLength = 10;
            this.txtmo_id.Name = "txtmo_id";
            this.txtmo_id.Size = new System.Drawing.Size(216, 22);
            this.txtmo_id.TabIndex = 12;
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
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(443, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(125, 22);
            this.label12.TabIndex = 98;
            this.label12.Tag = "t_mo_id";
            this.label12.Text = "頁 數";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(443, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(125, 22);
            this.label6.TabIndex = 89;
            this.label6.Tag = "t_goods_name_cn";
            this.label6.Text = "貨品名稱(中文)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtgoods_name
            // 
            this.txtgoods_name.Location = new System.Drawing.Point(570, 72);
            this.txtgoods_name.MaxLength = 100;
            this.txtgoods_name.Name = "txtgoods_name";
            this.txtgoods_name.Size = new System.Drawing.Size(457, 22);
            this.txtgoods_name.TabIndex = 10;
            // 
            // txtvendor_name
            // 
            this.txtvendor_name.Location = new System.Drawing.Point(570, 101);
            this.txtvendor_name.MaxLength = 100;
            this.txtvendor_name.Name = "txtvendor_name";
            this.txtvendor_name.Size = new System.Drawing.Size(457, 22);
            this.txtvendor_name.TabIndex = 11;
            // 
            // txtvendor_id2
            // 
            this.txtvendor_id2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvendor_id2.Location = new System.Drawing.Point(299, 101);
            this.txtvendor_id2.MaxLength = 10;
            this.txtvendor_id2.Name = "txtvendor_id2";
            this.txtvendor_id2.Size = new System.Drawing.Size(135, 22);
            this.txtvendor_id2.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(443, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 23);
            this.label5.TabIndex = 86;
            this.label5.Tag = "t_vendor_name";
            this.label5.Text = "供應商名稱";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtvendor_id1
            // 
            this.txtvendor_id1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtvendor_id1.Location = new System.Drawing.Point(140, 101);
            this.txtvendor_id1.MaxLength = 10;
            this.txtvendor_id1.Name = "txtvendor_id1";
            this.txtvendor_id1.Size = new System.Drawing.Size(135, 22);
            this.txtvendor_id1.TabIndex = 4;
            this.txtvendor_id1.Leave += new System.EventHandler(this.txtvendor_id1_Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(20, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 24);
            this.label2.TabIndex = 85;
            this.label2.Tag = "t_vendor_id";
            this.label2.Text = "供應商編碼";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtpo_id2
            // 
            this.txtpo_id2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpo_id2.Location = new System.Drawing.Point(299, 43);
            this.txtpo_id2.MaxLength = 12;
            this.txtpo_id2.Name = "txtpo_id2";
            this.txtpo_id2.Size = new System.Drawing.Size(135, 22);
            this.txtpo_id2.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(793, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 14);
            this.label3.TabIndex = 84;
            this.label3.Text = "~";
            // 
            // txtgoods_id2
            // 
            this.txtgoods_id2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgoods_id2.Location = new System.Drawing.Point(811, 43);
            this.txtgoods_id2.MaxLength = 18;
            this.txtgoods_id2.Name = "txtgoods_id2";
            this.txtgoods_id2.Size = new System.Drawing.Size(216, 22);
            this.txtgoods_id2.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(443, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 20);
            this.label4.TabIndex = 83;
            this.label4.Tag = "t_goods_id";
            this.label4.Text = "貨品編號";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtgoods_id1
            // 
            this.txtgoods_id1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgoods_id1.Location = new System.Drawing.Point(570, 43);
            this.txtgoods_id1.MaxLength = 18;
            this.txtgoods_id1.Name = "txtgoods_id1";
            this.txtgoods_id1.Size = new System.Drawing.Size(216, 22);
            this.txtgoods_id1.TabIndex = 8;
            this.txtgoods_id1.Leave += new System.EventHandler(this.txtgoods_id1_Leave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(20, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 20);
            this.label1.TabIndex = 82;
            this.label1.Tag = "t_po_id";
            this.label1.Text = "採購單號";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtpo_id1
            // 
            this.txtpo_id1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtpo_id1.Location = new System.Drawing.Point(140, 43);
            this.txtpo_id1.MaxLength = 12;
            this.txtpo_id1.Name = "txtpo_id1";
            this.txtpo_id1.Size = new System.Drawing.Size(135, 22);
            this.txtpo_id1.TabIndex = 0;
            this.txtpo_id1.Leave += new System.EventHandler(this.txtpo_id1_Leave);
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
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNEXIT,
            this.toolStripSeparator1,
            this.BTNFIND,
            this.toolStripSeparator2,
            this.BTNOK});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1185, 25);
            this.toolStrip1.TabIndex = 81;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNFIND
            // 
            this.BTNFIND.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNFIND.Name = "BTNFIND";
            this.BTNFIND.Size = new System.Drawing.Size(51, 22);
            this.BTNFIND.Text = "查詢(&F)";
            this.BTNFIND.Click += new System.EventHandler(this.BTNFIND_Click);
            // 
            // BTNOK
            // 
            this.BTNOK.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNOK.Name = "BTNOK";
            this.BTNOK.Size = new System.Drawing.Size(54, 22);
            this.BTNOK.Text = "確認(&O)";
            this.BTNOK.Click += new System.EventHandler(this.BTNOK_Click);
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
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(281, 47);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(16, 14);
            this.label15.TabIndex = 99;
            this.label15.Text = "~";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(281, 78);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(16, 14);
            this.label36.TabIndex = 262;
            this.label36.Tag = "";
            this.label36.Text = "~";
            this.label36.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dteorder_date2
            // 
            this.dteorder_date2.EditValue = "";
            this.dteorder_date2.EnterMoveNextControl = true;
            this.dteorder_date2.Location = new System.Drawing.Point(299, 72);
            this.dteorder_date2.Name = "dteorder_date2";
            this.dteorder_date2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.dteorder_date2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteorder_date2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteorder_date2.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dteorder_date2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteorder_date2.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.dteorder_date2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteorder_date2.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.dteorder_date2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteorder_date2.Properties.MaxLength = 10;
            this.dteorder_date2.Size = new System.Drawing.Size(135, 22);
            this.dteorder_date2.TabIndex = 3;
            this.dteorder_date2.Tag = "2";
            // 
            // label31
            // 
            this.label31.Location = new System.Drawing.Point(20, 73);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(115, 20);
            this.label31.TabIndex = 260;
            this.label31.Tag = "t_order_date";
            this.label31.Text = "訂單日期";
            this.label31.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dteorder_date1
            // 
            this.dteorder_date1.EditValue = "";
            this.dteorder_date1.EnterMoveNextControl = true;
            this.dteorder_date1.Location = new System.Drawing.Point(140, 72);
            this.dteorder_date1.Name = "dteorder_date1";
            this.dteorder_date1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.dteorder_date1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dteorder_date1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.dteorder_date1.Properties.DisplayFormat.FormatString = "yyyy/MM/dd";
            this.dteorder_date1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteorder_date1.Properties.EditFormat.FormatString = "yyyy/MM/dd";
            this.dteorder_date1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.dteorder_date1.Properties.Mask.EditMask = "yyyy/MM/dd";
            this.dteorder_date1.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.DateTimeAdvancingCaret;
            this.dteorder_date1.Properties.MaxLength = 10;
            this.dteorder_date1.Size = new System.Drawing.Size(135, 22);
            this.dteorder_date1.TabIndex = 2;
            this.dteorder_date1.Tag = "2";
            this.dteorder_date1.Leave += new System.EventHandler(this.dteorder_date1_Leave);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(281, 107);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(16, 14);
            this.label16.TabIndex = 263;
            this.label16.Tag = "";
            this.label16.Text = "~";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(281, 136);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(16, 14);
            this.label17.TabIndex = 267;
            this.label17.Tag = "";
            this.label17.Text = "~";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtdept_id2
            // 
            this.txtdept_id2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdept_id2.Location = new System.Drawing.Point(299, 131);
            this.txtdept_id2.MaxLength = 10;
            this.txtdept_id2.Name = "txtdept_id2";
            this.txtdept_id2.Size = new System.Drawing.Size(135, 22);
            this.txtdept_id2.TabIndex = 7;
            // 
            // txtdept_id1
            // 
            this.txtdept_id1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdept_id1.Location = new System.Drawing.Point(140, 131);
            this.txtdept_id1.MaxLength = 10;
            this.txtdept_id1.Name = "txtdept_id1";
            this.txtdept_id1.Size = new System.Drawing.Size(135, 22);
            this.txtdept_id1.TabIndex = 6;
            this.txtdept_id1.Leave += new System.EventHandler(this.txtdept_id1_Leave);
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(20, 129);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(115, 24);
            this.label18.TabIndex = 266;
            this.label18.Tag = "t_dept_id";
            this.label18.Text = "部門編碼";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmPOFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1185, 727);
            this.ControlBox = false;
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtdept_id2);
            this.Controls.Add(this.txtdept_id1);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label36);
            this.Controls.Add(this.dteorder_date2);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.dteorder_date1);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtmo_id);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtgoods_name);
            this.Controls.Add(this.txtvendor_name);
            this.Controls.Add(this.txtvendor_id2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtvendor_id1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtpo_id2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgoods_id2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtgoods_id1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtpo_id1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmPOFind";
            this.Text = "frmPOFind";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPOFind_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMmFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dteorder_date2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteorder_date2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteorder_date1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dteorder_date1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMmFind;
        private DevExpress.XtraGrid.Columns.GridColumn goods_id;
        private DevExpress.XtraGrid.Columns.GridColumn goods_name;
        private DevExpress.XtraGrid.Columns.GridColumn order_sec_qty;
        private DevExpress.XtraGrid.Columns.GridColumn color;
        private DevExpress.XtraGrid.Columns.GridColumn aready_receipt_qty;
        private DevExpress.XtraGrid.Columns.GridColumn unit_code;
        private DevExpress.XtraGrid.Columns.GridColumn sec_unit;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.TextBox txtmo_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtgoods_name;
        private System.Windows.Forms.TextBox txtvendor_name;
        private System.Windows.Forms.TextBox txtvendor_id2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtvendor_id1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtpo_id2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgoods_id2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgoods_id1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtpo_id1;
        private System.Windows.Forms.ToolStripButton BTNEXIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTNFIND;
        private System.Windows.Forms.ToolStripButton BTNOK;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label36;
        private DevExpress.XtraEditors.DateEdit dteorder_date2;
        private System.Windows.Forms.Label label31;
        private DevExpress.XtraEditors.DateEdit dteorder_date1;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtdept_id2;
        private System.Windows.Forms.TextBox txtdept_id1;
        private System.Windows.Forms.Label label18;
        private DevExpress.XtraGrid.Columns.GridColumn id;
        private DevExpress.XtraGrid.Columns.GridColumn order_date;
        private DevExpress.XtraGrid.Columns.GridColumn vendor_id;
        private DevExpress.XtraGrid.Columns.GridColumn vendor_name;
        private DevExpress.XtraGrid.Columns.GridColumn vendor_name_en;
        private DevExpress.XtraGrid.Columns.GridColumn mo_id;
        private DevExpress.XtraGrid.Columns.GridColumn sequence_id;
        private DevExpress.XtraGrid.Columns.GridColumn order_qty;
        private DevExpress.XtraGrid.Columns.GridColumn basic_unit;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private DevExpress.XtraGrid.Columns.GridColumn m_id;
        private DevExpress.XtraGrid.Columns.GridColumn exchange_rate;
        private DevExpress.XtraGrid.Columns.GridColumn department_id;
    }
}