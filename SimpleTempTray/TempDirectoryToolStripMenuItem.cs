using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTempTray
{
    class TempDirectoryToolStripMenuItem : ToolStripMenuItem
    {
        public TempDirectoryToolStripMenuItem(DirectoryInfo dinfo)
        {
            this.Directory = dinfo;
            this.Text = dinfo.Name;
            this.Click += new System.EventHandler(this.GotClicked);
        }

        private void GotClicked(object sender, EventArgs e)
        {
            MainForm.OpenDirectoryInExplorer(this.Directory);
        }

        public DirectoryInfo Directory { get; set; }
    }
}
