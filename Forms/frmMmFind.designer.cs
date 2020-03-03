namespace cfvn.Forms
{
    partial class frmMmFind
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
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNEXIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNFIND = new System.Windows.Forms.ToolStripButton();
            this.BTNOK = new System.Windows.Forms.ToolStripButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgoods_id2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtgoods_id1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMat_code = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrd_code = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtArt_code = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSize_code = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtClr_code = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkPur = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dgvMmFind = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.goods_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.english_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.color = new DevExpress.XtraGrid.Columns.GridColumn();
            this.do_color = new DevExpress.XtraGrid.Columns.GridColumn();
            this.unit_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.sec_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.modality = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cl_modality = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.txtenglish_name = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMmFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_modality)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(52, 22);
            this.BTNEXIT.Text = "退出(&X)";
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 14);
            this.label3.TabIndex = 41;
            this.label3.Text = "~";
            // 
            // txtgoods_id2
            // 
            this.txtgoods_id2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgoods_id2.Location = new System.Drawing.Point(378, 37);
            this.txtgoods_id2.MaxLength = 18;
            this.txtgoods_id2.Name = "txtgoods_id2";
            this.txtgoods_id2.Size = new System.Drawing.Size(261, 22);
            this.txtgoods_id2.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(33, 38);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 37;
            this.label4.Tag = "t_goods_id";
            this.label4.Text = "貨品編號";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtgoods_id1
            // 
            this.txtgoods_id1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgoods_id1.Location = new System.Drawing.Point(120, 37);
            this.txtgoods_id1.MaxLength = 18;
            this.txtgoods_id1.Name = "txtgoods_id1";
            this.txtgoods_id1.Size = new System.Drawing.Size(231, 22);
            this.txtgoods_id1.TabIndex = 0;
            this.txtgoods_id1.Leave += new System.EventHandler(this.txtgoods_id1_Leave);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(120, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 21);
            this.label1.TabIndex = 32;
            this.label1.Tag = "t_material";
            this.label1.Text = "物料類型";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMat_code
            // 
            this.txtMat_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtMat_code.Location = new System.Drawing.Point(120, 99);
            this.txtMat_code.MaxLength = 2;
            this.txtMat_code.Name = "txtMat_code";
            this.txtMat_code.Size = new System.Drawing.Size(89, 22);
            this.txtMat_code.TabIndex = 2;
            this.txtMat_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.toolStrip1.Size = new System.Drawing.Size(1014, 25);
            this.toolStrip1.TabIndex = 30;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(213, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 21);
            this.label2.TabIndex = 54;
            this.label2.Tag = "t_prod_type";
            this.label2.Text = "產品類型";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPrd_code
            // 
            this.txtPrd_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtPrd_code.Location = new System.Drawing.Point(213, 99);
            this.txtPrd_code.MaxLength = 2;
            this.txtPrd_code.Name = "txtPrd_code";
            this.txtPrd_code.Size = new System.Drawing.Size(89, 22);
            this.txtPrd_code.TabIndex = 3;
            this.txtPrd_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(311, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 56;
            this.label5.Tag = "t_artwork";
            this.label5.Text = "圖樣編號";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtArt_code
            // 
            this.txtArt_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtArt_code.Location = new System.Drawing.Point(307, 99);
            this.txtArt_code.MaxLength = 7;
            this.txtArt_code.Name = "txtArt_code";
            this.txtArt_code.Size = new System.Drawing.Size(124, 22);
            this.txtArt_code.TabIndex = 4;
            this.txtArt_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(436, 62);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 21);
            this.label13.TabIndex = 58;
            this.label13.Tag = "t_size";
            this.label13.Text = "尺寸";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtSize_code
            // 
            this.txtSize_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSize_code.Location = new System.Drawing.Point(436, 99);
            this.txtSize_code.MaxLength = 3;
            this.txtSize_code.Name = "txtSize_code";
            this.txtSize_code.Size = new System.Drawing.Size(93, 22);
            this.txtSize_code.TabIndex = 5;
            this.txtSize_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(537, 62);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(98, 21);
            this.label14.TabIndex = 60;
            this.label14.Tag = "t_color";
            this.label14.Text = "顏色";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtClr_code
            // 
            this.txtClr_code.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtClr_code.Location = new System.Drawing.Point(537, 99);
            this.txtClr_code.MaxLength = 4;
            this.txtClr_code.Name = "txtClr_code";
            this.txtClr_code.Size = new System.Drawing.Size(97, 22);
            this.txtClr_code.TabIndex = 6;
            this.txtClr_code.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(3, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(116, 19);
            this.label6.TabIndex = 62;
            this.label6.Tag = "t_goods_name_cn";
            this.label6.Text = "貨品名稱(中文)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(120, 124);
            this.txtname.MaxLength = 50;
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(514, 22);
            this.txtname.TabIndex = 7;
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
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "goods_id";
            this.dataGridViewTextBoxColumn2.FillWeight = 170F;
            this.dataGridViewTextBoxColumn2.HeaderText = "貨品編號";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 170;
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
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "dept_id";
            this.dataGridViewTextBoxColumn4.FillWeight = 60F;
            this.dataGridViewTextBoxColumn4.HeaderText = "部門";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 60;
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
            // chkPur
            // 
            this.chkPur.AutoSize = true;
            this.chkPur.Enabled = false;
            this.chkPur.Location = new System.Drawing.Point(661, 125);
            this.chkPur.Name = "chkPur";
            this.chkPur.Size = new System.Drawing.Size(98, 18);
            this.chkPur.TabIndex = 64;
            this.chkPur.Tag = "t_show_purchases";
            this.chkPur.Text = "只顯示採購件";
            this.chkPur.UseVisualStyleBackColor = true;
            this.chkPur.Visible = false;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(126, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "(1~2)";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(239, 84);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "(3~4)";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(334, 84);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "(5~11)";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(460, 84);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "(12~14)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(558, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(54, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "(15~18)";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(3, 177);
            this.gridControl1.MainView = this.dgvMmFind;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.cl_modality});
            this.gridControl1.Size = new System.Drawing.Size(1010, 443);
            this.gridControl1.TabIndex = 70;
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
            this.goods_id,
            this.name,
            this.english_name,
            this.color,
            this.do_color,
            this.unit_code,
            this.sec_unit,
            this.modality});
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
            // goods_id
            // 
            this.goods_id.Caption = "貨品編號";
            this.goods_id.FieldName = "goods_id";
            this.goods_id.Name = "goods_id";
            this.goods_id.OptionsColumn.AllowMove = false;
            this.goods_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.goods_id.OptionsColumn.ReadOnly = true;
            this.goods_id.Tag = "t_goods_id";
            this.goods_id.Visible = true;
            this.goods_id.VisibleIndex = 0;
            this.goods_id.Width = 178;
            // 
            // name
            // 
            this.name.Caption = "貨品名稱(中文)";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.OptionsColumn.AllowMove = false;
            this.name.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.name.OptionsFilter.AllowAutoFilter = false;
            this.name.OptionsFilter.AllowFilter = false;
            this.name.Tag = "t_goods_name_cn";
            this.name.Visible = true;
            this.name.VisibleIndex = 1;
            this.name.Width = 221;
            // 
            // english_name
            // 
            this.english_name.Caption = "貨品名稱(英文)";
            this.english_name.FieldName = "english_name";
            this.english_name.Name = "english_name";
            this.english_name.Tag = "t_goods_name_en";
            this.english_name.Visible = true;
            this.english_name.VisibleIndex = 2;
            this.english_name.Width = 205;
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
            this.color.VisibleIndex = 3;
            this.color.Width = 65;
            // 
            // do_color
            // 
            this.do_color.Caption = "顏色做法";
            this.do_color.FieldName = "do_color";
            this.do_color.MaxWidth = 250;
            this.do_color.Name = "do_color";
            this.do_color.OptionsColumn.AllowMove = false;
            this.do_color.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.do_color.OptionsColumn.ReadOnly = true;
            this.do_color.OptionsFilter.AllowAutoFilter = false;
            this.do_color.OptionsFilter.AllowFilter = false;
            this.do_color.Tag = "t_do_color";
            this.do_color.Visible = true;
            this.do_color.VisibleIndex = 4;
            this.do_color.Width = 133;
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
            this.unit_code.VisibleIndex = 5;
            this.unit_code.Width = 55;
            // 
            // sec_unit
            // 
            this.sec_unit.Caption = "重量單位";
            this.sec_unit.FieldName = "sec_unit";
            this.sec_unit.Name = "sec_unit";
            this.sec_unit.OptionsColumn.AllowMove = false;
            this.sec_unit.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.sec_unit.OptionsColumn.ReadOnly = true;
            this.sec_unit.OptionsFilter.AllowAutoFilter = false;
            this.sec_unit.OptionsFilter.AllowFilter = false;
            this.sec_unit.Tag = "t_sec_unit";
            this.sec_unit.Visible = true;
            this.sec_unit.VisibleIndex = 6;
            this.sec_unit.Width = 57;
            // 
            // modality
            // 
            this.modality.Caption = "管制類型";
            this.modality.ColumnEdit = this.cl_modality;
            this.modality.FieldName = "modality";
            this.modality.Name = "modality";
            this.modality.OptionsColumn.AllowMove = false;
            this.modality.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.modality.OptionsColumn.ReadOnly = true;
            this.modality.OptionsFilter.AllowAutoFilter = false;
            this.modality.OptionsFilter.AllowFilter = false;
            this.modality.Tag = "t_modality";
            this.modality.Visible = true;
            this.modality.VisibleIndex = 7;
            this.modality.Width = 74;
            // 
            // cl_modality
            // 
            this.cl_modality.AutoHeight = false;
            this.cl_modality.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cl_modality.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.cl_modality.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 40, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 60, "name")});
            this.cl_modality.DropDownRows = 10;
            this.cl_modality.Name = "cl_modality";
            this.cl_modality.NullText = "";
            this.cl_modality.PopupWidth = 100;
            this.cl_modality.ReadOnly = true;
            this.cl_modality.ShowHeader = false;
            this.cl_modality.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(3, 149);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(116, 19);
            this.label12.TabIndex = 72;
            this.label12.Tag = "t_goods_name_en";
            this.label12.Text = "貨品名稱(英文)";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtenglish_name
            // 
            this.txtenglish_name.Location = new System.Drawing.Point(120, 149);
            this.txtenglish_name.MaxLength = 50;
            this.txtenglish_name.Name = "txtenglish_name";
            this.txtenglish_name.Size = new System.Drawing.Size(514, 22);
            this.txtenglish_name.TabIndex = 8;
            // 
            // frmMmFind
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 621);
            this.ControlBox = false;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtenglish_name);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.chkPur);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtClr_code);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtSize_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtArt_code);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPrd_code);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtgoods_id2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtgoods_id1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMat_code);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmMmFind";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMmFind";
            this.Load += new System.EventHandler(this.frmMmFind_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMmFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cl_modality)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.ToolStripButton BTNEXIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTNFIND;
        private System.Windows.Forms.ToolStripButton BTNOK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgoods_id2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtgoods_id1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMat_code;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrd_code;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtArt_code;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSize_code;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtClr_code;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtname;
        private System.Windows.Forms.CheckBox chkPur;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView dgvMmFind;
        private DevExpress.XtraGrid.Columns.GridColumn goods_id;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn color;
        private DevExpress.XtraGrid.Columns.GridColumn do_color;
        private DevExpress.XtraGrid.Columns.GridColumn sec_unit;
        private DevExpress.XtraGrid.Columns.GridColumn unit_code;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit cl_modality;
        private DevExpress.XtraGrid.Columns.GridColumn modality;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtenglish_name;
        private DevExpress.XtraGrid.Columns.GridColumn english_name;
    }
}