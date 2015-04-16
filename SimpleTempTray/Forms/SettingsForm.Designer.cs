namespace SimpleTempTray
{
    partial class SettingsForm
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
            this._chkMinimizeOnStart = new System.Windows.Forms.CheckBox();
            this._btnSave = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this._chkRunAtWindowsStart = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // _chkMinimizeOnStart
            // 
            this._chkMinimizeOnStart.AutoSize = true;
            this._chkMinimizeOnStart.Location = new System.Drawing.Point(12, 12);
            this._chkMinimizeOnStart.Name = "_chkMinimizeOnStart";
            this._chkMinimizeOnStart.Size = new System.Drawing.Size(136, 17);
            this._chkMinimizeOnStart.TabIndex = 0;
            this._chkMinimizeOnStart.Text = "Minimize to tray on start";
            this._chkMinimizeOnStart.UseVisualStyleBackColor = true;
            // 
            // _btnSave
            // 
            this._btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this._btnSave.Location = new System.Drawing.Point(12, 60);
            this._btnSave.Name = "_btnSave";
            this._btnSave.Size = new System.Drawing.Size(75, 23);
            this._btnSave.TabIndex = 1;
            this._btnSave.Text = "Save";
            this._btnSave.UseVisualStyleBackColor = true;
            this._btnSave.Click += new System.EventHandler(this._btnSave_Click);
            // 
            // _btnCancel
            // 
            this._btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this._btnCancel.Location = new System.Drawing.Point(190, 60);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 2;
            this._btnCancel.Text = "Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            // 
            // _chkRunAtWindowsStart
            // 
            this._chkRunAtWindowsStart.AutoSize = true;
            this._chkRunAtWindowsStart.Location = new System.Drawing.Point(12, 35);
            this._chkRunAtWindowsStart.Name = "_chkRunAtWindowsStart";
            this._chkRunAtWindowsStart.Size = new System.Drawing.Size(232, 17);
            this._chkRunAtWindowsStart.TabIndex = 3;
            this._chkRunAtWindowsStart.Text = "Run SimpleTempTray when Windows starts";
            this._chkRunAtWindowsStart.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AcceptButton = this._btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this._btnCancel;
            this.ClientSize = new System.Drawing.Size(277, 89);
            this.Controls.Add(this._chkRunAtWindowsStart);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSave);
            this.Controls.Add(this._chkMinimizeOnStart);
            this.Name = "SettingsForm";
            this.Text = "SettingsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox _chkMinimizeOnStart;
        private System.Windows.Forms.Button _btnSave;
        private System.Windows.Forms.Button _btnCancel;
        private System.Windows.Forms.CheckBox _chkRunAtWindowsStart;
    }
}