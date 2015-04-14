namespace SimpleTempTray
{
    partial class NewDirectoryForm
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
            this._txtDirName = new System.Windows.Forms.TextBox();
            this._btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _txtDirName
            // 
            this._txtDirName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._txtDirName.Location = new System.Drawing.Point(12, 12);
            this._txtDirName.Name = "_txtDirName";
            this._txtDirName.Size = new System.Drawing.Size(200, 20);
            this._txtDirName.TabIndex = 0;
            // 
            // _btnAccept
            // 
            this._btnAccept.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._btnAccept.Location = new System.Drawing.Point(218, 10);
            this._btnAccept.Name = "_btnAccept";
            this._btnAccept.Size = new System.Drawing.Size(75, 23);
            this._btnAccept.TabIndex = 1;
            this._btnAccept.Text = "OK";
            this._btnAccept.UseVisualStyleBackColor = true;
            this._btnAccept.Click += new System.EventHandler(this._btnAccept_Click);
            // 
            // NewDirectoryForm
            // 
            this.AcceptButton = this._btnAccept;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(305, 42);
            this.Controls.Add(this._btnAccept);
            this.Controls.Add(this._txtDirName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "NewDirectoryForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Name";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.NewDirectoryForm_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _txtDirName;
        private System.Windows.Forms.Button _btnAccept;
    }
}