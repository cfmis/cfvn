namespace cfvn.Forms
{
    partial class frmSysWindow
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
            this.label6 = new System.Windows.Forms.Label();
            this.txtSeqence_id = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtTool_bar_obj_id = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWindow_id = new System.Windows.Forms.TextBox();
            this.txtTool_bar_obj_id_desc = new System.Windows.Forms.TextBox();
            this.bds1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvDetails = new System.Windows.Forms.DataGridView();
            this.window_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.window_id_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tool_bar_obj_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seqence_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tool_bar_obj_id_desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.create_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.updateby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.update_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFind = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtWindow_id1 = new System.Windows.Forms.TextBox();
            this.txtWindow_id_desc = new System.Windows.Forms.TextBox();
            this.btnAutoGen = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1109, 38);
            this.toolStrip1.TabIndex = 5;
            this.toolStrip1.Text = "toolStrip1";
            this.toolStrip1.Click += new System.EventHandler(this.toolStrip1_Click);
            // 
            // btnExit
            // 
            this.btnExit.AutoSize = false;
            this.btnExit.Image = global::cfvn.Properties.Resources.exit;
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
            this.btnNew.Size = new System.Drawing.Size(55, 35);
            this.btnNew.Text = " 新 增";
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
            this.btnEdit.Size = new System.Drawing.Size(55, 35);
            this.btnEdit.Text = " 修 改";
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
            this.btnDelete.Size = new System.Drawing.Size(49, 35);
            this.btnDelete.Text = "刪除";
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
            this.btnSave.Image = global::cfvn.Properties.Resources.SAVE;
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
            this.btnUndo.Size = new System.Drawing.Size(52, 35);
            this.btnUndo.Text = "恢 復";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // txtUpdate_date
            // 
            this.txtUpdate_date.Enabled = false;
            this.txtUpdate_date.Location = new System.Drawing.Point(440, 204);
            this.txtUpdate_date.Name = "txtUpdate_date";
            this.txtUpdate_date.ReadOnly = true;
            this.txtUpdate_date.Size = new System.Drawing.Size(181, 22);
            this.txtUpdate_date.TabIndex = 9;
            this.txtUpdate_date.Tag = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(367, 208);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 48;
            this.label8.Text = "修改日期";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(87, 206);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 46;
            this.label9.Text = "修改人";
            // 
            // txtUpdateby
            // 
            this.txtUpdateby.Enabled = false;
            this.txtUpdateby.Location = new System.Drawing.Point(140, 204);
            this.txtUpdateby.Name = "txtUpdateby";
            this.txtUpdateby.ReadOnly = true;
            this.txtUpdateby.Size = new System.Drawing.Size(147, 22);
            this.txtUpdateby.TabIndex = 8;
            this.txtUpdateby.Tag = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 174);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 14);
            this.label10.TabIndex = 44;
            this.label10.Text = "建档日期";
            // 
            // txtCreate_date
            // 
            this.txtCreate_date.Enabled = false;
            this.txtCreate_date.Location = new System.Drawing.Point(440, 169);
            this.txtCreate_date.Name = "txtCreate_date";
            this.txtCreate_date.ReadOnly = true;
            this.txtCreate_date.Size = new System.Drawing.Size(181, 22);
            this.txtCreate_date.TabIndex = 7;
            this.txtCreate_date.Tag = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(87, 173);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 14);
            this.label11.TabIndex = 42;
            this.label11.Text = "建档人";
            // 
            // txtCreateby
            // 
            this.txtCreateby.Enabled = false;
            this.txtCreateby.Location = new System.Drawing.Point(140, 169);
            this.txtCreateby.Name = "txtCreateby";
            this.txtCreateby.ReadOnly = true;
            this.txtCreateby.Size = new System.Drawing.Size(147, 22);
            this.txtCreateby.TabIndex = 6;
            this.txtCreateby.Tag = "2";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(19, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(117, 19);
            this.label7.TabIndex = 40;
            this.label7.Text = "备注";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtRemark.Location = new System.Drawing.Point(140, 136);
            this.txtRemark.MaxLength = 100;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(480, 22);
            this.txtRemark.TabIndex = 5;
            this.txtRemark.Tag = "2";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(19, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 19);
            this.label6.TabIndex = 38;
            this.label6.Text = "序号";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSeqence_id
            // 
            this.txtSeqence_id.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtSeqence_id.Location = new System.Drawing.Point(140, 105);
            this.txtSeqence_id.MaxLength = 10;
            this.txtSeqence_id.Name = "txtSeqence_id";
            this.txtSeqence_id.ReadOnly = true;
            this.txtSeqence_id.Size = new System.Drawing.Size(147, 22);
            this.txtSeqence_id.TabIndex = 4;
            this.txtSeqence_id.Tag = "2";
            // 
            // label5
            // 
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(3, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 19);
            this.label5.TabIndex = 36;
            this.label5.Text = "工具栏按钮对象编号";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtTool_bar_obj_id
            // 
            this.txtTool_bar_obj_id.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTool_bar_obj_id.Location = new System.Drawing.Point(140, 72);
            this.txtTool_bar_obj_id.MaxLength = 30;
            this.txtTool_bar_obj_id.Name = "txtTool_bar_obj_id";
            this.txtTool_bar_obj_id.ReadOnly = true;
            this.txtTool_bar_obj_id.Size = new System.Drawing.Size(147, 22);
            this.txtTool_bar_obj_id.TabIndex = 2;
            this.txtTool_bar_obj_id.Tag = "2";
            this.txtTool_bar_obj_id.Leave += new System.EventHandler(this.txtTool_bar_obj_id_Leave);
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(19, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 19);
            this.label3.TabIndex = 34;
            this.label3.Text = "窗体路径及名称";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWindow_id
            // 
            this.txtWindow_id.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtWindow_id.Location = new System.Drawing.Point(140, 7);
            this.txtWindow_id.MaxLength = 100;
            this.txtWindow_id.Name = "txtWindow_id";
            this.txtWindow_id.ReadOnly = true;
            this.txtWindow_id.Size = new System.Drawing.Size(301, 22);
            this.txtWindow_id.TabIndex = 0;
            this.txtWindow_id.Tag = "2";
            this.txtWindow_id.Leave += new System.EventHandler(this.txtWindow_id_Leave);
            // 
            // txtTool_bar_obj_id_desc
            // 
            this.txtTool_bar_obj_id_desc.Enabled = false;
            this.txtTool_bar_obj_id_desc.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtTool_bar_obj_id_desc.Location = new System.Drawing.Point(288, 72);
            this.txtTool_bar_obj_id_desc.MaxLength = 100;
            this.txtTool_bar_obj_id_desc.Name = "txtTool_bar_obj_id_desc";
            this.txtTool_bar_obj_id_desc.ReadOnly = true;
            this.txtTool_bar_obj_id_desc.Size = new System.Drawing.Size(153, 22);
            this.txtTool_bar_obj_id_desc.TabIndex = 3;
            this.txtTool_bar_obj_id_desc.Tag = "2";
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
            this.window_id,
            this.window_id_desc,
            this.tool_bar_obj_id,
            this.seqence_id,
            this.tool_bar_obj_id_desc,
            this.remark,
            this.createby,
            this.create_date,
            this.updateby,
            this.update_date});
            this.dgvDetails.Location = new System.Drawing.Point(2, 292);
            this.dgvDetails.Name = "dgvDetails";
            this.dgvDetails.ReadOnly = true;
            this.dgvDetails.RowTemplate.Height = 24;
            this.dgvDetails.Size = new System.Drawing.Size(1106, 415);
            this.dgvDetails.TabIndex = 50;
            // 
            // window_id
            // 
            this.window_id.DataPropertyName = "window_id";
            this.window_id.HeaderText = "窗体路径及名称";
            this.window_id.Name = "window_id";
            this.window_id.ReadOnly = true;
            this.window_id.Width = 150;
            // 
            // window_id_desc
            // 
            this.window_id_desc.DataPropertyName = "window_id_desc";
            this.window_id_desc.HeaderText = "窗体名称";
            this.window_id_desc.Name = "window_id_desc";
            this.window_id_desc.ReadOnly = true;
            this.window_id_desc.Width = 150;
            // 
            // tool_bar_obj_id
            // 
            this.tool_bar_obj_id.DataPropertyName = "tool_bar_obj_id";
            this.tool_bar_obj_id.HeaderText = "按鈕对象編號";
            this.tool_bar_obj_id.Name = "tool_bar_obj_id";
            this.tool_bar_obj_id.ReadOnly = true;
            this.tool_bar_obj_id.Width = 150;
            // 
            // seqence_id
            // 
            this.seqence_id.DataPropertyName = "seqence_id";
            this.seqence_id.HeaderText = "序号";
            this.seqence_id.Name = "seqence_id";
            this.seqence_id.ReadOnly = true;
            this.seqence_id.Width = 60;
            // 
            // tool_bar_obj_id_desc
            // 
            this.tool_bar_obj_id_desc.DataPropertyName = "tool_bar_obj_id_desc";
            this.tool_bar_obj_id_desc.HeaderText = "按钮对象名称";
            this.tool_bar_obj_id_desc.Name = "tool_bar_obj_id_desc";
            this.tool_bar_obj_id_desc.ReadOnly = true;
            this.tool_bar_obj_id_desc.Width = 180;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            this.remark.Width = 180;
            // 
            // createby
            // 
            this.createby.DataPropertyName = "createby";
            this.createby.HeaderText = "建档人";
            this.createby.Name = "createby";
            this.createby.ReadOnly = true;
            this.createby.Visible = false;
            // 
            // create_date
            // 
            this.create_date.DataPropertyName = "create_date";
            this.create_date.HeaderText = "建档日期";
            this.create_date.Name = "create_date";
            this.create_date.ReadOnly = true;
            this.create_date.Visible = false;
            // 
            // updateby
            // 
            this.updateby.DataPropertyName = "updateby";
            this.updateby.HeaderText = "修改人";
            this.updateby.Name = "updateby";
            this.updateby.ReadOnly = true;
            this.updateby.Visible = false;
            // 
            // update_date
            // 
            this.update_date.DataPropertyName = "update_date";
            this.update_date.HeaderText = "修改日期";
            this.update_date.Name = "update_date";
            this.update_date.ReadOnly = true;
            this.update_date.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnFind);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtWindow_id1);
            this.groupBox1.Location = new System.Drawing.Point(674, 57);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(433, 220);
            this.groupBox1.TabIndex = 51;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询条件";
            // 
            // btnFind
            // 
            this.btnFind.Image = global::cfvn.Properties.Resources.p_query;
            this.btnFind.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnFind.Location = new System.Drawing.Point(243, 103);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(90, 40);
            this.btnFind.TabIndex = 37;
            this.btnFind.Text = "查 询 ";
            this.btnFind.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnFind.UseVisualStyleBackColor = true;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 14);
            this.label1.TabIndex = 36;
            this.label1.Text = "窗体体路径及名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWindow_id1
            // 
            this.txtWindow_id1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtWindow_id1.Location = new System.Drawing.Point(146, 31);
            this.txtWindow_id1.MaxLength = 100;
            this.txtWindow_id1.Name = "txtWindow_id1";
            this.txtWindow_id1.Size = new System.Drawing.Size(275, 22);
            this.txtWindow_id1.TabIndex = 35;
            // 
            // txtWindow_id_desc
            // 
            this.txtWindow_id_desc.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtWindow_id_desc.Location = new System.Drawing.Point(140, 40);
            this.txtWindow_id_desc.MaxLength = 100;
            this.txtWindow_id_desc.Name = "txtWindow_id_desc";
            this.txtWindow_id_desc.ReadOnly = true;
            this.txtWindow_id_desc.Size = new System.Drawing.Size(301, 22);
            this.txtWindow_id_desc.TabIndex = 1;
            this.txtWindow_id_desc.Tag = "2";
            // 
            // btnAutoGen
            // 
            this.btnAutoGen.Enabled = false;
            this.btnAutoGen.Location = new System.Drawing.Point(447, 70);
            this.btnAutoGen.Name = "btnAutoGen";
            this.btnAutoGen.Size = new System.Drawing.Size(173, 27);
            this.btnAutoGen.TabIndex = 52;
            this.btnAutoGen.Text = "自动添加窗体工具栏按钮";
            this.btnAutoGen.UseVisualStyleBackColor = true;
            this.btnAutoGen.Click += new System.EventHandler(this.btnAutoGen_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnAutoGen);
            this.panel1.Controls.Add(this.txtWindow_id);
            this.panel1.Controls.Add(this.txtWindow_id_desc);
            this.panel1.Controls.Add(this.txtTool_bar_obj_id);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtSeqence_id);
            this.panel1.Controls.Add(this.txtTool_bar_obj_id_desc);
            this.panel1.Controls.Add(this.label6);
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
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(3, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(641, 237);
            this.panel1.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(19, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 19);
            this.label4.TabIndex = 54;
            this.label4.Text = "窗体描述";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(446, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 14);
            this.label2.TabIndex = 53;
            this.label2.Text = "**例如:Forms.frmCdCompany";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // frmSysWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1109, 719);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvDetails);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "frmSysWindow";
            this.Text = "frmSysWindow";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSysWindow_FormClosed);
            this.Load += new System.EventHandler(this.frmSysWindow_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bds1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetails)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSeqence_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtTool_bar_obj_id;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWindow_id;
        private System.Windows.Forms.TextBox txtTool_bar_obj_id_desc;
        private System.Windows.Forms.BindingSource bds1;
        private System.Windows.Forms.DataGridView dgvDetails;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtWindow_id1;
        private System.Windows.Forms.TextBox txtWindow_id_desc;
        private System.Windows.Forms.Button btnAutoGen;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.DataGridViewTextBoxColumn window_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn window_id_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn tool_bar_obj_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn seqence_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn tool_bar_obj_id_desc;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn createby;
        private System.Windows.Forms.DataGridViewTextBoxColumn create_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn updateby;
        private System.Windows.Forms.DataGridViewTextBoxColumn update_date;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
    }
}