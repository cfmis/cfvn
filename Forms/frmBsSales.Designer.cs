namespace cfvn.Forms
{
    partial class frmBsSales
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnFind = new System.Windows.Forms.ToolStripButton();
            this.t_update_date = new System.Windows.Forms.Label();
            this.t_update_by = new System.Windows.Forms.Label();
            this.t_create_date = new System.Windows.Forms.Label();
            this.t_create_by = new System.Windows.Forms.Label();
            this.lblabbrev_id = new System.Windows.Forms.Label();
            this.lblid = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sales_group = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.abbrev_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtupdate_date = new DevExpress.XtraEditors.TextEdit();
            this.txtupdate_by = new DevExpress.XtraEditors.TextEdit();
            this.txtcreate_date = new DevExpress.XtraEditors.TextEdit();
            this.txtcreate_by = new DevExpress.XtraEditors.TextEdit();
            this.luestate = new DevExpress.XtraEditors.LookUpEdit();
            this.t_state = new System.Windows.Forms.Label();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.luegroup = new DevExpress.XtraEditors.LookUpEdit();
            this.txtabbrev_id = new DevExpress.XtraEditors.TextEdit();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.txtenglish_name = new DevExpress.XtraEditors.TextEdit();
            this.t_english_name = new System.Windows.Forms.Label();
            this.lblSales_group = new System.Windows.Forms.Label();
            this.t_name = new System.Windows.Forms.Label();
            this.bds1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luegroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtabbrev_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnNew,
            this.toolStripSeparator4,
            this.btnEdit,
            this.toolStripSeparator2,
            this.btnDelete,
            this.toolStripSeparator3,
            this.btnSave,
            this.toolStripSeparator6,
            this.btnUndo,
            this.toolStripSeparator5,
            this.btnFind});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(951, 38);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(71, 35);
            this.btnExit.Text = "退 出 (&X)";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // btnNew
            // 
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(61, 35);
            this.btnNew.Text = " 新 增(&N)";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // btnEdit
            // 
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(60, 35);
            this.btnEdit.Text = " 修 改(&E)";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnDelete
            // 
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(53, 35);
            this.btnDelete.Text = "刪除(&D)";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btnSave
            // 
            this.btnSave.Enabled = false;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 35);
            this.btnSave.Text = " 保  存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
            // 
            // btnUndo
            // 
            this.btnUndo.Enabled = false;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(57, 35);
            this.btnUndo.Text = "恢 復(&U)";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // btnFind
            // 
            this.btnFind.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(51, 35);
            this.btnFind.Text = "查找(&F)";
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // t_update_date
            // 
            this.t_update_date.Location = new System.Drawing.Point(660, 65);
            this.t_update_date.Name = "t_update_date";
            this.t_update_date.Size = new System.Drawing.Size(77, 16);
            this.t_update_date.TabIndex = 48;
            this.t_update_date.Tag = "t_update_date";
            this.t_update_date.Text = "修改日期";
            this.t_update_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_update_by
            // 
            this.t_update_by.Location = new System.Drawing.Point(461, 65);
            this.t_update_by.Name = "t_update_by";
            this.t_update_by.Size = new System.Drawing.Size(77, 16);
            this.t_update_by.TabIndex = 46;
            this.t_update_by.Tag = "t_update_by";
            this.t_update_by.Text = "修改人";
            this.t_update_by.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_create_date
            // 
            this.t_create_date.Location = new System.Drawing.Point(230, 65);
            this.t_create_date.Name = "t_create_date";
            this.t_create_date.Size = new System.Drawing.Size(72, 16);
            this.t_create_date.TabIndex = 44;
            this.t_create_date.Tag = "t_create_date";
            this.t_create_date.Text = "建档日期";
            this.t_create_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_create_by
            // 
            this.t_create_by.Location = new System.Drawing.Point(9, 65);
            this.t_create_by.Name = "t_create_by";
            this.t_create_by.Size = new System.Drawing.Size(94, 16);
            this.t_create_by.TabIndex = 42;
            this.t_create_by.Tag = "t_create_by";
            this.t_create_by.Text = "建档人";
            this.t_create_by.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblabbrev_id
            // 
            this.lblabbrev_id.Location = new System.Drawing.Point(349, 8);
            this.lblabbrev_id.Name = "lblabbrev_id";
            this.lblabbrev_id.Size = new System.Drawing.Size(100, 16);
            this.lblabbrev_id.TabIndex = 40;
            this.lblabbrev_id.Tag = "t_abbrev_id";
            this.lblabbrev_id.Text = "簡寫編號";
            this.lblabbrev_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblid
            // 
            this.lblid.ForeColor = System.Drawing.Color.Blue;
            this.lblid.Location = new System.Drawing.Point(5, 8);
            this.lblid.Name = "lblid";
            this.lblid.Size = new System.Drawing.Size(100, 16);
            this.lblid.TabIndex = 34;
            this.lblid.Tag = "t_id";
            this.lblid.Text = "編號";
            this.lblid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dgvDetails
            // 
            this.dgvDetails.AllowUserToAddRows = false;
            this.dgvDetails.AllowUserToDeleteRows = false;
            this.dgvDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetails.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.english_name,
            this.sales_group,
            this.abbrev_id,
            this.create_by,
            this.create_date,
            this.update_by,
            this.update_date,
            this.state});
            this.dgvDetails.Location = new System.Drawing.Point(2, 146);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.ShowCellToolTips = false;
            this.dgvDetails.Size = new System.Drawing.Size(948, 464);
            this.dgvDetails.TabIndex = 50;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "編號";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ToolTipText = "t_id";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.ToolTipText = "t_name";
            this.name.Width = 150;
            // 
            // english_name
            // 
            this.english_name.DataPropertyName = "english_name";
            this.english_name.HeaderText = "名稱(英文)";
            this.english_name.Name = "english_name";
            this.english_name.ReadOnly = true;
            this.english_name.ToolTipText = "t_english_name";
            this.english_name.Width = 150;
            // 
            // sales_group
            // 
            this.sales_group.DataPropertyName = "sales_group";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.sales_group.DefaultCellStyle = dataGridViewCellStyle1;
            this.sales_group.HeaderText = "所屬組別";
            this.sales_group.Name = "sales_group";
            this.sales_group.ReadOnly = true;
            this.sales_group.ToolTipText = "t_group";
            this.sales_group.Width = 90;
            // 
            // abbrev_id
            // 
            this.abbrev_id.DataPropertyName = "abbrev_id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.abbrev_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.abbrev_id.HeaderText = "簡寫編號";
            this.abbrev_id.Name = "abbrev_id";
            this.abbrev_id.ReadOnly = true;
            this.abbrev_id.ToolTipText = "t_abbrev_id";
            this.abbrev_id.Width = 90;
            // 
            // create_by
            // 
            this.create_by.DataPropertyName = "create_by";
            this.create_by.HeaderText = "建档人";
            this.create_by.Name = "create_by";
            this.create_by.ReadOnly = true;
            this.create_by.ToolTipText = "t_create_by";
            this.create_by.Visible = false;
            this.create_by.Width = 90;
            // 
            // create_date
            // 
            this.create_date.DataPropertyName = "create_date";
            this.create_date.HeaderText = "建档日期";
            this.create_date.Name = "create_date";
            this.create_date.ReadOnly = true;
            this.create_date.ToolTipText = "t_create_date";
            this.create_date.Visible = false;
            // 
            // update_by
            // 
            this.update_by.DataPropertyName = "update_by";
            this.update_by.HeaderText = "修改人";
            this.update_by.Name = "update_by";
            this.update_by.ReadOnly = true;
            this.update_by.ToolTipText = "t_update_by";
            this.update_by.Width = 90;
            // 
            // update_date
            // 
            this.update_date.DataPropertyName = "update_date";
            this.update_date.HeaderText = "修改日期";
            this.update_date.Name = "update_date";
            this.update_date.ReadOnly = true;
            this.update_date.ToolTipText = "t_update_date";
            this.update_date.Width = 150;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "State";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.ToolTipText = "t_state";
            this.state.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtupdate_date);
            this.panel1.Controls.Add(this.txtupdate_by);
            this.panel1.Controls.Add(this.txtcreate_date);
            this.panel1.Controls.Add(this.txtcreate_by);
            this.panel1.Controls.Add(this.luestate);
            this.panel1.Controls.Add(this.t_state);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.luegroup);
            this.panel1.Controls.Add(this.txtabbrev_id);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtenglish_name);
            this.panel1.Controls.Add(this.t_english_name);
            this.panel1.Controls.Add(this.lblSales_group);
            this.panel1.Controls.Add(this.t_name);
            this.panel1.Controls.Add(this.lblid);
            this.panel1.Controls.Add(this.t_update_date);
            this.panel1.Controls.Add(this.lblabbrev_id);
            this.panel1.Controls.Add(this.t_update_by);
            this.panel1.Controls.Add(this.t_create_by);
            this.panel1.Controls.Add(this.t_create_date);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.panel1.Location = new System.Drawing.Point(3, 43);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 100);
            this.panel1.TabIndex = 53;
            // 
            // txtupdate_date
            // 
            this.txtupdate_date.Enabled = false;
            this.txtupdate_date.Location = new System.Drawing.Point(740, 63);
            this.txtupdate_date.Name = "txtupdate_date";
            this.txtupdate_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtupdate_date.Properties.ReadOnly = true;
            this.txtupdate_date.Size = new System.Drawing.Size(160, 22);
            this.txtupdate_date.TabIndex = 192;
            this.txtupdate_date.Tag = "2";
            // 
            // txtupdate_by
            // 
            this.txtupdate_by.Enabled = false;
            this.txtupdate_by.Location = new System.Drawing.Point(540, 63);
            this.txtupdate_by.Name = "txtupdate_by";
            this.txtupdate_by.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtupdate_by.Properties.ReadOnly = true;
            this.txtupdate_by.Size = new System.Drawing.Size(117, 22);
            this.txtupdate_by.TabIndex = 191;
            this.txtupdate_by.Tag = "2";
            // 
            // txtcreate_date
            // 
            this.txtcreate_date.Enabled = false;
            this.txtcreate_date.Location = new System.Drawing.Point(305, 63);
            this.txtcreate_date.Name = "txtcreate_date";
            this.txtcreate_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcreate_date.Properties.ReadOnly = true;
            this.txtcreate_date.Size = new System.Drawing.Size(150, 22);
            this.txtcreate_date.TabIndex = 190;
            this.txtcreate_date.Tag = "2";
            // 
            // txtcreate_by
            // 
            this.txtcreate_by.Enabled = false;
            this.txtcreate_by.Location = new System.Drawing.Point(107, 63);
            this.txtcreate_by.Name = "txtcreate_by";
            this.txtcreate_by.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcreate_by.Properties.ReadOnly = true;
            this.txtcreate_by.Size = new System.Drawing.Size(114, 22);
            this.txtcreate_by.TabIndex = 189;
            this.txtcreate_by.Tag = "2";
            // 
            // luestate
            // 
            this.luestate.EditValue = "";
            this.luestate.Enabled = false;
            this.luestate.Location = new System.Drawing.Point(740, 5);
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
            this.luestate.Size = new System.Drawing.Size(160, 22);
            this.luestate.TabIndex = 2;
            this.luestate.Tag = "2";
            // 
            // t_state
            // 
            this.t_state.Location = new System.Drawing.Point(660, 8);
            this.t_state.Name = "t_state";
            this.t_state.Size = new System.Drawing.Size(77, 16);
            this.t_state.TabIndex = 188;
            this.t_state.Tag = "t_state";
            this.t_state.Text = "狀態";
            this.t_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtid
            // 
            this.txtid.EnterMoveNextControl = true;
            this.txtid.Location = new System.Drawing.Point(107, 5);
            this.txtid.Name = "txtid";
            this.txtid.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Properties.MaxLength = 5;
            this.txtid.Size = new System.Drawing.Size(198, 22);
            this.txtid.TabIndex = 0;
            this.txtid.Tag = "2";
            // 
            // luegroup
            // 
            this.luegroup.EditValue = "";
            this.luegroup.EnterMoveNextControl = true;
            this.luegroup.Location = new System.Drawing.Point(740, 32);
            this.luegroup.Name = "luegroup";
            this.luegroup.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luegroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luegroup.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.luegroup.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 50, "Name1"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "Name2"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("english_name", 100, "Name5")});
            this.luegroup.Properties.DropDownRows = 15;
            this.luegroup.Properties.MaxLength = 5;
            this.luegroup.Properties.NullText = "";
            this.luegroup.Properties.PopupWidth = 250;
            this.luegroup.Properties.ShowHeader = false;
            this.luegroup.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luegroup.Size = new System.Drawing.Size(160, 22);
            this.luegroup.TabIndex = 5;
            this.luegroup.Tag = "1";
            // 
            // txtabbrev_id
            // 
            this.txtabbrev_id.EditValue = "";
            this.txtabbrev_id.EnterMoveNextControl = true;
            this.txtabbrev_id.Location = new System.Drawing.Point(451, 5);
            this.txtabbrev_id.Name = "txtabbrev_id";
            this.txtabbrev_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtabbrev_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtabbrev_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtabbrev_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtabbrev_id.Properties.MaxLength = 3;
            this.txtabbrev_id.Properties.ReadOnly = true;
            this.txtabbrev_id.Size = new System.Drawing.Size(206, 22);
            this.txtabbrev_id.TabIndex = 1;
            this.txtabbrev_id.Tag = "2";
            // 
            // txtname
            // 
            this.txtname.EditValue = "";
            this.txtname.EnterMoveNextControl = true;
            this.txtname.Location = new System.Drawing.Point(107, 32);
            this.txtname.Name = "txtname";
            this.txtname.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtname.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtname.Properties.MaxLength = 250;
            this.txtname.Properties.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(198, 22);
            this.txtname.TabIndex = 3;
            this.txtname.Tag = "2";
            // 
            // txtenglish_name
            // 
            this.txtenglish_name.EditValue = "";
            this.txtenglish_name.EnterMoveNextControl = true;
            this.txtenglish_name.Location = new System.Drawing.Point(451, 32);
            this.txtenglish_name.Name = "txtenglish_name";
            this.txtenglish_name.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtenglish_name.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtenglish_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtenglish_name.Properties.MaxLength = 250;
            this.txtenglish_name.Properties.ReadOnly = true;
            this.txtenglish_name.Size = new System.Drawing.Size(206, 22);
            this.txtenglish_name.TabIndex = 4;
            this.txtenglish_name.Tag = "2";
            // 
            // t_english_name
            // 
            this.t_english_name.Location = new System.Drawing.Point(366, 34);
            this.t_english_name.Name = "t_english_name";
            this.t_english_name.Size = new System.Drawing.Size(82, 16);
            this.t_english_name.TabIndex = 63;
            this.t_english_name.Tag = "t_english_name";
            this.t_english_name.Text = "名稱(英文)";
            this.t_english_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSales_group
            // 
            this.lblSales_group.Location = new System.Drawing.Point(660, 34);
            this.lblSales_group.Name = "lblSales_group";
            this.lblSales_group.Size = new System.Drawing.Size(77, 16);
            this.lblSales_group.TabIndex = 55;
            this.lblSales_group.Tag = "t_group";
            this.lblSales_group.Text = "所屬組別";
            this.lblSales_group.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_name
            // 
            this.t_name.ForeColor = System.Drawing.Color.Blue;
            this.t_name.Location = new System.Drawing.Point(5, 34);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(100, 16);
            this.t_name.TabIndex = 50;
            this.t_name.Tag = "t_name";
            this.t_name.Text = "名称";
            this.t_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmBsSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmBsSales";
            this.Tag = "Forms.frmBsSales";
            this.Text = "frmBsSales";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBsSales_FormClosed);
            this.Load += new System.EventHandler(this.frmBsSales_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luegroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtabbrev_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label t_update_date;
        private System.Windows.Forms.Label t_update_by;
        private System.Windows.Forms.Label t_create_date;
        private System.Windows.Forms.Label t_create_by;
        private System.Windows.Forms.Label lblabbrev_id;
        private System.Windows.Forms.Label lblid;
        private System.Windows.Forms.BindingSource bds1;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnFind;
        private System.Windows.Forms.Label t_name;
        private System.Windows.Forms.Label lblSales_group;
        private DevExpress.XtraEditors.TextEdit txtenglish_name;
        private System.Windows.Forms.Label t_english_name;
        private DevExpress.XtraEditors.TextEdit txtname;
        private DevExpress.XtraEditors.TextEdit txtabbrev_id;
        private DevExpress.XtraEditors.LookUpEdit luegroup;
        private DevExpress.XtraEditors.TextEdit txtid;
        private DevExpress.XtraEditors.LookUpEdit luestate;
        private System.Windows.Forms.Label t_state;
        private DevExpress.XtraEditors.TextEdit txtupdate_date;
        private DevExpress.XtraEditors.TextEdit txtupdate_by;
        private DevExpress.XtraEditors.TextEdit txtcreate_date;
        private DevExpress.XtraEditors.TextEdit txtcreate_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn english_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn sales_group;
        private System.Windows.Forms.DataGridViewTextBoxColumn abbrev_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}