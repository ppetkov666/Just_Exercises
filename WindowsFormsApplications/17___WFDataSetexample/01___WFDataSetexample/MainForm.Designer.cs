namespace _01___WFDataSetexample
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
            this.TextBoxTowns = new System.Windows.Forms.TextBox();
            this.bShowTownName = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.tbTextBoxTownName = new System.Windows.Forms.TextBox();
            this.lblTownName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxTowns
            // 
            this.TextBoxTowns.Location = new System.Drawing.Point(198, 103);
            this.TextBoxTowns.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TextBoxTowns.Name = "TextBoxTowns";
            this.TextBoxTowns.Size = new System.Drawing.Size(210, 26);
            this.TextBoxTowns.TabIndex = 0;
            // 
            // bShowTownName
            // 
            this.bShowTownName.Location = new System.Drawing.Point(198, 180);
            this.bShowTownName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.bShowTownName.Name = "bShowTownName";
            this.bShowTownName.Size = new System.Drawing.Size(212, 71);
            this.bShowTownName.TabIndex = 1;
            this.bShowTownName.Text = "Show Town Name";
            this.bShowTownName.UseVisualStyleBackColor = true;
            this.bShowTownName.Click += new System.EventHandler(this.BShowTownName_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(18, 108);
            this.lblId.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(68, 20);
            this.lblId.TabIndex = 2;
            this.lblId.Text = "Town ID";
            // 
            // tbTextBoxTownName
            // 
            this.tbTextBoxTownName.Location = new System.Drawing.Point(198, 297);
            this.tbTextBoxTownName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tbTextBoxTownName.Name = "tbTextBoxTownName";
            this.tbTextBoxTownName.Size = new System.Drawing.Size(210, 26);
            this.tbTextBoxTownName.TabIndex = 3;
            this.tbTextBoxTownName.TextChanged += new System.EventHandler(this.TbTextBoxTownName_TextChanged);
            // 
            // lblTownName
            // 
            this.lblTownName.AutoSize = true;
            this.lblTownName.Location = new System.Drawing.Point(22, 297);
            this.lblTownName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTownName.Name = "lblTownName";
            this.lblTownName.Size = new System.Drawing.Size(93, 20);
            this.lblTownName.TabIndex = 4;
            this.lblTownName.Text = "Town Name";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 449);
            this.Controls.Add(this.lblTownName);
            this.Controls.Add(this.tbTextBoxTownName);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.bShowTownName);
            this.Controls.Add(this.TextBoxTowns);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxTowns;
        private System.Windows.Forms.Button bShowTownName;
        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.TextBox tbTextBoxTownName;
        private System.Windows.Forms.Label lblTownName;
    }
}

