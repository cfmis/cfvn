namespace cfvn.Components
{
    partial class myFlow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnflowlist = new System.Windows.Forms.Button();
            this.btnflow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnflowlist
            // 
            this.btnflowlist.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnflowlist.Location = new System.Drawing.Point(170, 2);
            this.btnflowlist.Name = "btnflowlist";
            this.btnflowlist.Size = new System.Drawing.Size(94, 25);
            this.btnflowlist.TabIndex = 3;
            this.btnflowlist.Text = "流程查看";
            this.btnflowlist.UseVisualStyleBackColor = true;
            // 
            // btnflow
            // 
            this.btnflow.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnflow.Location = new System.Drawing.Point(2, 2);
            this.btnflow.Name = "btnflow";
            this.btnflow.Size = new System.Drawing.Size(154, 25);
            this.btnflow.TabIndex = 2;
            this.btnflow.Text = "草稿确认";
            this.btnflow.UseVisualStyleBackColor = true;
            // 
            // myFlow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnflowlist);
            this.Controls.Add(this.btnflow);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "myFlow";
            this.Size = new System.Drawing.Size(268, 30);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Button btnflowlist;
        public System.Windows.Forms.Button btnflow;
    }
}
