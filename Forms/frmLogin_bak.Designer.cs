namespace cftest.Forms
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblUserid = new System.Windows.Forms.Label();
            this.lblPawword = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cboUserid = new System.Windows.Forms.ComboBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblUserid
            // 
            this.lblUserid.AutoSize = true;
            this.lblUserid.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblUserid.Location = new System.Drawing.Point(58, 30);
            this.lblUserid.Name = "lblUserid";
            this.lblUserid.Size = new System.Drawing.Size(52, 15);
            this.lblUserid.TabIndex = 2;
            this.lblUserid.Text = "用戶：";
            // 
            // lblPawword
            // 
            this.lblPawword.AutoSize = true;
            this.lblPawword.Font = new System.Drawing.Font("PMingLiU", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblPawword.Location = new System.Drawing.Point(56, 74);
            this.lblPawword.Name = "lblPawword";
            this.lblPawword.Size = new System.Drawing.Size(52, 15);
            this.lblPawword.TabIndex = 3;
            this.lblPawword.Text = "用戶：";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(142, 121);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(65, 30);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "确定(&Y)";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(216, 121);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(65, 30);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "退出(&X)";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // cboUserid
            // 
            this.cboUserid.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.cboUserid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserid.Font = new System.Drawing.Font("Tahoma", 10.5F);
            this.cboUserid.FormattingEnabled = true;
            this.cboUserid.Items.AddRange(new object[] {
            "ZRQ"});
            this.cboUserid.Location = new System.Drawing.Point(116, 25);
            this.cboUserid.Name = "cboUserid";
            this.cboUserid.Size = new System.Drawing.Size(165, 25);
            this.cboUserid.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.txtPassword.Location = new System.Drawing.Point(116, 68);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(167, 26);
            this.txtPassword.TabIndex = 6;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 189);
            this.ControlBox = false;
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.cboUserid);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.lblPawword);
            this.Controls.Add(this.lblUserid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserid;
        private System.Windows.Forms.Label lblPawword;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cboUserid;
        private System.Windows.Forms.TextBox txtPassword;
    }
}