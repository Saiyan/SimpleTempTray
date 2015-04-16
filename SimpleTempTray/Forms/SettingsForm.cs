using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTempTray
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            this.Icon = Z.IconLibrary.FarmFresh.Icon.Cog.GetIcon32();
            LoadSettings();
        }

        private void LoadSettings()
        {
            _chkMinimizeOnStart.Checked = Properties.Settings.Default.HideOnStart;
            _chkRunAtWindowsStart.Checked = File.Exists(Utility.GetAutostartShortcutPath());
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HideOnStart = _chkMinimizeOnStart.Checked;
            if (_chkRunAtWindowsStart.Checked)
            {
                Utility.CreateAutostartShortcut();
            }
            else
            {
                Utility.DeleteAutostartShortcut();
            }

            Properties.Settings.Default.Save();
            this.Close();
        }

    }
}
