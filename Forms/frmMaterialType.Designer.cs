namespace cfvn.Forms
{
    partial class frmMaterialType
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
            this.txtid = new DevExpress.XtraEditors.TextEdit();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BTNEXIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNNEW = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNEDIT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNDELETE = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNSAVE = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNCANCEL = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNPRINT = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.lblEdesc = new System.Windows.Forms.Label();
            this.txtenglish_name = new DevExpress.XtraEditors.TextEdit();
            this.lblCdesc = new System.Windows.Forms.Label();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.txtremark = new DevExpress.XtraEditors.MemoEdit();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.luestate = new DevExpress.XtraEditors.LookUpEdit();
            this.t_state = new System.Windows.Forms.Label();
            this.lblAmtim = new System.Windows.Forms.Label();
            this.lblAmusr = new System.Windows.Forms.Label();
            this.lblCrtim = new System.Windows.Forms.Label();
            this.lblCrusr = new System.Windows.Forms.Label();
            this.txtupdate_date = new DevExpress.XtraEditors.TextEdit();
            this.txtupdate_by = new DevExpress.XtraEditors.TextEdit();
            this.txtcreate_date = new DevExpress.XtraEditors.TextEdit();
            this.txtcreate_by = new DevExpress.XtraEditors.TextEdit();
            this.panel1 = new System.Windows.Forms.Panel();
            this.luedatum = new DevExpress.XtraEditors.LookUpEdit();
            this.label2 = new System.Windows.Forms.Label();
            this.bds1 = new System.Windows.Forms.BindingSource(this.components);
            this.grpbFind = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtmat_code1 = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtremark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luedatum.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).BeginInit();
            this.grpbFind.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtmat_code1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // txtid
            // 
            this.txtid.EditValue = "";
            this.txtid.EnterMoveNextControl = true;
            this.txtid.Location = new System.Drawing.Point(94, 4);
            this.txtid.Name = "txtid";
            this.txtid.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtid.Properties.MaxLength = 7;
            this.txtid.Size = new System.Drawing.Size(122, 22);
            this.txtid.TabIndex = 0;
            this.txtid.Tag = "2";
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
            this.BTNDELETE,
            this.toolStripSeparator10,
            this.BTNSAVE,
            this.toolStripSeparator6,
            this.BTNCANCEL,
            this.toolStripSeparator4,
            this.BTNPRINT,
            this.toolStripSeparator8});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(1016, 28);
            this.toolStrip1.TabIndex = 10;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BTNEXIT
            // 
            this.BTNEXIT.AutoSize = false;
            this.BTNEXIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEXIT.Name = "BTNEXIT";
            this.BTNEXIT.Size = new System.Drawing.Size(65, 25);
            this.BTNEXIT.Text = "退出(&X)";
            this.BTNEXIT.Click += new System.EventHandler(this.BTNEXIT_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // BTNNEW
            // 
            this.BTNNEW.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNNEW.Name = "BTNNEW";
            this.BTNNEW.Size = new System.Drawing.Size(49, 25);
            this.BTNNEW.Text = "新增(&N)";
            this.BTNNEW.Click += new System.EventHandler(this.BTNNEW_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 28);
            // 
            // BTNEDIT
            // 
            this.BTNEDIT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNEDIT.Name = "BTNEDIT";
            this.BTNEDIT.Size = new System.Drawing.Size(48, 25);
            this.BTNEDIT.Text = "編輯(&E)";
            this.BTNEDIT.Click += new System.EventHandler(this.BTNEDIT_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // BTNDELETE
            // 
            this.BTNDELETE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNDELETE.Name = "BTNDELETE";
            this.BTNDELETE.Size = new System.Drawing.Size(49, 25);
            this.BTNDELETE.Text = "刪除(&D)";
            this.BTNDELETE.Click += new System.EventHandler(this.BTNDELETE_Click);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 28);
            // 
            // BTNSAVE
            // 
            this.BTNSAVE.Enabled = false;
            this.BTNSAVE.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNSAVE.Name = "BTNSAVE";
            this.BTNSAVE.Size = new System.Drawing.Size(47, 25);
            this.BTNSAVE.Text = "保存(&S)";
            this.BTNSAVE.Click += new System.EventHandler(this.BTNSAVE_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 28);
            // 
            // BTNCANCEL
            // 
            this.BTNCANCEL.Enabled = false;
            this.BTNCANCEL.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNCANCEL.Name = "BTNCANCEL";
            this.BTNCANCEL.Size = new System.Drawing.Size(49, 25);
            this.BTNCANCEL.Text = "取消(&U)";
            this.BTNCANCEL.Click += new System.EventHandler(this.BTNCANCEL_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 28);
            // 
            // BTNPRINT
            // 
            this.BTNPRINT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNPRINT.Name = "BTNPRINT";
            this.BTNPRINT.Size = new System.Drawing.Size(47, 25);
            this.BTNPRINT.Text = "列印(&P)";
            this.BTNPRINT.Click += new System.EventHandler(this.BTNPRINT_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Margin = new System.Windows.Forms.Padding(0, 0, 25, 0);
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 28);
            // 
            // lblEdesc
            // 
            this.lblEdesc.Location = new System.Drawing.Point(7, 54);
            this.lblEdesc.Name = "lblEdesc";
            this.lblEdesc.Size = new System.Drawing.Size(77, 13);
            this.lblEdesc.TabIndex = 14;
            this.lblEdesc.Tag = "t_english_name";
            this.lblEdesc.Text = "英文名稱";
            this.lblEdesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtenglish_name
            // 
            this.txtenglish_name.EnterMoveNextControl = true;
            this.txtenglish_name.Location = new System.Drawing.Point(94, 52);
            this.txtenglish_name.Name = "txtenglish_name";
            this.txtenglish_name.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtenglish_name.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtenglish_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtenglish_name.Properties.MaxLength = 200;
            this.txtenglish_name.Properties.ReadOnly = true;
            this.txtenglish_name.Size = new System.Drawing.Size(387, 22);
            this.txtenglish_name.TabIndex = 2;
            this.txtenglish_name.Tag = "2";
            // 
            // lblCdesc
            // 
            this.lblCdesc.Location = new System.Drawing.Point(7, 30);
            this.lblCdesc.Name = "lblCdesc";
            this.lblCdesc.Size = new System.Drawing.Size(77, 13);
            this.lblCdesc.TabIndex = 13;
            this.lblCdesc.Tag = "t_name";
            this.lblCdesc.Text = "名稱";
            this.lblCdesc.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtname
            // 
            this.txtname.EnterMoveNextControl = true;
            this.txtname.Location = new System.Drawing.Point(94, 28);
            this.txtname.Name = "txtname";
            this.txtname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtname.Properties.MaxLength = 200;
            this.txtname.Properties.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(387, 22);
            this.txtname.TabIndex = 1;
            this.txtname.Tag = "2";
            // 
            // txtremark
            // 
            this.txtremark.EnterMoveNextControl = true;
            this.txtremark.Location = new System.Drawing.Point(94, 76);
            this.txtremark.Name = "txtremark";
            this.txtremark.Properties.Appearance.BackColor = System.Drawing.Color.White;
            this.txtremark.Properties.Appearance.Options.UseBackColor = true;
            this.txtremark.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtremark.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtremark.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtremark.Properties.MaxLength = 200;
            this.txtremark.Properties.ReadOnly = true;
            this.txtremark.Size = new System.Drawing.Size(387, 53);
            this.txtremark.TabIndex = 3;
            this.txtremark.Tag = "2";
            // 
            // lblRemark
            // 
            this.lblRemark.Location = new System.Drawing.Point(7, 77);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(77, 13);
            this.lblRemark.TabIndex = 19;
            this.lblRemark.Tag = "t_remark";
            this.lblRemark.Text = "備註";
            this.lblRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblID
            // 
            this.lblID.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(7, 7);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(77, 13);
            this.lblID.TabIndex = 20;
            this.lblID.Tag = "t_id";
            this.lblID.Text = "編號";
            this.lblID.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // luestate
            // 
            this.luestate.EditValue = "";
            this.luestate.Enabled = false;
            this.luestate.Location = new System.Drawing.Point(321, 132);
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
            this.luestate.TabIndex = 5;
            this.luestate.Tag = "2";
            // 
            // t_state
            // 
            this.t_state.Location = new System.Drawing.Point(240, 134);
            this.t_state.Name = "t_state";
            this.t_state.Size = new System.Drawing.Size(77, 16);
            this.t_state.TabIndex = 194;
            this.t_state.Tag = "t_state";
            this.t_state.Text = "狀態";
            this.t_state.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmtim
            // 
            this.lblAmtim.Location = new System.Drawing.Point(241, 183);
            this.lblAmtim.Name = "lblAmtim";
            this.lblAmtim.Size = new System.Drawing.Size(77, 13);
            this.lblAmtim.TabIndex = 193;
            this.lblAmtim.Tag = "t_update_date";
            this.lblAmtim.Text = "修改日期";
            this.lblAmtim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblAmusr
            // 
            this.lblAmusr.Location = new System.Drawing.Point(7, 183);
            this.lblAmusr.Name = "lblAmusr";
            this.lblAmusr.Size = new System.Drawing.Size(77, 13);
            this.lblAmusr.TabIndex = 192;
            this.lblAmusr.Tag = "t_update_by";
            this.lblAmusr.Text = "修改人";
            this.lblAmusr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCrtim
            // 
            this.lblCrtim.Location = new System.Drawing.Point(241, 158);
            this.lblCrtim.Name = "lblCrtim";
            this.lblCrtim.Size = new System.Drawing.Size(77, 13);
            this.lblCrtim.TabIndex = 191;
            this.lblCrtim.Tag = "t_create_date";
            this.lblCrtim.Text = "建檔日期";
            this.lblCrtim.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCrusr
            // 
            this.lblCrusr.Location = new System.Drawing.Point(7, 158);
            this.lblCrusr.Name = "lblCrusr";
            this.lblCrusr.Size = new System.Drawing.Size(77, 13);
            this.lblCrusr.TabIndex = 190;
            this.lblCrusr.Tag = "t_create_by";
            this.lblCrusr.Text = "建檔人";
            this.lblCrusr.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtupdate_date
            // 
            this.txtupdate_date.Enabled = false;
            this.txtupdate_date.Location = new System.Drawing.Point(321, 181);
            this.txtupdate_date.Name = "txtupdate_date";
            this.txtupdate_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtupdate_date.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtupdate_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtupdate_date.Properties.ReadOnly = true;
            this.txtupdate_date.Size = new System.Drawing.Size(160, 22);
            this.txtupdate_date.TabIndex = 9;
            this.txtupdate_date.Tag = "2";
            // 
            // txtupdate_by
            // 
            this.txtupdate_by.Enabled = false;
            this.txtupdate_by.Location = new System.Drawing.Point(94, 181);
            this.txtupdate_by.Name = "txtupdate_by";
            this.txtupdate_by.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtupdate_by.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtupdate_by.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtupdate_by.Properties.MaxLength = 20;
            this.txtupdate_by.Properties.ReadOnly = true;
            this.txtupdate_by.Size = new System.Drawing.Size(122, 22);
            this.txtupdate_by.TabIndex = 8;
            this.txtupdate_by.Tag = "2";
            // 
            // txtcreate_date
            // 
            this.txtcreate_date.Enabled = false;
            this.txtcreate_date.Location = new System.Drawing.Point(321, 157);
            this.txtcreate_date.Name = "txtcreate_date";
            this.txtcreate_date.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcreate_date.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtcreate_date.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcreate_date.Properties.ReadOnly = true;
            this.txtcreate_date.Size = new System.Drawing.Size(160, 22);
            this.txtcreate_date.TabIndex = 7;
            this.txtcreate_date.Tag = "2";
            // 
            // txtcreate_by
            // 
            this.txtcreate_by.Enabled = false;
            this.txtcreate_by.Location = new System.Drawing.Point(94, 157);
            this.txtcreate_by.Name = "txtcreate_by";
            this.txtcreate_by.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtcreate_by.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtcreate_by.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtcreate_by.Properties.MaxLength = 20;
            this.txtcreate_by.Properties.ReadOnly = true;
            this.txtcreate_by.Size = new System.Drawing.Size(122, 22);
            this.txtcreate_by.TabIndex = 6;
            this.txtcreate_by.Tag = "2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.luedatum);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtid);
            this.panel1.Controls.Add(this.luestate);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.t_state);
            this.panel1.Controls.Add(this.lblCdesc);
            this.panel1.Controls.Add(this.lblAmtim);
            this.panel1.Controls.Add(this.txtenglish_name);
            this.panel1.Controls.Add(this.lblAmusr);
            this.panel1.Controls.Add(this.lblEdesc);
            this.panel1.Controls.Add(this.lblCrtim);
            this.panel1.Controls.Add(this.lblRemark);
            this.panel1.Controls.Add(this.lblCrusr);
            this.panel1.Controls.Add(this.txtremark);
            this.panel1.Controls.Add(this.txtupdate_date);
            this.panel1.Controls.Add(this.lblID);
            this.panel1.Controls.Add(this.txtupdate_by);
            this.panel1.Controls.Add(this.txtcreate_by);
            this.panel1.Controls.Add(this.txtcreate_date);
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(487, 207);
            this.panel1.TabIndex = 196;
            // 
            // luedatum
            // 
            this.luedatum.EditValue = "";
            this.luedatum.Enabled = false;
            this.luedatum.Location = new System.Drawing.Point(94, 132);
            this.luedatum.Name = "luedatum";
            this.luedatum.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.luedatum.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.luedatum.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.luedatum.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.luedatum.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("id", 30, "id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 100, "name")});
            this.luedatum.Properties.ImmediatePopup = true;
            this.luedatum.Properties.NullText = "";
            this.luedatum.Properties.PopupWidth = 130;
            this.luedatum.Properties.SearchMode = DevExpress.XtraEditors.Controls.SearchMode.OnlyInPopup;
            this.luedatum.Properties.ShowHeader = false;
            this.luedatum.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.luedatum.Size = new System.Drawing.Size(122, 22);
            this.luedatum.TabIndex = 4;
            this.luedatum.Tag = "2";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 16);
            this.label2.TabIndex = 196;
            this.label2.Tag = "t_category";
            this.label2.Text = "材料組別";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // grpbFind
            // 
            this.grpbFind.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpbFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.grpbFind.Controls.Add(this.btnFind);
            this.grpbFind.Controls.Add(this.txtmat_code1);
            this.grpbFind.Controls.Add(this.label1);
            this.grpbFind.Font = new System.Drawing.Font("Tahoma", 9F);
            this.grpbFind.Location = new System.Drawing.Point(490, 30);
            this.grpbFind.Name = "grpbFind";
            this.grpbFind.Size = new System.Drawing.Size(526, 206);
            this.grpbFind.TabIndex = 198;
            this.grpbFind.TabStop = false;
            this.grpbFind.Text = "Search";
            // 
            // btnFind
            // 
            this.btnFind.Image = global::cfvn.Properties.Resources.find;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(267, 23);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(96, 31);
            this.btnFind.TabIndex = 23;
            this.btnFind.Text = "Search(&F)";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // txtmat_code1
            // 
            this.txtmat_code1.EditValue = "";
            this.txtmat_code1.EnterMoveNextControl = true;
            this.txtmat_code1.Location = new System.Drawing.Point(90, 30);
            this.txtmat_code1.Name = "txtmat_code1";
            this.txtmat_code1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtmat_code1.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtmat_code1.Properties.MaxLength = 7;
            this.txtmat_code1.Size = new System.Drawing.Size(135, 22);
            this.txtmat_code1.TabIndex = 21;
            this.txtmat_code1.Tag = "";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 22;
            this.label1.Tag = "t_id";
            this.label1.Text = "編號";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.remark,
            this.datum,
            this.state,
            this.create_by,
            this.create_date,
            this.update_by,
            this.update_date});
            this.dgvDetails.Location = new System.Drawing.Point(2, 240);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.ShowCellToolTips = false;
            this.dgvDetails.Size = new System.Drawing.Size(1013, 495);
            this.dgvDetails.TabIndex = 199;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "編號";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.id.ToolTipText = "t_id";
            this.id.Width = 50;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "名稱";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.ToolTipText = "t_name";
            this.name.Width = 210;
            // 
            // english_name
            // 
            this.english_name.DataPropertyName = "english_name";
            this.english_name.HeaderText = "英文名稱";
            this.english_name.Name = "english_name";
            this.english_name.ReadOnly = true;
            this.english_name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.english_name.ToolTipText = "t_english_name";
            this.english_name.Width = 210;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "備註";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.remark.ToolTipText = "t_remark";
            this.remark.Width = 250;
            // 
            // datum
            // 
            this.datum.DataPropertyName = "datum";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.datum.DefaultCellStyle = dataGridViewCellStyle1;
            this.datum.HeaderText = "材料組別";
            this.datum.Name = "datum";
            this.datum.ReadOnly = true;
            this.datum.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.datum.ToolTipText = "t_category";
            // 
            // state
            // 
            this.state.DataPropertyName = "state";
            this.state.HeaderText = "state";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
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
            // frmMaterialType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 741);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.grpbFind);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmMaterialType";
            this.Tag = "Forms.frmMaterialType";
            this.Text = "frmMaterialType";
            this.Load += new System.EventHandler(this.frmMaterialType_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtid.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtremark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.luestate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtupdate_by.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_date.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtcreate_by.Properties)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.luedatum.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).EndInit();
            this.grpbFind.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtmat_code1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit txtid;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BTNEXIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BTNNEW;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton BTNEDIT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton BTNDELETE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
        private System.Windows.Forms.ToolStripButton BTNSAVE;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton BTNCANCEL;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton BTNPRINT;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.Label lblEdesc;
        private DevExpress.XtraEditors.TextEdit txtenglish_name;
        private System.Windows.Forms.Label lblCdesc;
        private DevExpress.XtraEditors.TextEdit txtname;
        private DevExpress.XtraEditors.MemoEdit txtremark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblID;
        private DevExpress.XtraEditors.LookUpEdit luestate;
        private System.Windows.Forms.Label t_state;
        private System.Windows.Forms.Label lblAmtim;
        private System.Windows.Forms.Label lblAmusr;
        private System.Windows.Forms.Label lblCrtim;
        private System.Windows.Forms.Label lblCrusr;
        private DevExpress.XtraEditors.TextEdit txtupdate_date;
        private DevExpress.XtraEditors.TextEdit txtupdate_by;
        private DevExpress.XtraEditors.TextEdit txtcreate_date;
        private DevExpress.XtraEditors.TextEdit txtcreate_by;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.BindingSource bds1;
        private System.Windows.Forms.GroupBox grpbFind;
        private System.Windows.Forms.Button btnFind;
        private DevExpress.XtraEditors.TextEdit txtmat_code1;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.LookUpEdit luedatum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn english_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn datum;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_date;
    }
}