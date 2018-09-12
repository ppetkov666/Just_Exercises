namespace _07___
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
            this.lblShowOccupancy = new System.Windows.Forms.Label();
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblShowOccupancy
            // 
            this.lblShowOccupancy.AutoSize = true;
            this.lblShowOccupancy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShowOccupancy.Location = new System.Drawing.Point(126, 101);
            this.lblShowOccupancy.Name = "lblShowOccupancy";
            this.lblShowOccupancy.Size = new System.Drawing.Size(266, 37);
            this.lblShowOccupancy.TabIndex = 0;
            this.lblShowOccupancy.Text = "Show Occupancy";
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox.Location = new System.Drawing.Point(415, 101);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(302, 41);
            this.checkBox.TabIndex = 1;
            this.checkBox.Text = "Check Occupancy";
            this.checkBox.UseVisualStyleBackColor = true;
            this.checkBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // CheckForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 229);
            this.Controls.Add(this.checkBox);
            this.Controls.Add(this.lblShowOccupancy);
            this.Name = "CheckForm";
            this.Text = "CheckForm";
            this.Load += new System.EventHandler(this.CheckForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShowOccupancy;
        private System.Windows.Forms.CheckBox checkBox;
    }
}

