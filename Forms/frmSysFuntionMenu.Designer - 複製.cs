namespace cftest.Forms
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
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
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.txtpkey = new System.Windows.Forms.TextBox();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnCancel = new System.Windows.Forms.ToolStripButton();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.btnUndo = new System.Windows.Forms.ToolStripButton();
            this.btnEdit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtPrent_menu_id.Properties)).BeginInit();
            this.toolStrip1.SuspendLayout();
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
            this.splitContainer1.Location = new System.Drawing.Point(3, 38);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.myTree);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtpkey);
            this.splitContainer1.Panel2.Controls.Add(this.txtMenu_id_name);
            this.splitContainer1.Panel2.Controls.Add(this.txtModifydate);
            this.splitContainer1.Panel2.Controls.Add(this.label8);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.txtModifyby);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.txtCreatedate);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.txtCreateby);
            this.splitContainer1.Panel2.Controls.Add(this.label7);
            this.splitContainer1.Panel2.Controls.Add(this.txtRemark);
            this.splitContainer1.Panel2.Controls.Add(this.label6);
            this.splitContainer1.Panel2.Controls.Add(this.txtWindow_id_name);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Panel2.Controls.Add(this.txtWindow_id);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.txtPrent_menu_id);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtMenu_id);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtRelatively_station);
            this.splitContainer1.Panel2.Controls.Add(this.chkVisible);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtCo_id);
            this.splitContainer1.Size = new System.Drawing.Size(992, 542);
            this.splitContainer1.SplitterDistance = 329;
            this.splitContainer1.TabIndex = 0;
            this.splitContainer1.Resize += new System.EventHandler(this.splitContainer1_Resize);
            // 
            // myTree
            // 
            this.myTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.myTree.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.myTree.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.myTree.ImageIndex = 0;
            this.myTree.ImageList = this.myImageList;
            this.myTree.Location = new System.Drawing.Point(1, 1);
            this.myTree.Name = "myTree";
            this.myTree.SelectedImageIndex = 0;
            this.myTree.Size = new System.Drawing.Size(324, 537);
            this.myTree.TabIndex = 1;
            this.myTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.myTree_AfterSelect);
            // 
            // txtMenu_id_name
            // 
            this.txtMenu_id_name.Enabled = false;
            this.txtMenu_id_name.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMenu_id_name.Location = new System.Drawing.Point(351, 79);
            this.txtMenu_id_name.Name = "txtMenu_id_name";
            this.txtMenu_id_name.ReadOnly = true;
            this.txtMenu_id_name.Size = new System.Drawing.Size(162, 22);
            this.txtMenu_id_name.TabIndex = 31;
            this.txtMenu_id_name.Tag = "2";
            // 
            // txtModifydate
            // 
            this.txtModifydate.Enabled = false;
            this.txtModifydate.Location = new System.Drawing.Point(351, 262);
            this.txtModifydate.Name = "txtModifydate";
            this.txtModifydate.ReadOnly = true;
            this.txtModifydate.Size = new System.Drawing.Size(162, 22);
            this.txtModifydate.TabIndex = 29;
            this.txtModifydate.Tag = "2";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(295, 265);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 30;
            this.label8.Text = "修改日期";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(82, 264);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 28;
            this.label9.Text = "修改人";
            // 
            // txtModifyby
            // 
            this.txtModifyby.Enabled = false;
            this.txtModifyby.Location = new System.Drawing.Point(127, 262);
            this.txtModifyby.Name = "txtModifyby";
            this.txtModifyby.ReadOnly = true;
            this.txtModifyby.Size = new System.Drawing.Size(149, 22);
            this.txtModifyby.TabIndex = 27;
            this.txtModifyby.Tag = "2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(295, 236);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 26;
            this.label10.Text = "建檔日期";
            // 
            // txtCreatedate
            // 
            this.txtCreatedate.Enabled = false;
            this.txtCreatedate.Location = new System.Drawing.Point(351, 232);
            this.txtCreatedate.Name = "txtCreatedate";
            this.txtCreatedate.ReadOnly = true;
            this.txtCreatedate.Size = new System.Drawing.Size(162, 22);
            this.txtCreatedate.TabIndex = 25;
            this.txtCreatedate.Tag = "2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(82, 235);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 24;
            this.label11.Text = "建檔人";
            // 
            // txtCreateby
            // 
            this.txtCreateby.Enabled = false;
            this.txtCreateby.Location = new System.Drawing.Point(127, 232);
            this.txtCreateby.Name = "txtCreateby";
            this.txtCreateby.ReadOnly = true;
            this.txtCreateby.Size = new System.Drawing.Size(149, 22);
            this.txtCreateby.TabIndex = 23;
            this.txtCreateby.Tag = "2";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(23, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 16);
            this.label7.TabIndex = 22;
            this.label7.Text = "備註";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRemark
            // 
            this.txtRemark.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtRemark.Location = new System.Drawing.Point(127, 204);
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.Size = new System.Drawing.Size(386, 22);
            this.txtRemark.TabIndex = 21;
            this.txtRemark.Tag = "2";
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(23, 175);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 20;
            this.label6.Text = "窗口名稱";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWindow_id_name
            // 
            this.txtWindow_id_name.Enabled = false;
            this.txtWindow_id_name.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtWindow_id_name.Location = new System.Drawing.Point(127, 172);
            this.txtWindow_id_name.Name = "txtWindow_id_name";
            this.txtWindow_id_name.ReadOnly = true;
            this.txtWindow_id_name.Size = new System.Drawing.Size(386, 22);
            this.txtWindow_id_name.TabIndex = 19;
            this.txtWindow_id_name.Tag = "2";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(23, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 16);
            this.label5.TabIndex = 18;
            this.label5.Text = "窗口";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtWindow_id
            // 
            this.txtWindow_id.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtWindow_id.Location = new System.Drawing.Point(127, 141);
            this.txtWindow_id.Name = "txtWindow_id";
            this.txtWindow_id.Size = new System.Drawing.Size(386, 22);
            this.txtWindow_id.TabIndex = 17;
            this.txtWindow_id.Tag = "2";
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(23, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 16);
            this.label4.TabIndex = 16;
            this.label4.Text = "上級菜單";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtPrent_menu_id
            // 
            this.txtPrent_menu_id.EnterMoveNextControl = true;
            this.txtPrent_menu_id.Location = new System.Drawing.Point(127, 110);
            this.txtPrent_menu_id.Name = "txtPrent_menu_id";
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
            this.label3.Location = new System.Drawing.Point(23, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "菜單";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtMenu_id
            // 
            this.txtMenu_id.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtMenu_id.Location = new System.Drawing.Point(127, 79);
            this.txtMenu_id.Name = "txtMenu_id";
            this.txtMenu_id.Size = new System.Drawing.Size(223, 22);
            this.txtMenu_id.TabIndex = 5;
            this.txtMenu_id.Tag = "2";
            this.txtMenu_id.Leave += new System.EventHandler(this.txtMenu_id_Leave);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(23, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "序號";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtRelatively_station
            // 
            this.txtRelatively_station.Font = new System.Drawing.Font("Tahoma", 9F);
            this.txtRelatively_station.Location = new System.Drawing.Point(127, 49);
            this.txtRelatively_station.Name = "txtRelatively_station";
            this.txtRelatively_station.Size = new System.Drawing.Size(149, 22);
            this.txtRelatively_station.TabIndex = 3;
            this.txtRelatively_station.Tag = "1";
            this.txtRelatively_station.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRelatively_station_KeyPress);
            // 
            // chkVisible
            // 
            this.chkVisible.AutoSize = true;
            this.chkVisible.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkVisible.Location = new System.Drawing.Point(417, 53);
            this.chkVisible.Name = "chkVisible";
            this.chkVisible.Size = new System.Drawing.Size(96, 16);
            this.chkVisible.TabIndex = 2;
            this.chkVisible.Tag = "2";
            this.chkVisible.Text = "菜單是否可見";
            this.chkVisible.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(23, 20);
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
            this.txtCo_id.Location = new System.Drawing.Point(127, 18);
            this.txtCo_id.Name = "txtCo_id";
            this.txtCo_id.ReadOnly = true;
            this.txtCo_id.Size = new System.Drawing.Size(149, 22);
            this.txtCo_id.TabIndex = 0;
            this.txtCo_id.Tag = "2";
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
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 38);
            // 
            // txtpkey
            // 
            this.txtpkey.Location = new System.Drawing.Point(380, 14);
            this.txtpkey.Name = "txtpkey";
            this.txtpkey.ReadOnly = true;
            this.txtpkey.Size = new System.Drawing.Size(133, 22);
            this.txtpkey.TabIndex = 32;
            this.txtpkey.Tag = "2";
            this.txtpkey.Visible = false;
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
            // btnNew
            // 
            this.btnNew.Image = global::SysDaan.Properties.Resources.mInsert;
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(55, 35);
            this.btnNew.Text = " 新 增";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = global::SysDaan.Properties.Resources.p_cancel;
            this.btnCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(49, 35);
            this.btnCancel.Text = "注銷";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(72, 35);
            this.btnSave.Text = " 保  存(&S)";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.Image = global::SysDaan.Properties.Resources.cancel;
            this.btnUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(65, 35);
            this.btnUndo.Text = "恢復(&U)";
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Image = global::SysDaan.Properties.Resources._24_Edit;
            this.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(49, 35);
            this.btnEdit.Text = "修改";
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 38);
            // 
            // frmSysFuntionMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 582);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("新細明體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Name = "frmSysFuntionMenu";
            this.Text = "frmSysFuntionMenu";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSysFuntionMenu_FormClosed);
            this.Load += new System.EventHandler(this.frmSysFuntionMenu_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.txtPrent_menu_id.Properties)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList myImageList;
        private System.Windows.Forms.SplitContainer splitContainer1;
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

    }
}