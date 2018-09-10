namespace _04___AndAnotherExample
{
    partial class CheckForm
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
            this.tbInputData = new System.Windows.Forms.TextBox();
            this.SetMyNameButton = new System.Windows.Forms.Button();
            this.ShowMyNameButton = new System.Windows.Forms.Button();
            this.bllPrintMyName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbInputData
            // 
            this.tbInputData.Location = new System.Drawing.Point(140, 62);
            this.tbInputData.Name = "tbInputData";
            this.tbInputData.Size = new System.Drawing.Size(362, 26);
            this.tbInputData.TabIndex = 0;
            // 
            // SetMyNameButton
            // 
            this.SetMyNameButton.Location = new System.Drawing.Point(140, 158);
            this.SetMyNameButton.Name = "SetMyNameButton";
            this.SetMyNameButton.Size = new System.Drawing.Size(362, 69);
            this.SetMyNameButton.TabIndex = 2;
            this.SetMyNameButton.Text = "Set Default Name";
            this.SetMyNameButton.UseVisualStyleBackColor = true;
            this.SetMyNameButton.Click += new System.EventHandler(this.SetMyNameButton_Click);
            // 
            // ShowMyNameButton
            // 
            this.ShowMyNameButton.Location = new System.Drawing.Point(140, 292);
            this.ShowMyNameButton.Name = "ShowMyNameButton";
            this.ShowMyNameButton.Size = new System.Drawing.Size(362, 69);
            this.ShowMyNameButton.TabIndex = 3;
            this.ShowMyNameButton.Text = "Show My Name";
            this.ShowMyNameButton.UseVisualStyleBackColor = true;
            this.ShowMyNameButton.Click += new System.EventHandler(this.ShowMyNameButton_Click);
            // 
            // bllPrintMyName
            // 
            this.bllPrintMyName.AutoSize = true;
            this.bllPrintMyName.Location = new System.Drawing.Point(585, 62);
            this.bllPrintMyName.Name = "bllPrintMyName";
            this.bllPrintMyName.Size = new System.Drawing.Size(130, 20);
            this.bllPrintMyName.TabIndex = 1;
            this.bllPrintMyName.Text = "Display My Name";
            this.bllPrintMyName.Click += new System.EventHandler(this.PrintMyNamelabel_Click);
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 449);
            this.Controls.Add(this.bllPrintMyName);
            this.Controls.Add(this.ShowMyNameButton);
            this.Controls.Add(this.SetMyNameButton);
            this.Controls.Add(this.tbInputData);
            this.Name = "CheckForm";
            this.Text = "CheckForm";
            this.Load += new System.EventHandler(this.CheckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbInputData;
        private System.Windows.Forms.Button SetMyNameButton;
        private System.Windows.Forms.Button ShowMyNameButton;
        private System.Windows.Forms.Label bllPrintMyName;
    }
}

