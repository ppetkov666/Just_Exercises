
namespace ConvertApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Text;
    using System.Windows.Forms;
    using System.Threading;
    using System.Diagnostics;

    public partial class MainForm : Form
    {
        public const string cFileExtensionDeploy = ".deploy";
        public const int cIncrementValue = 1;
        public bool mDirIsEmpthy = false;
        public bool mExceptionCaught = false;
        public bool mChangesHasBeenMade = false;
        public const string cErrorMessage = "Error Message!";
        public const string cWarningMessage = "Warning Message!";
        public const string cInformationMessage = "Information Message!";



        public MainForm()
        {
            InitializeComponent();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

            using (FolderBrowserDialog fbdFolderDialog = new FolderBrowserDialog())
            {
                DialogResult result = fbdFolderDialog.ShowDialog();
                if (result == DialogResult.OK)
                {
                    try
                    {
                        txtTextBox.Text = fbdFolderDialog.SelectedPath;
                    }
                    catch (Exception)
                    {

                        Display("Please check your Directory and then try again!", cErrorMessage, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {

            Button aButton = sender as Button;
            bool aIsFromDeploy = aButton == btnConvert_FROM_Deploy ? true : false;
            string[] files = GetAllFiles(txtTextBox.Text);

            if (FilesValidationFailed())
            {
                return;
            }

            SetProgressBar(files);
            mChangesHasBeenMade = false;
            Convert(files, aIsFromDeploy);
            CheckIfChangesHasBeenMade(files);
        }

        private bool FilesValidationFailed()
        {
            if (mExceptionCaught || mDirIsEmpthy)
            {
                if (mExceptionCaught)
                {
                    Display("Invalid Selected Path", cErrorMessage, MessageBoxIcon.Error);
                    mExceptionCaught = false;
                }
                else if (mDirIsEmpthy)
                {
                    Display("Your directory does not contain any files", cWarningMessage, MessageBoxIcon.Warning);
                    mDirIsEmpthy = false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        private void CheckIfChangesHasBeenMade(string[] files)
        {
            string[] ConvertedFiles = GetAllFiles(txtTextBox.Text);
            for (int i = 0; i < files.Length; i++)
            {
                if (ConvertedFiles.Length != files.Length)
                {
                    mChangesHasBeenMade = true;
                    return;
                }
                else if (!ConvertedFiles.Contains(files[i]))
                {
                    mChangesHasBeenMade = true;
                    return;
                }
            }
            if (!mChangesHasBeenMade)
            {
                prb_Loading.Value = 0;
                Display("No convert occured ", cInformationMessage, MessageBoxIcon.Information);
            }
        }

        private void Convert(string[] allFiles, bool isFromDeploy)
        {
            try
            {
                for (int i = 0; i < allFiles.Length; i++)
                {
                    string file = allFiles[i];
                    string fileWithNewExtension = string.Empty;
                    //short way to be done with ternary operator
                    fileWithNewExtension = file.EndsWith(cFileExtensionDeploy)? fileWithNewExtension = file.Replace(cFileExtensionDeploy, "")
                                                                              : fileWithNewExtension = file + cFileExtensionDeploy;
                    if (isFromDeploy)
                    {
                        if (!file.EndsWith(cFileExtensionDeploy))
                        { 
                            prb_Loading.Value += cIncrementValue;
                            continue;
                        }
                    }
                    else
                    {
                        if (file.EndsWith(cFileExtensionDeploy))
                        {
                            prb_Loading.Value += cIncrementValue;
                            continue;
                        }
                    }

                   // detailed way to be done with clasicc if/ else construction
                   //if (isFromDeploy)
                   //{
                   //
                   //    if (file.EndsWith(cFileExtensionDeploy))
                   //    {
                   //        fileWithNewExtension = file.Replace(cFileExtensionDeploy, "");
                   //    }
                   //    else
                   //    {
                   //        prb_Loading.Value += cIncrementValue;
                   //        continue;
                   //    }
                   //}
                   //
                   //else
                   //{
                   //
                   //    if (file.EndsWith(cFileExtensionDeploy))
                   //    {
                   //        prb_Loading.Value += cIncrementValue;
                   //        continue;
                   //    }
                   //    else
                   //    {
                   //        fileWithNewExtension = file + cFileExtensionDeploy;
                   //    }
                   //}
                    try
                    {
                        PerformFileAction(file, fileWithNewExtension);
                    }
                    catch (Exception)
                    {
                        Display("File Error !", cErrorMessage, MessageBoxIcon.Error);
                    }
                    prb_Loading.Value += cIncrementValue;
                }
            }
            catch (Exception)
            {
                Display("Please check your files and Directories and then try again!", cErrorMessage, MessageBoxIcon.Error);
            }
        }
        private void PerformFileAction(string file, string newFile)
        {

            if (File.Exists(newFile))
            {
                File.Delete(newFile);
            }
            if (chkKeep_Initial_files.Checked)
            {
                File.Copy(file, newFile);
            }
            else
            {
                File.Move(file, newFile);
            }
        }

        private void SetProgressBar(string[] allFiles)
        {
            prb_Loading.Maximum = allFiles.Length;
            prb_Loading.Value = 0;
        }

        private void Display(string text, string message, MessageBoxIcon messageBoxIcon)
        {

            MessageBox.Show(this, text, message, MessageBoxButtons.OK, messageBoxIcon);
        }
        private string[] GetAllFiles(string dirPath)
        {
            string[] allFiles = new string[0];
            try
            {
                allFiles = chkConvert_all_sub_dirs.Checked ? Directory.GetFiles(dirPath, "*.*", SearchOption.AllDirectories)
                                                           : Directory.GetFiles(dirPath);
                SearchOption searchOption = chkConvert_all_sub_dirs.Checked ? SearchOption.AllDirectories
                                                                            : SearchOption.TopDirectoryOnly;
                allFiles = Directory.GetFiles(dirPath, "*.*", searchOption);
                if (allFiles.Length == 0)
                {
                    mDirIsEmpthy = true;
                }
            }
            catch (Exception)
            {
                mExceptionCaught = true;
            }
            return allFiles;
        }
    }
}
