using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTempTray
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            InitIcons();
            this.Visible = false;
        }

        private void InitIcons()
        {
            this.Icon = Properties.Resources.TrayIcon;
            
            /*Tray*/
            _tsmNew.Image = Z.IconLibrary.FarmFresh.Icon.Add.GetImage32();
            _tsmAbout.Image = Z.IconLibrary.FarmFresh.Icon.Information.GetImage32();
            _tsmExit.Image = Z.IconLibrary.FarmFresh.Icon.DoorOut.GetImage32();

            /*Bottom*/
            _tsmBottomNew.Image = Z.IconLibrary.FarmFresh.Icon.Add.GetImage32();
            _tsmBottomRemoveSelected.Image = Z.IconLibrary.FarmFresh.Icon.Delete.GetImage32();
            _tsmBottomRemoveAll.Image = Z.IconLibrary.FarmFresh.Icon.DeletePackage.GetImage32();
            _tsmBottomSettings.Image = Z.IconLibrary.FarmFresh.Icon.Cog.GetImage32();
        }

        private bool _hideToTray = true;
        private bool _firstShow = true;
        private List<Process> _explorers = new List<Process>();

        #region Methods

        /// <summary>
        /// Creates a new temporary directory with a RANDOM name in the temporary path of Windows.
        /// </summary>
        public DirectoryInfo GetNewTempDirectory()
        {
            return Utility.GetNewTempDirectory(null);
        }


        /// <summary>
        /// Creates a new random temporary directory and opens it in Windows Explorer.
        /// </summary>
        private void OpenNewTempDir()
        {
            OpenNewTempDir(null);
        }

        /// <summary>
        /// Creates a new temporary directory and opens it in Windows Explorer.
        /// </summary>
        /// <param name="dirname">The name that should be used for the new directory. If this is null or empty a random name will be generated.</param>
        private void OpenNewTempDir(string dirname)
        {
            DirectoryInfo temp_dir = Utility.GetNewTempDirectory(dirname);
            this._listboxDirectories.Items.Add(temp_dir);
            this._tsmDirectories.DropDownItems.Add(new TempDirectoryToolStripMenuItem(temp_dir));
            this._tsmDirectories.Enabled = true;
            _listboxDirectories.SelectedIndex = _listboxDirectories.Items.Count - 1;
            _explorers.Add(Utility.OpenDirectoryInExplorer(temp_dir));
        }

        /// <summary>
        /// Deletes all temporary directories created in this session. This WILL delete the folders on the harddrive.
        /// </summary>
        private void DeleteAllDirectories()
        {
            for (int i = 0; i < _listboxDirectories.Items.Count; i++ )
            {
                var dir = _listboxDirectories.Items[i] as DirectoryInfo ;
                if (dir != null)
                {
                    if (Utility.DeleteDirectory(dir) == Utility.DeletionResult.Retry)
                    {
                        i--;
                    }
                }
            }
            RemoveAllDirectories();
        }

        /// <summary>
        /// Deletes a single temporary directory created in this session. This will NOT delete the folder on the harddrive.
        /// </summary>
        private void RemoveSelectedDir()
        {
            var dinfo = this._listboxDirectories.SelectedItem as DirectoryInfo;
            this._listboxDirectories.Items.Remove(dinfo);
            for (int i = 0; i < _tsmDirectories.DropDownItems.Count; i++)
            {
                var tdtsm = _tsmDirectories.DropDownItems[i] as TempDirectoryToolStripMenuItem;
                if (tdtsm != null)
                {
                    if (tdtsm.Directory == dinfo)
                    {
                        _tsmDirectories.DropDownItems.RemoveAt(i);
                        break;
                    }
                }
            }
            if (_tsmDirectories.DropDownItems.Count == 0)
            {
                _tsmDirectories.Enabled = false;
            }
        }


        /// <summary>
        /// Removes all temporary directories created in this session. This will NOT delete the folders on the harddrive.
        /// </summary>
        private void RemoveAllDirectories()
        {
            _listboxDirectories.Items.Clear();
            _tsmDirectories.DropDownItems.Clear();
            _tsmDirectories.Enabled = false;
        }

        private void EnableDisableButtons()
        {
            if (_listboxDirectories.Items.Count == 0)
            {
                _tsmBottomRemoveAll.Enabled = false;
                _tsmBottomRemoveSelected.Enabled = false;
            }
            else
            {
                _tsmBottomRemoveAll.Enabled = true;
                _tsmBottomRemoveSelected.Enabled = true;
            }
        }
        #endregion


        #region Events
        private void _tsmNew_Click(object sender, EventArgs e)
        {
            OpenNewTempDir();
            EnableDisableButtons();
        }

        private void _listboxDirectories_DoubleClick(object sender, EventArgs e)
        {
            var dinfo = _listboxDirectories.SelectedItem as DirectoryInfo;
            if (dinfo != null)
            {
                Utility.OpenDirectoryInExplorer(dinfo);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (this._hideToTray)
            {
                e.Cancel = true;
                this.Hide();
            }
        }

        private void _tsmExit_Click(object sender, EventArgs e)
        {
            this._hideToTray = false;

            if (_listboxDirectories.Items.Count > 0)
            {
                var mbox_result = MessageBox.Show(
                    "Do you want to delete all your temporary folders?",
                    "",
                    MessageBoxButtons.YesNo,MessageBoxIcon.Question
                    ,MessageBoxDefaultButton.Button1);

                if (mbox_result == DialogResult.Yes)
                {
                    DeleteAllDirectories();
                }
            }

            this.Close();
        }

        private void notifyIcon1_DoubleClick(object sender, EventArgs e)
        {
            this.Show();
        }

        private void _tsmNewDialog_Click(object sender, EventArgs e)
        {
            var newForm = new NewDirectoryForm();
            DialogResult dres = newForm.ShowDialog();

            if (dres == DialogResult.OK
                && !string.IsNullOrEmpty(newForm.DirectoryName))
            {
                OpenNewTempDir(newForm.DirectoryName);
            }
            newForm.Dispose();
        }

        private void _tsmAbout_Click(object sender, EventArgs e)
        {
            var aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private void _tsmBottomRemoveSelected_Click(object sender, EventArgs e)
        {
            var selected_dir = _listboxDirectories.SelectedItem as DirectoryInfo;
            if (selected_dir == null) return;
            var dres = MessageBox.Show("Delete directory from your hard drive?", "", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dres == DialogResult.Yes)
            {
                while (Utility.DeleteDirectory(selected_dir) == Utility.DeletionResult.Retry) ;
            }
            RemoveSelectedDir();
            EnableDisableButtons();
        }

        private void _tsmBottomDeleteAll_Click(object sender, EventArgs e)
        {
            var dres = MessageBox.Show("Delete all directories from your hard drive?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dres == DialogResult.Yes)
            {
                DeleteAllDirectories();
            }
            RemoveAllDirectories();
            EnableDisableButtons();
        }

        private void _tsmBottomSettings_Click(object sender, EventArgs e)
        {
            var settingsForm = new SettingsForm();
            var dres = settingsForm.ShowDialog();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            if (this._firstShow && Properties.Settings.Default.HideOnStart)
            {
                this.Hide();
                this._firstShow = false;
            }
        }

        #endregion

    }
}
