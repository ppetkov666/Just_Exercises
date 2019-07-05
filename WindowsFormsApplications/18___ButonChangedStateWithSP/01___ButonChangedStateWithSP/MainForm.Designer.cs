namespace _01___WFDinamicallyCreatedButtons
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
            this.text_box = new System.Windows.Forms.TextBox();
            this.bButtonClick = new System.Windows.Forms.Button();
            this.label = new System.Windows.Forms.Label();
            this.b_status = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // text_box
            // 
            this.text_box.Location = new System.Drawing.Point(96, 73);
            this.text_box.Margin = new System.Windows.Forms.Padding(4);
            this.text_box.Name = "text_box";
            this.text_box.Size = new System.Drawing.Size(148, 22);
            this.text_box.TabIndex = 0;
            // 
            // bButtonClick
            // 
            this.bButtonClick.Location = new System.Drawing.Point(96, 194);
            this.bButtonClick.Margin = new System.Windows.Forms.Padding(4);
            this.bButtonClick.Name = "bButtonClick";
            this.bButtonClick.Size = new System.Drawing.Size(148, 28);
            this.bButtonClick.TabIndex = 1;
            this.bButtonClick.Text = "Click";
            this.bButtonClick.UseVisualStyleBackColor = true;
            this.bButtonClick.Click += new System.EventHandler(this.bButtonClick_Click);
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(93, 34);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(151, 17);
            this.label.TabIndex = 2;
            this.label.Text = "Enter \"active\" or \"hide\"";
            // 
            // b_status
            // 
            this.b_status.Location = new System.Drawing.Point(96, 124);
            this.b_status.Name = "b_status";
            this.b_status.Size = new System.Drawing.Size(148, 31);
            this.b_status.TabIndex = 3;
            this.b_status.Text = "status";
            this.b_status.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 251);
            this.Controls.Add(this.b_status);
            this.Controls.Add(this.label);
            this.Controls.Add(this.bButtonClick);
            this.Controls.Add(this.text_box);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox text_box;
        private System.Windows.Forms.Button bButtonClick;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button b_status;
    }
}

