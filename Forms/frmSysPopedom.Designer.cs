namespace cfvn.Forms
{
    partial class frmSysPopedom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSysPopedom));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.myTree = new System.Windows.Forms.TreeView();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.user_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.group_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ava_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mis_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.createdate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifyby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modifydate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contextMenuStrip_admin = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxMenu_admin_add_group = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenu_admin_amd_user = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxMenu_admin_browse = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_group = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_group_add_group = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_group_amd_group = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_group_del_group = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_group_add_user = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_group_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_group_browse = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_user = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip_user_amd_user = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_user_del_user = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_user_amd_pwd = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_user_setting = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip_user_browse = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.contextMenuStrip_admin.SuspendLayout();
            this.contextMenuStrip_group.SuspendLayout();
            this.contextMenuStrip_user.SuspendLayout();
            this.SuspendLayout();
            // 
            // myImageList
            // 
            this.myImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("myImageList.ImageStream")));
            this.myImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.myImageList.Images.SetKeyName(0, "model.png");
            this.myImageList.Images.SetKeyName(1, "file3.png");
            this.myImageList.Images.SetKeyName(2, "files1.png");
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Location = new System.Drawing.Point(3, 2);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.myTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1157, 674);
            this.splitContainer1.SplitterDistance = 383;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // myTree
            // 
            this.myTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTree.Font = new System.Drawing.Font("Tahoma", 9F);
            this.myTree.ImageIndex = 0;
            this.myTree.ImageList = this.myImageList;
            this.myTree.Location = new System.Drawing.Point(1, 1);
            this.myTree.Name = "myTree";
            this.myTree.SelectedImageIndex = 0;
            this.myTree.Size = new System.Drawing.Size(378, 668);
            this.myTree.TabIndex = 1;
            this.myTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.myTree_AfterSelect);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.user_name,
            this.group_id,
            this.ava_date,
            this.mis_date,
            this.remark,
            this.createby,
            this.createdate,
            this.modifyby,
            this.modifydate,
            this.typeid,
            this.password});
            this.dataGridView1.Location = new System.Drawing.Point(5, 8);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(757, 652);
            this.dataGridView1.TabIndex = 0;
            // 
            // user_id
            // 
            this.user_id.DataPropertyName = "user_id";
            this.user_id.HeaderText = "编号";
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            // 
            // user_name
            // 
            this.user_name.DataPropertyName = "user_name";
            this.user_name.HeaderText = "用户名称";
            this.user_name.Name = "user_name";
            this.user_name.ReadOnly = true;
            // 
            // group_id
            // 
            this.group_id.DataPropertyName = "group_id";
            this.group_id.HeaderText = "组别";
            this.group_id.Name = "group_id";
            this.group_id.ReadOnly = true;
            // 
            // ava_date
            // 
            this.ava_date.DataPropertyName = "ava_date";
            dataGridViewCellStyle1.Format = "d";
            dataGridViewCellStyle1.NullValue = null;
            this.ava_date.DefaultCellStyle = dataGridViewCellStyle1;
            this.ava_date.HeaderText = "生效日期";
            this.ava_date.Name = "ava_date";
            this.ava_date.ReadOnly = true;
            // 
            // mis_date
            // 
            this.mis_date.DataPropertyName = "mis_date";
            dataGridViewCellStyle2.Format = "d";
            dataGridViewCellStyle2.NullValue = null;
            this.mis_date.DefaultCellStyle = dataGridViewCellStyle2;
            this.mis_date.HeaderText = "失效日期";
            this.mis_date.Name = "mis_date";
            this.mis_date.ReadOnly = true;
            // 
            // remark
            // 
            this.remark.DataPropertyName = "remark";
            this.remark.HeaderText = "备注";
            this.remark.Name = "remark";
            this.remark.ReadOnly = true;
            // 
            // createby
            // 
            this.createby.DataPropertyName = "createby";
            this.createby.HeaderText = "建档人";
            this.createby.Name = "createby";
            this.createby.ReadOnly = true;
            // 
            // createdate
            // 
            this.createdate.DataPropertyName = "createdate";
            this.createdate.HeaderText = "建档日期";
            this.createdate.Name = "createdate";
            this.createdate.ReadOnly = true;
            // 
            // modifyby
            // 
            this.modifyby.DataPropertyName = "modifyby";
            this.modifyby.HeaderText = "修改人";
            this.modifyby.Name = "modifyby";
            this.modifyby.ReadOnly = true;
            // 
            // modifydate
            // 
            this.modifydate.DataPropertyName = "modifydate";
            this.modifydate.HeaderText = "修改日期";
            this.modifydate.Name = "modifydate";
            this.modifydate.ReadOnly = true;
            // 
            // typeid
            // 
            this.typeid.DataPropertyName = "typeid";
            this.typeid.HeaderText = "类型";
            this.typeid.Name = "typeid";
            this.typeid.ReadOnly = true;
            // 
            // password
            // 
            this.password.DataPropertyName = "password";
            this.password.HeaderText = "password";
            this.password.Name = "password";
            this.password.ReadOnly = true;
            this.password.Visible = false;
            // 
            // contextMenuStrip_admin
            // 
            this.contextMenuStrip_admin.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxMenu_admin_add_group,
            this.ctxMenu_admin_amd_user,
            this.ctxMenu_admin_browse});
            this.contextMenuStrip_admin.Name = "contextMenuStrip_admin";
            this.contextMenuStrip_admin.Size = new System.Drawing.Size(119, 70);
            // 
            // ctxMenu_admin_add_group
            // 
            this.ctxMenu_admin_add_group.Name = "ctxMenu_admin_add_group";
            this.ctxMenu_admin_add_group.Size = new System.Drawing.Size(118, 22);
            this.ctxMenu_admin_add_group.Text = "新增組";
            this.ctxMenu_admin_add_group.Click += new System.EventHandler(this.ctxMenu_admin_add_group_Click);
            // 
            // ctxMenu_admin_amd_user
            // 
            this.ctxMenu_admin_amd_user.Name = "ctxMenu_admin_amd_user";
            this.ctxMenu_admin_amd_user.Size = new System.Drawing.Size(118, 22);
            this.ctxMenu_admin_amd_user.Text = "修改用戶";
            this.ctxMenu_admin_amd_user.Click += new System.EventHandler(this.ctxMenu_admin_amd_user_Click);
            // 
            // ctxMenu_admin_browse
            // 
            this.ctxMenu_admin_browse.Name = "ctxMenu_admin_browse";
            this.ctxMenu_admin_browse.Size = new System.Drawing.Size(118, 22);
            this.ctxMenu_admin_browse.Text = "權限瀏覽";
            // 
            // contextMenuStrip_group
            // 
            this.contextMenuStrip_group.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuStrip_group_add_group,
            this.contextMenuStrip_group_amd_group,
            this.contextMenuStrip_group_del_group,
            this.contextMenuStrip_group_add_user,
            this.contextMenuStrip_group_setting,
            this.contextMenuStrip_group_browse});
            this.contextMenuStrip_group.Name = "contextMenuStrip_group";
            this.contextMenuStrip_group.Size = new System.Drawing.Size(143, 136);
            // 
            // contextMenuStrip_group_add_group
            // 
            this.contextMenuStrip_group_add_group.Name = "contextMenuStrip_group_add_group";
            this.contextMenuStrip_group_add_group.Size = new System.Drawing.Size(142, 22);
            this.contextMenuStrip_group_add_group.Text = "新增組";
            this.contextMenuStrip_group_add_group.Click += new System.EventHandler(this.contextMenuStrip_group_add_group_Click);
            // 
            // contextMenuStrip_group_amd_group
            // 
            this.contextMenuStrip_group_amd_group.Name = "contextMenuStrip_group_amd_group";
            this.contextMenuStrip_group_amd_group.Size = new System.Drawing.Size(142, 22);
            this.contextMenuStrip_group_amd_group.Text = "修改組";
            this.contextMenuStrip_group_amd_group.Click += new System.EventHandler(this.contextMenuStrip_group_amd_group_Click);
            // 
            // contextMenuStrip_group_del_group
            // 
            this.contextMenuStrip_group_del_group.Name = "contextMenuStrip_group_del_group";
            this.contextMenuStrip_group_del_group.Size = new System.Drawing.Size(142, 22);
            this.contextMenuStrip_group_del_group.Text = "刪除組";
            this.contextMenuStrip_group_del_group.Click += new System.EventHandler(this.contextMenuStrip_group_del_group_Click);
            // 
            // contextMenuStrip_group_add_user
            // 
            this.contextMenuStrip_group_add_user.Name = "contextMenuStrip_group_add_user";
            this.contextMenuStrip_group_add_user.Size = new System.Drawing.Size(142, 22);
            this.contextMenuStrip_group_add_user.Text = "新增用戶";
            this.contextMenuStrip_group_add_user.Click += new System.EventHandler(this.contextMenuStrip_group_add_user_Click);
            // 
            // contextMenuStrip_group_setting
            // 
            this.contextMenuStrip_group_setting.Name = "contextMenuStrip_group_setting";
            this.contextMenuStrip_group_setting.Size = new System.Drawing.Size(142, 22);
            this.contextMenuStrip_group_setting.Text = "用戶權限設置";
            this.contextMenuStrip_group_setting.Click += new System.EventHandler(this.contextMenuStrip_group_setting_Click);
            // 
            // contextMenuStrip_group_browse
            // 
            this.contextMenuStrip_group_browse.Name = "contextMenuStrip_group_browse";
            this.contextMenuStrip_group_browse.Size = new System.Drawing.Size(142, 22);
            this.contextMenuStrip_group_browse.Text = "權限瀏覽";
            // 
            // contextMenuStrip_user
            // 
            this.contextMenuStrip_user.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contextMenuStrip_user_amd_user,
            this.contextMenuStrip_user_del_user,
            this.contextMenuStrip_user_amd_pwd,
            this.contextMenuStrip_user_setting,
            this.contextMenuStrip_user_browse});
            this.contextMenuStrip_user.Name = "contextMenuStrip_user";
            this.contextMenuStrip_user.Size = new System.Drawing.Size(143, 114);
            // 
            // contextMenuStrip_user_amd_user
            // 
            this.contextMenuStrip_user_amd_user.Name = "contextMenuStrip_user_amd_user";
            this.contextMenuStrip_user_amd_user.Size = new System.Drawing.Size(142, 22);
            this.contextMenuStrip_user_amd_user.Text = "修改用戶";
            this.contextMenuStrip_user_amd_user.Click += new System.EventHandler(this.contextMenuStrip_user_amd_user_Click);
            // 
            // contextMenuStrip_user_del_user
            // 
            this.contextMenuStrip_user_del_user.Name = "contextMenuStrip_user_del_user";
            this.contextMenuStrip_user_del_user.Size = new System.Drawing.Size(142, 22);
            this.contextMenuStrip_user_del_user.Text = "刪除用戶";
            this.contextMenuStrip_user_del_user.Click += new System.EventHandler(this.contextMenuStrip_user_del_user_Click);
            // 
            // contextMenuStrip_user_amd_pwd
            // 
            this.contextMenuStrip_user_amd_pwd.Name = "contextMenuStrip_user_amd_pwd";
            this.contextMenuStrip_user_amd_pwd.Size = new System.Drawing.Size(142, 22);
            this.contextMenuStrip_user_amd_pwd.Text = "密碼修改";
            this.contextMenuStrip_user_amd_pwd.Click += new System.EventHandler(this.contextMenuStrip_user_amd_pwd_Click);
            // 
            // contextMenuStrip_user_setting
            // 
            this.contextMenuStrip_user_setting.Name = "contextMenuStrip_user_setting";
            this.contextMenuStrip_user_setting.Size = new System.Drawing.Size(142, 22);
            this.contextMenuStrip_user_setting.Text = "用戶權限設置";
            this.contextMenuStrip_user_setting.Click += new System.EventHandler(this.contextMenuStrip_user_setting_Click);
            // 
            // contextMenuStrip_user_browse
            // 
            this.contextMenuStrip_user_browse.Name = "contextMenuStrip_user_browse";
            this.contextMenuStrip_user_browse.Size = new System.Drawing.Size(142, 22);
            this.contextMenuStrip_user_browse.Text = "權限瀏覽";
            // 
            // frmSysPopedom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 679);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Tahoma", 9F);
            this.Name = "frmSysPopedom";
            this.Text = "frmSysPopedom";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSysPopedom_FormClosed);
            this.Load += new System.EventHandler(this.frmSysPopedom_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.contextMenuStrip_admin.ResumeLayout(false);
            this.contextMenuStrip_group.ResumeLayout(false);
            this.contextMenuStrip_user.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList myImageList;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView myTree;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_admin;
        private System.Windows.Forms.ToolStripMenuItem ctxMenu_admin_add_group;
        private System.Windows.Forms.ToolStripMenuItem ctxMenu_admin_amd_user;
        private System.Windows.Forms.ToolStripMenuItem ctxMenu_admin_browse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_group;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_group_add_group;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_group_amd_group;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_group_del_group;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_group_add_user;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_group_setting;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_group_browse;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip_user;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_user_amd_user;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_user_del_user;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_user_amd_pwd;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_user_setting;
        private System.Windows.Forms.ToolStripMenuItem contextMenuStrip_user_browse;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn group_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ava_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn mis_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn remark;
        private System.Windows.Forms.DataGridViewTextBoxColumn createby;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdate;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifyby;
        private System.Windows.Forms.DataGridViewTextBoxColumn modifydate;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn password;

    }
}