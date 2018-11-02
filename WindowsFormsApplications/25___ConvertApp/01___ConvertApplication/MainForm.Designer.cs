

namespace ConvertApplication
{
    using System;
    using System.ComponentModel;
    using System.Windows.Forms;
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
            this.txtTextBox = new TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnConvert_TO_Deploy = new System.Windows.Forms.Button();
            this.btnConvert_FROM_Deploy = new System.Windows.Forms.Button();
            this.chkKeep_Initial_files = new System.Windows.Forms.CheckBox();
            this.chkConvert_all_sub_dirs = new System.Windows.Forms.CheckBox();
            this.prb_Loading = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtTextBox
            // 
            this.txtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTextBox.Location = new System.Drawing.Point(22, 46);
            this.txtTextBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(598, 44);
            this.txtTextBox.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBrowse.Location = new System.Drawing.Point(22, 294);
            this.btnBrowse.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(600, 62);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnConvert_TO_Deploy
            // 
            this.btnConvert_TO_Deploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnConvert_TO_Deploy.Location = new System.Drawing.Point(22, 638);
            this.btnConvert_TO_Deploy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvert_TO_Deploy.Name = "btnConvert_TO_Deploy";
            this.btnConvert_TO_Deploy.Size = new System.Drawing.Size(600, 62);
            this.btnConvert_TO_Deploy.TabIndex = 2;
            this.btnConvert_TO_Deploy.Text = "Convert TO Deploy";
            this.btnConvert_TO_Deploy.UseVisualStyleBackColor = true;
            this.btnConvert_TO_Deploy.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnConvert_FROM_Deploy
            // 
            this.btnConvert_FROM_Deploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnConvert_FROM_Deploy.Location = new System.Drawing.Point(22, 769);
            this.btnConvert_FROM_Deploy.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnConvert_FROM_Deploy.Name = "btnConvert_FROM_Deploy";
            this.btnConvert_FROM_Deploy.Size = new System.Drawing.Size(600, 62);
            this.btnConvert_FROM_Deploy.TabIndex = 3;
            this.btnConvert_FROM_Deploy.Text = "Convert FROM Deploy";
            this.btnConvert_FROM_Deploy.UseVisualStyleBackColor = true;
            this.btnConvert_FROM_Deploy.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // chkKeep_Initial_files
            // 
            this.chkKeep_Initial_files.AutoSize = true;
            this.chkKeep_Initial_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chkKeep_Initial_files.Location = new System.Drawing.Point(22, 411);
            this.chkKeep_Initial_files.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkKeep_Initial_files.Name = "chkKeep_Initial_files";
            this.chkKeep_Initial_files.Size = new System.Drawing.Size(275, 41);
            this.chkKeep_Initial_files.TabIndex = 4;
            this.chkKeep_Initial_files.Text = "Keep Initial Files";
            this.chkKeep_Initial_files.UseVisualStyleBackColor = true;
            // 
            // chkConvert_all_sub_dirs
            // 
            this.chkConvert_all_sub_dirs.AutoSize = true;
            this.chkConvert_all_sub_dirs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chkConvert_all_sub_dirs.Location = new System.Drawing.Point(22, 506);
            this.chkConvert_all_sub_dirs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.chkConvert_all_sub_dirs.Name = "chkConvert_all_sub_dirs";
            this.chkConvert_all_sub_dirs.Size = new System.Drawing.Size(426, 41);
            this.chkConvert_all_sub_dirs.TabIndex = 5;
            this.chkConvert_all_sub_dirs.Text = "Convert All Sub Directories";
            this.chkConvert_all_sub_dirs.UseVisualStyleBackColor = true;
            // 
            // prb_Loading
            // 
            this.prb_Loading.Location = new System.Drawing.Point(22, 160);
            this.prb_Loading.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.prb_Loading.Name = "prb_Loading";
            this.prb_Loading.Size = new System.Drawing.Size(600, 62);
            this.prb_Loading.TabIndex = 6;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(651, 940);
            this.Controls.Add(this.prb_Loading);
            this.Controls.Add(this.chkConvert_all_sub_dirs);
            this.Controls.Add(this.chkKeep_Initial_files);
            this.Controls.Add(this.btnConvert_FROM_Deploy);
            this.Controls.Add(this.btnConvert_TO_Deploy);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtTextBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtTextBox;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Button btnConvert_TO_Deploy;
        private System.Windows.Forms.Button btnConvert_FROM_Deploy;
        private System.Windows.Forms.CheckBox chkKeep_Initial_files;
        private CheckBox chkConvert_all_sub_dirs;
        private ProgressBar prb_Loading;
    }
}

