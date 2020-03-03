namespace cfvn.Forms
{
    partial class frmBsType
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.luestate = new DevExpress.XtraEditors.LookUpEdit();
            this.lblstate = new System.Windows.Forms.Label();
            this.lblgroup_id = new System.Windows.Forms.Label();
            this.txtgroup_id = new DevExpress.XtraEditors.LookUpEdit();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblupdate_date = new System.Windows.Forms.Label();
            this.lblupdate_by = new System.Windows.Forms.Label();
            this.lblcreate_date = new System.Windows.Forms.Label();
            this.lblcreate_by = new System.Windows.Forms.Label();
            this.txtupdate_date = new DevExpress.XtraEditors.TextEdit();
            this.txtupdate_by = new DevExpress.XtraEditors.TextEdit();
            this.txtcreate_date = new DevExpress.XtraEditors.TextEdit();
            this.txtcreate_by = new DevExpress.XtraEditors.TextEdit();
            this.lblenglish_name = new System.Windows.Forms.Label();
            this.txtenglish_name = new DevExpress.XtraEditors.TextEdit();
            this.lblname = new System.Windows.Forms.Label();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.lblID = new System.Windows.Forms.Label();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNEXIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNNEW = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNEDIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNSAVE = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNCANCEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNDELETE = new System.Windows.Forms.ToolStripButton();
            this.BTNFIND = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNPRINT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNEXCEL = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgroup_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.dgvDetails.ColumnHeadersHeight = 20;
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.group_id,
            this.id,
            this.name,
            this.english_name,
            this.remark,
            this.state,
            this.create_by,
            this.create_date,
            this.update_by,
            this.update_date});
            this.dgvDetails.Location = new System.Drawing.Point(1, 181);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.ShowCellToolTips = false;
            this.dgvDetails.Size = new System.Drawing.Size(947, 283);
            this.dgvDetails.TabIndex = 25;
            this.dgvDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDetails_RowPostPaint);
            this.dgvDetails.SelectionChanged += new System.EventHandler(this.dgvDetails_SelectionChanged);
            // 
            // group_id
            // 
            this.group_id.DataPropertyName = "group_id";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.group_id.DefaultCellStyle = dataGridViewCellStyle1;
            this.group_id.HeaderText = "類型組別";
            this.group_id.Name = "group_id";
            this.group_id.ReadOnly = true;
            this.group_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.group_id.ToolTipText = "t_type_group";
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.id.DefaultCellStyle = dataGridViewCellStyle2;
            this.id.HeaderText = "編號";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.ToolTipText = "t_id";
            this.id.Width = 60;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名稱";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.ToolTipText = "t_name";
            this.name.Width = 200;
            // 
            // english_name
            // 
            this.english_name.DataPropertyName = "english_name";
            this.english_name.HeaderText = "名稱(英文)";
            this.english_name.Name = "english_name";
            this.english_name.ReadOnly = true;
            this.english_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.english_name.ToolTipText = "t_english_name";
            this.english_name.Width = 200;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "備註";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.remark.ToolTipText = "t_remark";
            this.remark.Width = 150;
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "state";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.ToolTipText = "t_state";
            this.state.Visible = false;
            // 
            // create_by
            // 
            this.create_by.DataPropertyName = "create_by";
            this.create_by.HeaderText = "Create by";
            this.create_by.Name = "create_by";
            this.create_by.ReadOnly = true;
            this.create_by.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.create_by.Visible = false;
            // 
            // create_date
            // 
            this.create_date.DataPropertyName = "create_date";
            this.create_date.HeaderText = "Create date";
            this.create_date.Name = "create_date";
            this.create_date.ReadOnly = true;
            this.create_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.create_date.Visible = false;
            // 
            // update_by
            // 
            this.update_by.DataPropertyName = "update_by";
            this.update_by.HeaderText = "Update by";
            this.update_by.Name = "update_by";
            this.update_by.ReadOnly = true;
            this.update_by.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.update_by.Visible = false;
            // 
            // update_date
            // 
            this.update_date.DataPropertyName = "update_date";
            this.update_date.HeaderText = "Update date";
            this.update_date.Name = "update_date";
            this.update_date.ReadOnly = true;
            this.update_date.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.update_date.Visible = false;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.luestate);
            this.panel1.Controls.Add(this.lblstate);
            this.panel1.Controls.Add(this.lblgroup_id);
            this.panel1.Controls.Add(this.txtgroup_id);
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.lblRemark);
            this.panel1.Controls.Add(this.lblupdate_date);
            this.panel1.Controls.Add(this.lblupdate_by);
            this.panel1.Controls.Add(this.lblcreate_date);
            this.panel1.Controls.Add(this.lblcreate_by);
            this.panel1.Controls.Add(this.txtupdate_date);
            this.panel1.Controls.Add(this.txtupdate_by);
            this.panel1.Controls.Add(this.txtcreate_date);
            this.panel1.Controls.Add(this.txtcreate_by);
            this.panel1.Controls.Add(this.lblenglish_name);
            this.panel1.Controls.Add(this.txtenglish_name);
            this.panel1.Controls.Add(this.lblname);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Location = new System.Drawing.Point(1, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 141);
            this.panel1.TabIndex = 19;
            // 
            // luestate
            // 
            this.luestate.EditValue = "";
            this.luestate.Enabled = false;
            this.luestate.Location = new System.Drawing.Point(582, 7);
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
            this.luestate.Size = new System.Drawing.Size(126, 20);
            this.luestate.TabIndex = 189;
            this.luestate.Tag = "2";
            // 
            // lblstate
            // 
            this.lblstate.Location = new System.Drawing.Point(504, 10);
            this.lblstate.Name = "lblstate";
            this.lblstate.Size = new System.Drawing.Size(77, 14);
            this.lblstate.TabIndex = 190;
            this.lblstate.Tag = "t_state";
            this.lblstate.Text = "狀態";
            this.lblstate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblgroup_id
            // 
            this.lblgroup_id.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblgroup_id.ForeColor = System.Drawing.Color.Blue;
            this.lblgroup_id.Location = new System.Drawing.Point(10, 10);
            this.lblgroup_id.Name = "lblgroup_id";
            this.lblgroup_id.Size = new System.Drawing.Size(76, 14);
            this.lblgroup_id.TabIndex = 44;
            this.lblgroup_id.Tag = "t_type_group";
            this.lblgroup_id.Text = "類型組別";
            this.lblgroup_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtgroup_id
            // 
            this.txtgroup_id.EditValue = "";
            this.txtgroup_id.Enabled = false;
            this.txtgroup_id.EnterMoveNextControl = true;
            this.txtgroup_id.Location = new System.Drawing.Point(89, 8);
            this.txtgroup_id.Name = "txtgroup_id";
            this.txtgroup_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtgroup_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtgroup_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtgroup_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtgroup_id.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "Name")});
            this.txtgroup_id.Properties.DropDownRows = 15;
            this.txtgroup_id.Properties.MaxLength = 5;
            this.txtgroup_id.Properties.NullText = "";
            this.txtgroup_id.Properties.PopupWidth = 190;
            this.txtgroup_id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtgroup_id.Size = new System.Drawing.Size(208, 20);
            this.txtgroup_id.TabIndex = 5;
            this.txtgroup_id.Tag = "2";
            // 
            // txtRemark
            // 
            this.txtRemark.EnterMoveNextControl = true;
            this.txtRemark.Location = new System.Drawing.Point(89, 89);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.MaxLength = 200;
            this.txtRemark.Properties.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(377, 40);
            this.txtRemark.TabIndex = 9;
            this.txtRemark.Tag = "2";
            // 
            // lblRemark
            // 
            this.lblRemark.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblRemark.Location = new System.Drawing.Point(10, 88);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(76, 13);
            this.lblRemark.TabIndex = 17;
            this.lblRemark.Tag = "t_remark";
            this.lblRemark.Text = "備註";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblupdate_date
            // 
            this.lblupdate_date.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblupdate_date.Location = new System.Drawing.Point(505, 112);
            this.lblupdate_date.Name = "lblupdate_date";
            this.lblupdate_date.Size = new System.Drawing.Size(74, 13);
            this.lblupdate_date.TabIndex = 15;
            this.lblupdate_date.Tag = "t_update_date";
            this.lblupdate_date.Text = "修改日期";
            this.lblupdate_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblupdate_by
            // 
            this.lblupdate_by.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblupdate_by.Location = new System.Drawing.Point(505, 86);
            this.lblupdate_by.Name = "lblupdate_by";
            this.lblupdate_by.Size = new System.Drawing.Size(74, 13);
            this.lblupdate_by.TabIndex = 14;
            this.lblupdate_by.Tag = "t_update_by";
            this.lblupdate_by.Text = "修改人";
            this.lblupdate_by.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcreate_date
            // 
            this.lblcreate_date.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblcreate_date.Location = new System.Drawing.Point(505, 62);
            this.lblcreate_date.Name = "lblcreate_date";
            this.lblcreate_date.Size = new System.Drawing.Size(74, 13);
            this.lblcreate_date.TabIndex = 13;
            this.lblcreate_date.Tag = "t_create_date";
            this.lblcreate_date.Text = "建檔日期";
            this.lblcreate_date.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblcreate_by
            // 
            this.lblcreate_by.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblcreate_by.Location = new System.Drawing.Point(505, 37);
            this.lblcreate_by.Name = "lblcreate_by";
            this.lblcreate_by.Size = new System.Drawing.Size(74, 13);
            this.lblcreate_by.TabIndex = 12;
            this.lblcreate_by.Tag = "t_create_by";
            this.lblcreate_by.Text = "建檔人";
            this.lblcreate_by.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtupdate_date
            // 
            this.txtupdate_date.Enabled = false;
            this.txtupdate_date.Location = new System.Drawing.Point(582, 109);
            this.txtupdate_date.Name = "txtupdate_date";
            this.txtupdate_date.Properties.ReadOnly = true;
            this.txtupdate_date.Size = new System.Drawing.Size(126, 20);
            this.txtupdate_date.TabIndex = 11;
            this.txtupdate_date.Tag = "2";
            // 
            // txtupdate_by
            // 
            this.txtupdate_by.Enabled = false;
            this.txtupdate_by.Location = new System.Drawing.Point(582, 84);
            this.txtupdate_by.Name = "txtupdate_by";
            this.txtupdate_by.Properties.ReadOnly = true;
            this.txtupdate_by.Size = new System.Drawing.Size(126, 20);
            this.txtupdate_by.TabIndex = 10;
            this.txtupdate_by.Tag = "2";
            // 
            // txtcreate_date
            // 
            this.txtcreate_date.Enabled = false;
            this.txtcreate_date.Location = new System.Drawing.Point(582, 59);
            this.txtcreate_date.Name = "txtcreate_date";
            this.txtcreate_date.Properties.ReadOnly = true;
            this.txtcreate_date.Size = new System.Drawing.Size(126, 20);
            this.txtcreate_date.TabIndex = 9;
            this.txtcreate_date.Tag = "2";
            // 
            // txtcreate_by
            // 
            this.txtcreate_by.Enabled = false;
            this.txtcreate_by.Location = new System.Drawing.Point(582, 34);
            this.txtcreate_by.Name = "txtcreate_by";
            this.txtcreate_by.Properties.ReadOnly = true;
            this.txtcreate_by.Size = new System.Drawing.Size(126, 20);
            this.txtcreate_by.TabIndex = 8;
            this.txtcreate_by.Tag = "2";
            // 
            // lblenglish_name
            // 
            this.lblenglish_name.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblenglish_name.Location = new System.Drawing.Point(10, 65);
            this.lblenglish_name.Name = "lblenglish_name";
            this.lblenglish_name.Size = new System.Drawing.Size(76, 13);
            this.lblenglish_name.TabIndex = 5;
            this.lblenglish_name.Tag = "t_english_name";
            this.lblenglish_name.Text = "英文名稱";
            this.lblenglish_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtenglish_name
            // 
            this.txtenglish_name.EnterMoveNextControl = true;
            this.txtenglish_name.Location = new System.Drawing.Point(89, 62);
            this.txtenglish_name.Name = "txtenglish_name";
            this.txtenglish_name.Properties.MaxLength = 120;
            this.txtenglish_name.Properties.ReadOnly = true;
            this.txtenglish_name.Size = new System.Drawing.Size(377, 20);
            this.txtenglish_name.TabIndex = 2;
            this.txtenglish_name.Tag = "2";
            // 
            // lblname
            // 
            this.lblname.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblname.ForeColor = System.Drawing.Color.Blue;
            this.lblname.Location = new System.Drawing.Point(10, 37);
            this.lblname.Name = "lblname";
            this.lblname.Size = new System.Drawing.Size(76, 13);
            this.lblname.TabIndex = 3;
            this.lblname.Tag = "t_name";
            this.lblname.Text = "名稱";
            this.lblname.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtname
            // 
            this.txtname.EnterMoveNextControl = true;
            this.txtname.Location = new System.Drawing.Point(89, 35);
            this.txtname.Name = "txtname";
            this.txtname.Properties.MaxLength = 120;
            this.txtname.Properties.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(377, 20);
            this.txtname.TabIndex = 1;
            this.txtname.Tag = "2";
            // 
            // lblID
            // 
            this.lblID.Font = new System.Drawing.Font("Tahoma", 9F);
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(316, 10);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(66, 14);
            this.lblID.TabIndex = 1;
            this.lblID.Tag = "t_id";
            this.lblID.Text = "編號";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtid
            // 
            this.txtid.EnterMoveNextControl = true;
            this.txtid.Location = new System.Drawing.Point(384, 8);
            this.txtid.Name = "txtid";
            this.txtid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Properties.MaxLength = 4;
            this.txtid.Size = new System.Drawing.Size(82, 20);
            this.txtid.TabIndex = 0;
            this.txtid.Tag = "1";
            this.txtid.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BTNEXIT,
            this.toolStripSeparator1,
            this.BTNNEW,
            this.toolStripSeparator8,
            this.BTNEDIT,
            this.toolStripSeparator2,
            this.BTNSAVE,
            this.toolStripSeparator5,
            this.BTNCANCEL,
            this.toolStripSeparator3,
            this.toolStripSeparator4,
            this.BTNDELETE,
            this.BTNFIND,
            this.toolStripSeparator6,
            this.BTNPRINT,
            this.toolStripSeparator7,
            this.BTNEXCEL});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(950, 33);
            this.toolStrip1.TabIndex = 18;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.AutoSize = false;
            this.BTNEXIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(65, 30);
            this.BTNEXIT.Text = "退出(&X)";
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 33);
            // 
            // BTNNEW
            // 
            this.BTNNEW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNNEW.Name = "BTNNEW";
            this.BTNNEW.Size = new System.Drawing.Size(49, 30);
            this.BTNNEW.Text = "新增(&A)";
            this.BTNNEW.Click += new System.EventHandler(this.BTNNEW_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 33);
            // 
            // BTNEDIT
            // 
            this.BTNEDIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(48, 30);
            this.BTNEDIT.Text = "編輯(&E)";
            this.BTNEDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 33);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.Enabled = false;
            this.BTNSAVE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(47, 30);
            this.BTNSAVE.Text = "保存(&S)";
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 33);
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.Enabled = false;
            this.BTNCANCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(49, 30);
            this.BTNCANCEL.Text = "取消(&C)";
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 33);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 33);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(49, 30);
            this.BTNDELETE.Text = "刪除(&D)";
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // BTNFIND
            // 
            this.BTNFIND.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNFIND.Name = "BTNFIND";
            this.BTNFIND.Size = new System.Drawing.Size(47, 30);
            this.BTNFIND.Text = "查詢(&F)";
            this.BTNFIND.Click += new System.EventHandler(this.BTNFIND_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 33);
            // 
            // BTNPRINT
            // 
            this.BTNPRINT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNPRINT.Name = "BTNPRINT";
            this.BTNPRINT.Size = new System.Drawing.Size(47, 30);
            this.BTNPRINT.Text = "列印(&P)";
            this.BTNPRINT.Click += new System.EventHandler(this.BTNPRINT_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 33);
            // 
            // BTNEXCEL
            // 
            this.BTNEXCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEXCEL.Name = "BTNEXCEL";
            this.BTNEXCEL.Size = new System.Drawing.Size(70, 30);
            this.BTNEXCEL.Text = "匯出EXCEL";
            this.BTNEXCEL.Click += new System.EventHandler(this.BTNEXCEL_Click);
            // 
            // frmBsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 470);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmBsType";
            this.Tag = "Forms.frmBsType";
            this.Text = "類型資料";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBsType_FormClosed);
            this.Load += new System.EventHandler(this.frmBsType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtgroup_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblgroup_id;
        private DevExpress.XtraEditors.LookUpEdit txtgroup_id;
        private DevExpress.XtraEditors.MemoEdit txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblupdate_date;
        private System.Windows.Forms.Label lblupdate_by;
        private System.Windows.Forms.Label lblcreate_date;
        private System.Windows.Forms.Label lblcreate_by;
        private DevExpress.XtraEditors.TextEdit txtupdate_date;
        private DevExpress.XtraEditors.TextEdit txtupdate_by;
        private DevExpress.XtraEditors.TextEdit txtcreate_date;
        private DevExpress.XtraEditors.TextEdit txtcreate_by;
        private System.Windows.Forms.Label lblenglish_name;
        private DevExpress.XtraEditors.TextEdit txtenglish_name;
        private System.Windows.Forms.Label lblname;
        private DevExpress.XtraEditors.TextEdit txtname;
        private System.Windows.Forms.Label lblID;
        private DevExpress.XtraEditors.TextEdit txtid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTNEXIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTNNEW;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton BTNEDIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTNSAVE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BTNCANCEL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BTNDELETE;
        private System.Windows.Forms.ToolStripButton BTNFIND;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BTNPRINT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton BTNEXCEL;
        private DevExpress.XtraEditors.LookUpEdit luestate;
        private System.Windows.Forms.Label lblstate;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn english_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_date;
    }
}