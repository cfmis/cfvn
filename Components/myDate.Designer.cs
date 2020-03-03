namespace cfvn.Components
{
    partial class myDate
    {
        /// <summary> 
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器
        /// 修改這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.mskText = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // mskText
            // 
            this.mskText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mskText.Font = new System.Drawing.Font("Tahoma", 9F);
            this.mskText.Location = new System.Drawing.Point(1, 0);
            this.mskText.Mask = "0000/00/00";
            this.mskText.Name = "mskText";
            this.mskText.PromptChar = ' ';
            this.mskText.ReadOnly = true;
            this.mskText.Size = new System.Drawing.Size(102, 22);
            this.mskText.TabIndex = 0;
            this.mskText.Tag = "2";
            this.mskText.ValidatingType = typeof(System.DateTime);
            this.mskText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.mskText_KeyPress);
            this.mskText.Leave += new System.EventHandler(this.mskText_Leave);
            // 
            // myDate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mskText);
            this.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "myDate";
            this.Size = new System.Drawing.Size(103, 23);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.MaskedTextBox mskText;




    }
}
