namespace cfvn.Forms
{
    partial class frmCode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCode));
            this.lueLevel1 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lueLevel2 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.lueLevel3 = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.serial_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.levels = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.parent_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name_parent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.level_parent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.txtSearch = new DevExpress.XtraEditors.TextEdit();
            this.lueLevel4 = new DevExpress.XtraEditors.LookUpEdit();
            this.lueLevel5 = new DevExpress.XtraEditors.LookUpEdit();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.lueLevel1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLevel2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLevel3.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLevel4.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLevel5.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lueLevel1
            // 
            this.lueLevel1.EditValue = "";
            this.lueLevel1.EnterMoveNextControl = true;
            this.lueLevel1.Location = new System.Drawing.Point(12, 27);
            this.lueLevel1.Name = "lueLevel1";
            this.lueLevel1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lueLevel1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLevel1.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("serial_no", 80, "区域代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 120, "区域名称")});
            this.lueLevel1.Properties.DropDownRows = 20;
            this.lueLevel1.Properties.NullText = "";
            this.lueLevel1.Properties.PopupWidth = 200;
            this.lueLevel1.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueLevel1.Size = new System.Drawing.Size(124, 22);
            this.lueLevel1.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl1.Location = new System.Drawing.Point(22, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(112, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "省、直辖市（1级）";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl2.Location = new System.Drawing.Point(182, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 3;
            this.labelControl2.Text = "市（2级）";
            // 
            // lueLevel2
            // 
            this.lueLevel2.EditValue = "";
            this.lueLevel2.EnterMoveNextControl = true;
            this.lueLevel2.Location = new System.Drawing.Point(142, 27);
            this.lueLevel2.Name = "lueLevel2";
            this.lueLevel2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lueLevel2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLevel2.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("serial_no", 80, "区域代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 120, "区域名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("parent_id", 80, "父层区域代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name_parent", 120, "父层区域名称")});
            this.lueLevel2.Properties.DropDownRows = 20;
            this.lueLevel2.Properties.NullText = "";
            this.lueLevel2.Properties.PopupWidth = 400;
            this.lueLevel2.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueLevel2.Size = new System.Drawing.Size(144, 22);
            this.lueLevel2.TabIndex = 2;
            this.lueLevel2.EditValueChanged += new System.EventHandler(this.lueLevel2_EditValueChanged);
            this.lueLevel2.Enter += new System.EventHandler(this.lueLevel2_Enter);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl3.Location = new System.Drawing.Point(333, 7);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(86, 14);
            this.labelControl3.TabIndex = 5;
            this.labelControl3.Text = "区、县（3级）";
            // 
            // lueLevel3
            // 
            this.lueLevel3.EditValue = "";
            this.lueLevel3.EnterMoveNextControl = true;
            this.lueLevel3.Location = new System.Drawing.Point(294, 27);
            this.lueLevel3.Name = "lueLevel3";
            this.lueLevel3.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lueLevel3.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLevel3.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("serial_no", 80, "区域代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 120, "区域名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("parent_id", 80, "父层区域代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name_parent", 120, "父层区域名称")});
            this.lueLevel3.Properties.DropDownRows = 20;
            this.lueLevel3.Properties.NullText = "";
            this.lueLevel3.Properties.PopupWidth = 400;
            this.lueLevel3.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueLevel3.Size = new System.Drawing.Size(156, 22);
            this.lueLevel3.TabIndex = 4;
            this.lueLevel3.EditValueChanged += new System.EventHandler(this.lueLevel3_EditValueChanged);
            this.lueLevel3.Enter += new System.EventHandler(this.lueLevel3_Enter);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl4.Location = new System.Drawing.Point(530, 7);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "镇（4级）";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.labelControl5.Location = new System.Drawing.Point(716, 7);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(112, 14);
            this.labelControl5.TabIndex = 9;
            this.labelControl5.Text = "村、居委会（5级）";
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.serial_no,
            this.name,
            this.levels,
            this.parent_id,
            this.name_parent,
            this.level_parent});
            this.dgvList.Location = new System.Drawing.Point(6, 49);
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 20;
            this.dgvList.RowTemplate.Height = 20;
            this.dgvList.Size = new System.Drawing.Size(863, 282);
            this.dgvList.TabIndex = 0;
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // serial_no
            // 
            this.serial_no.DataPropertyName = "serial_no";
            this.serial_no.HeaderText = "区域代码";
            this.serial_no.Name = "serial_no";
            this.serial_no.ReadOnly = true;
            this.serial_no.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "区域名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            this.name.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name.Width = 210;
            // 
            // levels
            // 
            this.levels.DataPropertyName = "levels";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.levels.DefaultCellStyle = dataGridViewCellStyle1;
            this.levels.HeaderText = "区域级别";
            this.levels.Name = "levels";
            this.levels.ReadOnly = true;
            this.levels.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.levels.Width = 45;
            // 
            // parent_id
            // 
            this.parent_id.DataPropertyName = "parent_id";
            this.parent_id.HeaderText = "父层区域代码";
            this.parent_id.Name = "parent_id";
            this.parent_id.ReadOnly = true;
            this.parent_id.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.parent_id.Width = 110;
            // 
            // name_parent
            // 
            this.name_parent.DataPropertyName = "name_parent";
            this.name_parent.HeaderText = "父层区域名称";
            this.name_parent.Name = "name_parent";
            this.name_parent.ReadOnly = true;
            this.name_parent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.name_parent.Width = 160;
            // 
            // level_parent
            // 
            this.level_parent.DataPropertyName = "level_parent";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.level_parent.DefaultCellStyle = dataGridViewCellStyle2;
            this.level_parent.HeaderText = "父层区域级别";
            this.level_parent.Name = "level_parent";
            this.level_parent.ReadOnly = true;
            this.level_parent.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.level_parent.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.txtTotal);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.txtSearch);
            this.groupBox1.Controls.Add(this.dgvList);
            this.groupBox1.Location = new System.Drawing.Point(10, 89);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(877, 336);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "模糊查找";
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(292, 21);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(232, 14);
            this.labelControl8.TabIndex = 16;
            this.labelControl8.Text = "请输入目的地区域名称,并按回车键进行查找";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(204, 23);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(36, 14);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "笔记录";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(139, 17);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Properties.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.txtTotal.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTotal.Properties.Appearance.Options.UseBackColor = true;
            this.txtTotal.Properties.Appearance.Options.UseFont = true;
            this.txtTotal.Properties.Appearance.Options.UseForeColor = true;
            this.txtTotal.Properties.Appearance.Options.UseTextOptions = true;
            this.txtTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.txtTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple;
            this.txtTotal.Size = new System.Drawing.Size(61, 24);
            this.txtTotal.TabIndex = 14;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(75, 23);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 14);
            this.labelControl6.TabIndex = 13;
            this.labelControl6.Text = "共搜索到：";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(528, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Properties.Appearance.BackColor = System.Drawing.Color.Thistle;
            this.txtSearch.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Properties.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.txtSearch.Properties.Appearance.Options.UseBackColor = true;
            this.txtSearch.Properties.Appearance.Options.UseFont = true;
            this.txtSearch.Properties.Appearance.Options.UseForeColor = true;
            this.txtSearch.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtSearch.Properties.MaxLength = 100;
            this.txtSearch.Size = new System.Drawing.Size(254, 26);
            this.txtSearch.TabIndex = 1;
            this.txtSearch.ToolTip = "输入完成请按回车键，开始搜索";
            this.txtSearch.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyDown);
            // 
            // lueLevel4
            // 
            this.lueLevel4.EditValue = "";
            this.lueLevel4.EnterMoveNextControl = true;
            this.lueLevel4.Location = new System.Drawing.Point(457, 27);
            this.lueLevel4.Name = "lueLevel4";
            this.lueLevel4.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lueLevel4.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLevel4.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("serial_no", 80, "区域代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 120, "区域名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("parent_id", 80, "父层区域代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name_parent", 120, "父层区域名称")});
            this.lueLevel4.Properties.DropDownRows = 20;
            this.lueLevel4.Properties.NullText = "";
            this.lueLevel4.Properties.PopupWidth = 400;
            this.lueLevel4.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueLevel4.Size = new System.Drawing.Size(213, 22);
            this.lueLevel4.TabIndex = 13;
            this.lueLevel4.EditValueChanged += new System.EventHandler(this.lueLevel4_EditValueChanged);
            this.lueLevel4.Enter += new System.EventHandler(this.lueLevel4_Enter);
            // 
            // lueLevel5
            // 
            this.lueLevel5.EditValue = "";
            this.lueLevel5.EnterMoveNextControl = true;
            this.lueLevel5.Location = new System.Drawing.Point(678, 27);
            this.lueLevel5.Name = "lueLevel5";
            this.lueLevel5.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.lueLevel5.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueLevel5.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("serial_no", 80, "区域代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name", 120, "区域名称"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("parent_id", 80, "父层区域代码"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("name_parent", 120, "父层区域名称")});
            this.lueLevel5.Properties.DropDownRows = 20;
            this.lueLevel5.Properties.NullText = "";
            this.lueLevel5.Properties.PopupWidth = 400;
            this.lueLevel5.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.lueLevel5.Size = new System.Drawing.Size(211, 22);
            this.lueLevel5.TabIndex = 14;
            this.lueLevel5.Enter += new System.EventHandler(this.lueLevel5_Enter);
            // 
            // btnSelect
            // 
            this.btnSelect.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSelect.Image = ((System.Drawing.Image)(resources.GetObject("btnSelect.Image")));
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(582, 55);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(209, 31);
            this.btnSelect.TabIndex = 15;
            this.btnSelect.Text = "确定返回最低的区域代码";
            this.btnSelect.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Image = global::cfvn.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.Location = new System.Drawing.Point(806, 55);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 31);
            this.btnExit.TabIndex = 16;
            this.btnExit.Text = "退出";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // frmCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(895, 427);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lueLevel5);
            this.Controls.Add(this.lueLevel4);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.lueLevel3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.lueLevel2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lueLevel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCode";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmCode_FormClosed);
            this.Load += new System.EventHandler(this.frmCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lueLevel1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLevel2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLevel3.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSearch.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLevel4.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueLevel5.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lueLevel1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LookUpEdit lueLevel2;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LookUpEdit lueLevel3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit txtSearch;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit txtTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn serial_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn levels;
        private System.Windows.Forms.DataGridViewTextBoxColumn parent_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name_parent;
        private System.Windows.Forms.DataGridViewTextBoxColumn level_parent;
        private DevExpress.XtraEditors.LookUpEdit lueLevel4;
        private DevExpress.XtraEditors.LookUpEdit lueLevel5;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnExit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
    }
}