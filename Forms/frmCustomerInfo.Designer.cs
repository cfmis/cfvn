namespace cfvn.Forms
{
    partial class frmCustomerInfo

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomerInfo));
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
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.BTNINPORT = new System.Windows.Forms.ToolStripButton();
            this.txtUpdate_date = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUpdateby = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCreate_date = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCreateby = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomer_name = new System.Windows.Forms.TextBox();
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.customer_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_fax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_by = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lkeProvince = new DevExpress.XtraEditors.LookUpEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.txtCustomer_email = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCustomer_fax = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCustomer_tel = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomer_address = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bds1 = new System.Windows.Forms.BindingSource(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeProvince.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.btnRefresh,
            this.toolStripSeparator7,
            this.BTNINPORT});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(951, 38);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
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
            this.btnNew.Image = global::cfvn.Properties.Resources._new;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(71, 35);
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
            this.btnEdit.Image = global::cfvn.Properties.Resources.edit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(70, 35);
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
            this.btnDelete.Image = global::cfvn.Properties.Resources.delete;
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(65, 35);
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
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 35);
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
            this.btnUndo.Image = global::cfvn.Properties.Resources.cancel;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(68, 35);
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
            this.btnRefresh.Image = global::cfvn.Properties.Resources.refresh;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(65, 35);
            this.btnRefresh.Text = "刷新(&R)";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 38);
            // 
            // BTNINPORT
            // 
            this.BTNINPORT.Image = ((System.Drawing.Image)(resources.GetObject("BTNINPORT.Image")));
            this.BTNINPORT.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BTNINPORT.Name = "BTNINPORT";
            this.BTNINPORT.Size = new System.Drawing.Size(97, 35);
            this.BTNINPORT.Text = "汇入客户信息";
            this.BTNINPORT.Click += new System.EventHandler(this.BTNINPORT_Click);
            // 
            // txtUpdate_date
            // 
            this.txtUpdate_date.Enabled = false;
            this.txtUpdate_date.Location = new System.Drawing.Point(344, 163);
            this.txtUpdate_date.Name = "txtUpdate_date";
            this.txtUpdate_date.ReadOnly = true;
            this.txtUpdate_date.Size = new System.Drawing.Size(203, 22);
            this.txtUpdate_date.TabIndex = 11;
            this.txtUpdate_date.Tag = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(288, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 48;
            this.label8.Text = "修改日期";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(50, 165);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 46;
            this.label9.Text = "修改人";
            // 
            // txtUpdateby
            // 
            this.txtUpdateby.Enabled = false;
            this.txtUpdateby.Location = new System.Drawing.Point(95, 163);
            this.txtUpdateby.Name = "txtUpdateby";
            this.txtUpdateby.ReadOnly = true;
            this.txtUpdateby.Size = new System.Drawing.Size(168, 22);
            this.txtUpdateby.TabIndex = 10;
            this.txtUpdateby.Tag = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(288, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 44;
            this.label10.Text = "建档日期";
            // 
            // txtCreate_date
            // 
            this.txtCreate_date.Enabled = false;
            this.txtCreate_date.Location = new System.Drawing.Point(344, 138);
            this.txtCreate_date.Name = "txtCreate_date";
            this.txtCreate_date.ReadOnly = true;
            this.txtCreate_date.Size = new System.Drawing.Size(203, 22);
            this.txtCreate_date.TabIndex = 9;
            this.txtCreate_date.Tag = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(50, 141);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 42;
            this.label11.Text = "建档人";
            // 
            // txtCreateby
            // 
            this.txtCreateby.Enabled = false;
            this.txtCreateby.Location = new System.Drawing.Point(95, 138);
            this.txtCreateby.Name = "txtCreateby";
            this.txtCreateby.ReadOnly = true;
            this.txtCreateby.Size = new System.Drawing.Size(168, 22);
            this.txtCreateby.TabIndex = 8;
            this.txtCreateby.Tag = "2";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(33, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 40;
            this.label7.Text = "备  注";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtRemark.Location = new System.Drawing.Point(95, 112);
            this.txtRemark.MaxLength = 100;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(452, 22);
            this.txtRemark.TabIndex = 7;
            this.txtRemark.Tag = "2";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(20, 8);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 16);
            this.label3.TabIndex = 34;
            this.label3.Text = "客户名称";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomer_name
            // 
            this.txtCustomer_name.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCustomer_name.Location = new System.Drawing.Point(95, 7);
            this.txtCustomer_name.MaxLength = 200;
            this.txtCustomer_name.Name = "txtCustomer_name";
            this.txtCustomer_name.ReadOnly = true;
            this.txtCustomer_name.Size = new System.Drawing.Size(236, 22);
            this.txtCustomer_name.TabIndex = 0;
            this.txtCustomer_name.Tag = "2";
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
            this.customer_name,
            this.customer_address,
            this.contact,
            this.customer_tel,
            this.customer_fax,
            this.customer_email,
            this.remark,
            this.province,
            this.create_by,
            this.create_date,
            this.update_by,
            this.update_date});
            this.dgvDetails.Location = new System.Drawing.Point(2, 238);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(948, 376);
            this.dgvDetails.TabIndex = 50;
            // 
            // customer_name
            // 
            this.customer_name.DataPropertyName = "customer_name";
            this.customer_name.HeaderText = "客户名称";
            this.customer_name.Name = "customer_name";
            this.customer_name.ReadOnly = true;
            this.customer_name.Width = 120;
            // 
            // customer_address
            // 
            this.customer_address.DataPropertyName = "customer_address";
            this.customer_address.HeaderText = "客户地址";
            this.customer_address.Name = "customer_address";
            this.customer_address.ReadOnly = true;
            this.customer_address.Width = 160;
            // 
            // contact
            // 
            this.contact.DataPropertyName = "contact";
            this.contact.HeaderText = "联系人";
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            // 
            // customer_tel
            // 
            this.customer_tel.DataPropertyName = "customer_tel";
            this.customer_tel.HeaderText = "联系电话";
            this.customer_tel.Name = "customer_tel";
            this.customer_tel.ReadOnly = true;
            // 
            // customer_fax
            // 
            this.customer_fax.DataPropertyName = "customer_fax";
            this.customer_fax.HeaderText = "传真";
            this.customer_fax.Name = "customer_fax";
            this.customer_fax.ReadOnly = true;
            // 
            // customer_email
            // 
            this.customer_email.DataPropertyName = "customer_email";
            this.customer_email.HeaderText = "电邮";
            this.customer_email.Name = "customer_email";
            this.customer_email.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 150;
            // 
            // province
            // 
            this.province.DataPropertyName = "province";
            this.province.HeaderText = "省份或城市";
            this.province.Name = "province";
            this.province.ReadOnly = true;
            // 
            // create_by
            // 
            this.create_by.DataPropertyName = "create_by";
            this.create_by.HeaderText = "建档人";
            this.create_by.Name = "create_by";
            this.create_by.ReadOnly = true;
            this.create_by.Visible = false;
            // 
            // create_date
            // 
            this.create_date.DataPropertyName = "create_date";
            this.create_date.HeaderText = "建档日期";
            this.create_date.Name = "create_date";
            this.create_date.ReadOnly = true;
            this.create_date.Visible = false;
            // 
            // update_by
            // 
            this.update_by.DataPropertyName = "update_by";
            this.update_by.HeaderText = "修改人";
            this.update_by.Name = "update_by";
            this.update_by.ReadOnly = true;
            this.update_by.Visible = false;
            this.update_by.Width = 120;
            // 
            // update_date
            // 
            this.update_date.DataPropertyName = "update_date";
            this.update_date.HeaderText = "修改日期";
            this.update_date.Name = "update_date";
            this.update_date.ReadOnly = true;
            this.update_date.Visible = false;
            this.update_date.Width = 150;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lkeProvince);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtCustomer_email);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtCustomer_fax);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCustomer_tel);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCustomer_address);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCustomer_name);
            this.panel1.Controls.Add(this.txtUpdate_date);
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtCreateby);
            this.panel1.Controls.Add(this.txtUpdateby);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtCreate_date);
            this.panel1.Location = new System.Drawing.Point(3, 40);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(556, 192);
            this.panel1.TabIndex = 53;
            // 
            // lkeProvince
            // 
            this.lkeProvince.EditValue = "";
            this.lkeProvince.Enabled = false;
            this.lkeProvince.EnterMoveNextControl = true;
            this.lkeProvince.Location = new System.Drawing.Point(393, 7);
            this.lkeProvince.Name = "lkeProvince";
            this.lkeProvince.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lkeProvince.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.lkeProvince.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lkeProvince.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lkeProvince.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 150, "省份或城市")});
            this.lkeProvince.Properties.DropDownRows = 20;
            this.lkeProvince.Properties.NullText = "";
            this.lkeProvince.Properties.ShowHeader = false;
            this.lkeProvince.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lkeProvince.Size = new System.Drawing.Size(154, 22);
            this.lkeProvince.TabIndex = 1;
            this.lkeProvince.Tag = "2";
            // 
            // label13
            // 
            this.label13.ForeColor = System.Drawing.Color.Blue;
            this.label13.Location = new System.Drawing.Point(334, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(58, 16);
            this.label13.TabIndex = 60;
            this.label13.Text = "省份/城市";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomer_email
            // 
            this.txtCustomer_email.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCustomer_email.Location = new System.Drawing.Point(347, 86);
            this.txtCustomer_email.MaxLength = 50;
            this.txtCustomer_email.Name = "txtCustomer_email";
            this.txtCustomer_email.ReadOnly = true;
            this.txtCustomer_email.Size = new System.Drawing.Size(200, 22);
            this.txtCustomer_email.TabIndex = 6;
            this.txtCustomer_email.Tag = "2";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(283, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 16);
            this.label6.TabIndex = 58;
            this.label6.Text = "电  邮";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomer_fax
            // 
            this.txtCustomer_fax.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCustomer_fax.Location = new System.Drawing.Point(95, 86);
            this.txtCustomer_fax.MaxLength = 50;
            this.txtCustomer_fax.Name = "txtCustomer_fax";
            this.txtCustomer_fax.ReadOnly = true;
            this.txtCustomer_fax.Size = new System.Drawing.Size(168, 22);
            this.txtCustomer_fax.TabIndex = 5;
            this.txtCustomer_fax.Tag = "2";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(31, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.TabIndex = 56;
            this.label5.Text = "传  真";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomer_tel
            // 
            this.txtCustomer_tel.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCustomer_tel.Location = new System.Drawing.Point(347, 59);
            this.txtCustomer_tel.MaxLength = 50;
            this.txtCustomer_tel.Name = "txtCustomer_tel";
            this.txtCustomer_tel.ReadOnly = true;
            this.txtCustomer_tel.Size = new System.Drawing.Size(200, 22);
            this.txtCustomer_tel.TabIndex = 4;
            this.txtCustomer_tel.Tag = "2";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(278, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 16);
            this.label4.TabIndex = 54;
            this.label4.Text = "联系电话";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtContact
            // 
            this.txtContact.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtContact.Location = new System.Drawing.Point(95, 59);
            this.txtContact.MaxLength = 50;
            this.txtContact.Name = "txtContact";
            this.txtContact.ReadOnly = true;
            this.txtContact.Size = new System.Drawing.Size(168, 22);
            this.txtContact.TabIndex = 3;
            this.txtContact.Tag = "2";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 52;
            this.label2.Text = "联系人";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomer_address
            // 
            this.txtCustomer_address.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCustomer_address.Location = new System.Drawing.Point(95, 33);
            this.txtCustomer_address.MaxLength = 250;
            this.txtCustomer_address.Name = "txtCustomer_address";
            this.txtCustomer_address.ReadOnly = true;
            this.txtCustomer_address.Size = new System.Drawing.Size(452, 22);
            this.txtCustomer_address.TabIndex = 2;
            this.txtCustomer_address.Tag = "2";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 16);
            this.label1.TabIndex = 50;
            this.label1.Text = "客户送货地址";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(690, 9);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(238, 17);
            this.progressBar1.Step = 1;
            this.progressBar1.TabIndex = 54;
            this.progressBar1.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.txtCustomerName);
            this.groupBox1.Location = new System.Drawing.Point(566, 41);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 183);
            this.groupBox1.TabIndex = 55;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查找";
            // 
            // btnFind
            // 
            this.btnFind.Image = global::cfvn.Properties.Resources.p_query;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(278, 26);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 32);
            this.btnFind.TabIndex = 60;
            this.btnFind.Text = "数据查找";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 34);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 16);
            this.label12.TabIndex = 59;
            this.label12.Text = "客户名称";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCustomerName.Location = new System.Drawing.Point(63, 31);
            this.txtCustomerName.MaxLength = 200;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(209, 22);
            this.txtCustomerName.TabIndex = 0;
            // 
            // frmCustomerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmCustomerInfo";
            this.Tag = "Forms.frmCustomerInfo";
            this.Text = "frmCustomerInfo";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCdUnit_FormClosed);
            this.Load += new System.EventHandler(this.frmCdUnit_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lkeProvince.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtUpdate_date;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtUpdateby;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCreate_date;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCreateby;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomer_name;
        private System.Windows.Forms.BindingSource bds1;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.TextBox txtCustomer_address;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripButton BTNINPORT;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomer_tel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomer_fax;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCustomer_email;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.LookUpEdit lkeProvince;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_address;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_tel;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_fax;
        private System.Windows.Forms.DataGridViewTextBoxColumn customer_email;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn province;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_by;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_date;
    }
}