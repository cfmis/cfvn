namespace cfvn.Forms
{
    partial class frmSysFuntionMenu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSysFuntionMenu));
            this.myImageList = new System.Windows.Forms.ImageList(this.components);
            this.myTree = new System.Windows.Forms.TreeView();
            this.txtMenu_id_name = new System.Windows.Forms.TextBox();
            this.txtModifydate = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModifyby = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtCreatedate = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCreateby = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtWindow_id_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWindow_id = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPrent_menu_id = new DevExpress.XtraEditors.LookUpEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMenu_id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRelatively_station = new System.Windows.Forms.TextBox();
            this.chkVisible = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCo_id = new System.Windows.Forms.TextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.txtpkey = new System.Windows.Forms.TextBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrent_menu_id.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
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
            // myTree
            // 
            this.myTree.Dock = System.Windows.Forms.DockStyle.Left;
            this.myTree.Font = new System.Drawing.Font("Tahoma", 9F);
            this.myTree.ImageIndex = 0;
            this.myTree.ImageList = this.myImageList;
            this.myTree.Location = new System.Drawing.Point(0, 38);
            this.myTree.Name = "myTree";
            this.myTree.SelectedImageIndex = 0;
            this.myTree.Size = new System.Drawing.Size(277, 544);
            this.myTree.TabIndex = 1;
            this.myTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.myTree_AfterSelect);
            // 
            // txtMenu_id_name
            // 
            this.txtMenu_id_name.Enabled = false;
            this.txtMenu_id_name.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMenu_id_name.Location = new System.Drawing.Point(375, 85);
            this.txtMenu_id_name.Name = "txtMenu_id_name";
            this.txtMenu_id_name.ReadOnly = true;
            this.txtMenu_id_name.Size = new System.Drawing.Size(162, 22);
            this.txtMenu_id_name.TabIndex = 31;
            this.txtMenu_id_name.Tag = "2";
            // 
            // txtModifydate
            // 
            this.txtModifydate.Enabled = false;
            this.txtModifydate.Location = new System.Drawing.Point(375, 268);
            this.txtModifydate.Name = "txtModifydate";
            this.txtModifydate.ReadOnly = true;
            this.txtModifydate.Size = new System.Drawing.Size(162, 22);
            this.txtModifydate.TabIndex = 29;
            this.txtModifydate.Tag = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 271);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 14);
            this.label8.TabIndex = 30;
            this.label8.Text = "修改日期";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 270);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 14);
            this.label9.TabIndex = 28;
            this.label9.Text = "修改人";
            // 
            // txtModifyby
            // 
            this.txtModifyby.Enabled = false;
            this.txtModifyby.Location = new System.Drawing.Point(151, 268);
            this.txtModifyby.Name = "txtModifyby";
            this.txtModifyby.ReadOnly = true;
            this.txtModifyby.Size = new System.Drawing.Size(149, 22);
            this.txtModifyby.TabIndex = 27;
            this.txtModifyby.Tag = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(319, 242);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 14);
            this.label10.TabIndex = 26;
            this.label10.Text = "建档日期";
            // 
            // txtCreatedate
            // 
            this.txtCreatedate.Enabled = false;
            this.txtCreatedate.Location = new System.Drawing.Point(375, 238);
            this.txtCreatedate.Name = "txtCreatedate";
            this.txtCreatedate.ReadOnly = true;
            this.txtCreatedate.Size = new System.Drawing.Size(162, 22);
            this.txtCreatedate.TabIndex = 25;
            this.txtCreatedate.Tag = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(106, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(43, 14);
            this.label11.TabIndex = 24;
            this.label11.Text = "建档人";
            // 
            // txtCreateby
            // 
            this.txtCreateby.Enabled = false;
            this.txtCreateby.Location = new System.Drawing.Point(151, 238);
            this.txtCreateby.Name = "txtCreateby";
            this.txtCreateby.ReadOnly = true;
            this.txtCreateby.Size = new System.Drawing.Size(149, 22);
            this.txtCreateby.TabIndex = 23;
            this.txtCreateby.Tag = "2";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(47, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "备注";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtRemark.Location = new System.Drawing.Point(151, 210);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ReadOnly = true;
            this.txtRemark.Size = new System.Drawing.Size(386, 22);
            this.txtRemark.TabIndex = 21;
            this.txtRemark.Tag = "2";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(47, 181);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "窗口名称";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWindow_id_name
            // 
            this.txtWindow_id_name.Enabled = false;
            this.txtWindow_id_name.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtWindow_id_name.Location = new System.Drawing.Point(151, 178);
            this.txtWindow_id_name.Name = "txtWindow_id_name";
            this.txtWindow_id_name.ReadOnly = true;
            this.txtWindow_id_name.Size = new System.Drawing.Size(386, 22);
            this.txtWindow_id_name.TabIndex = 19;
            this.txtWindow_id_name.Tag = "2";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(47, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "窗体路径";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWindow_id
            // 
            this.txtWindow_id.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtWindow_id.Location = new System.Drawing.Point(151, 147);
            this.txtWindow_id.Name = "txtWindow_id";
            this.txtWindow_id.ReadOnly = true;
            this.txtWindow_id.Size = new System.Drawing.Size(386, 22);
            this.txtWindow_id.TabIndex = 17;
            this.txtWindow_id.Tag = "2";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(47, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "上级菜单";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrent_menu_id
            // 
            this.txtPrent_menu_id.Enabled = false;
            this.txtPrent_menu_id.EnterMoveNextControl = true;
            this.txtPrent_menu_id.Location = new System.Drawing.Point(151, 116);
            this.txtPrent_menu_id.Name = "txtPrent_menu_id";
            this.txtPrent_menu_id.Properties.AppearanceDisabled.ForeColor = System.Drawing.Color.Black;
            this.txtPrent_menu_id.Properties.AppearanceDisabled.Options.UseForeColor = true;
            this.txtPrent_menu_id.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Style3D;
            this.txtPrent_menu_id.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtPrent_menu_id.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("menu_id", 150, "menu_id"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("menu_id_name", 250, "menu_id_name")});
            this.txtPrent_menu_id.Properties.DropDownRows = 20;
            this.txtPrent_menu_id.Properties.NullText = "";
            this.txtPrent_menu_id.Properties.PopupWidth = 400;
            this.txtPrent_menu_id.Properties.ShowHeader = false;
            this.txtPrent_menu_id.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.txtPrent_menu_id.Size = new System.Drawing.Size(386, 22);
            this.txtPrent_menu_id.TabIndex = 15;
            this.txtPrent_menu_id.Tag = "2";
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.Blue;
            this.label3.Location = new System.Drawing.Point(47, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "菜单";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMenu_id
            // 
            this.txtMenu_id.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMenu_id.Location = new System.Drawing.Point(151, 85);
            this.txtMenu_id.Name = "txtMenu_id";
            this.txtMenu_id.ReadOnly = true;
            this.txtMenu_id.Size = new System.Drawing.Size(223, 22);
            this.txtMenu_id.TabIndex = 5;
            this.txtMenu_id.Tag = "2";
            this.txtMenu_id.Leave += new System.EventHandler(this.txtMenu_id_Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(47, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "序号";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRelatively_station
            // 
            this.txtRelatively_station.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtRelatively_station.Location = new System.Drawing.Point(151, 55);
            this.txtRelatively_station.Name = "txtRelatively_station";
            this.txtRelatively_station.ReadOnly = true;
            this.txtRelatively_station.Size = new System.Drawing.Size(149, 22);
            this.txtRelatively_station.TabIndex = 3;
            this.txtRelatively_station.Tag = "1";
            this.txtRelatively_station.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRelatively_station_KeyPress);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkVisible.Location = new System.Drawing.Point(441, 59);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(98, 18);
            this.chkVisible.TabIndex = 2;
            this.chkVisible.Tag = "2";
            this.chkVisible.Text = "菜单是否可见";
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(47, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "公司";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtCo_id
            // 
            this.txtCo_id.Enabled = false;
            this.txtCo_id.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtCo_id.Location = new System.Drawing.Point(151, 24);
            this.txtCo_id.Name = "txtCo_id";
            this.txtCo_id.ReadOnly = true;
            this.txtCo_id.Size = new System.Drawing.Size(149, 22);
            this.txtCo_id.TabIndex = 0;
            this.txtCo_id.Tag = "2";
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
            this.btnCancel,
            this.toolStripSeparator3,
            this.btnSave,
            this.toolStripSeparator6,
            this.btnUndo,
            this.toolStripSeparator5});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(997, 38);
            this.toolStrip1.TabIndex = 4;
            this.toolStrip1.Text = "toolStrip1";
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
            this.btnNew.Size = new System.Drawing.Size(59, 35);
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
            this.btnEdit.Size = new System.Drawing.Size(51, 35);
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::cfvn.Properties.Resources.p_cancel;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(51, 35);
            this.btnCancel.Text = "注销";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::cfvn.Properties.Resources.SAVE;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(80, 35);
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
            this.btnUndo.Image = global::cfvn.Properties.Resources.cancel;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(69, 35);
            this.btnUndo.Text = "恢复(&U)";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // txtpkey
            // 
            this.txtpkey.Location = new System.Drawing.Point(404, 20);
            this.txtpkey.Name = "txtpkey";
            this.txtpkey.ReadOnly = true;
            this.txtpkey.Size = new System.Drawing.Size(133, 22);
            this.txtpkey.TabIndex = 32;
            this.txtpkey.Tag = "2";
            this.txtpkey.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(277, 38);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 544);
            this.splitter1.TabIndex = 5;
            this.splitter1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtpkey);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtMenu_id_name);
            this.panel1.Controls.Add(this.txtCo_id);
            this.panel1.Controls.Add(this.txtModifydate);
            this.panel1.Controls.Add(this.chkVisible);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtRelatively_station);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtModifyby);
            this.panel1.Controls.Add(this.txtMenu_id);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCreatedate);
            this.panel1.Controls.Add(this.txtPrent_menu_id);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtCreateby);
            this.panel1.Controls.Add(this.txtWindow_id);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtRemark);
            this.panel1.Controls.Add(this.txtWindow_id_name);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Font = new System.Drawing.Font("Tahoma", 9F);
            this.panel1.Location = new System.Drawing.Point(280, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(717, 544);
            this.panel1.TabIndex = 6;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(540, 150);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(172, 16);
            this.label12.TabIndex = 33;
            this.label12.Text = "** Forms.frmCdCompany";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // frmSysFuntionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 582);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.myTree);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("PMingLiU", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmSysFuntionMenu";
            this.Text = "frmSysFuntionMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSysFuntionMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmSysFuntionMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrent_menu_id.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList myImageList;
        private System.Windows.Forms.TreeView myTree;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton btnCancel;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMenu_id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRelatively_station;
        private System.Windows.Forms.CheckBox chkVisible;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCo_id;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.LookUpEdit txtPrent_menu_id;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtWindow_id;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtWindow_id_name;
        private System.Windows.Forms.TextBox txtModifydate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModifyby;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtCreatedate;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCreateby;
        private System.Windows.Forms.TextBox txtMenu_id_name;
        private System.Windows.Forms.TextBox txtpkey;
        private System.Windows.Forms.ToolStripButton btnUndo;
        private System.Windows.Forms.ToolStripButton btnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label12;

    }
}