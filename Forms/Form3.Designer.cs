namespace SysDaan.Forms
{
    partial class Form3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form3));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnDeleted = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnPrint = new System.Windows.Forms.ToolStripButton();
            this.btnExcel = new System.Windows.Forms.ToolStripButton();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.dept_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.crusr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.crtim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amusr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.amtim = new DevExpress.XtraGrid.Columns.GridColumn();
            this.pkey = new DevExpress.XtraGrid.Columns.GridColumn();
            this.txtPkey = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnNew,
            this.toolStripSeparator2,
            this.btnEdit,
            this.toolStripSeparator3,
            this.btnSave,
            this.btnCancel,
            this.toolStripSeparator4,
            this.btnDeleted,
            this.toolStripSeparator5,
            this.btnPrint,
            this.btnExcel});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(873, 40);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(60, 37);
            this.btnExit.Text = "退 出 (&X)";
            this.btnExit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 40);
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(60, 37);
            this.btnNew.Text = "新 增 (&A)";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 40);
            // 
            // btnEdit
            // 
            this.btnEdit.Enabled = false;
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(68, 37);
            this.btnEdit.Text = "編  輯 (&M)";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnEdit.Visible = false;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 40);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(59, 37);
            this.btnSave.Text = "保 存 (&S)";
            this.btnSave.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(61, 37);
            this.btnCancel.Text = "恢 复 (&U)";
            this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 40);
            // 
            // btnDeleted
            // 
            this.btnDeleted.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleted.Image")));
            this.btnDeleted.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDeleted.Name = "btnDeleted";
            this.btnDeleted.Size = new System.Drawing.Size(79, 37);
            this.btnDeleted.Text = "删 除DEL(&D)";
            this.btnDeleted.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDeleted.Click += new System.EventHandler(this.btnDeleted_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 40);
            // 
            // btnPrint
            // 
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(59, 37);
            this.btnPrint.Text = "打 印 (&P)";
            this.btnPrint.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = ((System.Drawing.Image)(resources.GetObject("btnExcel.Image")));
            this.btnExcel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(87, 37);
            this.btnExcel.Text = "汇出EXCEL(&E)";
            this.btnExcel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // gridControl1
            // 
            this.gridControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControl1.Location = new System.Drawing.Point(3, 45);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(865, 294);
            this.gridControl1.TabIndex = 5;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 25;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.dept_id,
            this.remark,
            this.crusr,
            this.crtim,
            this.amusr,
            this.amtim,
            this.pkey});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.HorzScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.PaintStyleName = "Style3D";
            this.gridView1.RowHeight = 27;
            this.gridView1.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Always;
            // 
            // dept_id
            // 
            this.dept_id.Caption = "部门";
            this.dept_id.FieldName = "dept_id";
            this.dept_id.Name = "dept_id";
            this.dept_id.OptionsColumn.AllowMove = false;
            this.dept_id.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.True;
            this.dept_id.OptionsFilter.AllowAutoFilter = false;
            this.dept_id.OptionsFilter.AllowFilter = false;
            this.dept_id.Tag = "2";
            this.dept_id.Visible = true;
            this.dept_id.VisibleIndex = 0;
            this.dept_id.Width = 160;
            // 
            // remark
            // 
            this.remark.Caption = "备注";
            this.remark.FieldName = "remark";
            this.remark.Name = "remark";
            this.remark.OptionsColumn.AllowMove = false;
            this.remark.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.remark.OptionsFilter.AllowAutoFilter = false;
            this.remark.OptionsFilter.AllowFilter = false;
            this.remark.Tag = "2";
            this.remark.Visible = true;
            this.remark.VisibleIndex = 1;
            this.remark.Width = 200;
            // 
            // crusr
            // 
            this.crusr.Caption = "建档人";
            this.crusr.FieldName = "crusr";
            this.crusr.Name = "crusr";
            this.crusr.OptionsColumn.AllowMove = false;
            this.crusr.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.crusr.OptionsColumn.ReadOnly = true;
            this.crusr.OptionsFilter.AllowAutoFilter = false;
            this.crusr.OptionsFilter.AllowFilter = false;
            this.crusr.Tag = "2";
            this.crusr.Visible = true;
            this.crusr.VisibleIndex = 2;
            this.crusr.Width = 110;
            // 
            // crtim
            // 
            this.crtim.Caption = "建档日期";
            this.crtim.FieldName = "crtim";
            this.crtim.Name = "crtim";
            this.crtim.OptionsColumn.AllowMove = false;
            this.crtim.OptionsColumn.AllowSize = false;
            this.crtim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.crtim.OptionsColumn.ReadOnly = true;
            this.crtim.OptionsFilter.AllowAutoFilter = false;
            this.crtim.OptionsFilter.AllowFilter = false;
            this.crtim.Visible = true;
            this.crtim.VisibleIndex = 3;
            this.crtim.Width = 120;
            // 
            // amusr
            // 
            this.amusr.Caption = "修改人";
            this.amusr.FieldName = "amusr";
            this.amusr.Name = "amusr";
            this.amusr.OptionsColumn.AllowMove = false;
            this.amusr.OptionsColumn.AllowSize = false;
            this.amusr.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.amusr.OptionsColumn.ReadOnly = true;
            this.amusr.OptionsFilter.AllowAutoFilter = false;
            this.amusr.OptionsFilter.AllowFilter = false;
            this.amusr.Visible = true;
            this.amusr.VisibleIndex = 4;
            this.amusr.Width = 110;
            // 
            // amtim
            // 
            this.amtim.Caption = "修改日期";
            this.amtim.FieldName = "amtim";
            this.amtim.Name = "amtim";
            this.amtim.OptionsColumn.AllowMove = false;
            this.amtim.OptionsColumn.AllowSize = false;
            this.amtim.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.amtim.OptionsColumn.ReadOnly = true;
            this.amtim.OptionsFilter.AllowAutoFilter = false;
            this.amtim.OptionsFilter.AllowFilter = false;
            this.amtim.Tag = "2";
            this.amtim.Visible = true;
            this.amtim.VisibleIndex = 5;
            this.amtim.Width = 120;
            // 
            // pkey
            // 
            this.pkey.Caption = "pkey";
            this.pkey.FieldName = "pkey";
            this.pkey.Name = "pkey";
            // 
            // txtPkey
            // 
            this.txtPkey.Location = new System.Drawing.Point(713, 12);
            this.txtPkey.Name = "txtPkey";
            this.txtPkey.Size = new System.Drawing.Size(100, 22);
            this.txtPkey.TabIndex = 6;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 535);
            this.Controls.Add(this.txtPkey);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "Form3";
            this.Text = "部门资料";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnDeleted;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton btnPrint;
        private System.Windows.Forms.ToolStripButton btnExcel;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn pkey;
        private DevExpress.XtraGrid.Columns.GridColumn dept_id;
        private DevExpress.XtraGrid.Columns.GridColumn remark;
        private DevExpress.XtraGrid.Columns.GridColumn crusr;
        private DevExpress.XtraGrid.Columns.GridColumn crtim;
        private DevExpress.XtraGrid.Columns.GridColumn amusr;
        private DevExpress.XtraGrid.Columns.GridColumn amtim;
        private System.Windows.Forms.TextBox txtPkey;
    }
}