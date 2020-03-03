namespace cfvn.Forms
{
    partial class frmCdCompany
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
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.t_update_date = new System.Windows.Forms.Label();
            this.t_update_by = new System.Windows.Forms.Label();
            this.t_create_date = new System.Windows.Forms.Label();
            this.t_create_by = new System.Windows.Forms.Label();
            this.t_tel = new System.Windows.Forms.Label();
            this.t_company = new System.Windows.Forms.Label();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.english_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.e_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtFax = new DevExpress.XtraEditors.TextEdit();
            this.txtTel = new DevExpress.XtraEditors.TextEdit();
            this.txte_address = new DevExpress.XtraEditors.TextEdit();
            this.txtaddress = new DevExpress.XtraEditors.TextEdit();
            this.txtname = new DevExpress.XtraEditors.TextEdit();
            this.txtenglish_name = new DevExpress.XtraEditors.TextEdit();
            this.t_english_name = new System.Windows.Forms.Label();
            this.txtpicture_path = new DevExpress.XtraEditors.TextEdit();
            this.txtUpdate_by = new cfvn.Components.myTextBox();
            this.txtUpdate_date = new cfvn.Components.myTextBox();
            this.txtCreate_date = new cfvn.Components.myTextBox();
            this.txtCreate_by = new cfvn.Components.myTextBox();
            this.t_artwork_path = new System.Windows.Forms.Label();
            this.t_e_address = new System.Windows.Forms.Label();
            this.t_address = new System.Windows.Forms.Label();
            this.t_fax = new System.Windows.Forms.Label();
            this.txtId = new cfvn.Components.myTextBox();
            this.t_name = new System.Windows.Forms.Label();
            this.bds1 = new System.Windows.Forms.BindingSource(this.components);
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_address.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpicture_path.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
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
            this.btnRefresh});
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
            this.btnNew.Size = new System.Drawing.Size(55, 35);
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
            this.btnEdit.Size = new System.Drawing.Size(54, 35);
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
            this.btnDelete.Size = new System.Drawing.Size(49, 35);
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
            this.btnSave.Size = new System.Drawing.Size(56, 35);
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
            this.btnUndo.Size = new System.Drawing.Size(52, 35);
            this.btnUndo.Text = "恢 復(&U)";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // btnRefresh
            // 
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(49, 35);
            this.btnRefresh.Text = "刷新(&R)";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // t_update_date
            // 
            this.t_update_date.AutoSize = true;
            this.t_update_date.Location = new System.Drawing.Point(300, 254);
            this.t_update_date.Name = "t_update_date";
            this.t_update_date.Size = new System.Drawing.Size(53, 12);
            this.t_update_date.TabIndex = 48;
            this.t_update_date.Tag = "t_update_date";
            this.t_update_date.Text = "修改日期";
            // 
            // t_update_by
            // 
            this.t_update_by.AutoSize = true;
            this.t_update_by.Location = new System.Drawing.Point(75, 253);
            this.t_update_by.Name = "t_update_by";
            this.t_update_by.Size = new System.Drawing.Size(41, 12);
            this.t_update_by.TabIndex = 46;
            this.t_update_by.Tag = "t_update_by";
            this.t_update_by.Text = "修改人";
            // 
            // t_create_date
            // 
            this.t_create_date.AutoSize = true;
            this.t_create_date.Location = new System.Drawing.Point(300, 231);
            this.t_create_date.Name = "t_create_date";
            this.t_create_date.Size = new System.Drawing.Size(53, 12);
            this.t_create_date.TabIndex = 44;
            this.t_create_date.Tag = "t_create_date";
            this.t_create_date.Text = "建档日期";
            // 
            // t_create_by
            // 
            this.t_create_by.AutoSize = true;
            this.t_create_by.Location = new System.Drawing.Point(75, 230);
            this.t_create_by.Name = "t_create_by";
            this.t_create_by.Size = new System.Drawing.Size(41, 12);
            this.t_create_by.TabIndex = 42;
            this.t_create_by.Tag = "t_create_by";
            this.t_create_by.Text = "建档人";
            // 
            // t_tel
            // 
            this.t_tel.Location = new System.Drawing.Point(16, 84);
            this.t_tel.Name = "t_tel";
            this.t_tel.Size = new System.Drawing.Size(100, 16);
            this.t_tel.TabIndex = 40;
            this.t_tel.Tag = "t_tel";
            this.t_tel.Text = "电话";
            this.t_tel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_company
            // 
            this.t_company.ForeColor = System.Drawing.Color.Blue;
            this.t_company.Location = new System.Drawing.Point(16, 8);
            this.t_company.Name = "t_company";
            this.t_company.Size = new System.Drawing.Size(100, 16);
            this.t_company.TabIndex = 34;
            this.t_company.Tag = "t_company";
            this.t_company.Text = "公司";
            this.t_company.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.tel,
            this.fax,
            this.address,
            this.e_address,
            this.remark,
            this.create_by,
            this.create_date,
            this.update_by,
            this.update_date});
            this.dgvDetails.Location = new System.Drawing.Point(2, 333);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.ShowCellToolTips = false;
            this.dgvDetails.Size = new System.Drawing.Size(948, 281);
            this.dgvDetails.TabIndex = 50;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "代码";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.ToolTipText = "t_id";
            this.id.Width = 110;
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
            // 
            // tel
            // 
            this.tel.DataPropertyName = "tel";
            this.tel.HeaderText = "电话";
            this.tel.Name = "tel";
            this.tel.ReadOnly = true;
            this.tel.ToolTipText = "t_tel";
            this.tel.Width = 150;
            // 
            // fax
            // 
            this.fax.DataPropertyName = "fax";
            this.fax.HeaderText = "传真";
            this.fax.Name = "fax";
            this.fax.ReadOnly = true;
            this.fax.ToolTipText = "t_fax";
            this.fax.Width = 150;
            // 
            // address
            // 
            this.address.DataPropertyName = "address";
            this.address.HeaderText = "地址";
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.ToolTipText = "t_address";
            this.address.Width = 120;
            // 
            // e_address
            // 
            this.e_address.DataPropertyName = "e_address";
            this.e_address.HeaderText = "英文地址";
            this.e_address.Name = "e_address";
            this.e_address.ReadOnly = true;
            this.e_address.ToolTipText = "t_e_address";
            this.e_address.Width = 150;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "picture_path";
            this.remark.HeaderText = "圖樣路徑";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.ToolTipText = "t_artwork_path";
            this.remark.Width = 150;
            // 
            // create_by
            // 
            this.create_by.DataPropertyName = "create_by";
            this.create_by.HeaderText = "建档人";
            this.create_by.Name = "create_by";
            this.create_by.ReadOnly = true;
            this.create_by.ToolTipText = "t_create_by";
            this.create_by.Visible = false;
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
            this.update_by.Width = 120;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.txtFax);
            this.panel1.Controls.Add(this.txtTel);
            this.panel1.Controls.Add(this.txte_address);
            this.panel1.Controls.Add(this.txtaddress);
            this.panel1.Controls.Add(this.txtname);
            this.panel1.Controls.Add(this.txtenglish_name);
            this.panel1.Controls.Add(this.t_english_name);
            this.panel1.Controls.Add(this.txtpicture_path);
            this.panel1.Controls.Add(this.txtUpdate_by);
            this.panel1.Controls.Add(this.txtUpdate_date);
            this.panel1.Controls.Add(this.txtCreate_date);
            this.panel1.Controls.Add(this.txtCreate_by);
            this.panel1.Controls.Add(this.t_artwork_path);
            this.panel1.Controls.Add(this.t_e_address);
            this.panel1.Controls.Add(this.t_address);
            this.panel1.Controls.Add(this.t_fax);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.t_name);
            this.panel1.Controls.Add(this.t_company);
            this.panel1.Controls.Add(this.t_update_date);
            this.panel1.Controls.Add(this.t_tel);
            this.panel1.Controls.Add(this.t_update_by);
            this.panel1.Controls.Add(this.t_create_by);
            this.panel1.Controls.Add(this.t_create_date);
            this.panel1.Location = new System.Drawing.Point(3, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(947, 287);
            this.panel1.TabIndex = 53;
            // 
            // txtFax
            // 
            this.txtFax.EditValue = "";
            this.txtFax.EnterMoveNextControl = true;
            this.txtFax.Location = new System.Drawing.Point(118, 107);
            this.txtFax.Name = "txtFax";
            this.txtFax.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtFax.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtFax.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtFax.Properties.MaxLength = 255;
            this.txtFax.Properties.ReadOnly = true;
            this.txtFax.Size = new System.Drawing.Size(453, 22);
            this.txtFax.TabIndex = 4;
            this.txtFax.Tag = "2";
            // 
            // txtTel
            // 
            this.txtTel.EditValue = "";
            this.txtTel.EnterMoveNextControl = true;
            this.txtTel.Location = new System.Drawing.Point(118, 82);
            this.txtTel.Name = "txtTel";
            this.txtTel.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtTel.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtTel.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtTel.Properties.MaxLength = 255;
            this.txtTel.Properties.ReadOnly = true;
            this.txtTel.Size = new System.Drawing.Size(453, 22);
            this.txtTel.TabIndex = 3;
            this.txtTel.Tag = "2";
            // 
            // txte_address
            // 
            this.txte_address.EditValue = "";
            this.txte_address.EnterMoveNextControl = true;
            this.txte_address.Location = new System.Drawing.Point(118, 159);
            this.txte_address.Name = "txte_address";
            this.txte_address.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txte_address.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txte_address.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txte_address.Properties.MaxLength = 255;
            this.txte_address.Properties.ReadOnly = true;
            this.txte_address.Size = new System.Drawing.Size(453, 22);
            this.txte_address.TabIndex = 6;
            this.txte_address.Tag = "2";
            // 
            // txtaddress
            // 
            this.txtaddress.EditValue = "";
            this.txtaddress.EnterMoveNextControl = true;
            this.txtaddress.Location = new System.Drawing.Point(118, 133);
            this.txtaddress.Name = "txtaddress";
            this.txtaddress.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtaddress.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtaddress.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtaddress.Properties.MaxLength = 255;
            this.txtaddress.Properties.ReadOnly = true;
            this.txtaddress.Size = new System.Drawing.Size(453, 22);
            this.txtaddress.TabIndex = 5;
            this.txtaddress.Tag = "2";
            // 
            // txtname
            // 
            this.txtname.EditValue = "";
            this.txtname.EnterMoveNextControl = true;
            this.txtname.Location = new System.Drawing.Point(118, 32);
            this.txtname.Name = "txtname";
            this.txtname.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtname.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtname.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtname.Properties.MaxLength = 255;
            this.txtname.Properties.ReadOnly = true;
            this.txtname.Size = new System.Drawing.Size(453, 22);
            this.txtname.TabIndex = 1;
            this.txtname.Tag = "2";
            // 
            // txtenglish_name
            // 
            this.txtenglish_name.EditValue = "";
            this.txtenglish_name.EnterMoveNextControl = true;
            this.txtenglish_name.Location = new System.Drawing.Point(118, 57);
            this.txtenglish_name.Name = "txtenglish_name";
            this.txtenglish_name.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtenglish_name.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtenglish_name.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtenglish_name.Properties.MaxLength = 255;
            this.txtenglish_name.Properties.ReadOnly = true;
            this.txtenglish_name.Size = new System.Drawing.Size(453, 22);
            this.txtenglish_name.TabIndex = 2;
            this.txtenglish_name.Tag = "2";
            // 
            // t_english_name
            // 
            this.t_english_name.Location = new System.Drawing.Point(15, 59);
            this.t_english_name.Name = "t_english_name";
            this.t_english_name.Size = new System.Drawing.Size(100, 16);
            this.t_english_name.TabIndex = 63;
            this.t_english_name.Tag = "t_english_name";
            this.t_english_name.Text = "名稱(英文)";
            this.t_english_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtpicture_path
            // 
            this.txtpicture_path.EditValue = "";
            this.txtpicture_path.EnterMoveNextControl = true;
            this.txtpicture_path.Location = new System.Drawing.Point(118, 185);
            this.txtpicture_path.Name = "txtpicture_path";
            this.txtpicture_path.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtpicture_path.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtpicture_path.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtpicture_path.Properties.MaxLength = 255;
            this.txtpicture_path.Properties.ReadOnly = true;
            this.txtpicture_path.Size = new System.Drawing.Size(453, 22);
            this.txtpicture_path.TabIndex = 7;
            this.txtpicture_path.Tag = "2";
            // 
            // txtUpdate_by
            // 
            this.txtUpdate_by.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtUpdate_by.Location = new System.Drawing.Point(120, 250);
            this.txtUpdate_by.Name = "txtUpdate_by";
            this.txtUpdate_by.Size = new System.Drawing.Size(149, 23);
            this.txtUpdate_by.TabIndex = 10;
            // 
            // txtUpdate_date
            // 
            this.txtUpdate_date.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtUpdate_date.Location = new System.Drawing.Point(356, 250);
            this.txtUpdate_date.Name = "txtUpdate_date";
            this.txtUpdate_date.Size = new System.Drawing.Size(217, 23);
            this.txtUpdate_date.TabIndex = 11;
            // 
            // txtCreate_date
            // 
            this.txtCreate_date.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCreate_date.Location = new System.Drawing.Point(356, 225);
            this.txtCreate_date.Name = "txtCreate_date";
            this.txtCreate_date.Size = new System.Drawing.Size(217, 23);
            this.txtCreate_date.TabIndex = 9;
            // 
            // txtCreate_by
            // 
            this.txtCreate_by.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCreate_by.Location = new System.Drawing.Point(120, 225);
            this.txtCreate_by.Name = "txtCreate_by";
            this.txtCreate_by.Size = new System.Drawing.Size(149, 23);
            this.txtCreate_by.TabIndex = 8;
            // 
            // t_artwork_path
            // 
            this.t_artwork_path.Location = new System.Drawing.Point(15, 187);
            this.t_artwork_path.Name = "t_artwork_path";
            this.t_artwork_path.Size = new System.Drawing.Size(100, 16);
            this.t_artwork_path.TabIndex = 61;
            this.t_artwork_path.Tag = "t_artwork_path";
            this.t_artwork_path.Text = "圖樣路徑";
            this.t_artwork_path.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_e_address
            // 
            this.t_e_address.Location = new System.Drawing.Point(16, 159);
            this.t_e_address.Name = "t_e_address";
            this.t_e_address.Size = new System.Drawing.Size(100, 16);
            this.t_e_address.TabIndex = 59;
            this.t_e_address.Tag = "t_e_address";
            this.t_e_address.Text = "地址(英文)";
            this.t_e_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_address
            // 
            this.t_address.Location = new System.Drawing.Point(15, 133);
            this.t_address.Name = "t_address";
            this.t_address.Size = new System.Drawing.Size(100, 16);
            this.t_address.TabIndex = 57;
            this.t_address.Tag = "t_address";
            this.t_address.Text = "地址";
            this.t_address.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // t_fax
            // 
            this.t_fax.Location = new System.Drawing.Point(15, 109);
            this.t_fax.Name = "t_fax";
            this.t_fax.Size = new System.Drawing.Size(100, 16);
            this.t_fax.TabIndex = 55;
            this.t_fax.Tag = "t_fax";
            this.t_fax.Text = "传真";
            this.t_fax.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtId
            // 
            this.txtId.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtId.Location = new System.Drawing.Point(118, 7);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(455, 23);
            this.txtId.TabIndex = 0;
            // 
            // t_name
            // 
            this.t_name.ForeColor = System.Drawing.Color.Blue;
            this.t_name.Location = new System.Drawing.Point(16, 34);
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(100, 16);
            this.t_name.TabIndex = 50;
            this.t_name.Tag = "t_name";
            this.t_name.Text = "名称";
            this.t_name.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmCdCompany
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 616);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmCdCompany";
            this.Tag = "Forms.frmCdCompany";
            this.Text = "frmCdCompany";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCdCompany_FormClosed);
            this.Load += new System.EventHandler(this.frmCdCompany_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtFax.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTel.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txte_address.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtaddress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtenglish_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtpicture_path.Properties)).EndInit();
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
        private System.Windows.Forms.Label t_tel;
        private System.Windows.Forms.Label t_company;
        private System.Windows.Forms.BindingSource bds1;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.Label t_name;
        private cfvn.Components.myTextBox txtId;
        private System.Windows.Forms.Label t_artwork_path;
        private System.Windows.Forms.Label t_e_address;
        private System.Windows.Forms.Label t_address;
        private System.Windows.Forms.Label t_fax;
        private cfvn.Components.myTextBox txtUpdate_by;
        private cfvn.Components.myTextBox txtUpdate_date;
        private cfvn.Components.myTextBox txtCreate_date;
        private cfvn.Components.myTextBox txtCreate_by;
        private DevExpress.XtraEditors.TextEdit txtpicture_path;
        private DevExpress.XtraEditors.TextEdit txtenglish_name;
        private System.Windows.Forms.Label t_english_name;
        private DevExpress.XtraEditors.TextEdit txtname;
        private DevExpress.XtraEditors.TextEdit txte_address;
        private DevExpress.XtraEditors.TextEdit txtaddress;
        private DevExpress.XtraEditors.TextEdit txtTel;
        private DevExpress.XtraEditors.TextEdit txtFax;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn english_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn e_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_date;
    }
}