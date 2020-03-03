﻿namespace cfvn.Forms
{
    partial class frmBsMoney
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
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.currency_sign = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.country_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bp_formula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sunaccount_rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.luestate = new DevExpress.XtraEditors.LookUpEdit();
            this.t_state = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtcurrency_sign = new DevExpress.XtraEditors.TextEdit();
            this.lblSunaccount_rate = new System.Windows.Forms.Label();
            this.txtSunaccount_rate = new DevExpress.XtraEditors.TextEdit();
            this.lblBp_formula = new System.Windows.Forms.Label();
            this.txtBp_formula = new DevExpress.XtraEditors.TextEdit();
            this.lblCountry_id = new System.Windows.Forms.Label();
            this.txtCountry_id = new DevExpress.XtraEditors.LookUpEdit();
            this.lblAmtim = new System.Windows.Forms.Label();
            this.lblAmusr = new System.Windows.Forms.Label();
            this.lblCrtim = new System.Windows.Forms.Label();
            this.lblCrusr = new System.Windows.Forms.Label();
            this.txtupdate_date = new DevExpress.XtraEditors.TextEdit();
            this.txtupdate_by = new DevExpress.XtraEditors.TextEdit();
            this.txtcreate_date = new DevExpress.XtraEditors.TextEdit();
            this.txtcreate_by = new DevExpress.XtraEditors.TextEdit();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblEdesc = new System.Windows.Forms.Label();
            this.txtenglish_name = new DevExpress.XtraEditors.TextEdit();
            this.lblCdesc = new System.Windows.Forms.Label();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.lblID = new System.Windows.Forms.Label();
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.txtRemark = new DevExpress.XtraEditors.MemoEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNEXIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNNEW = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNEDIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNSAVE = new System.Windows.Forms.ToolStripButton();
            this.BTNCANCEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNDELETE = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNFIND = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNPRINT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNEXCEL = new System.Windows.Forms.ToolStripButton();
            this.bds1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcurrency_sign.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSunaccount_rate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBp_formula.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry_id.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).BeginInit();
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
            this.dgvDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.english_name,
            this.currency_sign,
            this.country_id,
            this.remark,
            this.bp_formula,
            this.sunaccount_rate,
            this.state,
            this.create_by,
            this.create_date,
            this.update_by,
            this.update_date});
            this.dgvDetails.Location = new System.Drawing.Point(1, 231);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.ShowCellToolTips = false;
            this.dgvDetails.Size = new System.Drawing.Size(951, 258);
            this.dgvDetails.TabIndex = 9;
            this.dgvDetails.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dgvDetails_RowPostPaint);
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
            this.name.Width = 120;
            // 
            // english_name
            // 
            this.english_name.DataPropertyName = "english_name";
            this.english_name.HeaderText = "英文名稱";
            this.english_name.Name = "english_name";
            this.english_name.ReadOnly = true;
            this.english_name.ToolTipText = "t_english_name";
            this.english_name.Width = 120;
            // 
            // currency_sign
            // 
            this.currency_sign.DataPropertyName = "currency_sign";
            this.currency_sign.HeaderText = "貨幣符號";
            this.currency_sign.Name = "currency_sign";
            this.currency_sign.ReadOnly = true;
            this.currency_sign.ToolTipText = "t_currency_sign";
            this.currency_sign.Width = 110;
            // 
            // country_id
            // 
            this.country_id.DataPropertyName = "country_id";
            this.country_id.HeaderText = "所屬國家";
            this.country_id.Name = "country_id";
            this.country_id.ReadOnly = true;
            this.country_id.ToolTipText = "t_country";
            this.country_id.Width = 80;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "備註";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.ToolTipText = "t_remark";
            this.remark.Width = 110;
            // 
            // bp_formula
            // 
            this.bp_formula.DataPropertyName = "bp_formula";
            this.bp_formula.HeaderText = "PB價公式";
            this.bp_formula.Name = "bp_formula";
            this.bp_formula.ReadOnly = true;
            this.bp_formula.ToolTipText = "t_bp_formula";
            this.bp_formula.Width = 120;
            // 
            // sunaccount_rate
            // 
            this.sunaccount_rate.DataPropertyName = "sunaccount_rate";
            this.sunaccount_rate.HeaderText = "SunAccount 匯率";
            this.sunaccount_rate.Name = "sunaccount_rate";
            this.sunaccount_rate.ReadOnly = true;
            this.sunaccount_rate.ToolTipText = "t_sunaccount_rate";
            this.sunaccount_rate.Width = 120;
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
            this.panel1.Controls.Add(this.luestate);
            this.panel1.Controls.Add(this.t_state);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtcurrency_sign);
            this.panel1.Controls.Add(this.lblSunaccount_rate);
            this.panel1.Controls.Add(this.txtSunaccount_rate);
            this.panel1.Controls.Add(this.lblBp_formula);
            this.panel1.Controls.Add(this.txtBp_formula);
            this.panel1.Controls.Add(this.lblCountry_id);
            this.panel1.Controls.Add(this.txtCountry_id);
            this.panel1.Controls.Add(this.lblAmtim);
            this.panel1.Controls.Add(this.lblAmusr);
            this.panel1.Controls.Add(this.lblCrtim);
            this.panel1.Controls.Add(this.lblCrusr);
            this.panel1.Controls.Add(this.txtupdate_date);
            this.panel1.Controls.Add(this.txtupdate_by);
            this.panel1.Controls.Add(this.txtcreate_date);
            this.panel1.Controls.Add(this.txtcreate_by);
            this.panel1.Controls.Add(this.lblRemark);
            this.panel1.Controls.Add(this.lblEdesc);
            this.panel1.Controls.Add(this.txtenglish_name);
            this.panel1.Controls.Add(this.lblCdesc);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.panel1.Location = new System.Drawing.Point(1, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 201);
            this.panel1.TabIndex = 11;
            // 
            // luestate
            // 
            this.luestate.EditValue = "";
            this.luestate.Enabled = false;
            this.luestate.Location = new System.Drawing.Point(569, 62);
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
            this.luestate.Size = new System.Drawing.Size(163, 20);
            this.luestate.TabIndex = 191;
            this.luestate.Tag = "2";
            // 
            // t_state
            // 
            this.t_state.Location = new System.Drawing.Point(482, 64);
            this.t_state.Name = "t_state";
            this.t_state.Size = new System.Drawing.Size(85, 16);
            this.t_state.TabIndex = 192;
            this.t_state.Tag = "t_state";
            this.t_state.Text = "狀態";
            this.t_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(274, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 36;
            this.label1.Tag = "t_currency_sign";
            this.label1.Text = "貨幣符號";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtcurrency_sign
            // 
            this.txtcurrency_sign.EnterMoveNextControl = true;
            this.txtcurrency_sign.Location = new System.Drawing.Point(350, 9);
            this.txtcurrency_sign.Name = "txtcurrency_sign";
            this.txtcurrency_sign.Properties.ReadOnly = true;
            this.txtcurrency_sign.Size = new System.Drawing.Size(122, 20);
            this.txtcurrency_sign.TabIndex = 35;
            this.txtcurrency_sign.Tag = "2";
            // 
            // lblSunaccount_rate
            // 
            this.lblSunaccount_rate.Location = new System.Drawing.Point(239, 117);
            this.lblSunaccount_rate.Name = "lblSunaccount_rate";
            this.lblSunaccount_rate.Size = new System.Drawing.Size(107, 15);
            this.lblSunaccount_rate.TabIndex = 34;
            this.lblSunaccount_rate.Tag = "t_sunaccount_rate";
            this.lblSunaccount_rate.Text = "SunAccount 匯率";
            this.lblSunaccount_rate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSunaccount_rate
            // 
            this.txtSunaccount_rate.EnterMoveNextControl = true;
            this.txtSunaccount_rate.Location = new System.Drawing.Point(350, 115);
            this.txtSunaccount_rate.Name = "txtSunaccount_rate";
            this.txtSunaccount_rate.Properties.Mask.EditMask = "n";
            this.txtSunaccount_rate.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSunaccount_rate.Properties.ReadOnly = true;
            this.txtSunaccount_rate.Size = new System.Drawing.Size(122, 20);
            this.txtSunaccount_rate.TabIndex = 5;
            this.txtSunaccount_rate.Tag = "2";
            // 
            // lblBp_formula
            // 
            this.lblBp_formula.Location = new System.Drawing.Point(9, 117);
            this.lblBp_formula.Name = "lblBp_formula";
            this.lblBp_formula.Size = new System.Drawing.Size(73, 13);
            this.lblBp_formula.TabIndex = 32;
            this.lblBp_formula.Tag = "t_bp_formula";
            this.lblBp_formula.Text = "BP價公式";
            this.lblBp_formula.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtBp_formula
            // 
            this.txtBp_formula.EnterMoveNextControl = true;
            this.txtBp_formula.Location = new System.Drawing.Point(89, 114);
            this.txtBp_formula.Name = "txtBp_formula";
            this.txtBp_formula.Properties.ReadOnly = true;
            this.txtBp_formula.Size = new System.Drawing.Size(148, 20);
            this.txtBp_formula.TabIndex = 4;
            this.txtBp_formula.Tag = "2";
            // 
            // lblCountry_id
            // 
            this.lblCountry_id.ForeColor = System.Drawing.Color.Blue;
            this.lblCountry_id.Location = new System.Drawing.Point(5, 92);
            this.lblCountry_id.Name = "lblCountry_id";
            this.lblCountry_id.Size = new System.Drawing.Size(79, 13);
            this.lblCountry_id.TabIndex = 22;
            this.lblCountry_id.Tag = "t_country";
            this.lblCountry_id.Text = "所屬國家";
            this.lblCountry_id.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCountry_id
            // 
            this.txtCountry_id.EditValue = "";
            this.txtCountry_id.Enabled = false;
            this.txtCountry_id.EnterMoveNextControl = true;
            this.txtCountry_id.Location = new System.Drawing.Point(89, 88);
            this.txtCountry_id.Name = "txtCountry_id";
            this.txtCountry_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCountry_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtCountry_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtCountry_id.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCountry_id.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.txtCountry_id.Properties.DropDownRows = 15;
            this.txtCountry_id.Properties.MaxLength = 2;
            this.txtCountry_id.Properties.NullText = "";
            this.txtCountry_id.Properties.PopupWidth = 130;
            this.txtCountry_id.Properties.ShowHeader = false;
            this.txtCountry_id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtCountry_id.Size = new System.Drawing.Size(148, 20);
            this.txtCountry_id.TabIndex = 3;
            this.txtCountry_id.Tag = "2";
            // 
            // lblAmtim
            // 
            this.lblAmtim.Location = new System.Drawing.Point(482, 174);
            this.lblAmtim.Name = "lblAmtim";
            this.lblAmtim.Size = new System.Drawing.Size(85, 13);
            this.lblAmtim.TabIndex = 15;
            this.lblAmtim.Tag = "t_update_date";
            this.lblAmtim.Text = "修改日期";
            this.lblAmtim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmusr
            // 
            this.lblAmusr.Location = new System.Drawing.Point(482, 145);
            this.lblAmusr.Name = "lblAmusr";
            this.lblAmusr.Size = new System.Drawing.Size(85, 13);
            this.lblAmusr.TabIndex = 14;
            this.lblAmusr.Tag = "t_update_by";
            this.lblAmusr.Text = "修改人";
            this.lblAmusr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCrtim
            // 
            this.lblCrtim.Location = new System.Drawing.Point(482, 119);
            this.lblCrtim.Name = "lblCrtim";
            this.lblCrtim.Size = new System.Drawing.Size(85, 13);
            this.lblCrtim.TabIndex = 13;
            this.lblCrtim.Tag = "t_create_date";
            this.lblCrtim.Text = "建檔日期";
            this.lblCrtim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCrusr
            // 
            this.lblCrusr.Location = new System.Drawing.Point(482, 90);
            this.lblCrusr.Name = "lblCrusr";
            this.lblCrusr.Size = new System.Drawing.Size(85, 15);
            this.lblCrusr.TabIndex = 12;
            this.lblCrusr.Tag = "t_create_by";
            this.lblCrusr.Text = "建檔人";
            this.lblCrusr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtupdate_date
            // 
            this.txtupdate_date.Enabled = false;
            this.txtupdate_date.Location = new System.Drawing.Point(569, 171);
            this.txtupdate_date.Name = "txtupdate_date";
            this.txtupdate_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtupdate_date.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtupdate_date.Properties.ReadOnly = true;
            this.txtupdate_date.Size = new System.Drawing.Size(163, 20);
            this.txtupdate_date.TabIndex = 10;
            this.txtupdate_date.Tag = "2";
            // 
            // txtupdate_by
            // 
            this.txtupdate_by.Enabled = false;
            this.txtupdate_by.Location = new System.Drawing.Point(569, 144);
            this.txtupdate_by.Name = "txtupdate_by";
            this.txtupdate_by.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtupdate_by.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtupdate_by.Properties.ReadOnly = true;
            this.txtupdate_by.Size = new System.Drawing.Size(163, 20);
            this.txtupdate_by.TabIndex = 9;
            this.txtupdate_by.Tag = "2";
            // 
            // txtcreate_date
            // 
            this.txtcreate_date.Enabled = false;
            this.txtcreate_date.Location = new System.Drawing.Point(569, 115);
            this.txtcreate_date.Name = "txtcreate_date";
            this.txtcreate_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcreate_date.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtcreate_date.Properties.ReadOnly = true;
            this.txtcreate_date.Size = new System.Drawing.Size(163, 20);
            this.txtcreate_date.TabIndex = 8;
            this.txtcreate_date.Tag = "2";
            // 
            // txtcreate_by
            // 
            this.txtcreate_by.Enabled = false;
            this.txtcreate_by.Location = new System.Drawing.Point(569, 88);
            this.txtcreate_by.Name = "txtcreate_by";
            this.txtcreate_by.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcreate_by.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtcreate_by.Properties.ReadOnly = true;
            this.txtcreate_by.Size = new System.Drawing.Size(163, 20);
            this.txtcreate_by.TabIndex = 7;
            this.txtcreate_by.Tag = "2";
            // 
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(-12, 142);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(96, 13);
            this.lblRemark.TabIndex = 7;
            this.lblRemark.Tag = "t_remark";
            this.lblRemark.Text = "備注";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEdesc
            // 
            this.lblEdesc.Location = new System.Drawing.Point(7, 64);
            this.lblEdesc.Name = "lblEdesc";
            this.lblEdesc.Size = new System.Drawing.Size(77, 13);
            this.lblEdesc.TabIndex = 5;
            this.lblEdesc.Tag = "t_english_name";
            this.lblEdesc.Text = "英文名稱";
            this.lblEdesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtenglish_name
            // 
            this.txtenglish_name.EnterMoveNextControl = true;
            this.txtenglish_name.Location = new System.Drawing.Point(89, 62);
            this.txtenglish_name.Name = "txtenglish_name";
            this.txtenglish_name.Properties.ReadOnly = true;
            this.txtenglish_name.Size = new System.Drawing.Size(383, 20);
            this.txtenglish_name.TabIndex = 2;
            this.txtenglish_name.Tag = "2";
            // 
            // lblCdesc
            // 
            this.lblCdesc.ForeColor = System.Drawing.Color.Blue;
            this.lblCdesc.Location = new System.Drawing.Point(7, 39);
            this.lblCdesc.Name = "lblCdesc";
            this.lblCdesc.Size = new System.Drawing.Size(77, 13);
            this.lblCdesc.TabIndex = 3;
            this.lblCdesc.Tag = "t_name";
            this.lblCdesc.Text = "中文名稱";
            this.lblCdesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtname
            // 
            this.txtname.EnterMoveNextControl = true;
            this.txtname.Location = new System.Drawing.Point(89, 36);
            this.txtname.Name = "txtname";
            this.txtname.Properties.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(383, 20);
            this.txtname.TabIndex = 1;
            this.txtname.Tag = "2";
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(6, 14);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Tag = "t_id";
            this.lblID.Text = "編號";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtid
            // 
            this.txtid.EnterMoveNextControl = true;
            this.txtid.Location = new System.Drawing.Point(89, 10);
            this.txtid.Name = "txtid";
            this.txtid.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtid.Properties.MaxLength = 10;
            this.txtid.Properties.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(148, 20);
            this.txtid.TabIndex = 0;
            this.txtid.Tag = "2";
            this.txtid.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(89, 141);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Properties.MaxLength = 255;
            this.txtRemark.Properties.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(383, 50);
            this.txtRemark.TabIndex = 6;
            this.txtRemark.Tag = "2";
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
            this.toolStripSeparator6,
            this.BTNSAVE,
            this.BTNCANCEL,
            this.toolStripSeparator3,
            this.BTNDELETE,
            this.toolStripSeparator4,
            this.BTNFIND,
            this.toolStripSeparator7,
            this.BTNPRINT,
            this.toolStripSeparator8,
            this.BTNEXCEL});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(953, 25);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
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
            // BTNEXCEL
            // 
            this.BTNEXCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEXCEL.Name = "BTNEXCEL";
            this.BTNEXCEL.Size = new System.Drawing.Size(70, 22);
            this.BTNEXCEL.Text = "匯出EXCEL";
            this.BTNEXCEL.Click += new System.EventHandler(this.BTNEXCEL_Click);
            // 
            // frmBsMoney
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 490);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmBsMoney";
            this.Tag = "Forms.frmBsMoney";
            this.Text = "frmBsMoney";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmBsMoney_FormClosed);
            this.Load += new System.EventHandler(this.frmBsMoney_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcurrency_sign.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSunaccount_rate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBp_formula.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtCountry_id.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRemark.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSunaccount_rate;
        private DevExpress.XtraEditors.TextEdit txtSunaccount_rate;
        private System.Windows.Forms.Label lblBp_formula;
        private DevExpress.XtraEditors.TextEdit txtBp_formula;
        private System.Windows.Forms.Label lblCountry_id;
        private DevExpress.XtraEditors.LookUpEdit txtCountry_id;
        private System.Windows.Forms.Label lblAmtim;
        private System.Windows.Forms.Label lblAmusr;
        private System.Windows.Forms.Label lblCrtim;
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
        private System.Windows.Forms.ToolStripButton BTNEXCEL;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit txtcurrency_sign;
        private DevExpress.XtraEditors.LookUpEdit luestate;
        private System.Windows.Forms.Label t_state;
        private System.Windows.Forms.BindingSource bds1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn english_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn currency_sign;
        private System.Windows.Forms.DataGridViewTextBoxColumn country_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn bp_formula;
        private System.Windows.Forms.DataGridViewTextBoxColumn sunaccount_rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_date;
    }
}