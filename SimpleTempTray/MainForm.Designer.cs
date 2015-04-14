namespace SimpleTempTray
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this._cmsTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this._tsmNew = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmNewDialog = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmDirectories = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._tsmAbout = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmExit = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._listboxDirectories = new System.Windows.Forms.ListBox();
            this._msBottom = new System.Windows.Forms.MenuStrip();
            this._tsmBottomNew = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmBottomRemoveSelected = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmBottomRemoveAll = new System.Windows.Forms.ToolStripMenuItem();
            this._tsmBottomSettings = new System.Windows.Forms.ToolStripMenuItem();
            this._cmsTray.SuspendLayout();
            this._msBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.ContextMenuStrip = this._cmsTray;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.DoubleClick += new System.EventHandler(this.notifyIcon1_DoubleClick);
            // 
            // _cmsTray
            // 
            this._cmsTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmNew,
            this._tsmNewDialog,
            this.toolStripSeparator2,
            this._tsmDirectories,
            this.toolStripSeparator1,
            this._tsmAbout,
            this._tsmExit});
            this._cmsTray.Name = "contextMenuStrip1";
            this._cmsTray.Size = new System.Drawing.Size(131, 126);
            // 
            // _tsmNew
            // 
            this._tsmNew.Name = "_tsmNew";
            this._tsmNew.Size = new System.Drawing.Size(130, 22);
            this._tsmNew.Text = "New";
            this._tsmNew.Click += new System.EventHandler(this._tsmNew_Click);
            // 
            // _tsmNewDialog
            // 
            this._tsmNewDialog.Name = "_tsmNewDialog";
            this._tsmNewDialog.Size = new System.Drawing.Size(130, 22);
            this._tsmNewDialog.Text = "New...";
            this._tsmNewDialog.Click += new System.EventHandler(this._tsmNewDialog_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(127, 6);
            // 
            // _tsmDirectories
            // 
            this._tsmDirectories.Enabled = false;
            this._tsmDirectories.Name = "_tsmDirectories";
            this._tsmDirectories.Size = new System.Drawing.Size(130, 22);
            this._tsmDirectories.Text = "Directories";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(127, 6);
            // 
            // _tsmAbout
            // 
            this._tsmAbout.Name = "_tsmAbout";
            this._tsmAbout.Size = new System.Drawing.Size(130, 22);
            this._tsmAbout.Text = "About";
            this._tsmAbout.Click += new System.EventHandler(this._tsmAbout_Click);
            // 
            // _tsmExit
            // 
            this._tsmExit.Name = "_tsmExit";
            this._tsmExit.Size = new System.Drawing.Size(130, 22);
            this._tsmExit.Text = "Exit";
            this._tsmExit.Click += new System.EventHandler(this._tsmExit_Click);
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // _listboxDirectories
            // 
            this._listboxDirectories.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._listboxDirectories.FormattingEnabled = true;
            this._listboxDirectories.Location = new System.Drawing.Point(5, 3);
            this._listboxDirectories.Name = "_listboxDirectories";
            this._listboxDirectories.Size = new System.Drawing.Size(353, 225);
            this._listboxDirectories.TabIndex = 1;
            this._listboxDirectories.DoubleClick += new System.EventHandler(this._listboxDirectories_DoubleClick);
            // 
            // _msBottom
            // 
            this._msBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this._msBottom.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._tsmBottomNew,
            this._tsmBottomRemoveSelected,
            this._tsmBottomRemoveAll,
            this._tsmBottomSettings});
            this._msBottom.Location = new System.Drawing.Point(0, 237);
            this._msBottom.Name = "_msBottom";
            this._msBottom.Size = new System.Drawing.Size(362, 24);
            this._msBottom.TabIndex = 2;
            this._msBottom.Text = "menuStrip1";
            // 
            // _tsmBottomNew
            // 
            this._tsmBottomNew.Image = global::SimpleTempTray.Properties.Resources.default_icon_image;
            this._tsmBottomNew.Name = "_tsmBottomNew";
            this._tsmBottomNew.Size = new System.Drawing.Size(59, 20);
            this._tsmBottomNew.Text = "New";
            this._tsmBottomNew.Click += new System.EventHandler(this._tsmNew_Click);
            // 
            // _tsmBottomRemoveSelected
            // 
            this._tsmBottomRemoveSelected.Enabled = false;
            this._tsmBottomRemoveSelected.Image = global::SimpleTempTray.Properties.Resources.default_icon_image;
            this._tsmBottomRemoveSelected.Name = "_tsmBottomRemoveSelected";
            this._tsmBottomRemoveSelected.Size = new System.Drawing.Size(125, 20);
            this._tsmBottomRemoveSelected.Text = "Remove Selected";
            this._tsmBottomRemoveSelected.Click += new System.EventHandler(this._tsmBottomRemoveSelected_Click);
            // 
            // _tsmBottomRemoveAll
            // 
            this._tsmBottomRemoveAll.Enabled = false;
            this._tsmBottomRemoveAll.Image = global::SimpleTempTray.Properties.Resources.default_icon_image;
            this._tsmBottomRemoveAll.Name = "_tsmBottomRemoveAll";
            this._tsmBottomRemoveAll.Size = new System.Drawing.Size(95, 20);
            this._tsmBottomRemoveAll.Text = "Remove All";
            this._tsmBottomRemoveAll.Click += new System.EventHandler(this._tsmBottomDeleteAll_Click);
            // 
            // _tsmBottomSettings
            // 
            this._tsmBottomSettings.Image = global::SimpleTempTray.Properties.Resources.default_icon_image;
            this._tsmBottomSettings.Name = "_tsmBottomSettings";
            this._tsmBottomSettings.Size = new System.Drawing.Size(77, 20);
            this._tsmBottomSettings.Text = "Settings";
            this._tsmBottomSettings.Click += new System.EventHandler(this._tsmBottomSettings_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(362, 261);
            this.Controls.Add(this._msBottom);
            this.Controls.Add(this._listboxDirectories);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MainMenuStrip = this._msBottom;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "SimpleTempTray";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this._cmsTray.ResumeLayout(false);
            this._msBottom.ResumeLayout(false);
            this._msBottom.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip _cmsTray;
        private System.Windows.Forms.ToolStripMenuItem _tsmNew;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem _tsmDirectories;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _tsmExit;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.ListBox _listboxDirectories;
        private System.Windows.Forms.MenuStrip _msBottom;
        private System.Windows.Forms.ToolStripMenuItem _tsmBottomRemoveSelected;
        private System.Windows.Forms.ToolStripMenuItem _tsmBottomRemoveAll;
        private System.Windows.Forms.ToolStripMenuItem _tsmBottomNew;
        private System.Windows.Forms.ToolStripMenuItem _tsmBottomSettings;
        private System.Windows.Forms.ToolStripMenuItem _tsmNewDialog;
        private System.Windows.Forms.ToolStripMenuItem _tsmAbout;

    }
}

