namespace PictureSaver
{
    partial class PicSvrFrm
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
            this.LnkTb = new System.Windows.Forms.TextBox();
            this.SvDlBtn = new System.Windows.Forms.Button();
            this.FldrDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.UrlLbl = new System.Windows.Forms.Label();
            this.AlFlsPrgBr = new System.Windows.Forms.ProgressBar();
            this.FilePrgsLbl = new System.Windows.Forms.Label();
            this.OneFlPrgBr = new System.Windows.Forms.ProgressBar();
            this.FileNmLbl = new System.Windows.Forms.Label();
            this.PrgsLbl = new System.Windows.Forms.Label();
            this.FileLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LnkTb
            // 
            this.LnkTb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LnkTb.Location = new System.Drawing.Point(12, 58);
            this.LnkTb.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LnkTb.Name = "LnkTb";
            this.LnkTb.Size = new System.Drawing.Size(505, 22);
            this.LnkTb.TabIndex = 0;
            // 
            // SvDlBtn
            // 
            this.SvDlBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.SvDlBtn.Location = new System.Drawing.Point(157, 138);
            this.SvDlBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SvDlBtn.Name = "SvDlBtn";
            this.SvDlBtn.Size = new System.Drawing.Size(215, 53);
            this.SvDlBtn.TabIndex = 1;
            this.SvDlBtn.Text = "Save/Download";
            this.SvDlBtn.UseVisualStyleBackColor = true;
            this.SvDlBtn.Click += new System.EventHandler(this.SvDlBtn_Click);
            // 
            // UrlLbl
            // 
            this.UrlLbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.UrlLbl.AutoSize = true;
            this.UrlLbl.Location = new System.Drawing.Point(223, 25);
            this.UrlLbl.Name = "UrlLbl";
            this.UrlLbl.Size = new System.Drawing.Size(96, 17);
            this.UrlLbl.TabIndex = 2;
            this.UrlLbl.Text = "Input Url Here";
            // 
            // AlFlsPrgBr
            // 
            this.AlFlsPrgBr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AlFlsPrgBr.Location = new System.Drawing.Point(12, 318);
            this.AlFlsPrgBr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AlFlsPrgBr.Name = "AlFlsPrgBr";
            this.AlFlsPrgBr.Size = new System.Drawing.Size(507, 23);
            this.AlFlsPrgBr.Step = 1;
            this.AlFlsPrgBr.TabIndex = 3;
            this.AlFlsPrgBr.Click += new System.EventHandler(this.AlFlsPrgBr_Click);
            // 
            // FilePrgsLbl
            // 
            this.FilePrgsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FilePrgsLbl.AutoSize = true;
            this.FilePrgsLbl.BackColor = System.Drawing.Color.Transparent;
            this.FilePrgsLbl.Location = new System.Drawing.Point(155, 297);
            this.FilePrgsLbl.Name = "FilePrgsLbl";
            this.FilePrgsLbl.Size = new System.Drawing.Size(238, 17);
            this.FilePrgsLbl.TabIndex = 4;
            this.FilePrgsLbl.Text = "0% Completed 0/0 Files Downloaded";
            // 
            // OneFlPrgBr
            // 
            this.OneFlPrgBr.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OneFlPrgBr.Location = new System.Drawing.Point(12, 271);
            this.OneFlPrgBr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OneFlPrgBr.Name = "OneFlPrgBr";
            this.OneFlPrgBr.Size = new System.Drawing.Size(507, 23);
            this.OneFlPrgBr.TabIndex = 5;
            // 
            // FileNmLbl
            // 
            this.FileNmLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileNmLbl.AutoSize = true;
            this.FileNmLbl.BackColor = System.Drawing.Color.Transparent;
            this.FileNmLbl.Location = new System.Drawing.Point(155, 251);
            this.FileNmLbl.Name = "FileNmLbl";
            this.FileNmLbl.Size = new System.Drawing.Size(138, 17);
            this.FileNmLbl.TabIndex = 6;
            this.FileNmLbl.Text = ".jpg/jpeg/gif/img/bmp";
            // 
            // PrgsLbl
            // 
            this.PrgsLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PrgsLbl.AutoSize = true;
            this.PrgsLbl.Location = new System.Drawing.Point(12, 297);
            this.PrgsLbl.Name = "PrgsLbl";
            this.PrgsLbl.Size = new System.Drawing.Size(65, 17);
            this.PrgsLbl.TabIndex = 8;
            this.PrgsLbl.Text = "Progress";
            // 
            // FileLbl
            // 
            this.FileLbl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FileLbl.AutoSize = true;
            this.FileLbl.Location = new System.Drawing.Point(12, 251);
            this.FileLbl.Name = "FileLbl";
            this.FileLbl.Size = new System.Drawing.Size(30, 17);
            this.FileLbl.TabIndex = 9;
            this.FileLbl.Text = "File";
            // 
            // PicSvrFrm
            // 
            this.AcceptButton = this.SvDlBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 359);
            this.Controls.Add(this.FileLbl);
            this.Controls.Add(this.PrgsLbl);
            this.Controls.Add(this.FileNmLbl);
            this.Controls.Add(this.OneFlPrgBr);
            this.Controls.Add(this.FilePrgsLbl);
            this.Controls.Add(this.AlFlsPrgBr);
            this.Controls.Add(this.UrlLbl);
            this.Controls.Add(this.SvDlBtn);
            this.Controls.Add(this.LnkTb);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "PicSvrFrm";
            this.Text = "Picture Saver";
            this.Load += new System.EventHandler(this.PicSvrFrm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LnkTb;
        private System.Windows.Forms.Button SvDlBtn;
        private System.Windows.Forms.FolderBrowserDialog FldrDlg;
        private System.Windows.Forms.Label UrlLbl;
        private System.Windows.Forms.ProgressBar AlFlsPrgBr;
        private System.Windows.Forms.Label FilePrgsLbl;
        private System.Windows.Forms.ProgressBar OneFlPrgBr;
        private System.Windows.Forms.Label FileNmLbl;
        private System.Windows.Forms.Label PrgsLbl;
        private System.Windows.Forms.Label FileLbl;
    }
}

