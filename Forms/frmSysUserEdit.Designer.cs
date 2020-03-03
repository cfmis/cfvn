namespace cfvn.Forms
{
    partial class frmSysUserEdit
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnExit = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnSave = new System.Windows.Forms.ToolStripButton();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtUser_id = new System.Windows.Forms.TextBox();
            this.txtUser_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbInherit_type = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCreateby = new System.Windows.Forms.TextBox();
            this.txtCreatedate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtModifydate = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtModifyby = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.mskMis_date = new System.Windows.Forms.MaskedTextBox();
            this.mskAva_date = new System.Windows.Forms.MaskedTextBox();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.AutoSize = false;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnExit,
            this.toolStripSeparator1,
            this.btnSave});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.toolStrip1.Size = new System.Drawing.Size(458, 36);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnExit
            // 
            this.btnExit.Image = global::cfvn.Properties.Resources.exit;
            this.btnExit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(63, 33);
            this.btnExit.Text = "Exit (&X)";
            this.btnExit.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::cfvn.Properties.Resources.SAVE;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(64, 33);
            this.btnSave.Text = "Save (&S)";
            this.btnSave.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Location = new System.Drawing.Point(29, 14);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(29, 12);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "编号";
            // 
            // txtUser_id
            // 
            this.txtUser_id.Location = new System.Drawing.Point(61, 9);
            this.txtUser_id.Name = "txtUser_id";
            this.txtUser_id.ReadOnly = true;
            this.txtUser_id.Size = new System.Drawing.Size(113, 22);
            this.txtUser_id.TabIndex = 2;
            this.txtUser_id.Leave += new System.EventHandler(this.txtUser_id_Leave);
            // 
            // txtUser_name
            // 
            this.txtUser_name.Location = new System.Drawing.Point(61, 39);
            this.txtUser_name.Name = "txtUser_name";
            this.txtUser_name.Size = new System.Drawing.Size(327, 22);
            this.txtUser_name.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(61, 69);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.ReadOnly = true;
            this.txtPassword.Size = new System.Drawing.Size(113, 22);
            this.txtPassword.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 6;
            this.label2.Text = "密码";
            // 
            // cmbInherit_type
            // 
            this.cmbInherit_type.FormattingEnabled = true;
            this.cmbInherit_type.Items.AddRange(new object[] {
            "Y",
            "N"});
            this.cmbInherit_type.Location = new System.Drawing.Point(275, 70);
            this.cmbInherit_type.Name = "cmbInherit_type";
            this.cmbInherit_type.Size = new System.Drawing.Size(113, 20);
            this.cmbInherit_type.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(243, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 8;
            this.label3.Text = "继承";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 105);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 11;
            this.label4.Text = "开始日期";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(219, 105);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "失效日期";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 133);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 14;
            this.label6.Text = "建档人";
            // 
            // txtCreateby
            // 
            this.txtCreateby.Location = new System.Drawing.Point(61, 130);
            this.txtCreateby.Name = "txtCreateby";
            this.txtCreateby.ReadOnly = true;
            this.txtCreateby.Size = new System.Drawing.Size(113, 22);
            this.txtCreateby.TabIndex = 13;
            // 
            // txtCreatedate
            // 
            this.txtCreatedate.Location = new System.Drawing.Point(275, 130);
            this.txtCreatedate.Name = "txtCreatedate";
            this.txtCreatedate.ReadOnly = true;
            this.txtCreatedate.Size = new System.Drawing.Size(113, 22);
            this.txtCreatedate.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(219, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "建档日期";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 163);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 12);
            this.label8.TabIndex = 20;
            this.label8.Text = "修改日期";
            // 
            // txtModifydate
            // 
            this.txtModifydate.Location = new System.Drawing.Point(275, 160);
            this.txtModifydate.Name = "txtModifydate";
            this.txtModifydate.ReadOnly = true;
            this.txtModifydate.Size = new System.Drawing.Size(113, 22);
            this.txtModifydate.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 163);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 18;
            this.label9.Text = "修改人";
            // 
            // txtModifyby
            // 
            this.txtModifyby.Location = new System.Drawing.Point(61, 160);
            this.txtModifyby.Name = "txtModifyby";
            this.txtModifyby.ReadOnly = true;
            this.txtModifyby.Size = new System.Drawing.Size(113, 22);
            this.txtModifyby.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.mskMis_date);
            this.panel1.Controls.Add(this.mskAva_date);
            this.panel1.Controls.Add(this.txtModifydate);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.lblUser);
            this.panel1.Controls.Add(this.txtUser_id);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtModifyby);
            this.panel1.Controls.Add(this.txtUser_name);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtPassword);
            this.panel1.Controls.Add(this.txtCreatedate);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.cmbInherit_type);
            this.panel1.Controls.Add(this.txtCreateby);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(0, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(457, 238);
            this.panel1.TabIndex = 21;
            // 
            // mskMis_date
            // 
            this.mskMis_date.Location = new System.Drawing.Point(275, 99);
            this.mskMis_date.Mask = "0000/00/00";
            this.mskMis_date.Name = "mskMis_date";
            this.mskMis_date.PromptChar = ' ';
            this.mskMis_date.Size = new System.Drawing.Size(113, 22);
            this.mskMis_date.TabIndex = 22;
            this.mskMis_date.ValidatingType = typeof(System.DateTime);
            this.mskMis_date.Leave += new System.EventHandler(this.mskMis_date_Leave);
            // 
            // mskAva_date
            // 
            this.mskAva_date.Location = new System.Drawing.Point(61, 99);
            this.mskAva_date.Mask = "0000/00/00";
            this.mskAva_date.Name = "mskAva_date";
            this.mskAva_date.PromptChar = ' ';
            this.mskAva_date.Size = new System.Drawing.Size(113, 22);
            this.mskAva_date.TabIndex = 21;
            this.mskAva_date.ValidatingType = typeof(System.DateTime);
            this.mskAva_date.Leave += new System.EventHandler(this.mskAva_date_Leave);
            // 
            // frmSysUserEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(458, 279);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmSysUserEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmSysUserEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmSysUserEdit_FormClosed);
            this.Load += new System.EventHandler(this.frmSysUserEdit_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnExit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton btnSave;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtUser_id;
        private System.Windows.Forms.TextBox txtUser_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbInherit_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCreateby;
        private System.Windows.Forms.TextBox txtCreatedate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtModifydate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtModifyby;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MaskedTextBox mskMis_date;
        private System.Windows.Forms.MaskedTextBox mskAva_date;

    }
}