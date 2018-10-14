

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
            this.txtTextBox = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.btnConvert_TO_Deploy = new System.Windows.Forms.Button();
            this.btnConvert_FROM_Deploy = new System.Windows.Forms.Button();
            this.chkKeep_Initial_files = new System.Windows.Forms.CheckBox();
            this.chkConvert_all_sub_dirs = new System.Windows.Forms.CheckBox();
            this.lblPercentageLabel = new System.Windows.Forms.Label();
            this.prb_MyProgressBar = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // txtTextBox
            // 
            this.txtTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.txtTextBox.Location = new System.Drawing.Point(15, 30);
            this.txtTextBox.Name = "txtTextBox";
            this.txtTextBox.Size = new System.Drawing.Size(400, 32);
            this.txtTextBox.TabIndex = 0;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnBrowse.Location = new System.Drawing.Point(15, 191);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(400, 40);
            this.btnBrowse.TabIndex = 1;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // btnConvert_TO_Deploy
            // 
            this.btnConvert_TO_Deploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnConvert_TO_Deploy.Location = new System.Drawing.Point(15, 415);
            this.btnConvert_TO_Deploy.Name = "btnConvert_TO_Deploy";
            this.btnConvert_TO_Deploy.Size = new System.Drawing.Size(400, 40);
            this.btnConvert_TO_Deploy.TabIndex = 2;
            this.btnConvert_TO_Deploy.Text = "Convert TO Deploy";
            this.btnConvert_TO_Deploy.UseVisualStyleBackColor = true;
            this.btnConvert_TO_Deploy.Click += new System.EventHandler(this.btnConvert_TO_Deploy_Click);
            // 
            // btnConvert_FROM_Deploy
            // 
            this.btnConvert_FROM_Deploy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.btnConvert_FROM_Deploy.Location = new System.Drawing.Point(15, 500);
            this.btnConvert_FROM_Deploy.Name = "btnConvert_FROM_Deploy";
            this.btnConvert_FROM_Deploy.Size = new System.Drawing.Size(400, 40);
            this.btnConvert_FROM_Deploy.TabIndex = 3;
            this.btnConvert_FROM_Deploy.Text = "Convert FROM Deploy";
            this.btnConvert_FROM_Deploy.UseVisualStyleBackColor = true;
            this.btnConvert_FROM_Deploy.Click += new System.EventHandler(this.btnConvert_FROM_Deploy_Click);
            // 
            // chkKeep_Initial_files
            // 
            this.chkKeep_Initial_files.AutoSize = true;
            this.chkKeep_Initial_files.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chkKeep_Initial_files.Location = new System.Drawing.Point(15, 267);
            this.chkKeep_Initial_files.Name = "chkKeep_Initial_files";
            this.chkKeep_Initial_files.Size = new System.Drawing.Size(191, 30);
            this.chkKeep_Initial_files.TabIndex = 4;
            this.chkKeep_Initial_files.Text = "Keep Initial Files";
            this.chkKeep_Initial_files.UseVisualStyleBackColor = true;
            // 
            // chkConvert_all_sub_dirs
            // 
            this.chkConvert_all_sub_dirs.AutoSize = true;
            this.chkConvert_all_sub_dirs.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.chkConvert_all_sub_dirs.Location = new System.Drawing.Point(15, 329);
            this.chkConvert_all_sub_dirs.Name = "chkConvert_all_sub_dirs";
            this.chkConvert_all_sub_dirs.Size = new System.Drawing.Size(293, 30);
            this.chkConvert_all_sub_dirs.TabIndex = 5;
            this.chkConvert_all_sub_dirs.Text = "Convert All Sub Directories";
            this.chkConvert_all_sub_dirs.UseVisualStyleBackColor = true;
            // 
            // lblPercentageLabel
            // 
            this.lblPercentageLabel.AutoSize = true;
            this.lblPercentageLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPercentageLabel.Location = new System.Drawing.Point(351, 104);
            this.lblPercentageLabel.Name = "lblPercentageLabel";
            this.lblPercentageLabel.Size = new System.Drawing.Size(25, 24);
            this.lblPercentageLabel.TabIndex = 7;
            this.lblPercentageLabel.Text = "%";
            this.lblPercentageLabel.Visible = false;
            // 
            // prb_MyProgressBar
            // 
            this.prb_MyProgressBar.Location = new System.Drawing.Point(15, 104);
            this.prb_MyProgressBar.Name = "prb_MyProgressBar";
            this.prb_MyProgressBar.Size = new System.Drawing.Size(330, 40);
            this.prb_MyProgressBar.TabIndex = 6;
            this.prb_MyProgressBar.Visible = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(434, 611);
            this.Controls.Add(this.lblPercentageLabel);
            this.Controls.Add(this.prb_MyProgressBar);
            this.Controls.Add(this.chkConvert_all_sub_dirs);
            this.Controls.Add(this.chkKeep_Initial_files);
            this.Controls.Add(this.btnConvert_FROM_Deploy);
            this.Controls.Add(this.btnConvert_TO_Deploy);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtTextBox);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
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
        private Label lblPercentageLabel;
        private ProgressBar prb_MyProgressBar;
    }
}

