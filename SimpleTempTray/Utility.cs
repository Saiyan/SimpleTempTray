using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleTempTray
{
    class Utility
    {

        /// <summary>
        /// Creates a new temporary directory with a GIVEN name in the temporary path of Windows.
        /// </summary>
        /// <param name="dirname">The name that should be used for the new directory. If this is null or empty a random name will be generated.</param>
        public static DirectoryInfo GetNewTempDirectory(string dirname)
        {
            string temp_dir;
            if (string.IsNullOrEmpty(dirname))
            {
                do
                {
                    temp_dir = Utility.GetRandomDirectory();
                }
                while (Directory.Exists(temp_dir));
            }
            else
            {
                temp_dir = Path.Combine(Path.GetTempPath(), dirname);
            }

            if (Directory.Exists(temp_dir))
            {
                return new DirectoryInfo(temp_dir);
            }
            else
            {
                return Directory.CreateDirectory(temp_dir);
            }
        }

        /// <summary>
        /// Gets the path for a new random directory in the temporary path of Windows.
        /// </summary>
        public static string GetRandomDirectory()
        {
            return Path.Combine(Path.GetTempPath(), Path.GetRandomFileName());
        }


        /// <summary>
        /// Opens a given directory in Windows Explorer
        /// </summary>
        public static Process OpenDirectoryInExplorer(DirectoryInfo dinfo)
        {
            return Process.Start(dinfo.FullName);
        }

        /// <summary>
        /// Deletes a directory and shows a MessageBox on failure
        /// </summary>
        /// <param name="dir">The Directory to delete.</param>
        /// <returns>Indicates whether the deletion was successful, got canceled or if the user wants to retry the operation.</returns>
        public static DeletionResult DeleteDirectory(DirectoryInfo dir)
        {
            return DeleteDirectory(dir, true);
        }

        /// <summary>
        /// Deletes a directory and shows a MessageBox on failure
        /// </summary>
        /// <param name="dir">The Directory to delete.</param>
        /// <param name="showMsgBox">If true show a MessageBox at failure which asks the user if the process should be retried.</param>
        /// <returns>Indicates whether the deletion was successful, got canceled or if the user wants to retry the operation.</returns>
        public static DeletionResult DeleteDirectory(DirectoryInfo dir, bool showMsgBox)
        {
            try
            {
                if (Directory.Exists(dir.FullName))
                {
                    Directory.Delete(dir.FullName, true);
                }
            }
            catch (IOException ioe)
            {
                if (!showMsgBox)
                {
                    return DeletionResult.Cancel;
                }
                else
                {
                    string msg = string.Format("The Folder {0} couldn't be deleted. One of the containing files may be opened in another program.", dir.FullName);
                    var dres = MessageBox.Show(msg, "", MessageBoxButtons.RetryCancel);
                    if (dres == DialogResult.Retry)
                    {
                        return DeletionResult.Retry;
                    }
                }
            }
            return DeletionResult.Deleted;
        }

        public enum DeletionResult
        {
            Retry,
            Cancel,
            Deleted
        }
    }

}
