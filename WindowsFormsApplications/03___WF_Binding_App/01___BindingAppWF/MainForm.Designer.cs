namespace BindingDataWindowsFormsApp
{
    partial class FrmLocation
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
            this.chkOccupancyBox = new System.Windows.Forms.CheckBox();
            this.lblOccupancyNameBox = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // chkOccupancyBox
            // 
            this.chkOccupancyBox.AutoSize = true;
            this.chkOccupancyBox.Checked = true;
            this.chkOccupancyBox.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.chkOccupancyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkOccupancyBox.Location = new System.Drawing.Point(468, 100);
            this.chkOccupancyBox.Name = "chkOccupancyBox";
            this.chkOccupancyBox.Size = new System.Drawing.Size(253, 41);
            this.chkOccupancyBox.TabIndex = 0;
            this.chkOccupancyBox.Text = "chkOccupancy";
            this.chkOccupancyBox.UseVisualStyleBackColor = true;
            // 
            // lblOccupancyNameBox
            // 
            this.lblOccupancyNameBox.AutoSize = true;
            this.lblOccupancyNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOccupancyNameBox.Location = new System.Drawing.Point(65, 101);
            this.lblOccupancyNameBox.Name = "lblOccupancyNameBox";
            this.lblOccupancyNameBox.Size = new System.Drawing.Size(295, 37);
            this.lblOccupancyNameBox.TabIndex = 1;
            this.lblOccupancyNameBox.Text = "lblOccupancyName";
            // 
            // FrmLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(822, 238);
            this.Controls.Add(this.lblOccupancyNameBox);
            this.Controls.Add(this.chkOccupancyBox);
            this.Name = "FrmLocation";
            this.Text = "frmLocation ";
            this.Load += new System.EventHandler(this.FrmLocation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkOccupancyBox;
        private System.Windows.Forms.Label lblOccupancyNameBox;
    }
}

