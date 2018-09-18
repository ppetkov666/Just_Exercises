namespace _15___BindingControlToList
{
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
            this.bShow = new System.Windows.Forms.Button();
            this.ComboBoxTowns = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bShow
            // 
            this.bShow.Location = new System.Drawing.Point(80, 183);
            this.bShow.Name = "bShow";
            this.bShow.Size = new System.Drawing.Size(197, 66);
            this.bShow.TabIndex = 0;
            this.bShow.Text = "Show";
            this.bShow.UseVisualStyleBackColor = true;
            this.bShow.Click += new System.EventHandler(this.bShow_Click);
            // 
            // ComboBoxTowns
            // 
            this.ComboBoxTowns.FormattingEnabled = true;
            this.ComboBoxTowns.Location = new System.Drawing.Point(80, 72);
            this.ComboBoxTowns.Name = "ComboBoxTowns";
            this.ComboBoxTowns.Size = new System.Drawing.Size(197, 21);
            this.ComboBoxTowns.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 355);
            this.Controls.Add(this.ComboBoxTowns);
            this.Controls.Add(this.bShow);
            this.Name = "MainForm";
            this.Text = "ComplexBinding";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bShow;
        private System.Windows.Forms.ComboBox ComboBoxTowns;
    }
}

