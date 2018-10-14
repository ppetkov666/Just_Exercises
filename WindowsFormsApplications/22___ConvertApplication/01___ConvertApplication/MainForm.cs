
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
        public const string c_FileExtensionDeploy = ".deploy";
        private Rectangle m_txtTextBoxOriginalSize;
        private Rectangle m_btnBrowseOriginalSize;
        private Rectangle m_btnConvert_to_DeployOriginalSize;
        private Rectangle m_btnConvert_From_DeployOriginalSize;
        private Rectangle m_chkKeep_Initial_filesOriginalSize;
        private Rectangle m_prbMyProgressBarOriginalSize;
        private Rectangle m_lblPercentageLabelOriginalSize;
        private Rectangle m_chkConvert_all_sub_dirsOriginalSize;
        private Size m_mainFormOriginalSize;
        private delegate void d_Convert(string str_param);
        

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            InitializeSizeControls();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            // this is the regular Solution
            //using (FolderBrowserDialog folderDialog = new FolderBrowserDialog())
            //{
            //
            //    
            //    if (folderDialog.ShowDialog() == DialogResult.OK)
            //    {
            //
            //        txtTextBox.Text = folderDialog.SelectedPath;
            //    }
            //}

            // this is my custom "Hack"
            string fileName = "Save Here";
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.FileName = fileName;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    
                    txtTextBox.Text = Path.GetDirectoryName(sfd.FileName);
                }
            }
        }

        private void btnConvert_TO_Deploy_Click(object sender, EventArgs e)
        {

            GetProgressBar();

            string dirPath = txtTextBox.Text;

            Get_files_converted_TO_deploy(dirPath);
        }

        private void btnConvert_FROM_Deploy_Click(object sender, EventArgs e)
        {

            GetProgressBar();

            string dirPath = txtTextBox.Text;
            Get_files_converted_FROM_deploy(dirPath);
        }
        private void Get_files_converted_TO_deploy(string dirPath)
        {
            if (DirIsEmpthy(dirPath))
            {
                return;
            }
            string[] files = Directory.GetFiles(dirPath);
            if (files.Length == 0)
            {

                Display("Directory Is Empty");
                return;
            }
            else
            {
                foreach (var file in files)
                {
                    if (file.EndsWith(c_FileExtensionDeploy))
                    {
                        continue;
                    }

                    else
                    {
                        if (chkKeep_Initial_files.Checked)
                        {
                            string fileWithNewExtension = Path.Combine(dirPath, Path.GetFileName(file + c_FileExtensionDeploy));
                            if (files.Contains(fileWithNewExtension))
                            {
                                continue;
                            }
                            else
                            {
                                File.Copy(file, fileWithNewExtension);
                            }

                        }
                        else
                        {

                            string fileWithNewExtension = Path.Combine(dirPath, Path.GetFileName(file + c_FileExtensionDeploy));
                            if (files.Contains(fileWithNewExtension))
                            {
                                File.Delete(file);
                                continue;
                            }
                            else
                            {
                                File.Move(file, fileWithNewExtension);
                            }
                        }
                    }
                }
            }
            if (chkConvert_all_sub_dirs.Checked)
            {
                Convert_sub_directories(dirPath, chkConvert_all_sub_dirs.Checked, Get_files_converted_TO_deploy);
            }
        }

        private void Get_files_converted_FROM_deploy(string dirPath)
        {
            // check for Directory path 
            if (DirIsEmpthy(dirPath))
            {
                return;
            }
            string[] files = Directory.GetFiles(dirPath);
            // check for files into Directory 
            if (files.Length == 0)
            {
                Display("Directory Is Empty");
                return;
            }

            else
            {
                foreach (string file in files)
                {
                    string extension = Path.GetExtension(file);

                    if (!(extension == c_FileExtensionDeploy))
                    {
                        continue;
                    }
                    else
                    {
                        if (chkKeep_Initial_files.Checked)
                        {

                            string newFile = GetFileWithoutExt(dirPath, file);
                            if (files.Contains(newFile))
                            {
                                File.Delete(file);
                                continue;
                            }
                            else
                            {
                                File.Copy(file, newFile);
                            }

                        }
                        else
                        {
                            string newFile = GetFileWithoutExt(dirPath, file);
                            if (files.Contains(newFile))
                            {
                                File.Delete(file);
                                continue;
                            }
                            else
                            {
                                File.Move(file, newFile);
                            }

                        }
                    }
                }

                if (chkConvert_all_sub_dirs.Checked)
                {
                    Convert_sub_directories(dirPath, chkConvert_all_sub_dirs.Checked, Get_files_converted_FROM_deploy);
                }
            }
        }

        private void Convert_sub_directories(string dirPath, bool checkBox_checked, d_Convert Convert)
        {
            if (checkBox_checked)
            {
                string[] allDirectories = Directory.GetDirectories(dirPath);
                foreach (string eachDir in allDirectories)
                {

                    Convert(eachDir);
                }
            }
        }

        private string GetFileWithoutExt(string dirPath, string file)
        {
            string fileWithoutExtension = Path.GetFileNameWithoutExtension(file);
            string newFile = Path.Combine(dirPath, fileWithoutExtension);
            return newFile;
        }

        private bool DirIsEmpthy(string dirPath)
        {
            if (string.IsNullOrEmpty(dirPath))
            {
                Display("Directory Path is Missing, Please Enter valid Directory and try again");
                return true;
            }
            else
            {
                return false;
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            ResizeChildrenControls();
        }

        private void ResizeControl(Rectangle originalSizeControl, Control control)
        {
            float xRatio = (float)(this.Width) / (float)(m_mainFormOriginalSize.Width);
            float yRatio = (float)(this.Height) / (float)(m_mainFormOriginalSize.Height);
            int newX = (int)(originalSizeControl.Location.X * xRatio);
            int newY = (int)(originalSizeControl.Location.Y * yRatio);
            int newWidth = (int)(originalSizeControl.Size.Width * xRatio);
            int newHeight = (int)(originalSizeControl.Size.Height * yRatio);

            control.Location = new Point(newX, newY);
            control.Size = new Size(newWidth, newHeight);
        }

        private void InitializeSizeControls()
        {
            m_mainFormOriginalSize = this.Size;

            m_txtTextBoxOriginalSize = new Rectangle(txtTextBox.Location.X,
                                                   txtTextBox.Location.Y,
                                                   txtTextBox.Width,
                                                   txtTextBox.Height);

            m_btnBrowseOriginalSize = new Rectangle(btnBrowse.Location.X,
                                                  btnBrowse.Location.Y,
                                                  btnBrowse.Width,
                                                  btnBrowse.Height);

            m_btnConvert_to_DeployOriginalSize = new Rectangle(btnConvert_TO_Deploy.Location.X,
                                                             btnConvert_TO_Deploy.Location.Y,
                                                             btnConvert_TO_Deploy.Width,
                                                             btnConvert_TO_Deploy.Height);

            m_btnConvert_From_DeployOriginalSize = new Rectangle(btnConvert_FROM_Deploy.Location.X,
                                                               btnConvert_FROM_Deploy.Location.Y,
                                                               btnConvert_FROM_Deploy.Width,
                                                               btnConvert_FROM_Deploy.Height);

            m_chkKeep_Initial_filesOriginalSize = new Rectangle(chkKeep_Initial_files.Location.X,
                                                              chkKeep_Initial_files.Location.Y,
                                                              chkKeep_Initial_files.Width,
                                                              chkKeep_Initial_files.Height);
            m_prbMyProgressBarOriginalSize = new Rectangle(prb_MyProgressBar.Location.X,
                                                           prb_MyProgressBar.Location.Y,
                                                           prb_MyProgressBar.Width,
                                                           prb_MyProgressBar.Height);
            m_lblPercentageLabelOriginalSize = new Rectangle(lblPercentageLabel.Location.X,
                                                           lblPercentageLabel.Location.Y,
                                                           lblPercentageLabel.Width,
                                                           lblPercentageLabel.Height);
            m_chkConvert_all_sub_dirsOriginalSize = new Rectangle(chkConvert_all_sub_dirs.Location.X,
                                                                  chkConvert_all_sub_dirs.Location.Y,
                                                                  chkConvert_all_sub_dirs.Width,
                                                                   chkConvert_all_sub_dirs.Height);
        }

        private void ResizeChildrenControls()
        {
            ResizeControl(m_txtTextBoxOriginalSize, txtTextBox);
            ResizeControl(m_btnBrowseOriginalSize, btnBrowse);
            ResizeControl(m_btnConvert_to_DeployOriginalSize, btnConvert_TO_Deploy);
            ResizeControl(m_btnConvert_From_DeployOriginalSize, btnConvert_FROM_Deploy);
            ResizeControl(m_chkKeep_Initial_filesOriginalSize, chkKeep_Initial_files);
            ResizeControl(m_prbMyProgressBarOriginalSize, prb_MyProgressBar);
            ResizeControl(m_lblPercentageLabelOriginalSize, lblPercentageLabel);
            ResizeControl(m_chkConvert_all_sub_dirsOriginalSize, chkConvert_all_sub_dirs);
        }

        private void GetProgressBar()
        {

            prb_MyProgressBar.Visible = true;
            lblPercentageLabel.Visible = true;
            for (int i = 0; i <= 100; i++)
            {

                prb_MyProgressBar.Value = i;
                Loading();
                prb_MyProgressBar.Refresh();
                lblPercentageLabel.Text = prb_MyProgressBar.Value.ToString() + " %";
                lblPercentageLabel.Update();
            }
            Display("Loading Completed");
            prb_MyProgressBar.Visible = false;
            lblPercentageLabel.Visible = false;
            prb_MyProgressBar.Value = 0;
            
        }

        private void Display(string text)
        {
            
            MessageBox.Show($@"{text}");
        }
        private void Loading()
        {
            Thread.Sleep(10);
        }
    }
}
