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
    public partial class NewDirectoryForm : Form
    {
        public NewDirectoryForm()
        {
            InitializeComponent();
        }

        public string DirectoryName { get; private set; }

        private void _btnAccept_Click(object sender, EventArgs e)
        {
            this.DirectoryName = _txtDirName.Text;
            this.Close();
        }

        private void NewDirectoryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (string.IsNullOrEmpty(this.DirectoryName))
            {
                this.DialogResult = DialogResult.Abort;
            }
            else
            {
                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
