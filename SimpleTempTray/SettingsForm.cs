using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
        }

        private void _btnSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.HideOnStart = _chkMinimizeOnStart.Checked;
            Properties.Settings.Default.Save();
        }

    }
}
